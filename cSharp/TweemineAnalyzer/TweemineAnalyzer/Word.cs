﻿using System;

namespace TweemineAnalyzer
{
    class Word : IComparable
    {
        public int id;
        public int count;
        public string word;

        public Word(int id, int count, string word)
        {
            this.id    = id;
            this.count = count;
            this.word  = word;
        }

        public int CompareTo(object obj)
        {
            if (this.count < ((Word)obj).count)
                return 1;
            else if(this.count > ((Word)obj).count)
                return -1;
            else
                return 0;
        }
    }
}
