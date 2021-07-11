namespace OpenCvHW
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imgMorph = new Emgu.CV.UI.ImageBox();
            this.imgContour = new Emgu.CV.UI.ImageBox();
            this.imgBinary = new Emgu.CV.UI.ImageBox();
            this.ImgBlurred = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgMorph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgContour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBinary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBlurred)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(476, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "contour";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "morphology";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "binary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "preprocessing";
            // 
            // imgMorph
            // 
            this.imgMorph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgMorph.Location = new System.Drawing.Point(46, 311);
            this.imgMorph.Name = "imgMorph";
            this.imgMorph.Size = new System.Drawing.Size(390, 266);
            this.imgMorph.TabIndex = 13;
            this.imgMorph.TabStop = false;
            // 
            // imgContour
            // 
            this.imgContour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgContour.Location = new System.Drawing.Point(479, 311);
            this.imgContour.Name = "imgContour";
            this.imgContour.Size = new System.Drawing.Size(390, 266);
            this.imgContour.TabIndex = 12;
            this.imgContour.TabStop = false;
            // 
            // imgBinary
            // 
            this.imgBinary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgBinary.Location = new System.Drawing.Point(479, 23);
            this.imgBinary.Name = "imgBinary";
            this.imgBinary.Size = new System.Drawing.Size(390, 266);
            this.imgBinary.TabIndex = 11;
            this.imgBinary.TabStop = false;
            // 
            // ImgBlurred
            // 
            this.ImgBlurred.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgBlurred.Location = new System.Drawing.Point(46, 23);
            this.ImgBlurred.Name = "ImgBlurred";
            this.ImgBlurred.Size = new System.Drawing.Size(390, 266);
            this.ImgBlurred.TabIndex = 10;
            this.ImgBlurred.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 580);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgMorph);
            this.Controls.Add(this.imgContour);
            this.Controls.Add(this.imgBinary);
            this.Controls.Add(this.ImgBlurred);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgMorph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgContour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBinary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBlurred)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Emgu.CV.UI.ImageBox imgMorph;
        private Emgu.CV.UI.ImageBox imgContour;
        private Emgu.CV.UI.ImageBox imgBinary;
        private Emgu.CV.UI.ImageBox ImgBlurred;
    }
}

