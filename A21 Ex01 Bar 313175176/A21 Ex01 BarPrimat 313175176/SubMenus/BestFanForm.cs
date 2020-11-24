using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace DesktopGUI.SubMenus
{
    public partial class BestFanForm : Form
    {
        private const bool k_VisibleObject = true;
        private const int k_NumberOfBestFanToShow = 3;

        public BestFanForm()
        {
            InitializeComponent();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            fetchFindBestFan();
        }

        private void fetchFindBestFan()
        {
            List<Tuple<User, int>> listOfBestFan = FindBestFan(k_NumberOfBestFanToShow, (int)scoreForLikeInPhotoNumericUpDown.Value, (int)scoreForCommentInPhotoNumericUpDown.Value, (int)scoreForLikeInPostNumericUpDown.Value, (int)scoreForCommentInPostNumericUpDown.Value);

            bestFanListBox.Items.Clear();
            bestFanListBox.DisplayMember = "Name";
            foreach (Tuple<User, int> newFan in listOfBestFan)
            {
                string newFanToDisplay = string.Format("{0}. {1} with the score: {2}", bestFanListBox.Items.Count + 1, newFan.Item1.Name, newFan.Item2);
                bestFanListBox.Items.Add(newFanToDisplay);
            }

            if(bestFanListBox.Items.Count == 0)
            {
                MessageBox.Show(@"There is no like, comment in post or Photo");
                bestFanListBox.Visible = !k_VisibleObject;
            }
            else
            {
                bestFanListBox.Visible = k_VisibleObject;
            }
        }
    }
}