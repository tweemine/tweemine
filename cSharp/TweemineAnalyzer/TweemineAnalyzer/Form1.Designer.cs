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
            this.cntMnFile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNextTweet = new System.Windows.Forms.Button();
            this.btnPrevTweet = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnDelTweet = new System.Windows.Forms.Button();
            this.grpDataNavigation = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAddTag = new System.Windows.Forms.Button();
            this.txttag = new System.Windows.Forms.TextBox();
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chcLstLabels = new System.Windows.Forms.CheckedListBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFileButton = new System.Windows.Forms.Button();
            this.combineButton = new System.Windows.Forms.Button();
            this.folderBD = new System.Windows.Forms.FolderBrowserDialog();
            this.btntrain = new System.Windows.Forms.Button();
            this.tweetInfo = new System.Windows.Forms.Label();
            this.tweetIndex = new System.Windows.Forms.Label();
            this.btnWritetoJson = new TweemineAnalyzer.CircleButton();
            this.cntMnFile.SuspendLayout();
            this.grpDataNavigation.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTweetText
            // 
            this.lblTweetText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTweetText.ContextMenuStrip = this.cntMnFile;
            this.lblTweetText.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTweetText.Location = new System.Drawing.Point(12, 44);
            this.lblTweetText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTweetText.Name = "lblTweetText";
            this.lblTweetText.Size = new System.Drawing.Size(535, 274);
            this.lblTweetText.TabIndex = 0;
            // 
            // cntMnFile
            // 
            this.cntMnFile.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cntMnFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.cntMnFile.Name = "cntMnFile";
            this.cntMnFile.Size = new System.Drawing.Size(104, 48);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.WriteToFile_Click);
            // 
            // btnNextTweet
            // 
            this.btnNextTweet.Location = new System.Drawing.Point(66, 32);
            this.btnNextTweet.Margin = new System.Windows.Forms.Padding(2);
            this.btnNextTweet.Name = "btnNextTweet";
            this.btnNextTweet.Size = new System.Drawing.Size(50, 40);
            this.btnNextTweet.TabIndex = 2;
            this.btnNextTweet.Tag = "1";
            this.btnNextTweet.Text = ">";
            this.toolTip1.SetToolTip(this.btnNextTweet, "Next Tweet");
            this.btnNextTweet.UseVisualStyleBackColor = true;
            this.btnNextTweet.Click += new System.EventHandler(this.NavigateLabeledData_Click);
            // 
            // btnPrevTweet
            // 
            this.btnPrevTweet.Location = new System.Drawing.Point(5, 32);
            this.btnPrevTweet.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrevTweet.Name = "btnPrevTweet";
            this.btnPrevTweet.Size = new System.Drawing.Size(50, 40);
            this.btnPrevTweet.TabIndex = 2;
            this.btnPrevTweet.Tag = "-1";
            this.btnPrevTweet.Text = "<";
            this.toolTip1.SetToolTip(this.btnPrevTweet, "Previous Tweet");
            this.btnPrevTweet.UseVisualStyleBackColor = true;
            this.btnPrevTweet.Click += new System.EventHandler(this.NavigateLabeledData_Click);
            // 
            // btnDelTweet
            // 
            this.btnDelTweet.Location = new System.Drawing.Point(5, 85);
            this.btnDelTweet.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelTweet.Name = "btnDelTweet";
            this.btnDelTweet.Size = new System.Drawing.Size(111, 35);
            this.btnDelTweet.TabIndex = 3;
            this.btnDelTweet.Text = "Delete Tweet";
            this.toolTip1.SetToolTip(this.btnDelTweet, "Delete this tweet from file. This wont be saving the file till you close the prog" +
        "ram.");
            this.btnDelTweet.UseVisualStyleBackColor = true;
            this.btnDelTweet.Click += new System.EventHandler(this.btnDelTweet_Click);
            // 
            // grpDataNavigation
            // 
            this.grpDataNavigation.Controls.Add(this.btnDelTweet);
            this.grpDataNavigation.Controls.Add(this.btnNextTweet);
            this.grpDataNavigation.Controls.Add(this.btnPrevTweet);
            this.grpDataNavigation.Location = new System.Drawing.Point(179, 331);
            this.grpDataNavigation.Margin = new System.Windows.Forms.Padding(2);
            this.grpDataNavigation.Name = "grpDataNavigation";
            this.grpDataNavigation.Padding = new System.Windows.Forms.Padding(2);
            this.grpDataNavigation.Size = new System.Drawing.Size(121, 124);
            this.grpDataNavigation.TabIndex = 3;
            this.grpDataNavigation.TabStop = false;
            this.grpDataNavigation.Text = "Tweets";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnWritetoJson);
            this.groupBox3.Location = new System.Drawing.Point(465, 331);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(82, 124);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Labeled Data";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAddTag);
            this.groupBox4.Controls.Add(this.txttag);
            this.groupBox4.Location = new System.Drawing.Point(11, 331);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(164, 124);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Label Data";
            // 
            // btnAddTag
            // 
            this.btnAddTag.Location = new System.Drawing.Point(5, 79);
            this.btnAddTag.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddTag.Name = "btnAddTag";
            this.btnAddTag.Size = new System.Drawing.Size(155, 41);
            this.btnAddTag.TabIndex = 3;
            this.btnAddTag.Text = "Add Tag";
            this.btnAddTag.UseVisualStyleBackColor = true;
            this.btnAddTag.Click += new System.EventHandler(this.btnAddTag_Click);
            // 
            // txttag
            // 
            this.txttag.Location = new System.Drawing.Point(4, 32);
            this.txttag.Margin = new System.Windows.Forms.Padding(2);
            this.txttag.Name = "txttag";
            this.txttag.Size = new System.Drawing.Size(155, 20);
            this.txttag.TabIndex = 2;
            // 
            // cmbUserName
            // 
            this.cmbUserName.Enabled = false;
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.Items.AddRange(new object[] {
            "Default"});
            this.cmbUserName.Location = new System.Drawing.Point(50, 10);
            this.cmbUserName.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(145, 21);
            this.cmbUserName.TabIndex = 5;
            this.cmbUserName.SelectedIndexChanged += new System.EventHandler(this.cmbUserName_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "User :";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chcLstLabels);
            this.groupBox5.Location = new System.Drawing.Point(313, 331);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(148, 124);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Labels";
            // 
            // chcLstLabels
            // 
            this.chcLstLabels.CheckOnClick = true;
            this.chcLstLabels.Location = new System.Drawing.Point(4, 20);
            this.chcLstLabels.Margin = new System.Windows.Forms.Padding(2);
            this.chcLstLabels.Name = "chcLstLabels";
            this.chcLstLabels.Size = new System.Drawing.Size(130, 94);
            this.chcLstLabels.TabIndex = 2;
            this.chcLstLabels.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chcLstLabels_ItemCheck);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // openFileButton
            // 
            this.openFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openFileButton.Location = new System.Drawing.Point(526, 7);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(100, 23);
            this.openFileButton.TabIndex = 8;
            this.openFileButton.Text = "Choose Tweet File";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // combineButton
            // 
            this.combineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combineButton.Location = new System.Drawing.Point(632, 7);
            this.combineButton.Name = "combineButton";
            this.combineButton.Size = new System.Drawing.Size(105, 23);
            this.combineButton.TabIndex = 9;
            this.combineButton.Text = "Combine All Tweets";
            this.combineButton.UseVisualStyleBackColor = true;
            this.combineButton.Click += new System.EventHandler(this.combineButton_Click);
            // 
            // folderBD
            // 
            this.folderBD.Description = "Select a folder that includes multiple json files to combine.";
            // 
            // btntrain
            // 
            this.btntrain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btntrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntrain.Location = new System.Drawing.Point(743, 7);
            this.btntrain.Name = "btntrain";
            this.btntrain.Size = new System.Drawing.Size(105, 23);
            this.btntrain.TabIndex = 10;
            this.btntrain.Text = "Train and Test";
            this.btntrain.UseVisualStyleBackColor = true;
            this.btntrain.Click += new System.EventHandler(this.btntrain_Click);
            // 
            // tweetInfo
            // 
            this.tweetInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tweetInfo.ContextMenuStrip = this.cntMnFile;
            this.tweetInfo.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tweetInfo.Location = new System.Drawing.Point(552, 44);
            this.tweetInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tweetInfo.Name = "tweetInfo";
            this.tweetInfo.Size = new System.Drawing.Size(298, 274);
            this.tweetInfo.TabIndex = 11;
            // 
            // tweetIndex
            // 
            this.tweetIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tweetIndex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tweetIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tweetIndex.Location = new System.Drawing.Point(760, 429);
            this.tweetIndex.Name = "tweetIndex";
            this.tweetIndex.Size = new System.Drawing.Size(88, 26);
            this.tweetIndex.TabIndex = 12;
            this.tweetIndex.Text = "0/0";
            this.tweetIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnWritetoJson
            // 
            this.btnWritetoJson.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnWritetoJson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWritetoJson.ForeColor = System.Drawing.Color.White;
            this.btnWritetoJson.Location = new System.Drawing.Point(11, 28);
            this.btnWritetoJson.Margin = new System.Windows.Forms.Padding(2);
            this.btnWritetoJson.Name = "btnWritetoJson";
            this.btnWritetoJson.Size = new System.Drawing.Size(59, 58);
            this.btnWritetoJson.TabIndex = 9;
            this.btnWritetoJson.Text = "Write To json File";
            this.toolTip1.SetToolTip(this.btnWritetoJson, "Write to Json");
            this.btnWritetoJson.UseVisualStyleBackColor = false;
            this.btnWritetoJson.Click += new System.EventHandler(this.WriteToFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 466);
            this.ContextMenuStrip = this.cntMnFile;
            this.Controls.Add(this.tweetIndex);
            this.Controls.Add(this.tweetInfo);
            this.Controls.Add(this.btntrain);
            this.Controls.Add(this.combineButton);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbUserName);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpDataNavigation);
            this.Controls.Add(this.lblTweetText);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Tweemine";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.cntMnFile.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAddTag;
        private System.Windows.Forms.TextBox txttag;
        private System.Windows.Forms.ComboBox cmbUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckedListBox chcLstLabels;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button openFileButton;
        private CircleButton btnWritetoJson;
        private System.Windows.Forms.Button btnDelTweet;
        private System.Windows.Forms.ContextMenuStrip cntMnFile;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Button combineButton;
        private System.Windows.Forms.FolderBrowserDialog folderBD;
        private System.Windows.Forms.Button btntrain;
        private System.Windows.Forms.Label tweetInfo;
        private System.Windows.Forms.Label tweetIndex;
    }
}

