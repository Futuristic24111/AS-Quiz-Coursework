namespace Quiz_Coursework
{
    partial class LeaderboardScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaderboardScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.thirdLbl = new System.Windows.Forms.Label();
            this.firstLbl = new System.Windows.Forms.Label();
            this.secondLbl = new System.Windows.Forms.Label();
            this.playerLstBox = new System.Windows.Forms.ListBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(336, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "The Leaderboard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(426, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "The Podium";
            // 
            // thirdLbl
            // 
            this.thirdLbl.AutoSize = true;
            this.thirdLbl.BackColor = System.Drawing.Color.Transparent;
            this.thirdLbl.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.thirdLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.thirdLbl.Location = new System.Drawing.Point(531, 140);
            this.thirdLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.thirdLbl.Name = "thirdLbl";
            this.thirdLbl.Size = new System.Drawing.Size(59, 14);
            this.thirdLbl.TabIndex = 2;
            this.thirdLbl.Text = "3rd Place";
            // 
            // firstLbl
            // 
            this.firstLbl.AutoSize = true;
            this.firstLbl.BackColor = System.Drawing.Color.Transparent;
            this.firstLbl.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.firstLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.firstLbl.Location = new System.Drawing.Point(451, 96);
            this.firstLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstLbl.Name = "firstLbl";
            this.firstLbl.Size = new System.Drawing.Size(60, 14);
            this.firstLbl.TabIndex = 3;
            this.firstLbl.Text = "1st Place";
            // 
            // secondLbl
            // 
            this.secondLbl.AutoSize = true;
            this.secondLbl.BackColor = System.Drawing.Color.Transparent;
            this.secondLbl.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.secondLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.secondLbl.Location = new System.Drawing.Point(374, 140);
            this.secondLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.secondLbl.Name = "secondLbl";
            this.secondLbl.Size = new System.Drawing.Size(61, 14);
            this.secondLbl.TabIndex = 4;
            this.secondLbl.Text = "2nd Place";
            // 
            // playerLstBox
            // 
            this.playerLstBox.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playerLstBox.FormattingEnabled = true;
            this.playerLstBox.ItemHeight = 14;
            this.playerLstBox.Location = new System.Drawing.Point(363, 242);
            this.playerLstBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.playerLstBox.Name = "playerLstBox";
            this.playerLstBox.Size = new System.Drawing.Size(272, 144);
            this.playerLstBox.TabIndex = 5;
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backBtn.Location = new System.Drawing.Point(722, 365);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(58, 44);
            this.backBtn.TabIndex = 6;
            this.backBtn.Text = "--->";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Quiz_Coursework.Properties.Resources.Podium;
            this.pictureBox1.Location = new System.Drawing.Point(374, 96);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // LeaderboardScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quiz_Coursework.Properties.Resources.Music_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(788, 430);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.playerLstBox);
            this.Controls.Add(this.secondLbl);
            this.Controls.Add(this.firstLbl);
            this.Controls.Add(this.thirdLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LeaderboardScreen";
            this.Text = "LeaderboardScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label thirdLbl;
        private Label firstLbl;
        private Label secondLbl;
        private ListBox playerLstBox;
        private Button backBtn;
        private PictureBox pictureBox1;
    }
}