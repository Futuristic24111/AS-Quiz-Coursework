namespace Quiz_Coursework
{
    partial class GameStartScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameStartScreen));
            this.WelcomeLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playBtn = new System.Windows.Forms.Button();
            this.LeaderboardBtn = new System.Windows.Forms.Button();
            this.returnBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeLbl
            // 
            this.WelcomeLbl.AutoSize = true;
            this.WelcomeLbl.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLbl.Font = new System.Drawing.Font("Rockwell", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WelcomeLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WelcomeLbl.Location = new System.Drawing.Point(24, 44);
            this.WelcomeLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.WelcomeLbl.Name = "WelcomeLbl";
            this.WelcomeLbl.Size = new System.Drawing.Size(704, 43);
            this.WelcomeLbl.TabIndex = 0;
            this.WelcomeLbl.Text = "Hello player, and welcome to Jet Wars!!!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(14, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(703, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "You completed the quiz but are you able";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(130, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(547, 43);
            this.label2.TabIndex = 2;
            this.label2.Text = "to take on some plane combat?";
            // 
            // playBtn
            // 
            this.playBtn.Location = new System.Drawing.Point(106, 253);
            this.playBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(150, 128);
            this.playBtn.TabIndex = 3;
            this.playBtn.Text = "Join the fight";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // LeaderboardBtn
            // 
            this.LeaderboardBtn.Location = new System.Drawing.Point(327, 253);
            this.LeaderboardBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.LeaderboardBtn.Name = "LeaderboardBtn";
            this.LeaderboardBtn.Size = new System.Drawing.Size(150, 128);
            this.LeaderboardBtn.TabIndex = 4;
            this.LeaderboardBtn.Text = "See Previous Scores";
            this.LeaderboardBtn.UseVisualStyleBackColor = true;
            this.LeaderboardBtn.Click += new System.EventHandler(this.LeaderboardBtn_Click);
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(540, 253);
            this.returnBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(150, 128);
            this.returnBtn.TabIndex = 5;
            this.returnBtn.Text = "Return To The End Screen";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // GameStartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quiz_Coursework.Properties.Resources.GameBackDrop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(788, 430);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.LeaderboardBtn);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WelcomeLbl);
            this.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "GameStartScreen";
            this.Text = "GameStartScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label WelcomeLbl;
        private Label label1;
        private Label label2;
        private Button playBtn;
        private Button LeaderboardBtn;
        private Button returnBtn;
    }
}