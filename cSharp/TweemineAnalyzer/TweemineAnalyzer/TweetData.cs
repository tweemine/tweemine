﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweemineAnalyzer
{
    [Serializable]
    public class TweetData
    {
        public string tweet;
        public string parsedTweet;
        public bool labeled;
        public string[] words;
        public User[] users;
        public int wordCount;
        public int punctuationMarkCount;
        public int digitCount;
        public int avarageWordLength;
    }
}
