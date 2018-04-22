using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TweemineAnalyzer
{
    class Parser
    {
        public static List<string> ParseTheText(string txt)
        {
            int minWordLength = 3;
            int maxWordLength = 7;

            List<string> matchDataList = new List<string>();
            string[] data = txt.Split(' ');

            Regex word = new Regex(@"^[\w]+$");

            // This is not the best solution but it's enough for now.
            Regex link = new Regex(@"(www\.|https?:\/\/)([\w+]+)\.");

            Regex hashtag = new Regex(@"^#[\w]+$");

            Regex mention = new Regex(@"^@[\w]+$");

            foreach (string s in data)
            {
                // If word is a link, hashtag or mention, just pass the other one.
                if (link.Match(s).Success || hashtag.IsMatch(s) || mention.IsMatch(s))
                    continue;

                string curr_word = s;

                // Remove all punctation characters.
                for (int i = 0; i < curr_word.Length; i++)
                {
                    if (char.IsPunctuation(curr_word[i]) == true)
                    {
                        curr_word = curr_word.Remove(i, 1);
                        i--;
                    }
                }

                if ( word.IsMatch(curr_word) )
                {
                    if (string.IsNullOrEmpty(curr_word) == false)
                    {
                        if (curr_word.Length < minWordLength)
                            continue;

                        if (curr_word.Length > maxWordLength)
                            curr_word = curr_word.Substring(0, maxWordLength);

                        // We convert characters to lower. e.g: "NiCe" == "nice"
                        matchDataList.Add(curr_word.ToLower());
                    }
                }
            }
            
            return matchDataList;
        }
    }
}
