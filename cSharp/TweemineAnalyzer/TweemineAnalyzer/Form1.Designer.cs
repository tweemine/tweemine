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
            this.btnWritetoJson = new TweemineAnalyzer.CircleButton();
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
            this.lblTweetText.Location = new System.Drawing.Point(16, 50);
            this.lblTweetText.Name = "lblTweetText";
            this.lblTweetText.Size = new System.Drawing.Size(714, 199);
            this.lblTweetText.TabIndex = 0;
            // 
            // btnNextTweet
            // 
            this.btnNextTweet.Location = new System.Drawing.Point(88, 21);
            this.btnNextTweet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNextTweet.Name = "btnNextTweet";
            this.btnNextTweet.Size = new System.Drawing.Size(67, 90);
            this.btnNextTweet.TabIndex = 2;
            this.btnNextTweet.Tag = "1";
            this.btnNextTweet.Text = ">";
            this.toolTip1.SetToolTip(this.btnNextTweet, "Next Tweet");
            this.btnNextTweet.UseVisualStyleBackColor = true;
            this.btnNextTweet.Click += new System.EventHandler(this.NavigateLabeledData_Click);
            // 
            // btnPrevTweet
            // 
            this.btnPrevTweet.Location = new System.Drawing.Point(5, 21);
            this.btnPrevTweet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrevTweet.Name = "btnPrevTweet";
            this.btnPrevTweet.Size = new System.Drawing.Size(67, 90);
            this.btnPrevTweet.TabIndex = 2;
            this.btnPrevTweet.Tag = "-1";
            this.btnPrevTweet.Text = "<";
            this.toolTip1.SetToolTip(this.btnPrevTweet, "Previous Tweet");
            this.btnPrevTweet.UseVisualStyleBackColor = true;
            this.btnPrevTweet.Click += new System.EventHandler(this.NavigateLabeledData_Click);
            // 
            // grpDataNavigation
            // 
            this.grpDataNavigation.Controls.Add(this.btnNextTweet);
            this.grpDataNavigation.Controls.Add(this.btnPrevTweet);
            this.grpDataNavigation.Location = new System.Drawing.Point(240, 258);
            this.grpDataNavigation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataNavigation.Name = "grpDataNavigation";
            this.grpDataNavigation.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataNavigation.Size = new System.Drawing.Size(161, 122);
            this.grpDataNavigation.TabIndex = 3;
            this.grpDataNavigation.TabStop = false;
            this.grpDataNavigation.Text = "Tweets";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnWritetoJson);
            this.groupBox3.Location = new System.Drawing.Point(541, 258);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(189, 132);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Labeled Data";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAddTag);
            this.groupBox4.Controls.Add(this.txttag);
            this.groupBox4.Location = new System.Drawing.Point(16, 254);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(219, 134);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Label Data";
            // 
            // btnAddTag
            // 
            this.btnAddTag.Location = new System.Drawing.Point(37, 78);
            this.btnAddTag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddTag.Name = "btnAddTag";
            this.btnAddTag.Size = new System.Drawing.Size(117, 50);
            this.btnAddTag.TabIndex = 3;
            this.btnAddTag.Text = "Add Tag";
            this.btnAddTag.UseVisualStyleBackColor = true;
            // 
            // txttag
            // 
            this.txttag.Location = new System.Drawing.Point(5, 39);
            this.txttag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttag.Name = "txttag";
            this.txttag.Size = new System.Drawing.Size(205, 22);
            this.txttag.TabIndex = 2;
            // 
            // cmbUserName
            // 
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.Items.AddRange(new object[] {
            "Şamil SOFTSAM",
            "Mehmet Ali",
            "Melih"});
            this.cmbUserName.Location = new System.Drawing.Point(67, 12);
            this.cmbUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(192, 24);
            this.cmbUserName.TabIndex = 5;
            this.cmbUserName.SelectedIndexChanged += new System.EventHandler(this.cmbUserName_SelectedIndexChanged);
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
            this.groupBox5.Location = new System.Drawing.Point(417, 258);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(117, 132);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Labels";
            // 
            // chcLstLabels
            // 
            this.chcLstLabels.CheckOnClick = true;
            this.chcLstLabels.FormattingEnabled = true;
            this.chcLstLabels.Items.AddRange(new object[] {
            "Belirsiz",
            "Sinirli",
            "Sevinçli",
            "Mutlu",
            "Üzgün",
            "Kırılmış",
            "Umutsuz",
            "Mutsuz"});
            this.chcLstLabels.Location = new System.Drawing.Point(7, 22);
            this.chcLstLabels.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chcLstLabels.Name = "chcLstLabels";
            this.chcLstLabels.Size = new System.Drawing.Size(95, 89);
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
            this.openFileButton.Location = new System.Drawing.Point(579, 9);
            this.openFileButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(151, 28);
            this.openFileButton.TabIndex = 8;
            this.openFileButton.Text = "Choose Tweet File";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // btnWritetoJson
            // 
            this.btnWritetoJson.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnWritetoJson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWritetoJson.ForeColor = System.Drawing.Color.White;
            this.btnWritetoJson.Location = new System.Drawing.Point(38, 21);
            this.btnWritetoJson.Name = "btnWritetoJson";
            this.btnWritetoJson.Size = new System.Drawing.Size(114, 108);
            this.btnWritetoJson.TabIndex = 9;
            this.btnWritetoJson.Text = "Write To json File";
            this.toolTip1.SetToolTip(this.btnWritetoJson, "Write to Json");
            this.btnWritetoJson.UseVisualStyleBackColor = false;
            this.btnWritetoJson.Click += new System.EventHandler(this.WriteToFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 400);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbUserName);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpDataNavigation);
            this.Controls.Add(this.lblTweetText);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Tweemine";
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
    }
}

