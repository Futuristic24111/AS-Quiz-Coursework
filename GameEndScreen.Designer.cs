namespace Quiz_Coursework
{
    partial class GameEndScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameEndScreen));
            GameOverLbl = new Label();
            backBtn = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            scoreLbl = new Label();
            SuspendLayout();
            // 
            // GameOverLbl
            // 
            GameOverLbl.AutoSize = true;
            GameOverLbl.BackColor = Color.Transparent;
            GameOverLbl.Font = new Font("Rockwell", 36F, FontStyle.Bold, GraphicsUnit.Point);
            GameOverLbl.ForeColor = SystemColors.ButtonHighlight;
            GameOverLbl.Location = new Point(474, 74);
            GameOverLbl.Margin = new Padding(4, 0, 4, 0);
            GameOverLbl.Name = "GameOverLbl";
            GameOverLbl.Size = new Size(783, 131);
            GameOverLbl.TabIndex = 1;
            GameOverLbl.Text = "Game Over!!!";
            // 
            // backBtn
            // 
            backBtn.Font = new Font("Rockwell", 14F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.Location = new Point(561, 575);
            backBtn.Margin = new Padding(4, 5, 4, 5);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(270, 232);
            backBtn.TabIndex = 4;
            backBtn.Text = "Go Back To Quiz";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Rockwell", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(212, 575);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(270, 232);
            button1.TabIndex = 5;
            button1.Text = "Retry";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Rockwell", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(928, 575);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(270, 232);
            button2.TabIndex = 6;
            button2.Text = "Back To Start Screen";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Rockwell", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(1266, 575);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(270, 232);
            button3.TabIndex = 7;
            button3.Text = "Leader Board";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // scoreLbl
            // 
            scoreLbl.AutoSize = true;
            scoreLbl.BackColor = Color.Transparent;
            scoreLbl.Font = new Font("Rockwell", 26F, FontStyle.Bold, GraphicsUnit.Point);
            scoreLbl.ForeColor = SystemColors.ButtonHighlight;
            scoreLbl.Location = new Point(536, 227);
            scoreLbl.Margin = new Padding(4, 0, 4, 0);
            scoreLbl.Name = "scoreLbl";
            scoreLbl.Size = new Size(647, 95);
            scoreLbl.TabIndex = 8;
            scoreLbl.Text = "You Scored: xxx";
            // 
            // GameEndScreen
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.GameBackDrop;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1605, 881);
            Controls.Add(scoreLbl);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(backBtn);
            Controls.Add(GameOverLbl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            Name = "GameEndScreen";
            Text = "GameEndScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label GameOverLbl;
        private Button backBtn;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label scoreLbl;
    }
}