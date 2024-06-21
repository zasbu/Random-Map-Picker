namespace MapPicker
{
    partial class Form1
    {
        private System.Windows.Forms.Label lblMapName;
        private System.Windows.Forms.Label lblTier;
        private System.Windows.Forms.Label lblTierNumber;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.CheckBox chkTier1;
        private System.Windows.Forms.CheckBox chkTier2;
        private System.Windows.Forms.CheckBox chkTier3;
        private System.Windows.Forms.CheckBox chkTier4;
        private System.Windows.Forms.CheckBox chkTier5;
        private System.Windows.Forms.CheckBox chkTier6;
        private System.Windows.Forms.CheckBox chkTier7;
        private System.Windows.Forms.CheckBox chkTier8;
        private System.Windows.Forms.CheckBox chkStaged;
        private System.Windows.Forms.CheckBox chkLinear;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.PictureBox picMapPreview;

        private void InitializeComponent()
        {
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(45, 45, 48); // Dark background color
            this.ForeColor = System.Drawing.Color.White; // White text color

            this.lblMapName = new System.Windows.Forms.Label();
            this.lblTier = new System.Windows.Forms.Label();
            this.lblTierNumber = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.chkTier1 = new System.Windows.Forms.CheckBox();
            this.chkTier2 = new System.Windows.Forms.CheckBox();
            this.chkTier3 = new System.Windows.Forms.CheckBox();
            this.chkTier4 = new System.Windows.Forms.CheckBox();
            this.chkTier5 = new System.Windows.Forms.CheckBox();
            this.chkTier6 = new System.Windows.Forms.CheckBox();
            this.chkTier7 = new System.Windows.Forms.CheckBox();
            this.chkTier8 = new System.Windows.Forms.CheckBox();
            this.chkStaged = new System.Windows.Forms.CheckBox();
            this.chkLinear = new System.Windows.Forms.CheckBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.picMapPreview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMapPreview)).BeginInit();
            this.SuspendLayout();

            // 
            // lblMapName
            // 
            this.lblMapName.AutoSize = true;
            this.lblMapName.BackColor = System.Drawing.Color.Transparent;
            this.lblMapName.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMapName.ForeColor = System.Drawing.Color.White; // White text color
            this.lblMapName.Location = new System.Drawing.Point((this.ClientSize.Width - this.lblMapName.Width) / 2, 40); // Centered horizontally
            this.lblMapName.Name = "lblMapName";
            this.lblMapName.Size = new System.Drawing.Size(128, 29);
            this.lblMapName.TabIndex = 0;
            this.lblMapName.Text = "Map Name";
            this.lblMapName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblTier
            // 
            this.lblTier.AutoSize = true;
            this.lblTier.BackColor = System.Drawing.Color.Transparent;
            this.lblTier.Font = new System.Drawing.Font("Helvetica", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTier.ForeColor = System.Drawing.Color.White; // White text color
            this.lblTier.Location = new System.Drawing.Point((this.ClientSize.Width - this.lblTier.Width - this.lblTierNumber.Width) / 2, 80); // Centered with lblTierNumber
            this.lblTier.Name = "lblTier";
            this.lblTier.Size = new System.Drawing.Size(43, 23);
            this.lblTier.TabIndex = 1;
            this.lblTier.Text = "Tier";
            this.lblTier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblTierNumber
            // 
            this.lblTierNumber.AutoSize = true;
            this.lblTierNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblTierNumber.Font = new System.Drawing.Font("Helvetica", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTierNumber.ForeColor = System.Drawing.Color.Red;
            this.lblTierNumber.Location = new System.Drawing.Point((this.ClientSize.Width - this.lblTier.Width - this.lblTierNumber.Width) / 2 + this.lblTier.Width, 80); // Centered with lblTier
            this.lblTierNumber.Name = "lblTierNumber";
            this.lblTierNumber.Size = new System.Drawing.Size(30, 23);
            this.lblTierNumber.TabIndex = 1;
            this.lblTierNumber.Text = " 3";
            this.lblTierNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.Transparent;
            this.lblType.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.White; // White text color
            this.lblType.Location = new System.Drawing.Point((this.ClientSize.Width - this.lblType.Width) / 2, 100); // Centered horizontally
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(45, 19);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // chkTier1
            // 
            this.chkTier1.AutoSize = true;
            this.chkTier1.BackColor = System.Drawing.Color.Transparent;
            this.chkTier1.Font = new System.Drawing.Font("Helvetica", 8F);
            this.chkTier1.ForeColor = System.Drawing.Color.White; // White text color
            this.chkTier1.Location = new System.Drawing.Point(0, 0);
            this.chkTier1.Name = "chkTier1";
            this.chkTier1.Size = new System.Drawing.Size(55, 18);
            this.chkTier1.TabIndex = 3;
            this.chkTier1.Text = "Tier 1";
            this.chkTier1.UseVisualStyleBackColor = true;
            this.chkTier1.Checked = true;

            // 
            // chkTier2
            // 
            this.chkTier2.AutoSize = true;
            this.chkTier2.BackColor = System.Drawing.Color.Transparent;
            this.chkTier2.Font = new System.Drawing.Font("Helvetica", 8F);
            this.chkTier2.ForeColor = System.Drawing.Color.White; // White text color
            this.chkTier2.Location = new System.Drawing.Point(0, 0);
            this.chkTier2.Name = "chkTier2";
            this.chkTier2.Size = new System.Drawing.Size(55, 18);
            this.chkTier2.TabIndex = 4;
            this.chkTier2.Text = "Tier 2";
            this.chkTier2.UseVisualStyleBackColor = true;
            this.chkTier2.Checked = true;

            // 
            // chkTier3
            // 
            this.chkTier3.AutoSize = true;
            this.chkTier3.BackColor = System.Drawing.Color.Transparent;
            this.chkTier3.Font = new System.Drawing.Font("Helvetica", 8F);
            this.chkTier3.ForeColor = System.Drawing.Color.White; // White text color
            this.chkTier3.Location = new System.Drawing.Point(0, 0);
            this.chkTier3.Name = "chkTier3";
            this.chkTier3.Size = new System.Drawing.Size(55, 18);
            this.chkTier3.TabIndex = 5;
            this.chkTier3.Text = "Tier 3";
            this.chkTier3.UseVisualStyleBackColor = true;
            this.chkTier3.Checked = true;

            // 
            // chkTier4
            // 
            this.chkTier4.AutoSize = true;
            this.chkTier4.BackColor = System.Drawing.Color.Transparent;
            this.chkTier4.Font = new System.Drawing.Font("Helvetica", 8F);
            this.chkTier4.ForeColor = System.Drawing.Color.White; // White text color
            this.chkTier4.Location = new System.Drawing.Point(0, 0);
            this.chkTier4.Name = "chkTier4";
            this.chkTier4.Size = new System.Drawing.Size(55, 18);
            this.chkTier4.TabIndex = 6;
            this.chkTier4.Text = "Tier 4";
            this.chkTier4.UseVisualStyleBackColor = true;
            this.chkTier4.Checked = true;

            // 
            // chkTier5
            // 
            this.chkTier5.AutoSize = true;
            this.chkTier5.BackColor = System.Drawing.Color.Transparent;
            this.chkTier5.Font = new System.Drawing.Font("Helvetica", 8F);
            this.chkTier5.ForeColor = System.Drawing.Color.White; // White text color
            this.chkTier5.Location = new System.Drawing.Point(0, 0);
            this.chkTier5.Name = "chkTier5";
            this.chkTier5.Size = new System.Drawing.Size(55, 18);
            this.chkTier5.TabIndex = 7;
            this.chkTier5.Text = "Tier 5";
            this.chkTier5.UseVisualStyleBackColor = true;
            this.chkTier5.Checked = true;

            // 
            // chkTier6
            // 
            this.chkTier6.AutoSize = true;
            this.chkTier6.BackColor = System.Drawing.Color.Transparent;
            this.chkTier6.Font = new System.Drawing.Font("Helvetica", 8F);
            this.chkTier6.ForeColor = System.Drawing.Color.White; // White text color
            this.chkTier6.Location = new System.Drawing.Point(0, 0);
            this.chkTier6.Name = "chkTier6";
            this.chkTier6.Size = new System.Drawing.Size(55, 18);
            this.chkTier6.TabIndex = 8;
            this.chkTier6.Text = "Tier 6";
            this.chkTier6.UseVisualStyleBackColor = true;
            this.chkTier6.Checked = true;

            // 
            // chkTier7
            // 
            this.chkTier7.AutoSize = true;
            this.chkTier7.BackColor = System.Drawing.Color.Transparent;
            this.chkTier7.Font = new System.Drawing.Font("Helvetica", 8F);
            this.chkTier7.ForeColor = System.Drawing.Color.White; // White text color
            this.chkTier7.Location = new System.Drawing.Point(0, 0);
            this.chkTier7.Name = "chkTier7";
            this.chkTier7.Size = new System.Drawing.Size(55, 18);
            this.chkTier7.TabIndex = 9;
            this.chkTier7.Text = "Tier 7";
            this.chkTier7.UseVisualStyleBackColor = true;
            this.chkTier7.Checked = true;

            // 
            // chkTier8
            // 
            this.chkTier8.AutoSize = true;
            this.chkTier8.BackColor = System.Drawing.Color.Transparent;
            this.chkTier8.Font = new System.Drawing.Font("Helvetica", 8F);
            this.chkTier8.ForeColor = System.Drawing.Color.White; // White text color
            this.chkTier8.Location = new System.Drawing.Point(0, 0);
            this.chkTier8.Name = "chkTier8";
            this.chkTier8.Size = new System.Drawing.Size(55, 18);
            this.chkTier8.TabIndex = 10;
            this.chkTier8.Text = "Tier 8";
            this.chkTier8.UseVisualStyleBackColor = true;
            this.chkTier8.Checked = true;

            // 
            // chkStaged
            // 
            this.chkStaged.AutoSize = true;
            this.chkStaged.BackColor = System.Drawing.Color.Transparent;
            this.chkStaged.Font = new System.Drawing.Font("Helvetica", 8F);
            this.chkStaged.ForeColor = System.Drawing.Color.White; // White text color
            this.chkStaged.Location = new System.Drawing.Point(0, 0);
            this.chkStaged.Name = "chkStaged";
            this.chkStaged.Size = new System.Drawing.Size(64, 18);
            this.chkStaged.TabIndex = 11;
            this.chkStaged.Text = "Staged";
            this.chkStaged.UseVisualStyleBackColor = true;
            this.chkStaged.Checked = true;

            // 
            // chkLinear
            // 
            this.chkLinear.AutoSize = true;
            this.chkLinear.BackColor = System.Drawing.Color.Transparent;
            this.chkLinear.Font = new System.Drawing.Font("Helvetica", 8F);
            this.chkLinear.ForeColor = System.Drawing.Color.White; // White text color
            this.chkLinear.Location = new System.Drawing.Point(0, 20);
            this.chkLinear.Name = "chkLinear";
            this.chkLinear.Size = new System.Drawing.Size(57, 18);
            this.chkLinear.TabIndex = 12;
            this.chkLinear.Text = "Linear";
            this.chkLinear.UseVisualStyleBackColor = true;
            this.chkLinear.Checked = true;

            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(20, 60);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(560, 40);
            this.btnGenerate.TabIndex = 14;
            this.btnGenerate.Text = "Generate Random Map";
            this.btnGenerate.UseVisualStyleBackColor = false;

            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.bottomPanel.Controls.Add(this.chkStaged);
            this.bottomPanel.Controls.Add(this.chkLinear);
            this.bottomPanel.Controls.Add(this.chkTier1);
            this.bottomPanel.Controls.Add(this.chkTier2);
            this.bottomPanel.Controls.Add(this.chkTier3);
            this.bottomPanel.Controls.Add(this.chkTier4);
            this.bottomPanel.Controls.Add(this.chkTier5);
            this.bottomPanel.Controls.Add(this.chkTier6);
            this.bottomPanel.Controls.Add(this.chkTier7);
            this.bottomPanel.Controls.Add(this.chkTier8);
            this.bottomPanel.Controls.Add(this.btnGenerate);
            this.bottomPanel.Location = new System.Drawing.Point(0, 385);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(600, 120);
            this.bottomPanel.TabIndex = 15;

            // Adjust the position of the checkboxes to center them
            int totalCheckboxWidth = 8 * (chkTier1.Width + 10);
            int startX = (this.bottomPanel.Width - totalCheckboxWidth) / 2 - 8;

            this.chkTier1.Location = new System.Drawing.Point(startX + 50, 20);
            this.chkTier2.Location = new System.Drawing.Point(startX + (chkTier1.Width + 10) * 1 + 50, 20);
            this.chkTier3.Location = new System.Drawing.Point(startX + (chkTier1.Width + 10) * 2 + 50, 20);
            this.chkTier4.Location = new System.Drawing.Point(startX + (chkTier1.Width + 10) * 3 + 50, 20);
            this.chkTier5.Location = new System.Drawing.Point(startX + (chkTier1.Width + 10) * 4 + 50, 20);
            this.chkTier6.Location = new System.Drawing.Point(startX + (chkTier1.Width + 10) * 5 + 50, 20);
            this.chkTier7.Location = new System.Drawing.Point(startX + (chkTier1.Width + 10) * 6 + 50, 20);
            this.chkTier8.Location = new System.Drawing.Point(startX + (chkTier1.Width + 10) * 7 + 50, 20);

            this.chkStaged.Location = new System.Drawing.Point(startX - 15, 11);
            this.chkLinear.Location = new System.Drawing.Point(startX - 15, 29);

            // 
            // picMapPreview
            // 
            this.picMapPreview.BackColor = System.Drawing.Color.Transparent;
            this.picMapPreview.Location = new System.Drawing.Point(50, 130);
            this.picMapPreview.Name = "picMapPreview";
            this.picMapPreview.Size = new System.Drawing.Size(500, 200);
            this.picMapPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMapPreview.TabIndex = 16;
            this.picMapPreview.TabStop = false;
            this.picMapPreview.Paint += new System.Windows.Forms.PaintEventHandler(this.PicMapPreview_Paint);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.picMapPreview);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblTier);
            this.Controls.Add(this.lblMapName);
            this.Controls.Add(this.lblTierNumber);
            this.Name = "Form1";
            this.Text = "Random Map Picker";
            ((System.ComponentModel.ISupportInitialize)(this.picMapPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
