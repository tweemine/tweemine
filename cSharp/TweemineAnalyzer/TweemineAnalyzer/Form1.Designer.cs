namespace TweemineAnalyzer
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTweetText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNextTweet = new System.Windows.Forms.Button();
            this.btnPrevTweet = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnWritetoJson = new System.Windows.Forms.Button();
            this.btnReadFromJson = new System.Windows.Forms.Button();
            this.btnLabeledDataNext = new System.Windows.Forms.Button();
            this.btnLabeledDataPrev = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTweetText
            // 
            this.lblTweetText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTweetText.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTweetText.Location = new System.Drawing.Point(70, 9);
            this.lblTweetText.Name = "lblTweetText";
            this.lblTweetText.Size = new System.Drawing.Size(663, 132);
            this.lblTweetText.TabIndex = 0;
            this.lblTweetText.Text = "TweetText";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tweet  :";
            // 
            // btnNextTweet
            // 
            this.btnNextTweet.Location = new System.Drawing.Point(66, 36);
            this.btnNextTweet.Name = "btnNextTweet";
            this.btnNextTweet.Size = new System.Drawing.Size(37, 28);
            this.btnNextTweet.TabIndex = 2;
            this.btnNextTweet.Tag = "1";
            this.btnNextTweet.Text = ">";
            this.toolTip1.SetToolTip(this.btnNextTweet, "Next Tweet");
            this.btnNextTweet.UseVisualStyleBackColor = true;
            this.btnNextTweet.Click += new System.EventHandler(this.NavigateTweets_Click);
            // 
            // btnPrevTweet
            // 
            this.btnPrevTweet.Location = new System.Drawing.Point(23, 36);
            this.btnPrevTweet.Name = "btnPrevTweet";
            this.btnPrevTweet.Size = new System.Drawing.Size(37, 28);
            this.btnPrevTweet.TabIndex = 2;
            this.btnPrevTweet.Tag = "-1";
            this.btnPrevTweet.Text = "<";
            this.toolTip1.SetToolTip(this.btnPrevTweet, "Previous Tweet");
            this.btnPrevTweet.UseVisualStyleBackColor = true;
            this.btnPrevTweet.Click += new System.EventHandler(this.NavigateTweets_Click);
            // 
            // btnWritetoJson
            // 
            this.btnWritetoJson.Location = new System.Drawing.Point(112, 21);
            this.btnWritetoJson.Name = "btnWritetoJson";
            this.btnWritetoJson.Size = new System.Drawing.Size(104, 58);
            this.btnWritetoJson.TabIndex = 2;
            this.btnWritetoJson.Tag = "true";
            this.btnWritetoJson.Text = "WTJ";
            this.toolTip1.SetToolTip(this.btnWritetoJson, "Write to Json");
            this.btnWritetoJson.UseVisualStyleBackColor = true;
            this.btnWritetoJson.Click += new System.EventHandler(this.ReadOrWriteToFile_Click);
            // 
            // btnReadFromJson
            // 
            this.btnReadFromJson.Location = new System.Drawing.Point(6, 21);
            this.btnReadFromJson.Name = "btnReadFromJson";
            this.btnReadFromJson.Size = new System.Drawing.Size(100, 58);
            this.btnReadFromJson.TabIndex = 2;
            this.btnReadFromJson.Tag = "false";
            this.btnReadFromJson.Text = "RFJ";
            this.toolTip1.SetToolTip(this.btnReadFromJson, "Read From Json");
            this.btnReadFromJson.UseVisualStyleBackColor = true;
            this.btnReadFromJson.Click += new System.EventHandler(this.ReadOrWriteToFile_Click);
            // 
            // btnLabeledDataNext
            // 
            this.btnLabeledDataNext.Location = new System.Drawing.Point(64, 36);
            this.btnLabeledDataNext.Name = "btnLabeledDataNext";
            this.btnLabeledDataNext.Size = new System.Drawing.Size(37, 28);
            this.btnLabeledDataNext.TabIndex = 2;
            this.btnLabeledDataNext.Tag = "1";
            this.btnLabeledDataNext.Text = ">";
            this.toolTip1.SetToolTip(this.btnLabeledDataNext, "Next Labeled Data");
            this.btnLabeledDataNext.UseVisualStyleBackColor = true;
            this.btnLabeledDataNext.Click += new System.EventHandler(this.NavigateLabeledData_Click);
            // 
            // btnLabeledDataPrev
            // 
            this.btnLabeledDataPrev.Location = new System.Drawing.Point(21, 36);
            this.btnLabeledDataPrev.Name = "btnLabeledDataPrev";
            this.btnLabeledDataPrev.Size = new System.Drawing.Size(37, 28);
            this.btnLabeledDataPrev.TabIndex = 2;
            this.btnLabeledDataPrev.Tag = "-1";
            this.btnLabeledDataPrev.Text = "<";
            this.toolTip1.SetToolTip(this.btnLabeledDataPrev, "Previous Labeled Data");
            this.btnLabeledDataPrev.UseVisualStyleBackColor = true;
            this.btnLabeledDataPrev.Click += new System.EventHandler(this.NavigateLabeledData_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNextTweet);
            this.groupBox1.Controls.Add(this.btnPrevTweet);
            this.groupBox1.Location = new System.Drawing.Point(612, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 85);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tweets";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLabeledDataNext);
            this.groupBox2.Controls.Add(this.btnLabeledDataPrev);
            this.groupBox2.Location = new System.Drawing.Point(485, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(121, 85);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Labeled Data";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnWritetoJson);
            this.groupBox3.Controls.Add(this.btnReadFromJson);
            this.groupBox3.Location = new System.Drawing.Point(257, 144);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(222, 85);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Labeled Data";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Location = new System.Drawing.Point(12, 144);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(239, 100);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Label Data";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Belirsiz",
            "Mutlu",
            "Üzgün",
            "Sinirli"});
            this.comboBox1.Location = new System.Drawing.Point(7, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tag";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(158, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Add Tag";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 249);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTweetText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTweetText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNextTweet;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnPrevTweet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLabeledDataNext;
        private System.Windows.Forms.Button btnLabeledDataPrev;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnWritetoJson;
        private System.Windows.Forms.Button btnReadFromJson;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

