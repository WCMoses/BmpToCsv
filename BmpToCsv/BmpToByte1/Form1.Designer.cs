namespace BmpToByte1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtOutputFilePath = new System.Windows.Forms.TextBox();
            this.txtImageFilePath = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 90);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create CSV";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblWidth);
            this.splitContainer1.Panel1.Controls.Add(this.lblHeight);
            this.splitContainer1.Panel1.Controls.Add(this.txtOutputFilePath);
            this.splitContainer1.Panel1.Controls.Add(this.txtImageFilePath);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1634, 831);
            this.splitContainer1.SplitterDistance = 665;
            this.splitContainer1.TabIndex = 1;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(302, 432);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(151, 37);
            this.lblWidth.TabIndex = 4;
            this.lblWidth.Text = "Width:XX";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(70, 432);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(160, 37);
            this.lblHeight.TabIndex = 3;
            this.lblHeight.Text = "Height:XX";
            // 
            // txtOutputFilePath
            // 
            this.txtOutputFilePath.Location = new System.Drawing.Point(59, 171);
            this.txtOutputFilePath.Name = "txtOutputFilePath";
            this.txtOutputFilePath.Size = new System.Drawing.Size(557, 44);
            this.txtOutputFilePath.TabIndex = 2;
            this.txtOutputFilePath.Text = "c:\\Images\\output1.csv";
            // 
            // txtImageFilePath
            // 
            this.txtImageFilePath.Location = new System.Drawing.Point(59, 56);
            this.txtImageFilePath.Name = "txtImageFilePath";
            this.txtImageFilePath.Size = new System.Drawing.Size(557, 44);
            this.txtImageFilePath.TabIndex = 1;
            this.txtImageFilePath.Text = "c:\\Images\\20x20.bmp";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(965, 831);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1634, 831);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtOutputFilePath;
        private System.Windows.Forms.TextBox txtImageFilePath;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWidth;
    }
}

