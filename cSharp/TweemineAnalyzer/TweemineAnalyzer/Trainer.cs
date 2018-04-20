using System.Collections.Generic;
using TweemineNeuralNetwork;

namespace TweemineAnalyzer
{
    class Trainer
    {
        Dictionary<string, Word> wordDict;
        Dictionary<string, int>  labelDict;
        Analyser                 analyser;
        NeuralNetwork            nn;
        TweetData[]              trainingTweets;
        TweetData[]              testingTweets;
        string[]                 labels;

        public Trainer(Analyser _analyser, int _hiddenNodes, double _learningRate)
        {
            analyser = _analyser;
            trainingTweets = _analyser.TrainingTweets;
            testingTweets = _analyser.TestingTweets;
            labels = _analyser.Labels;
            wordDict = _analyser.WordDictionary;
            labelDict = _analyser.LabelDictioanary;
           
            nn = new NeuralNetwork(
                _analyser.MaxWordPerTweet,
                _hiddenNodes,
                _analyser.LabelCount,
                _learningRate
            );
        }

        public void Train()
        {
            double[] inputArr;
            double[] outputArr;

            for(int i = 0; i < this.trainingTweets.Length; i++)
            {
                inputArr = new double[nn.inputNodes];
                outputArr = new double[nn.outputNodes];

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
                    analyser.TweetCount,
                    -1f,
                    1f
                );

                outputArr = Normalize(
                    outputArr,
                    0f,
                    analyser.LabelCount - 1f,
                    -1f,
                    1f
                );

                // We are training neural network here for every tweet.
                nn.FeedForward(inputArr);
                nn.Train(inputArr, outputArr);
            }
        }

        public List<List<int>> Test()
        {
            List<List<int>> correctIndex = new List<List<int>>();
            // Implement me.
            double[] inputArr;
            double[] outputArr;

            for (int i = 0; i < this.testingTweets.Length; i++)
            {
                inputArr = new double[nn.inputNodes];
                outputArr = new double[nn.outputNodes];

                // Set words for input array.
                string[] words = this.testingTweets[i].words;
                for (int j = 0; j < words.Length; j++)
                {
                    inputArr[j] = (double)wordDict[words[j]].id;
                }

                // Set labels for output array.
                for (int j = 0; j < labels.Length; j++)
                {
                    if (labelDict[this.testingTweets[i].users[0].labels[0]] == j)
                        outputArr[j] = 1f;
                    else
                        outputArr[j] = 0f;
                }

                // Normalise before training.
                inputArr = Normalize(
                    inputArr,
                    0,
                    analyser.TweetCount,
                    -1f,
                    1f
                );

                outputArr = Normalize(
                    outputArr,
                    0f,
                    analyser.LabelCount - 1f,
                    -1f,
                    1f
                );

                // We are training neural network here for every tweet.
                double[] result = nn.FeedForward(inputArr);
                List<int> lst = new List<int>();
                for (int j = 0; j < labels.Length; j++)
                {
                    if (result[j] > 0.5)
                        lst.Add(j);
                }
                correctIndex.Add(lst);
                    //result ı kontrol et

                }
            return correctIndex;
        }

        private double[] Normalize(double[] arr, double oldMin, double oldMax, double newMin, double newMax)
        {
            double[] normalized = new double[arr.Length];

            for(int i = 0; i < arr.Length; i++)
            {
                normalized[i] = (arr[i] - oldMin) / (oldMax - oldMin) * (newMax - newMin) + newMin;
            }

            return normalized;
        }
    }
}
