using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Imaging;

namespace Steganography
{
    public partial class MainWindow : Form
    {
        Bitmap stegoImage;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void hideText_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)openedImage.Image;
            int R = 0, G = 0, B = 0;

            Color pixel = bmp.GetPixel(0, 0);

            R = pixel.R;
            G = pixel.G;
            B = pixel.B;

            //Debug.Write(R + "\n");
            //Debug.Write(G + "\n");
            //Debug.Write(B + "\n");
            
            //Debug.Write(R % 2 + "\n");
            //Debug.Write(G % 2 + "\n");
            //Debug.Write(B % 2 + "\n");

            // now, clear the least significant bit (LSB) from each pixel element
            R = pixel.R - pixel.R % 2;
            G = pixel.G - pixel.G % 2;
            B = pixel.B - pixel.B % 2;

            //Debug.Write(R + "\n");
            //Debug.Write(G + "\n");
            //Debug.Write(B + "\n");

            if(textBox.Text == "" || textBox.TextLength == 0)
            {
                MessageBox.Show("Textbox cannot be empty! Please enter some text!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                stegoImage = StegOperation.embedText(textBox.Text, bmp);
                MessageBox.Show("Message successfully hidden in the image", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void browseImageDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openedImage_Click(object sender, EventArgs e)
        {

        }

        private void imageButton_Click(object sender, EventArgs e)
        {
            browseImageDialog.Filter = "Image Files (*.png; *.bmp)|*.png; *.bmp";

            if (browseImageDialog.ShowDialog() == DialogResult.OK)
            {
                openedImage.Image = Image.FromFile(browseImageDialog.FileName);
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog save_dialog = new SaveFileDialog();
            save_dialog.Filter = "Png Image|*.png|Bitmap Image|*.bmp";

            if (save_dialog.ShowDialog() == DialogResult.OK && stegoImage != null)
            {
                switch (save_dialog.FilterIndex)
                {
                    case 0:
                        {
                            stegoImage.Save(save_dialog.FileName, ImageFormat.Png);
                        }
                        break;
                    case 1:
                        {
                            stegoImage.Save(save_dialog.FileName, ImageFormat.Bmp);
                        }
                        break;
                }
            }
        }
    }
}
