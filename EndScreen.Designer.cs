namespace Quiz_Coursework
{
    partial class EndScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.leaderboardBtn = new System.Windows.Forms.Button();
            this.gameBtn = new System.Windows.Forms.Button();
            this.restartBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.scoreLbl = new System.Windows.Forms.Label();
            this.gameWarning = new System.Windows.Forms.ListBox();
            this.timerLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(380, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "The End";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(178, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(624, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hope you enjoyed my quiz, and that your guitar knowledge has been";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(356, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "broadened successfully :)";
            // 
            // leaderboardBtn
            // 
            this.leaderboardBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.leaderboardBtn.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.leaderboardBtn.Location = new System.Drawing.Point(321, 201);
            this.leaderboardBtn.Name = "leaderboardBtn";
            this.leaderboardBtn.Size = new System.Drawing.Size(107, 80);
            this.leaderboardBtn.TabIndex = 3;
            this.leaderboardBtn.Text = "Leaderboard";
            this.leaderboardBtn.UseVisualStyleBackColor = false;
            this.leaderboardBtn.Click += new System.EventHandler(this.leaderboardBtn_Click);
            // 
            // gameBtn
            // 
            this.gameBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gameBtn.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameBtn.Location = new System.Drawing.Point(496, 201);
            this.gameBtn.Name = "gameBtn";
            this.gameBtn.Size = new System.Drawing.Size(107, 80);
            this.gameBtn.TabIndex = 4;
            this.gameBtn.Text = "Game";
            this.gameBtn.UseVisualStyleBackColor = false;
            this.gameBtn.Click += new System.EventHandler(this.gameBtn_Click);
            // 
            // restartBtn
            // 
            this.restartBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.restartBtn.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.restartBtn.Location = new System.Drawing.Point(321, 307);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(107, 80);
            this.restartBtn.TabIndex = 5;
            this.restartBtn.Text = "Return To StartScreen";
            this.restartBtn.UseVisualStyleBackColor = false;
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
            // 
            // quitBtn
            // 
            this.quitBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.quitBtn.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quitBtn.Location = new System.Drawing.Point(496, 307);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(107, 80);
            this.quitBtn.TabIndex = 6;
            this.quitBtn.Text = "Quit";
            this.quitBtn.UseVisualStyleBackColor = false;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.BackColor = System.Drawing.Color.Transparent;
            this.scoreLbl.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scoreLbl.Location = new System.Drawing.Point(380, 141);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(179, 23);
            this.scoreLbl.TabIndex = 7;
            this.scoreLbl.Text = "You scored: Score";
            // 
            // gameWarning
            // 
            this.gameWarning.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameWarning.FormattingEnabled = true;
            this.gameWarning.ItemHeight = 14;
            this.gameWarning.Location = new System.Drawing.Point(624, 203);
            this.gameWarning.Margin = new System.Windows.Forms.Padding(2);
            this.gameWarning.Name = "gameWarning";
            this.gameWarning.Size = new System.Drawing.Size(127, 74);
            this.gameWarning.TabIndex = 8;
            // 
            // timerLbl
            // 
            this.timerLbl.AutoSize = true;
            this.timerLbl.BackColor = System.Drawing.Color.Transparent;
            this.timerLbl.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timerLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timerLbl.Location = new System.Drawing.Point(343, 166);
            this.timerLbl.Name = "timerLbl";
            this.timerLbl.Size = new System.Drawing.Size(174, 23);
            this.timerLbl.TabIndex = 9;
            this.timerLbl.Text = "Time taken: xxxx";
            // 
            // EndScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quiz_Coursework.Properties.Resources.Music_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 425);
            this.Controls.Add(this.timerLbl);
            this.Controls.Add(this.gameWarning);
            this.Controls.Add(this.scoreLbl);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.restartBtn);
            this.Controls.Add(this.gameBtn);
            this.Controls.Add(this.leaderboardBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EndScreen";
            this.Text = "EndScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button leaderboardBtn;
        private Button gameBtn;
        private Button restartBtn;
        private Button quitBtn;
        private Label scoreLbl;
        private ListBox gameWarning;
        private Label timerLbl;
    }
}