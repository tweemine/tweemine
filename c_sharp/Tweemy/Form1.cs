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
        Tweets[] array;
        TTData[] arrayTdata;
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
            tTData.label = string.IsNullOrEmpty(txtLabel.Text.Trim())?"Belirsiz":txtLabel.Text.Trim();
            serializableData.Add(tTData);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //we are gonna read from the file which is in the python folder and we are in debug folder
            //cd .. -> change directory back
            StreamReader streamReader = new StreamReader(@"..\..\..\..\python\tweets.json");

            string jsonTweets = streamReader.ReadToEnd();
            
            array = JsonConvert.DeserializeObject<Tweets[]>(jsonTweets);

            lblTweet.Text = array[index++].Tweet;

            //we are reading labeled data from a file

             streamReader = new StreamReader(@"labeledData.json");

             jsonTweets = streamReader.ReadToEnd();

            arrayTdata = JsonConvert.DeserializeObject<TTData[]>(jsonTweets);

            streamReader.Close();


            //username[i%2=0]
            //tweet   [i%2=1]



            //listBox1.Items.AddRange(tweetList.ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblTweet.Text = array[(index++)%array.Length].Tweet;
        }

        private void btnSaveJson_Click(object sender, EventArgs e)
        {
            //we are writing the labeled data to a file
            TextWriter textWriter=new StreamWriter("labeledData.json");
         JsonSerializer jsonSer= JsonSerializer.Create();
            string json = JsonConvert.SerializeObject(serializableData.ToArray());
            jsonSer.Serialize(textWriter, json);
            textWriter.Close();
            
        }
        int i = 0;

        private void button2_Click_1(object sender, EventArgs e)
        {
            lblTweet.Text = arrayTdata[i++].words[0] + arrayTdata[i].label;
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
