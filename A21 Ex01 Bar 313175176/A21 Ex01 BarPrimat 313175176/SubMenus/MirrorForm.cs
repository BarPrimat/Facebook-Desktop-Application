using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ex01.Logic;

namespace Ex01.DesktopGUI
{
    public partial class MirrorForm : Form
    {
        public MirrorForm()
        {
            InitializeComponent();
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

                whatKnowAboutYouListBox.Items.Clear();
                foreach (string stringToDisplay in listToDisplay)
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
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}