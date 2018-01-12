namespace SlidingPuzzleGame
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
            this.box1 = new System.Windows.Forms.PictureBox();
            this.box4 = new System.Windows.Forms.PictureBox();
            this.box7 = new System.Windows.Forms.PictureBox();
            this.box8 = new System.Windows.Forms.PictureBox();
            this.box5 = new System.Windows.Forms.PictureBox();
            this.box2 = new System.Windows.Forms.PictureBox();
            this.box9 = new System.Windows.Forms.PictureBox();
            this.box6 = new System.Windows.Forms.PictureBox();
            this.box3 = new System.Windows.Forms.PictureBox();
            this.winLabel = new System.Windows.Forms.Label();
            this.restartLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.box1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box3)).BeginInit();
            this.SuspendLayout();
            // 
            // box1
            // 
            this.box1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box1.Location = new System.Drawing.Point(20, 25);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(200, 200);
            this.box1.TabIndex = 1;
            this.box1.TabStop = false;
            // 
            // box4
            // 
            this.box4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box4.Location = new System.Drawing.Point(20, 231);
            this.box4.Name = "box4";
            this.box4.Size = new System.Drawing.Size(200, 200);
            this.box4.TabIndex = 2;
            this.box4.TabStop = false;
            // 
            // box7
            // 
            this.box7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box7.Location = new System.Drawing.Point(20, 437);
            this.box7.Name = "box7";
            this.box7.Size = new System.Drawing.Size(200, 200);
            this.box7.TabIndex = 3;
            this.box7.TabStop = false;
            // 
            // box8
            // 
            this.box8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box8.Location = new System.Drawing.Point(226, 437);
            this.box8.Name = "box8";
            this.box8.Size = new System.Drawing.Size(200, 200);
            this.box8.TabIndex = 6;
            this.box8.TabStop = false;
            // 
            // box5
            // 
            this.box5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box5.Location = new System.Drawing.Point(226, 231);
            this.box5.Name = "box5";
            this.box5.Size = new System.Drawing.Size(200, 200);
            this.box5.TabIndex = 5;
            this.box5.TabStop = false;
            // 
            // box2
            // 
            this.box2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box2.Location = new System.Drawing.Point(226, 25);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(200, 200);
            this.box2.TabIndex = 4;
            this.box2.TabStop = false;
            // 
            // box9
            // 
            this.box9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box9.Location = new System.Drawing.Point(432, 437);
            this.box9.Name = "box9";
            this.box9.Size = new System.Drawing.Size(200, 200);
            this.box9.TabIndex = 9;
            this.box9.TabStop = false;
            // 
            // box6
            // 
            this.box6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box6.Location = new System.Drawing.Point(432, 231);
            this.box6.Name = "box6";
            this.box6.Size = new System.Drawing.Size(200, 200);
            this.box6.TabIndex = 8;
            this.box6.TabStop = false;
            // 
            // box3
            // 
            this.box3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box3.Location = new System.Drawing.Point(432, 25);
            this.box3.Name = "box3";
            this.box3.Size = new System.Drawing.Size(200, 200);
            this.box3.TabIndex = 7;
            this.box3.TabStop = false;
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.Location = new System.Drawing.Point(779, 161);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(173, 46);
            this.winLabel.TabIndex = 10;
            this.winLabel.Text = "You win!";
            this.winLabel.Visible = false;
            // 
            // restartLabel
            // 
            this.restartLabel.AutoSize = true;
            this.restartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartLabel.Location = new System.Drawing.Point(779, 273);
            this.restartLabel.Name = "restartLabel";
            this.restartLabel.Size = new System.Drawing.Size(410, 46);
            this.restartLabel.TabIndex = 11;
            this.restartLabel.Text = "To restart, press enter";
            this.restartLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 661);
            this.Controls.Add(this.restartLabel);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.box9);
            this.Controls.Add(this.box6);
            this.Controls.Add(this.box3);
            this.Controls.Add(this.box8);
            this.Controls.Add(this.box5);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.box7);
            this.Controls.Add(this.box4);
            this.Controls.Add(this.box1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.box1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox box1;
        private System.Windows.Forms.PictureBox box4;
        private System.Windows.Forms.PictureBox box7;
        private System.Windows.Forms.PictureBox box8;
        private System.Windows.Forms.PictureBox box5;
        private System.Windows.Forms.PictureBox box2;
        private System.Windows.Forms.PictureBox box9;
        private System.Windows.Forms.PictureBox box6;
        private System.Windows.Forms.PictureBox box3;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Label restartLabel;
        private System.Windows.Forms.Timer gameTimer;
    }
}

