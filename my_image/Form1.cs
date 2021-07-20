using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace my_image
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Bitmap bmpImage = (Bitmap)pictureBox1.Image;
            Bitmap bmpPic = new Bitmap(bmpImage.Width, bmpImage.Height);
            Color colCurrent;
            string pixelInfo = "";
            int currentPixel = 1;
            double RedPix = 0;
            
            

            double maxPixels = bmpImage.Height * bmpImage.Width;



            pgsPixels.Maximum =(int)maxPixels + 1;

            pgsPixels.Value = 0;

           

            //Walk over every pixel in the bitmap
            for (int y = 0; y < bmpImage.Height; y++)
            {
                for (int x = 0; x < bmpImage.Width; x++)
                {
                    colCurrent = bmpImage.GetPixel(x, y);

                    pixelInfo = string.Format("Pixel{5:00000} Coord = [{0:00}, {1:00}] - Color RGB  =   [{2:000}, {3:000}, {4:000}])", x, y, colCurrent.R, colCurrent.G, colCurrent.B, currentPixel);

                    currentPixel++;

                    pgsPixels.Value = currentPixel;

                   

                    if (colCurrent.R > 103 && colCurrent.G < 31 && colCurrent.B < 74)
                    {
                        RedPix++;
                        bmpPic.SetPixel(x, y, colCurrent);

                    }
                   
                    

                  
                    
                }
                pictureBox2.Image = bmpPic;
                

                lblProgress.Text = string.Format("{0}/{1} pixels processed", currentPixel, maxPixels);
                Application.DoEvents();

                
            }
            double redPercentage = RedPix / maxPixels * 100;
            RedPixBox.Text = string.Format("there are {0} red pixels",RedPix);
            redPercent.Text = string.Format("there is a percentage of {0} red pixels",redPercentage);
            pictureBox1.Image = bmpImage;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dgrTemp = ofdLoadImage.ShowDialog();

            if(dgrTemp == DialogResult.OK)
            {
                Bitmap bmpTemp = new Bitmap(ofdLoadImage.FileName);

                pictureBox1.Image = bmpTemp;
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
       
}
