namespace car
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rightOFF = new System.Windows.Forms.PictureBox();
            this.rightON = new System.Windows.Forms.PictureBox();
            this.leftOFF = new System.Windows.Forms.PictureBox();
            this.leftON = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.leftturnstick = new System.Windows.Forms.PictureBox();
            this.rightturnstick = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BrakeLON = new System.Windows.Forms.PictureBox();
            this.BrakeRON = new System.Windows.Forms.PictureBox();
            this.BrakePedal = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.rightOFF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftOFF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftturnstick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightturnstick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrakeLON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrakeRON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrakePedal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // rightOFF
            // 
            this.rightOFF.Image = ((System.Drawing.Image)(resources.GetObject("rightOFF.Image")));
            this.rightOFF.Location = new System.Drawing.Point(599, 28);
            this.rightOFF.Name = "rightOFF";
            this.rightOFF.Size = new System.Drawing.Size(136, 62);
            this.rightOFF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightOFF.TabIndex = 0;
            this.rightOFF.TabStop = false;
            // 
            // rightON
            // 
            this.rightON.Image = ((System.Drawing.Image)(resources.GetObject("rightON.Image")));
            this.rightON.Location = new System.Drawing.Point(599, 28);
            this.rightON.Name = "rightON";
            this.rightON.Size = new System.Drawing.Size(136, 62);
            this.rightON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightON.TabIndex = 1;
            this.rightON.TabStop = false;
            this.rightON.Visible = false;
            this.rightON.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // leftOFF
            // 
            this.leftOFF.Image = ((System.Drawing.Image)(resources.GetObject("leftOFF.Image")));
            this.leftOFF.Location = new System.Drawing.Point(64, 28);
            this.leftOFF.Name = "leftOFF";
            this.leftOFF.Size = new System.Drawing.Size(136, 62);
            this.leftOFF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftOFF.TabIndex = 3;
            this.leftOFF.TabStop = false;
            // 
            // leftON
            // 
            this.leftON.Image = ((System.Drawing.Image)(resources.GetObject("leftON.Image")));
            this.leftON.Location = new System.Drawing.Point(64, 28);
            this.leftON.Name = "leftON";
            this.leftON.Size = new System.Drawing.Size(136, 62);
            this.leftON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftON.TabIndex = 5;
            this.leftON.TabStop = false;
            this.leftON.Visible = false;
            this.leftON.Click += new System.EventHandler(this.leftON_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(353, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 80);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(222, 115);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(378, 197);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // leftturnstick
            // 
            this.leftturnstick.Image = ((System.Drawing.Image)(resources.GetObject("leftturnstick.Image")));
            this.leftturnstick.Location = new System.Drawing.Point(92, 285);
            this.leftturnstick.Name = "leftturnstick";
            this.leftturnstick.Size = new System.Drawing.Size(72, 45);
            this.leftturnstick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftturnstick.TabIndex = 8;
            this.leftturnstick.TabStop = false;
            this.leftturnstick.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // rightturnstick
            // 
            this.rightturnstick.Image = ((System.Drawing.Image)(resources.GetObject("rightturnstick.Image")));
            this.rightturnstick.Location = new System.Drawing.Point(92, 177);
            this.rightturnstick.Name = "rightturnstick";
            this.rightturnstick.Size = new System.Drawing.Size(72, 48);
            this.rightturnstick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightturnstick.TabIndex = 9;
            this.rightturnstick.TabStop = false;
            this.rightturnstick.Click += new System.EventHandler(this.rightturnstick_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(92, 231);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BrakeLON
            // 
            this.BrakeLON.Image = ((System.Drawing.Image)(resources.GetObject("BrakeLON.Image")));
            this.BrakeLON.Location = new System.Drawing.Point(17, 351);
            this.BrakeLON.Name = "BrakeLON";
            this.BrakeLON.Size = new System.Drawing.Size(147, 87);
            this.BrakeLON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BrakeLON.TabIndex = 11;
            this.BrakeLON.TabStop = false;
            this.BrakeLON.Visible = false;
            // 
            // BrakeRON
            // 
            this.BrakeRON.Image = ((System.Drawing.Image)(resources.GetObject("BrakeRON.Image")));
            this.BrakeRON.Location = new System.Drawing.Point(626, 351);
            this.BrakeRON.Name = "BrakeRON";
            this.BrakeRON.Size = new System.Drawing.Size(147, 87);
            this.BrakeRON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BrakeRON.TabIndex = 12;
            this.BrakeRON.TabStop = false;
            this.BrakeRON.Visible = false;
            // 
            // BrakePedal
            // 
            this.BrakePedal.Image = ((System.Drawing.Image)(resources.GetObject("BrakePedal.Image")));
            this.BrakePedal.Location = new System.Drawing.Point(297, 336);
            this.BrakePedal.Name = "BrakePedal";
            this.BrakePedal.Size = new System.Drawing.Size(83, 102);
            this.BrakePedal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BrakePedal.TabIndex = 13;
            this.BrakePedal.TabStop = false;
            this.BrakePedal.MouseEnter += new System.EventHandler(this.BrakesON);
            this.BrakePedal.MouseLeave += new System.EventHandler(this.BrakesOFF);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(17, 351);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(147, 87);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 14;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(626, 351);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(147, 87);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 15;
            this.pictureBox8.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BrakeRON);
            this.Controls.Add(this.BrakeLON);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.BrakePedal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rightturnstick);
            this.Controls.Add(this.leftturnstick);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.leftON);
            this.Controls.Add(this.leftOFF);
            this.Controls.Add(this.rightON);
            this.Controls.Add(this.rightOFF);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rightOFF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftOFF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftturnstick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightturnstick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrakeLON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrakeRON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrakePedal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox rightOFF;
        private System.Windows.Forms.PictureBox rightON;
        private System.Windows.Forms.PictureBox leftOFF;
        private System.Windows.Forms.PictureBox leftON;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox leftturnstick;
        private System.Windows.Forms.PictureBox rightturnstick;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox BrakeLON;
        private System.Windows.Forms.PictureBox BrakeRON;
        private System.Windows.Forms.PictureBox BrakePedal;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}

