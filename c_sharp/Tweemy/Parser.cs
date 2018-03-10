using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tweemy
{
    class Parser
    {
        public static List<string> ParseTheText(string txt)
        {
            List<string> matchDataList = new List<string>();
            string[] data = txt.Split(' ','#');
            Regex reg = new Regex(@"^[\w]+$");

            foreach (var item in data)
            {
                string s = item.Trim(' ',',','-','!','#','&','.' );
           
                if (reg.IsMatch(s))
                {
                    if(string.IsNullOrEmpty(s) == false)
                        matchDataList.Add(s);
                }
            }
            
            return matchDataList;
        }
    }
}
