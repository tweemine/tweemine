namespace Tweemy
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.txtLabel = new System.Windows.Forms.TextBox();
            this.lblTweet = new System.Windows.Forms.Label();
            this.btnNextTweet = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSaveJson = new System.Windows.Forms.Button();
            this.btnLabeled = new System.Windows.Forms.Button();
            this.cmbTags = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(577, 289);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Etiketle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLabel
            // 
            this.txtLabel.Location = new System.Drawing.Point(21, 294);
            this.txtLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(215, 22);
            this.txtLabel.TabIndex = 1;
            // 
            // lblTweet
            // 
            this.lblTweet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTweet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTweet.Location = new System.Drawing.Point(16, 11);
            this.lblTweet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTweet.Name = "lblTweet";
            this.lblTweet.Size = new System.Drawing.Size(636, 199);
            this.lblTweet.TabIndex = 3;
            this.lblTweet.Text = "@denizbasaran60: @denizim48 @EvitanNeslihan @Fatoss_ata @Fikriye59 @AtaminKiziyim" +
    " @SeherdoganD @hseyinmacar6 @bayramali35 @ertasramazan1…";
            // 
            // btnNextTweet
            // 
            this.btnNextTweet.Location = new System.Drawing.Point(447, 214);
            this.btnNextTweet.Margin = new System.Windows.Forms.Padding(4);
            this.btnNextTweet.Name = "btnNextTweet";
            this.btnNextTweet.Size = new System.Drawing.Size(97, 33);
            this.btnNextTweet.TabIndex = 4;
            this.btnNextTweet.Text = "Next Tweet";
            this.btnNextTweet.UseVisualStyleBackColor = true;
            this.btnNextTweet.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(21, 350);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(631, 116);
            this.listBox1.TabIndex = 5;
            // 
            // btnSaveJson
            // 
            this.btnSaveJson.Location = new System.Drawing.Point(542, 474);
            this.btnSaveJson.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveJson.Name = "btnSaveJson";
            this.btnSaveJson.Size = new System.Drawing.Size(117, 49);
            this.btnSaveJson.TabIndex = 6;
            this.btnSaveJson.Text = "Save To Json";
            this.btnSaveJson.UseVisualStyleBackColor = true;
            this.btnSaveJson.Click += new System.EventHandler(this.btnSaveJson_Click);
            // 
            // btnLabeled
            // 
            this.btnLabeled.Location = new System.Drawing.Point(555, 214);
            this.btnLabeled.Margin = new System.Windows.Forms.Padding(4);
            this.btnLabeled.Name = "btnLabeled";
            this.btnLabeled.Size = new System.Drawing.Size(97, 33);
            this.btnLabeled.TabIndex = 7;
            this.btnLabeled.Text = "labeled";
            this.btnLabeled.UseVisualStyleBackColor = true;
            this.btnLabeled.Click += new System.EventHandler(this.btnLabeled_Click);
            // 
            // cmbTags
            // 
            this.cmbTags.FormattingEnabled = true;
            this.cmbTags.Items.AddRange(new object[] {
            "Mutlu",
            "Üzgün",
            "Sinirli",
            "Kederli",
            "Sevgi"});
            this.cmbTags.Location = new System.Drawing.Point(405, 291);
            this.cmbTags.Name = "cmbTags";
            this.cmbTags.Size = new System.Drawing.Size(169, 24);
            this.cmbTags.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(242, 291);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 27);
            this.button3.TabIndex = 9;
            this.button3.Text = "Etiket Ekle";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(418, 474);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 49);
            this.button4.TabIndex = 10;
            this.button4.Text = "Read from Json";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnNextTweet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 526);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cmbTags);
            this.Controls.Add(this.btnLabeled);
            this.Controls.Add(this.btnSaveJson);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnNextTweet);
            this.Controls.Add(this.lblTweet);
            this.Controls.Add(this.txtLabel);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtLabel;
        private System.Windows.Forms.Label lblTweet;
        private System.Windows.Forms.Button btnNextTweet;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSaveJson;
        private System.Windows.Forms.Button btnLabeled;
        private System.Windows.Forms.ComboBox cmbTags;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

