using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using TweemineNeuralNetwork;

namespace TweemineAnalyzer
{
    public partial class TrainerForm : Form
    {
        #region Variables
        
        string nnParentPath = Path.Combine("..", "..", "..", "..", "..", "tweets", "NNConfig");
        //string nnFile = "NN.json";
        //string nntestDataFile = "testing.json";
        string TrainDataFile = "TrainClass.json";
        //string nnAnalyserFile = "analyser.json";
        static string tagsPath = Path.Combine("..", "..", "..", "..", "..", "tweets", "tags.txt");
        static string fileName = "all_tweets.json";
        static string defaultTweetPath = Path.Combine("..", "..", "..", "..", "..", "tweets", fileName);

        Trainer trainer;
        string filePath = "";
        string[] labels;

        //we need this for changing UI
        bool trackbarschanged = true;

        private bool mouseDown;
        private Point lastLocation;
        TrainingType trainedType;
        int[,] confussion;
        #endregion

        #region Constructor

        public TrainerForm(string[] _labels)
        {
            InitializeComponent();
            pnlResults.Visible = false;
            labels = _labels;
            lblLearningRate.Text = ((tbLearningRate.Value / 100.0f)).ToString();
            lblHiddenNeuronCount.Text = tbHiddenNeuronCount.Value.ToString();
            lblTestPercent.Text = tbTestCount.Value.ToString() + " %";
            txtFileName.Text = fileName;
            filePath = defaultTweetPath;
            confussion = new int[labels.Length, labels.Length];
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
            lblTestPercent.Text = tbTestCount.Value.ToString() + " %";
            txtFileName.Text = defaultTweetPath;
            filePath = defaultTweetPath;

            confussion = new int[labels.Length, labels.Length];

        }

        #endregion

        #region ComponentsEvents

        private void UpMenuButtons_Click(object sender, EventArgs e)
        {
            Button button = ((Button)sender);
            pnlPicker.Left = button.Left;
            pnlPicker.BackColor = button.BackColor;

            if (button.Tag.ToString() == "1")
            {
                pnlANNInfo.Visible = true;
                pnlResults.Visible = false;
                pnlTrainAndTesting.Visible = false;


            }
            if (button.Tag.ToString() == "2")
            {
                pnlANNInfo.Visible = false;
                pnlResults.Visible = true;
                pnlTrainAndTesting.Visible = false;

            }
            if (button.Tag.ToString() == "3")
            {
                pnlANNInfo.Visible = false;
                pnlResults.Visible = false;
                pnlTrainAndTesting.Visible = true;

                ShowSavedData(trainer.Analyser.TrainingTweets);

            }
            if (button.Tag.ToString() == "4")
            {
                pnlANNInfo.Visible = false;
                pnlResults.Visible = false;
                pnlTrainAndTesting.Visible = true;
                ShowSavedData(trainer.Analyser.TestingTweets);
            }
            if (button.Tag.ToString() == "5")
            {
                pnlANNInfo.Visible = false;
                pnlResults.Visible = false;
                pnlTrainAndTesting.Visible = true;
                //create confussion Matrix here
                ShowCMatrix();
            }
        }

        private void ShowCMatrix()
        {
            txtTrainingandTesting.Clear();
            txtTrainingandTesting.AppendText(string.Format("{0,-30}", ""));
            for (int i = 0; i < labels.Length; i++)
            {
                txtTrainingandTesting.AppendText(string.Format("{0,-15}",labels[i]));
            }
            txtTrainingandTesting.AppendText("\n");
            for (int i = 0; i < labels.Length; i++)
            {
                txtTrainingandTesting.AppendText(string.Format("{0,-10}", labels[i]));
                for (int j = 0; j < labels.Length; j++)
                {
                    txtTrainingandTesting.AppendText(string.Format("{0,18}" , confussion[i,j].ToString()));
                }
                txtTrainingandTesting.AppendText("\n\n");
            }
        }

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
            Hide();
            new TweemineMain().Show();
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
                lblTestPercent.Text = trackBar.Value.ToString() + " %";
            if (trackbarschanged == false)
            {
                btnTrainTest.Text = "Train and Test";
                btnTrainTest.Click += btnTrainTest_Click;
                btnTrainTest.Click -= btnTest_Click;
                trackbarschanged = true;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFileName.Text = openFileDialog.SafeFileName;
                filePath = openFileDialog.FileName;
            }
        }

