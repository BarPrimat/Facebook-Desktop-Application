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
        private const bool k_CreateNewDictionary = true;
        private const int k_NumberOfBestFanToShow = 3;
        private Dictionary<User, int> m_FriendsScore;

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
            List<User> listOfBestFan = FindBestFan(k_NumberOfBestFanToShow, (int)scoreForLikeInPhotoNumericUpDown.Value, (int)scoreForCommentInPhotoNumericUpDown.Value, (int)scoreForLikeInPostNumericUpDown.Value, (int)scoreForCommentInPostNumericUpDown.Value);

            bestFanListBox.Items.Clear();
            bestFanListBox.DisplayMember = "Name";
            int counterOfBestFan = 0;
            foreach (User newFan in listOfBestFan)
            {
                string.Format("{0}. {1} with the score: {2}", i, maxUserScore.Name, maxScore);
                bestFanListBox.Items.Add(newFan);
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

        public List<User> FindBestFan(int i_NumberBestFanToReturn, int i_ScoreForLikeInPhoto, int i_ScoreForCommentInPhoto, int i_ScoreForLikeInPost, int i_ScoreForCommentInPost)
        {
            List<User> listOfBestFan = new List<User>();

            calculatePhotoScore(i_ScoreForLikeInPhoto, i_ScoreForCommentInPhoto, k_CreateNewDictionary);
            calculatePostScore(i_ScoreForLikeInPost, i_ScoreForCommentInPost, !k_CreateNewDictionary);
            for (int i = 0; i < i_NumberBestFanToReturn; i++)
            {
                listOfBestFan.Add(FindNextBestFan());
            }

            return listOfBestFan;
        }

        private Tuple<User, int> FindNextBestFan()
        {
            int maxScore = 0;
            User maxUserScore = null;

            foreach (KeyValuePair<User, int> pair in m_FriendsScore)
            {
                if (pair.Value > maxScore)
                {
                    maxScore = pair.Value;
                    maxUserScore = pair.Key;
                }
            }

            if (maxUserScore != null)
            {
                m_FriendsScore.Remove(maxUserScore);
            }

            return new Tuple<User, int>(maxUserScore, maxScore);
        }

        private void calculatePostScore(int i_ScoreForLike, int i_ScoreForComment, bool i_CreateNewDictionary)
        {
            if(i_CreateNewDictionary)
            {
                m_FriendsScore = new Dictionary<User, int>();
            }

            try
            {
                if(i_ScoreForLike != 0 || i_ScoreForComment != 0)
                {
                    foreach(Post post in Session.LoggedInUser.Posts)
                    {
                        calculatePostLikeScore(post, i_ScoreForLike);
                        calculatePostCommentScore(post, i_ScoreForComment);
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void calculatePostCommentScore(Post i_Post, int i_ScoreForComment)
        {
            if (i_ScoreForComment != 0)
            {
                foreach (Comment userThatCommentedOnPhoto in i_Post.Comments)
                {
                    findAndUpdateScoreInFriendsScore(userThatCommentedOnPhoto.From, i_ScoreForComment);
                }
            }
        }

        private void calculatePostLikeScore(Post i_Post, int i_ScoreForLike)
        {
            if (i_ScoreForLike != 0)
            {
                foreach (User userThatLikePost in i_Post.LikedBy)
                {
                    findAndUpdateScoreInFriendsScore(userThatLikePost, i_ScoreForLike);
                }
            }
        }

        private void calculatePhotoScore(int i_ScoreForLike, int i_ScoreForComment, bool i_CreateNewDictionary)
        {
            if (i_CreateNewDictionary)
            {
                m_FriendsScore = new Dictionary<User, int>();
            }

            try
            {
                if (i_ScoreForLike != 0 || i_ScoreForComment != 0)
                {
                    foreach (Photo photo in Session.LoggedInUser.PhotosTaggedIn)
                    {
                        calculatePhotoLikeScore(photo, i_ScoreForLike);
                        calculatePhotoCommentScore(photo, i_ScoreForComment);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void calculatePhotoCommentScore(Photo i_Photo, int i_ScoreForComment)
        {
            if (i_ScoreForComment != 0)
            {
                foreach (Comment userThatCommentedOnPhoto in i_Photo.Comments)
                {
                    findAndUpdateScoreInFriendsScore(userThatCommentedOnPhoto.From, i_ScoreForComment);
                }
            }
        }

        private void calculatePhotoLikeScore(Photo i_Photo, int i_ScoreForLike)
        {
            if (i_ScoreForLike != 0)
            {
                foreach (User userThatLikePhoto in i_Photo.LikedBy)
                {
                    findAndUpdateScoreInFriendsScore(userThatLikePhoto, i_ScoreForLike);
                }
            }
        }

        private void findAndUpdateScoreInFriendsScore(User i_UserThatLikePhoto, int i_ScoreForLike)
        {
            if (m_FriendsScore.ContainsKey(i_UserThatLikePhoto))
            {
                m_FriendsScore[i_UserThatLikePhoto] += i_ScoreForLike;
            }
            else
            {
                m_FriendsScore.Add(i_UserThatLikePhoto, i_ScoreForLike);
            }
        }
    }
}