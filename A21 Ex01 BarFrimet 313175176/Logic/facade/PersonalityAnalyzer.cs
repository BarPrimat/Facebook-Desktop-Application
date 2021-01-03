using System.Collections.Generic;
using Ex01.Logic.facade;
using FacebookWrapper.ObjectModel;

namespace Ex01.Logic
{
    public class PersonalityAnalyzer
    {
        private readonly int r_Sensitivity;
        private readonly PostAnalyzer r_PostAnalyzer;
        private readonly PhotoAnalyzer r_PhotoAnalyzer;

        public PersonalityAnalyzer(int i_Sensitivity)
        {
            r_Sensitivity = i_Sensitivity;
            r_PostAnalyzer = new PostAnalyzer();
            r_PhotoAnalyzer = new PhotoAnalyzer(); 
        }

        public List<string> Analyzer()
        {
            List<string> listToDisplay = new List<string>();

            r_PostAnalyzer.Analyzer();
            r_PhotoAnalyzer.Analyzer();
            Dictionary<string, int> patternAndThereAmountDictionary = AnalyzerOperations.UnionDictionaries(
                r_PostAnalyzer.PatternAndThereAmountDictionary, r_PhotoAnalyzer.PatternAndThereAmountDictionary);
            foreach (KeyValuePair<string, int> pair in patternAndThereAmountDictionary)
            {
                if(r_Sensitivity <= pair.Value)
                {
                    listToDisplay.Add(pair.Key);
                }
            }

            return listToDisplay;
        }
    }
}