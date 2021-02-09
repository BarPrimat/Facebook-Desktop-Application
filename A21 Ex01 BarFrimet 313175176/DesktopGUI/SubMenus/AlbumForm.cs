using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Ex02.Logic;
using FacebookWrapper.ObjectModel;

namespace Ex02.DesktopGUI
{
    public partial class AlbumForm : Form
    {
        private const int k_NumberOfPartialPhotoToShow = 4;
        private static readonly Color sr_ButtonRegularColor = SystemColors.ActiveCaption;
        private static readonly Color sr_DarkButtonColor = Color.DarkGray;
        private Dictionary<Tuple<string, string>, Photo> m_PhotoFromAlbum = new Dictionary<Tuple<string, string>, Photo>();
        private readonly User m_LoggedInUser = null;

        public AlbumForm(ToggleNightMode i_ToggleNightMode)
        {
            InitializeComponent();
            m_LoggedInUser = Session.Instance.LoggedInUser;
            ToggleNightMode.ChangeObjectColor(this, sr_ButtonRegularColor, sr_DarkButtonColor);
            i_ToggleNightMode.PropertyChanged += changeViewMode;
        }

        private void changeViewMode(object sender, PropertyChangedEventArgs e)
        {
            ToggleNightMode.ChangeObjectColor(this, sr_ButtonRegularColor, sr_DarkButtonColor);
        }

        private void albumLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchAlbums();
        }

        private void fetchAlbums()
        {
            try
            {
                albumListBox.Items.Clear();
                albumListBox.DisplayMember = "Name";
                foreach (Album album in m_LoggedInUser.Albums)
                {
                    albumListBox.Items.Add(album);
                }

                if (albumListBox.Items.Count == 0)
                {
                    MessageBox.Show("No Albums to retrieve");
                }
            }
            catch (Exception e)
            {
                albumListBox.Items.Add(e);
            }
        }

        private void albumListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedAlbum();
        }

        private void displaySelectedAlbum()
        {
            try
            {
                if (albumListBox.SelectedItems.Count == 1)
                {
                    Album selectedAlbum = albumListBox.SelectedItem as Album;

                    if (selectedAlbum != null)
                    {
                        showPartialPhoto(selectedAlbum);
                    }
                    else
                    {
                        simplePictureInAlbumPictureBox1.Image = simplePictureInAlbumPictureBox1.ErrorImage;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No picture in albums to retrieve");
            }
        }

        private void showPartialPhoto(Album i_SelectedAlbum)
        {
            for (int i = 0; i < k_NumberOfPartialPhotoToShow; i++)
            {
                if (i_SelectedAlbum.Photos[i] != null)
                {
                    PictureBox pictureInAlbumPictureBox = null;
                    switch (i)
                    {
                        case 0:
                            pictureInAlbumPictureBox = simplePictureInAlbumPictureBox1;
                            break;
                        case 1:
                            pictureInAlbumPictureBox = simplePictureInAlbumPictureBox2;
                            break;
                        case 2:
                            pictureInAlbumPictureBox = simplePictureInAlbumPictureBox3;
                            break;
                        case 3:
                            pictureInAlbumPictureBox = simplePictureInAlbumPictureBox4;
                            break;
                    }

                    if (pictureInAlbumPictureBox != null)
                    {
                        pictureInAlbumPictureBox.LoadAsync(i_SelectedAlbum.Photos[i].PictureNormalURL);
                    }
                }
            }
        }

        private void showAlbumPictureLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchPictureList();
        }

        private void fetchPictureList()
        {
            try
            {
                pictureInAlbumListBox.Items.Clear(); 
                if (albumListBox.SelectedItems.Count == 1)
                {
                    Album selectedAlbum = albumListBox.SelectedItem as Album;
                    List<Photo> listOfAlbumPictures = new List<Photo>(selectedAlbum.Photos); 
                    Dictionary<Tuple<string, string>, Photo> photoFromAlbum = new Dictionary<Tuple<string, string>, Photo>();

                    foreach (Photo photo in selectedAlbum.Photos)
                    {
                        string nameOfPhoto = !string.IsNullOrEmpty(photo.Name) ? photo.Name : (photoFromAlbum.Count + 1).ToString();
                        Tuple<string, string> tuple = new Tuple<string, string>(nameOfPhoto, photo.Id);

                        photoFromAlbum.Add(tuple, photo);
                        pictureInAlbumListBox.Items.Add(tuple);
                    }

                    m_PhotoFromAlbum = photoFromAlbum;
                }
                else
                {
                    MessageBox.Show("First select Album");
                }
            }
            catch (Exception e)
            {
                pictureInAlbumListBox.Items.Add(e);
            }
        }

        private void pictureInAlbumListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedPicture();
        }

        private void displaySelectedPicture()
        {
            try
            {
                if (pictureInAlbumListBox.SelectedItems.Count == 1)
                {
                    Photo selectedPhoto = m_PhotoFromAlbum[((Tuple<string, string>)pictureInAlbumListBox.SelectedItem)] as Photo;
                    specificPhotoFromAlbumPictureBox.LoadAsync(selectedPhoto?.PictureNormalURL);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}