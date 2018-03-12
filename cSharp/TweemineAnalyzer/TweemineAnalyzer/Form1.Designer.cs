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
            this.btnNextTweet = new System.Windows.Forms.Button();
            this.btnPrevTweet = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnWritetoJson = new System.Windows.Forms.Button();
            this.btnReadFromJson = new System.Windows.Forms.Button();
            this.grpDataNavigation = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAddTag = new System.Windows.Forms.Button();
            this.txttag = new System.Windows.Forms.TextBox();
            this.btnTag = new System.Windows.Forms.Button();
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chcLstLabels = new System.Windows.Forms.CheckedListBox();
            this.toggle1 = new TweemineAnalyzer.toggle();
            this.grpDataNavigation.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            // btnNextTweet
            // 
            this.btnNextTweet.Location = new System.Drawing.Point(88, 21);
            this.btnNextTweet.Name = "btnNextTweet";
            this.btnNextTweet.Size = new System.Drawing.Size(65, 35);
            this.btnNextTweet.TabIndex = 2;
            this.btnNextTweet.Tag = "1";
            this.btnNextTweet.Text = ">";
            this.toolTip1.SetToolTip(this.btnNextTweet, "Next Tweet");
            this.btnNextTweet.UseVisualStyleBackColor = true;
            // 
            // btnPrevTweet
            // 
            this.btnPrevTweet.Location = new System.Drawing.Point(6, 21);
            this.btnPrevTweet.Name = "btnPrevTweet";
            this.btnPrevTweet.Size = new System.Drawing.Size(65, 35);
            this.btnPrevTweet.TabIndex = 2;
            this.btnPrevTweet.Tag = "-1";
            this.btnPrevTweet.Text = "<";
            this.toolTip1.SetToolTip(this.btnPrevTweet, "Previous Tweet");
            this.btnPrevTweet.UseVisualStyleBackColor = true;
            // 
            // btnWritetoJson
            // 
            this.btnWritetoJson.Location = new System.Drawing.Point(72, 37);
            this.btnWritetoJson.Name = "btnWritetoJson";
            this.btnWritetoJson.Size = new System.Drawing.Size(60, 73);
            this.btnWritetoJson.TabIndex = 2;
            this.btnWritetoJson.Tag = "true";
            this.btnWritetoJson.Text = "WTJ";
            this.toolTip1.SetToolTip(this.btnWritetoJson, "Write to Json");
            this.btnWritetoJson.UseVisualStyleBackColor = true;
            this.btnWritetoJson.Click += new System.EventHandler(this.ReadOrWriteToFile_Click);
            // 
            // btnReadFromJson
            // 
            this.btnReadFromJson.Location = new System.Drawing.Point(6, 39);
            this.btnReadFromJson.Name = "btnReadFromJson";
            this.btnReadFromJson.Size = new System.Drawing.Size(60, 71);
            this.btnReadFromJson.TabIndex = 2;
            this.btnReadFromJson.Tag = "false";
            this.btnReadFromJson.Text = "RFJ";
            this.toolTip1.SetToolTip(this.btnReadFromJson, "Read From Json");
            this.btnReadFromJson.UseVisualStyleBackColor = true;
            this.btnReadFromJson.Click += new System.EventHandler(this.ReadOrWriteToFile_Click);
            // 
            // grpDataNavigation
            // 
            this.grpDataNavigation.Controls.Add(this.btnNextTweet);
            this.grpDataNavigation.Controls.Add(this.btnPrevTweet);
            this.grpDataNavigation.Location = new System.Drawing.Point(240, 309);
            this.grpDataNavigation.Name = "grpDataNavigation";
            this.grpDataNavigation.Size = new System.Drawing.Size(161, 72);
            this.grpDataNavigation.TabIndex = 3;
            this.grpDataNavigation.TabStop = false;
            this.grpDataNavigation.Text = "Tweets";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnWritetoJson);
            this.groupBox3.Controls.Add(this.btnReadFromJson);
            this.groupBox3.Location = new System.Drawing.Point(591, 259);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(139, 132);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Labeled Data";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAddTag);
            this.groupBox4.Controls.Add(this.txttag);
            this.groupBox4.Location = new System.Drawing.Point(16, 253);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(218, 134);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Label Data";
            // 
            // btnAddTag
            // 
            this.btnAddTag.Location = new System.Drawing.Point(37, 77);
            this.btnAddTag.Name = "btnAddTag";
            this.btnAddTag.Size = new System.Drawing.Size(118, 51);
            this.btnAddTag.TabIndex = 3;
            this.btnAddTag.Text = "Add Tag";
            this.btnAddTag.UseVisualStyleBackColor = true;
            // 
            // txttag
            // 
            this.txttag.Location = new System.Drawing.Point(6, 40);
            this.txttag.Name = "txttag";
            this.txttag.Size = new System.Drawing.Size(205, 22);
            this.txttag.TabIndex = 2;
            // 
            // btnTag
            // 
            this.btnTag.Location = new System.Drawing.Point(108, 21);
            this.btnTag.Name = "btnTag";
            this.btnTag.Size = new System.Drawing.Size(51, 106);
            this.btnTag.TabIndex = 1;
            this.btnTag.Text = "Tag";
            this.btnTag.UseVisualStyleBackColor = true;
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chcLstLabels);
            this.groupBox5.Controls.Add(this.btnTag);
            this.groupBox5.Location = new System.Drawing.Point(417, 259);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(168, 132);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Labels";
            // 
            // chcLstLabels
            // 
            this.chcLstLabels.FormattingEnabled = true;
            this.chcLstLabels.Items.AddRange(new object[] {
            "Sinirli",
            "Sevinçli",
            "Mutlu",
            "Üzgün"});
            this.chcLstLabels.Location = new System.Drawing.Point(7, 22);
            this.chcLstLabels.Name = "chcLstLabels";
            this.chcLstLabels.Size = new System.Drawing.Size(95, 106);
            this.chcLstLabels.TabIndex = 2;
            // 
            // toggle1
            // 
            this.toggle1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.toggle1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toggle1.Location = new System.Drawing.Point(250, 270);
            this.toggle1.Name = "toggle1";
            this.toggle1.Size = new System.Drawing.Size(161, 33);
            this.toggle1.State = true;
            this.toggle1.TabIndex = 8;
            this.toggle1.Toggle1Color = System.Drawing.Color.MediumAquamarine;
            this.toggle1.Toggle1Text = "Tweet";
            this.toggle1.Toggle2Color = System.Drawing.Color.LightSeaGreen;
            this.toggle1.Toggle2Text = "Labeled Data";
            this.toggle1.ToggleChanged += new TweemineAnalyzer.toggle.Toggled(this.toggle1_ToggleChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 400);
            this.Controls.Add(this.toggle1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbUserName);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpDataNavigation);
            this.Controls.Add(this.lblTweetText);
            this.Name = "Form1";
            this.Text = "Tweemine";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpDataNavigation.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTweetText;
        private System.Windows.Forms.Button btnNextTweet;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnPrevTweet;
        private System.Windows.Forms.GroupBox grpDataNavigation;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnWritetoJson;
        private System.Windows.Forms.Button btnReadFromJson;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAddTag;
        private System.Windows.Forms.TextBox txttag;
        private System.Windows.Forms.Button btnTag;
        private System.Windows.Forms.ComboBox cmbUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckedListBox chcLstLabels;
        private toggle toggle1;
    }
}

