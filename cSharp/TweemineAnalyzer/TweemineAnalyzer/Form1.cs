using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using System.IO;

namespace TweemineAnalyzer
{
    public partial class Form1 : Form
    {
        #region Variables
        //we need all read tweets so we need this glob. var.
        TweetData[] tweetDatas;
        LabeledTweetData[] labeledTweetDatas;

        //for json
        List<LabeledTweetData> labeledTweetDataList;

        int currentTweetIndex = 0;
        int currentLabeledDataIndex = 0;

        string tweetsPath = Path.Combine("..", "..", "..", "..", "..", "python", "tweets.json");
        string labeledTweetsPath = "labeledData.json";
        #endregion

        public Form1()
        {
            InitializeComponent();
            labeledTweetDataList = new List<LabeledTweetData>();
        }
        #region ComponentsEvents
        private void Form1_Load(object sender, EventArgs e)
        {
            tweetDatas = ReadTweetsFromJsonFile(tweetsPath);
            //when this form loads then show me the first tweet in the list
            NavigateTweets_Click(null, new EventArgs());
            toggle1_ToggleChanged(false);
        }

        private void NavigateTweets_Click(object sender, EventArgs e)
        {
            currentLabeledDataIndex = 0;
            int buttonVal = 0;

            //we have a tag in every button for navigating tweets. so we can send them all here
            if (sender != null)
                buttonVal = int.Parse(((Button)sender).Tag.ToString());
            currentTweetIndex += buttonVal;
            //we need to check if we are under 0.
            currentTweetIndex = currentTweetIndex < 0 ? tweetDatas.Length - 1 : currentTweetIndex;
            //we can write asked tweet data. currentTweetIndex % tweetDatas.Length --> we can go over tweets so
            //we can start from 0
            if (tweetDatas.Length > 0)
                lblTweetText.Text = tweetDatas[currentTweetIndex % tweetDatas.Length].Tweet;
            else
                lblTweetText.Text = "No Tweet data in the file";
        }

