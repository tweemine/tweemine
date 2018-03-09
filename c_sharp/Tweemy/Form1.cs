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

namespace Tweemy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(Parser.ParseTheText(textBox1.Text).ToArray());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //we are gonna read from the file which is in the python folder and we are in debug folder
            //cd .. -> change directory back
            StreamReader streamReader = new StreamReader(@"..\..\..\..\python\tweets.txt");

            List<string> tweetList = new List<string>();
            //username[i%2=0]
            //tweet   [i%2=1]
            string[] tweets = streamReader.ReadToEnd().Split();
            foreach (var tweet in tweets)
            {
                if(string.IsNullOrEmpty(tweet)==false && string.IsNullOrWhiteSpace(tweet)==false )
                {
                    tweetList.Add(tweet);
                }
            }

            listBox1.Items.AddRange(tweetList.ToArray());
        }
    }
}
