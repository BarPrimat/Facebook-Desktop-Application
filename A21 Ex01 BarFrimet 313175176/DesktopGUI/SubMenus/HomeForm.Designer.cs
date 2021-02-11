using System.Drawing;

namespace Ex03.DesktopGUI
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label localeLabel;
            System.Windows.Forms.Label nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.logoutButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
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
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.birthdayLabel1 = new System.Windows.Forms.Label();
            this.emailLabel1 = new System.Windows.Forms.Label();
            this.localeLabel1 = new System.Windows.Forms.Label();
            this.nameLabel1 = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            localeLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            birthdayLabel.Location = new System.Drawing.Point(458, 54);
            birthdayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(71, 20);
            birthdayLabel.TabIndex = 25;
            birthdayLabel.Text = "Birthday:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            emailLabel.Location = new System.Drawing.Point(458, 89);
            emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(52, 20);
            emailLabel.TabIndex = 27;
            emailLabel.Text = "Email:";
            // 
            // localeLabel
            // 
            localeLabel.AutoSize = true;
            localeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            localeLabel.Location = new System.Drawing.Point(458, 125);
            localeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            localeLabel.Name = "localeLabel";
            localeLabel.Size = new System.Drawing.Size(60, 20);
            localeLabel.TabIndex = 29;
            localeLabel.Text = "Locale:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            nameLabel.Location = new System.Drawing.Point(458, 18);
            nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(55, 20);
            nameLabel.TabIndex = 31;
            nameLabel.Text = "Name:";
            // 
            // userPictureBox
            // 
            this.userPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.userPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("userPictureBox.Image")));
            this.userPictureBox.Location = new System.Drawing.Point(12, 12);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(132, 142);
            this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPictureBox.TabIndex = 4;
            this.userPictureBox.TabStop = false;
            // 
            // logoutButton
            // 
            this.logoutButton.AutoSize = true;
            this.logoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logoutButton.FlatAppearance.BorderSize = 3;
            this.logoutButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.logoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logoutButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.logoutButton.Location = new System.Drawing.Point(162, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(84, 45);
            this.logoutButton.TabIndex = 5;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.infoLabel.Location = new System.Drawing.Point(394, 18);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(37, 20);
            this.infoLabel.TabIndex = 8;
            this.infoLabel.Text = "Info";
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
            this.friendsListBox.Location = new System.Drawing.Point(297, 188);
            this.friendsListBox.Name = "friendsListBox";
            this.friendsListBox.Size = new System.Drawing.Size(256, 124);
            this.friendsListBox.TabIndex = 7;
            // 
            // friendsLinkLabel
            // 
            this.friendsLinkLabel.AutoSize = true;
            this.friendsLinkLabel.Location = new System.Drawing.Point(292, 165);
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
            this.groupsLinkLabel.Location = new System.Drawing.Point(292, 322);
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
            this.groupsListBox.Location = new System.Drawing.Point(292, 345);
            this.groupsListBox.Name = "groupsListBox";
            this.groupsListBox.Size = new System.Drawing.Size(260, 124);
            this.groupsListBox.TabIndex = 11;
            // 
            // lastPostLinkLabel
            // 
            this.lastPostLinkLabel.AutoSize = true;
            this.lastPostLinkLabel.Location = new System.Drawing.Point(12, 322);
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
            this.eventLinkLabel.Location = new System.Drawing.Point(564, 165);
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
            this.eventListBox.Location = new System.Drawing.Point(568, 188);
            this.eventListBox.Name = "eventListBox";
            this.eventListBox.Size = new System.Drawing.Size(260, 124);
            this.eventListBox.TabIndex = 15;
            // 
            // lastPostListBox
            // 
            this.lastPostListBox.FormattingEnabled = true;
            this.lastPostListBox.HorizontalScrollbar = true;
            this.lastPostListBox.ItemHeight = 20;
            this.lastPostListBox.Location = new System.Drawing.Point(16, 345);
            this.lastPostListBox.Name = "lastPostListBox";
            this.lastPostListBox.Size = new System.Drawing.Size(260, 124);
            this.lastPostListBox.TabIndex = 13;
            // 
            // checkInLinkLabel
            // 
            this.checkInLinkLabel.AutoSize = true;
            this.checkInLinkLabel.Location = new System.Drawing.Point(564, 322);
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
            this.checkInListBox.Location = new System.Drawing.Point(568, 345);
            this.checkInListBox.Name = "checkInListBox";
            this.checkInListBox.Size = new System.Drawing.Size(260, 124);
            this.checkInListBox.TabIndex = 19;
            // 
            // postStatusLabel
            // 
            this.postStatusLabel.AutoSize = true;
            this.postStatusLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.postStatusLabel.Location = new System.Drawing.Point(12, 165);
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
            this.postStatusButton.Size = new System.Drawing.Size(75, 32);
            this.postStatusButton.TabIndex = 24;
            this.postStatusButton.Text = "Post";
            this.postStatusButton.UseVisualStyleBackColor = true;
            this.postStatusButton.Click += new System.EventHandler(this.postStatusButton_Click);
            // 
            // statusTextBox
            // 
            this.statusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.statusTextBox.Location = new System.Drawing.Point(12, 188);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(264, 124);
            this.statusTextBox.TabIndex = 23;
            this.statusTextBox.Text = "What\'s on your mind?";
            this.statusTextBox.TextChanged += new System.EventHandler(this.statusTextBox_TextChanged);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // birthdayLabel1
            // 
            this.birthdayLabel1.AutoSize = true;
            this.birthdayLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.birthdayLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.birthdayLabel1.Location = new System.Drawing.Point(539, 54);
            this.birthdayLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.birthdayLabel1.Name = "birthdayLabel1";
            this.birthdayLabel1.Size = new System.Drawing.Size(103, 20);
            this.birthdayLabel1.TabIndex = 26;
            this.birthdayLabel1.Text = "User birthday";
            // 
            // emailLabel1
            // 
            this.emailLabel1.AutoSize = true;
            this.emailLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.emailLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emailLabel1.Location = new System.Drawing.Point(538, 89);
            this.emailLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel1.Name = "emailLabel1";
            this.emailLabel1.Size = new System.Drawing.Size(86, 20);
            this.emailLabel1.TabIndex = 28;
            this.emailLabel1.Text = "User Email";
            // 
            // localeLabel1
            // 
            this.localeLabel1.AutoSize = true;
            this.localeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Locale", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.localeLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.localeLabel1.Location = new System.Drawing.Point(538, 125);
            this.localeLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.localeLabel1.Name = "localeLabel1";
            this.localeLabel1.Size = new System.Drawing.Size(88, 20);
            this.localeLabel1.TabIndex = 30;
            this.localeLabel1.Text = "User locale";
            // 
            // nameLabel1
            // 
            this.nameLabel1.AutoSize = true;
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.nameLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameLabel1.Location = new System.Drawing.Point(539, 18);
            this.nameLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(87, 20);
            this.nameLabel1.TabIndex = 32;
            this.nameLabel1.Text = "User name";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(861, 502);
            this.Controls.Add(birthdayLabel);
            this.Controls.Add(this.birthdayLabel1);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailLabel1);
            this.Controls.Add(localeLabel);
            this.Controls.Add(this.localeLabel1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameLabel1);
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
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.friendsListBox);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.userPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label infoLabel;
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
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Label birthdayLabel1;
        private System.Windows.Forms.Label emailLabel1;
        private System.Windows.Forms.Label localeLabel1;
        private System.Windows.Forms.Label nameLabel1;
    }
}