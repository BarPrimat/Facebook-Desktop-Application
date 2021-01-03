namespace DesktopGUI
{
    partial class LoginForm
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
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Button loginButton;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            titleLabel = new System.Windows.Forms.Label();
            loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            titleLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            titleLabel.Location = new System.Drawing.Point(168, 47);
            titleLabel.Margin = new System.Windows.Forms.Padding(0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(389, 30);
            titleLabel.TabIndex = 24;
            titleLabel.Text = "Welcome to the Facebook App";
            titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginButton
            // 
            loginButton.AutoSize = true;
            loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            loginButton.FlatAppearance.BorderSize = 10;
            loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            loginButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            loginButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            loginButton.Location = new System.Drawing.Point(91, 91);
            loginButton.Margin = new System.Windows.Forms.Padding(0);
            loginButton.Name = "loginButton";
            loginButton.Size = new System.Drawing.Size(405, 102);
            loginButton.TabIndex = 25;
            loginButton.Text = "Tap here to login";
            loginButton.UseMnemonic = false;
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(576, 240);
            this.Controls.Add(loginButton);
            this.Controls.Add(titleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}