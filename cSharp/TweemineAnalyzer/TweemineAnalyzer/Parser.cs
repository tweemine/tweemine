using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TweemineAnalyzer
{
    class Parser
    {
        public static List<string> ParseTheText(string txt)
        {
            List<string> matchDataList = new List<string>();
            string[] data = txt.Split(' ');

            Regex word = new Regex(@"^[\w]+$");

            // This is not the best solution but it's enough for now.
            Regex link = new Regex(@"^([.]*)(www\.|https?:\/\/)([\w]+)([.]*)$");

            Regex hashtag = new Regex(@"^#[\w]+$");
            Regex mention = new Regex(@"^@[\w]+$");

            foreach (string s in data)
            {
                // There is some "\n" characters in tweets. So we should remove them.
                string cleared = s.Replace("\\n", string.Empty);

                // If word is a link, hashtag or mention, just pass the other one.
                if (link.IsMatch(s) || hashtag.IsMatch(s) || mention.IsMatch(s))
                    continue;

                // We do this because of punctuation characters. e.g. "güzeldi..."
                string trimmed = s.Trim(' ',',','-','!','#','&','.');
                
                if ( word.IsMatch(trimmed) )
                {
                    if(string.IsNullOrEmpty(trimmed) == false)
                        matchDataList.Add(trimmed);
                }
            }
            
            return matchDataList;
        }
    }
}
