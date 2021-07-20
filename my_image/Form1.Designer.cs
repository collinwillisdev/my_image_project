
namespace my_image
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
            this.button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pgsPixels = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdLoadImage = new System.Windows.Forms.OpenFileDialog();
            this.pcBox2 = new System.Windows.Forms.PictureBox();
            this.RedPixBox = new System.Windows.Forms.TextBox();
            this.redPercent = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(299, 362);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 61);
            this.button.TabIndex = 1;
            this.button.Text = "Make";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pgsPixels
            // 
            this.pgsPixels.Location = new System.Drawing.Point(618, 362);
            this.pgsPixels.Name = "pgsPixels";
            this.pgsPixels.Size = new System.Drawing.Size(129, 23);
            this.pgsPixels.TabIndex = 3;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(668, 344);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(35, 13);
            this.lblProgress.TabIndex = 4;
            this.lblProgress.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // ofdLoadImage
            // 
            this.ofdLoadImage.FileName = "openFileDialog1";
            this.ofdLoadImage.Filter = "PNG Files| *.png";
            // 
            // pcBox2
            // 
            this.pcBox2.BackColor = System.Drawing.Color.Red;
            this.pcBox2.Location = new System.Drawing.Point(525, 385);
            this.pcBox2.Name = "pcBox2";
            this.pcBox2.Size = new System.Drawing.Size(55, 42);
            this.pcBox2.TabIndex = 6;
            this.pcBox2.TabStop = false;
            // 
            // RedPixBox
            // 
            this.RedPixBox.Location = new System.Drawing.Point(618, 391);
            this.RedPixBox.Name = "RedPixBox";
            this.RedPixBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.RedPixBox.Size = new System.Drawing.Size(129, 20);
            this.RedPixBox.TabIndex = 7;
            // 
            // redPercent
            // 
            this.redPercent.Location = new System.Drawing.Point(618, 418);
            this.redPercent.Name = "redPercent";
            this.redPercent.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.redPercent.Size = new System.Drawing.Size(129, 20);
            this.redPercent.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(429, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(318, 239);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.redPercent);
            this.Controls.Add(this.RedPixBox);
            this.Controls.Add(this.pcBox2);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.pgsPixels);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar pgsPixels;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofdLoadImage;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pcBox2;
        private System.Windows.Forms.TextBox RedPixBox;
        private System.Windows.Forms.TextBox redPercent;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

