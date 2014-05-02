namespace LineEntityGenerationCG
{
    partial class CanvasForm
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.radioDDA = new System.Windows.Forms.RadioButton();
            this.radioBresenham = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpixel = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDraw = new System.Windows.Forms.Button();
            this.txtTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(156, 71);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(460, 301);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // radioDDA
            // 
            this.radioDDA.AutoSize = true;
            this.radioDDA.Checked = true;
            this.radioDDA.Location = new System.Drawing.Point(251, 35);
            this.radioDDA.Name = "radioDDA";
            this.radioDDA.Size = new System.Drawing.Size(41, 16);
            this.radioDDA.TabIndex = 2;
            this.radioDDA.TabStop = true;
            this.radioDDA.Text = "DDA";
            this.radioDDA.UseVisualStyleBackColor = true;
            // 
            // radioBresenham
            // 
            this.radioBresenham.AutoSize = true;
            this.radioBresenham.Location = new System.Drawing.Point(298, 35);
            this.radioBresenham.Name = "radioBresenham";
            this.radioBresenham.Size = new System.Drawing.Size(77, 16);
            this.radioBresenham.TabIndex = 3;
            this.radioBresenham.TabStop = true;
            this.radioBresenham.Text = "Bresenham";
            this.radioBresenham.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Algorithm";
            // 
            // txtpixel
            // 
            this.txtpixel.Location = new System.Drawing.Point(34, 71);
            this.txtpixel.Multiline = true;
            this.txtpixel.Name = "txtpixel";
            this.txtpixel.Size = new System.Drawing.Size(116, 301);
            this.txtpixel.TabIndex = 4;
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(34, 32);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(58, 21);
            this.txtFrom.TabIndex = 5;
            this.txtFrom.Text = "0,0";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(122, 32);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(58, 21);
            this.txtTo.TabIndex = 6;
            this.txtTo.Text = "19,19";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "->";
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(381, 32);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 8;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(471, 32);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 21);
            this.txtTime.TabIndex = 9;
            // 
            // CanvasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 440);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.txtpixel);
            this.Controls.Add(this.radioBresenham);
            this.Controls.Add(this.radioDDA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox);
            this.Name = "CanvasForm";
            this.Text = "CanvasForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioDDA;
        private System.Windows.Forms.RadioButton radioBresenham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpixel;
        public System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.TextBox txtTime;
    }
}