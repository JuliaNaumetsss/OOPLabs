﻿namespace OOP
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DrawFoursquare = new System.Windows.Forms.Button();
            this.x1 = new System.Windows.Forms.TextBox();
            this.y1 = new System.Windows.Forms.TextBox();
            this.DrawRectangle = new System.Windows.Forms.Button();
            this.x2 = new System.Windows.Forms.TextBox();
            this.y2 = new System.Windows.Forms.TextBox();
            this.DrawParallelogram = new System.Windows.Forms.Button();
            this.parametr1 = new System.Windows.Forms.TextBox();
            this.parametr2 = new System.Windows.Forms.TextBox();
            this.DrawCircle = new System.Windows.Forms.Button();
            this.DrawTriangle = new System.Windows.Forms.Button();
            this.RBFoursquare = new System.Windows.Forms.RadioButton();
            this.RBRectangle = new System.Windows.Forms.RadioButton();
            this.RBParallelogram = new System.Windows.Forms.RadioButton();
            this.RBTriangle = new System.Windows.Forms.RadioButton();
            this.RBCircle = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CleanCoord = new System.Windows.Forms.Button();
            this.CleanField = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(474, 356);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // DrawFoursquare
            // 
            this.DrawFoursquare.Location = new System.Drawing.Point(757, 28);
            this.DrawFoursquare.Name = "DrawFoursquare";
            this.DrawFoursquare.Size = new System.Drawing.Size(121, 24);
            this.DrawFoursquare.TabIndex = 3;
            this.DrawFoursquare.Text = "Draw Foursquare";
            this.DrawFoursquare.UseVisualStyleBackColor = true;
            this.DrawFoursquare.Visible = false;
            this.DrawFoursquare.Click += new System.EventHandler(this.DrawFoursquare_Click);
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(562, 29);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(61, 20);
            this.x1.TabIndex = 4;
            this.x1.Visible = false;
            this.x1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.x1_KeyPress);
            // 
            // y1
            // 
            this.y1.Location = new System.Drawing.Point(672, 29);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(61, 20);
            this.y1.TabIndex = 5;
            this.y1.Visible = false;
            this.y1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.y1_KeyPress);
            // 
            // DrawRectangle
            // 
            this.DrawRectangle.Location = new System.Drawing.Point(757, 69);
            this.DrawRectangle.Name = "DrawRectangle";
            this.DrawRectangle.Size = new System.Drawing.Size(121, 23);
            this.DrawRectangle.TabIndex = 10;
            this.DrawRectangle.Text = "Draw Rectangle";
            this.DrawRectangle.UseVisualStyleBackColor = true;
            this.DrawRectangle.Visible = false;
            this.DrawRectangle.Click += new System.EventHandler(this.DrawRectangle_Click);
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(562, 98);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(62, 20);
            this.x2.TabIndex = 11;
            this.x2.Visible = false;
            this.x2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.x2_KeyPress);
            // 
            // y2
            // 
            this.y2.Location = new System.Drawing.Point(672, 95);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(62, 20);
            this.y2.TabIndex = 12;
            this.y2.Visible = false;
            this.y2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.y2_KeyPress);
            // 
            // DrawParallelogram
            // 
            this.DrawParallelogram.Location = new System.Drawing.Point(757, 107);
            this.DrawParallelogram.Name = "DrawParallelogram";
            this.DrawParallelogram.Size = new System.Drawing.Size(121, 23);
            this.DrawParallelogram.TabIndex = 19;
            this.DrawParallelogram.Text = "Draw Parallelogram";
            this.DrawParallelogram.UseVisualStyleBackColor = true;
            this.DrawParallelogram.Visible = false;
            this.DrawParallelogram.Click += new System.EventHandler(this.DrawParallelogram_Click);
            // 
            // parametr1
            // 
            this.parametr1.Location = new System.Drawing.Point(562, 172);
            this.parametr1.Name = "parametr1";
            this.parametr1.Size = new System.Drawing.Size(62, 20);
            this.parametr1.TabIndex = 20;
            this.parametr1.Visible = false;
            this.parametr1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.parametr1_KeyPress);
            // 
            // parametr2
            // 
            this.parametr2.Location = new System.Drawing.Point(672, 172);
            this.parametr2.Name = "parametr2";
            this.parametr2.Size = new System.Drawing.Size(62, 20);
            this.parametr2.TabIndex = 22;
            this.parametr2.Visible = false;
            this.parametr2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.parametr2_KeyPress);
            // 
            // DrawCircle
            // 
            this.DrawCircle.Location = new System.Drawing.Point(757, 184);
            this.DrawCircle.Name = "DrawCircle";
            this.DrawCircle.Size = new System.Drawing.Size(121, 23);
            this.DrawCircle.TabIndex = 36;
            this.DrawCircle.Text = "Draw Circle";
            this.DrawCircle.UseVisualStyleBackColor = true;
            this.DrawCircle.Visible = false;
            this.DrawCircle.Click += new System.EventHandler(this.DrawCircle_Click);
            // 
            // DrawTriangle
            // 
            this.DrawTriangle.Location = new System.Drawing.Point(757, 146);
            this.DrawTriangle.Name = "DrawTriangle";
            this.DrawTriangle.Size = new System.Drawing.Size(121, 23);
            this.DrawTriangle.TabIndex = 40;
            this.DrawTriangle.Text = "Draw Triangle";
            this.DrawTriangle.UseVisualStyleBackColor = true;
            this.DrawTriangle.Visible = false;
            this.DrawTriangle.Click += new System.EventHandler(this.DrawTriangle_Click);
            // 
            // RBFoursquare
            // 
            this.RBFoursquare.AutoSize = true;
            this.RBFoursquare.Location = new System.Drawing.Point(522, 336);
            this.RBFoursquare.Name = "RBFoursquare";
            this.RBFoursquare.Size = new System.Drawing.Size(78, 17);
            this.RBFoursquare.TabIndex = 56;
            this.RBFoursquare.TabStop = true;
            this.RBFoursquare.Text = "Foursquare";
            this.RBFoursquare.UseVisualStyleBackColor = true;
            this.RBFoursquare.Click += new System.EventHandler(this.RBFoursquare_Click);
            // 
            // RBRectangle
            // 
            this.RBRectangle.AutoSize = true;
            this.RBRectangle.Location = new System.Drawing.Point(606, 336);
            this.RBRectangle.Name = "RBRectangle";
            this.RBRectangle.Size = new System.Drawing.Size(74, 17);
            this.RBRectangle.TabIndex = 57;
            this.RBRectangle.TabStop = true;
            this.RBRectangle.Text = "Rectangle";
            this.RBRectangle.UseVisualStyleBackColor = true;
            this.RBRectangle.Click += new System.EventHandler(this.RBRectangle_Click);
            // 
            // RBParallelogram
            // 
            this.RBParallelogram.AutoSize = true;
            this.RBParallelogram.Location = new System.Drawing.Point(686, 336);
            this.RBParallelogram.Name = "RBParallelogram";
            this.RBParallelogram.Size = new System.Drawing.Size(88, 17);
            this.RBParallelogram.TabIndex = 58;
            this.RBParallelogram.TabStop = true;
            this.RBParallelogram.Text = "Parallelogram";
            this.RBParallelogram.UseVisualStyleBackColor = true;
            this.RBParallelogram.Click += new System.EventHandler(this.RBParallelogram_Click);
            // 
            // RBTriangle
            // 
            this.RBTriangle.AutoSize = true;
            this.RBTriangle.Location = new System.Drawing.Point(780, 336);
            this.RBTriangle.Name = "RBTriangle";
            this.RBTriangle.Size = new System.Drawing.Size(63, 17);
            this.RBTriangle.TabIndex = 59;
            this.RBTriangle.TabStop = true;
            this.RBTriangle.Text = "Triangle";
            this.RBTriangle.UseVisualStyleBackColor = true;
            this.RBTriangle.Click += new System.EventHandler(this.RBTriangle_Click);
            // 
            // RBCircle
            // 
            this.RBCircle.AutoSize = true;
            this.RBCircle.Location = new System.Drawing.Point(849, 336);
            this.RBCircle.Name = "RBCircle";
            this.RBCircle.Size = new System.Drawing.Size(51, 17);
            this.RBCircle.TabIndex = 60;
            this.RBCircle.TabStop = true;
            this.RBCircle.Text = "Circle";
            this.RBCircle.UseVisualStyleBackColor = true;
            this.RBCircle.Click += new System.EventHandler(this.RBCircle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(571, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "x1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(571, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "x2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(691, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "y1";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(691, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "y2";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(571, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "x3";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(669, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 66;
            this.label6.Text = "y3";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(595, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 67;
            this.label7.Text = "side1";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(706, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 68;
            this.label8.Text = "side2";
            this.label8.Visible = false;
            // 
            // CleanCoord
            // 
            this.CleanCoord.Location = new System.Drawing.Point(686, 259);
            this.CleanCoord.Name = "CleanCoord";
            this.CleanCoord.Size = new System.Drawing.Size(99, 35);
            this.CleanCoord.TabIndex = 69;
            this.CleanCoord.Text = "Clean coordinates";
            this.CleanCoord.UseVisualStyleBackColor = true;
            this.CleanCoord.Click += new System.EventHandler(this.CleanCoord_Click);
            // 
            // CleanField
            // 
            this.CleanField.Location = new System.Drawing.Point(551, 259);
            this.CleanField.Name = "CleanField";
            this.CleanField.Size = new System.Drawing.Size(89, 35);
            this.CleanField.TabIndex = 70;
            this.CleanField.Text = "Clean drawing field";
            this.CleanField.UseVisualStyleBackColor = true;
            this.CleanField.Click += new System.EventHandler(this.CleanField_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 380);
            this.Controls.Add(this.CleanField);
            this.Controls.Add(this.CleanCoord);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RBCircle);
            this.Controls.Add(this.RBTriangle);
            this.Controls.Add(this.RBParallelogram);
            this.Controls.Add(this.RBRectangle);
            this.Controls.Add(this.RBFoursquare);
            this.Controls.Add(this.DrawTriangle);
            this.Controls.Add(this.DrawCircle);
            this.Controls.Add(this.parametr2);
            this.Controls.Add(this.parametr1);
            this.Controls.Add(this.DrawParallelogram);
            this.Controls.Add(this.y2);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.DrawRectangle);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.DrawFoursquare);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Draw Figures";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button DrawFoursquare;
        private System.Windows.Forms.TextBox x1;
        private System.Windows.Forms.TextBox y1;
        private System.Windows.Forms.Button DrawRectangle;
        private System.Windows.Forms.TextBox x2;
        private System.Windows.Forms.TextBox y2;
        private System.Windows.Forms.Button DrawParallelogram;
        private System.Windows.Forms.TextBox parametr1;
        private System.Windows.Forms.TextBox parametr2;
        private System.Windows.Forms.Button DrawCircle;
        private System.Windows.Forms.Button DrawTriangle;
        private System.Windows.Forms.RadioButton RBFoursquare;
        private System.Windows.Forms.RadioButton RBRectangle;
        private System.Windows.Forms.RadioButton RBParallelogram;
        private System.Windows.Forms.RadioButton RBTriangle;
        private System.Windows.Forms.RadioButton RBCircle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button CleanCoord;
        private System.Windows.Forms.Button CleanField;
    }
}