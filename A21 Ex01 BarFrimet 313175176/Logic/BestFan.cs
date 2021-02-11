using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace Ex03.Logic
{
    public class BestFan
    {
        private Dictionary<User, int> m_FriendsScore;
        private const bool k_CreateNewDictionary = true;
        private readonly User r_LoggedInUser = null;

        public BestFan()
        {
            r_LoggedInUser = Session.Instance.LoggedInUser;
        }

        public List<Tuple<User, int>> FindBestFans(int i_NumberBestFanToReturn, int i_ScoreForLikeInPhoto, int i_ScoreForCommentInPhoto, int i_ScoreForLikeInPost, int i_ScoreForCommentInPost)
        {
            List<Tuple<User, int>> listOfBestFan = new List<Tuple<User, int>>();

            calculatePhotoScore(i_ScoreForLikeInPhoto, i_ScoreForCommentInPhoto, k_CreateNewDictionary);
            calculatePostScore(i_ScoreForLikeInPost, i_ScoreForCommentInPost, !k_CreateNewDictionary);
            for (int i = 0; i < i_NumberBestFanToReturn; i++)
            {
                Tuple<User, int> newBestFan = FindNextBestFan();
                if(newBestFan != null)
                {
                    listOfBestFan.Add(newBestFan);
                }
            }

            return listOfBestFan;
        }

        public Tuple<User, int> FindNextBestFan()
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
            if (i_CreateNewDictionary)
            {
                m_FriendsScore = new Dictionary<User, int>();
            }

            if (i_ScoreForLike != 0 || i_ScoreForComment != 0)
            {
                foreach (Post post in r_LoggedInUser.Posts)
                {
                    calculatePostLikeScore(post, i_ScoreForLike);
                    calculatePostCommentScore(post, i_ScoreForComment);
                }
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

            if (i_ScoreForLike != 0 || i_ScoreForComment != 0)
            {
                foreach (Photo photo in r_LoggedInUser.PhotosTaggedIn)
                {
                    calculatePhotoLikeScore(photo, i_ScoreForLike);
                    calculatePhotoCommentScore(photo, i_ScoreForComment);
                }
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