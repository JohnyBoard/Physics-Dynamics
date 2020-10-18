namespace Dynamics
{
    partial class Dynamics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dynamics));
            this.pbGround = new System.Windows.Forms.PictureBox();
            this.pbBall1 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.button = new System.Windows.Forms.Button();
            this.pbBall2 = new System.Windows.Forms.PictureBox();
            this.pbSpring = new System.Windows.Forms.PictureBox();
            this.pbMagnet = new System.Windows.Forms.PictureBox();
            this.pbBall3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpring)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMagnet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBall3)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGround
            // 
            this.pbGround.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pbGround.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbGround.Location = new System.Drawing.Point(0, 400);
            this.pbGround.Name = "pbGround";
            this.pbGround.Size = new System.Drawing.Size(800, 50);
            this.pbGround.TabIndex = 0;
            this.pbGround.TabStop = false;
            // 
            // pbBall1
            // 
            this.pbBall1.BackColor = System.Drawing.Color.Transparent;
            this.pbBall1.Image = ((System.Drawing.Image)(resources.GetObject("pbBall1.Image")));
            this.pbBall1.Location = new System.Drawing.Point(12, 347);
            this.pbBall1.Name = "pbBall1";
            this.pbBall1.Size = new System.Drawing.Size(48, 47);
            this.pbBall1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBall1.TabIndex = 1;
            this.pbBall1.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 33;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // button
            // 
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Location = new System.Drawing.Point(361, 415);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 2;
            this.button.Text = "Start";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // pbBall2
            // 
            this.pbBall2.BackColor = System.Drawing.Color.Transparent;
            this.pbBall2.Image = ((System.Drawing.Image)(resources.GetObject("pbBall2.Image")));
            this.pbBall2.Location = new System.Drawing.Point(375, 87);
            this.pbBall2.Name = "pbBall2";
            this.pbBall2.Size = new System.Drawing.Size(48, 47);
            this.pbBall2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBall2.TabIndex = 3;
            this.pbBall2.TabStop = false;
            // 
            // pbSpring
            // 
            this.pbSpring.Image = ((System.Drawing.Image)(resources.GetObject("pbSpring.Image")));
            this.pbSpring.Location = new System.Drawing.Point(334, -74);
            this.pbSpring.Name = "pbSpring";
            this.pbSpring.Size = new System.Drawing.Size(123, 166);
            this.pbSpring.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSpring.TabIndex = 4;
            this.pbSpring.TabStop = false;
            // 
            // pbMagnet
            // 
            this.pbMagnet.Image = ((System.Drawing.Image)(resources.GetObject("pbMagnet.Image")));
            this.pbMagnet.Location = new System.Drawing.Point(542, 12);
            this.pbMagnet.Name = "pbMagnet";
            this.pbMagnet.Size = new System.Drawing.Size(123, 105);
            this.pbMagnet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMagnet.TabIndex = 5;
            this.pbMagnet.TabStop = false;
            // 
            // pbBall3
            // 
            this.pbBall3.BackColor = System.Drawing.Color.Transparent;
            this.pbBall3.Image = ((System.Drawing.Image)(resources.GetObject("pbBall3.Image")));
            this.pbBall3.Location = new System.Drawing.Point(579, 123);
            this.pbBall3.Name = "pbBall3";
            this.pbBall3.Size = new System.Drawing.Size(48, 47);
            this.pbBall3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBall3.TabIndex = 6;
            this.pbBall3.TabStop = false;
            // 
            // Dynamics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbBall3);
            this.Controls.Add(this.pbMagnet);
            this.Controls.Add(this.pbSpring);
            this.Controls.Add(this.pbBall2);
            this.Controls.Add(this.button);
            this.Controls.Add(this.pbBall1);
            this.Controls.Add(this.pbGround);
            this.Name = "Dynamics";
            this.Text = "Dynamics";
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpring)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMagnet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBall3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGround;
        private System.Windows.Forms.PictureBox pbBall1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.PictureBox pbBall2;
        private System.Windows.Forms.PictureBox pbSpring;
        private System.Windows.Forms.PictureBox pbMagnet;
        private System.Windows.Forms.PictureBox pbBall3;
    }
}