using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using Ex01.Logic;

namespace Ex01.DesktopGUI
{
    public partial class HomeForm : Form
    {
        private const bool k_ObjectIsVisible = true;
        private const bool k_EnabledAllForms = true;
        private const string k_LoginText = "Login";
        private const string k_LogoutText = "Logout";
        private static bool s_IsAlreadyLogIn = false;
        private readonly MainMenuForm r_ParentForm;

        public HomeForm(MainMenuForm i_ParentForm)
        {
            InitializeComponent();
            r_ParentForm = i_ParentForm;
            if(s_IsAlreadyLogIn)
            {
                loginOrLogoutButton.Text = k_LogoutText;
                setInfo();
            }
            else
            {
                loginOrLogoutButton.Text = k_LoginText;
                enabledOrDisableAllForms(!k_EnabledAllForms);
            }
        }

        private void loginOrLogoutButton_Click(object sender, EventArgs e)
        {
            fetchLoginOrLogout();
        }

        private void fetchLoginOrLogout()
        {
            bool needToEnable = false;
            try
            {
                if (loginOrLogoutButton.Text == k_LoginText)
                {
                    Session.LoginAndInit();
                    if (Session.Result.LoggedInUser != null)
                    {
                        setInfo();
                        loginOrLogoutButton.Text = k_LogoutText;
                        needToEnable = k_EnabledAllForms;
                        s_IsAlreadyLogIn = true;
                    }
                }
                else
                {
                    clearAllItemsInScreen();
                    Session.Logout();
                    loginOrLogoutButton.Text = k_LoginText;
                    MessageBox.Show("You are now logged out!");
                    s_IsAlreadyLogIn = false;
                }

                enabledOrDisableAllForms(needToEnable);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
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
            r_ParentForm.EnabledOrDisableAllFormButtons(i_EnabledAllForms);
            this.friendsLinkLabel.Enabled = i_EnabledAllForms;
            this.lastPostLinkLabel.Enabled = i_EnabledAllForms;
            this.groupsLinkLabel.Enabled = i_EnabledAllForms;
            this.eventLinkLabel.Enabled = i_EnabledAllForms;
            this.statusTextBox.Enabled = i_EnabledAllForms;
            this.checkInLinkLabel.Enabled = i_EnabledAllForms;
            if(!i_EnabledAllForms)
            {
                statusTextBox.Text = "What's on your mind?";
                postStatusButton.Enabled = i_EnabledAllForms;
            }
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

        // DEPRECATED function
        private void postStatusButton_Click(object sender, EventArgs e)
        {
            fetchPostStatus();
        }

        private void friendsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchFriends();
        }

        private void lastPostLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchLastPosts();
        }

        private void groupsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchGroups();
        }

        private void eventLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchEvent();
        }

        private void checkInLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchCheckIn();
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

        private void fetchLastPosts()
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

        private void statusTextBox_TextChanged(object sender, EventArgs e)
        {
            postStatusButton.Enabled = ("What's on your mind?" != postStatusButton.Text) && (postStatusButton.Text != string.Empty);
        }

        // DEPRECATED function
        private void fetchPostStatus()
        {
            try
            {
                Session.LoggedInUser.PostStatus(statusTextBox.Text);
                MessageBox.Show("The Status Posted!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void fetchCheckIn()
        {
            try
            {
                checkInListBox.Items.Clear();
                this.checkInListBox.Items.Clear();
                foreach (Checkin userCheckIn in Session.LoggedInUser.Checkins)
                {
                    this.checkInListBox.Items.Add(string.Format("Location: {0}, {1}   Time: {2}", userCheckIn.Place.Location.Country, userCheckIn.Place.Location.City, userCheckIn.UpdateTime));
                }

                if (checkInListBox.Items.Count == 0)
                {
                    checkInListBox.Items.Add("No Check Ins to retrive");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}