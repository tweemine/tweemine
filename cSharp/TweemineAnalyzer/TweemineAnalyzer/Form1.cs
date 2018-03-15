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
           // toggle1.State = true;
        }
        #region ComponentsEvents
        private void Form1_Load(object sender, EventArgs e)
        {
            tweetDatas = ReadTweetsFromJsonFile(tweetsPath);
            foreach (TweetData item in tweetDatas)
            {
                //we are parsing every raw tweet data
                ParseUnLabeledDatas();
                currentTweetIndex++;
            }

            //we are reading labeled datas and we are not overwriting it
            //FIXME: after we parsed raw tweet data we need to append these datas on current labeled datas
            //be careful about taking same old tweets everytime
            labeledTweetDatas = ReadLabeledDataFromJsonFile(labeledTweetsPath);
            if (labeledTweetDatas == null || labeledTweetDatas.Length == 0)
            {
                //if we dont have any data we can write current data and read from it
                WriteToJsonFile(labeledTweetsPath, labeledTweetDataList.ToArray());
                labeledTweetDatas = labeledTweetDataList.ToArray();
            }
            //when this form loads then show me the first parsed tweet in the list
            NavigateLabeledData_Click(null, new EventArgs());
        }

        private void NavigateLabeledData_Click(object sender, EventArgs e)
        {
            if(labeledTweetDatas==null )
            {
                MessageBox.Show("You forgot to read from json??","Warning",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if( labeledTweetDatas.Length == 0)
            {
                MessageBox.Show("you dont have any labeled data in json","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            currentTweetIndex = 0;
            int labeledTweetDatasLength = labeledTweetDatas.Length;
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
            int labeledTweetDatasLength = labeledTweetDatas.Length;
            currentLabeledDataIndex += increment;
            //we need to check if we are under 0.
            currentLabeledDataIndex = currentLabeledDataIndex < 0 ?
                tweetDatas.Length - 1 : currentLabeledDataIndex;

            currentLabeledDataIndex = currentLabeledDataIndex % labeledTweetDatasLength;

            string rawTweet = "";
            string labels = "";
            string user = "None";
            int wordsLength = labeledTweetDatas[currentLabeledDataIndex].words.Length;
            for (int i = 0; i < wordsLength; i++)
            {
                rawTweet += labeledTweetDatas[currentLabeledDataIndex].words[i] + " ";
            }

            ClearCheckedDataFromCheckedListBox(chcLstLabels);
            //we already have this labels so we dont have to make changes on data thats why we unregister this event
            UnregisterItemChekEvent(chcLstLabels_ItemCheck);
            if (labeledTweetDatas[currentLabeledDataIndex].labels != null)
            {
                int labelsLength = labeledTweetDatas[currentLabeledDataIndex].labels.Length;
                for (int i = 0; i < labelsLength; i++)
                {
                    string currentLabel = labeledTweetDatas[currentLabeledDataIndex].labels[i];


                    for (int j = 0; j < chcLstLabels.Items.Count; j++)
                    {
                        if (chcLstLabels.Items[j].ToString() == currentLabel)
                        {
                            chcLstLabels.SetItemCheckState(j, CheckState.Checked);
                            break;
                        }

                    }
                    labels += currentLabel + ",";
                }
            }
            RegisterItemChekEvent(chcLstLabels_ItemCheck);
            user = labeledTweetDatas[currentLabeledDataIndex].user;
            labels = labels.TrimEnd(',');
            if (labeledTweetDatas.Length > 0)
            {
                //we can write asked tweet data. currentTweetIndex % tweetDatas.Length --> we can go over tweets so
                //we can start from 0
                lblTweetText.Text = "Tweet :" + rawTweet +
                    "\n\nLabel:" + labels +
                    "\n\nUser :" + user;
            }
            else
            {
                lblTweetText.Text = "No labeled Tweet data in the file";
            }
        }
        //when we click next data or prev data we need to clear every checked data in the list and 
        //we need to check appropriate datas
        private void ClearCheckedDataFromCheckedListBox(CheckedListBox _chcLstLabels)
        {
            //item check fires everytime we check or uncheck the object so we need to stop doing it while clearing data
            //otherwise we will loose datas
            UnregisterItemChekEvent(chcLstLabels_ItemCheck);
            for (int j = 0; j < _chcLstLabels.Items.Count; j++)
            {
                if (_chcLstLabels.GetItemCheckState(j) == CheckState.Checked)
                {
                    _chcLstLabels.SetItemCheckState(j, CheckState.Unchecked);
                }
            }
            RegisterItemChekEvent(chcLstLabels_ItemCheck);
        }

        private void WriteToFile_Click(object sender, EventArgs e)
        {
                WriteToJsonFile(labeledTweetsPath, labeledTweetDatas);
                labeledTweetDatas = ReadLabeledDataFromJsonFile(labeledTweetsPath);
        }
        private void RegisterItemChekEvent(ItemCheckEventHandler itemCheckEventHandler)
        {
            chcLstLabels.ItemCheck += itemCheckEventHandler;
        }
        private void UnregisterItemChekEvent(ItemCheckEventHandler itemCheckEventHandler)
        {
            chcLstLabels.ItemCheck -= itemCheckEventHandler;
        }
        private void chcLstLabels_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //FIXME we need to hanle unchecked state
            //when we uncheck a data we need to update labels and shown text

            if (e.NewValue == CheckState.Checked)
            {
                AddFeaturesToLabeledData(e.Index);
                //show the data we changed
                UpdateShownData(0);
            }
            else
            {
                DeleteFeaturesFromLabeledData(e.Index);
                UpdateShownData(0);
            }


        }
        private void DeleteFeaturesFromLabeledData(int newDataIndex)
        {
            LabeledTweetData labeled = labeledTweetDatas[currentLabeledDataIndex % labeledTweetDatas.Length];
            if (newDataIndex != -1)
            {
                string newLabels = "";
                string newLabel = chcLstLabels.Items[newDataIndex].ToString(); 
                if (labeled.labels != null)
                {
                    foreach (string item in labeled.labels)
                    {
                        if (newLabel != item)
                            newLabels += item + ",";
                    }
                    newLabels = newLabels.TrimEnd(',');
                    if (newLabels != string.Empty)
                        labeled.labels = newLabels.Split(',');
                    else
                        labeled.labels = null;

                }
                if (cmbUserName.Text != string.Empty)
                    labeled.user = cmbUserName.Text;
            }
        }
        private void AddFeaturesToLabeledData(int newDataIndex)
        {
            LabeledTweetData labeled = labeledTweetDatas[currentLabeledDataIndex % labeledTweetDatas.Length];
            //we can only change label data and user data so we can update these datas
            if (newDataIndex != -1)
            {
                string newLables = "";
                string newLabel = chcLstLabels.Items[newDataIndex].ToString();
                if (labeled.labels != null)
                {
                    foreach (string item in labeled.labels)
                    {
                        if (newLabel != item)
                            newLables += item + ",";
                    }
                }
                newLables += newLabel;
                labeled.labels = newLables.Split(',');
            }
            if (cmbUserName.Text != string.Empty)
                labeled.user = cmbUserName.Text;
        }

        private void ParseLabeledDatas()
        {
            List<string> labels = new List<string>();
            foreach (var item in chcLstLabels.CheckedItems)
            {
                labels.Add(item.ToString());
            }

            string[] wordsT = Parser.ParseTheText(tweetDatas[currentTweetIndex % tweetDatas.Length].Tweet).ToArray();
            // = cmbTags.Text;
            string userT = cmbUserName.Text;
            string[] labelsT = labels.ToArray();

            labeledTweetDataList.Add(new LabeledTweetData() { labels = labelsT, words = wordsT, user = userT });
        }

        private void ParseUnLabeledDatas()
        {
            string[] wordsT = Parser.ParseTheText(tweetDatas[currentTweetIndex % tweetDatas.Length].Tweet).ToArray();
            labeledTweetDataList.Add(new LabeledTweetData() { labels = null, words = wordsT, user = null });
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

            try
            {
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
            } catch {
                // if there is no labelled data, return null.
                return null;
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
                textWriter.Close();
            }
        }


        #endregion

        private void cmbUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            AddFeaturesToLabeledData(-1);
            UpdateShownData(0);
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