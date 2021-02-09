using System;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace Ex02.Logic.facade
{
    public class PhotoAnalyzer
    {
        private readonly Dictionary<string, int> r_PatternAndThereAmountDictionary;
        private readonly User r_LoggedInUser;

        public PhotoAnalyzer()
        {
            r_LoggedInUser = Session.Instance.LoggedInUser;
            r_PatternAndThereAmountDictionary = new Dictionary<string, int>();
        }

        public Dictionary<string, int> PatternAndThereAmountDictionary => r_PatternAndThereAmountDictionary;

        public void Analyzer()
        {
            PhotoIterator userPhotos = new PhotoIterator(r_LoggedInUser.Albums);
            var photoEnumerator = userPhotos.GetEnumerator();

            try
            {
                while (photoEnumerator.MoveNext())
                {
                    analyzeOptions(photoEnumerator.Current);
                }
            }
            catch { }
        }

        private void analyzeOptions(Photo i_Photo)
        {
            // Can add any Photo analyze parameters that needed
            if (!string.IsNullOrEmpty(i_Photo.Name))
            {
                AnalyzerOperations.FindAndUpdatePatternThatMatch(r_PatternAndThereAmountDictionary, i_Photo.Name);
            }

            if (!string.IsNullOrEmpty(i_Photo.Message))
            {
                AnalyzerOperations.FindAndUpdatePatternThatMatch(r_PatternAndThereAmountDictionary, i_Photo.Message);
            }
        }
    }
}