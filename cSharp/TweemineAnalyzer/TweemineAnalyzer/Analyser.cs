using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using System.Linq;

namespace TweemineAnalyzer
{
    [Serializable]
    class Analyser
    {
        #region Variables

        private static string wordsPath = Path.Combine("..", "..", "..", "..", "..", "tweets", "words.json");

        private Dictionary<string, Word> wordDict;
        private Dictionary<string, int> labelDict;
        private Dictionary<string, int> labelFreq;
        private TweetData[] tweets;
        private TweetData[] trainingTweets;
        private TweetData[] testingTweets;
        private Word[] words;
        private string[] labels;
        

        public TweetData[] Testings { get { return testingTweets; } }
        // Max word count per tweet. This needed for Neural Network.
        private int maxWordPerTweet;

        // Unique word count
        private int uniqueWordCount;

        // Total label count
        private int labelCount;

        // Tweet count
        private int tweetCount;

        //if the training data and testing data is random or not
        private bool isRandom;
        //what is the percentage of the testing data
        private int percentage;

        int testingCount;
        int trainingCount;

        #endregion

        #region Constructors
        public Analyser()
        {

        }

        public Analyser(TweetData[] tweets, string[] labels)
        {
            this.tweets = tweets;
            this.tweetCount = tweets.Length;
            this.labels = labels;
            this.labelCount = labels.Length;
            this.wordDict = new Dictionary<string, Word>();
            this.labelDict = new Dictionary<string, int>();
            this.labelFreq = new Dictionary<string, int>();

            TestingTweets = tweets;
            TrainingTweets = null;

            testingCount = tweetCount;
            trainingCount = 0;
        }

        public Analyser(TweetData[] tweets, string[] labels, int _percentage = 10, bool _isRandom = false)
        {
            this.tweets = tweets;
            this.tweetCount = tweets.Length;
            this.labels = labels;
            this.labelCount = labels.Length;
            this.wordDict = new Dictionary<string, Word>();
            this.labelDict = new Dictionary<string, int>();
            this.labelFreq = new Dictionary<string, int>();

            percentage = _percentage;
            isRandom = _isRandom;

            testingCount = (tweets.Length * percentage) / 100;
            trainingCount = tweets.Length - testingCount;

            TrainingTweets = new TweetData[trainingCount];
            TestingTweets = new TweetData[testingCount];

            SeperateTweets();

        }

        #endregion
        
        #region Helpers
        /// <summary>
        /// seperates tweets as training and testing data
        /// </summary>
        private void SeperateTweets()
        {
            List<TweetData> trainingList = new List<TweetData>();
            List<TweetData> testingList = new List<TweetData>();
            Random random = new Random();

            for (int i = 0; i < tweets.Length; i++)
            {
                if (isRandom)
                {
                    double rndVal = random.NextDouble();
                    if (rndVal > 0.7)
                    {
                        //training
                        if (trainingList.Count >= trainingCount)
                            testingList.Add(tweets[i]);
                        else
                            trainingList.Add(tweets[i]);
                    }
                    else
                    {
                        if (testingList.Count >= testingCount)
                            trainingList.Add(tweets[i]);
                        else
                            testingList.Add(tweets[i]);
                    } 
                }
                else
                {
                    if (trainingList.Count < trainingCount)
                        trainingList.Add(tweets[i]);
                    else
                        testingList.Add(tweets[i]);
                    
                }
            }

            TrainingTweets = trainingList.ToArray();
            TestingTweets  = testingList.ToArray(); 
        }
        #endregion

        #region Analyser Methods

        public void Analyse1()
        {
            // We keep words because later we may want to save it.
            words = AnalyseWords();
            Array.Sort(words);

            this.uniqueWordCount = words.Length;

            int idx = 0;
            foreach (string label in labels)
            {
                labelDict.Add(label, idx++);
            }

            GetLabelFreq();
        }

        public void Analyse2()
        {
            for(int i = 0; i < tweets.Length; i++)
            {
                string tweet = tweets[i].parsedTweet;
                for (int j = 0; j < tweet.Length; j++)
                {
                    if (Char.IsDigit(tweet[j]) == true)
                        tweets[i].digitCount++;

                    if (tweet[j] == ' ')
                        tweets[i].wordCount++;

                    if (Char.IsPunctuation(tweet[j]) == true)
                        tweets[i].punctuationMarkCount++;
                }

                tweets[i].wordCount++;
                tweets[i].avarageWordLength = (tweet.Length - tweets[i].wordCount) / tweets[i].wordCount;
            }
        }

        private Word[] AnalyseWords()
        {
            int id = 1;

            for (int i = 0; i < tweets.Length; i++)
            {
                if (tweets[i].words.Length > maxWordPerTweet)
                    maxWordPerTweet = tweets[i].words.Length;

                for (int j = 0; j < tweets[i].words.Length; j++)
                {
                    string word = tweets[i].words[j];
                    if (wordDict.ContainsKey(word) == true)
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
            foreach (KeyValuePair<string, Word> p in wordDict)
            {
                wordList.Add(p.Value);
            }

            return wordList.ToArray();
        }

        private void GetLabelFreq()
        {
            for(int i = 0; i < tweets.Length; i++)
            {
                if (tweets[i].users[0].labels == null)
                    continue;

                string label = tweets[i].users[0].labels[0];
                if (labelFreq.ContainsKey(label) == false)
                    labelFreq.Add(label, 1);                
                else
                    labelFreq[label]++;
            }
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

        #region Properties
        public double Accuracy { get; set; }
        public int UniqueWordCount
        {
            set { uniqueWordCount = value; }
            get
            {
                return uniqueWordCount;
            }
        }

        public int TweetCount
        {
            set { tweetCount = value; }
            get
            {
                return this.tweetCount;
            }
        }
        public int MaxWordPerTweet
        {
            set { maxWordPerTweet = value; }
            get
            {
                return maxWordPerTweet;
            }
        }


        public int LabelCount
        {
            set { labelCount = value; }
            get
            {
                return this.labelCount;
            }
        }

        public int TestingCount
        {
            set { testingCount = value; }
            get
            {
                return testingCount;
            }
        }

        public int TrainingCount
        {
            set { trainingCount = value; }
            get
            {
                return trainingCount;
            }
        }

        public Dictionary<string, Word> WordDictionary
        {
            set { wordDict = value; }
            get
            {
                return this.wordDict;
            }
        }

        public Dictionary<string, int> LabelDictioanary
        {
            set { labelDict = value; }
            get
            {
                return this.labelDict;
            }
        }

        public TweetData[] TrainingTweets
        {
            
            get
            {
                return this.trainingTweets;
            }
             set { trainingTweets = value; }
        }
        public TweetData[] Tweets
        {
            set { tweets = value; }
            get
            {
                return this.tweets;
            }
        }
        public TweetData[] TestingTweets
        {
          
            get
            {
                return this.testingTweets;
            }
             set { testingTweets = value; }
        }
        public string[] Labels
        {
            set { labels = value; }
            get
            {
                return this.labels;
            }
        }

        public Dictionary<string, int> LabelFreq
        {
            set { labelFreq = value; }
            get
            {
                return this.labelFreq;
            }
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
