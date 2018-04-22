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
        string nnParentPath = Path.Combine("..", "..", "..", "..", "..", "tweets", "NNConfig");
        string nnFile = "NN.json";
        string nntestDataFile = "testing.json";
        string nntrainDataFile = "training.json";
        static string tagsPath = Path.Combine("..", "..", "..", "..", "..", "tweets", "tags.txt");
        static string fileName = "all_tweets.json";
        static string defaultTweetPath = Path.Combine("..", "..", "..", "..", "..", "tweets", fileName);

        Trainer trainer;
        string filePath = "";
        string[] labels;

        //we need this for changing UI
        bool trackbarschanged = true;

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

        }


        private void BtnAnnandResultButton_Click(object sender, EventArgs e)
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

                ReadNNTweets(nntrainDataFile);

            }
            if (button.Tag.ToString() == "4")
            {
                pnlANNInfo.Visible = false;
                pnlResults.Visible = false;
                pnlTrainAndTesting.Visible = true;
                ReadNNTweets(nntestDataFile);
            }
        }
        void ReadNNTweets(string file)
        {
            txtTrainingandTesting.Clear();
            TweetData[] _tweetDatas = JsonFileController.ReadDataFromJsonFile<TweetData[]>(Path.Combine(nnParentPath, file));
            for (int i = 0; i < _tweetDatas.Length; i++)
            {
                txtTrainingandTesting.AppendText("Tweet:\n\n");
                txtTrainingandTesting.AppendText(_tweetDatas[i].tweet + "\n\n");
                txtTrainingandTesting.AppendText("\n\n");
                txtTrainingandTesting.AppendText("------------------------------------------------\n\n");
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
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("you have to choose a file to train....");
                return;
            }

            TweetData[] twData = JsonFileController.ReadDataFromJsonFile<TweetData[]>(filePath);
            ParseTweets(ref twData);
            Analyser analyser = new Analyser(twData, labels, tbTestCount.Value, chckPickRandomly.Checked);
            analyser.Analyse();
            progressBar.Value = 0;
            progressBar.Maximum = twData.Length;
            trainer = new Trainer(analyser, tbHiddenNeuronCount.Value, double.Parse(lblLearningRate.Text));
            trainer.Train(progressBar);

            List<List<Tuple<int, double>>> list = trainer.Test(progressBar);


            richtxtAnnResult.Text = "";
            for (int i = 0; i < analyser.TestingTweets.Length; i++)
            {
                richtxtAnnResult.AppendText("TWEET:\n\n");
                richtxtAnnResult.AppendText(analyser.TestingTweets[i].tweet + "\n\n");


                richtxtAnnResult.AppendText("PREDICTION:\n\n");
                for (int j = 0; j < list[i].Count; j++)
                {
                    string val = labels[list[i][j].Item1];
                    double percentage = list[i][j].Item2 * 100;
                    richtxtAnnResult.AppendText(val + ":\t" + percentage.ToString("F2") + "%\n");
                }

                richtxtAnnResult.AppendText("\nANSWER: " + analyser.TestingTweets[i].users[0].labels[0]);

                richtxtAnnResult.AppendText("\n\n");
                richtxtAnnResult.AppendText("#################################################################\n\n");
            }

            ShowAnalyserInfo(trainer);
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

        private void btnSaveANN_Click(object sender, EventArgs e)
        {
            JsonFileController.WriteToJsonFile(Path.Combine(nnParentPath, nnFile), trainer.Neuralnetwork);
            JsonFileController.WriteToJsonFile(Path.Combine(nnParentPath, nntestDataFile), trainer.Analyser.TestingTweets);
            JsonFileController.WriteToJsonFile(Path.Combine(nnParentPath, nntrainDataFile), trainer.Analyser.TrainingTweets);

        }

        private void btnLoadAnn_Click(object sender, EventArgs e)
        {
            NeuralNetwork neuralNetwork = JsonFileController.ReadDataFromJsonFile<NeuralNetwork>(Path.Combine(nnParentPath, nnFile));

            trainer = new Trainer(null, neuralNetwork.HiddenNodes, neuralNetwork.LearningRate);
            trainer.Neuralnetwork = neuralNetwork;

            btnTrainTest.Text = "TEST";
            btnTrainTest.Click -= btnTrainTest_Click;
            btnTrainTest.Click += btnTest_Click;
            ShowNeuralNetworkInfo(trainer.Neuralnetwork);
            trackbarschanged = false;
            btnNNTraining.Enabled = btnNNTesting.Enabled = true;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("you have to choose a file to train....");
                return;
            }

            TweetData[] twData = JsonFileController.ReadDataFromJsonFile<TweetData[]>(Path.Combine(nnParentPath, nntestDataFile));
            ParseTweets(ref twData);
            Analyser analyser = new Analyser(twData, labels);
            analyser.Analyse();
            progressBar.Value = 0;
            progressBar.Maximum = twData.Length;
            trainer.Analyser = analyser;
            List<List<Tuple<int, double>>> list = trainer.Test(progressBar);

            richtxtAnnResult.Text = "";
            for (int i = 0; i < analyser.TestingTweets.Length; i++)
            {
                richtxtAnnResult.AppendText("TWEET:\n\n");
                richtxtAnnResult.AppendText(analyser.TestingTweets[i].tweet + "\n\n");

                richtxtAnnResult.AppendText("PREDICTION:\n\n");
                for (int j = 0; j < list[i].Count; j++)
                {
                    // We may want to percentage of prediction
                    string val = labels[list[i][j].Item1];
                    double percentage = list[i][j].Item2 * 100;
                    richtxtAnnResult.AppendText(val + ": " + percentage.ToString("F2") + "%\n");
                }
                
                richtxtAnnResult.AppendText("\nANSWER:\t" + analyser.TestingTweets[i].users[0].labels[0]);
                
                richtxtAnnResult.AppendText("\n\n");
                richtxtAnnResult.AppendText("######################################################n\n");
            }

            ShowAnalyserInfo(trainer);
        }
    }
}