        private void btnSaveANN_Click(object sender, EventArgs e)
        {
            trainer.trainingType = trainedType;
            JsonFileController.WriteToJsonFile(Path.Combine(nnParentPath, TrainDataFile), trainer);
        }

        private void btnLoadAnn_Click(object sender, EventArgs e)
        {
            trainer = JsonFileController.ReadDataFromJsonFile<Trainer>(Path.Combine(nnParentPath, TrainDataFile));
            ShowNeuralNetworkInfo(trainer.Neuralnetwork);
            trackbarschanged = false;
            btnNNTraining.Enabled = btnNNTesting.Enabled = btnTest.Enabled = btnCMatrix.Enabled = true;
            toggle1.Value = trainer.trainingType == TrainingType.WORD_TRAINING ? true : false;
            trainedType = trainer.trainingType;
            lblsystemType.Text = trainingType.ToString();
        }

        private void btnTrainTest_Click(object sender, EventArgs e)
        {
            TrainTest(trainingType);
            trainedType = trainingType;
            lblsystemType.Text = trainedType.ToString();
            btnCMatrix.Enabled = true;

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Test(trainedType);
        }

        #endregion

        #region Trainer Methods

        private void TrainTest(TrainingType type)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("you have to choose a file to train....");
                return;
            }

            btnTest.Enabled = true;
            progressBar.Value = 0;

            TweetData[] twData = JsonFileController.ReadDataFromJsonFile<TweetData[]>(filePath);
            ParseTweets(ref twData, type);

            Analyser analyser = new Analyser(twData, labels, tbTestCount.Value, chckPickRandomly.Checked);
            if (type == TrainingType.WORD_TRAINING)
                analyser.Analyse1();
            else
                analyser.Analyse2();

            progressBar.Maximum = twData.Length;

            trainer = new Trainer(analyser, tbHiddenNeuronCount.Value, double.Parse(lblLearningRate.Text), type);

            List<List<Tuple<int, double>>> list;
            if (type == TrainingType.WORD_TRAINING)
            {
                trainer.Train1(progressBar);
                list = trainer.Test1(progressBar);
            }
            else
            {
                trainer.Train2(progressBar);
                list = trainer.Test2(progressBar);
            }

            Test(type, analyser);
            //richtxtAnnResult.Text = "";
            //for (int i = 0; i < analyser.TestingTweets.Length; i++)
            //{
            //    richtxtAnnResult.AppendText("TWEET:\n\n");
            //    richtxtAnnResult.AppendText(analyser.TestingTweets[i].tweet + "\n\n");


            //    richtxtAnnResult.AppendText("PREDICTION:\n\n");
            //    for (int j = 0; j < list[i].Count; j++)
            //    {
            //        string val = labels[list[i][j].Item1];
            //        double percentage = list[i][j].Item2 * 100;
            //        richtxtAnnResult.AppendText(val + ":\t" + percentage.ToString("F2") + "%\n");
            //    }

            //    richtxtAnnResult.AppendText("\nANSWER: " + analyser.TestingTweets[i].users[0].labels[0]);

            //    richtxtAnnResult.AppendText("\n\n");
            //    richtxtAnnResult.AppendText("#################################################################\n\n");
            //}

            ShowAnalyserInfo(trainer);
        }

        private void Test(TrainingType type,Analyser analyser=null)
        {
            
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("you have to choose a file to train....");
                return;
            }
            if (analyser == null)
                analyser = trainer.Analyser;

            TweetData[] twData = analyser.TestingTweets;
            progressBar.Value = 0;
            progressBar.Maximum = twData.Length;

            List<List<Tuple<int, double>>> list;
            if (type == TrainingType.WORD_TRAINING)
                list = trainer.Test1(progressBar);
            else
                list = trainer.Test2(progressBar);

            confussion = new int[labels.Length, labels.Length];


            richtxtAnnResult.Text = "";
            for (int i = 0; i < analyser.TestingTweets.Length; i++)
            {
                richtxtAnnResult.AppendText("TWEET:\n\n");
                richtxtAnnResult.AppendText(analyser.TestingTweets[i].tweet + "\n\n");
                double max = double.MinValue;
                int index=0;

                richtxtAnnResult.AppendText("PREDICTION:\n\n");
                for (int j = 0; j < list[i].Count; j++)
                {
                   
                       
                  
                    // We may want to percentage of prediction
                    string val = labels[list[i][j].Item1];
                    double percentage = list[i][j].Item2 * 100;
                    if (percentage > max)
                    {
                        max = percentage;
                        index = list[i][j].Item1;
                    }


                        richtxtAnnResult.AppendText(val + ": " + percentage.ToString("F2") + "%\n");
                }
               int correct_Index = Array.IndexOf(labels, analyser.TestingTweets[i].users[0].labels[0]);

                confussion[correct_Index, index]++;
                richtxtAnnResult.AppendText("\nANSWER:\t" + analyser.TestingTweets[i].users[0].labels[0]);

                richtxtAnnResult.AppendText("\n\n");
                richtxtAnnResult.AppendText("######################################################n\n");
            }

            ShowAnalyserInfo(trainer);
        }

        #endregion

        #region Update Info Methods

        void ShowSavedData(TweetData[] _tweets)
        {
            txtTrainingandTesting.Clear();
            TweetData[] _tweetDatas = _tweets;
            for (int i = 0; i < _tweetDatas.Length; i++)
            {
                txtTrainingandTesting.AppendText("Tweet:\n\n");
                txtTrainingandTesting.AppendText(_tweetDatas[i].tweet + "\n\n");
                txtTrainingandTesting.AppendText("\n\n");
                txtTrainingandTesting.AppendText("------------------------------------------------\n\n");
            }
        }

        private void ShowAnalyserInfo(Trainer trainer)
        {
            lblHiddenShowCount.Text = trainer.Neuralnetwork.HiddenNodes.ToString();
            lblInputCount.Text = trainer.Neuralnetwork.InputNodes.ToString();
            lblOutputCount.Text = trainer.Neuralnetwork.OutputNodes.ToString();
            lblTestingCount.Text = trainer.Analyser.TestingCount.ToString();
            lblTrainingCount.Text = trainer.Analyser.TrainingCount.ToString();
            lblAccuracy.Text = trainer.Analyser.Accuracy.ToString("F2");
        }

        private void ShowNeuralNetworkInfo(NeuralNetwork neuralNetwork)
        {
            tbHiddenNeuronCount.Value = neuralNetwork.HiddenNodes;
            lblHiddenNeuronCount.Text = neuralNetwork.HiddenNodes.ToString();
            tbLearningRate.Value = (int)(neuralNetwork.LearningRate * 100);
            lblLearningRate.Text = (tbLearningRate.Value / 100.0).ToString();
            lblHiddenShowCount.Text = neuralNetwork.HiddenNodes.ToString();
            lblInputCount.Text = neuralNetwork.InputNodes.ToString();
            lblOutputCount.Text = neuralNetwork.OutputNodes.ToString();
        }

        #endregion

        #region Helpers

        void ParseTweets(ref TweetData[] tweetDatas, TrainingType type)
        {
            foreach (TweetData data in tweetDatas)
            {
                if (type == TrainingType.WORD_TRAINING)
                {
                    string[] parsedTweet = Parser.ParseTheText1(data.tweet).ToArray();
                    data.words = parsedTweet;
                }
                else
                {
                    string parsedTweet = Parser.ParseTheText2(data.tweet);
                    data.parsedTweet = parsedTweet;
                }
            }
        }

        #endregion


        TrainingType trainingType=TrainingType.FEATURE_TRAINING;
        private void toggle1_ToggleChanged(bool val)
        {
            if(val==false)
            {
               trainingType = TrainingType.FEATURE_TRAINING;
                
            }
            else
            {
                trainingType = TrainingType.WORD_TRAINING;
                
            }
        }
    }
}
