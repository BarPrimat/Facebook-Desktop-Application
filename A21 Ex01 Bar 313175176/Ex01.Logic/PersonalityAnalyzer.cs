using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace Ex01.Logic
{
    public class PersonalityAnalyzer
    {
        private readonly int r_Sensitivity;
        private readonly Dictionary<string, int> r_PatternAndThereAmountDictionary;

        public PersonalityAnalyzer(int i_Sensitivity)
        {
            r_Sensitivity = i_Sensitivity;
            r_PatternAndThereAmountDictionary = new Dictionary<string, int>();
        }

        public List<string> Analyzer()
        {
            List<string> listToDisplay = new List<string>();

            postAnalyzer();
            photoAnalyzer();
            foreach (KeyValuePair<string, int> pair in r_PatternAndThereAmountDictionary)
            {
                if(r_Sensitivity <= pair.Value)
                {
                    listToDisplay.Add(pair.Key);
                }
            }

            return listToDisplay;
        }

        private void photoAnalyzer()
        {
            foreach(Album album in Session.LoggedInUser.Albums)
            {
                foreach(Photo photo in album.Photos)
                {
                    if(!string.IsNullOrEmpty(photo.Name))
                    {
                        findAndUpdatePatternThatMatch(photo.Name);
                    }
                }
            }
        }

        private void postAnalyzer()
        {
            foreach (Post post in Session.LoggedInUser.Posts)
            {
                if (!string.IsNullOrEmpty(post.Message))
                {
                    findAndUpdatePatternThatMatch(post.Message);
                }
            }
        }

        private void findAndUpdatePatternThatMatch(string i_TextToTest)
        {
            string textAfterClear = clearStringFromExtensions(i_TextToTest);
            string[] textSplit = textAfterClear.Split();

            foreach (string textToAnalyze in textSplit)
            {
                if (WordsDatabase.WordsAndPatternDictionary.ContainsKey(textToAnalyze))
                {
                    // The textToAnalyze string is familiar pattern with the pattern dictionary
                    HashSet<string> setOfPatternThatMatch = WordsDatabase.WordsAndPatternDictionary[textToAnalyze];
                    foreach (string patternThatMatch in setOfPatternThatMatch)
                    {
                        if (r_PatternAndThereAmountDictionary.ContainsKey(patternThatMatch))
                        {
                            // Add 1 to the amount of the found pattern
                            r_PatternAndThereAmountDictionary[patternThatMatch]++;
                        }
                        else
                        {
                            // Create a new pattern in r_PatternAndThereAmountDictionary
                            r_PatternAndThereAmountDictionary.Add(patternThatMatch, 1);
                        }
                    }
                }
            }
        }

        private static string clearStringFromExtensions(string i_TextToClear)
        {
            i_TextToClear = i_TextToClear.ToLower();
            foreach (string extension in WordsDatabase.StringExtension)
            {
                i_TextToClear = i_TextToClear.Replace(extension, string.Empty);
            }

            return i_TextToClear;
        }
    }
}