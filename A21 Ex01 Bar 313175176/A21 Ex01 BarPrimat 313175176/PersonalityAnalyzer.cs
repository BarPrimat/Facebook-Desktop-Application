using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace DesktopGUI
{
    public class PersonalityAnalyzer
    {
        private readonly int r_Sensitivity;
        private readonly Dictionary<string, HashSet<string>> r_WordsAndPatternDictionary = new Dictionary<string, HashSet<string>>()
        {
            { "cat", new HashSet<string>() { "love pets", "love cats"}},
            { "dog", new HashSet<string>() { "love pets",  "love dogs"}},
            { "football", new HashSet<string>() { "love sport", "love football" }},
            { "soccer", new HashSet<string>() {"love sport", "love football"}},
            { "basketball", new HashSet<string>() {"love sport", "love basketball"}},
            { "handball", new HashSet<string>() {"love sport", "love handball"}},
            { "election", new HashSet<string>() {"interested in politics"}},
            { "trump", new HashSet<string>() {"interested in politics"}},
            { "biden", new HashSet<string>() {"interested in politics"}},
            { "gantz", new HashSet<string>() {"interested in politics"}},
            { "bibi", new HashSet<string>() {"interested in politics"}},
            { "netanyahu", new HashSet<string>() {"interested in politics"}},
            { "food", new HashSet<string>() {"interested in food"}},
            { "pasta", new HashSet<string>() {"interested in food", "interested in italian food"}},
            { "pizza", new HashSet<string>() {"interested in food", "interested in italian food"}},
            { "Sushi", new HashSet<string>() {"interested in food", "interested in asian food"}},
            { "test", new HashSet<string>() {"not a human"}},
            { "testt", new HashSet<string>() {"not a human"}},
            { "testtt", new HashSet<string>() {"not a human"}},
            { "robot", new HashSet<string>() {"interested in technology"}},
            { "york", new HashSet<string>() {"man of the world"}},
            { "london", new HashSet<string>() {"man of the world", "interested england"}},
            { "sidney", new HashSet<string>() {"man of the world", "interested in australia"}},
            { "berlin", new HashSet<string>() {"man of the world", "interested in germany"}},
            { "friends", new HashSet<string>() {"love the community"}},
            { "academic", new HashSet<string>() {"Interested in a degree"}},
            { "degree", new HashSet<string>() {"Interested in a degree"}},
            // Hebrew word for the testing 
            { "חתול", new HashSet<string>() { "love pets", "love pets cats"}},
            { "כלב", new HashSet<string>() { "love pets",  "love pets dogs"}},
            { "כדורגל", new HashSet<string>() {"love sport", "love football"}},
            { "כדורסל", new HashSet<string>() {"love sport", "love basketball"}},
            { "כדוריד", new HashSet<string>() {"love sport", "love handball"}},
            { "בחירות", new HashSet<string>() {"interested in politics"}},
            { "טרמפ", new HashSet<string>() {"interested in politics"}},
            { "ביידן", new HashSet<string>() {"interested in politics"}},
            { "גנץ", new HashSet<string>() {"interested in politics"}},
            { "ביבי", new HashSet<string>() {"interested in politics"}},
            { "נתניהו", new HashSet<string>() {"interested in politics"}},
            { "אוכל", new HashSet<string>() {"interested in food"}},
            { "פסטה", new HashSet<string>() {"interested in food", "interested in italian food"}},
            { "פיצה", new HashSet<string>() {"interested in food", "interested in italian food"}},
            { "סושי", new HashSet<string>() {"interested in food", "interested in asian food"}},
            { "בדיקה", new HashSet<string>() {"not a human"}},
            { "רובוט", new HashSet<string>() {"interested in technology"}},
            { "יורק", new HashSet<string>() {"man of the world"}},
            { "לונדון", new HashSet<string>() {"man of the world", "interested england"}},
            { "סידני", new HashSet<string>() {"man of the world", "interested in australia"}},
            { "ברלין", new HashSet<string>() {"man of the world", "interested in germany"}},
            { "חברים", new HashSet<string>() {"love the community"}},
            { "תואר", new HashSet<string>() {"Interested in a degree"}},
            { "בנות", new HashSet<string>() {"love the community"}},
            { "שווה", new HashSet<string>() {"nothing to learns"}},

        };
        private readonly Dictionary<string, int> r_PatternAndThereAmountDictionary;
        private static readonly HashSet<string> sr_StringExtension = new HashSet<string>(){",", ".", ":", ";", "[', ']", "(", ")", "<", ">", "!", "?", "@", "#", "*", "-", "'", "`", "'s"};

        public PersonalityAnalyzer(int i_Sensitivity)
        {
            r_Sensitivity = i_Sensitivity;
            r_PatternAndThereAmountDictionary = new Dictionary<string, int>();
        }

        public List<string> Analyzer()
        {
            List<string> listToDisplay = new List<string>();

            foreach(Post post in Session.LoggedInUser.Posts)
            {
                if(post.Message != null)
                {
                    string textAfterClear = clearStringFromExtensions(post.Message);
                    string[] textSplit = textAfterClear.Split();
                    foreach(string textToAnalyze in textSplit)
                    {
                        if(r_WordsAndPatternDictionary.ContainsKey(textToAnalyze))
                        {
                            HashSet<string> setOfPatternThatMatch = r_WordsAndPatternDictionary[textToAnalyze];
                            foreach (string patternThatMatch in setOfPatternThatMatch)
                            {
                                if(r_PatternAndThereAmountDictionary.ContainsKey(patternThatMatch))
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
            }

            foreach (KeyValuePair<string, int> pair in r_PatternAndThereAmountDictionary)
            {
                if(r_Sensitivity <= pair.Value)
                {
                    listToDisplay.Add(pair.Key);
                }
            }

            return listToDisplay;
        }

        private static string clearStringFromExtensions(string i_TextToClear)
        {
            i_TextToClear = i_TextToClear.ToLower();
            foreach(string extension in sr_StringExtension)
            {
                i_TextToClear = i_TextToClear.Replace(extension, string.Empty);
            }

            return i_TextToClear;
        }
    }
}
