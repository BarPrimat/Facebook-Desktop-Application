﻿using System.Drawing;

namespace DesktopGUI.SubMenus
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
            this.scoreForLikeInPhotoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.scoreForLikeInPhotoLabel = new System.Windows.Forms.Label();
            this.scoreForCommentLabel = new System.Windows.Forms.Label();
            this.scoreForCommentInPhotoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.findButton = new System.Windows.Forms.Button();
            this.bestFanListBox = new System.Windows.Forms.ListBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreForLikeInPostNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.scoreForCommentInPostNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.scoreForLikeInPhotoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreForCommentInPhotoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreForLikeInPostNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreForCommentInPostNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreForLikeInPhotoNumericUpDown
            // 
            this.scoreForLikeInPhotoNumericUpDown.Location = new System.Drawing.Point(656, 107);
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
            this.scoreForLikeInPhotoLabel.AutoSize = true;
            this.scoreForLikeInPhotoLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.scoreForLikeInPhotoLabel.Location = new System.Drawing.Point(445, 109);
            this.scoreForLikeInPhotoLabel.Name = "scoreForLikeInPhotoLabel";
            this.scoreForLikeInPhotoLabel.Size = new System.Drawing.Size(162, 20);
            this.scoreForLikeInPhotoLabel.TabIndex = 2;
            this.scoreForLikeInPhotoLabel.Text = "Score for like in photo";
            // 
            // scoreForCommentLabel
            // 
            this.scoreForCommentLabel.AutoSize = true;
            this.scoreForCommentLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.scoreForCommentLabel.Location = new System.Drawing.Point(445, 160);
            this.scoreForCommentLabel.Name = "scoreForCommentLabel";
            this.scoreForCommentLabel.Size = new System.Drawing.Size(205, 20);
            this.scoreForCommentLabel.TabIndex = 4;
            this.scoreForCommentLabel.Text = "Score for comment in photo";
            // 
            // scoreForCommentInPhotoNumericUpDown
            // 
            this.scoreForCommentInPhotoNumericUpDown.Location = new System.Drawing.Point(656, 154);
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
            this.findButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.findButton.FlatAppearance.BorderSize = 3;
            this.findButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.findButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.findButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.findButton.Location = new System.Drawing.Point(359, 253);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(109, 36);
            this.findButton.TabIndex = 7;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // bestFanListBox
            // 
            this.bestFanListBox.FormattingEnabled = true;
            this.bestFanListBox.HorizontalScrollbar = true;
            this.bestFanListBox.ItemHeight = 20;
            this.bestFanListBox.Location = new System.Drawing.Point(233, 295);
            this.bestFanListBox.Name = "bestFanListBox";
            this.bestFanListBox.Size = new System.Drawing.Size(382, 124);
            this.bestFanListBox.TabIndex = 14;
            this.bestFanListBox.Visible = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.titleLabel.Location = new System.Drawing.Point(216, 32);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(399, 37);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Find how is your best fan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(61, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Score for like in post";
            // 
            // scoreForLikeInPostNumericUpDown
            // 
            this.scoreForLikeInPostNumericUpDown.Location = new System.Drawing.Point(274, 107);
            this.scoreForLikeInPostNumericUpDown.Name = "scoreForLikeInPostNumericUpDown";
            this.scoreForLikeInPostNumericUpDown.Size = new System.Drawing.Size(70, 26);
            this.scoreForLikeInPostNumericUpDown.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(61, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Score for comment in post";
            // 
            // scoreForCommentInPostNumericUpDown
            // 
            this.scoreForCommentInPostNumericUpDown.Location = new System.Drawing.Point(274, 156);
            this.scoreForCommentInPostNumericUpDown.Name = "scoreForCommentInPostNumericUpDown";
            this.scoreForCommentInPostNumericUpDown.Size = new System.Drawing.Size(70, 26);
            this.scoreForCommentInPostNumericUpDown.TabIndex = 17;
            // 
            // BestFanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(830, 480);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scoreForCommentInPostNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scoreForLikeInPostNumericUpDown);
            this.Controls.Add(this.bestFanListBox);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.titleLabel);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown scoreForLikeInPhotoNumericUpDown;
        private System.Windows.Forms.Label scoreForLikeInPhotoLabel;
        private System.Windows.Forms.Label scoreForCommentLabel;
        private System.Windows.Forms.NumericUpDown scoreForCommentInPhotoNumericUpDown;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.ListBox bestFanListBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown scoreForLikeInPostNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown scoreForCommentInPostNumericUpDown;
    }
}