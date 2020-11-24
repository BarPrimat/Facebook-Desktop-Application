using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopGUI.SubMenus
{
    public partial class MirrorForm : Form
    {
        public MirrorForm()
        {
            InitializeComponent();
        }

        private void letsStartButton_Click(object sender, EventArgs e)
        {
            fetchLetsStart();
        }

        private void fetchLetsStart()
        {
            List<string> listToDisplay = new PersonalityAnalyzer((int)sensitivityOfAnalyzerNumericUpDown.Value).Analyzer();

            whatKnowAboutYouListBox.Items.Clear();
            whatKnowAboutYouListBox.DisplayMember = "Mirror";
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
    }
}