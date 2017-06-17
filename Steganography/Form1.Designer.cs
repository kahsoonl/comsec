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
            this.components = new System.ComponentModel.Container();
            this.hideText = new System.Windows.Forms.Button();
            this.openedImage = new System.Windows.Forms.PictureBox();
            this.browseImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.imageButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.extractButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.extractProper = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.openedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // hideText
            // 
            this.hideText.Location = new System.Drawing.Point(361, 315);
            this.hideText.Name = "hideText";
            this.hideText.Size = new System.Drawing.Size(134, 92);
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
            this.extractButton.Location = new System.Drawing.Point(516, 315);
            this.extractButton.Name = "extractButton";
            this.extractButton.Size = new System.Drawing.Size(134, 43);
            this.extractButton.TabIndex = 6;
            this.extractButton.Text = "Extract Text Normal";
            this.extractButton.UseVisualStyleBackColor = true;
            this.extractButton.Click += new System.EventHandler(this.extractButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(361, 27);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(289, 282);
            this.textBox.TabIndex = 7;
            this.textBox.Text = "";
            // 
            // extractProper
            // 
            this.extractProper.Location = new System.Drawing.Point(516, 364);
            this.extractProper.Name = "extractProper";
            this.extractProper.Size = new System.Drawing.Size(134, 43);
            this.extractProper.TabIndex = 8;
            this.extractProper.Text = "Extract Text";
            this.extractProper.UseVisualStyleBackColor = true;
            this.extractProper.Click += new System.EventHandler(this.extractProper_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 441);
            this.Controls.Add(this.extractProper);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.extractButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.imageButton);
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
        private System.Windows.Forms.Button imageButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button extractButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.Button extractProper;
    }
}

