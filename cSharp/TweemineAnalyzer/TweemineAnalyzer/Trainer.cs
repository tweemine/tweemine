using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TweemineNeuralNetwork;

namespace TweemineAnalyzer
{
    public enum TrainingType
    {
        WORD_TRAINING,
        FEATURE_TRAINING
    }

    class Trainer
    {
        #region Variables

        Dictionary<string, Word> wordDict;
        Dictionary<string, int>  labelDict;
        Analyser                 analyser;
        NeuralNetwork            nn;
        TweetData[]              trainingTweets;
        TweetData[]              testingTweets;
        string[]                 labels;

        #endregion

        #region Constructors

        //for serialization
        public Trainer()
        {

        }

        public Trainer(Analyser _analyser, int _hiddenNodes, double _learningRate, TrainingType type)
        {
            analyser = _analyser;
            if (analyser != null)
            {
                trainingTweets = _analyser.TrainingTweets;
                testingTweets = _analyser.TestingTweets;
                labels = _analyser.Labels;
                wordDict = _analyser.WordDictionary;
                labelDict = _analyser.LabelDictioanary;

                nn = new NeuralNetwork(
                    (type == TrainingType.WORD_TRAINING) ?_analyser.MaxWordPerTweet : 4,
                    _hiddenNodes,
                    _analyser.LabelCount,
                    _learningRate
                );
            }
        }

        void SetAnalyser(Analyser _analyser)
        {
            trainingTweets = _analyser.TrainingTweets;
            testingTweets = _analyser.TestingTweets;
            labels = _analyser.Labels;
            wordDict = _analyser.WordDictionary;
            labelDict = _analyser.LabelDictioanary;
        }

        #endregion

        #region Train and Test

        public void Train1(ProgressBar progressBar)
        {
            double[] inputArr;
            double[] outputArr;

            for(int i = 0; i < this.trainingTweets.Length; i++)
            {
                progressBar.Value++;
                inputArr = new double[nn.InputNodes];
                outputArr = new double[nn.OutputNodes];

                // Set words for input array.
                string[] words = this.trainingTweets[i].words;
                for(int j = 0; j < words.Length; j++)
                {
                    inputArr[j] = (double)wordDict[words[j]].id;
                }

                // Set labels for output array.
                for(int j = 0; j < labels.Length; j++)
                {
                    if (labelDict[this.trainingTweets[i].users[0].labels[0]] == j)
                        outputArr[j] = 1f;
                    else
                        outputArr[j] = 0f;
                }
                
                // Normalise before training.
                inputArr = Normalize(
                    inputArr,
                    0,
                    analyser.UniqueWordCount,
                    -1f,
                    1f
                );

                // We are training neural network here for every tweet.
                nn.FeedForward(inputArr);
                nn.Train(inputArr, outputArr);
            }
        }

        public List<List<Tuple<int, double>>> Test1(ProgressBar progressBar)
        {
            List<List<Tuple<int, double>>> correctIndex = new List<List<Tuple<int, double>>>();
            double[] inputArr;
            int corrects = 0;

            for (int i = 0; i < testingTweets.Length; i++)
            {
                progressBar.Value++;
                inputArr = new double[nn.InputNodes];

                // Set words for input array.
                string[] words = this.testingTweets[i].words;
                for (int j = 0; j < words.Length; j++)
                {
                    inputArr[j] = (double)wordDict[words[j]].id;
                }

                // Normalise before training.
                inputArr = Normalize(
                    inputArr,
                    0,
                    analyser.UniqueWordCount,
                    -1f,
                    1f
                );

                // We are training neural network here for every tweet.
                double[] result = nn.FeedForward(inputArr);
                List<Tuple<int, double>> lst = new List<Tuple<int, double>>();
                Tuple<int, double> max = new Tuple<int, double>(0, result[0]);

                for (int j = 0; j < labels.Length; j++)
                {
                    lst.Add(new Tuple<int, double>(j, result[j]));
                    if (result[j] > max.Item2)
                        max = new Tuple<int, double>(j, result[j]);     
                }

                if (labels[max.Item1] == testingTweets[i].users[0].labels[0])
                    corrects++;

                correctIndex.Add(lst);
            }

            analyser.Accuracy = ((double)corrects / testingTweets.Length)*100;
            return correctIndex;
        }

        public void Train2(ProgressBar progressBar)
        {
            double[] inputArr;
            double[] outputArr;

            // min and max values for features
            double[] Mins = FindMin(trainingTweets);
            double[] Maxes = FindMax(trainingTweets);

            for (int i = 0; i < trainingTweets.Length; i++)
            {
                progressBar.Value++;
                inputArr = new double[nn.InputNodes];
                outputArr = new double[nn.OutputNodes];

                // Set features for input array.
                inputArr[0] = this.trainingTweets[i].wordCount;
                inputArr[1] = this.trainingTweets[i].punctuationMarkCount;
                inputArr[2] = this.trainingTweets[i].digitCount;
                inputArr[3] = this.trainingTweets[i].avarageWordLength;

                // Normalise before training.
                inputArr = Normalize(
                    inputArr,
                    Mins,
                    Maxes,
                    -1f,
                    1f
                );

                nn.FeedForward(inputArr);
                nn.Train(inputArr, outputArr);
            }
        }

