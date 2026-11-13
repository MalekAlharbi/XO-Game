namespace XO_Game
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
            this.gbGameInfo = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbWinner = new System.Windows.Forms.Label();
            this.lbWinnerTitle = new System.Windows.Forms.Label();
            this.lbPlayer = new System.Windows.Forms.Label();
            this.lbTurn = new System.Windows.Forms.Label();
            this.gbXOBoard = new System.Windows.Forms.GroupBox();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.lbGameTitle = new System.Windows.Forms.Label();
            this.gbGameInfo.SuspendLayout();
            this.gbXOBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGameInfo
            // 
            this.gbGameInfo.BackColor = System.Drawing.Color.Transparent;
            this.gbGameInfo.Controls.Add(this.button1);
            this.gbGameInfo.Controls.Add(this.lbWinner);
            this.gbGameInfo.Controls.Add(this.lbWinnerTitle);
            this.gbGameInfo.Controls.Add(this.lbPlayer);
            this.gbGameInfo.Controls.Add(this.lbTurn);
            this.gbGameInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbGameInfo.Location = new System.Drawing.Point(58, 135);
            this.gbGameInfo.Name = "gbGameInfo";
            this.gbGameInfo.Size = new System.Drawing.Size(252, 426);
            this.gbGameInfo.TabIndex = 0;
            this.gbGameInfo.TabStop = false;
            this.gbGameInfo.Text = "Game Info";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(63, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Reset Game";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbWinner
            // 
            this.lbWinner.AutoSize = true;
            this.lbWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWinner.Location = new System.Drawing.Point(56, 252);
            this.lbWinner.Name = "lbWinner";
            this.lbWinner.Size = new System.Drawing.Size(30, 42);
            this.lbWinner.TabIndex = 3;
            this.lbWinner.Text = "-";
            // 
            // lbWinnerTitle
            // 
            this.lbWinnerTitle.AutoSize = true;
            this.lbWinnerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWinnerTitle.Location = new System.Drawing.Point(56, 193);
            this.lbWinnerTitle.Name = "lbWinnerTitle";
            this.lbWinnerTitle.Size = new System.Drawing.Size(136, 42);
            this.lbWinnerTitle.TabIndex = 2;
            this.lbWinnerTitle.Text = "Winner";
            // 
            // lbPlayer
            // 
            this.lbPlayer.AutoSize = true;
            this.lbPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayer.Location = new System.Drawing.Point(56, 93);
            this.lbPlayer.Name = "lbPlayer";
            this.lbPlayer.Size = new System.Drawing.Size(30, 42);
            this.lbPlayer.TabIndex = 1;
            this.lbPlayer.Text = "-";
            // 
            // lbTurn
            // 
            this.lbTurn.AutoSize = true;
            this.lbTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTurn.Location = new System.Drawing.Point(79, 42);
            this.lbTurn.Name = "lbTurn";
            this.lbTurn.Size = new System.Drawing.Size(95, 42);
            this.lbTurn.TabIndex = 0;
            this.lbTurn.Text = "Turn";
            // 
            // gbXOBoard
            // 
            this.gbXOBoard.BackColor = System.Drawing.Color.Transparent;
            this.gbXOBoard.Controls.Add(this.btn9);
            this.gbXOBoard.Controls.Add(this.btn8);
            this.gbXOBoard.Controls.Add(this.btn7);
            this.gbXOBoard.Controls.Add(this.btn6);
            this.gbXOBoard.Controls.Add(this.btn5);
            this.gbXOBoard.Controls.Add(this.btn4);
            this.gbXOBoard.Controls.Add(this.btn3);
            this.gbXOBoard.Controls.Add(this.btn2);
            this.gbXOBoard.Controls.Add(this.btn1);
            this.gbXOBoard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbXOBoard.Location = new System.Drawing.Point(332, 135);
            this.gbXOBoard.Name = "gbXOBoard";
            this.gbXOBoard.Size = new System.Drawing.Size(505, 426);
            this.gbXOBoard.TabIndex = 1;
            this.gbXOBoard.TabStop = false;
            this.gbXOBoard.Text = "XO Board";
            this.gbXOBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.gbXOBoard_Paint);
            this.gbXOBoard.Enter += new System.EventHandler(this.gbXOBoard_Enter);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Transparent;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.ForeColor = System.Drawing.Color.Transparent;
            this.btn9.Image = global::XO_Game.Properties.Resources.question_mark_96;
            this.btn9.Location = new System.Drawing.Point(378, 315);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(95, 79);
            this.btn9.TabIndex = 16;
            this.btn9.Tag = "?";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn_click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Transparent;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.ForeColor = System.Drawing.Color.Transparent;
            this.btn8.Image = global::XO_Game.Properties.Resources.question_mark_96;
            this.btn8.Location = new System.Drawing.Point(227, 315);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(95, 79);
            this.btn8.TabIndex = 15;
            this.btn8.Tag = "?";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn_click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Transparent;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.ForeColor = System.Drawing.Color.Transparent;
            this.btn7.Image = global::XO_Game.Properties.Resources.question_mark_96;
            this.btn7.Location = new System.Drawing.Point(71, 315);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(95, 79);
            this.btn7.TabIndex = 14;
            this.btn7.Tag = "?";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn_click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Transparent;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.ForeColor = System.Drawing.Color.Transparent;
            this.btn6.Image = global::XO_Game.Properties.Resources.question_mark_96;
            this.btn6.Location = new System.Drawing.Point(378, 193);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(95, 79);
            this.btn6.TabIndex = 13;
            this.btn6.Tag = "?";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn_click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Transparent;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.ForeColor = System.Drawing.Color.Transparent;
            this.btn5.Image = global::XO_Game.Properties.Resources.question_mark_96;
            this.btn5.Location = new System.Drawing.Point(227, 193);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(95, 79);
            this.btn5.TabIndex = 12;
            this.btn5.Tag = "?";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn_click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Transparent;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.ForeColor = System.Drawing.Color.Transparent;
            this.btn4.Image = global::XO_Game.Properties.Resources.question_mark_96;
            this.btn4.Location = new System.Drawing.Point(71, 193);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(95, 79);
            this.btn4.TabIndex = 11;
            this.btn4.Tag = "?";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn_click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Transparent;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.ForeColor = System.Drawing.Color.Transparent;
            this.btn3.Image = global::XO_Game.Properties.Resources.question_mark_96;
            this.btn3.Location = new System.Drawing.Point(378, 71);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(95, 79);
            this.btn3.TabIndex = 10;
            this.btn3.Tag = "?";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn_click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Transparent;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.ForeColor = System.Drawing.Color.Transparent;
            this.btn2.Image = global::XO_Game.Properties.Resources.question_mark_96;
            this.btn2.Location = new System.Drawing.Point(227, 71);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(95, 79);
            this.btn2.TabIndex = 9;
            this.btn2.Tag = "?";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn_click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Transparent;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.ForeColor = System.Drawing.Color.Transparent;
            this.btn1.Image = global::XO_Game.Properties.Resources.question_mark_96;
            this.btn1.Location = new System.Drawing.Point(71, 71);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(95, 79);
            this.btn1.TabIndex = 5;
            this.btn1.Tag = "?";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn_click);
            // 
            // lbGameTitle
            // 
            this.lbGameTitle.AutoSize = true;
            this.lbGameTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbGameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGameTitle.ForeColor = System.Drawing.Color.White;
            this.lbGameTitle.Location = new System.Drawing.Point(416, 59);
            this.lbGameTitle.Name = "lbGameTitle";
            this.lbGameTitle.Size = new System.Drawing.Size(317, 73);
            this.lbGameTitle.TabIndex = 3;
            this.lbGameTitle.Text = "XO Game";
            this.lbGameTitle.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.BackgroundImage = global::XO_Game.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(890, 573);
            this.Controls.Add(this.lbGameTitle);
            this.Controls.Add(this.gbXOBoard);
            this.Controls.Add(this.gbGameInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbGameInfo.ResumeLayout(false);
            this.gbGameInfo.PerformLayout();
            this.gbXOBoard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGameInfo;
        private System.Windows.Forms.GroupBox gbXOBoard;
        private System.Windows.Forms.Label lbGameTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbWinner;
        private System.Windows.Forms.Label lbWinnerTitle;
        private System.Windows.Forms.Label lbPlayer;
        private System.Windows.Forms.Label lbTurn;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
    }
}

