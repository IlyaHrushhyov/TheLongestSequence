using Helpers;
using System.Text.RegularExpressions;

namespace StringHelper
{
    public static class StringSequenceHelper
    {
        private static List<string> GetAllWords(string incomingString)
        {
            // Delete all tabs
            string withoutTabs = Regex.Replace(incomingString, @"\s+", " ");

            // Get all words
            List<string> words = withoutTabs.Split(' ').ToList();

            return words;
        }

        public static List<SequenceData> FindMaxSequenceForEveryWord(string incomingString)
        {
            if (incomingString == null)
            {
                throw new ArgumentNullException(nameof(incomingString));
            }

            List<string> words = GetAllWords(incomingString);

            var result = new List<SequenceData>(words.Count);

            // Find different characters for every word
            int wordMaximum = 0;
            string currentCharacter = default;
            int currentMax = default;
            // Running through all words
            foreach (var word in words)
            {
                // Running through all characters
                for (int j = 0; j < word.Length; j++)
                {
                    // Running for every character

                    if ((j != 0) && (word[j] == word[j - 1]))
                    {
                        currentMax++;
                    }
                    else
                    {
                        if (currentMax > wordMaximum)
                        {
                            currentCharacter = word[j - 1].ToString();
                            wordMaximum = currentMax;
                        }
                        currentMax = 1;
                    }
                }
                result.Add(new SequenceData(currentCharacter, wordMaximum));

                wordMaximum = default;
                currentMax = default;
            }
            return result;
        }

    }
}