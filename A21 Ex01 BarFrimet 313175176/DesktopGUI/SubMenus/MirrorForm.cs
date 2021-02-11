using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Ex03.Logic;

namespace Ex03.DesktopGUI
{
    public partial class MirrorForm : Form
    {
        // Color can change in the future
        private static readonly Color sr_RegularFormColor = SystemColors.ActiveCaption;
        private static readonly Color sr_DarkButtonColor = Color.DarkGray;

        public MirrorForm(ToggleNightMode i_ToggleNightMode)
        {
            InitializeComponent();
            ToggleNightMode.ChangeObjectColor(this, sr_RegularFormColor, sr_DarkButtonColor);
            i_ToggleNightMode.PropertyChanged += changeViewMode;
        }

        private void changeViewMode(object sender, PropertyChangedEventArgs e)
        {
            ToggleNightMode.ChangeObjectColor(this, sr_RegularFormColor, sr_DarkButtonColor);
        }

        private void letsStartButton_Click(object sender, EventArgs e)
        {
            fetchFindPatternBehavior();
        }

        private void fetchFindPatternBehavior()
        {
            try
            {
                List<string> listToDisplay = new PersonalityAnalyzer((int)sensitivityOfAnalyzerNumericUpDown.Value).Analyzer();

                displayUserBehavior(listToDisplay);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void displayUserBehavior(List<string> i_ListToDisplay)
        {
            try
            {
                whatKnowAboutYouListBox.Items.Clear();
                foreach (string stringToDisplay in i_ListToDisplay)
                {
                    whatKnowAboutYouListBox.Items.Add(stringToDisplay);
                }

                if (whatKnowAboutYouListBox.Items.Count == 0)
                {
                    MessageBox.Show("There is no pattern that matches your post or not found any post to analyze");
                    whatKnowAboutYouListBox.Visible = false;
                }
                else
                {
                    whatKnowAboutYouListBox.Visible = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}