using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace Ex02.Logic.facade
{
    public class PostAnalyzer
    {
        private readonly Dictionary<string, int> r_PatternAndThereAmountDictionary;
        private readonly User r_LoggedInUser;

        public PostAnalyzer()
        {
            r_LoggedInUser = Session.Instance.LoggedInUser;
            r_PatternAndThereAmountDictionary = new Dictionary<string, int>();
        }

        public Dictionary<string, int> PatternAndThereAmountDictionary => r_PatternAndThereAmountDictionary;

        public void Analyzer()
        {
            foreach (Post post in r_LoggedInUser.Posts)
            {
                if (!string.IsNullOrEmpty(post.Message))
                {
                    AnalyzerOperations.FindAndUpdatePatternThatMatch(r_PatternAndThereAmountDictionary, post.Message);
                }
            }
        }
    }
}
