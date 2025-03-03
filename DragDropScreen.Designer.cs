namespace Quiz_Coursework
{
    partial class DragDropScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DragDropScreen));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.playerStatsListBox = new System.Windows.Forms.ListBox();
            this.playerLbl = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerLbl = new System.Windows.Forms.Label();
            this.questionLbl = new System.Windows.Forms.Label();
            this.questionNoLbl = new System.Windows.Forms.Label();
            this.ansLbl1 = new System.Windows.Forms.Label();
            this.ansLbl2 = new System.Windows.Forms.Label();
            this.ansLbl3 = new System.Windows.Forms.Label();
            this.ansPicBox1 = new System.Windows.Forms.PictureBox();
            this.ansPicBox2 = new System.Windows.Forms.PictureBox();
            this.ansPicBox3 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToLoginScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ansPicBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ansPicBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ansPicBox3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(342, 388);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 29);
            this.button6.TabIndex = 60;
            this.button6.Text = "Continue";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // playerStatsListBox
            // 
            this.playerStatsListBox.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playerStatsListBox.FormattingEnabled = true;
            this.playerStatsListBox.ItemHeight = 14;
            this.playerStatsListBox.Location = new System.Drawing.Point(523, 152);
            this.playerStatsListBox.Name = "playerStatsListBox";
            this.playerStatsListBox.Size = new System.Drawing.Size(129, 46);
            this.playerStatsListBox.TabIndex = 59;
            // 
            // playerLbl
            // 
            this.playerLbl.AutoSize = true;
            this.playerLbl.BackColor = System.Drawing.Color.Transparent;
            this.playerLbl.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playerLbl.Location = new System.Drawing.Point(558, 129);
            this.playerLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerLbl.Name = "playerLbl";
            this.playerLbl.Size = new System.Drawing.Size(61, 19);
            this.playerLbl.TabIndex = 56;
            this.playerLbl.Text = "Player";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::Quiz_Coursework.Properties.Resources.Avatar7;
            this.pictureBox8.Location = new System.Drawing.Point(523, 41);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(129, 86);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 55;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.MouseLeave += new System.EventHandler(this.pictureBox8_Click);
            this.pictureBox8.MouseHover += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 118);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseHover += new System.EventHandler(this.FooFightas);
            // 
            // timerLbl
            // 
            this.timerLbl.AutoSize = true;
            this.timerLbl.BackColor = System.Drawing.Color.Transparent;
            this.timerLbl.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timerLbl.Location = new System.Drawing.Point(11, 32);
            this.timerLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timerLbl.Name = "timerLbl";
            this.timerLbl.Size = new System.Drawing.Size(73, 21);
            this.timerLbl.TabIndex = 44;
            this.timerLbl.Text = "Timer: ";
            // 
            // questionLbl
            // 
            this.questionLbl.AutoSize = true;
            this.questionLbl.BackColor = System.Drawing.Color.Transparent;
            this.questionLbl.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.questionLbl.Location = new System.Drawing.Point(286, 118);
            this.questionLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(118, 19);
            this.questionLbl.TabIndex = 43;
            this.questionLbl.Text = "Question Label";
            // 
            // questionNoLbl
            // 
            this.questionNoLbl.AutoSize = true;
            this.questionNoLbl.BackColor = System.Drawing.Color.Transparent;
            this.questionNoLbl.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.questionNoLbl.Location = new System.Drawing.Point(286, 34);
            this.questionNoLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.questionNoLbl.Name = "questionNoLbl";
            this.questionNoLbl.Size = new System.Drawing.Size(179, 23);
            this.questionNoLbl.TabIndex = 42;
            this.questionNoLbl.Text = "Question Number";
            // 
            // ansLbl1
            // 
            this.ansLbl1.AutoSize = true;
            this.ansLbl1.BackColor = System.Drawing.Color.Transparent;
            this.ansLbl1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ansLbl1.Location = new System.Drawing.Point(272, 200);
            this.ansLbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ansLbl1.Name = "ansLbl1";
            this.ansLbl1.Size = new System.Drawing.Size(58, 16);
            this.ansLbl1.TabIndex = 61;
            this.ansLbl1.Text = "Answer1";
            this.ansLbl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelGrabbed);
            // 
            // ansLbl2
            // 
            this.ansLbl2.AutoSize = true;
            this.ansLbl2.BackColor = System.Drawing.Color.Transparent;
            this.ansLbl2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ansLbl2.Location = new System.Drawing.Point(272, 253);
            this.ansLbl2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ansLbl2.Name = "ansLbl2";
            this.ansLbl2.Size = new System.Drawing.Size(58, 16);
            this.ansLbl2.TabIndex = 62;
            this.ansLbl2.Text = "Answer2";
            this.ansLbl2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelGrabbed);
            // 
            // ansLbl3
            // 
            this.ansLbl3.AutoSize = true;
            this.ansLbl3.BackColor = System.Drawing.Color.Transparent;
            this.ansLbl3.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ansLbl3.Location = new System.Drawing.Point(272, 311);
            this.ansLbl3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ansLbl3.Name = "ansLbl3";
            this.ansLbl3.Size = new System.Drawing.Size(58, 16);
            this.ansLbl3.TabIndex = 63;
            this.ansLbl3.Text = "Answer3";
            this.ansLbl3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelGrabbed);
            // 
            // ansPicBox1
            // 
            this.ansPicBox1.Location = new System.Drawing.Point(422, 175);
            this.ansPicBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ansPicBox1.Name = "ansPicBox1";
            this.ansPicBox1.Size = new System.Drawing.Size(96, 64);
            this.ansPicBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ansPicBox1.TabIndex = 64;
            this.ansPicBox1.TabStop = false;
            this.ansPicBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.picDragDrop);
            this.ansPicBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.AllowDragDropCopy);
            // 
            // ansPicBox2
            // 
            this.ansPicBox2.Location = new System.Drawing.Point(422, 243);
            this.ansPicBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ansPicBox2.Name = "ansPicBox2";
            this.ansPicBox2.Size = new System.Drawing.Size(96, 64);
            this.ansPicBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ansPicBox2.TabIndex = 65;
            this.ansPicBox2.TabStop = false;
            this.ansPicBox2.DragDrop += new System.Windows.Forms.DragEventHandler(this.pic2DragDrop);
            this.ansPicBox2.DragEnter += new System.Windows.Forms.DragEventHandler(this.AllowDragDropCopy);
            // 
            // ansPicBox3
            // 
            this.ansPicBox3.Location = new System.Drawing.Point(422, 311);
            this.ansPicBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ansPicBox3.Name = "ansPicBox3";
            this.ansPicBox3.Size = new System.Drawing.Size(96, 64);
            this.ansPicBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ansPicBox3.TabIndex = 66;
            this.ansPicBox3.TabStop = false;
            this.ansPicBox3.DragDrop += new System.Windows.Forms.DragEventHandler(this.pic3DragDrop);
            this.ansPicBox3.DragEnter += new System.Windows.Forms.DragEventHandler(this.AllowDragDropCopy);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(69, 388);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 29);
            this.button5.TabIndex = 67;
            this.button5.Text = "Show Menu";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToMenuToolStripMenuItem,
            this.backToLoginScreenToolStripMenuItem,
            this.quitToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(788, 24);
            this.menuStrip1.TabIndex = 68;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToMenuToolStripMenuItem
            // 
            this.backToMenuToolStripMenuItem.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backToMenuToolStripMenuItem.Name = "backToMenuToolStripMenuItem";
            this.backToMenuToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.backToMenuToolStripMenuItem.Text = "Back To Menu";
            this.backToMenuToolStripMenuItem.Click += new System.EventHandler(this.backToMenuToolStripMenuItem_Click);
            // 
            // backToLoginScreenToolStripMenuItem
            // 
            this.backToLoginScreenToolStripMenuItem.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backToLoginScreenToolStripMenuItem.Name = "backToLoginScreenToolStripMenuItem";
            this.backToLoginScreenToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.backToLoginScreenToolStripMenuItem.Text = "Log Out";
            this.backToLoginScreenToolStripMenuItem.Click += new System.EventHandler(this.backToLoginScreenToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // DragDropScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quiz_Coursework.Properties.Resources.Guitar_Background_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(788, 430);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.ansPicBox3);
            this.Controls.Add(this.ansPicBox2);
            this.Controls.Add(this.ansPicBox1);
            this.Controls.Add(this.ansLbl3);
            this.Controls.Add(this.ansLbl2);
            this.Controls.Add(this.ansLbl1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.playerStatsListBox);
            this.Controls.Add(this.playerLbl);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.timerLbl);
            this.Controls.Add(this.questionLbl);
            this.Controls.Add(this.questionNoLbl);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DragDropScreen";
            this.Text = "DragDropScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ansPicBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ansPicBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ansPicBox3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Button button6;
        private ListBox playerStatsListBox;
        private Label playerLbl;
        private PictureBox pictureBox8;
        private PictureBox pictureBox1;
        private Label timerLbl;
        private Label questionLbl;
        private Label questionNoLbl;
        private Label ansLbl1;
        private Label ansLbl2;
        private Label ansLbl3;
        private PictureBox ansPicBox1;
        private PictureBox ansPicBox2;
        private PictureBox ansPicBox3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private Button button5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem backToMenuToolStripMenuItem;
        private ToolStripMenuItem backToLoginScreenToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem1;
    }
}