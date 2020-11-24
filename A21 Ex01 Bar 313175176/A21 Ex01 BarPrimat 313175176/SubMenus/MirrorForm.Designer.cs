using System.Drawing;

namespace DesktopGUI.SubMenus
{
    partial class MirrorForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.explanationLabel = new System.Windows.Forms.Label();
            this.letsStartButton = new System.Windows.Forms.Button();
            this.whatKnowAboutYouListBox = new System.Windows.Forms.ListBox();
            this.sensitivityOfAnalyzerLabel = new System.Windows.Forms.Label();
            this.sensitivityOfAnalyzerNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.sensitivityOfAnalyzerNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.titleLabel.Location = new System.Drawing.Point(118, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(611, 95);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "Mirror mirror on the wall can you tell me what I interest for";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // explanationLabel
            // 
            this.explanationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.explanationLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.explanationLabel.Location = new System.Drawing.Point(120, 104);
            this.explanationLabel.Name = "explanationLabel";
            this.explanationLabel.Size = new System.Drawing.Size(572, 133);
            this.explanationLabel.TabIndex = 7;
            this.explanationLabel.Text = "This feature designed to show your interests based on keywords that founded in yo" +
    "ur posts and images.\r\nAs the sensitivity score you will select is higher, the co" +
    "nclusions will be more accurate.";
            // 
            // letsStartButton
            // 
            this.letsStartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.letsStartButton.FlatAppearance.BorderSize = 3;
            this.letsStartButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.letsStartButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.letsStartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.letsStartButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.letsStartButton.Location = new System.Drawing.Point(372, 289);
            this.letsStartButton.Name = "letsStartButton";
            this.letsStartButton.Size = new System.Drawing.Size(109, 36);
            this.letsStartButton.TabIndex = 8;
            this.letsStartButton.Text = "Let\'s start";
            this.letsStartButton.UseVisualStyleBackColor = true;
            this.letsStartButton.Click += new System.EventHandler(this.letsStartButton_Click);
            // 
            // whatKnowAboutYouListBox
            // 
            this.whatKnowAboutYouListBox.FormattingEnabled = true;
            this.whatKnowAboutYouListBox.HorizontalScrollbar = true;
            this.whatKnowAboutYouListBox.ItemHeight = 20;
            this.whatKnowAboutYouListBox.Location = new System.Drawing.Point(251, 344);
            this.whatKnowAboutYouListBox.Name = "whatKnowAboutYouListBox";
            this.whatKnowAboutYouListBox.Size = new System.Drawing.Size(382, 124);
            this.whatKnowAboutYouListBox.TabIndex = 15;
            this.whatKnowAboutYouListBox.Visible = false;
            // 
            // sensitivityOfAnalyzerLabel
            // 
            this.sensitivityOfAnalyzerLabel.AutoSize = true;
            this.sensitivityOfAnalyzerLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sensitivityOfAnalyzerLabel.Location = new System.Drawing.Point(281, 251);
            this.sensitivityOfAnalyzerLabel.Name = "sensitivityOfAnalyzerLabel";
            this.sensitivityOfAnalyzerLabel.Size = new System.Drawing.Size(191, 20);
            this.sensitivityOfAnalyzerLabel.TabIndex = 17;
            this.sensitivityOfAnalyzerLabel.Text = "Sensitivity of  the analyzer";
            // 
            // sensitivityOfAnalyzerNumericUpDown
            // 
            this.sensitivityOfAnalyzerNumericUpDown.Location = new System.Drawing.Point(492, 249);
            this.sensitivityOfAnalyzerNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sensitivityOfAnalyzerNumericUpDown.Name = "sensitivityOfAnalyzerNumericUpDown";
            this.sensitivityOfAnalyzerNumericUpDown.Size = new System.Drawing.Size(70, 26);
            this.sensitivityOfAnalyzerNumericUpDown.TabIndex = 16;
            this.sensitivityOfAnalyzerNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MirrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(830, 480);
            this.Controls.Add(this.sensitivityOfAnalyzerLabel);
            this.Controls.Add(this.sensitivityOfAnalyzerNumericUpDown);
            this.Controls.Add(this.whatKnowAboutYouListBox);
            this.Controls.Add(this.letsStartButton);
            this.Controls.Add(this.explanationLabel);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MirrorForm";
            this.Text = "SpacificVehicleForm";
            ((System.ComponentModel.ISupportInitialize)(this.sensitivityOfAnalyzerNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label explanationLabel;
        private System.Windows.Forms.Button letsStartButton;
        private System.Windows.Forms.ListBox whatKnowAboutYouListBox;
        private System.Windows.Forms.Label sensitivityOfAnalyzerLabel;
        private System.Windows.Forms.NumericUpDown sensitivityOfAnalyzerNumericUpDown;
    }
}