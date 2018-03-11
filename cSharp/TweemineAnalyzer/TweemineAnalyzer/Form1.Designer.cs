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
            this.btnAddTag = new System.Windows.Forms.Button();
            this.txttag = new System.Windows.Forms.TextBox();
            this.btnTag = new System.Windows.Forms.Button();
            this.cmbTags = new System.Windows.Forms.ComboBox();
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.lblTweetText.Location = new System.Drawing.Point(16, 51);
            this.lblTweetText.Name = "lblTweetText";
            this.lblTweetText.Size = new System.Drawing.Size(714, 199);
            this.lblTweetText.TabIndex = 0;
            this.lblTweetText.Text = "TweetText";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(325, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tweet ";
            // 
            // btnNextTweet
            // 
            this.btnNextTweet.Location = new System.Drawing.Point(69, 30);
            this.btnNextTweet.Name = "btnNextTweet";
            this.btnNextTweet.Size = new System.Drawing.Size(46, 54);
            this.btnNextTweet.TabIndex = 2;
            this.btnNextTweet.Tag = "1";
            this.btnNextTweet.Text = ">";
            this.toolTip1.SetToolTip(this.btnNextTweet, "Next Tweet");
            this.btnNextTweet.UseVisualStyleBackColor = true;
            this.btnNextTweet.Click += new System.EventHandler(this.NavigateTweets_Click);
            // 
            // btnPrevTweet
            // 
            this.btnPrevTweet.Location = new System.Drawing.Point(6, 30);
            this.btnPrevTweet.Name = "btnPrevTweet";
            this.btnPrevTweet.Size = new System.Drawing.Size(46, 54);
            this.btnPrevTweet.TabIndex = 2;
            this.btnPrevTweet.Tag = "-1";
            this.btnPrevTweet.Text = "<";
            this.toolTip1.SetToolTip(this.btnPrevTweet, "Previous Tweet");
            this.btnPrevTweet.UseVisualStyleBackColor = true;
            this.btnPrevTweet.Click += new System.EventHandler(this.NavigateTweets_Click);
            // 
            // btnWritetoJson
            // 
            this.btnWritetoJson.Location = new System.Drawing.Point(112, 30);
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
            this.btnReadFromJson.Location = new System.Drawing.Point(6, 30);
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
            this.btnLabeledDataNext.Location = new System.Drawing.Point(69, 30);
            this.btnLabeledDataNext.Name = "btnLabeledDataNext";
            this.btnLabeledDataNext.Size = new System.Drawing.Size(46, 54);
            this.btnLabeledDataNext.TabIndex = 2;
            this.btnLabeledDataNext.Tag = "1";
            this.btnLabeledDataNext.Text = ">";
            this.toolTip1.SetToolTip(this.btnLabeledDataNext, "Next Labeled Data");
            this.btnLabeledDataNext.UseVisualStyleBackColor = true;
            this.btnLabeledDataNext.Click += new System.EventHandler(this.NavigateLabeledData_Click);
            // 
            // btnLabeledDataPrev
            // 
            this.btnLabeledDataPrev.Location = new System.Drawing.Point(6, 30);
            this.btnLabeledDataPrev.Name = "btnLabeledDataPrev";
            this.btnLabeledDataPrev.Size = new System.Drawing.Size(46, 54);
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
            this.groupBox1.Location = new System.Drawing.Point(261, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tweets";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLabeledDataNext);
            this.groupBox2.Controls.Add(this.btnLabeledDataPrev);
            this.groupBox2.Location = new System.Drawing.Point(388, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(121, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Labeled Data";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnWritetoJson);
            this.groupBox3.Controls.Add(this.btnReadFromJson);
            this.groupBox3.Location = new System.Drawing.Point(515, 253);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(222, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Labeled Data";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAddTag);
            this.groupBox4.Controls.Add(this.txttag);
            this.groupBox4.Controls.Add(this.btnTag);
            this.groupBox4.Controls.Add(this.cmbTags);
            this.groupBox4.Location = new System.Drawing.Point(16, 253);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(239, 100);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Label Data";
            // 
            // btnAddTag
            // 
            this.btnAddTag.Location = new System.Drawing.Point(158, 56);
            this.btnAddTag.Name = "btnAddTag";
            this.btnAddTag.Size = new System.Drawing.Size(75, 32);
            this.btnAddTag.TabIndex = 3;
            this.btnAddTag.Text = "Add Tag";
            this.btnAddTag.UseVisualStyleBackColor = true;
            // 
            // txttag
            // 
            this.txttag.Location = new System.Drawing.Point(7, 62);
            this.txttag.Name = "txttag";
            this.txttag.Size = new System.Drawing.Size(121, 22);
            this.txttag.TabIndex = 2;
            // 
            // btnTag
            // 
            this.btnTag.Location = new System.Drawing.Point(158, 16);
            this.btnTag.Name = "btnTag";
            this.btnTag.Size = new System.Drawing.Size(75, 34);
            this.btnTag.TabIndex = 1;
            this.btnTag.Text = "Tag";
            this.btnTag.UseVisualStyleBackColor = true;
            this.btnTag.Click += new System.EventHandler(this.btnTag_Click);
            // 
            // cmbTags
            // 
            this.cmbTags.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTags.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTags.FormattingEnabled = true;
            this.cmbTags.Items.AddRange(new object[] {
            "Belirsiz",
            "Mutlu",
            "Üzgün",
            "Sinirli"});
            this.cmbTags.Location = new System.Drawing.Point(7, 22);
            this.cmbTags.Name = "cmbTags";
            this.cmbTags.Size = new System.Drawing.Size(121, 24);
            this.cmbTags.TabIndex = 0;
            // 
            // cmbUserName
            // 
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.Items.AddRange(new object[] {
            "Şamil SOFTSAM",
            "Mehmet Ali",
            "Melih"});
            this.cmbUserName.Location = new System.Drawing.Point(67, 12);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(192, 24);
            this.cmbUserName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "User :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 410);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbUserName);
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
        private System.Windows.Forms.Button btnAddTag;
        private System.Windows.Forms.TextBox txttag;
        private System.Windows.Forms.Button btnTag;
        private System.Windows.Forms.ComboBox cmbTags;
        private System.Windows.Forms.ComboBox cmbUserName;
        private System.Windows.Forms.Label label2;
    }
}

