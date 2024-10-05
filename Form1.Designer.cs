namespace Rock_Paper_Scissor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnRock = new Button();
            btnPaper = new Button();
            btnScissors = new Button();
            btnReset = new Button();
            PicPlayer = new PictureBox();
            picCPU = new PictureBox();
            txtPlayer = new Label();
            txtCPU = new Label();
            txtScore = new Label();
            txtTimer = new Label();
            txtRound = new Label();
            CountDown = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)PicPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCPU).BeginInit();
            SuspendLayout();
            // 
            // btnRock
            // 
            btnRock.Location = new Point(12, 69);
            btnRock.Name = "btnRock";
            btnRock.Size = new Size(122, 41);
            btnRock.TabIndex = 0;
            btnRock.Text = "Rock";
            btnRock.UseVisualStyleBackColor = true;
            btnRock.Click += btnRock_Click;
            // 
            // btnPaper
            // 
            btnPaper.Location = new Point(12, 149);
            btnPaper.Name = "btnPaper";
            btnPaper.Size = new Size(122, 41);
            btnPaper.TabIndex = 1;
            btnPaper.Text = "Paper";
            btnPaper.UseVisualStyleBackColor = true;
            btnPaper.Click += btnPaper_Click;
            // 
            // btnScissors
            // 
            btnScissors.Location = new Point(12, 226);
            btnScissors.Name = "btnScissors";
            btnScissors.Size = new Size(122, 41);
            btnScissors.TabIndex = 2;
            btnScissors.Text = "Scissors";
            btnScissors.UseVisualStyleBackColor = true;
            btnScissors.Click += btnScissors_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(649, 397);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(122, 41);
            btnReset.TabIndex = 3;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // PicPlayer
            // 
            PicPlayer.Image = Properties.Resources.qq;
            PicPlayer.Location = new Point(168, 92);
            PicPlayer.Name = "PicPlayer";
            PicPlayer.Size = new Size(167, 160);
            PicPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
            PicPlayer.TabIndex = 4;
            PicPlayer.TabStop = false;
            // 
            // picCPU
            // 
            picCPU.Image = Properties.Resources.qq;
            picCPU.Location = new Point(574, 92);
            picCPU.Name = "picCPU";
            picCPU.Size = new Size(167, 160);
            picCPU.SizeMode = PictureBoxSizeMode.StretchImage;
            picCPU.TabIndex = 4;
            picCPU.TabStop = false;
            // 
            // txtPlayer
            // 
            txtPlayer.AutoSize = true;
            txtPlayer.Location = new Point(212, 64);
            txtPlayer.Name = "txtPlayer";
            txtPlayer.Size = new Size(59, 25);
            txtPlayer.TabIndex = 5;
            txtPlayer.Text = "Player";
            // 
            // txtCPU
            // 
            txtCPU.AutoSize = true;
            txtCPU.Location = new Point(631, 64);
            txtCPU.Name = "txtCPU";
            txtCPU.Size = new Size(45, 25);
            txtCPU.TabIndex = 5;
            txtCPU.Text = "CPU";
            // 
            // txtScore
            // 
            txtScore.AutoSize = true;
            txtScore.BackColor = Color.Linen;
            txtScore.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtScore.Location = new Point(337, 92);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(231, 32);
            txtScore.TabIndex = 5;
            txtScore.Text = "Player: 0      CPU: 0";
            txtScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTimer
            // 
            txtTimer.AutoSize = true;
            txtTimer.BackColor = Color.Linen;
            txtTimer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtTimer.Location = new Point(427, 151);
            txtTimer.Name = "txtTimer";
            txtTimer.Size = new Size(28, 32);
            txtTimer.TabIndex = 5;
            txtTimer.Text = "5";
            txtTimer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtRound
            // 
            txtRound.AutoSize = true;
            txtRound.BackColor = Color.Linen;
            txtRound.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtRound.Location = new Point(384, 289);
            txtRound.Name = "txtRound";
            txtRound.Size = new Size(117, 32);
            txtRound.TabIndex = 5;
            txtRound.Text = "Round: 3";
            txtRound.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CountDown
            // 
            CountDown.Interval = 1000;
            CountDown.Tick += CountDownEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ranger_4df6c1b6;
            ClientSize = new Size(800, 450);
            Controls.Add(txtRound);
            Controls.Add(txtTimer);
            Controls.Add(txtScore);
            Controls.Add(txtCPU);
            Controls.Add(txtPlayer);
            Controls.Add(picCPU);
            Controls.Add(PicPlayer);
            Controls.Add(btnReset);
            Controls.Add(btnScissors);
            Controls.Add(btnPaper);
            Controls.Add(btnRock);
            Name = "Form1";
            Text = "Rock Paper Scissor game";
            ((System.ComponentModel.ISupportInitialize)PicPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCPU).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRock;
        private Button btnPaper;
        private Button btnScissors;
        private Button btnReset;
        private PictureBox PicPlayer;
        private PictureBox picCPU;
        private Label txtPlayer;
        private Label txtCPU;
        private Label txtScore;
        private Label txtTimer;
        private Label txtRound;
        private System.Windows.Forms.Timer CountDown;
    }
}