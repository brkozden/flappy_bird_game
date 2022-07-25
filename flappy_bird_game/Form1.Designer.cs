namespace flappy_bird_game
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
            this.components = new System.ComponentModel.Container();
            this.pipe1 = new System.Windows.Forms.PictureBox();
            this.bird_picturebox = new System.Windows.Forms.PictureBox();
            this.pipe2 = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pipe3 = new System.Windows.Forms.PictureBox();
            this.pipe4 = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pipe1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // pipe1
            // 
            this.pipe1.BackColor = System.Drawing.Color.Transparent;
            this.pipe1.Image = global::flappy_bird_game.Properties.Resources.pinpng_com_pipe_png_333546;
            this.pipe1.Location = new System.Drawing.Point(64, 336);
            this.pipe1.Name = "pipe1";
            this.pipe1.Size = new System.Drawing.Size(100, 220);
            this.pipe1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe1.TabIndex = 1;
            this.pipe1.TabStop = false;
            // 
            // bird_picturebox
            // 
            this.bird_picturebox.BackColor = System.Drawing.Color.Transparent;
            this.bird_picturebox.Image = global::flappy_bird_game.Properties.Resources.SeekPng_com_flappy_bird_png_1515387;
            this.bird_picturebox.Location = new System.Drawing.Point(54, 189);
            this.bird_picturebox.Name = "bird_picturebox";
            this.bird_picturebox.Size = new System.Drawing.Size(43, 41);
            this.bird_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird_picturebox.TabIndex = 2;
            this.bird_picturebox.TabStop = false;
            // 
            // pipe2
            // 
            this.pipe2.BackColor = System.Drawing.Color.Transparent;
            this.pipe2.Image = global::flappy_bird_game.Properties.Resources._55555;
            this.pipe2.Location = new System.Drawing.Point(181, -44);
            this.pipe2.Name = "pipe2";
            this.pipe2.Size = new System.Drawing.Size(100, 246);
            this.pipe2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe2.TabIndex = 3;
            this.pipe2.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(12, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(103, 28);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score: 0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pipe3
            // 
            this.pipe3.BackColor = System.Drawing.Color.Transparent;
            this.pipe3.Image = global::flappy_bird_game.Properties.Resources._55555;
            this.pipe3.Location = new System.Drawing.Point(799, -32);
            this.pipe3.Name = "pipe3";
            this.pipe3.Size = new System.Drawing.Size(100, 189);
            this.pipe3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe3.TabIndex = 5;
            this.pipe3.TabStop = false;
            // 
            // pipe4
            // 
            this.pipe4.BackColor = System.Drawing.Color.Transparent;
            this.pipe4.Image = global::flappy_bird_game.Properties.Resources.pinpng_com_pipe_png_333546;
            this.pipe4.Location = new System.Drawing.Point(809, 294);
            this.pipe4.Name = "pipe4";
            this.pipe4.Size = new System.Drawing.Size(100, 175);
            this.pipe4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe4.TabIndex = 6;
            this.pipe4.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::flappy_bird_game.Properties.Resources.PikPng_com_scratch_png_474860;
            this.ground.Location = new System.Drawing.Point(0, 463);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(921, 93);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::flappy_bird_game.Properties.Resources._46888871_624a3900_ce7f_11e8_808e_99fd90c8a3f4;
            this.ClientSize = new System.Drawing.Size(921, 554);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pipe3);
            this.Controls.Add(this.pipe4);
            this.Controls.Add(this.bird_picturebox);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipe1);
            this.Controls.Add(this.pipe2);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pipe1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pipe1;
        private System.Windows.Forms.PictureBox bird_picturebox;
        private System.Windows.Forms.PictureBox pipe2;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pipe3;
        private System.Windows.Forms.PictureBox pipe4;
        private System.Windows.Forms.PictureBox ground;
    }
}

