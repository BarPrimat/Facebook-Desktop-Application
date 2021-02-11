using System;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace Ex03.Logic
{
    public sealed class Session
    {
        private User m_LoggedInUser = null;
        private LoginResult m_LoginResult = null;
        private static volatile Session s_Instance = null;
        private static readonly object sr_DoubleLock = new Object();

        private Session()
        {
        }

        public static Session Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (sr_DoubleLock)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new Session();
                        }
                    }
                }

                return s_Instance;
            }
        }

        public User LoggedInUser => m_LoggedInUser;

        public LoginResult Result => m_LoginResult;

        public void LoginAndInit()
        {
            try
            {
                // We can disabled the code line below and the CollectionLimit will be around 25-50
                // FacebookWrapper.FacebookService.s_CollectionLimit = 200;

                if (m_LoginResult == null)
                {
                    // Owner: design.patterns
                    // Use the FacebookService.Login method to display the login form to any user who wish to use this application.
                    // You can then save the result.AccessToken for future auto-connect to this user:
                    m_LoginResult = FacebookService.Login(
                        "1328648187483117", // (desig patter's "Design Patterns Course App 2.4" app)
                        "public_profile",
                        "email",
                        // "publish_to_groups",
                        "user_birthday",
                        "user_age_range",
                        "user_gender",
                        "user_link",
                        "user_tagged_places",
                        "user_videos",
                        // "publish_to_groups",
                        // "groups_access_member_info",
                        "user_friends",
                        "user_events",
                        "user_likes",
                        "user_location",
                        "user_photos",
                        "user_posts",
                        "user_hometown"

                    // DEPRECATED PERMISSIONS:
                    //"publish_actions"
                    //"user_about_me",
                    //"user_education_history",
                    //"user_actions.video",
                    //"user_actions.news",
                    //"user_actions.music",
                    //"user_actions.fitness",
                    //"user_actions.books",
                    //"user_games_activity",
                    //"user_managed_groups",
                    //"user_relationships",
                    //"user_relationship_details",
                    //"user_religion_politics",
                    //"user_tagged_places",
                    //"user_website",
                    //"user_work_history",
                    //"read_custom_friendlists",
                    //"read_page_mailboxes",
                    //"manage_pages",
                    //"publish_pages",
                    //"publish_actions",
                    //"rsvp_event"
                    //"user_groups" (This permission is only available for apps using Graph API version v2.3 or older.)
                    //"user_status" (This permission is only available for apps using Graph API version v2.3 or older.)
                    /// "read_mailbox", (This permission is only available for apps using Graph API version v2.3 or older.)
                    // "read_stream", (This permission is only available for apps using Graph API version v2.3 or older.)
                    // "manage_notifications", (This permission is only available for apps using Graph API version v2.3 or older.)

                    );
                    // The documentation regarding facebook login and permissions can be found here: 
                    // https://developers.facebook.com/docs/facebook-login/permissions#reference

                }

                if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
                {
                    m_LoggedInUser = m_LoginResult.LoggedInUser;
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Logout()
        {
            m_LoggedInUser = null;
            m_LoginResult = null;
            s_Instance = null;
        }
    }
}