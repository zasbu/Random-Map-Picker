using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;

namespace MapPicker
{
    public partial class Form1 : Form
    {
        private List<string> shuffledMaps = new List<string>();
        private DataTable? surfMaps = null;
        private Dictionary<int, string> colorGradient = new Dictionary<int, string>();
        private Random random;
        private string? lastGeneratedMap = null;

        public Form1()
        {
            LoadBackgroundImage();
            InitializeComponent();
            this.DoubleBuffered = true;
            random = new Random();
            InitializeUI();
            InitializeDataAsync();
        }

        private async void InitializeDataAsync()
        {
            await InitializeData();
        }

        private async Task InitializeData()
        {
            colorGradient = new Dictionary<int, string>
            {
                { 1, "#00FF00" },
                { 2, "#66FF66" },
                { 3, "#FFFF66" },
                { 4, "#FFCC00" },
                { 5, "#FF9933" },
                { 6, "#FF6666" },
                { 7, "#FF3333" },
                { 8, "#990000" }
            };

            string url = "https://docs.google.com/spreadsheets/d/1oXU6UXGPdgdqRiAjjD_5c1WfI6PY6ML4/export?format=xlsx";
            surfMaps = await LoadExcelData(url);

            if (surfMaps != null)
            {
                UpdateShuffledMaps();
                foreach (var map in shuffledMaps)
                {
                    Console.WriteLine($"Map: {map}");
                }
            }
            else
            {
                MessageBox.Show("Failed to load data from the provided URL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<DataTable?> LoadExcelData(string url)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    var stream = await response.Content.ReadAsStreamAsync();

                    using (var memoryStream = new System.IO.MemoryStream())
                    {
                        await stream.CopyToAsync(memoryStream);
                        memoryStream.Position = 0;

                        System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

                        using (var reader = ExcelReaderFactory.CreateReader(memoryStream))
                        {
                            var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });

                            return result.Tables[0];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void InitializeUI()
        {
            // Hide labels initially
            lblMapName.Visible = false;
            lblTier.Visible = false;
            lblType.Visible = false;
            lblTierNumber.Visible = false;

            // Disable resizing
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            btnGenerate.Click += async (sender, args) => await PickRandomMap();
        }

        private void LoadBackgroundImage()
        {
            // Load background image from new URL
            string imageUrl = "https://raw.githubusercontent.com/zasbu/SurfMapsScreenshots/main/screenshots/background.png";
            using (HttpClient client = new HttpClient())
            {
                var response = client.GetAsync(imageUrl).Result;
                response.EnsureSuccessStatusCode();
                using (var stream = response.Content.ReadAsStream())
                {
                    var backgroundImage = Image.FromStream(stream);
                    this.BackgroundImage = backgroundImage;
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
        }

        private void UpdateShuffledMaps()
        {
            if (surfMaps == null)
            {
                Console.WriteLine("surfMaps is null. Data might not have been loaded correctly.");
                shuffledMaps = new List<string>();
                return;
            }

            var includedTiers = new List<int>();
            for (int i = 1; i <= 8; i++)
            {
                var controls = Controls.Find($"chkTier{i}", true);
                CheckBox? checkBox = controls.FirstOrDefault() as CheckBox;

                if (checkBox != null && checkBox.Checked)
                {
                    includedTiers.Add(i);
                }
            }

            var includedTypes = new List<string>();
            if (chkStaged.Checked)
            {
                includedTypes.Add("Staged");
                includedTypes.Add("Staged-Linear");
            }
            if (chkLinear.Checked)
            {
                includedTypes.Add("Linear");
            }

            List<string> filteredMaps = new List<string>();
            if (includedTiers.Count > 0 && includedTypes.Count > 0)
            {
                var tempFilteredMaps = surfMaps.AsEnumerable()
                    .Where(row =>
                    {
                        if (int.TryParse(row["Tier"]?.ToString(), out int tier) && includedTiers.Contains(tier))
                        {
                            var type = row["Type"]?.ToString();
                            return type != null && includedTypes.Contains(type);
                        }
                        else
                        {
                            Console.WriteLine($"Invalid tier or type value: {row["Tier"]}, {row["Type"]}");
                            return false;
                        }
                    })
                    .Select(row => row["Map name"]?.ToString())
                    .Where(map => !string.IsNullOrEmpty(map))
                    .ToList();

                filteredMaps = tempFilteredMaps.Cast<string>().ToList();
            }

            if (filteredMaps.Count > 0)
            {
                shuffledMaps = ShuffleList(filteredMaps);
            }
            else
            {
                Console.WriteLine("No maps found for the selected tiers and types.");
                shuffledMaps = new List<string>();
            }

            Console.WriteLine($"Updated shuffled maps count: {shuffledMaps.Count}");
        }

        private async Task PickRandomMap()
        {
            btnGenerate.Enabled = false;

            UpdateShuffledMaps();

            if (surfMaps == null || shuffledMaps == null || shuffledMaps.Count == 0)
            {
                DisplayMessage("No tiers selected!");
                btnGenerate.Enabled = true;
                return;
            }

            string selectedMap;

            do
            {
                selectedMap = shuffledMaps.Last();
                shuffledMaps.Remove(selectedMap);

                if (shuffledMaps.Count == 0)
                {
                    UpdateShuffledMaps();
                }
            } while (selectedMap == lastGeneratedMap && shuffledMaps.Count > 1);

            lastGeneratedMap = selectedMap;

            var mapData = surfMaps.AsEnumerable().FirstOrDefault(row => row["Map name"]?.ToString() == selectedMap);
            if (mapData != null)
            {
                DisplayMapData(mapData);
                await LoadMapPreview(selectedMap);
            }
            else
            {
                DisplayMessage("Map data not found!");
            }

            btnGenerate.Enabled = true;
        }

        private void DisplayMapData(DataRow mapData)
        {
            var mapTier = Convert.ToInt32(mapData["Tier"]?.ToString() ?? "0");
            var mapType = mapData["Type"]?.ToString();

            lblMapName.Text = mapData["Map name"]?.ToString() ?? "Unknown Map";
            lblMapName.Visible = true;
            CenterControl(lblMapName);

            lblTier.Text = "Tier: ";
            lblTierNumber.Text = mapTier.ToString();
            lblTierNumber.ForeColor = ColorTranslator.FromHtml(colorGradient[mapTier]);
            lblTier.Visible = true;
            lblTierNumber.Visible = true;
            CenterControl(lblTier, lblTierNumber);

            lblType.Text = mapType ?? "Unknown Type";
            lblType.Visible = true;
            CenterControl(lblType);
        }

        private async Task LoadMapPreview(string mapName)
        {
            // Attempt to load image from primary URL
            string primaryImageUrl = $"https://raw.githubusercontent.com/Sayt123/SurfMapPics/Maps-and-bonuses/csgo/{mapName}.jpg";
            if (await TryLoadImageFromUrl(primaryImageUrl))
            {
                return;
            }

            // Attempt to load image from secondary URL
            string secondaryImageUrl = $"https://raw.githubusercontent.com/zasbu/SurfMapsScreenshots/main/screenshots/{mapName}.jpg";
            if (await TryLoadImageFromUrl(secondaryImageUrl))
            {
                return;
            }

            // If both attempts fail, do nothing
            picMapPreview.Image = null;
        }

        private async Task<bool> TryLoadImageFromUrl(string imageUrl)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetAsync(imageUrl);
                    response.EnsureSuccessStatusCode();
                    using (var stream = await response.Content.ReadAsStreamAsync())
                    {
                        var image = Image.FromStream(stream);
                        picMapPreview.Image = image;
                        picMapPreview.Visible = true;
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        private void DisplayMessage(string message)
        {
            lblMapName.Text = message;
            lblMapName.Visible = true;
            CenterControl(lblMapName);
            lblTier.Text = "";
            lblTierNumber.Text = "";
            lblType.Text = "";
            picMapPreview.Image = null; // Clear the map preview
        }

        private void CenterControl(Control control, Control? secondaryControl = null)
        {
            if (secondaryControl == null)
            {
                control.Location = new Point((this.ClientSize.Width - control.Width) / 2, control.Location.Y);
            }
            else
            {
                int totalWidth = control.Width + secondaryControl.Width;
                int startX = (this.ClientSize.Width - totalWidth) / 2;
                control.Location = new Point(startX, control.Location.Y);
                secondaryControl.Location = new Point(startX + control.Width, control.Location.Y);
            }
        }

        private List<T> ShuffleList<T>(List<T> list)
        {
            var shuffledList = new List<T>(list);
            for (int i = shuffledList.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                T temp = shuffledList[i];
                shuffledList[i] = shuffledList[j];
                shuffledList[j] = temp;
            }
            return shuffledList;
        }

        private void PicMapPreview_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;

            Rectangle rect = new Rectangle(0, 0, picMapPreview.Width, picMapPreview.Height);
            int radius = 40;

            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.StartFigure();
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
                path.CloseFigure();

                using (SolidBrush brush = new SolidBrush(picMapPreview.BackColor))
                {
                    graphics.FillPath(brush, path);
                }

                picMapPreview.Region = new Region(path);
            }
        }
    }
}
