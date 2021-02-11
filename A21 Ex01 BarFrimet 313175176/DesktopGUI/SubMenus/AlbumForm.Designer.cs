using System.Drawing;
using System.Windows.Forms;

namespace Ex03.DesktopGUI
{
    partial class AlbumForm
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
            this.albumLinkLabel = new System.Windows.Forms.LinkLabel();
            this.albumListBox = new System.Windows.Forms.ListBox();
            this.simplePictureInAlbumPictureBox1 = new System.Windows.Forms.PictureBox();
            this.simplePictureInAlbumPictureBox2 = new System.Windows.Forms.PictureBox();
            this.simplePictureInAlbumPictureBox3 = new System.Windows.Forms.PictureBox();
            this.simplePictureInAlbumPictureBox4 = new System.Windows.Forms.PictureBox();
            this.specificPhotoFromAlbumPictureBox = new System.Windows.Forms.PictureBox();
            this.showAlbumPictureLinkLabel = new System.Windows.Forms.LinkLabel();
            this.pictureInAlbumListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.simplePictureInAlbumPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simplePictureInAlbumPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simplePictureInAlbumPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simplePictureInAlbumPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specificPhotoFromAlbumPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // albumLinkLabel
            // 
            this.albumLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.albumLinkLabel.AutoSize = true;
            this.albumLinkLabel.Location = new System.Drawing.Point(12, 22);
            this.albumLinkLabel.Name = "albumLinkLabel";
            this.albumLinkLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.albumLinkLabel.Size = new System.Drawing.Size(98, 20);
            this.albumLinkLabel.TabIndex = 12;
            this.albumLinkLabel.TabStop = true;
            this.albumLinkLabel.Text = "Show Album";
            this.albumLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.albumLinkLabel_LinkClicked);
            // 
            // albumListBox
            // 
            this.albumListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.albumListBox.FormattingEnabled = true;
            this.albumListBox.HorizontalScrollbar = true;
            this.albumListBox.ItemHeight = 20;
            this.albumListBox.Location = new System.Drawing.Point(12, 59);
            this.albumListBox.Name = "albumListBox";
            this.albumListBox.Size = new System.Drawing.Size(345, 104);
            this.albumListBox.TabIndex = 11;
            this.albumListBox.SelectedIndexChanged += new System.EventHandler(this.albumListBox_SelectedIndexChanged);
            // 
            // simplePictureInAlbumPictureBox1
            // 
            this.simplePictureInAlbumPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simplePictureInAlbumPictureBox1.Location = new System.Drawing.Point(386, 2);
            this.simplePictureInAlbumPictureBox1.Name = "simplePictureInAlbumPictureBox1";
            this.simplePictureInAlbumPictureBox1.Size = new System.Drawing.Size(189, 111);
            this.simplePictureInAlbumPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.simplePictureInAlbumPictureBox1.TabIndex = 13;
            this.simplePictureInAlbumPictureBox1.TabStop = false;
            // 
            // simplePictureInAlbumPictureBox2
            // 
            this.simplePictureInAlbumPictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simplePictureInAlbumPictureBox2.Location = new System.Drawing.Point(386, 119);
            this.simplePictureInAlbumPictureBox2.Name = "simplePictureInAlbumPictureBox2";
            this.simplePictureInAlbumPictureBox2.Size = new System.Drawing.Size(189, 111);
            this.simplePictureInAlbumPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.simplePictureInAlbumPictureBox2.TabIndex = 14;
            this.simplePictureInAlbumPictureBox2.TabStop = false;
            // 
            // simplePictureInAlbumPictureBox3
            // 
            this.simplePictureInAlbumPictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simplePictureInAlbumPictureBox3.Location = new System.Drawing.Point(629, 2);
            this.simplePictureInAlbumPictureBox3.Name = "simplePictureInAlbumPictureBox3";
            this.simplePictureInAlbumPictureBox3.Size = new System.Drawing.Size(189, 111);
            this.simplePictureInAlbumPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.simplePictureInAlbumPictureBox3.TabIndex = 15;
            this.simplePictureInAlbumPictureBox3.TabStop = false;
            // 
            // simplePictureInAlbumPictureBox4
            // 
            this.simplePictureInAlbumPictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simplePictureInAlbumPictureBox4.Location = new System.Drawing.Point(629, 119);
            this.simplePictureInAlbumPictureBox4.Name = "simplePictureInAlbumPictureBox4";
            this.simplePictureInAlbumPictureBox4.Size = new System.Drawing.Size(189, 111);
            this.simplePictureInAlbumPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.simplePictureInAlbumPictureBox4.TabIndex = 16;
            this.simplePictureInAlbumPictureBox4.TabStop = false;
            // 
            // specificPhotoFromAlbumPictureBox
            // 
            this.specificPhotoFromAlbumPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.specificPhotoFromAlbumPictureBox.Location = new System.Drawing.Point(363, 236);
            this.specificPhotoFromAlbumPictureBox.Name = "specificPhotoFromAlbumPictureBox";
            this.specificPhotoFromAlbumPictureBox.Size = new System.Drawing.Size(455, 232);
            this.specificPhotoFromAlbumPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.specificPhotoFromAlbumPictureBox.TabIndex = 17;
            this.specificPhotoFromAlbumPictureBox.TabStop = false;
            // 
            // showAlbumPictureLinkLabel
            // 
            this.showAlbumPictureLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showAlbumPictureLinkLabel.AutoSize = true;
            this.showAlbumPictureLinkLabel.Location = new System.Drawing.Point(12, 223);
            this.showAlbumPictureLinkLabel.Name = "showAlbumPictureLinkLabel";
            this.showAlbumPictureLinkLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.showAlbumPictureLinkLabel.Size = new System.Drawing.Size(151, 20);
            this.showAlbumPictureLinkLabel.TabIndex = 19;
            this.showAlbumPictureLinkLabel.TabStop = true;
            this.showAlbumPictureLinkLabel.Text = "Show Album Picture";
            this.showAlbumPictureLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.showAlbumPictureLinkLabel_LinkClicked);
            // 
            // pictureInAlbumListBox
            // 
            this.pictureInAlbumListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureInAlbumListBox.FormattingEnabled = true;
            this.pictureInAlbumListBox.HorizontalScrollbar = true;
            this.pictureInAlbumListBox.ItemHeight = 20;
            this.pictureInAlbumListBox.Location = new System.Drawing.Point(12, 260);
            this.pictureInAlbumListBox.Name = "pictureInAlbumListBox";
            this.pictureInAlbumListBox.Size = new System.Drawing.Size(315, 104);
            this.pictureInAlbumListBox.TabIndex = 18;
            this.pictureInAlbumListBox.SelectedIndexChanged += new System.EventHandler(this.pictureInAlbumListBox_SelectedIndexChanged);
            // 
            // AlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(830, 480);
            this.Controls.Add(this.showAlbumPictureLinkLabel);
            this.Controls.Add(this.pictureInAlbumListBox);
            this.Controls.Add(this.specificPhotoFromAlbumPictureBox);
            this.Controls.Add(this.simplePictureInAlbumPictureBox4);
            this.Controls.Add(this.simplePictureInAlbumPictureBox3);
            this.Controls.Add(this.simplePictureInAlbumPictureBox2);
            this.Controls.Add(this.simplePictureInAlbumPictureBox1);
            this.Controls.Add(this.albumLinkLabel);
            this.Controls.Add(this.albumListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlbumForm";
            this.Text = "ChangeStatusForm";
            ((System.ComponentModel.ISupportInitialize)(this.simplePictureInAlbumPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simplePictureInAlbumPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simplePictureInAlbumPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simplePictureInAlbumPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specificPhotoFromAlbumPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel albumLinkLabel;
        private ListBox albumListBox;
        private PictureBox simplePictureInAlbumPictureBox1;
        private PictureBox simplePictureInAlbumPictureBox2;
        private PictureBox simplePictureInAlbumPictureBox3;
        private PictureBox simplePictureInAlbumPictureBox4;
        private PictureBox specificPhotoFromAlbumPictureBox;
        private LinkLabel showAlbumPictureLinkLabel;
        private ListBox pictureInAlbumListBox;
    }
}