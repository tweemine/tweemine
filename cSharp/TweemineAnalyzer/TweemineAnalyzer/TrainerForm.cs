using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TweemineAnalyzer
{
    public partial class TrainerForm : Form
    {
        static string tagsPath = Path.Combine("..", "..", "..", "..", "..", "tweets", "tags.txt");
        static string fileName = "all_tweets.json";
        static string defaultTweetPath = Path.Combine("..", "..", "..", "..", "..", "tweets", fileName);

        Trainer trainer;
        string filePath = "";
        string[] labels;   

        public TrainerForm(string[] _labels)
        {
            InitializeComponent();
            pnlResults.Visible = false;
            labels = _labels;
            lblLearningRate.Text = ((tbLearningRate.Value / 100.0f)).ToString();
            lblHiddenNeuronCount.Text = tbHiddenNeuronCount.Value.ToString();
            lblTestCount.Text = tbTestCount.Value.ToString() + " %";
            txtFileName.Text = fileName;
            filePath = defaultTweetPath;
        }

        public TrainerForm()
        {
            InitializeComponent();

            pnlResults.Visible = false;
            //You have to read labels from file
            List<string> labelList = new List<string>();

            StreamReader stream = new StreamReader(tagsPath, Encoding.GetEncoding(1254));
            while (!stream.EndOfStream)
            {
                string label = stream.ReadLine();
                labelList.Add(label);
            }
            stream.Close();

            labels = labelList.ToArray();
            lblLearningRate.Text = ((tbLearningRate.Value / 100.0f)).ToString();
            lblHiddenNeuronCount.Text = tbHiddenNeuronCount.Value.ToString();
            lblTestCount.Text = tbTestCount.Value.ToString() + " %";
            txtFileName.Text = defaultTweetPath;
            filePath = defaultTweetPath;
            
        }


        private void BtnAnnandResultButton_Click(object sender, EventArgs e)
        {
            Button button = ((Button)sender);
            pnlPicker.Top = button.Top;
            pnlPicker.BackColor = button.BackColor;

            if (button.Tag.ToString() == "1")
            {
                pnlANNInfo.Visible = true;
                pnlResults.Visible = false;

            }
            if (button.Tag.ToString() == "2")
            {
                pnlANNInfo.Visible = false;
                pnlResults.Visible = true;

            }
        }

        private bool mouseDown;
        private Point lastLocation;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TrackBars_Scroll(object sender, EventArgs e)
        {
            TrackBar trackBar = ((TrackBar)sender);
            if (trackBar.Tag.ToString() == "LR")
                lblLearningRate.Text = ((trackBar.Value / 100.0f)).ToString();
            else if (trackBar.Tag.ToString() == "HN")
                lblHiddenNeuronCount.Text = trackBar.Value.ToString();
            else
                lblTestCount.Text = trackBar.Value.ToString()+" %";
        }
        
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                txtFileName.Text = openFileDialog.SafeFileName;
                filePath = openFileDialog.FileName;
            }
        }
       
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

        void ParseTweets(ref TweetData[] tweetDatas)
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

        private void btnTrainTest_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("you have to choose a file to train....");
                return;
            }

            TweetData[] twData = ReadTweetsFromJsonFile(filePath);
            ParseTweets(ref twData);
            Analyser analyser = new Analyser(twData, labels,tbTestCount.Value,chckPickRandomly.Checked);
            analyser.Analyse();
            trainer = new Trainer(analyser, tbHiddenNeuronCount.Value, double.Parse(lblLearningRate.Text));
            trainer.Train();

            List<List<int>> list = trainer.Test();


            richtxtAnnResult.Text = "";
            for (int i = 0; i < analyser.TestingTweets.Length; i++)
            {
                richtxtAnnResult.AppendText("Tweet:\n\n");
                richtxtAnnResult.AppendText(analyser.TestingTweets[i].tweet + "\n\n");
                

                richtxtAnnResult.AppendText("Prediction: ");
                for (int j = 0; j < list[i].Count; j++)
                {
                    // We may want to percentage of prediction
                    string val = labels[list[i][j]];
                    richtxtAnnResult.AppendText(val + " ");
                }

                richtxtAnnResult.AppendText("\n\n");
                richtxtAnnResult.AppendText("------------------------------------------------\n\n");
            }

        }
    }
}
