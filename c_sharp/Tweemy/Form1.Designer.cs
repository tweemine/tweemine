﻿namespace Tweemy
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
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 237);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "Etiketle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLabel
            // 
            this.txtLabel.Location = new System.Drawing.Point(11, 237);
            this.txtLabel.Margin = new System.Windows.Forms.Padding(2);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(162, 20);
            this.txtLabel.TabIndex = 1;
            // 
            // lblTweet
            // 
            this.lblTweet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTweet.Location = new System.Drawing.Point(12, 9);
            this.lblTweet.Name = "lblTweet";
            this.lblTweet.Size = new System.Drawing.Size(477, 162);
            this.lblTweet.TabIndex = 3;
            this.lblTweet.Text = "label1";
            // 
            // btnNextTweet
            // 
            this.btnNextTweet.Location = new System.Drawing.Point(204, 174);
            this.btnNextTweet.Name = "btnNextTweet";
            this.btnNextTweet.Size = new System.Drawing.Size(131, 41);
            this.btnNextTweet.TabIndex = 4;
            this.btnNextTweet.Text = "Next Tweet";
            this.btnNextTweet.UseVisualStyleBackColor = true;
            this.btnNextTweet.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(28, 318);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(421, 95);
            this.listBox1.TabIndex = 5;
            // 
            // btnSaveJson
            // 
            this.btnSaveJson.Location = new System.Drawing.Point(404, 431);
            this.btnSaveJson.Name = "btnSaveJson";
            this.btnSaveJson.Size = new System.Drawing.Size(85, 40);
            this.btnSaveJson.TabIndex = 6;
            this.btnSaveJson.Text = "Save To Json";
            this.btnSaveJson.UseVisualStyleBackColor = true;
            this.btnSaveJson.Click += new System.EventHandler(this.btnSaveJson_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(359, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 40);
            this.button2.TabIndex = 7;
            this.button2.Text = "labeled";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnNextTweet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 468);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSaveJson);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnNextTweet);
            this.Controls.Add(this.lblTweet);
            this.Controls.Add(this.txtLabel);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button button2;
    }
}

