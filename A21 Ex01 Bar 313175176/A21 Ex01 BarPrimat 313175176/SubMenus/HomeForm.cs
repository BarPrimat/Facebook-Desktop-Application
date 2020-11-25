using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ex01.DesktopGUI.Properties;
using FacebookWrapper.ObjectModel;
using Ex01.Logic;

namespace Ex01.DesktopGUI
{
    public partial class HomeForm : Form
    {
        private const bool k_ObjectIsVisible = true;
        private const bool k_EnabledAllForms = true;
        private static bool s_IsAlreadyLogIn = false;
        private readonly MainMenuForm r_ParentForm;

        public HomeForm(MainMenuForm i_ParentForm)
        {
            InitializeComponent();
            r_ParentForm = i_ParentForm;
            if(s_IsAlreadyLogIn)
            {
                loginOrLogoutButton.Text = "Logout";
                setInfo();
            }
            else
            {
                loginOrLogoutButton.Text = "Login";
                enabledOrDisableAllForms(!k_EnabledAllForms);
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            bool needToEnable = false;

            if(loginOrLogoutButton.Text == "Login")
            {
                Session.LoginAndInit();
                if(Session.Result.LoggedInUser != null)
                {
                    setInfo();
                    loginOrLogoutButton.Text = "Logout";
                    needToEnable = k_EnabledAllForms;
                    s_IsAlreadyLogIn = true;
                }
            }
            else
            {
                Session.Logout();
                clearAllItemsInScreen();
                loginOrLogoutButton.Text = "Login";
                MessageBox.Show("You are now logged out!");
                s_IsAlreadyLogIn = false;
            }

            enabledOrDisableAllForms(needToEnable);
        }

        private void clearAllItemsInScreen()
        {
            infoTextBox.Clear();
            friendsListBox.Items.Clear();
            lastPostListBox.Items.Clear();
            groupsListBox.Items.Clear();
            eventListBox.Items.Clear();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.userPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("userPictureBox.Image")));
        }

        private void enabledOrDisableAllForms(bool i_EnabledAllForms)
        {
            r_ParentForm.EnabledOrDisableAllForms(i_EnabledAllForms);
            this.friendsLinkLabel.Enabled = i_EnabledAllForms;
            this.lastPostLinkLabel.Enabled = i_EnabledAllForms;
            this.groupsLinkLabel.Enabled = i_EnabledAllForms;
            this.eventLinkLabel.Enabled = i_EnabledAllForms;
        }

        private void setInfo()
        {
            try
            {
                userPictureBox.LoadAsync(Session.LoggedInUser.PictureNormalURL);
                welcomeLabel.Text = "Welcome " + Session.LoggedInUser.FirstName;
                welcomeLabel.Visible = k_ObjectIsVisible;
                infoTextBox.Text = string.Format(
@"User Name:{0}
Gender: {1}
Relationship Status: {2}
Birthday: {3}
Location : {4}
Education: {5}",
                    Session.LoggedInUser.Name,
                    Session.LoggedInUser.Gender,
                    Session.LoggedInUser.RelationshipStatus,
                    Session.LoggedInUser.Birthday,
                    Session.LoggedInUser.Location.Name,
                    Session.LoggedInUser.Educations);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void friendsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchFriends();
        }

        private void lastPostLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchLastPost();
        }

        private void groupsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchGroups();
        }

        private void eventLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchEvent();
        }

        private void fetchFriends()
        {
            try
            {
                friendsListBox.Items.Clear();
                friendsListBox.DisplayMember = "Name";
                foreach (User friend in Session.LoggedInUser.Friends)
                {
                    friendsListBox.Items.Add(friend);
                    friend.ReFetch(DynamicWrapper.eLoadOptions.Basic);
                }

                if (friendsListBox.Items.Count == 0)
                {
                    MessageBox.Show("There are no Friends to retrieve");
                }
            }
            catch(Exception e)
            {
                this.friendsListBox.Items.Add(e);
            }
        }

        private void fetchLastPost()
        {
            try
            {
                lastPostListBox.Items.Clear();
                List<Post> listOfPosts = new List<Post>(Session.LoggedInUser.Posts);
                foreach(Post userPost in listOfPosts)
                {
                    if(userPost.Message != null)
                    {
                        lastPostListBox.Items.Add(userPost.Message);
                    }
                    else if(userPost.Caption != null)
                    {
                        lastPostListBox.Items.Add(userPost.Caption);
                    }
                    else
                    {
                        lastPostListBox.Items.Add(string.Format("[{0}]", userPost.Type));
                    }
                }

                if(listOfPosts.Count == 0)
                {
                    MessageBox.Show("There is no post to show");
                }
            }
            catch(Exception e)
            {
                lastPostListBox.Items.Add(e.Message);
            }
        }

        private void fetchGroups()
        {
            try
            {
                groupsListBox.Items.Clear();
                groupsListBox.DisplayMember = "Name";
                List<Group> listOfGroups = new List<Group>(Session.LoggedInUser.Groups);

                foreach (Group group in listOfGroups)
                {
                    groupsListBox.Items.Add(group);
                }

                if (listOfGroups.Count == 0)
                {
                    MessageBox.Show("Not found any group");
                }
            }
            catch (Exception e)
            {
                lastPostListBox.Items.Add(e.Message);
            }
        }

        private void fetchEvent()
        {
            try
            {
                eventListBox.Items.Clear();
                eventListBox.DisplayMember = "Name";
                List<Event> listOfEvents = new List<Event>(Session.LoggedInUser.Events);

                foreach (Event facebookEvent in listOfEvents)
                {
                    eventListBox.Items.Add(facebookEvent);
                }

                if (listOfEvents.Count == 0)
                {
                    MessageBox.Show("Not found any event");
                }
            }
            catch (Exception e)
            {
                lastPostListBox.Items.Add(e.Message);
            }
        }
    }
}