        public List<List<Tuple<int,double>>> Test2(ProgressBar progressBar)
        {
            List<List<Tuple<int, double>>> correctIndex = new List<List<Tuple<int, double>>>();
            double[] inputArr;
            int corrects = 0;

            // min amd max values of features
            double[] Mins = FindMin(testingTweets);   
            double[] Maxes = FindMax(testingTweets);

            for (int i = 0; i < testingTweets.Length; i++)
            {
                progressBar.Value++;
                inputArr = new double[nn.InputNodes];

                // Set words for input array.
                inputArr[0] = this.testingTweets[i].wordCount;
                inputArr[1] = this.testingTweets[i].punctuationMarkCount;
                inputArr[2] = this.testingTweets[i].digitCount;
                inputArr[3] = this.testingTweets[i].avarageWordLength;

                // Normalise before training.
                inputArr = Normalize(
                    inputArr,
                    Mins,
                    Maxes,
                    -1f,
                    1f
                );

                double[] result = nn.FeedForward(inputArr);

                List<Tuple<int, double>> lst = new List<Tuple<int, double>>();
                Tuple<int, double> max = new Tuple<int, double>(0,result[0]);

                for (int j = 0; j < labels.Length; j++)
                {
                    lst.Add(new Tuple<int, double>(j,result[j]));
                    if (result[j] > max.Item2)
                        max = new Tuple<int, double>(j, result[j]);
                }
                if (labels[max.Item1] == testingTweets[i].users[0].labels[0])
                    corrects++;

                correctIndex.Add(lst);
            }

            analyser.Accuracy = ((double)corrects / testingTweets.Length) * 100;
            return correctIndex;
        }

        #endregion

        #region Normalization Methods

        private double[] Normalize(double[] arr, double oldMin, double oldMax, double newMin, double newMax)
        {
            double[] normalized = new double[arr.Length];

            for(int i = 0; i < arr.Length; i++)
            {
                normalized[i] = ((arr[i] - oldMin) / (oldMax - oldMin)) * (newMax - newMin) + newMin;
            }

            return normalized;
        }
        private double[] Normalize(double[] arr,double[] oldMins, double[] oldMaxes, double newMin,double newMax)
        {
            double[] normalized = new double[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                normalized[i] = ((arr[i] - oldMins[i]) / (oldMaxes[i] - oldMins[i])) * (newMax - newMax) + newMin;
            }
            return normalized;
        }

        #endregion

        #region Helpers

        private double[] FindMin (TweetData[] tweets)
        {
            double[] min = { double.MaxValue, double.MaxValue, double.MaxValue, double.MaxValue };

            // find min values for features
            for (int i = 0; i < tweets.Length; i++)
            {
                if (min[0] > tweets[i].wordCount)
                    min[0] = tweets[i].wordCount;

                if (min[1] > tweets[i].punctuationMarkCount)
                    min[1] = tweets[i].punctuationMarkCount;

                if (min[2] > tweets[i].digitCount)
                    min[2] = tweets[i].digitCount;

                if (min[3] > tweets[i].avarageWordLength)
                    min[3] = tweets[i].avarageWordLength;
            }
            return min;
        }

        private double[] FindMax(TweetData[] tweets)
        {
            double[] max = { 0, 0, 0, 0 };

            // find max values for features
            for (int i = 0; i < tweets.Length; i++)
            {
                if (max[0] < tweets[i].wordCount)
                    max[0] = tweets[i].wordCount;

                if (max[1] < tweets[i].punctuationMarkCount)
                    max[1] = tweets[i].punctuationMarkCount;

                if (max[2] < tweets[i].digitCount)
                    max[2] = tweets[i].digitCount;

                if (max[3] < tweets[i].avarageWordLength)
                    max[3] = tweets[i].avarageWordLength;
            }
            return max;
        }

        #endregion

        #region Properties

        public NeuralNetwork Neuralnetwork
        {
            get { return nn; }
            set { nn = value; }
        }

        public Analyser Analyser
        {
            get { return analyser; }
            set { analyser = value; SetAnalyser(value); }
        }

        public Dictionary<string, Word> WordDict
        {
            get { return wordDict; }
            set { wordDict = value; }
        }

        public Dictionary<string, int> LabelDict
        {
            get { return labelDict; }
            set { labelDict = value; }
        }

        public TweetData[] TrainingTweets
        {
            get { return trainingTweets; }
            set { trainingTweets = value; }
        }

        public TweetData[] TestingTweets
        {
            get { return testingTweets; }
            set { testingTweets = value; }
        }

        public string[] Labels
        {
            get { return labels; }
            set { labels = value; }
        }

        #endregion
    }
}
