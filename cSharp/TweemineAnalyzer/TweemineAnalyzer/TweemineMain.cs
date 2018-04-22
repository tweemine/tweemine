using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace TweemineAnalyzer
{
    public partial class TweemineMain : Form
    {
        #region Variables

        bool fileChanged = false;

        string tagsPath = Path.Combine("..", "..", "..", "..", "..", "tweets", "tags.txt");
        string txtFilePath = Path.Combine("..", "..", "..", "..", "..", "tweets", "tweets.txt");

        // we need all read tweets so we need this glob. var.
        TweetData[] tweetDatas;

        string[] labels;

        string tweetsPath;

        int currentTweetIndex = 0;

        int userIndex = 0;

        #endregion

        #region Constructors

        public TweemineMain()
        {
            InitializeComponent();
        }

        #endregion

        #region ComponentsEvents

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> labelList = new List<string>();

            StreamReader stream = new StreamReader(tagsPath, Encoding.GetEncoding(1254));
            while (!stream.EndOfStream)
            {
                string label = stream.ReadLine();
                labelList.Add(label);
                chcLstLabels.Items.Add(label);
            }
            stream.Close();

            labels = labelList.ToArray();


        }

        private void NavigateLabeledData_Click(object sender, EventArgs e)
        {

            if (tweetDatas == null)
            {
                MessageBox.Show("You forgot to read from json??", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tweetDatas.Length == 0)
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

            tweetIndex.Text = (currentTweetIndex + 1) + "/" + tweetDatasLength;

            TweetData currTweet = tweetDatas[currentTweetIndex];
            User currUser = currTweet.users[userIndex];

            string rawTweet = "";
            string tweet = "";
            string labels = "";

            int wordsLength = currTweet.words.Length;
            for (int i = 0; i < wordsLength; i++)
            {
                tweet += currTweet.words[i] + " ";
            }

            rawTweet = currTweet.tweet;

            ClearCheckedDataFromCheckedListBox(chcLstLabels);

            // we already have this labels so we dont have to make changes on data thats why we unregister this event
            UnregisterItemCheckEvent(chcLstLabels_ItemCheck);
            if (currUser.labels != null)
            {
                int labelsLength = currUser.labels.Length;
                for (int i = 0; i < labelsLength; i++)
                {
                    string currentLabel = currUser.labels[i];

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

            cmbUserName.Text = currUser.name;

            if (tweetDatas.Length > 0)
            {
                //we can write asked tweet data. currentTweetIndex % tweetDatas.Length --> we can go over tweets so
                //we can start from 0
                lblTweetText.Text = "Raw tweet: " + rawTweet +
                    "\n\nTweet: " + tweet +
                    "\n\nLabel: " + labels +
                    "\n\nUser: " + currUser.name;
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
            JsonFileController.WriteToJsonFile(tweetsPath, tweetDatas);
            fileChanged = false;
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
            //when we uncheck a data we need to update labels and shown text

            if (e.NewValue == CheckState.Checked)
                AddFeaturesToLabeledData(e.Index);
            else
                DeleteFeaturesFromLabeledData(e.Index);

            fileChanged = true;
            //show the data we changed

            UpdateShownData(0);
        }

        private void DeleteFeaturesFromLabeledData(int newDataIndex)
        {
            TweetData currTweet = tweetDatas[currentTweetIndex];
            User currUser = currTweet.users[userIndex];

            string newLabel = chcLstLabels.Items[newDataIndex].ToString();
            List<string> newLabels = new List<string>(currUser.labels);

            if (currUser.labels != null || currUser.labels.Length != 0)
            {
                newLabels.Remove(newLabel);

                if (newLabels.Count == 0)
                    currTweet.labeled = false;
                else
                    currTweet.labeled = true;
            }

            currUser.labels = newLabels.ToArray();
        }

        private void AddFeaturesToLabeledData(int newDataIndex)
        {
            TweetData currTweet = tweetDatas[currentTweetIndex];
            User currUser = currTweet.users[userIndex];
            string newLabel = chcLstLabels.Items[newDataIndex].ToString();

            List<string> newLabels = (currUser.labels == null) ? new List<string>() : new List<string>(currUser.labels);

            newLabels.Add(newLabel);
            currTweet.labeled = true;
            currUser.labels = newLabels.ToArray();
        }

        private void cmbUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            userIndex = FindUserIndex();
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
                    tweetDatas = JsonFileController.ReadDataFromJsonFile<TweetData[]>(tweetsPath);

                    // RegisterUsers() should be called before ParseTweets()
                    // because we check words array is null or not in RegisterUsers().
                    RegisterUsers();
                    ParseTweets();

                    // save parsed tweets to json file.
                    JsonFileController.WriteToJsonFile(tweetsPath, tweetDatas);

                    // Navigate to first tweet.
                    NavigateLabeledData_Click(null, new EventArgs());

                    FillTweetInfo();
                }
                else
                {
                    MessageBox.Show("Please choose a json file.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddTag_Click(object sender, EventArgs e)
        {
            if (txttag.Text == string.Empty)
                return;

            string data = txttag.Text;
            StreamWriter writer = new StreamWriter(tagsPath, true);
            writer.WriteLine(data);
            chcLstLabels.Items.Add(data);
            txttag.Clear();
            writer.Close();
        }

        private void btnDelTweet_Click(object sender, EventArgs e)
        {
            List<TweetData> tweets = new List<TweetData>(tweetDatas);
            tweets.RemoveAt(currentTweetIndex);
            tweetDatas = tweets.ToArray();
            fileChanged = true;
            UpdateShownData(0);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (fileChanged)
            {
                DialogResult dialogResult = MessageBox.Show("Would you like to save changed datas to file?", "Data Changed", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (dialogResult)
                {
                    case DialogResult.None:
                        break;
                    case DialogResult.OK:
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                    case DialogResult.Abort:
                        break;
                    case DialogResult.Retry:
                        break;
                    case DialogResult.Ignore:
                        break;
                    case DialogResult.Yes:
                        JsonFileController.WriteToJsonFile(tweetsPath, tweetDatas);
                        break;
                    case DialogResult.No:
                        break;
                    default:
                        break;
                }

            }
            Application.Exit();
        }

        private void combineButton_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBD.ShowDialog();
            if (result == DialogResult.OK)
            {
                JsonFileController.CombineAllJsonFiles(folderBD.SelectedPath);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                NavigateLabeledData_Click(btnPrevTweet, new EventArgs());
            }
            else if (e.KeyCode == Keys.Right)
            {
                NavigateLabeledData_Click(btnNextTweet, new EventArgs());
            }
        }
        #endregion

        #region SomeHelperMethods

        void FillTweetInfo()
        {
            Analyser analyser = new Analyser(tweetDatas, labels);
            analyser.Analyse();

            tweetInfo.Text = "";

            if (analyser.LabelFreq.Count == 0)
                return;

            for (int i = 0; i < labels.Length; i++)
            {
                if (analyser.LabelFreq.ContainsKey(labels[i]) == true)
                    tweetInfo.Text += labels[i] + ": " + analyser.LabelFreq[labels[i]] + "\n";
                else
                    tweetInfo.Text += labels[i] + ": 0" + "\n";
            }

            tweetInfo.Text += "\nTotal: " + analyser.Tweets.Length + "\n";
        }

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
        }

        private void RegisterUsers()
        {
            List<User> users = new List<User>();

            foreach (string user in cmbUserName.Items)
            {
                users.Add(new User()
                {
                    name = user,
                    labels = null
                });
            }

            for (int i = 0; i < tweetDatas.Length; i++)
            {
                // If tweets are parsed before, we do not need to register users again.
                if (tweetDatas[i].words != null && tweetDatas[i].words.Length > 0)
                    continue;

                tweetDatas[i].users = users.ToArray();
            }
        }

        private int FindUserIndex()
        {
            string selectedUser = (string)cmbUserName.SelectedItem;
            User[] users = tweetDatas[currentTweetIndex].users;

            for (int i = 0; i < users.Length; i++)
            {
                if (users[i].name == selectedUser)
                    return i;
            }

            // This should not be return never.
            return -1;
        }

        #endregion

        private void btntrain_Click(object sender, EventArgs e)
        {
            new TrainerForm(labels).Show();
            this.Hide();
        }
    }
}