        private void NavigateLabeledData_Click(object sender, EventArgs e)
        {
            //FIXME: we wont see the first data in the array when we click these navigation Buttons
            if(labeledTweetDatas==null )
            {
                MessageBox.Show("You forgot to read from json??","Warning",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if( labeledTweetDatas.Length == 0)
            {
                MessageBox.Show("you dont have any labeled data in json","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            currentTweetIndex = 0;
            int labeledTweetDatasLength = labeledTweetDatas.Length;
            int buttonVal = 0;
            //we have a tag in every button for navigating tweets. so we can send them all here
            if (sender != null)
                buttonVal = int.Parse(((Button)sender).Tag.ToString());
            currentLabeledDataIndex += buttonVal;
            //we need to check if we are under 0.
            currentLabeledDataIndex = currentLabeledDataIndex < 0 ?
                tweetDatas.Length - 1 : currentLabeledDataIndex;

            string rawTweet = "";
            string labels="";
            string user="None";
            for (int i = 0; i
                < labeledTweetDatas[currentLabeledDataIndex % labeledTweetDatasLength].words.Length; i++)
            {
                rawTweet += labeledTweetDatas[currentLabeledDataIndex % labeledTweetDatasLength].words[i] + " ";
            }
            for (int i = 0; i
               < labeledTweetDatas[currentLabeledDataIndex % labeledTweetDatasLength].labels.Length; i++)
            {
                labels += labeledTweetDatas[currentLabeledDataIndex % labeledTweetDatasLength].labels[i] + ",";
            }
            user = labeledTweetDatas[currentLabeledDataIndex % labeledTweetDatasLength].user;
            if (tweetDatas.Length > 0)
            {
                //we can write asked tweet data. currentTweetIndex % tweetDatas.Length --> we can go over tweets so
                //we can start from 0
                lblTweetText.Text = "Tweet :" + rawTweet +
                    "\n\nLabel:" + labels +
                    "\n\nUser :" + user;
            }
            else
            {
                lblTweetText.Text = "No Tweet data in the file";
            }
        }
        private void ReadOrWriteToFile_Click(object sender, EventArgs e)
        {
            bool writeToFile = bool.Parse(((Button)sender).Tag.ToString());

            if (writeToFile == true)
            {
                //we need to write to json file labeled data
                WriteToJsonFile(labeledTweetsPath, labeledTweetDataList.ToArray());
            }
            else
            {
                //read data from labeledTweets json file
                labeledTweetDatas = ReadLabeledDataFromJsonFile(labeledTweetsPath);
            }
        }
        private void btnTag_Click(object sender, EventArgs e)
        {
            List<string> labels = new List<string>();
            foreach (var item in chcLstLabels.CheckedItems)
            {
                labels.Add(item.ToString());
            }

            string[] wordsT = Parser.ParseTheText(tweetDatas[currentTweetIndex].Tweet).ToArray();
            // = cmbTags.Text;
            string userT = cmbUserName.Text;
            string[] labelsT = labels.ToArray();

            labeledTweetDataList.Add(new LabeledTweetData() { labels = labelsT, words = wordsT, user = userT });
        }
        #endregion
        #region FileReadWrite
        /// <summary>
        /// reads tweets from a file
        /// </summary>
        /// <param name="path">file path</param>
        TweetData[] ReadTweetsFromJsonFile(string path)
        {
            TweetData[] tweetDataArr;
            //we wont need text reader after this scope so I am being sure GC has collected this ref.
            using (TextReader textReader = new StreamReader(path, Encoding.UTF8))
            {
                //Reading the json File
                string context = textReader.ReadToEnd();
                //Sending into JsonConvert.DeserializeObject for getting the data as TweetData array
                tweetDataArr = JsonConvert.DeserializeObject<TweetData[]>(context);
                //close the file
                textReader.Close();

            }
            return tweetDataArr;

        }
        LabeledTweetData[] ReadLabeledDataFromJsonFile(string path)
        {
            LabeledTweetData[] labeledTweets;
            using (StreamReader reader = new StreamReader(path, Encoding.UTF8))
            {
                //Reading the json File
                string context = reader.ReadToEnd();

                //we have a string looks like "[\\{obj\\},\\{obj2\\}]" so we are removing things that json doesnt understand 
                context = context.Replace("\\", string.Empty);
                context = context.Trim('"');
                //Sending into JsonConvert.DeserializeObject for getting the data as TweetData array
                labeledTweets = JsonConvert.DeserializeObject<LabeledTweetData[]>(context, new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                });
                //close the file
                reader.Close();

            }

            return labeledTweets;
        }
        void WriteToJsonFile(string path, object obj)
        {
            using (TextWriter textWriter = new StreamWriter(path))
            {
                //create a new json serializer object for serialazation
                JsonSerializer jsonSerializer = new JsonSerializer();
                //serialize data
                string jsonText = JsonConvert.SerializeObject(obj);
                //write as json format in the file
                jsonSerializer.Serialize(textWriter,
                                         jsonText);
            }
        }
        #endregion

        private void toggle1_ToggleChanged(bool val)
        {
            if(val==true)
            {
                
                btnNextTweet.Click -= NavigateLabeledData_Click;
                btnNextTweet.Click += NavigateTweets_Click;

                btnPrevTweet.Click -= NavigateLabeledData_Click;
                btnPrevTweet.Click += NavigateTweets_Click;

                grpDataNavigation.Text = "Tweets";
            }
            else
            {
                currentTweetIndex = 0;
                
                btnNextTweet.Click += NavigateLabeledData_Click;
                btnNextTweet.Click -= NavigateTweets_Click;

                btnPrevTweet.Click += NavigateLabeledData_Click;
                btnPrevTweet.Click -= NavigateTweets_Click;

                grpDataNavigation.Text = "Labeled Data";
            }
        }
    }
    #region Classes
    class TweetData
    {
        public string Tweet;
    }
    class LabeledTweetData
    {
        public string[] words;
        public string[] labels;
        public string user;
    }
    #endregion
}