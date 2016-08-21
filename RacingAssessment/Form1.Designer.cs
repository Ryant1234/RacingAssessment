namespace RacingAssessment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rbGroup = new System.Windows.Forms.GroupBox();
            this.lblMaxBet = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBob = new System.Windows.Forms.Label();
            this.lblJohnson = new System.Windows.Forms.Label();
            this.lblJonesy = new System.Windows.Forms.Label();
            this.inputCarNumber = new System.Windows.Forms.NumericUpDown();
            this.inputBetAmount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbPunter2 = new System.Windows.Forms.RadioButton();
            this.rbPunter1 = new System.Windows.Forms.RadioButton();
            this.rbPunter0 = new System.Windows.Forms.RadioButton();
            this.btnPlaceBet = new System.Windows.Forms.Button();
            this.imgRacingTrack = new System.Windows.Forms.PictureBox();
            this.imgCar1 = new System.Windows.Forms.PictureBox();
            this.imgCar4 = new System.Windows.Forms.PictureBox();
            this.imgCar3 = new System.Windows.Forms.PictureBox();
            this.imgCar2 = new System.Windows.Forms.PictureBox();
            this.imgFinishLine = new System.Windows.Forms.PictureBox();
            this.imgStartLine = new System.Windows.Forms.PictureBox();
            this.btnRace = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.rbGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputCarNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputBetAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRacingTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFinishLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStartLine)).BeginInit();
            this.SuspendLayout();
            // 
            // rbGroup
            // 
            this.rbGroup.Controls.Add(this.lblMaxBet);
            this.rbGroup.Controls.Add(this.label1);
            this.rbGroup.Controls.Add(this.lblBob);
            this.rbGroup.Controls.Add(this.lblJohnson);
            this.rbGroup.Controls.Add(this.lblJonesy);
            this.rbGroup.Controls.Add(this.inputCarNumber);
            this.rbGroup.Controls.Add(this.inputBetAmount);
            this.rbGroup.Controls.Add(this.label3);
            this.rbGroup.Controls.Add(this.label2);
            this.rbGroup.Controls.Add(this.rbPunter2);
            this.rbGroup.Controls.Add(this.rbPunter1);
            this.rbGroup.Controls.Add(this.rbPunter0);
            this.rbGroup.Location = new System.Drawing.Point(1, 360);
            this.rbGroup.Name = "rbGroup";
            this.rbGroup.Size = new System.Drawing.Size(733, 112);
            this.rbGroup.TabIndex = 0;
            this.rbGroup.TabStop = false;
            this.rbGroup.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblMaxBet
            // 
            this.lblMaxBet.AutoSize = true;
            this.lblMaxBet.Location = new System.Drawing.Point(172, 59);
            this.lblMaxBet.Name = "lblMaxBet";
            this.lblMaxBet.Size = new System.Drawing.Size(0, 13);
            this.lblMaxBet.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Max Bet";
            // 
            // lblBob
            // 
            this.lblBob.AutoSize = true;
            this.lblBob.Location = new System.Drawing.Point(449, 83);
            this.lblBob.Name = "lblBob";
            this.lblBob.Size = new System.Drawing.Size(0, 13);
            this.lblBob.TabIndex = 19;
            // 
            // lblJohnson
            // 
            this.lblJohnson.AutoSize = true;
            this.lblJohnson.Location = new System.Drawing.Point(449, 60);
            this.lblJohnson.Name = "lblJohnson";
            this.lblJohnson.Size = new System.Drawing.Size(0, 13);
            this.lblJohnson.TabIndex = 18;
            // 
            // lblJonesy
            // 
            this.lblJonesy.AutoSize = true;
            this.lblJonesy.Location = new System.Drawing.Point(449, 37);
            this.lblJonesy.Name = "lblJonesy";
            this.lblJonesy.Size = new System.Drawing.Size(0, 13);
            this.lblJonesy.TabIndex = 17;
            // 
            // inputCarNumber
            // 
            this.inputCarNumber.Location = new System.Drawing.Point(244, 58);
            this.inputCarNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.inputCarNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputCarNumber.Name = "inputCarNumber";
            this.inputCarNumber.Size = new System.Drawing.Size(65, 20);
            this.inputCarNumber.TabIndex = 12;
            this.inputCarNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // inputBetAmount
            // 
            this.inputBetAmount.Location = new System.Drawing.Point(337, 60);
            this.inputBetAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputBetAmount.Name = "inputBetAmount";
            this.inputBetAmount.Size = new System.Drawing.Size(74, 20);
            this.inputBetAmount.TabIndex = 11;
            this.inputBetAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputBetAmount.ValueChanged += new System.EventHandler(this.inputBetAmount_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Car to bet on";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Amount to Bet";
            // 
            // rbPunter2
            // 
            this.rbPunter2.AutoSize = true;
            this.rbPunter2.Location = new System.Drawing.Point(11, 83);
            this.rbPunter2.Name = "rbPunter2";
            this.rbPunter2.Size = new System.Drawing.Size(14, 13);
            this.rbPunter2.TabIndex = 2;
            this.rbPunter2.TabStop = true;
            this.rbPunter2.UseVisualStyleBackColor = true;
            this.rbPunter2.CheckedChanged += new System.EventHandler(this.rbGambler3_CheckedChanged);
            // 
            // rbPunter1
            // 
            this.rbPunter1.AutoSize = true;
            this.rbPunter1.Location = new System.Drawing.Point(11, 60);
            this.rbPunter1.Name = "rbPunter1";
            this.rbPunter1.Size = new System.Drawing.Size(14, 13);
            this.rbPunter1.TabIndex = 1;
            this.rbPunter1.TabStop = true;
            this.rbPunter1.UseVisualStyleBackColor = true;
            this.rbPunter1.CheckedChanged += new System.EventHandler(this.rbGambler2_CheckedChanged);
            // 
            // rbPunter0
            // 
            this.rbPunter0.AutoSize = true;
            this.rbPunter0.Location = new System.Drawing.Point(11, 37);
            this.rbPunter0.Name = "rbPunter0";
            this.rbPunter0.Size = new System.Drawing.Size(14, 13);
            this.rbPunter0.TabIndex = 0;
            this.rbPunter0.TabStop = true;
            this.rbPunter0.UseVisualStyleBackColor = true;
            this.rbPunter0.CheckedChanged += new System.EventHandler(this.rbGambler1_CheckedChanged);
            // 
            // btnPlaceBet
            // 
            this.btnPlaceBet.Location = new System.Drawing.Point(12, 478);
            this.btnPlaceBet.Name = "btnPlaceBet";
            this.btnPlaceBet.Size = new System.Drawing.Size(124, 43);
            this.btnPlaceBet.TabIndex = 1;
            this.btnPlaceBet.Text = "Place Bet";
            this.btnPlaceBet.UseVisualStyleBackColor = true;
            this.btnPlaceBet.Click += new System.EventHandler(this.btnPlaceBet_Click);
            // 
            // imgRacingTrack
            // 
            this.imgRacingTrack.Image = ((System.Drawing.Image)(resources.GetObject("imgRacingTrack.Image")));
            this.imgRacingTrack.Location = new System.Drawing.Point(1, 1);
            this.imgRacingTrack.Name = "imgRacingTrack";
            this.imgRacingTrack.Size = new System.Drawing.Size(1108, 366);
            this.imgRacingTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgRacingTrack.TabIndex = 15;
            this.imgRacingTrack.TabStop = false;
            // 
            // imgCar1
            // 
            this.imgCar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgCar1.Image = ((System.Drawing.Image)(resources.GetObject("imgCar1.Image")));
            this.imgCar1.Location = new System.Drawing.Point(1, 41);
            this.imgCar1.Name = "imgCar1";
            this.imgCar1.Size = new System.Drawing.Size(100, 50);
            this.imgCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCar1.TabIndex = 16;
            this.imgCar1.TabStop = false;
            // 
            // imgCar4
            // 
            this.imgCar4.Image = ((System.Drawing.Image)(resources.GetObject("imgCar4.Image")));
            this.imgCar4.Location = new System.Drawing.Point(1, 279);
            this.imgCar4.Name = "imgCar4";
            this.imgCar4.Size = new System.Drawing.Size(100, 50);
            this.imgCar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCar4.TabIndex = 17;
            this.imgCar4.TabStop = false;
            // 
            // imgCar3
            // 
            this.imgCar3.Image = ((System.Drawing.Image)(resources.GetObject("imgCar3.Image")));
            this.imgCar3.Location = new System.Drawing.Point(1, 207);
            this.imgCar3.Name = "imgCar3";
            this.imgCar3.Size = new System.Drawing.Size(100, 50);
            this.imgCar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCar3.TabIndex = 18;
            this.imgCar3.TabStop = false;
            // 
            // imgCar2
            // 
            this.imgCar2.Image = ((System.Drawing.Image)(resources.GetObject("imgCar2.Image")));
            this.imgCar2.Location = new System.Drawing.Point(1, 109);
            this.imgCar2.Name = "imgCar2";
            this.imgCar2.Size = new System.Drawing.Size(100, 50);
            this.imgCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCar2.TabIndex = 19;
            this.imgCar2.TabStop = false;
            // 
            // imgFinishLine
            // 
            this.imgFinishLine.Image = ((System.Drawing.Image)(resources.GetObject("imgFinishLine.Image")));
            this.imgFinishLine.Location = new System.Drawing.Point(1065, 22);
            this.imgFinishLine.Name = "imgFinishLine";
            this.imgFinishLine.Size = new System.Drawing.Size(44, 324);
            this.imgFinishLine.TabIndex = 20;
            this.imgFinishLine.TabStop = false;
            // 
            // imgStartLine
            // 
            this.imgStartLine.Image = ((System.Drawing.Image)(resources.GetObject("imgStartLine.Image")));
            this.imgStartLine.Location = new System.Drawing.Point(57, 22);
            this.imgStartLine.Name = "imgStartLine";
            this.imgStartLine.Size = new System.Drawing.Size(44, 324);
            this.imgStartLine.TabIndex = 21;
            this.imgStartLine.TabStop = false;
            // 
            // btnRace
            // 
            this.btnRace.Location = new System.Drawing.Point(973, 483);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(124, 43);
            this.btnRace.TabIndex = 14;
            this.btnRace.Text = "Race";
            this.btnRace.UseVisualStyleBackColor = true;
            this.btnRace.Click += new System.EventHandler(this.btnRace_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(832, 483);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(124, 43);
            this.btnReset.TabIndex = 22;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 538);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.imgCar4);
            this.Controls.Add(this.imgCar3);
            this.Controls.Add(this.imgCar2);
            this.Controls.Add(this.imgCar1);
            this.Controls.Add(this.imgStartLine);
            this.Controls.Add(this.imgFinishLine);
            this.Controls.Add(this.imgRacingTrack);
            this.Controls.Add(this.btnRace);
            this.Controls.Add(this.btnPlaceBet);
            this.Controls.Add(this.rbGroup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.rbGroup.ResumeLayout(false);
            this.rbGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputCarNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputBetAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRacingTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFinishLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStartLine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox rbGroup;
        private System.Windows.Forms.NumericUpDown inputBetAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.RadioButton rbPunter2;
        public System.Windows.Forms.RadioButton rbPunter1;
        public System.Windows.Forms.RadioButton rbPunter0;
        private System.Windows.Forms.Button btnPlaceBet;
        private System.Windows.Forms.PictureBox imgRacingTrack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox imgFinishLine;
        private System.Windows.Forms.PictureBox imgStartLine;
        public System.Windows.Forms.PictureBox imgCar1;
        public System.Windows.Forms.PictureBox imgCar4;
        public System.Windows.Forms.PictureBox imgCar3;
        public System.Windows.Forms.PictureBox imgCar2;
        public System.Windows.Forms.NumericUpDown inputCarNumber;
        public System.Windows.Forms.Label lblBob;
        public System.Windows.Forms.Label lblJohnson;
        public System.Windows.Forms.Label lblJonesy;
        private System.Windows.Forms.Label lblMaxBet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRace;
        private System.Windows.Forms.Button btnReset;
    }
}

