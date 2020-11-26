namespace Ex01.DesktopGUI
{
    sealed partial class MainMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.displaySubPanel = new System.Windows.Forms.Panel();
            this.mirrorButton = new System.Windows.Forms.Button();
            this.bestFanButton = new System.Windows.Forms.Button();
            this.featuresButton = new System.Windows.Forms.Button();
            this.albumButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.facebookPictureBox = new System.Windows.Forms.PictureBox();
            this.mainFillPanel = new System.Windows.Forms.Panel();
            this.mainDownPanel = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.displaySubPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facebookPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(128)))), ((int)(((byte)(168)))));
            this.panelSideMenu.Controls.Add(this.exitButton);
            this.panelSideMenu.Controls.Add(this.displaySubPanel);
            this.panelSideMenu.Controls.Add(this.featuresButton);
            this.panelSideMenu.Controls.Add(this.albumButton);
            this.panelSideMenu.Controls.Add(this.homeButton);
            this.panelSideMenu.Controls.Add(this.logoPanel);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 490);
            this.panelSideMenu.TabIndex = 9;
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exitButton.Location = new System.Drawing.Point(0, 400);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(250, 60);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // displaySubPanel
            // 
            this.displaySubPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(179)))), ((int)(((byte)(201)))));
            this.displaySubPanel.Controls.Add(this.mirrorButton);
            this.displaySubPanel.Controls.Add(this.bestFanButton);
            this.displaySubPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.displaySubPanel.Location = new System.Drawing.Point(0, 280);
            this.displaySubPanel.Name = "displaySubPanel";
            this.displaySubPanel.Size = new System.Drawing.Size(250, 120);
            this.displaySubPanel.TabIndex = 4;
            // 
            // mirrorButton
            // 
            this.mirrorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mirrorButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.mirrorButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.mirrorButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mirrorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mirrorButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mirrorButton.Location = new System.Drawing.Point(0, 60);
            this.mirrorButton.Name = "mirrorButton";
            this.mirrorButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.mirrorButton.Size = new System.Drawing.Size(250, 60);
            this.mirrorButton.TabIndex = 9;
            this.mirrorButton.Text = "The Mirror";
            this.mirrorButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mirrorButton.UseVisualStyleBackColor = true;
            this.mirrorButton.Click += new System.EventHandler(this.mirrorButton_Click);
            // 
            // bestFanButton
            // 
            this.bestFanButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bestFanButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.bestFanButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.bestFanButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bestFanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bestFanButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bestFanButton.Location = new System.Drawing.Point(0, 0);
            this.bestFanButton.Name = "bestFanButton";
            this.bestFanButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.bestFanButton.Size = new System.Drawing.Size(250, 60);
            this.bestFanButton.TabIndex = 8;
            this.bestFanButton.Text = "The Best Fan";
            this.bestFanButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bestFanButton.UseVisualStyleBackColor = true;
            this.bestFanButton.Click += new System.EventHandler(this.bestFanButton_Click);
            // 
            // featuresButton
            // 
            this.featuresButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.featuresButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.featuresButton.Enabled = false;
            this.featuresButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.featuresButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.featuresButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.featuresButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.featuresButton.Location = new System.Drawing.Point(0, 220);
            this.featuresButton.Name = "featuresButton";
            this.featuresButton.Size = new System.Drawing.Size(250, 60);
            this.featuresButton.TabIndex = 7;
            this.featuresButton.Text = "Features";
            this.featuresButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.featuresButton.UseVisualStyleBackColor = true;
            this.featuresButton.Click += new System.EventHandler(this.featuresButton_Click);
            // 
            // albumButton
            // 
            this.albumButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.albumButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.albumButton.Enabled = false;
            this.albumButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.albumButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.albumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.albumButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.albumButton.Location = new System.Drawing.Point(0, 160);
            this.albumButton.Name = "albumButton";
            this.albumButton.Size = new System.Drawing.Size(250, 60);
            this.albumButton.TabIndex = 6;
            this.albumButton.Text = "Album";
            this.albumButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.albumButton.UseVisualStyleBackColor = true;
            this.albumButton.Click += new System.EventHandler(this.albumButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.homeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.homeButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.homeButton.Location = new System.Drawing.Point(0, 100);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(250, 60);
            this.homeButton.TabIndex = 1;
            this.homeButton.Text = "Home";
            this.homeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.logoPanel.Controls.Add(this.facebookPictureBox);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(250, 100);
            this.logoPanel.TabIndex = 0;
            // 
            // facebookPictureBox
            // 
            this.facebookPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.facebookPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.facebookPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("facebookPictureBox.Image")));
            this.facebookPictureBox.Location = new System.Drawing.Point(20, 8);
            this.facebookPictureBox.Name = "facebookPictureBox";
            this.facebookPictureBox.Size = new System.Drawing.Size(85, 88);
            this.facebookPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.facebookPictureBox.TabIndex = 3;
            this.facebookPictureBox.TabStop = false;
            this.facebookPictureBox.Click += new System.EventHandler(this.facebookPictureBox_Click);
            // 
            // mainFillPanel
            // 
            this.mainFillPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainFillPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFillPanel.Location = new System.Drawing.Point(250, 0);
            this.mainFillPanel.Name = "mainFillPanel";
            this.mainFillPanel.Size = new System.Drawing.Size(728, 390);
            this.mainFillPanel.TabIndex = 9;
            // 
            // mainDownPanel
            // 
            this.mainDownPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.mainDownPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainDownPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mainDownPanel.Location = new System.Drawing.Point(250, 390);
            this.mainDownPanel.Name = "mainDownPanel";
            this.mainDownPanel.Size = new System.Drawing.Size(728, 100);
            this.mainDownPanel.TabIndex = 8;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(978, 490);
            this.Controls.Add(this.mainFillPanel);
            this.Controls.Add(this.mainDownPanel);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook Desktop App";
            this.panelSideMenu.ResumeLayout(false);
            this.displaySubPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.facebookPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel mainFillPanel;
        private System.Windows.Forms.Panel displaySubPanel;
        private System.Windows.Forms.PictureBox facebookPictureBox;
        private System.Windows.Forms.Panel mainDownPanel;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button featuresButton;
        private System.Windows.Forms.Button albumButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button mirrorButton;
        private System.Windows.Forms.Button bestFanButton;
    }
}

