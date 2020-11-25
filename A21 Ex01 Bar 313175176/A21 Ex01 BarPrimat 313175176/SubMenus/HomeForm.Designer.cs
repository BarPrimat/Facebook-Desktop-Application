using System.Drawing;

namespace Ex01.DesktopGUI
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.loginOrLogoutButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.friendsListBox = new System.Windows.Forms.ListBox();
            this.friendsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.groupsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.groupsListBox = new System.Windows.Forms.ListBox();
            this.lastPostLinkLabel = new System.Windows.Forms.LinkLabel();
            this.eventLinkLabel = new System.Windows.Forms.LinkLabel();
            this.eventListBox = new System.Windows.Forms.ListBox();
            this.lastPostListBox = new System.Windows.Forms.ListBox();
            this.checkInLinkLabel = new System.Windows.Forms.LinkLabel();
            this.checkInListBox = new System.Windows.Forms.ListBox();
            this.postStatusLabel = new System.Windows.Forms.Label();
            this.postStatusButton = new System.Windows.Forms.Button();
            this.statusTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // userPictureBox
            // 
            this.userPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.userPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("userPictureBox.Image")));
            this.userPictureBox.Location = new System.Drawing.Point(12, 12);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(132, 141);
            this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPictureBox.TabIndex = 4;
            this.userPictureBox.TabStop = false;
            // 
            // loginOrLogoutButton
            // 
            this.loginOrLogoutButton.AutoSize = true;
            this.loginOrLogoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.loginOrLogoutButton.FlatAppearance.BorderSize = 3;
            this.loginOrLogoutButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.loginOrLogoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.loginOrLogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginOrLogoutButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginOrLogoutButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.loginOrLogoutButton.Location = new System.Drawing.Point(162, 12);
            this.loginOrLogoutButton.Name = "loginOrLogoutButton";
            this.loginOrLogoutButton.Size = new System.Drawing.Size(68, 43);
            this.loginOrLogoutButton.TabIndex = 5;
            this.loginOrLogoutButton.Text = "Login";
            this.loginOrLogoutButton.UseVisualStyleBackColor = true;
            this.loginOrLogoutButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.infoLabel.Location = new System.Drawing.Point(390, 12);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(37, 20);
            this.infoLabel.TabIndex = 8;
            this.infoLabel.Text = "Info";
            // 
            // infoTextBox
            // 
            this.infoTextBox.Location = new System.Drawing.Point(436, 9);
            this.infoTextBox.Multiline = true;
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.ReadOnly = true;
            this.infoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.infoTextBox.Size = new System.Drawing.Size(382, 152);
            this.infoTextBox.TabIndex = 9;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.welcomeLabel.Location = new System.Drawing.Point(162, 69);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(144, 20);
            this.welcomeLabel.TabIndex = 6;
            this.welcomeLabel.Text = "Welcome Message";
            this.welcomeLabel.Visible = false;
            // 
            // friendsListBox
            // 
            this.friendsListBox.FormattingEnabled = true;
            this.friendsListBox.HorizontalScrollbar = true;
            this.friendsListBox.ItemHeight = 20;
            this.friendsListBox.Location = new System.Drawing.Point(297, 187);
            this.friendsListBox.Name = "friendsListBox";
            this.friendsListBox.Size = new System.Drawing.Size(256, 124);
            this.friendsListBox.TabIndex = 7;
            // 
            // friendsLinkLabel
            // 
            this.friendsLinkLabel.AutoSize = true;
            this.friendsLinkLabel.Location = new System.Drawing.Point(293, 164);
            this.friendsLinkLabel.Name = "friendsLinkLabel";
            this.friendsLinkLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.friendsLinkLabel.Size = new System.Drawing.Size(106, 20);
            this.friendsLinkLabel.TabIndex = 10;
            this.friendsLinkLabel.TabStop = true;
            this.friendsLinkLabel.Text = "Show Friends";
            this.friendsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.friendsLinkLabel_LinkClicked);
            // 
            // groupsLinkLabel
            // 
            this.groupsLinkLabel.AutoSize = true;
            this.groupsLinkLabel.Location = new System.Drawing.Point(293, 321);
            this.groupsLinkLabel.Name = "groupsLinkLabel";
            this.groupsLinkLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupsLinkLabel.Size = new System.Drawing.Size(106, 20);
            this.groupsLinkLabel.TabIndex = 12;
            this.groupsLinkLabel.TabStop = true;
            this.groupsLinkLabel.Text = "Show Groups";
            this.groupsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.groupsLinkLabel_LinkClicked);
            // 
            // groupsListBox
            // 
            this.groupsListBox.FormattingEnabled = true;
            this.groupsListBox.HorizontalScrollbar = true;
            this.groupsListBox.ItemHeight = 20;
            this.groupsListBox.Location = new System.Drawing.Point(293, 344);
            this.groupsListBox.Name = "groupsListBox";
            this.groupsListBox.Size = new System.Drawing.Size(260, 124);
            this.groupsListBox.TabIndex = 11;
            // 
            // lastPostLinkLabel
            // 
            this.lastPostLinkLabel.AutoSize = true;
            this.lastPostLinkLabel.Location = new System.Drawing.Point(12, 321);
            this.lastPostLinkLabel.Name = "lastPostLinkLabel";
            this.lastPostLinkLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lastPostLinkLabel.Size = new System.Drawing.Size(128, 20);
            this.lastPostLinkLabel.TabIndex = 14;
            this.lastPostLinkLabel.TabStop = true;
            this.lastPostLinkLabel.Text = "Show Last Posts";
            this.lastPostLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lastPostLinkLabel_LinkClicked);
            // 
            // eventLinkLabel
            // 
            this.eventLinkLabel.AutoSize = true;
            this.eventLinkLabel.Location = new System.Drawing.Point(564, 164);
            this.eventLinkLabel.Name = "eventLinkLabel";
            this.eventLinkLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.eventLinkLabel.Size = new System.Drawing.Size(94, 20);
            this.eventLinkLabel.TabIndex = 16;
            this.eventLinkLabel.TabStop = true;
            this.eventLinkLabel.Text = "Show Event";
            this.eventLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.eventLinkLabel_LinkClicked);
            // 
            // eventListBox
            // 
            this.eventListBox.FormattingEnabled = true;
            this.eventListBox.HorizontalScrollbar = true;
            this.eventListBox.ItemHeight = 20;
            this.eventListBox.Location = new System.Drawing.Point(568, 187);
            this.eventListBox.Name = "eventListBox";
            this.eventListBox.Size = new System.Drawing.Size(260, 124);
            this.eventListBox.TabIndex = 15;
            // 
            // lastPostListBox
            // 
            this.lastPostListBox.FormattingEnabled = true;
            this.lastPostListBox.HorizontalScrollbar = true;
            this.lastPostListBox.ItemHeight = 20;
            this.lastPostListBox.Location = new System.Drawing.Point(16, 344);
            this.lastPostListBox.Name = "lastPostListBox";
            this.lastPostListBox.Size = new System.Drawing.Size(260, 124);
            this.lastPostListBox.TabIndex = 13;
            // 
            // checkInLinkLabel
            // 
            this.checkInLinkLabel.AutoSize = true;
            this.checkInLinkLabel.Location = new System.Drawing.Point(564, 314);
            this.checkInLinkLabel.Name = "checkInLinkLabel";
            this.checkInLinkLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkInLinkLabel.Size = new System.Drawing.Size(116, 20);
            this.checkInLinkLabel.TabIndex = 20;
            this.checkInLinkLabel.TabStop = true;
            this.checkInLinkLabel.Text = "Show Check In";
            this.checkInLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.checkInLinkLabel_LinkClicked);
            // 
            // checkInListBox
            // 
            this.checkInListBox.FormattingEnabled = true;
            this.checkInListBox.HorizontalScrollbar = true;
            this.checkInListBox.ItemHeight = 20;
            this.checkInListBox.Location = new System.Drawing.Point(568, 344);
            this.checkInListBox.Name = "checkInListBox";
            this.checkInListBox.Size = new System.Drawing.Size(260, 124);
            this.checkInListBox.TabIndex = 19;
            // 
            // postStatusLabel
            // 
            this.postStatusLabel.AutoSize = true;
            this.postStatusLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.postStatusLabel.Location = new System.Drawing.Point(12, 164);
            this.postStatusLabel.Name = "postStatusLabel";
            this.postStatusLabel.Size = new System.Drawing.Size(89, 20);
            this.postStatusLabel.TabIndex = 22;
            this.postStatusLabel.Text = "Post status";
            // 
            // postStatusButton
            // 
            this.postStatusButton.Enabled = false;
            this.postStatusButton.Location = new System.Drawing.Point(201, 278);
            this.postStatusButton.Name = "postStatusButton";
            this.postStatusButton.Size = new System.Drawing.Size(75, 33);
            this.postStatusButton.TabIndex = 24;
            this.postStatusButton.Text = "Post";
            this.postStatusButton.UseVisualStyleBackColor = true;
            this.postStatusButton.Click += new System.EventHandler(this.postStatusButton_Click);
            // 
            // statusTextBox
            // 
            this.statusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.statusTextBox.Location = new System.Drawing.Point(12, 187);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(264, 124);
            this.statusTextBox.TabIndex = 23;
            this.statusTextBox.Text = "What\'s on your mind?";
            this.statusTextBox.TextChanged += new System.EventHandler(this.statusTextBox_TextChanged);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(830, 480);
            this.Controls.Add(this.postStatusButton);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.postStatusLabel);
            this.Controls.Add(this.checkInLinkLabel);
            this.Controls.Add(this.checkInListBox);
            this.Controls.Add(this.eventLinkLabel);
            this.Controls.Add(this.eventListBox);
            this.Controls.Add(this.lastPostLinkLabel);
            this.Controls.Add(this.lastPostListBox);
            this.Controls.Add(this.groupsLinkLabel);
            this.Controls.Add(this.groupsListBox);
            this.Controls.Add(this.friendsLinkLabel);
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.friendsListBox);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.loginOrLogoutButton);
            this.Controls.Add(this.userPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.Button loginOrLogoutButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.TextBox infoTextBox;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.ListBox friendsListBox;
        private System.Windows.Forms.LinkLabel friendsLinkLabel;
        private System.Windows.Forms.LinkLabel groupsLinkLabel;
        private System.Windows.Forms.ListBox groupsListBox;
        private System.Windows.Forms.LinkLabel lastPostLinkLabel;
        private System.Windows.Forms.LinkLabel eventLinkLabel;
        private System.Windows.Forms.ListBox eventListBox;
        private System.Windows.Forms.ListBox lastPostListBox;
        private System.Windows.Forms.LinkLabel checkInLinkLabel;
        private System.Windows.Forms.ListBox checkInListBox;
        private System.Windows.Forms.Label postStatusLabel;
        private System.Windows.Forms.Button postStatusButton;
        private System.Windows.Forms.RichTextBox statusTextBox;
    }
}