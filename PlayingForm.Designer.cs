namespace RockPaperScissors
{
    partial class PlayingForm
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
            this.guna = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnPlayerScore = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnCoputerScore = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnRock = new Guna.UI2.WinForms.Guna2Button();
            this.btnPaper = new Guna.UI2.WinForms.Guna2Button();
            this.btnScissors = new Guna.UI2.WinForms.Guna2Button();
            this.lblChosingOption = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pbComputer = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbme = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbme)).BeginInit();
            this.SuspendLayout();
            // 
            // guna
            // 
            this.guna.BackColor = System.Drawing.Color.Transparent;
            this.guna.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna.Location = new System.Drawing.Point(25, 12);
            this.guna.Name = "guna";
            this.guna.Size = new System.Drawing.Size(62, 28);
            this.guna.TabIndex = 0;
            this.guna.Text = "Player";
            // 
            // btnPlayerScore
            // 
            this.btnPlayerScore.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayerScore.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayerScore.Location = new System.Drawing.Point(42, 46);
            this.btnPlayerScore.Name = "btnPlayerScore";
            this.btnPlayerScore.Size = new System.Drawing.Size(15, 28);
            this.btnPlayerScore.TabIndex = 0;
            this.btnPlayerScore.Text = "0";
            this.btnPlayerScore.Click += new System.EventHandler(this.btnPlayerScore_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(425, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(99, 28);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Computer";
            // 
            // btnCoputerScore
            // 
            this.btnCoputerScore.BackColor = System.Drawing.Color.Transparent;
            this.btnCoputerScore.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoputerScore.Location = new System.Drawing.Point(474, 46);
            this.btnCoputerScore.Name = "btnCoputerScore";
            this.btnCoputerScore.Size = new System.Drawing.Size(15, 28);
            this.btnCoputerScore.TabIndex = 0;
            this.btnCoputerScore.Text = "0";
            this.btnCoputerScore.Click += new System.EventHandler(this.btnPlayerScore_Click);
            // 
            // btnRock
            // 
            this.btnRock.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRock.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRock.ForeColor = System.Drawing.Color.White;
            this.btnRock.Location = new System.Drawing.Point(107, 275);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(89, 45);
            this.btnRock.TabIndex = 1;
            this.btnRock.Text = "Rock";
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPaper.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPaper.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPaper.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPaper.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPaper.ForeColor = System.Drawing.Color.White;
            this.btnPaper.Location = new System.Drawing.Point(245, 275);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(89, 45);
            this.btnPaper.TabIndex = 1;
            this.btnPaper.Text = "Paper";
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnScissors.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnScissors.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnScissors.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnScissors.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnScissors.ForeColor = System.Drawing.Color.White;
            this.btnScissors.Location = new System.Drawing.Point(385, 275);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(89, 45);
            this.btnScissors.TabIndex = 1;
            this.btnScissors.Text = "Scissors";
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // lblChosingOption
            // 
            this.lblChosingOption.BackColor = System.Drawing.Color.Transparent;
            this.lblChosingOption.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChosingOption.Location = new System.Drawing.Point(190, 80);
            this.lblChosingOption.Name = "lblChosingOption";
            this.lblChosingOption.Size = new System.Drawing.Size(174, 28);
            this.lblChosingOption.TabIndex = 0;
            this.lblChosingOption.Text = "Choose an Option";
            // 
            // pbComputer
            // 
            this.pbComputer.ImageRotate = 0F;
            this.pbComputer.Location = new System.Drawing.Point(328, 130);
            this.pbComputer.Name = "pbComputer";
            this.pbComputer.Size = new System.Drawing.Size(98, 77);
            this.pbComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbComputer.TabIndex = 2;
            this.pbComputer.TabStop = false;
            // 
            // pbme
            // 
            this.pbme.ImageRotate = 0F;
            this.pbme.Location = new System.Drawing.Point(139, 130);
            this.pbme.Name = "pbme";
            this.pbme.Size = new System.Drawing.Size(98, 77);
            this.pbme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbme.TabIndex = 2;
            this.pbme.TabStop = false;
            this.pbme.Tag = "";
            // 
            // PlayingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 346);
            this.Controls.Add(this.pbComputer);
            this.Controls.Add(this.pbme);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.btnCoputerScore);
            this.Controls.Add(this.btnPlayerScore);
            this.Controls.Add(this.lblChosingOption);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlayingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayingForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna;
        private Guna.UI2.WinForms.Guna2HtmlLabel btnPlayerScore;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel btnCoputerScore;
        private Guna.UI2.WinForms.Guna2Button btnRock;
        private Guna.UI2.WinForms.Guna2Button btnPaper;
        private Guna.UI2.WinForms.Guna2Button btnScissors;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblChosingOption;
        private Guna.UI2.WinForms.Guna2PictureBox pbme;
        private Guna.UI2.WinForms.Guna2PictureBox pbComputer;
    }
}