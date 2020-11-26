using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex01.Logic
{
    public class WordsDatabase
    {
        // String extension that will needed to remove before finding any pattern
        private static readonly HashSet<string> sr_StringExtension = new HashSet<string>() { ",", ".", ":", ";", "[', ']", "(", ")", "<", ">", "!", "?", "@", "#", "*", "-", "'", "`", "'s", "ing" };
        // Can replace in the future with NLP database that learn the pattern from the facebook text
        // Or replace with real database in XML or json 
        private static readonly Dictionary<string, HashSet<string>> sr_WordsAndPatternDictionary = new Dictionary<string, HashSet<string>>()
            {
                { "cat", new HashSet<string>() { "love pets", "love cats"}},
                { "dog", new HashSet<string>() { "love pets",  "love dogs"}},
                { "koala", new HashSet<string>() { "love pets",  "interested in australia"}},
                { "pig", new HashSet<string>() { "love pets"}},
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
                { "testing", new HashSet<string>() {"not a human"}},
                { "null", new HashSet<string>() {"not a human"}},
                { "robot", new HashSet<string>() {"interested in technology"}},
                { "york", new HashSet<string>() {"man of the world"}},
                { "london", new HashSet<string>() {"man of the world", "interested england"}},
                { "sidney", new HashSet<string>() {"man of the world", "interested in australia"}},
                { "berlin", new HashSet<string>() {"man of the world", "interested in germany"}},
                { "barcelona", new HashSet<string>() {"man of the world"}},
                { "world", new HashSet<string>() {"man of the world", "interested in spain"}},
                { "friend", new HashSet<string>() {"love the community"}},
                { "friends", new HashSet<string>() {"love the community"}},
                { "academic", new HashSet<string>() {"Interested in a degree"}},
                { "degree", new HashSet<string>() {"Interested in a degree"}},
                { "app", new HashSet<string>() {"Interested in code"}},
                { "debug", new HashSet<string>() {"Interested in code"}},
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
                { "ברצלונה", new HashSet<string>() {"man of the world", "interested in spain"}},
                { "חברים", new HashSet<string>() {"love the community"}},
                { "תואר", new HashSet<string>() {"Interested in a degree"}}
                /* Only for testing
                { "בנות", new HashSet<string>() {"love the community"}},
                { "שווה", new HashSet<string>() {"nothing to learns"}},
                { "שלי", new HashSet<string>() {"nothing to learns"}}
                */
            };

        public static Dictionary<string, HashSet<string>> WordsAndPatternDictionary => sr_WordsAndPatternDictionary;

        public static HashSet<string> StringExtension => sr_StringExtension;
    }
}
