namespace Steganography
{
    partial class MainWindow
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
            this.hideText = new System.Windows.Forms.Button();
            this.openedImage = new System.Windows.Forms.PictureBox();
            this.browseImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.imageButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.extractButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.openedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // hideText
            // 
            this.hideText.Location = new System.Drawing.Point(361, 364);
            this.hideText.Name = "hideText";
            this.hideText.Size = new System.Drawing.Size(134, 43);
            this.hideText.TabIndex = 0;
            this.hideText.Text = "Hide Text";
            this.hideText.UseVisualStyleBackColor = true;
            this.hideText.Click += new System.EventHandler(this.hideText_Click);
            // 
            // openedImage
            // 
            this.openedImage.Image = global::Steganography.Properties.Resources.defaultImage;
            this.openedImage.Location = new System.Drawing.Point(12, 27);
            this.openedImage.Name = "openedImage";
            this.openedImage.Size = new System.Drawing.Size(318, 316);
            this.openedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.openedImage.TabIndex = 1;
            this.openedImage.TabStop = false;
            this.openedImage.Click += new System.EventHandler(this.openedImage_Click);
            // 
            // browseImageDialog
            // 
            this.browseImageDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.browseImageDialog_FileOk);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(345, 27);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(305, 316);
            this.textBox.TabIndex = 3;
            this.textBox.Text = "";
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // imageButton
            // 
            this.imageButton.Location = new System.Drawing.Point(35, 364);
            this.imageButton.Name = "imageButton";
            this.imageButton.Size = new System.Drawing.Size(120, 43);
            this.imageButton.TabIndex = 4;
            this.imageButton.Text = "Open Image";
            this.imageButton.UseVisualStyleBackColor = true;
            this.imageButton.Click += new System.EventHandler(this.imageButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(183, 364);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(120, 43);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save Image";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // extractButton
            // 
            this.extractButton.Location = new System.Drawing.Point(516, 364);
            this.extractButton.Name = "extractButton";
            this.extractButton.Size = new System.Drawing.Size(134, 43);
            this.extractButton.TabIndex = 6;
            this.extractButton.Text = "Extract Text";
            this.extractButton.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 441);
            this.Controls.Add(this.extractButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.imageButton);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.openedImage);
            this.Controls.Add(this.hideText);
            this.Name = "MainWindow";
            this.Text = "Steganography";
            ((System.ComponentModel.ISupportInitialize)(this.openedImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button hideText;
        private System.Windows.Forms.PictureBox openedImage;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog browseImageDialog;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.Button imageButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button extractButton;
    }
}

