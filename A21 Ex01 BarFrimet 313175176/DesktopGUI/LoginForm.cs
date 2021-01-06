using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ex02.DesktopGUI;
using Ex02.Logic;

namespace DesktopGUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            fetchLogin();
        }

        private void fetchLogin()
        {
            try
            {
                Session.Instance.LoginAndInit();
                if(Session.Instance.LoggedInUser != null)
                {
                    this.Hide();
                    new MainMenuForm().ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Some problem has occurred try again");
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
