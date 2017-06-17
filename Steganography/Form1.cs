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
using System.Text.RegularExpressions;

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

            if(textBox.Text == "" || textBox.TextLength == 0)
            {
                MessageBox.Show("Textbox cannot be empty! Please enter some text!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                stegoImage = StegOperation.embedMessage(textBox.Text, bmp);
                if(stegoImage != null)
                {
                    MessageBox.Show("Message successfully hidden in the image", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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

        private void extractButton_Click(object sender, EventArgs e)
        {
            stegoImage = (Bitmap)openedImage.Image;

            string extractedText = StegOperation.extractMessage(stegoImage);
            
            //MessageBox.Show("Message successfully extracted from the image", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox.Text = extractedText;
        }

        private void extractProper_Click(object sender, EventArgs e)
        {
            stegoImage = (Bitmap)openedImage.Image;

            string extractedText = StegOperation.extractMessageInvert(stegoImage);
            
            //MessageBox.Show("Message successfully extracted from the image", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox.Text = extractedText;
        }
    }
}
