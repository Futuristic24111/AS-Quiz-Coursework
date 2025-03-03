namespace Quiz_Coursework
{
    partial class GameScreen
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            enemy1 = new PictureBox();
            enemy3 = new PictureBox();
            enemy2 = new PictureBox();
            player = new PictureBox();
            bullet = new PictureBox();
            scoreText = new Label();
            playTimer = new System.Windows.Forms.Timer(components);
            menuStrip1 = new MenuStrip();
            returnToMenuToolStripMenuItem = new ToolStripMenuItem();
            returnToMenuToolStripMenuItem1 = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            exitApplicationToolStripMenuItem = new ToolStripMenuItem();
            menuOptionsToolStripMenuItem = new ToolStripMenuItem();
            pausePlayToolStripMenuItem = new ToolStripMenuItem();
            restartToolStripMenuItem = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            bad1 = new System.Windows.Forms.Timer(components);
            bad2 = new System.Windows.Forms.Timer(components);
            bad3 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)enemy1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bullet).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // enemy1
            // 
            enemy1.BackColor = Color.Transparent;
            enemy1.Image = Properties.Resources.Enemy;
            enemy1.Location = new Point(85, 101);
            enemy1.Name = "enemy1";
            enemy1.Size = new Size(102, 90);
            enemy1.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy1.TabIndex = 0;
            enemy1.TabStop = false;
            // 
            // enemy3
            // 
            enemy3.BackColor = Color.Transparent;
            enemy3.Image = Properties.Resources.Enemy;
            enemy3.Location = new Point(607, 101);
            enemy3.Name = "enemy3";
            enemy3.Size = new Size(102, 90);
            enemy3.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy3.TabIndex = 1;
            enemy3.TabStop = false;
            // 
            // enemy2
            // 
            enemy2.BackColor = Color.Transparent;
            enemy2.Image = Properties.Resources.Enemy;
            enemy2.Location = new Point(349, 101);
            enemy2.Name = "enemy2";
            enemy2.Size = new Size(102, 90);
            enemy2.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy2.TabIndex = 2;
            enemy2.TabStop = false;
            // 
            // player
            // 
            player.BackColor = Color.Transparent;
            player.Image = Properties.Resources.Player;
            player.Location = new Point(349, 695);
            player.Name = "player";
            player.Size = new Size(111, 97);
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            player.TabIndex = 3;
            player.TabStop = false;
            // 
            // bullet
            // 
            bullet.Image = Properties.Resources.Bullet;
            bullet.Location = new Point(398, 584);
            bullet.Name = "bullet";
            bullet.Size = new Size(7, 27);
            bullet.SizeMode = PictureBoxSizeMode.StretchImage;
            bullet.TabIndex = 4;
            bullet.TabStop = false;
            // 
            // scoreText
            // 
            scoreText.AutoSize = true;
            scoreText.Font = new Font("Rockwell", 72F, FontStyle.Bold, GraphicsUnit.Point);
            scoreText.ForeColor = Color.White;
            scoreText.Location = new Point(348, 292);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(103, 117);
            scoreText.TabIndex = 5;
            scoreText.Text = "0";
            // 
            // playTimer
            // 
            playTimer.Enabled = true;
            playTimer.Interval = 10;
            playTimer.Tick += playTimer_Tick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(36, 36);
            menuStrip1.Items.AddRange(new ToolStripItem[] { returnToMenuToolStripMenuItem, menuOptionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(804, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // returnToMenuToolStripMenuItem
            // 
            returnToMenuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { returnToMenuToolStripMenuItem1, logOutToolStripMenuItem, exitApplicationToolStripMenuItem });
            returnToMenuToolStripMenuItem.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point);
            returnToMenuToolStripMenuItem.Name = "returnToMenuToolStripMenuItem";
            returnToMenuToolStripMenuItem.Size = new Size(45, 20);
            returnToMenuToolStripMenuItem.Text = "Quit";
            // 
            // returnToMenuToolStripMenuItem1
            // 
            returnToMenuToolStripMenuItem1.Name = "returnToMenuToolStripMenuItem1";
            returnToMenuToolStripMenuItem1.Size = new Size(172, 22);
            returnToMenuToolStripMenuItem1.Text = "Return To Menu";
            returnToMenuToolStripMenuItem1.Click += returnToMenuToolStripMenuItem1_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(172, 22);
            logOutToolStripMenuItem.Text = "Log Out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // exitApplicationToolStripMenuItem
            // 
            exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            exitApplicationToolStripMenuItem.Size = new Size(172, 22);
            exitApplicationToolStripMenuItem.Text = "Exit Application";
            exitApplicationToolStripMenuItem.Click += exitApplicationToolStripMenuItem_Click;
            // 
            // menuOptionsToolStripMenuItem
            // 
            menuOptionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pausePlayToolStripMenuItem, restartToolStripMenuItem });
            menuOptionsToolStripMenuItem.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point);
            menuOptionsToolStripMenuItem.Name = "menuOptionsToolStripMenuItem";
            menuOptionsToolStripMenuItem.Size = new Size(105, 20);
            menuOptionsToolStripMenuItem.Text = "Menu Options";
            // 
            // pausePlayToolStripMenuItem
            // 
            pausePlayToolStripMenuItem.Name = "pausePlayToolStripMenuItem";
            pausePlayToolStripMenuItem.Size = new Size(142, 22);
            pausePlayToolStripMenuItem.Text = "Pause/Play";
            pausePlayToolStripMenuItem.Click += pausePlayToolStripMenuItem_Click;
            // 
            // restartToolStripMenuItem
            // 
            restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            restartToolStripMenuItem.Size = new Size(142, 22);
            restartToolStripMenuItem.Text = "Restart";
            restartToolStripMenuItem.Click += restartToolStripMenuItem_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 10;
            // 
            // timer3
            // 
            timer3.Enabled = true;
            timer3.Interval = 10;
            // 
            // bad1
            // 
            bad1.Interval = 1000;
            bad1.Tick += bad1_Tick;
            // 
            // bad2
            // 
            bad2.Interval = 1000;
            bad2.Tick += bad2_Tick;
            // 
            // bad3
            // 
            bad3.Interval = 1000;
            bad3.Tick += bad3_Tick;
            // 
            // GameScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkTurquoise;
            ClientSize = new Size(804, 881);
            Controls.Add(bullet);
            Controls.Add(player);
            Controls.Add(enemy2);
            Controls.Add(enemy3);
            Controls.Add(enemy1);
            Controls.Add(scoreText);
            Controls.Add(menuStrip1);
            Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "GameScreen";
            Text = "Fighter Jet Shooting Game";
            KeyDown += onKeyDown;
            KeyUp += onKeyUp;
            ((System.ComponentModel.ISupportInitialize)enemy1).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy3).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)bullet).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox enemy1;
        private PictureBox enemy3;
        private PictureBox enemy2;
        private PictureBox player;
        private PictureBox bullet;
        private Label scoreText;
        private System.Windows.Forms.Timer playTimer;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem returnToMenuToolStripMenuItem;
        private ToolStripMenuItem returnToMenuToolStripMenuItem1;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem exitApplicationToolStripMenuItem;
        private ToolStripMenuItem menuOptionsToolStripMenuItem;
        private ToolStripMenuItem pausePlayToolStripMenuItem;
        private ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer bad1;
        private System.Windows.Forms.Timer bad2;
        private System.Windows.Forms.Timer bad3;
    }
}