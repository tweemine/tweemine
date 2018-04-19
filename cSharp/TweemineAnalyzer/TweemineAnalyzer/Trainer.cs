using System.Collections.Generic;
using TweemineNeuralNetwork;

namespace TweemineAnalyzer
{
    class Trainer
    {
        Dictionary<string, Word> wordDict;
        NeuralNetwork            nn;
        TweetData[]              tweets;
        string[]                 labels;

        public Trainer(Analyser analyser, int hiddenNodes, double learningRate)
        {
            this.tweets = analyser.GetTweets();
            this.labels = analyser.GetLabels();
            this.wordDict = analyser.GetWordDictionary();

            nn = new NeuralNetwork(
                analyser.GetMaxWordPerTweet(),
                hiddenNodes,
                analyser.GetLabelCount(),
                learningRate
            );
        }

        public void Train()
        {

        }
    }
}
