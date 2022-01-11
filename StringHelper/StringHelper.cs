using System.Text.RegularExpressions;

namespace StringHelper
{
    public static class StringHelper
    {
        public static List<string> FindMaxSequenceForEveryWord(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException("str");
            }

            var result = new List<string>();

            // Delete all tabs
            string withoutTabs = Regex.Replace(str, @"\s+", " ");

            // Get all words
            var words = withoutTabs.Split(' ').ToList();

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
                            currentCharacter = word[j-1].ToString();
                            wordMaximum = currentMax;
                        }

                        currentMax = 1;
                    }
                }
                result.Add(currentCharacter.ToString() + " " + wordMaximum.ToString());

                wordMaximum = 0;
                currentMax = 0;
            }
            return result;
        }
    }
}