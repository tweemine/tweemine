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
using System.Text.RegularExpressions;

namespace TweemineAnalyzer
{
    public partial class Form1 : Form
    {
        #region Variables

        //we need all read tweets so we need this glob. var.
        TweetData[] tweetDatas;

        string tweetsPath;

        int currentTweetIndex = 0;

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        #region ComponentsEvents
        private void NavigateLabeledData_Click(object sender, EventArgs e)
        {
            if(tweetDatas == null )
            {
                MessageBox.Show("You forgot to read from json??","Warning",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if(tweetDatas.Length == 0)
            {
                MessageBox.Show("you dont have any labeled data in json", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int buttonVal = 0;

            //we have a tag in every button for navigating tweets. so we can send them all here
            if (sender != null)
                buttonVal = int.Parse(((Button)sender).Tag.ToString());

            UpdateShownData(buttonVal);
        }

        //this shows the labeled tweet on appropriate label object
        //increment takes values -1 0 1
        private void UpdateShownData(int increment)
        {
            int tweetDatasLength = tweetDatas.Length;
            currentTweetIndex += increment;
 
            
            ////we need to check if we are under 0.
            currentTweetIndex = currentTweetIndex < 0 ?
                tweetDatas.Length - 1 : currentTweetIndex;

            currentTweetIndex = currentTweetIndex % tweetDatasLength;

            string rawTweet = "";
            string labels = "";
            string user = "None";
            int wordsLength = tweetDatas[currentTweetIndex].words.Length;


            for (int i = 0; i < wordsLength; i++)
            {
                rawTweet += tweetDatas[currentTweetIndex].words[i] + " ";
            }

            ClearCheckedDataFromCheckedListBox(chcLstLabels);

            // we already have this labels so we dont have to make changes on data thats why we unregister this event
            UnregisterItemCheckEvent(chcLstLabels_ItemCheck);
            if (tweetDatas[currentTweetIndex].labels != null)
            {
                int labelsLength = tweetDatas[currentTweetIndex].labels.Length;
                for (int i = 0; i < labelsLength; i++)
                {
                    string currentLabel = tweetDatas[currentTweetIndex].labels[i];

                    for (int j = 0; j < chcLstLabels.Items.Count; j++)
                    {
                        if (chcLstLabels.Items[j].ToString() == currentLabel)
                        {
                            chcLstLabels.SetItemCheckState(j, CheckState.Checked);
                            break;
                        }

                    }
                    labels += currentLabel + ", ";
                }
            }

            RegisterItemCheckEvent(chcLstLabels_ItemCheck);
            labels = labels.TrimEnd(',', ' ');

            user = tweetDatas[currentTweetIndex].user;
            cmbUserName.Text = user;            

            if (tweetDatas.Length > 0)
            {
                //we can write asked tweet data. currentTweetIndex % tweetDatas.Length --> we can go over tweets so
                //we can start from 0
                lblTweetText.Text = "Tweet: " + rawTweet +
                    "\n\nLabel: " + labels +
                    "\n\nUser: " + user;
            }
            else
            {
                lblTweetText.Text = "No parsed Tweet data in the file";
            }
        }

        //when we click next data or prev data we need to clear every checked data in the list and 
        //we need to check appropriate datas
        private void ClearCheckedDataFromCheckedListBox(CheckedListBox _chcLstLabels)
        {
            //item check fires everytime we check or uncheck the object so we need to stop doing it while clearing data
            //otherwise we will loose datas
            UnregisterItemCheckEvent(chcLstLabels_ItemCheck);
            for (int j = 0; j < _chcLstLabels.Items.Count; j++)
            {
                if (_chcLstLabels.GetItemCheckState(j) == CheckState.Checked)
                {
                    _chcLstLabels.SetItemCheckState(j, CheckState.Unchecked);
                }
            }
            RegisterItemCheckEvent(chcLstLabels_ItemCheck);
        }

        private void WriteToFile_Click(object sender, EventArgs e)
        {
            WriteToJsonFile(tweetsPath, tweetDatas);
        }

        private void RegisterItemCheckEvent(ItemCheckEventHandler itemCheckEventHandler)
        {
            chcLstLabels.ItemCheck += itemCheckEventHandler;
        }

        private void UnregisterItemCheckEvent(ItemCheckEventHandler itemCheckEventHandler)
        {
            chcLstLabels.ItemCheck -= itemCheckEventHandler;
        }

        private void chcLstLabels_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //FIXME we need to hanle unchecked state
            //when we uncheck a data we need to update labels and shown text

            Console.WriteLine(e.Index);

            if (e.NewValue == CheckState.Checked)
                AddFeaturesToLabeledData(e.Index);
            else
                DeleteFeaturesFromLabeledData(e.Index);

            //show the data we changed
            UpdateShownData(0);
        }

        private void DeleteFeaturesFromLabeledData(int newDataIndex)
        {
            TweetData currTweet = tweetDatas[currentTweetIndex];

            string newLabel = chcLstLabels.Items[newDataIndex].ToString();
            List<string> newLabels = new List<string>(currTweet.labels);

            if (currTweet.labels != null || currTweet.labels.Length != 0)
            {
                newLabels.Remove(newLabel);

                if (newLabels.Count == 0)
                    currTweet.labeled = false;
                else
                    currTweet.labeled = true;

                currTweet.labels = newLabels.ToArray();
            }
        }

        private void AddFeaturesToLabeledData(int newDataIndex)
        {
            TweetData currTweet = tweetDatas[currentTweetIndex];

            string newLabel = chcLstLabels.Items[newDataIndex].ToString();
            List<string> newLabels = new List<string>(currTweet.labels);

            if (currTweet.labels != null)
            {
                newLabels.Add(newLabel);

                currTweet.labeled = true;
                currTweet.labels = newLabels.ToArray();
            }
        }

        private void ParseLabeledDatas()
        {
            //List<string> labels = new List<string>();
            //foreach (var item in chcLstLabels.CheckedItems)
            //{
            //    labels.Add(item.ToString());
            //}

            //string[] wordsT = Parser.ParseTheText(tweetDatas[currentTweetIndex % tweetDatas.Length].tweet).ToArray();
            //// = cmbTags.Text;
            //string userT = cmbUserName.Text;
            //string[] labelsT = labels.ToArray();

            //labeledTweetDataList.Add(new LabeledTweetData() { labels = labelsT, words = wordsT, user = userT });
        }

        private void ParseUnLabeledDatas()
        {
            //string[] wordsT = Parser.ParseTheText(tweetDatas[currentTweetIndex % tweetDatas.Length].tweet).ToArray();
            //labeledTweetDataList.Add(new LabeledTweetData() { labels = null, words = wordsT, user = null });
        }

        private void cmbUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUserName.Text == string.Empty)
                return;

            tweetDatas[currentTweetIndex].user = cmbUserName.Text;
            UpdateShownData(0);
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (openFileDialog.SafeFileName.EndsWith(".json"))
                {
                    tweetsPath = openFileDialog.FileName;
                    tweetDatas = ReadTweetsFromJsonFile(tweetsPath);

                    ParseTweets();
                    NavigateLabeledData_Click(null, new EventArgs());
                }
                else
                {
                    Console.WriteLine("Please choose a json file.");
                }
            }


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

        void WriteToJsonFile(string path, object obj)
        {
            using (TextWriter textWriter = new StreamWriter(path))
            {
                //create a new json serializer object for serialazation
                JsonSerializer jsonSerializer = new JsonSerializer();
                
                //serialize data
                string jsonText = JsonConvert.SerializeObject(obj);
                textWriter.Write(jsonText);
  
                textWriter.Close();
            }
        }
        #endregion

        void ParseTweets()
        {
            foreach (TweetData data in tweetDatas)
            {
                // If tweet is not parsed, we'll parse it for first time here. 
                if (data.words == null || data.words.Length == 0)
                {
                    string[] parsedTweet = Parser.ParseTheText(data.tweet).ToArray();
                    data.words = parsedTweet;
                }
            }

            // save parsed tweets to json file.
            WriteToJsonFile(tweetsPath, tweetDatas);
        }
    }
}