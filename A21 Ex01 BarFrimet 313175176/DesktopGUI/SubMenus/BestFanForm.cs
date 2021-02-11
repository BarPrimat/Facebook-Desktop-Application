using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Ex03.Logic;
using FacebookWrapper.ObjectModel;

namespace Ex03.DesktopGUI
{
    public partial class BestFanForm : Form
    {
        private BestFan m_BestFan;
        private const bool k_VisibleObject = true;
        // Color can change in the future
        private static readonly Color sr_RegularFormColor = SystemColors.ActiveCaption;
        private static readonly Color sr_DarkButtonColor = Color.DarkGray;
        private const int k_NumberOfBestFanToShow = 3;

        public BestFanForm(ToggleNightMode i_ToggleNightMode)
        {
            InitializeComponent();
            ToggleNightMode.ChangeObjectColor(this, sr_RegularFormColor, sr_DarkButtonColor);
            i_ToggleNightMode.PropertyChanged += changeViewMode;
        }

        private void changeViewMode(object sender, PropertyChangedEventArgs e)
        {
            ToggleNightMode.ChangeObjectColor(this, sr_RegularFormColor, sr_DarkButtonColor);
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            fetchFindBestFan();
        }

        private void fetchFindBestFan()
        {
            try
            {
                m_BestFan = new BestFan();
                List<Tuple<User, int>> listOfBestFan = m_BestFan.FindBestFans(k_NumberOfBestFanToShow, (int)scoreForLikeInPhotoNumericUpDown.Value, (int)scoreForCommentInPhotoNumericUpDown.Value, (int)scoreForLikeInPostNumericUpDown.Value, (int)scoreForCommentInPostNumericUpDown.Value);

                bestFanListBox.Items.Clear();
                foreach (Tuple<User, int> newFan in listOfBestFan)
                {
                    addNewBestFanToBestFanListBox(newFan.Item1, newFan.Item2);
                }

                if (bestFanListBox.Items.Count == 0)
                {
                    MessageBox.Show(@"There is no like, comment in post or Photo");
                    displayOrNotBestFanObjects(!k_VisibleObject);
                }
                else
                {
                    displayOrNotBestFanObjects(k_VisibleObject);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void addNewBestFanToBestFanListBox(User i_NewFanUser, int i_NewFanScore)
        {
            if (i_NewFanUser != null)
            {
                string newFanToDisplay = string.Format("{0}. {1} with the score: {2}", bestFanListBox.Items.Count + 1, i_NewFanUser.Name, i_NewFanScore);
                bestFanListBox.Items.Add(newFanToDisplay);
            }
        }

        private void displayOrNotBestFanObjects(bool i_DisplayObjects)
        {
            bestFanListBox.Visible = i_DisplayObjects;
            findYourNextBestFanButton.Visible = i_DisplayObjects;
        }

        private void findYourNextBestFanButton_Click(object sender, EventArgs e)
        {
            fetchFindNextBestFan();
        }

        private void fetchFindNextBestFan()
        {
            try
            {
                Tuple<User, int> listOfBestFan = m_BestFan.FindNextBestFan();

                if (listOfBestFan != null)
                {
                    addNewBestFanToBestFanListBox(listOfBestFan.Item1, listOfBestFan.Item2);
                }
                else
                {
                    MessageBox.Show(@"There is no more fans");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}