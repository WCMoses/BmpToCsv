using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace BmpToByte1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //image to byteArray
            string source = txtImageFilePath.Text;
            //Image img = Image.FromFile(source);
            Bitmap img = new Bitmap(source);
            int h = img.Height;
            int w = img.Width;
            lblHeight.Text = "Height: " + h.ToString();
            lblWidth.Text = "Width: " + w.ToString();
            string output = txtOutputFilePath.Text;


            int count = 0;
            Color pixelColor;
            int red = 0;
            int blue = 0;
            int green = 0;
            int colorSum = 0;
            using (StreamWriter writer = new StreamWriter(output))
            {
                for (int width = 0; width < w; width++)
                {
                    for (int height = 0; height < h; height++)
                    {
                        pixelColor = img.GetPixel(width, height);
                        red = pixelColor.R;
                        green = pixelColor.G;
                        blue = pixelColor.B;
                        if (red == 0 && green == 0 && blue == 0)
                        {
                            colorSum = 0;
                        }
                        else
                        {
                            colorSum = (red + blue + green) / 3;
                        }
                        Console.WriteLine(count + " Height= " + height + " width = " + width + " Color = " + pixelColor + " Intensity = " + colorSum.ToString());
                        writer.Write(colorSum.ToString() + ",");
                        count++;
                    }
                    writer.Write(Environment.NewLine);
                }
                writer.Flush();
            }

        }
    }
}
