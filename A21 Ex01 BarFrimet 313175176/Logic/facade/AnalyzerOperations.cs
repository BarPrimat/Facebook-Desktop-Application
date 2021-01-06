using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace Ex02.Logic.facade
{
    public class AnalyzerOperations
    {
        public static void FindAndUpdatePatternThatMatch(Dictionary<string, int>  i_PatternAndThereAmountDictionary, string i_TextToTest)
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
                        if (i_PatternAndThereAmountDictionary.ContainsKey(patternThatMatch))
                        {
                            // Add 1 to the amount of the found pattern
                            i_PatternAndThereAmountDictionary[patternThatMatch]++;
                        }
                        else
                        {
                            // Create a new pattern in r_PatternAndThereAmountDictionary
                            i_PatternAndThereAmountDictionary.Add(patternThatMatch, 1);
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

        public static Dictionary<string, int> UnionDictionaries(Dictionary<string, int> i_FirstDictionary, Dictionary<string, int> i_SecondDictionary)
        {
            Dictionary<string, int> unionDictionaries = new Dictionary<string, int>();

            foreach (KeyValuePair<string, int> pattern in i_FirstDictionary)
            {
                unionDictionaries.Add(pattern.Key, pattern.Value);
                if (i_SecondDictionary.ContainsKey(pattern.Key))
                {
                    unionDictionaries[pattern.Key] += pattern.Value;
                }
            }

            foreach (KeyValuePair<string, int> pattern in i_SecondDictionary)
            {
                if (!unionDictionaries.ContainsKey(pattern.Key))
                {
                    unionDictionaries.Add(pattern.Key, pattern.Value);
                }
            }

            return unionDictionaries;
        }
    }
}