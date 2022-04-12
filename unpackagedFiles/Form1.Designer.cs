namespace CandyCrush
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_red = new System.Windows.Forms.Button();
            this.btn_blue = new System.Windows.Forms.Button();
            this.btn_yellow = new System.Windows.Forms.Button();
            this.btn_brown = new System.Windows.Forms.Button();
            this.btn_purple = new System.Windows.Forms.Button();
            this.btn_green = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_moveCounter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 426);
            this.panel1.TabIndex = 0;
            // 
            // btn_red
            // 
            this.btn_red.BackColor = System.Drawing.Color.LightCoral;
            this.btn_red.Location = new System.Drawing.Point(682, 77);
            this.btn_red.Name = "btn_red";
            this.btn_red.Size = new System.Drawing.Size(25, 25);
            this.btn_red.TabIndex = 1;
            this.btn_red.UseVisualStyleBackColor = false;
            this.btn_red.Click += new System.EventHandler(this.colorButton_Click);
            this.btn_red.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // btn_blue
            // 
            this.btn_blue.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_blue.Location = new System.Drawing.Point(744, 77);
            this.btn_blue.Name = "btn_blue";
            this.btn_blue.Size = new System.Drawing.Size(25, 25);
            this.btn_blue.TabIndex = 4;
            this.btn_blue.UseVisualStyleBackColor = false;
            this.btn_blue.Click += new System.EventHandler(this.colorButton_Click);
            this.btn_blue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // btn_yellow
            // 
            this.btn_yellow.BackColor = System.Drawing.Color.Gold;
            this.btn_yellow.Location = new System.Drawing.Point(713, 77);
            this.btn_yellow.Name = "btn_yellow";
            this.btn_yellow.Size = new System.Drawing.Size(25, 25);
            this.btn_yellow.TabIndex = 5;
            this.btn_yellow.UseVisualStyleBackColor = false;
            this.btn_yellow.Click += new System.EventHandler(this.colorButton_Click);
            this.btn_yellow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // btn_brown
            // 
            this.btn_brown.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_brown.Location = new System.Drawing.Point(713, 108);
            this.btn_brown.Name = "btn_brown";
            this.btn_brown.Size = new System.Drawing.Size(25, 25);
            this.btn_brown.TabIndex = 10;
            this.btn_brown.UseVisualStyleBackColor = false;
            this.btn_brown.Click += new System.EventHandler(this.colorButton_Click);
            this.btn_brown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // btn_purple
            // 
            this.btn_purple.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_purple.Location = new System.Drawing.Point(744, 108);
            this.btn_purple.Name = "btn_purple";
            this.btn_purple.Size = new System.Drawing.Size(25, 25);
            this.btn_purple.TabIndex = 9;
            this.btn_purple.UseVisualStyleBackColor = false;
            this.btn_purple.Click += new System.EventHandler(this.colorButton_Click);
            this.btn_purple.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // btn_green
            // 
            this.btn_green.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_green.Location = new System.Drawing.Point(682, 108);
            this.btn_green.Name = "btn_green";
            this.btn_green.Size = new System.Drawing.Size(25, 25);
            this.btn_green.TabIndex = 6;
            this.btn_green.UseVisualStyleBackColor = false;
            this.btn_green.Click += new System.EventHandler(this.colorButton_Click);
            this.btn_green.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.LightGray;
            this.btn_reset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_reset.BackgroundImage")));
            this.btn_reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_reset.Location = new System.Drawing.Point(670, 315);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(118, 32);
            this.btn_reset.TabIndex = 11;
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            this.btn_reset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(670, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 23);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_moveCounter
            // 
            this.lbl_moveCounter.AutoSize = true;
            this.lbl_moveCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_moveCounter.Location = new System.Drawing.Point(678, 40);
            this.lbl_moveCounter.Name = "lbl_moveCounter";
            this.lbl_moveCounter.Size = new System.Drawing.Size(80, 20);
            this.lbl_moveCounter.TabIndex = 13;
            this.lbl_moveCounter.Text = "Moves: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_moveCounter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_brown);
            this.Controls.Add(this.btn_purple);
            this.Controls.Add(this.btn_green);
            this.Controls.Add(this.btn_yellow);
            this.Controls.Add(this.btn_blue);
            this.Controls.Add(this.btn_red);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Candy Crush";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_red;
        private System.Windows.Forms.Button btn_blue;
        private System.Windows.Forms.Button btn_yellow;
        private System.Windows.Forms.Button btn_brown;
        private System.Windows.Forms.Button btn_purple;
        private System.Windows.Forms.Button btn_green;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_moveCounter;
    }
}

