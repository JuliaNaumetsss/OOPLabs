namespace OOP
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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DrawFoursquare = new System.Windows.Forms.Button();
            this.x1 = new System.Windows.Forms.TextBox();
            this.y1 = new System.Windows.Forms.TextBox();
            this.side1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DrawRectangle = new System.Windows.Forms.Button();
            this.x2 = new System.Windows.Forms.TextBox();
            this.y2 = new System.Windows.Forms.TextBox();
            this.side3 = new System.Windows.Forms.TextBox();
            this.side2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DrawParallelogram = new System.Windows.Forms.Button();
            this.x3 = new System.Windows.Forms.TextBox();
            this.y3 = new System.Windows.Forms.TextBox();
            this.x4 = new System.Windows.Forms.TextBox();
            this.y4 = new System.Windows.Forms.TextBox();
            this.side4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labelll = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.DrawCircle = new System.Windows.Forms.Button();
            this.Xc = new System.Windows.Forms.TextBox();
            this.Yc = new System.Windows.Forms.TextBox();
            this.radius = new System.Windows.Forms.TextBox();
            this.DrawTriangle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(701, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Draw";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 356);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // DrawFoursquare
            // 
            this.DrawFoursquare.Location = new System.Drawing.Point(678, 31);
            this.DrawFoursquare.Name = "DrawFoursquare";
            this.DrawFoursquare.Size = new System.Drawing.Size(122, 24);
            this.DrawFoursquare.TabIndex = 3;
            this.DrawFoursquare.Text = "Draw Foursquare";
            this.DrawFoursquare.UseVisualStyleBackColor = true;
            this.DrawFoursquare.Click += new System.EventHandler(this.DrawFoursquare_Click);
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(445, 31);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(61, 20);
            this.x1.TabIndex = 4;
            this.x1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.x1_KeyPress);
            // 
            // y1
            // 
            this.y1.Location = new System.Drawing.Point(524, 31);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(61, 20);
            this.y1.TabIndex = 5;
            this.y1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.y1_KeyPress);
            // 
            // side1
            // 
            this.side1.Location = new System.Drawing.Point(613, 32);
            this.side1.Name = "side1";
            this.side1.Size = new System.Drawing.Size(53, 20);
            this.side1.TabIndex = 6;
            this.side1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.side1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(452, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(529, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(615, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "side";
            // 
            // DrawRectangle
            // 
            this.DrawRectangle.Location = new System.Drawing.Point(678, 69);
            this.DrawRectangle.Name = "DrawRectangle";
            this.DrawRectangle.Size = new System.Drawing.Size(121, 23);
            this.DrawRectangle.TabIndex = 10;
            this.DrawRectangle.Text = "Draw Rectangle";
            this.DrawRectangle.UseVisualStyleBackColor = true;
            this.DrawRectangle.Click += new System.EventHandler(this.DrawRectangle_Click);
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(375, 69);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(62, 20);
            this.x2.TabIndex = 11;
            this.x2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.x2_KeyPress);
            // 
            // y2
            // 
            this.y2.Location = new System.Drawing.Point(455, 69);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(62, 20);
            this.y2.TabIndex = 12;
            this.y2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.y2_KeyPress);
            // 
            // side3
            // 
            this.side3.Location = new System.Drawing.Point(610, 69);
            this.side3.Name = "side3";
            this.side3.Size = new System.Drawing.Size(62, 20);
            this.side3.TabIndex = 13;
            this.side3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.side3_KeyPress);
            // 
            // side2
            // 
            this.side2.Location = new System.Drawing.Point(532, 69);
            this.side2.Name = "side2";
            this.side2.Size = new System.Drawing.Size(62, 20);
            this.side2.TabIndex = 14;
            this.side2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.side2_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "x";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(478, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(559, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "side";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(627, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "side";
            // 
            // DrawParallelogram
            // 
            this.DrawParallelogram.Location = new System.Drawing.Point(688, 143);
            this.DrawParallelogram.Name = "DrawParallelogram";
            this.DrawParallelogram.Size = new System.Drawing.Size(121, 23);
            this.DrawParallelogram.TabIndex = 19;
            this.DrawParallelogram.Text = "Draw Parallelogram";
            this.DrawParallelogram.UseVisualStyleBackColor = true;
            this.DrawParallelogram.Click += new System.EventHandler(this.DrawParallelogram_Click);
            // 
            // x3
            // 
            this.x3.Location = new System.Drawing.Point(350, 119);
            this.x3.Name = "x3";
            this.x3.Size = new System.Drawing.Size(62, 20);
            this.x3.TabIndex = 20;
            this.x3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.x3_KeyPress);
            // 
            // y3
            // 
            this.y3.Location = new System.Drawing.Point(350, 163);
            this.y3.Name = "y3";
            this.y3.Size = new System.Drawing.Size(62, 20);
            this.y3.TabIndex = 21;
            this.y3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.y3_KeyPress);
            // 
            // x4
            // 
            this.x4.Location = new System.Drawing.Point(445, 118);
            this.x4.Name = "x4";
            this.x4.Size = new System.Drawing.Size(62, 20);
            this.x4.TabIndex = 22;
            this.x4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.x4_KeyPress);
            // 
            // y4
            // 
            this.y4.Location = new System.Drawing.Point(444, 163);
            this.y4.Name = "y4";
            this.y4.Size = new System.Drawing.Size(62, 20);
            this.y4.TabIndex = 23;
            this.y4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.y4_KeyPress);
            // 
            // side4
            // 
            this.side4.Location = new System.Drawing.Point(532, 163);
            this.side4.Name = "side4";
            this.side4.Size = new System.Drawing.Size(62, 20);
            this.side4.TabIndex = 25;
            this.side4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.y5_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(372, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "x";
            // 
            // labelll
            // 
            this.labelll.AutoSize = true;
            this.labelll.Location = new System.Drawing.Point(469, 103);
            this.labelll.Name = "labelll";
            this.labelll.Size = new System.Drawing.Size(12, 13);
            this.labelll.TabIndex = 29;
            this.labelll.Text = "x";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(372, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "y";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(469, 143);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(12, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "y";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(559, 148);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "side";
            // 
            // DrawCircle
            // 
            this.DrawCircle.Location = new System.Drawing.Point(688, 261);
            this.DrawCircle.Name = "DrawCircle";
            this.DrawCircle.Size = new System.Drawing.Size(121, 23);
            this.DrawCircle.TabIndex = 36;
            this.DrawCircle.Text = "Draw Circle";
            this.DrawCircle.UseVisualStyleBackColor = true;
            this.DrawCircle.Click += new System.EventHandler(this.DrawCircle_Click);
            // 
            // Xc
            // 
            this.Xc.Location = new System.Drawing.Point(350, 261);
            this.Xc.Name = "Xc";
            this.Xc.Size = new System.Drawing.Size(62, 20);
            this.Xc.TabIndex = 37;
            this.Xc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Xc_KeyPress);
            // 
            // Yc
            // 
            this.Yc.Location = new System.Drawing.Point(445, 261);
            this.Yc.Name = "Yc";
            this.Yc.Size = new System.Drawing.Size(62, 20);
            this.Yc.TabIndex = 38;
            this.Yc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Yc_KeyPress);
            // 
            // radius
            // 
            this.radius.Location = new System.Drawing.Point(544, 264);
            this.radius.Name = "radius";
            this.radius.Size = new System.Drawing.Size(62, 20);
            this.radius.TabIndex = 39;
            this.radius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.radius_KeyPress);
            // 
            // DrawTriangle
            // 
            this.DrawTriangle.Location = new System.Drawing.Point(688, 205);
            this.DrawTriangle.Name = "DrawTriangle";
            this.DrawTriangle.Size = new System.Drawing.Size(121, 23);
            this.DrawTriangle.TabIndex = 40;
            this.DrawTriangle.Text = "Draw Triangle";
            this.DrawTriangle.UseVisualStyleBackColor = true;
            this.DrawTriangle.Click += new System.EventHandler(this.DrawTriangle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 380);
            this.Controls.Add(this.DrawTriangle);
            this.Controls.Add(this.radius);
            this.Controls.Add(this.Yc);
            this.Controls.Add(this.Xc);
            this.Controls.Add(this.DrawCircle);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.labelll);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.side4);
            this.Controls.Add(this.y4);
            this.Controls.Add(this.x4);
            this.Controls.Add(this.y3);
            this.Controls.Add(this.x3);
            this.Controls.Add(this.DrawParallelogram);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.side2);
            this.Controls.Add(this.side3);
            this.Controls.Add(this.y2);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.DrawRectangle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.side1);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.DrawFoursquare);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Draw Figures";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button DrawFoursquare;
        private System.Windows.Forms.TextBox x1;
        private System.Windows.Forms.TextBox y1;
        private System.Windows.Forms.TextBox side1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DrawRectangle;
        private System.Windows.Forms.TextBox x2;
        private System.Windows.Forms.TextBox y2;
        private System.Windows.Forms.TextBox side3;
        private System.Windows.Forms.TextBox side2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button DrawParallelogram;
        private System.Windows.Forms.TextBox x3;
        private System.Windows.Forms.TextBox y3;
        private System.Windows.Forms.TextBox x4;
        private System.Windows.Forms.TextBox y4;
        private System.Windows.Forms.TextBox side4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelll;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button DrawCircle;
        private System.Windows.Forms.TextBox Xc;
        private System.Windows.Forms.TextBox Yc;
        private System.Windows.Forms.TextBox radius;
        private System.Windows.Forms.Button DrawTriangle;
    }
}