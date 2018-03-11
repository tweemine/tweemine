using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using Newtonsoft.Json;

namespace Tweemy
{
    public partial class Form1 : Form
    {
        int index = 0;
        Tweets[] readTweetArray;
        TTData[] arrayTdata;
        dynamic labeledData;
        public Form1()
        {
            InitializeComponent();
            serializableData = new List<TTData>();
        }
        List<TTData> serializableData;
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(Parser.ParseTheText(lblTweet.Text).ToArray());
            TTData tTData = new TTData();
            tTData.words = Parser.ParseTheText(lblTweet.Text).ToArray();
            tTData.label = cmbTags.Text.Trim();
            serializableData.Add(tTData);
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
                ReadRawTweets();
                ReadLabeledData();
        }
        //we are gonna read from the file which is in the python folder and we are in debug folder
        //cd .. -> change directory back
        void ReadRawTweets()
        {

            using (StreamReader streamReader = new StreamReader(@"..\..\..\..\..\python\tweets.json"))
            {
                try
                {
                    string jsonTweets = streamReader.ReadToEnd();

                    readTweetArray = JsonConvert.DeserializeObject<Tweets[]>(jsonTweets);

                    lblTweet.Text = readTweetArray[index++].Tweet;
                }
                catch
                {
                    streamReader.Close();
                }
                finally
                {
                    streamReader.Close();
                }
            }
        }
        //we are reading labeled data from a file
        void ReadLabeledData()
        {
            using (TextReader textreader = new StreamReader("labeledData.json",Encoding.UTF8))
            {
                try
                {
                    string jsonTweets = textreader.ReadToEnd();

                    
                    arrayTdata = JsonConvert.DeserializeObject<TTData[]>(jsonTweets);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    textreader.Close();
                }
                finally
                {
                    textreader.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblTweet.Text = readTweetArray[(index++)%readTweetArray.Length].Tweet;
        }

        private void btnSaveJson_Click(object sender, EventArgs e)
        {
            //we are writing the labeled data to a file
            TextWriter textWriter=new StreamWriter("labeledData.json");
            JsonSerializer jsonSer = new JsonSerializer();
            string json = JsonConvert.SerializeObject(serializableData.ToArray());
            jsonSer.Serialize(textWriter, json);
            
            textWriter.Close();
            
        }
        int labeledTweetIndex = 0;

        private void btnLabeled_Click(object sender, EventArgs e)
        {
            string tweet = "";
            for (int i = 0; i < arrayTdata[i++].words.Length; i++)
            {
                tweet += arrayTdata[i++].words[i]+ " ";
            }
            lblTweet.Text = "Tweet:" +tweet+ "\nLabel:["+ arrayTdata[labeledTweetIndex].label+"]";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReadLabeledData();
        }
    }
    class Tweets
    {
        public string Tweet;
    }
    class TTData
    {
        public string[] words;
        public string label;
    }
}
