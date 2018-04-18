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
        private static string wordsPath = Path.Combine("..", "..", "..", "..", "..", "tweets", "words.json");

        public static void Analyse(TweetData[] tweets)
        {
            Word[] oldWords = ReadWordsFromJson();
            Word[] analysedWords = AnalyseWords(tweets, oldWords);
            Array.Sort(analysedWords);

            WriteWordsToJson(analysedWords);
        }

        private static Word[] AnalyseWords(TweetData[] tweets, Word[] oldWords)
        {
            Dictionary<string, Word> wordDict = new Dictionary<string, Word>();

            int maxId = 0;

            if (oldWords != null)
            {
                for (int i = 0; i < oldWords.Length; i++)
                {
                    Word word = oldWords[i];
                    wordDict.Add(word.word, word);

                    if (word.id > maxId)
                        maxId = word.id;
                }
            }

            // Initialize id with maxId + 1
            int id = ++maxId;

            for(int i = 0; i < tweets.Length; i++)
            {
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
    }
}
