namespace TweemineAnalyzer
{
    partial class TrainerForm
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnTrainTest = new System.Windows.Forms.Button();
            this.grpTrainingSettings = new System.Windows.Forms.GroupBox();
            this.tbTestCount = new System.Windows.Forms.TrackBar();
            this.chckPickRandomly = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTestPercent = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoadAnn = new System.Windows.Forms.Button();
            this.grpAnnSettings = new System.Windows.Forms.GroupBox();
            this.tbHiddenNeuronCount = new System.Windows.Forms.TrackBar();
            this.tbLearningRate = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLearningRate = new System.Windows.Forms.Label();
            this.lblHiddenNeuronCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.btnResultInfo = new System.Windows.Forms.Button();
            this.btnAnnInfo = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlPicker = new System.Windows.Forms.Panel();
            this.pnlResults = new System.Windows.Forms.Panel();
            this.richtxtAnnResult = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnNNTraining = new System.Windows.Forms.Button();
            this.btnNNTesting = new System.Windows.Forms.Button();
            this.pnlANNInfo = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblHiddenShowCount = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblOutputCount = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblAccuracy = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTestingCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTrainingCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblInputCount = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSaveANN = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlTrainAndTesting = new System.Windows.Forms.Panel();
            this.txtTrainingandTesting = new System.Windows.Forms.RichTextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grpTrainingSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTestCount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpAnnSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbHiddenNeuronCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLearningRate)).BeginInit();
            this.pnlResults.SuspendLayout();
            this.pnlANNInfo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.pnlTrainAndTesting.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFileName
            // 
            this.txtFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFileName.Location = new System.Drawing.Point(79, 106);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(241, 28);
            this.txtFileName.TabIndex = 0;
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label0.Location = new System.Drawing.Point(13, 111);
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
            this.btnBrowse.Location = new System.Drawing.Point(325, 103);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(80, 34);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.progressBar);
            this.panel1.Controls.Add(this.btnTest);
            this.panel1.Controls.Add(this.btnTrainTest);
            this.panel1.Controls.Add(this.grpTrainingSettings);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.grpAnnSettings);
            this.panel1.Controls.Add(this.txtFileName);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.label0);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 742);
            this.panel1.TabIndex = 3;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(16, 685);
            this.progressBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(389, 46);
            this.progressBar.TabIndex = 6;
            this.toolTip1.SetToolTip(this.progressBar, "%70");
            // 
            // btnTrainTest
            // 
            this.btnTrainTest.BackColor = System.Drawing.Color.BlueViolet;
            this.btnTrainTest.FlatAppearance.BorderSize = 0;
            this.btnTrainTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrainTest.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTrainTest.Location = new System.Drawing.Point(19, 599);
            this.btnTrainTest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTrainTest.Name = "btnTrainTest";
            this.btnTrainTest.Size = new System.Drawing.Size(172, 71);
            this.btnTrainTest.TabIndex = 5;
            this.btnTrainTest.Text = "Train and Test";
            this.btnTrainTest.UseVisualStyleBackColor = false;
            this.btnTrainTest.Click += new System.EventHandler(this.btnTrainTest_Click);
            // 
            // grpTrainingSettings
            // 
            this.grpTrainingSettings.Controls.Add(this.tbTestCount);
            this.grpTrainingSettings.Controls.Add(this.chckPickRandomly);
            this.grpTrainingSettings.Controls.Add(this.label4);
            this.grpTrainingSettings.Controls.Add(this.lblTestPercent);
            this.grpTrainingSettings.Location = new System.Drawing.Point(17, 459);
            this.grpTrainingSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTrainingSettings.Name = "grpTrainingSettings";
            this.grpTrainingSettings.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTrainingSettings.Size = new System.Drawing.Size(388, 130);
            this.grpTrainingSettings.TabIndex = 4;
            this.grpTrainingSettings.TabStop = false;
            this.grpTrainingSettings.Text = "Training Settings";
            // 
            // tbTestCount
            // 
            this.tbTestCount.AutoSize = false;
            this.tbTestCount.LargeChange = 10;
            this.tbTestCount.Location = new System.Drawing.Point(165, 37);
            this.tbTestCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTestCount.Maximum = 50;
            this.tbTestCount.Minimum = 10;
            this.tbTestCount.Name = "tbTestCount";
            this.tbTestCount.Size = new System.Drawing.Size(137, 50);
            this.tbTestCount.SmallChange = 5;
            this.tbTestCount.TabIndex = 0;
            this.tbTestCount.Tag = "TC";
            this.tbTestCount.TickFrequency = 10;
            this.tbTestCount.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbTestCount.Value = 30;
            this.tbTestCount.Scroll += new System.EventHandler(this.TrackBars_Scroll);
            // 
            // chckPickRandomly
            // 
            this.chckPickRandomly.AutoSize = true;
            this.chckPickRandomly.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chckPickRandomly.Location = new System.Drawing.Point(220, 103);
            this.chckPickRandomly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.label4.Location = new System.Drawing.Point(5, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Test count as %:";
            // 
            // lblTestPercent
            // 
            this.lblTestPercent.AutoSize = true;
            this.lblTestPercent.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTestPercent.Location = new System.Drawing.Point(303, 50);
            this.lblTestPercent.Name = "lblTestPercent";
            this.lblTestPercent.Size = new System.Drawing.Size(55, 20);
            this.lblTestPercent.TabIndex = 1;
            this.lblTestPercent.Text = "10 %";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLoadAnn);
            this.groupBox1.Controls.Add(this.btnSaveANN);
            this.groupBox1.Location = new System.Drawing.Point(17, 311);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Size = new System.Drawing.Size(388, 132);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ANN Settings";
            // 
            // btnLoadAnn
            // 
            this.btnLoadAnn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLoadAnn.FlatAppearance.BorderSize = 0;
            this.btnLoadAnn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadAnn.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLoadAnn.Location = new System.Drawing.Point(40, 36);
            this.btnLoadAnn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnLoadAnn.Name = "btnLoadAnn";
            this.btnLoadAnn.Size = new System.Drawing.Size(133, 69);
            this.btnLoadAnn.TabIndex = 5;
            this.btnLoadAnn.Text = "Load ANN";
            this.btnLoadAnn.UseVisualStyleBackColor = false;
            this.btnLoadAnn.Click += new System.EventHandler(this.btnLoadAnn_Click);
            // 
            // grpAnnSettings
            // 
            this.grpAnnSettings.Controls.Add(this.tbHiddenNeuronCount);
            this.grpAnnSettings.Controls.Add(this.tbLearningRate);
            this.grpAnnSettings.Controls.Add(this.label3);
            this.grpAnnSettings.Controls.Add(this.lblLearningRate);
            this.grpAnnSettings.Controls.Add(this.lblHiddenNeuronCount);
            this.grpAnnSettings.Controls.Add(this.label2);
            this.grpAnnSettings.Location = new System.Drawing.Point(17, 162);
            this.grpAnnSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAnnSettings.Name = "grpAnnSettings";
            this.grpAnnSettings.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.tbHiddenNeuronCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbHiddenNeuronCount.Maximum = 100;
            this.tbHiddenNeuronCount.Minimum = 10;
            this.tbHiddenNeuronCount.Name = "tbHiddenNeuronCount";
            this.tbHiddenNeuronCount.Size = new System.Drawing.Size(104, 50);
            this.tbHiddenNeuronCount.TabIndex = 0;
            this.tbHiddenNeuronCount.Tag = "HN";
            this.tbHiddenNeuronCount.TickFrequency = 10;
            this.tbHiddenNeuronCount.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbHiddenNeuronCount.Value = 30;
            this.tbHiddenNeuronCount.Scroll += new System.EventHandler(this.TrackBars_Scroll);
            // 
            // tbLearningRate
            // 
            this.tbLearningRate.AutoSize = false;
            this.tbLearningRate.LargeChange = 20;
            this.tbLearningRate.Location = new System.Drawing.Point(221, 12);
            this.tbLearningRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLearningRate.Maximum = 100;
            this.tbLearningRate.Name = "tbLearningRate";
            this.tbLearningRate.Size = new System.Drawing.Size(104, 50);
            this.tbLearningRate.TabIndex = 0;
            this.tbLearningRate.Tag = "LR";
            this.tbLearningRate.TickFrequency = 10;
            this.tbLearningRate.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbLearningRate.Value = 5;
            this.tbLearningRate.Scroll += new System.EventHandler(this.TrackBars_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(5, 85);
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
            this.lblHiddenNeuronCount.Location = new System.Drawing.Point(331, 85);
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
            // btnResultInfo
            // 
            this.btnResultInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResultInfo.BackColor = System.Drawing.Color.MediumPurple;
            this.btnResultInfo.FlatAppearance.BorderSize = 0;
            this.btnResultInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResultInfo.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnResultInfo.Location = new System.Drawing.Point(551, 0);
            this.btnResultInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResultInfo.Name = "btnResultInfo";
            this.btnResultInfo.Size = new System.Drawing.Size(109, 57);
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
            this.btnAnnInfo.Location = new System.Drawing.Point(441, 0);
            this.btnAnnInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnnInfo.Name = "btnAnnInfo";
            this.btnAnnInfo.Size = new System.Drawing.Size(109, 57);
            this.btnAnnInfo.TabIndex = 7;
            this.btnAnnInfo.Tag = "1";
            this.btnAnnInfo.Text = "ANN";
            this.btnAnnInfo.UseVisualStyleBackColor = false;
            this.btnAnnInfo.Click += new System.EventHandler(this.BtnAnnandResultButton_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1219, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnMinimize.Location = new System.Drawing.Point(1176, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(43, 26);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pnlPicker
            // 
            this.pnlPicker.BackColor = System.Drawing.Color.BlueViolet;
            this.pnlPicker.Location = new System.Drawing.Point(441, 60);
            this.pnlPicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPicker.Name = "pnlPicker";
            this.pnlPicker.Size = new System.Drawing.Size(109, 10);
            this.pnlPicker.TabIndex = 4;
            // 
            // pnlResults
            // 
            this.pnlResults.BackColor = System.Drawing.Color.Snow;
            this.pnlResults.Controls.Add(this.richtxtAnnResult);
            this.pnlResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlResults.Location = new System.Drawing.Point(0, 0);
            this.pnlResults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlResults.Name = "pnlResults";
            this.pnlResults.Size = new System.Drawing.Size(807, 654);
            this.pnlResults.TabIndex = 5;
            // 
            // richtxtAnnResult
            // 
            this.richtxtAnnResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richtxtAnnResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richtxtAnnResult.Location = new System.Drawing.Point(0, 0);
            this.richtxtAnnResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richtxtAnnResult.MaximumSize = new System.Drawing.Size(867, 566);
            this.richtxtAnnResult.Name = "richtxtAnnResult";
            this.richtxtAnnResult.ReadOnly = true;
            this.richtxtAnnResult.Size = new System.Drawing.Size(807, 566);
            this.richtxtAnnResult.TabIndex = 0;
            this.richtxtAnnResult.Text = "";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Dosya Seçiniz";
            this.openFileDialog.RestoreDirectory = true;
            // 
            // btnNNTraining
            // 
            this.btnNNTraining.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNNTraining.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnNNTraining.Enabled = false;
            this.btnNNTraining.FlatAppearance.BorderSize = 0;
            this.btnNNTraining.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNNTraining.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNNTraining.Location = new System.Drawing.Point(660, 0);
            this.btnNNTraining.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNNTraining.Name = "btnNNTraining";
            this.btnNNTraining.Size = new System.Drawing.Size(109, 57);
            this.btnNNTraining.TabIndex = 7;
            this.btnNNTraining.Tag = "3";
            this.btnNNTraining.Text = "Training Data";
            this.btnNNTraining.UseVisualStyleBackColor = false;
            this.btnNNTraining.Click += new System.EventHandler(this.BtnAnnandResultButton_Click);
            // 
            // btnNNTesting
            // 
            this.btnNNTesting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNNTesting.BackColor = System.Drawing.Color.SlateBlue;
            this.btnNNTesting.Enabled = false;
            this.btnNNTesting.FlatAppearance.BorderSize = 0;
            this.btnNNTesting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNNTesting.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNNTesting.Location = new System.Drawing.Point(769, 0);
            this.btnNNTesting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNNTesting.Name = "btnNNTesting";
            this.btnNNTesting.Size = new System.Drawing.Size(109, 57);
            this.btnNNTesting.TabIndex = 8;
            this.btnNNTesting.Tag = "4";
            this.btnNNTesting.Text = "Testing Data";
            this.btnNNTesting.UseVisualStyleBackColor = false;
            this.btnNNTesting.Click += new System.EventHandler(this.BtnAnnandResultButton_Click);
            // 
            // pnlANNInfo
            // 
            this.pnlANNInfo.BackColor = System.Drawing.Color.Snow;
            this.pnlANNInfo.Controls.Add(this.groupBox3);
            this.pnlANNInfo.Controls.Add(this.label11);
            this.pnlANNInfo.Controls.Add(this.label10);
            this.pnlANNInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlANNInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlANNInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlANNInfo.Name = "pnlANNInfo";
            this.pnlANNInfo.Size = new System.Drawing.Size(807, 654);
            this.pnlANNInfo.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblHiddenShowCount);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.lblOutputCount);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.lblAccuracy);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lblTestingCount);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.lblTrainingCount);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lblInputCount);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(254, 236);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(304, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ANN Info";
            // 
            // lblHiddenShowCount
            // 
            this.lblHiddenShowCount.AutoSize = true;
            this.lblHiddenShowCount.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHiddenShowCount.Location = new System.Drawing.Point(75, 71);
            this.lblHiddenShowCount.Name = "lblHiddenShowCount";
            this.lblHiddenShowCount.Size = new System.Drawing.Size(17, 17);
            this.lblHiddenShowCount.TabIndex = 0;
            this.lblHiddenShowCount.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(12, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Hidden:";
            // 
            // lblOutputCount
            // 
            this.lblOutputCount.AutoSize = true;
            this.lblOutputCount.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOutputCount.Location = new System.Drawing.Point(75, 47);
            this.lblOutputCount.Name = "lblOutputCount";
            this.lblOutputCount.Size = new System.Drawing.Size(17, 17);
            this.lblOutputCount.TabIndex = 0;
            this.lblOutputCount.Text = "0";
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
            // lblAccuracy
            // 
            this.lblAccuracy.AutoSize = true;
            this.lblAccuracy.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAccuracy.Location = new System.Drawing.Point(196, 71);
            this.lblAccuracy.Name = "lblAccuracy";
            this.lblAccuracy.Size = new System.Drawing.Size(37, 17);
            this.lblAccuracy.TabIndex = 0;
            this.lblAccuracy.Text = "0 %";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(117, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Accuracy :";
            // 
            // lblTestingCount
            // 
            this.lblTestingCount.AutoSize = true;
            this.lblTestingCount.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTestingCount.Location = new System.Drawing.Point(196, 47);
            this.lblTestingCount.Name = "lblTestingCount";
            this.lblTestingCount.Size = new System.Drawing.Size(17, 17);
            this.lblTestingCount.TabIndex = 0;
            this.lblTestingCount.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(131, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Testing :";
            // 
            // lblTrainingCount
            // 
            this.lblTrainingCount.AutoSize = true;
            this.lblTrainingCount.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTrainingCount.Location = new System.Drawing.Point(196, 22);
            this.lblTrainingCount.Name = "lblTrainingCount";
            this.lblTrainingCount.Size = new System.Drawing.Size(17, 17);
            this.lblTrainingCount.TabIndex = 0;
            this.lblTrainingCount.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(125, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Training :";
            // 
            // lblInputCount
            // 
            this.lblInputCount.AutoSize = true;
            this.lblInputCount.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInputCount.Location = new System.Drawing.Point(75, 22);
            this.lblInputCount.Name = "lblInputCount";
            this.lblInputCount.Size = new System.Drawing.Size(17, 17);
            this.lblInputCount.TabIndex = 0;
            this.lblInputCount.Text = "0";
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
            this.label11.Location = new System.Drawing.Point(354, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "System Info";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(300, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(215, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Tweemine Text Analyzer";
            // 
            // btnSaveANN
            // 
            this.btnSaveANN.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSaveANN.FlatAppearance.BorderSize = 0;
            this.btnSaveANN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveANN.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaveANN.Location = new System.Drawing.Point(214, 36);
            this.btnSaveANN.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSaveANN.Name = "btnSaveANN";
            this.btnSaveANN.Size = new System.Drawing.Size(133, 69);
            this.btnSaveANN.TabIndex = 5;
            this.btnSaveANN.Text = "Save ANN Settings";
            this.btnSaveANN.UseVisualStyleBackColor = false;
            this.btnSaveANN.Click += new System.EventHandler(this.btnSaveANN_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.pnlANNInfo);
            this.pnlContainer.Controls.Add(this.pnlResults);
            this.pnlContainer.Controls.Add(this.pnlTrainAndTesting);
            this.pnlContainer.Location = new System.Drawing.Point(441, 75);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(807, 654);
            this.pnlContainer.TabIndex = 9;
            // 
            // pnlTrainAndTesting
            // 
            this.pnlTrainAndTesting.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTrainAndTesting.Controls.Add(this.txtTrainingandTesting);
            this.pnlTrainAndTesting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTrainAndTesting.Location = new System.Drawing.Point(0, 0);
            this.pnlTrainAndTesting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTrainAndTesting.Name = "pnlTrainAndTesting";
            this.pnlTrainAndTesting.Size = new System.Drawing.Size(807, 654);
            this.pnlTrainAndTesting.TabIndex = 5;
            // 
            // txtTrainingandTesting
            // 
            this.txtTrainingandTesting.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTrainingandTesting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTrainingandTesting.Location = new System.Drawing.Point(0, 0);
            this.txtTrainingandTesting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTrainingandTesting.MaximumSize = new System.Drawing.Size(867, 566);
            this.txtTrainingandTesting.Name = "txtTrainingandTesting";
            this.txtTrainingandTesting.ReadOnly = true;
            this.txtTrainingandTesting.Size = new System.Drawing.Size(807, 566);
            this.txtTrainingandTesting.TabIndex = 0;
            this.txtTrainingandTesting.Text = "";
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.BlueViolet;
            this.btnTest.Enabled = false;
            this.btnTest.FlatAppearance.BorderSize = 0;
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTest.Location = new System.Drawing.Point(231, 599);
            this.btnTest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(172, 71);
            this.btnTest.TabIndex = 5;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // TrainerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1269, 742);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.btnNNTesting);
            this.Controls.Add(this.btnResultInfo);
            this.Controls.Add(this.btnNNTraining);
            this.Controls.Add(this.pnlPicker);
            this.Controls.Add(this.btnAnnInfo);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TrainerForm";
            this.Text = "Trainer";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpTrainingSettings.ResumeLayout(false);
            this.grpTrainingSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTestCount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.grpAnnSettings.ResumeLayout(false);
            this.grpAnnSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbHiddenNeuronCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLearningRate)).EndInit();
            this.pnlResults.ResumeLayout(false);
            this.pnlANNInfo.ResumeLayout(false);
            this.pnlANNInfo.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.pnlContainer.ResumeLayout(false);
            this.pnlTrainAndTesting.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblTestPercent;
        private System.Windows.Forms.Label lblLearningRate;
        private System.Windows.Forms.Label lblHiddenNeuronCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel pnlPicker;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlResults;
        private System.Windows.Forms.RichTextBox richtxtAnnResult;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoadAnn;
        private System.Windows.Forms.Button btnNNTraining;
        private System.Windows.Forms.Button btnNNTesting;
        private System.Windows.Forms.Panel pnlANNInfo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblHiddenShowCount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblOutputCount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblAccuracy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTestingCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTrainingCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblInputCount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSaveANN;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlTrainAndTesting;
        private System.Windows.Forms.RichTextBox txtTrainingandTesting;
        private System.Windows.Forms.Button btnTest;
    }
}