using System.Drawing;

namespace Ex03.DesktopGUI
{
    partial class BestFanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BestFanForm));
            this.scoreForLikeInPhotoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.scoreForLikeInPhotoLabel = new System.Windows.Forms.Label();
            this.scoreForCommentLabel = new System.Windows.Forms.Label();
            this.scoreForCommentInPhotoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.findButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreForLikeInPostNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.scoreForCommentInPostNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.bestFanListBox = new System.Windows.Forms.ListBox();
            this.findYourNextBestFanButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.explanationLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.scoreForLikeInPhotoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreForCommentInPhotoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreForLikeInPostNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreForCommentInPostNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreForLikeInPhotoNumericUpDown
            // 
            this.scoreForLikeInPhotoNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreForLikeInPhotoNumericUpDown.Location = new System.Drawing.Point(684, 138);
            this.scoreForLikeInPhotoNumericUpDown.Name = "scoreForLikeInPhotoNumericUpDown";
            this.scoreForLikeInPhotoNumericUpDown.Size = new System.Drawing.Size(70, 26);
            this.scoreForLikeInPhotoNumericUpDown.TabIndex = 1;
            this.scoreForLikeInPhotoNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // scoreForLikeInPhotoLabel
            // 
            this.scoreForLikeInPhotoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreForLikeInPhotoLabel.AutoSize = true;
            this.scoreForLikeInPhotoLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.scoreForLikeInPhotoLabel.Location = new System.Drawing.Point(473, 140);
            this.scoreForLikeInPhotoLabel.Name = "scoreForLikeInPhotoLabel";
            this.scoreForLikeInPhotoLabel.Size = new System.Drawing.Size(162, 20);
            this.scoreForLikeInPhotoLabel.TabIndex = 2;
            this.scoreForLikeInPhotoLabel.Text = "Score for like in photo";
            // 
            // scoreForCommentLabel
            // 
            this.scoreForCommentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreForCommentLabel.AutoSize = true;
            this.scoreForCommentLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.scoreForCommentLabel.Location = new System.Drawing.Point(473, 199);
            this.scoreForCommentLabel.Name = "scoreForCommentLabel";
            this.scoreForCommentLabel.Size = new System.Drawing.Size(205, 20);
            this.scoreForCommentLabel.TabIndex = 4;
            this.scoreForCommentLabel.Text = "Score for comment in photo";
            // 
            // scoreForCommentInPhotoNumericUpDown
            // 
            this.scoreForCommentInPhotoNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreForCommentInPhotoNumericUpDown.Location = new System.Drawing.Point(684, 195);
            this.scoreForCommentInPhotoNumericUpDown.Name = "scoreForCommentInPhotoNumericUpDown";
            this.scoreForCommentInPhotoNumericUpDown.Size = new System.Drawing.Size(70, 26);
            this.scoreForCommentInPhotoNumericUpDown.TabIndex = 3;
            this.scoreForCommentInPhotoNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // findButton
            // 
            this.findButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.findButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.findButton.FlatAppearance.BorderSize = 3;
            this.findButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.findButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.findButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.findButton.Location = new System.Drawing.Point(360, 287);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(109, 36);
            this.findButton.TabIndex = 7;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(60, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Score for like in post";
            // 
            // scoreForLikeInPostNumericUpDown
            // 
            this.scoreForLikeInPostNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreForLikeInPostNumericUpDown.Location = new System.Drawing.Point(273, 142);
            this.scoreForLikeInPostNumericUpDown.Name = "scoreForLikeInPostNumericUpDown";
            this.scoreForLikeInPostNumericUpDown.Size = new System.Drawing.Size(70, 26);
            this.scoreForLikeInPostNumericUpDown.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(60, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Score for comment in post";
            // 
            // scoreForCommentInPostNumericUpDown
            // 
            this.scoreForCommentInPostNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreForCommentInPostNumericUpDown.Location = new System.Drawing.Point(273, 197);
            this.scoreForCommentInPostNumericUpDown.Name = "scoreForCommentInPostNumericUpDown";
            this.scoreForCommentInPostNumericUpDown.Size = new System.Drawing.Size(70, 26);
            this.scoreForCommentInPostNumericUpDown.TabIndex = 17;
            // 
            // bestFanListBox
            // 
            this.bestFanListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bestFanListBox.FormattingEnabled = true;
            this.bestFanListBox.HorizontalScrollbar = true;
            this.bestFanListBox.ItemHeight = 20;
            this.bestFanListBox.Location = new System.Drawing.Point(233, 329);
            this.bestFanListBox.Name = "bestFanListBox";
            this.bestFanListBox.Size = new System.Drawing.Size(402, 124);
            this.bestFanListBox.TabIndex = 14;
            this.bestFanListBox.Visible = false;
            // 
            // findYourNextBestFanButton
            // 
            this.findYourNextBestFanButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.findYourNextBestFanButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.findYourNextBestFanButton.FlatAppearance.BorderSize = 3;
            this.findYourNextBestFanButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.findYourNextBestFanButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.findYourNextBestFanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findYourNextBestFanButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.findYourNextBestFanButton.Location = new System.Drawing.Point(486, 287);
            this.findYourNextBestFanButton.Name = "findYourNextBestFanButton";
            this.findYourNextBestFanButton.Size = new System.Drawing.Size(139, 36);
            this.findYourNextBestFanButton.TabIndex = 20;
            this.findYourNextBestFanButton.Text = "Find next fan";
            this.findYourNextBestFanButton.UseVisualStyleBackColor = true;
            this.findYourNextBestFanButton.Visible = false;
            this.findYourNextBestFanButton.Click += new System.EventHandler(this.findYourNextBestFanButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.titleLabel.Location = new System.Drawing.Point(226, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(402, 44);
            this.titleLabel.TabIndex = 23;
            this.titleLabel.Text = "Find how is your best fan";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // explanationLabel
            // 
            this.explanationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.explanationLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.explanationLabel.Location = new System.Drawing.Point(59, 71);
            this.explanationLabel.Name = "explanationLabel";
            this.explanationLabel.Size = new System.Drawing.Size(718, 44);
            this.explanationLabel.TabIndex = 22;
            this.explanationLabel.Text = "Rate the importance of each one of the following properties";
            this.explanationLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(64, 309);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(652, 309);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(116, 124);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // BestFanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(830, 480);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.explanationLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.findYourNextBestFanButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scoreForCommentInPostNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scoreForLikeInPostNumericUpDown);
            this.Controls.Add(this.bestFanListBox);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.scoreForCommentLabel);
            this.Controls.Add(this.scoreForCommentInPhotoNumericUpDown);
            this.Controls.Add(this.scoreForLikeInPhotoLabel);
            this.Controls.Add(this.scoreForLikeInPhotoNumericUpDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BestFanForm";
            this.Text = "DisplayByStatusCategoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.scoreForLikeInPhotoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreForCommentInPhotoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreForLikeInPostNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreForCommentInPostNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown scoreForLikeInPhotoNumericUpDown;
        private System.Windows.Forms.Label scoreForLikeInPhotoLabel;
        private System.Windows.Forms.Label scoreForCommentLabel;
        private System.Windows.Forms.NumericUpDown scoreForCommentInPhotoNumericUpDown;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown scoreForLikeInPostNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown scoreForCommentInPostNumericUpDown;
        private System.Windows.Forms.ListBox bestFanListBox;
        private System.Windows.Forms.Button findYourNextBestFanButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label explanationLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}