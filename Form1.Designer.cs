﻿namespace Jump
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ObstacleBox = new System.Windows.Forms.PictureBox();
            this.PlayerBox = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.GameOverLabel = new System.Windows.Forms.Label();
            this.Counting = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.ScoreText = new System.Windows.Forms.Label();
            this.TimerCounting = new System.Windows.Forms.Timer(this.components);
            this.NewGameLabel = new System.Windows.Forms.Label();
            this.YourScoreLabel = new System.Windows.Forms.Label();
            this.SpeedLvlText = new System.Windows.Forms.Label();
            this.SpeedLvl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Bot_NR = new System.Windows.Forms.Label();
            this.Gen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ObstacleBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ObstacleBox
            // 
            this.ObstacleBox.BackColor = System.Drawing.Color.Transparent;
            this.ObstacleBox.Image = global::Jump.Properties.Resources.explosion;
            this.ObstacleBox.Location = new System.Drawing.Point(816, 188);
            this.ObstacleBox.Name = "ObstacleBox";
            this.ObstacleBox.Size = new System.Drawing.Size(46, 42);
            this.ObstacleBox.TabIndex = 0;
            this.ObstacleBox.TabStop = false;
            // 
            // PlayerBox
            // 
            this.PlayerBox.BackColor = System.Drawing.Color.Transparent;
            this.PlayerBox.ErrorImage = null;
            this.PlayerBox.Image = global::Jump.Properties.Resources.startgame;
            this.PlayerBox.Location = new System.Drawing.Point(70, 138);
            this.PlayerBox.Name = "PlayerBox";
            this.PlayerBox.Size = new System.Drawing.Size(49, 100);
            this.PlayerBox.TabIndex = 1;
            this.PlayerBox.TabStop = false;
            // 
            // GameOverLabel
            // 
            this.GameOverLabel.BackColor = System.Drawing.Color.Transparent;
            this.GameOverLabel.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold);
            this.GameOverLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.GameOverLabel.Location = new System.Drawing.Point(239, 20);
            this.GameOverLabel.Name = "GameOverLabel";
            this.GameOverLabel.Size = new System.Drawing.Size(348, 77);
            this.GameOverLabel.TabIndex = 2;
            this.GameOverLabel.Text = "GAME OVER";
            // 
            // Counting
            // 
            this.Counting.BackColor = System.Drawing.Color.Transparent;
            this.Counting.Font = new System.Drawing.Font("Segoe Print", 72F);
            this.Counting.ForeColor = System.Drawing.Color.OrangeRed;
            this.Counting.Location = new System.Drawing.Point(285, 20);
            this.Counting.Name = "Counting";
            this.Counting.Size = new System.Drawing.Size(458, 142);
            this.Counting.TabIndex = 4;
            this.Counting.Text = "3";
            // 
            // Score
            // 
            this.Score.BackColor = System.Drawing.Color.Transparent;
            this.Score.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Score.ForeColor = System.Drawing.Color.Yellow;
            this.Score.Location = new System.Drawing.Point(708, 38);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(58, 38);
            this.Score.TabIndex = 5;
            this.Score.Text = "0";
            // 
            // ScoreText
            // 
            this.ScoreText.BackColor = System.Drawing.Color.Transparent;
            this.ScoreText.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ScoreText.ForeColor = System.Drawing.Color.Yellow;
            this.ScoreText.Location = new System.Drawing.Point(632, 38);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(82, 38);
            this.ScoreText.TabIndex = 6;
            this.ScoreText.Text = "Score:";
            // 
            // NewGameLabel
            // 
            this.NewGameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NewGameLabel.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGameLabel.ForeColor = System.Drawing.Color.Yellow;
            this.NewGameLabel.Location = new System.Drawing.Point(307, 117);
            this.NewGameLabel.Name = "NewGameLabel";
            this.NewGameLabel.Size = new System.Drawing.Size(226, 51);
            this.NewGameLabel.TabIndex = 7;
            this.NewGameLabel.Text = "New Game";
            this.NewGameLabel.Click += new System.EventHandler(this.NewGameLabel_Click);
            // 
            // YourScoreLabel
            // 
            this.YourScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.YourScoreLabel.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.YourScoreLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.YourScoreLabel.Location = new System.Drawing.Point(342, 97);
            this.YourScoreLabel.Name = "YourScoreLabel";
            this.YourScoreLabel.Size = new System.Drawing.Size(201, 31);
            this.YourScoreLabel.TabIndex = 8;
            this.YourScoreLabel.Text = "Your score: ";
            // 
            // SpeedLvlText
            // 
            this.SpeedLvlText.BackColor = System.Drawing.Color.Transparent;
            this.SpeedLvlText.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SpeedLvlText.ForeColor = System.Drawing.Color.Yellow;
            this.SpeedLvlText.Location = new System.Drawing.Point(632, 9);
            this.SpeedLvlText.Name = "SpeedLvlText";
            this.SpeedLvlText.Size = new System.Drawing.Size(120, 29);
            this.SpeedLvlText.TabIndex = 9;
            this.SpeedLvlText.Text = "Speed lvl: ";
            this.SpeedLvlText.Click += new System.EventHandler(this.SpeedLvlText_Click);
            // 
            // SpeedLvl
            // 
            this.SpeedLvl.BackColor = System.Drawing.Color.Transparent;
            this.SpeedLvl.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold);
            this.SpeedLvl.ForeColor = System.Drawing.Color.Yellow;
            this.SpeedLvl.Location = new System.Drawing.Point(742, 9);
            this.SpeedLvl.Name = "SpeedLvl";
            this.SpeedLvl.Size = new System.Drawing.Size(48, 34);
            this.SpeedLvl.TabIndex = 10;
            this.SpeedLvl.Text = "1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(305, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 38);
            this.label1.TabIndex = 11;
            this.label1.Text = "Bot_NR:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(505, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 38);
            this.label2.TabIndex = 12;
            this.label2.Text = "Gen:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Bot_NR
            // 
            this.Bot_NR.BackColor = System.Drawing.Color.Transparent;
            this.Bot_NR.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Bot_NR.ForeColor = System.Drawing.Color.Yellow;
            this.Bot_NR.Location = new System.Drawing.Point(410, 0);
            this.Bot_NR.Name = "Bot_NR";
            this.Bot_NR.Size = new System.Drawing.Size(58, 38);
            this.Bot_NR.TabIndex = 13;
            this.Bot_NR.Text = "0";
            // 
            // Gen
            // 
            this.Gen.BackColor = System.Drawing.Color.Transparent;
            this.Gen.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Gen.ForeColor = System.Drawing.Color.Yellow;
            this.Gen.Location = new System.Drawing.Point(568, 0);
            this.Gen.Name = "Gen";
            this.Gen.Size = new System.Drawing.Size(58, 38);
            this.Gen.TabIndex = 14;
            this.Gen.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 308);
            this.Controls.Add(this.Gen);
            this.Controls.Add(this.Bot_NR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SpeedLvl);
            this.Controls.Add(this.SpeedLvlText);
            this.Controls.Add(this.YourScoreLabel);
            this.Controls.Add(this.NewGameLabel);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.GameOverLabel);
            this.Controls.Add(this.PlayerBox);
            this.Controls.Add(this.ObstacleBox);
            this.Controls.Add(this.Counting);
            this.MaximumSize = new System.Drawing.Size(816, 346);
            this.MinimumSize = new System.Drawing.Size(816, 346);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ObstacleBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ObstacleBox;
        private System.Windows.Forms.PictureBox PlayerBox;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label GameOverLabel;
        private System.Windows.Forms.Label Counting;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.Timer TimerCounting;
        private System.Windows.Forms.Label NewGameLabel;
        private System.Windows.Forms.Label YourScoreLabel;
        private System.Windows.Forms.Label SpeedLvlText;
        private System.Windows.Forms.Label SpeedLvl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Bot_NR;
        private System.Windows.Forms.Label Gen;
    }
}

