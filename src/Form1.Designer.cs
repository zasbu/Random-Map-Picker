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
            lblMapName = new Label();
            lblTier = new Label();
            lblTierNumber = new Label();
            lblType = new Label();
            chkTier1 = new CheckBox();
            bottomPanel = new Panel();
            chkStaged = new CheckBox();
            chkLinear = new CheckBox();
            chkTier2 = new CheckBox();
            chkTier3 = new CheckBox();
            chkTier4 = new CheckBox();
            chkTier5 = new CheckBox();
            chkTier6 = new CheckBox();
            chkTier7 = new CheckBox();
            chkTier8 = new CheckBox();
            btnGenerate = new Button();
            picMapPreview = new PictureBox();
            bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMapPreview).BeginInit();
            SuspendLayout();
            // 
            // lblMapName
            // 
            lblMapName.AutoSize = true;
            lblMapName.BackColor = Color.Transparent;
            lblMapName.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMapName.ForeColor = Color.White;
            lblMapName.Location = new Point(331, 46);
            lblMapName.Margin = new Padding(4, 0, 4, 0);
            lblMapName.Name = "lblMapName";
            lblMapName.Size = new Size(128, 27);
            lblMapName.TabIndex = 0;
            lblMapName.Text = "Map Name";
            lblMapName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTier
            // 
            lblTier.AutoSize = true;
            lblTier.BackColor = Color.Transparent;
            lblTier.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTier.ForeColor = Color.White;
            lblTier.Location = new Point(331, 92);
            lblTier.Margin = new Padding(4, 0, 4, 0);
            lblTier.Name = "lblTier";
            lblTier.Size = new Size(42, 22);
            lblTier.TabIndex = 1;
            lblTier.Text = "Tier";
            lblTier.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTierNumber
            // 
            lblTierNumber.AutoSize = true;
            lblTierNumber.BackColor = Color.Transparent;
            lblTierNumber.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTierNumber.ForeColor = Color.Red;
            lblTierNumber.Location = new Point(331, 92);
            lblTierNumber.Margin = new Padding(4, 0, 4, 0);
            lblTierNumber.Name = "lblTierNumber";
            lblTierNumber.Size = new Size(26, 22);
            lblTierNumber.TabIndex = 1;
            lblTierNumber.Text = " 3";
            lblTierNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.BackColor = Color.Transparent;
            lblType.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblType.ForeColor = Color.White;
            lblType.Location = new Point(331, 115);
            lblType.Margin = new Padding(4, 0, 4, 0);
            lblType.Name = "lblType";
            lblType.Size = new Size(41, 18);
            lblType.TabIndex = 2;
            lblType.Text = "Type";
            lblType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chkTier1
            // 
            chkTier1.AutoSize = true;
            chkTier1.BackColor = Color.Transparent;
            chkTier1.Checked = true;
            chkTier1.CheckState = CheckState.Checked;
            chkTier1.Font = new Font("Arial", 8F);
            chkTier1.ForeColor = Color.White;
            chkTier1.Location = new Point(700, 23);
            chkTier1.Margin = new Padding(4, 3, 4, 3);
            chkTier1.Name = "chkTier1";
            chkTier1.Size = new Size(53, 18);
            chkTier1.TabIndex = 3;
            chkTier1.Text = "Tier 1";
            chkTier1.UseVisualStyleBackColor = true;
            // 
            // bottomPanel
            // 
            bottomPanel.BackColor = Color.FromArgb(30, 30, 30);
            bottomPanel.Controls.Add(chkStaged);
            bottomPanel.Controls.Add(chkLinear);
            bottomPanel.Controls.Add(chkTier1);
            bottomPanel.Controls.Add(chkTier2);
            bottomPanel.Controls.Add(chkTier3);
            bottomPanel.Controls.Add(chkTier4);
            bottomPanel.Controls.Add(chkTier5);
            bottomPanel.Controls.Add(chkTier6);
            bottomPanel.Controls.Add(chkTier7);
            bottomPanel.Controls.Add(chkTier8);
            bottomPanel.Controls.Add(btnGenerate);
            bottomPanel.Location = new Point(0, 444);
            bottomPanel.Margin = new Padding(4, 3, 4, 3);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(700, 138);
            bottomPanel.TabIndex = 15;
            // 
            // chkStaged
            // 
            chkStaged.AutoSize = true;
            chkStaged.BackColor = Color.Transparent;
            chkStaged.Checked = true;
            chkStaged.CheckState = CheckState.Checked;
            chkStaged.Font = new Font("Arial", 8F);
            chkStaged.ForeColor = Color.White;
            chkStaged.Location = new Point(0, 0);
            chkStaged.Margin = new Padding(4, 3, 4, 3);
            chkStaged.Name = "chkStaged";
            chkStaged.Size = new Size(60, 18);
            chkStaged.TabIndex = 11;
            chkStaged.Text = "Staged";
            chkStaged.UseVisualStyleBackColor = true;
            // 
            // chkLinear
            // 
            chkLinear.AutoSize = true;
            chkLinear.BackColor = Color.Transparent;
            chkLinear.Checked = true;
            chkLinear.CheckState = CheckState.Checked;
            chkLinear.Font = new Font("Arial", 8F);
            chkLinear.ForeColor = Color.White;
            chkLinear.Location = new Point(0, 23);
            chkLinear.Margin = new Padding(4, 3, 4, 3);
            chkLinear.Name = "chkLinear";
            chkLinear.Size = new Size(56, 18);
            chkLinear.TabIndex = 12;
            chkLinear.Text = "Linear";
            chkLinear.UseVisualStyleBackColor = true;
            // 
            // chkTier2
            // 
            chkTier2.AutoSize = true;
            chkTier2.BackColor = Color.Transparent;
            chkTier2.Checked = true;
            chkTier2.CheckState = CheckState.Checked;
            chkTier2.Font = new Font("Arial", 8F);
            chkTier2.ForeColor = Color.White;
            chkTier2.Location = new Point(0, 0);
            chkTier2.Margin = new Padding(4, 3, 4, 3);
            chkTier2.Name = "chkTier2";
            chkTier2.Size = new Size(53, 18);
            chkTier2.TabIndex = 4;
            chkTier2.Text = "Tier 2";
            chkTier2.UseVisualStyleBackColor = true;
            // 
            // chkTier3
            // 
            chkTier3.AutoSize = true;
            chkTier3.BackColor = Color.Transparent;
            chkTier3.Checked = true;
            chkTier3.CheckState = CheckState.Checked;
            chkTier3.Font = new Font("Arial", 8F);
            chkTier3.ForeColor = Color.White;
            chkTier3.Location = new Point(0, 0);
            chkTier3.Margin = new Padding(4, 3, 4, 3);
            chkTier3.Name = "chkTier3";
            chkTier3.Size = new Size(53, 18);
            chkTier3.TabIndex = 5;
            chkTier3.Text = "Tier 3";
            chkTier3.UseVisualStyleBackColor = true;
            // 
            // chkTier4
            // 
            chkTier4.AutoSize = true;
            chkTier4.BackColor = Color.Transparent;
            chkTier4.Checked = true;
            chkTier4.CheckState = CheckState.Checked;
            chkTier4.Font = new Font("Arial", 8F);
            chkTier4.ForeColor = Color.White;
            chkTier4.Location = new Point(0, 0);
            chkTier4.Margin = new Padding(4, 3, 4, 3);
            chkTier4.Name = "chkTier4";
            chkTier4.Size = new Size(53, 18);
            chkTier4.TabIndex = 6;
            chkTier4.Text = "Tier 4";
            chkTier4.UseVisualStyleBackColor = true;
            // 
            // chkTier5
            // 
            chkTier5.AutoSize = true;
            chkTier5.BackColor = Color.Transparent;
            chkTier5.Checked = true;
            chkTier5.CheckState = CheckState.Checked;
            chkTier5.Font = new Font("Arial", 8F);
            chkTier5.ForeColor = Color.White;
            chkTier5.Location = new Point(0, 0);
            chkTier5.Margin = new Padding(4, 3, 4, 3);
            chkTier5.Name = "chkTier5";
            chkTier5.Size = new Size(53, 18);
            chkTier5.TabIndex = 7;
            chkTier5.Text = "Tier 5";
            chkTier5.UseVisualStyleBackColor = true;
            // 
            // chkTier6
            // 
            chkTier6.AutoSize = true;
            chkTier6.BackColor = Color.Transparent;
            chkTier6.Checked = true;
            chkTier6.CheckState = CheckState.Checked;
            chkTier6.Font = new Font("Arial", 8F);
            chkTier6.ForeColor = Color.White;
            chkTier6.Location = new Point(0, 0);
            chkTier6.Margin = new Padding(4, 3, 4, 3);
            chkTier6.Name = "chkTier6";
            chkTier6.Size = new Size(53, 18);
            chkTier6.TabIndex = 8;
            chkTier6.Text = "Tier 6";
            chkTier6.UseVisualStyleBackColor = true;
            // 
            // chkTier7
            // 
            chkTier7.AutoSize = true;
            chkTier7.BackColor = Color.Transparent;
            chkTier7.Checked = true;
            chkTier7.CheckState = CheckState.Checked;
            chkTier7.Font = new Font("Arial", 8F);
            chkTier7.ForeColor = Color.White;
            chkTier7.Location = new Point(0, 0);
            chkTier7.Margin = new Padding(4, 3, 4, 3);
            chkTier7.Name = "chkTier7";
            chkTier7.Size = new Size(53, 18);
            chkTier7.TabIndex = 9;
            chkTier7.Text = "Tier 7";
            chkTier7.UseVisualStyleBackColor = true;
            // 
            // chkTier8
            // 
            chkTier8.AutoSize = true;
            chkTier8.BackColor = Color.Transparent;
            chkTier8.Checked = true;
            chkTier8.CheckState = CheckState.Checked;
            chkTier8.Font = new Font("Arial", 8F);
            chkTier8.ForeColor = Color.White;
            chkTier8.Location = new Point(0, 0);
            chkTier8.Margin = new Padding(4, 3, 4, 3);
            chkTier8.Name = "chkTier8";
            chkTier8.Size = new Size(53, 18);
            chkTier8.TabIndex = 10;
            chkTier8.Text = "Tier 8";
            chkTier8.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.DodgerBlue;
            btnGenerate.FlatAppearance.BorderSize = 0;
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerate.ForeColor = Color.White;
            btnGenerate.Location = new Point(23, 69);
            btnGenerate.Margin = new Padding(4, 3, 4, 3);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(653, 46);
            btnGenerate.TabIndex = 14;
            btnGenerate.Text = "Generate Random Map";
            btnGenerate.UseVisualStyleBackColor = false;
            // 
            // picMapPreview
            // 
            picMapPreview.BackColor = Color.Transparent;
            picMapPreview.Location = new Point(58, 150);
            picMapPreview.Margin = new Padding(4, 3, 4, 3);
            picMapPreview.Name = "picMapPreview";
            picMapPreview.Size = new Size(583, 231);
            picMapPreview.SizeMode = PictureBoxSizeMode.StretchImage;
            picMapPreview.TabIndex = 16;
            picMapPreview.TabStop = false;
            picMapPreview.Paint += PicMapPreview_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 48);
            ClientSize = new Size(700, 577);
            Controls.Add(picMapPreview);
            Controls.Add(bottomPanel);
            Controls.Add(lblType);
            Controls.Add(lblTier);
            Controls.Add(lblMapName);
            Controls.Add(lblTierNumber);
            ForeColor = Color.White;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Random Map Picker";
            bottomPanel.ResumeLayout(false);
            bottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMapPreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
