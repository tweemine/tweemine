using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace TweemineAnalyzer
{
    class Analyser
    {
        #region Variables

        private static string wordsPath = Path.Combine("..", "..", "..", "..", "..", "tweets", "words.json");

        private Dictionary<string, Word> wordDict;
        private TweetData[] tweets;
        private Word[]      words;
        private string[]    labels;

        // Max word count per tweet. This needed for Neural Network.
        private int maxWordPerTweet;

        // Unique word count
        private int uniqueWordCount;

        // Total label count
        private int labelCount;

        // Tweet count
        private int tweetCount;

        #endregion

        #region Constructor

        public Analyser(TweetData[] tweets, string[] labels)
        {
            this.tweets     = tweets;
            this.tweetCount = tweets.Length;
            this.labels     = labels;
            this.labelCount = labels.Length;
            this.wordDict   = new Dictionary<string, Word>();
        }

        #endregion

        #region Analyser Methods

        public void Analyse()
        {
            // We keep words because later we may want to save it.
            words = AnalyseWords();
            Array.Sort(words);

            this.uniqueWordCount = words.Length;
        }

        private Word[] AnalyseWords()
        {
            int id = 1;

            for(int i = 0; i < tweets.Length; i++)
            {
                if (tweets[i].words.Length > maxWordPerTweet)
                    maxWordPerTweet = tweets[i].words.Length;

                for(int j = 0; j < tweets[i].words.Length; j++)
                {
                    string word = tweets[i].words[j];
                    if(wordDict.ContainsKey(word) == true)
                    {
                        wordDict[word].count++;
                    }
                    else
                    {
                        wordDict.Add(word, new Word(id++, 1, word));
                    }
                }
            }

            List<Word> wordList = new List<Word>();
            foreach(KeyValuePair<string, Word> p in wordDict)
            {
                wordList.Add(p.Value);
            }

            return wordList.ToArray();
        }

        #endregion

        #region Read-Write

        private static void WriteWordsToJson(object obj)
        {
            using (TextWriter textWriter = new StreamWriter(wordsPath))
            {
                //create a new json serializer object for serialazation
                JsonSerializer jsonSerializer = new JsonSerializer();

                //serialize data
                string jsonText = JsonConvert.SerializeObject(obj);
                textWriter.Write(jsonText);

                textWriter.Close();
            }
        }

        private static Word[] ReadWordsFromJson()
        {
            Word[] wordArr;

            if (File.Exists(wordsPath) == false)
                return null;

            //we wont need text reader after this scope so I am being sure GC has collected this ref.
            using (TextReader textReader = new StreamReader(wordsPath, Encoding.UTF8))
            {
                //Reading the json File
                string context = textReader.ReadToEnd();

                //Sending into JsonConvert.DeserializeObject for getting the data as TweetData array
                wordArr = JsonConvert.DeserializeObject<Word[]>(context);

                //close the file
                textReader.Close();
            }

            return wordArr;
        }

        #endregion

        #region Get Set Methods

        public int GetUniqueWordCount()
        {
            return this.uniqueWordCount;
        }

        public int GetTweetCount()
        {
            return this.tweetCount;
        }

        public int GetMaxWordPerTweet()
        {
            return maxWordPerTweet;
        }

        public int GetLabelCount()
        {
            return this.labelCount;
        }

        public Dictionary<string, Word> GetWordDictionary()
        {
            return this.wordDict;
        }

        public TweetData[] GetTweets()
        {
            return this.tweets;
        }

        public string[] GetLabels()
        {
            return this.labels;
        }

        #endregion

        #region Test

        public void Test()
        {
            Console.WriteLine("tweetCount: " + tweetCount);
            Console.WriteLine("labelCount: " + labelCount);
            Console.WriteLine("uniqueWordCount: " + uniqueWordCount);
            Console.WriteLine("maxWordPerTweet: " + maxWordPerTweet);
        }

        #endregion
    }
}
