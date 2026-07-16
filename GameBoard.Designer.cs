namespace XO_Game
{
    partial class GameBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameBoard));
            this.lblGameName = new System.Windows.Forms.Label();
            this.pbP = new System.Windows.Forms.PictureBox();
            this.lblTxt1 = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblText2 = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.btnRestartGame = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGameName
            // 
            this.lblGameName.BackColor = System.Drawing.Color.Transparent;
            this.lblGameName.Font = new System.Drawing.Font("Britannic Bold", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.lblGameName.Location = new System.Drawing.Point(620, 57);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(606, 79);
            this.lblGameName.TabIndex = 9;
            this.lblGameName.Text = "Tic-Tac-Toe Game";
            this.lblGameName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbP
            // 
            this.pbP.BackColor = System.Drawing.Color.Transparent;
            this.pbP.Image = global::XO_Game.Properties.Resources.GizmoLogWithoutBackGround;
            this.pbP.Location = new System.Drawing.Point(36, 33);
            this.pbP.Name = "pbP";
            this.pbP.Size = new System.Drawing.Size(376, 267);
            this.pbP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbP.TabIndex = 10;
            this.pbP.TabStop = false;
            // 
            // lblTxt1
            // 
            this.lblTxt1.BackColor = System.Drawing.Color.Transparent;
            this.lblTxt1.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxt1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(211)))), ((int)(((byte)(199)))));
            this.lblTxt1.Location = new System.Drawing.Point(36, 315);
            this.lblTxt1.Name = "lblTxt1";
            this.lblTxt1.Size = new System.Drawing.Size(376, 56);
            this.lblTxt1.TabIndex = 11;
            this.lblTxt1.Text = "Turn";
            this.lblTxt1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTurn
            // 
            this.lblTurn.BackColor = System.Drawing.Color.Transparent;
            this.lblTurn.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTurn.Location = new System.Drawing.Point(36, 371);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(376, 56);
            this.lblTurn.TabIndex = 12;
            this.lblTurn.Text = "Player1";
            this.lblTurn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblText2
            // 
            this.lblText2.BackColor = System.Drawing.Color.Transparent;
            this.lblText2.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(211)))), ((int)(((byte)(199)))));
            this.lblText2.Location = new System.Drawing.Point(35, 473);
            this.lblText2.Name = "lblText2";
            this.lblText2.Size = new System.Drawing.Size(376, 56);
            this.lblText2.TabIndex = 13;
            this.lblText2.Text = "Winner";
            this.lblText2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWinner
            // 
            this.lblWinner.BackColor = System.Drawing.Color.Transparent;
            this.lblWinner.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.DarkGray;
            this.lblWinner.Location = new System.Drawing.Point(36, 529);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(376, 66);
            this.lblWinner.TabIndex = 14;
            this.lblWinner.Text = "In Progress";
            this.lblWinner.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.BackColor = System.Drawing.Color.Transparent;
            this.btnRestartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestartGame.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestartGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.btnRestartGame.Location = new System.Drawing.Point(36, 644);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(375, 67);
            this.btnRestartGame.TabIndex = 15;
            this.btnRestartGame.Text = "Restart Game";
            this.btnRestartGame.UseVisualStyleBackColor = false;
            this.btnRestartGame.Click += new System.EventHandler(this.btnRestartGame_Click);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.Transparent;
            this.Button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button2.BackgroundImage")));
            this.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button2.FlatAppearance.BorderSize = 0;
            this.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2.Location = new System.Drawing.Point(846, 169);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(154, 131);
            this.Button2.TabIndex = 18;
            this.Button2.Tag = "?";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.BoardButtons_Click);
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.Transparent;
            this.Button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button3.BackgroundImage")));
            this.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button3.FlatAppearance.BorderSize = 0;
            this.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button3.Location = new System.Drawing.Point(1072, 169);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(154, 131);
            this.Button3.TabIndex = 19;
            this.Button3.Tag = "?";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.BoardButtons_Click);
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.Color.Transparent;
            this.Button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button4.BackgroundImage")));
            this.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button4.FlatAppearance.BorderSize = 0;
            this.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button4.Location = new System.Drawing.Point(620, 353);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(154, 131);
            this.Button4.TabIndex = 20;
            this.Button4.Tag = "?";
            this.Button4.UseVisualStyleBackColor = false;
            this.Button4.Click += new System.EventHandler(this.BoardButtons_Click);
            // 
            // Button5
            // 
            this.Button5.BackColor = System.Drawing.Color.Transparent;
            this.Button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button5.BackgroundImage")));
            this.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button5.FlatAppearance.BorderSize = 0;
            this.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button5.Location = new System.Drawing.Point(846, 353);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(154, 131);
            this.Button5.TabIndex = 21;
            this.Button5.Tag = "?";
            this.Button5.UseVisualStyleBackColor = false;
            this.Button5.Click += new System.EventHandler(this.BoardButtons_Click);
            // 
            // Button6
            // 
            this.Button6.BackColor = System.Drawing.Color.Transparent;
            this.Button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button6.BackgroundImage")));
            this.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button6.FlatAppearance.BorderSize = 0;
            this.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button6.Location = new System.Drawing.Point(1072, 353);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(154, 131);
            this.Button6.TabIndex = 22;
            this.Button6.Tag = "?";
            this.Button6.UseVisualStyleBackColor = false;
            this.Button6.Click += new System.EventHandler(this.BoardButtons_Click);
            // 
            // Button7
            // 
            this.Button7.BackColor = System.Drawing.Color.Transparent;
            this.Button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button7.BackgroundImage")));
            this.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button7.FlatAppearance.BorderSize = 0;
            this.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button7.Location = new System.Drawing.Point(620, 537);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(154, 131);
            this.Button7.TabIndex = 23;
            this.Button7.Tag = "?";
            this.Button7.UseVisualStyleBackColor = false;
            this.Button7.Click += new System.EventHandler(this.BoardButtons_Click);
            // 
            // Button8
            // 
            this.Button8.BackColor = System.Drawing.Color.Transparent;
            this.Button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button8.BackgroundImage")));
            this.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button8.FlatAppearance.BorderSize = 0;
            this.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button8.Location = new System.Drawing.Point(846, 537);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(154, 131);
            this.Button8.TabIndex = 24;
            this.Button8.Tag = "?";
            this.Button8.UseVisualStyleBackColor = false;
            this.Button8.Click += new System.EventHandler(this.BoardButtons_Click);
            // 
            // Button9
            // 
            this.Button9.BackColor = System.Drawing.Color.Transparent;
            this.Button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button9.BackgroundImage")));
            this.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button9.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button9.FlatAppearance.BorderSize = 0;
            this.Button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button9.Location = new System.Drawing.Point(1072, 537);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(154, 131);
            this.Button9.TabIndex = 25;
            this.Button9.Tag = "?";
            this.Button9.UseVisualStyleBackColor = false;
            this.Button9.Click += new System.EventHandler(this.BoardButtons_Click);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.Transparent;
            this.Button1.BackgroundImage = global::XO_Game.Properties.Resources.PuncNew;
            this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button1.FlatAppearance.BorderSize = 0;
            this.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Location = new System.Drawing.Point(620, 169);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(154, 131);
            this.Button1.TabIndex = 26;
            this.Button1.Tag = "?";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.BoardButtons_Click);
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::XO_Game.Properties.Resources.Gemini_Generated_Image_dz9t3vdz9t3vdz9t;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1299, 733);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Button9);
            this.Controls.Add(this.Button8);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.btnRestartGame);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.lblText2);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.lblTxt1);
            this.Controls.Add(this.pbP);
            this.Controls.Add(this.lblGameName);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameBoard";
            this.Text = "Tic-Tac-Toe";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameBoard_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.PictureBox pbP;
        private System.Windows.Forms.Label lblTxt1;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblText2;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button btnRestartGame;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.Button Button8;
        private System.Windows.Forms.Button Button9;
        private System.Windows.Forms.Button Button1;
    }
}

