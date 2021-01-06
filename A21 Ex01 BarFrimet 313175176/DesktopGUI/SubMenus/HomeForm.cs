using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using DesktopGUI;
using FacebookWrapper.ObjectModel;
using Ex02.Logic;

namespace Ex02.DesktopGUI
{
    public partial class HomeForm : Form
    {
        private const bool k_ObjectIsVisible = true;
        private readonly MainMenuForm r_ParentForm;
        private readonly User r_LoggedInUser = null;

        public HomeForm(MainMenuForm i_ParentForm)
        {
            InitializeComponent();
            r_LoggedInUser = Session.Instance.LoggedInUser;
            r_ParentForm = i_ParentForm;
            showInfo();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            fetchLogout();
        }

        private void fetchLogout()
        {
            try
            {
                Session.Instance.Logout();
                MessageBox.Show("You are now logged out!");
                this.Hide();
                r_ParentForm.Hide();
                new LoginForm().ShowDialog();
                this.Close();
                r_ParentForm.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void showInfo()
        {
            try
            {
                userPictureBox.LoadAsync(r_LoggedInUser.PictureNormalURL);
                welcomeLabel.Text = "Welcome " + r_LoggedInUser.FirstName;
                welcomeLabel.Visible = k_ObjectIsVisible;
                userBindingSource.DataSource = r_LoggedInUser;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        // DEPRECATED function
        private void postStatusButton_Click(object sender, EventArgs e)
        {
            new Thread(fetchPostStatus).Start();
        }

        private void friendsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(fetchFriends).Start();
        }

        private void lastPostLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(fetchLastPosts).Start();
        }

        private void groupsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(fetchGroups).Start();
        }

        private void eventLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(fetchEvent).Start();
        }

        private void checkInLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(fetchCheckIn).Start();
        }

        private void fetchFriends()
        {
            try
            {
                friendsListBox.Invoke(new Action(() => friendsListBox.Items.Clear()));
                friendsListBox.Invoke(new Action(() => friendsListBox.DisplayMember = "Name"));
                foreach (User friend in r_LoggedInUser.Friends)
                {
                    friendsListBox.Invoke(new Action(() => friendsListBox.Items.Add(friend)));
                    friend.ReFetch(DynamicWrapper.eLoadOptions.Basic);
                }

                if (friendsListBox.Items.Count == 0)
                {
                    MessageBox.Show("There are no Friends to retrieve");
                }
            }
            catch(Exception e)
            {
                showMessageBoxIfFormIsAccessible(e.Message);
            }
        }

        private void fetchLastPosts()
        {
            try
            {
                lastPostListBox.Invoke(new Action(() => lastPostListBox.Items.Clear()));
                List<Post> listOfPosts = new List<Post>(r_LoggedInUser.Posts);
                foreach(Post userPost in listOfPosts)
                {
                    if(userPost.Message != null)
                    {
                        lastPostListBox.Invoke(new Action(() => lastPostListBox.Items.Add(userPost.Message)));
                    }
                    else if(userPost.Caption != null)
                    {
                        lastPostListBox.Invoke(new Action(() => lastPostListBox.Items.Add(userPost.Caption)));
                    }
                    else
                    {
                        lastPostListBox.Invoke(new Action(() => lastPostListBox.Items.Add(string.Format("[{0}]", userPost.Type))));
                    }
                }

                if(listOfPosts.Count == 0)
                {
                    MessageBox.Show("There is no post to show");
                }
            }
            catch(Exception e)
            {
                showMessageBoxIfFormIsAccessible(e.Message);
            }
        }

        private void fetchGroups()
        {
            try
            {
                groupsListBox.Invoke(new Action(() => groupsListBox.Items.Clear()));
                groupsListBox.Invoke(new Action(() => groupsListBox.DisplayMember = "Name"));
                List<Group> listOfGroups = new List<Group>(r_LoggedInUser.Groups);

                foreach (Group group in listOfGroups)
                {
                    groupsListBox.Invoke(new Action(() => groupsListBox.Items.Add(group)));
                }

                if (listOfGroups.Count == 0)
                {
                    MessageBox.Show("Not found any group");
                }
            }
            catch (Exception e)
            {
                showMessageBoxIfFormIsAccessible(e.Message);
            }
        }

        private void fetchEvent()
        {
            try
            {
                eventListBox.Invoke(new Action(() => eventListBox.Items.Clear()));
                eventListBox.Invoke(new Action(() => eventListBox.DisplayMember = "Name"));
                List<Event> listOfEvents = new List<Event>(r_LoggedInUser.Events);

                foreach (Event facebookEvent in listOfEvents)
                {
                    eventListBox.Invoke(new Action(() => eventListBox.Items.Add(facebookEvent)));
                }

                if (listOfEvents.Count == 0)
                {
                    MessageBox.Show("Not found any event");
                }
            }
            catch (Exception e)
            {
                showMessageBoxIfFormIsAccessible(e.Message);
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
                r_LoggedInUser.PostStatus(statusTextBox.Text);
                MessageBox.Show("The Status Posted!");
            }
            catch (Exception exception)
            {
                MessageBox.Show("The status not posted! this is a DEPRECATED function ");
            }
        }

        private void fetchCheckIn()
        {
            try
            {
                checkInListBox.Invoke(new Action(() => checkInListBox.Items.Clear()));
                foreach(Checkin userCheckIn in r_LoggedInUser.Checkins)
                {
                    if(userCheckIn.Place != null)
                    {
                        checkInListBox.Invoke(
                            new Action(
                                () => this.checkInListBox.Items.Add(
                                    string.Format(
                                        "Location: {0}, {1}   Time: {2}",
                                        userCheckIn.Place.Location.Country,
                                        userCheckIn.Place.Location.City,
                                        userCheckIn.UpdateTime))));
                    }
                    else
                    {
                        checkInListBox.Invoke(
                            new Action(() => checkInListBox.Items.Add($"Time: {userCheckIn.UpdateTime}")));
                    }

                    if(checkInListBox.Items.Count == 0)
                    {
                        checkInListBox.Invoke(new Action(() => checkInListBox.Items.Add("No Check Ins to retrieve")));
                        return;
                    }
                }
            }
            catch(Exception ex)
            {
                showMessageBoxIfFormIsAccessible(ex.Message);
            }
        }

        private void showMessageBoxIfFormIsAccessible(string i_ExceptionMessage)
        {
            if (this.IsAccessible)
            {
                MessageBox.Show(i_ExceptionMessage);
            }
        }
    }
}