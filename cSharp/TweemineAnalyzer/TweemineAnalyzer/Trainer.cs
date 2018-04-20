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
        TweetData[]              tweets;
        string[]                 labels;

        public Trainer(Analyser analyser, int hiddenNodes, double learningRate)
        {
            this.analyser  = analyser;
            this.tweets    = analyser.GetTweets();
            this.labels    = analyser.GetLabels();
            this.wordDict  = analyser.GetWordDictionary();
            this.labelDict = analyser.GetLabelDictioanary();
           
            nn = new NeuralNetwork(
                analyser.GetMaxWordPerTweet(),
                hiddenNodes,
                analyser.GetLabelCount(),
                learningRate
            );
        }

        public void Train()
        {
            double[] inputArr;
            double[] outputArr;

            for(int i = 0; i < this.tweets.Length; i++)
            {
                inputArr = new double[nn.inputNodes];
                outputArr = new double[nn.outputNodes];

                // Set words for input array.
                string[] words = this.tweets[i].words;
                for(int j = 0; j < words.Length; j++)
                {
                    inputArr[j] = (double)wordDict[words[j]].id;
                }

                // Set labels for output array.
                for(int j = 0; j < labels.Length; j++)
                {
                    if (labelDict[this.tweets[i].users[0].labels[0]] == j)
                        outputArr[j] = 1f;
                    else
                        outputArr[j] = 0f;
                }

                // Normalise before training.
                inputArr = Normalize(
                    inputArr,
                    0,
                    analyser.GetTweetCount(),
                    -1f,
                    1f
                );

                outputArr = Normalize(
                    inputArr,
                    0f,
                    analyser.GetLabelCount() - 1f,
                    -1f,
                    1f
                );

                // We are training neural network here for every tweet.
                nn.FeedForward(inputArr);
                nn.Train(inputArr, outputArr);
            }
        }

        public void Test()
        {
            // Implement me.
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
