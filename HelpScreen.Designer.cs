namespace Quiz_Coursework
{
    partial class HelpScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.typeLbl = new System.Windows.Forms.Label();
            this.tutLbl = new System.Windows.Forms.Label();
            this.MultBtn = new System.Windows.Forms.Button();
            this.FillBtn = new System.Windows.Forms.Button();
            this.TrueBtn = new System.Windows.Forms.Button();
            this.DragBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(454, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Help";
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.BackColor = System.Drawing.Color.Transparent;
            this.typeLbl.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.typeLbl.Location = new System.Drawing.Point(360, 110);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(185, 29);
            this.typeLbl.TabIndex = 1;
            this.typeLbl.Text = "Question Type";
            // 
            // tutLbl
            // 
            this.tutLbl.AutoSize = true;
            this.tutLbl.BackColor = System.Drawing.Color.Transparent;
            this.tutLbl.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tutLbl.Location = new System.Drawing.Point(300, 176);
            this.tutLbl.Name = "tutLbl";
            this.tutLbl.Size = new System.Drawing.Size(65, 27);
            this.tutLbl.TabIndex = 2;
            this.tutLbl.Text = "Help";
            // 
            // MultBtn
            // 
            this.MultBtn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MultBtn.Location = new System.Drawing.Point(32, 23);
            this.MultBtn.Name = "MultBtn";
            this.MultBtn.Size = new System.Drawing.Size(104, 55);
            this.MultBtn.TabIndex = 3;
            this.MultBtn.Text = "Multi-Choice Help";
            this.MultBtn.UseVisualStyleBackColor = true;
            this.MultBtn.Click += new System.EventHandler(this.MultBtn_Click);
            // 
            // FillBtn
            // 
            this.FillBtn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FillBtn.Location = new System.Drawing.Point(145, 23);
            this.FillBtn.Name = "FillBtn";
            this.FillBtn.Size = new System.Drawing.Size(104, 55);
            this.FillBtn.TabIndex = 4;
            this.FillBtn.Text = "Fill-The-Blanks Help";
            this.FillBtn.UseVisualStyleBackColor = true;
            this.FillBtn.Click += new System.EventHandler(this.FillBtn_Click);
            // 
            // TrueBtn
            // 
            this.TrueBtn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TrueBtn.Location = new System.Drawing.Point(32, 84);
            this.TrueBtn.Name = "TrueBtn";
            this.TrueBtn.Size = new System.Drawing.Size(104, 55);
            this.TrueBtn.TabIndex = 5;
            this.TrueBtn.Text = "True-False Help";
            this.TrueBtn.UseVisualStyleBackColor = true;
            this.TrueBtn.Click += new System.EventHandler(this.TrueBtn_Click);
            // 
            // DragBtn
            // 
            this.DragBtn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DragBtn.Location = new System.Drawing.Point(145, 84);
            this.DragBtn.Name = "DragBtn";
            this.DragBtn.Size = new System.Drawing.Size(104, 55);
            this.DragBtn.TabIndex = 6;
            this.DragBtn.Text = "Drag-Drop Help";
            this.DragBtn.UseVisualStyleBackColor = true;
            this.DragBtn.Click += new System.EventHandler(this.DragBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backBtn.Location = new System.Drawing.Point(698, 383);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(78, 55);
            this.backBtn.TabIndex = 7;
            this.backBtn.Text = "---->";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // HelpScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quiz_Coursework.Properties.Resources.Theory_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(788, 450);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.DragBtn);
            this.Controls.Add(this.TrueBtn);
            this.Controls.Add(this.FillBtn);
            this.Controls.Add(this.MultBtn);
            this.Controls.Add(this.tutLbl);
            this.Controls.Add(this.typeLbl);
            this.Controls.Add(this.label1);
            this.Name = "HelpScreen";
            this.Text = "HelpScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label typeLbl;
        private Label tutLbl;
        private Button MultBtn;
        private Button FillBtn;
        private Button TrueBtn;
        private Button DragBtn;
        private Button backBtn;
    }
}