namespace TweemineAnalyzer
{
    partial class Trainer
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
            this.components = new System.ComponentModel.Container();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label0 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnResultInfo = new System.Windows.Forms.Button();
            this.btnAnnInfo = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnTrainTest = new System.Windows.Forms.Button();
            this.grpTrainingSettings = new System.Windows.Forms.GroupBox();
            this.tbTestCount = new System.Windows.Forms.TrackBar();
            this.chckPickRandomly = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTestCount = new System.Windows.Forms.Label();
            this.grpAnnSettings = new System.Windows.Forms.GroupBox();
            this.tbHiddenNeuronCount = new System.Windows.Forms.TrackBar();
            this.tbLearningRate = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLearningRate = new System.Windows.Forms.Label();
            this.lblHiddenNeuronCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.pnlANNInfo = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlPicker = new System.Windows.Forms.Panel();
            this.pnlResults = new System.Windows.Forms.Panel();
            this.richtxtAnnResult = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.grpTrainingSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTestCount)).BeginInit();
            this.grpAnnSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbHiddenNeuronCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLearningRate)).BeginInit();
            this.pnlANNInfo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnlResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFileName
            // 
            this.txtFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFileName.Location = new System.Drawing.Point(79, 112);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(241, 22);
            this.txtFileName.TabIndex = 0;
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label0.Location = new System.Drawing.Point(14, 110);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(59, 20);
            this.label0.TabIndex = 1;
            this.label0.Text = "File  :";
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBrowse.Location = new System.Drawing.Point(326, 111);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(80, 22);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnResultInfo);
            this.panel1.Controls.Add(this.btnAnnInfo);
            this.panel1.Controls.Add(this.progressBar);
            this.panel1.Controls.Add(this.btnTrainTest);
            this.panel1.Controls.Add(this.grpTrainingSettings);
            this.panel1.Controls.Add(this.grpAnnSettings);
            this.panel1.Controls.Add(this.txtFileName);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.label0);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 615);
            this.panel1.TabIndex = 3;
            // 
            // btnResultInfo
            // 
            this.btnResultInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResultInfo.BackColor = System.Drawing.Color.MediumPurple;
            this.btnResultInfo.FlatAppearance.BorderSize = 0;
            this.btnResultInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResultInfo.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnResultInfo.Location = new System.Drawing.Point(348, 49);
            this.btnResultInfo.Name = "btnResultInfo";
            this.btnResultInfo.Size = new System.Drawing.Size(67, 34);
            this.btnResultInfo.TabIndex = 8;
            this.btnResultInfo.Tag = "2";
            this.btnResultInfo.Text = "Results";
            this.btnResultInfo.UseVisualStyleBackColor = false;
            this.btnResultInfo.Click += new System.EventHandler(this.BtnAnnandResultButton_Click);
            // 
            // btnAnnInfo
            // 
            this.btnAnnInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnnInfo.BackColor = System.Drawing.Color.BlueViolet;
            this.btnAnnInfo.FlatAppearance.BorderSize = 0;
            this.btnAnnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnInfo.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnnInfo.Location = new System.Drawing.Point(348, 9);
            this.btnAnnInfo.Name = "btnAnnInfo";
            this.btnAnnInfo.Size = new System.Drawing.Size(67, 34);
            this.btnAnnInfo.TabIndex = 7;
            this.btnAnnInfo.Tag = "1";
            this.btnAnnInfo.Text = "ANN";
            this.btnAnnInfo.UseVisualStyleBackColor = false;
            this.btnAnnInfo.Click += new System.EventHandler(this.BtnAnnandResultButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(4, 543);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(402, 45);
            this.progressBar.TabIndex = 6;
            this.toolTip1.SetToolTip(this.progressBar, "%70");
            this.progressBar.Value = 70;
            // 
            // btnTrainTest
            // 
            this.btnTrainTest.BackColor = System.Drawing.Color.BlueViolet;
            this.btnTrainTest.FlatAppearance.BorderSize = 0;
            this.btnTrainTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrainTest.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTrainTest.Location = new System.Drawing.Point(63, 457);
            this.btnTrainTest.Name = "btnTrainTest";
            this.btnTrainTest.Size = new System.Drawing.Size(297, 71);
            this.btnTrainTest.TabIndex = 5;
            this.btnTrainTest.Text = "Train and Test";
            this.btnTrainTest.UseVisualStyleBackColor = false;
            // 
            // grpTrainingSettings
            // 
            this.grpTrainingSettings.Controls.Add(this.tbTestCount);
            this.grpTrainingSettings.Controls.Add(this.chckPickRandomly);
            this.grpTrainingSettings.Controls.Add(this.label4);
            this.grpTrainingSettings.Controls.Add(this.lblTestCount);
            this.grpTrainingSettings.Location = new System.Drawing.Point(17, 299);
            this.grpTrainingSettings.Name = "grpTrainingSettings";
            this.grpTrainingSettings.Size = new System.Drawing.Size(388, 131);
            this.grpTrainingSettings.TabIndex = 4;
            this.grpTrainingSettings.TabStop = false;
            this.grpTrainingSettings.Text = "Training Settings";
            // 
            // tbTestCount
            // 
            this.tbTestCount.AutoSize = false;
            this.tbTestCount.LargeChange = 10;
            this.tbTestCount.Location = new System.Drawing.Point(166, 37);
            this.tbTestCount.Maximum = 50;
            this.tbTestCount.Minimum = 10;
            this.tbTestCount.Name = "tbTestCount";
            this.tbTestCount.Size = new System.Drawing.Size(137, 51);
            this.tbTestCount.SmallChange = 5;
            this.tbTestCount.TabIndex = 0;
            this.tbTestCount.Tag = "TC";
            this.tbTestCount.TickFrequency = 10;
            this.tbTestCount.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbTestCount.Value = 10;
            this.tbTestCount.Scroll += new System.EventHandler(this.TrackBars_Scroll);
            // 
            // chckPickRandomly
            // 
            this.chckPickRandomly.AutoSize = true;
            this.chckPickRandomly.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chckPickRandomly.Location = new System.Drawing.Point(226, 103);
            this.chckPickRandomly.Name = "chckPickRandomly";
            this.chckPickRandomly.Size = new System.Drawing.Size(138, 22);
            this.chckPickRandomly.TabIndex = 1;
            this.chckPickRandomly.Text = "Pick Randomly";
            this.chckPickRandomly.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Test count as %:";
            // 
            // lblTestCount
            // 
            this.lblTestCount.AutoSize = true;
            this.lblTestCount.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTestCount.Location = new System.Drawing.Point(318, 51);
            this.lblTestCount.Name = "lblTestCount";
            this.lblTestCount.Size = new System.Drawing.Size(55, 20);
            this.lblTestCount.TabIndex = 1;
            this.lblTestCount.Text = "10 %";
            // 
            // grpAnnSettings
            // 
            this.grpAnnSettings.Controls.Add(this.tbHiddenNeuronCount);
            this.grpAnnSettings.Controls.Add(this.tbLearningRate);
            this.grpAnnSettings.Controls.Add(this.label3);
            this.grpAnnSettings.Controls.Add(this.lblLearningRate);
            this.grpAnnSettings.Controls.Add(this.lblHiddenNeuronCount);
            this.grpAnnSettings.Controls.Add(this.label2);
            this.grpAnnSettings.Location = new System.Drawing.Point(17, 140);
            this.grpAnnSettings.Name = "grpAnnSettings";
            this.grpAnnSettings.Size = new System.Drawing.Size(388, 137);
            this.grpAnnSettings.TabIndex = 3;
            this.grpAnnSettings.TabStop = false;
            this.grpAnnSettings.Text = "ANN Settings";
            // 
            // tbHiddenNeuronCount
            // 
            this.tbHiddenNeuronCount.AutoSize = false;
            this.tbHiddenNeuronCount.LargeChange = 20;
            this.tbHiddenNeuronCount.Location = new System.Drawing.Point(221, 69);
            this.tbHiddenNeuronCount.Maximum = 100;
            this.tbHiddenNeuronCount.Name = "tbHiddenNeuronCount";
            this.tbHiddenNeuronCount.Size = new System.Drawing.Size(104, 51);
            this.tbHiddenNeuronCount.SmallChange = 2;
            this.tbHiddenNeuronCount.TabIndex = 0;
            this.tbHiddenNeuronCount.Tag = "HN";
            this.tbHiddenNeuronCount.TickFrequency = 10;
            this.tbHiddenNeuronCount.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbHiddenNeuronCount.Scroll += new System.EventHandler(this.TrackBars_Scroll);
            // 
            // tbLearningRate
            // 
            this.tbLearningRate.AutoSize = false;
            this.tbLearningRate.LargeChange = 20;
            this.tbLearningRate.Location = new System.Drawing.Point(221, 12);
            this.tbLearningRate.Maximum = 100;
            this.tbLearningRate.Name = "tbLearningRate";
            this.tbLearningRate.Size = new System.Drawing.Size(104, 51);
            this.tbLearningRate.SmallChange = 2;
            this.tbLearningRate.TabIndex = 0;
            this.tbLearningRate.Tag = "LR";
            this.tbLearningRate.TickFrequency = 10;
            this.tbLearningRate.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbLearningRate.Scroll += new System.EventHandler(this.TrackBars_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hidden Neuron Count :";
            // 
            // lblLearningRate
            // 
            this.lblLearningRate.AutoSize = true;
            this.lblLearningRate.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLearningRate.Location = new System.Drawing.Point(327, 30);
            this.lblLearningRate.Name = "lblLearningRate";
            this.lblLearningRate.Size = new System.Drawing.Size(20, 20);
            this.lblLearningRate.TabIndex = 1;
            this.lblLearningRate.Text = "0";
            // 
            // lblHiddenNeuronCount
            // 
            this.lblHiddenNeuronCount.AutoSize = true;
            this.lblHiddenNeuronCount.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHiddenNeuronCount.Location = new System.Drawing.Point(330, 85);
            this.lblHiddenNeuronCount.Name = "lblHiddenNeuronCount";
            this.lblHiddenNeuronCount.Size = new System.Drawing.Size(20, 20);
            this.lblHiddenNeuronCount.TabIndex = 1;
            this.lblHiddenNeuronCount.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(73, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Learning Rate :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(159, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Train and Test";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label.Location = new System.Drawing.Point(105, 36);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(215, 20);
            this.label.TabIndex = 1;
            this.label.Text = "Tweemine Text Analyzer";
            // 
            // pnlANNInfo
            // 
            this.pnlANNInfo.BackColor = System.Drawing.Color.Snow;
            this.pnlANNInfo.Controls.Add(this.groupBox3);
            this.pnlANNInfo.Controls.Add(this.label11);
            this.pnlANNInfo.Controls.Add(this.label10);
            this.pnlANNInfo.Location = new System.Drawing.Point(432, 36);
            this.pnlANNInfo.Name = "pnlANNInfo";
            this.pnlANNInfo.Size = new System.Drawing.Size(504, 576);
            this.pnlANNInfo.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(90, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(304, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ANN Info";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(75, 72);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(26, 17);
            this.label17.TabIndex = 0;
            this.label17.Text = "70";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(12, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Hidden:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(75, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 17);
            this.label16.TabIndex = 0;
            this.label16.Text = "8";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(5, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Output :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(75, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "1000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(17, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Input :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(191, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "System Info";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(137, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(215, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Tweemine Text Analyzer";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(888, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(51, 26);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Snow;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMinimize.Location = new System.Drawing.Point(845, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(42, 26);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pnlPicker
            // 
            this.pnlPicker.BackColor = System.Drawing.Color.BlueViolet;
            this.pnlPicker.Location = new System.Drawing.Point(415, 9);
            this.pnlPicker.Name = "pnlPicker";
            this.pnlPicker.Size = new System.Drawing.Size(11, 34);
            this.pnlPicker.TabIndex = 4;
            // 
            // pnlResults
            // 
            this.pnlResults.BackColor = System.Drawing.Color.Snow;
            this.pnlResults.Controls.Add(this.richtxtAnnResult);
            this.pnlResults.Location = new System.Drawing.Point(435, 39);
            this.pnlResults.Name = "pnlResults";
            this.pnlResults.Size = new System.Drawing.Size(504, 576);
            this.pnlResults.TabIndex = 5;
            // 
            // richtxtAnnResult
            // 
            this.richtxtAnnResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richtxtAnnResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richtxtAnnResult.Location = new System.Drawing.Point(0, 0);
            this.richtxtAnnResult.Name = "richtxtAnnResult";
            this.richtxtAnnResult.ReadOnly = true;
            this.richtxtAnnResult.Size = new System.Drawing.Size(504, 576);
            this.richtxtAnnResult.TabIndex = 0;
            this.richtxtAnnResult.Text = "ANN Results";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Dosya Seçiniz";
            this.openFileDialog.RestoreDirectory = true;
            // 
            // Trainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(939, 615);
            this.Controls.Add(this.pnlPicker);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlResults);
            this.Controls.Add(this.pnlANNInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Trainer";
            this.Text = "Trainer";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpTrainingSettings.ResumeLayout(false);
            this.grpTrainingSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTestCount)).EndInit();
            this.grpAnnSettings.ResumeLayout(false);
            this.grpAnnSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbHiddenNeuronCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLearningRate)).EndInit();
            this.pnlANNInfo.ResumeLayout(false);
            this.pnlANNInfo.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.pnlResults.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpTrainingSettings;
        private System.Windows.Forms.TrackBar tbTestCount;
        private System.Windows.Forms.CheckBox chckPickRandomly;
        private System.Windows.Forms.GroupBox grpAnnSettings;
        private System.Windows.Forms.TrackBar tbHiddenNeuronCount;
        private System.Windows.Forms.TrackBar tbLearningRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnResultInfo;
        private System.Windows.Forms.Button btnAnnInfo;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnTrainTest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTestCount;
        private System.Windows.Forms.Label lblLearningRate;
        private System.Windows.Forms.Label lblHiddenNeuronCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel pnlANNInfo;
        private System.Windows.Forms.Panel pnlPicker;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnlResults;
        private System.Windows.Forms.RichTextBox richtxtAnnResult;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}