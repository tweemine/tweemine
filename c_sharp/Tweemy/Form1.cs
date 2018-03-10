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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(Parser.ParseTheText(lblTweet.Text).ToArray());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //we are gonna read from the file which is in the python folder and we are in debug folder
            //cd .. -> change directory back
            StreamReader streamReader = new StreamReader(@"..\..\..\..\python\tweets.json");

            string jsonTweets = streamReader.ReadToEnd();
            
            array = JsonConvert.DeserializeObject<Tweets[]>(jsonTweets);

            lblTweet.Text = array[index++].Tweet;

           
                
           

            //username[i%2=0]
            //tweet   [i%2=1]
            
            

            //listBox1.Items.AddRange(tweetList.ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblTweet.Text = array[(index++)%array.Length].Tweet;
        }
    }
    class Tweets
    {
        public string Tweet;
    }
}
