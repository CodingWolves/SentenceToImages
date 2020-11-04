namespace SentencesToImages
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
            if(disposing && (components != null))
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
            this.previewPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sentencesListBox = new System.Windows.Forms.ListBox();
            this.addSensFileButton = new System.Windows.Forms.Button();
            this.saveImagesButton = new System.Windows.Forms.Button();
            this.outputFolderTextBox = new System.Windows.Forms.TextBox();
            this.chooseOutputFolderButton = new System.Windows.Forms.Button();
            this.outputFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundColorBox = new System.Windows.Forms.PictureBox();
            this.defaultBackColorBox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBackColorBox)).BeginInit();
            this.SuspendLayout();
            // 
            // previewPictureBox
            // 
            this.previewPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previewPictureBox.Location = new System.Drawing.Point(8, 23);
            this.previewPictureBox.Name = "previewPictureBox";
            this.previewPictureBox.Size = new System.Drawing.Size(511, 402);
            this.previewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previewPictureBox.TabIndex = 0;
            this.previewPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Preview";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.previewPictureBox);
            this.panel1.Location = new System.Drawing.Point(259, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(529, 435);
            this.panel1.TabIndex = 2;
            // 
            // sentencesListBox
            // 
            this.sentencesListBox.FormattingEnabled = true;
            this.sentencesListBox.Location = new System.Drawing.Point(12, 170);
            this.sentencesListBox.Name = "sentencesListBox";
            this.sentencesListBox.Size = new System.Drawing.Size(241, 160);
            this.sentencesListBox.TabIndex = 3;
            this.sentencesListBox.SelectedIndexChanged += new System.EventHandler(this.sentencesListBox_SelectedIndexChanged);
            this.sentencesListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sentencesListBox_KeyDown);
            // 
            // addSensFileButton
            // 
            this.addSensFileButton.Location = new System.Drawing.Point(12, 12);
            this.addSensFileButton.Name = "addSensFileButton";
            this.addSensFileButton.Size = new System.Drawing.Size(241, 53);
            this.addSensFileButton.TabIndex = 4;
            this.addSensFileButton.Text = "Add Sentences File";
            this.addSensFileButton.UseVisualStyleBackColor = true;
            this.addSensFileButton.Click += new System.EventHandler(this.addSensFileButton_Click);
            // 
            // saveImagesButton
            // 
            this.saveImagesButton.Location = new System.Drawing.Point(12, 385);
            this.saveImagesButton.Name = "saveImagesButton";
            this.saveImagesButton.Size = new System.Drawing.Size(241, 53);
            this.saveImagesButton.TabIndex = 5;
            this.saveImagesButton.Text = "Save Images";
            this.saveImagesButton.UseVisualStyleBackColor = true;
            this.saveImagesButton.Click += new System.EventHandler(this.saveImagesButton_Click);
            // 
            // outputFolderTextBox
            // 
            this.outputFolderTextBox.Location = new System.Drawing.Point(12, 359);
            this.outputFolderTextBox.Name = "outputFolderTextBox";
            this.outputFolderTextBox.Size = new System.Drawing.Size(201, 20);
            this.outputFolderTextBox.TabIndex = 6;
            // 
            // chooseOutputFolderButton
            // 
            this.chooseOutputFolderButton.Location = new System.Drawing.Point(219, 358);
            this.chooseOutputFolderButton.Name = "chooseOutputFolderButton";
            this.chooseOutputFolderButton.Size = new System.Drawing.Size(34, 23);
            this.chooseOutputFolderButton.TabIndex = 7;
            this.chooseOutputFolderButton.Text = "...";
            this.chooseOutputFolderButton.UseVisualStyleBackColor = true;
            this.chooseOutputFolderButton.Click += new System.EventHandler(this.chooseOutputFolderButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Output Folder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sentences";
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "fileDialog";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Background Color";
            // 
            // backgroundColorBox
            // 
            this.backgroundColorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backgroundColorBox.Location = new System.Drawing.Point(210, 123);
            this.backgroundColorBox.Name = "backgroundColorBox";
            this.backgroundColorBox.Size = new System.Drawing.Size(43, 44);
            this.backgroundColorBox.TabIndex = 11;
            this.backgroundColorBox.TabStop = false;
            this.backgroundColorBox.DoubleClick += new System.EventHandler(this.sentenceBackColorBox_DoubleClick);
            // 
            // defaultBackColorBox
            // 
            this.defaultBackColorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.defaultBackColorBox.Location = new System.Drawing.Point(15, 71);
            this.defaultBackColorBox.Name = "defaultBackColorBox";
            this.defaultBackColorBox.Size = new System.Drawing.Size(27, 26);
            this.defaultBackColorBox.TabIndex = 12;
            this.defaultBackColorBox.TabStop = false;
            this.defaultBackColorBox.DoubleClick += new System.EventHandler(this.defaultBackColorBox_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Default Background Color";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.defaultBackColorBox);
            this.Controls.Add(this.backgroundColorBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chooseOutputFolderButton);
            this.Controls.Add(this.outputFolderTextBox);
            this.Controls.Add(this.saveImagesButton);
            this.Controls.Add(this.addSensFileButton);
            this.Controls.Add(this.sentencesListBox);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBackColorBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox previewPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox sentencesListBox;
        private System.Windows.Forms.Button addSensFileButton;
        private System.Windows.Forms.Button saveImagesButton;
        private System.Windows.Forms.TextBox outputFolderTextBox;
        private System.Windows.Forms.Button chooseOutputFolderButton;
        private System.Windows.Forms.FolderBrowserDialog outputFolderDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox backgroundColorBox;
        private System.Windows.Forms.PictureBox defaultBackColorBox;
        private System.Windows.Forms.Label label5;
    }
}

