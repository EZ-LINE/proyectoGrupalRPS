namespace Forms
{
    partial class RPS_3Form
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
            this.txtCongratulations = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPreviousPlayer = new System.Windows.Forms.Button();
            this.btnNextPlayer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtScore = new System.Windows.Forms.Label();
            this.txtDraw = new System.Windows.Forms.Label();
            this.txtLoss = new System.Windows.Forms.Label();
            this.txtWin = new System.Windows.Forms.Label();
            this.playerDraw = new System.Windows.Forms.Label();
            this.totalScore = new System.Windows.Forms.Label();
            this.playerLoss = new System.Windows.Forms.Label();
            this.playerVictories = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.Label();
            this.playerCounter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCongratulations
            // 
            this.txtCongratulations.AutoSize = true;
            this.txtCongratulations.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCongratulations.Location = new System.Drawing.Point(63, 43);
            this.txtCongratulations.Name = "txtCongratulations";
            this.txtCongratulations.Size = new System.Drawing.Size(206, 32);
            this.txtCongratulations.TabIndex = 0;
            this.txtCongratulations.Text = "GAME: COMPLETE";
            this.txtCongratulations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtCongratulations.Click += new System.EventHandler(this.GameCompleteText);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Forms.Properties.Resources.fire;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 392);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnPreviousPlayer
            // 
            this.btnPreviousPlayer.Location = new System.Drawing.Point(590, 52);
            this.btnPreviousPlayer.Name = "btnPreviousPlayer";
            this.btnPreviousPlayer.Size = new System.Drawing.Size(75, 23);
            this.btnPreviousPlayer.TabIndex = 3;
            this.btnPreviousPlayer.Text = "Previous";
            this.btnPreviousPlayer.UseVisualStyleBackColor = true;
            this.btnPreviousPlayer.Click += new System.EventHandler(this.btnPreviousPlayer_Click);
            // 
            // btnNextPlayer
            // 
            this.btnNextPlayer.Location = new System.Drawing.Point(671, 52);
            this.btnNextPlayer.Name = "btnNextPlayer";
            this.btnNextPlayer.Size = new System.Drawing.Size(75, 23);
            this.btnNextPlayer.TabIndex = 4;
            this.btnNextPlayer.Text = "Next";
            this.btnNextPlayer.UseVisualStyleBackColor = true;
            this.btnNextPlayer.Click += new System.EventHandler(this.btnNextPlayer_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtScore);
            this.panel1.Controls.Add(this.txtDraw);
            this.panel1.Controls.Add(this.txtLoss);
            this.panel1.Controls.Add(this.txtWin);
            this.panel1.Controls.Add(this.playerDraw);
            this.panel1.Controls.Add(this.totalScore);
            this.panel1.Controls.Add(this.playerLoss);
            this.panel1.Controls.Add(this.playerVictories);
            this.panel1.Controls.Add(this.playerLabel);
            this.panel1.Controls.Add(this.txtPlayerName);
            this.panel1.Location = new System.Drawing.Point(63, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 285);
            this.panel1.TabIndex = 5;
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtScore.Location = new System.Drawing.Point(149, 210);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(24, 30);
            this.txtScore.TabIndex = 10;
            this.txtScore.Text = "0";
            this.txtScore.Visible = false;
            // 
            // txtDraw
            // 
            this.txtDraw.AutoSize = true;
            this.txtDraw.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDraw.Location = new System.Drawing.Point(149, 167);
            this.txtDraw.Name = "txtDraw";
            this.txtDraw.Size = new System.Drawing.Size(24, 30);
            this.txtDraw.TabIndex = 9;
            this.txtDraw.Text = "0";
            this.txtDraw.Visible = false;
            // 
            // txtLoss
            // 
            this.txtLoss.AutoSize = true;
            this.txtLoss.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLoss.Location = new System.Drawing.Point(149, 127);
            this.txtLoss.Name = "txtLoss";
            this.txtLoss.Size = new System.Drawing.Size(24, 30);
            this.txtLoss.TabIndex = 8;
            this.txtLoss.Text = "0";
            this.txtLoss.Visible = false;
            // 
            // txtWin
            // 
            this.txtWin.AutoSize = true;
            this.txtWin.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtWin.Location = new System.Drawing.Point(149, 84);
            this.txtWin.Name = "txtWin";
            this.txtWin.Size = new System.Drawing.Size(24, 30);
            this.txtWin.TabIndex = 6;
            this.txtWin.Text = "0";
            this.txtWin.Visible = false;
            // 
            // playerDraw
            // 
            this.playerDraw.AutoSize = true;
            this.playerDraw.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playerDraw.Location = new System.Drawing.Point(17, 167);
            this.playerDraw.Name = "playerDraw";
            this.playerDraw.Size = new System.Drawing.Size(70, 30);
            this.playerDraw.TabIndex = 5;
            this.playerDraw.Text = "Draws";
            // 
            // totalScore
            // 
            this.totalScore.AutoSize = true;
            this.totalScore.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalScore.Location = new System.Drawing.Point(20, 210);
            this.totalScore.Name = "totalScore";
            this.totalScore.Size = new System.Drawing.Size(114, 30);
            this.totalScore.TabIndex = 4;
            this.totalScore.Text = "Total Score";
            // 
            // playerLoss
            // 
            this.playerLoss.AutoSize = true;
            this.playerLoss.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playerLoss.Location = new System.Drawing.Point(17, 127);
            this.playerLoss.Name = "playerLoss";
            this.playerLoss.Size = new System.Drawing.Size(84, 30);
            this.playerLoss.TabIndex = 3;
            this.playerLoss.Text = "Defeats";
            // 
            // playerVictories
            // 
            this.playerVictories.AutoSize = true;
            this.playerVictories.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playerVictories.Location = new System.Drawing.Point(17, 84);
            this.playerVictories.Name = "playerVictories";
            this.playerVictories.Size = new System.Drawing.Size(132, 30);
            this.playerVictories.TabIndex = 2;
            this.playerVictories.Text = "Obliterations";
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playerLabel.Location = new System.Drawing.Point(17, 16);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(126, 45);
            this.playerLabel.TabIndex = 1;
            this.playerLabel.Text = "PLAYER";
            this.playerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.AutoSize = true;
            this.txtPlayerName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPlayerName.Location = new System.Drawing.Point(149, 28);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(123, 30);
            this.txtPlayerName.TabIndex = 0;
            this.txtPlayerName.Text = "GERTRUCIO";
            // 
            // playerCounter
            // 
            this.playerCounter.AutoSize = true;
            this.playerCounter.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playerCounter.Location = new System.Drawing.Point(549, 52);
            this.playerCounter.Name = "playerCounter";
            this.playerCounter.Size = new System.Drawing.Size(35, 23);
            this.playerCounter.TabIndex = 2;
            this.playerCounter.Text = "0/0";
            // 
            // RPS_3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 416);
            this.Controls.Add(this.playerCounter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNextPlayer);
            this.Controls.Add(this.btnPreviousPlayer);
            this.Controls.Add(this.txtCongratulations);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RPS_3Form";
            this.Text = "RPS_3Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label txtCongratulations;
        private PictureBox pictureBox1;
        private Button btnPreviousPlayer;
        private Button btnNextPlayer;
        private Panel panel1;
        private Label playerLabel;
        private Label txtPlayerName;
        private Label playerCounter;
        private Label playerVictories;
        private Label txtScore;
        private Label txtDraw;
        private Label txtLoss;
        private Label txtWin;
        private Label playerDraw;
        private Label totalScore;
        private Label playerLoss;
    }
}