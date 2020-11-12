namespace SentencesToImages
{
    partial class SentencesToImages
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
            this.ZoomLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
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
            this.currentBackColorBox = new System.Windows.Forms.PictureBox();
            this.DefaultBackColorBox = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ResetAllToDefault = new System.Windows.Forms.Button();
            this.DefaultFontSizeLabel = new System.Windows.Forms.Label();
            this.DefaultImageSizeLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.defaultImageSizeTrackBar = new System.Windows.Forms.TrackBar();
            this.defaultFontSizeTrackBar = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ResetStyleToDefault = new System.Windows.Forms.Button();
            this.CurrentImageSizeLabel = new System.Windows.Forms.Label();
            this.CurrentFontSizeLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.currentImageSizeTrackBar = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.currentFontSizeTrackBar = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ImageFormatComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentBackColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefaultBackColorBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defaultImageSizeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultFontSizeTrackBar)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentImageSizeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentFontSizeTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // previewPictureBox
            // 
            this.previewPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previewPictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.previewPictureBox.Location = new System.Drawing.Point(8, 23);
            this.previewPictureBox.Name = "previewPictureBox";
            this.previewPictureBox.Size = new System.Drawing.Size(511, 405);
            this.previewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.previewPictureBox.TabIndex = 0;
            this.previewPictureBox.TabStop = false;
            this.previewPictureBox.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.PreviewPictureBox_MouseWheel);
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
            this.panel1.Controls.Add(this.ZoomLabel);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.previewPictureBox);
            this.panel1.Location = new System.Drawing.Point(259, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(529, 435);
            this.panel1.TabIndex = 2;
            // 
            // ZoomLabel
            // 
            this.ZoomLabel.AutoSize = true;
            this.ZoomLabel.Location = new System.Drawing.Point(478, 7);
            this.ZoomLabel.Name = "ZoomLabel";
            this.ZoomLabel.Size = new System.Drawing.Size(33, 13);
            this.ZoomLabel.TabIndex = 3;
            this.ZoomLabel.Text = "x1.00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(410, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Zoom factor -";
            // 
            // sentencesListBox
            // 
            this.sentencesListBox.FormattingEnabled = true;
            this.sentencesListBox.Location = new System.Drawing.Point(12, 214);
            this.sentencesListBox.Margin = new System.Windows.Forms.Padding(2);
            this.sentencesListBox.Name = "sentencesListBox";
            this.sentencesListBox.Size = new System.Drawing.Size(238, 121);
            this.sentencesListBox.TabIndex = 3;
            this.sentencesListBox.SelectedIndexChanged += new System.EventHandler(this.SentencesListBox_SelectedIndexChanged);
            this.sentencesListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SentencesListBox_KeyDown);
            // 
            // addSensFileButton
            // 
            this.addSensFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addSensFileButton.Location = new System.Drawing.Point(8, 3);
            this.addSensFileButton.Margin = new System.Windows.Forms.Padding(2);
            this.addSensFileButton.Name = "addSensFileButton";
            this.addSensFileButton.Size = new System.Drawing.Size(241, 47);
            this.addSensFileButton.TabIndex = 4;
            this.addSensFileButton.Text = "Add Sentences File";
            this.addSensFileButton.UseVisualStyleBackColor = true;
            this.addSensFileButton.Click += new System.EventHandler(this.AddSensFileButton_Click);
            // 
            // saveImagesButton
            // 
            this.saveImagesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveImagesButton.Location = new System.Drawing.Point(104, 385);
            this.saveImagesButton.Name = "saveImagesButton";
            this.saveImagesButton.Size = new System.Drawing.Size(149, 53);
            this.saveImagesButton.TabIndex = 5;
            this.saveImagesButton.Text = "Save Images";
            this.saveImagesButton.UseVisualStyleBackColor = true;
            this.saveImagesButton.Click += new System.EventHandler(this.SaveImagesButton_Click);
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
            this.chooseOutputFolderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chooseOutputFolderButton.Location = new System.Drawing.Point(219, 358);
            this.chooseOutputFolderButton.Name = "chooseOutputFolderButton";
            this.chooseOutputFolderButton.Size = new System.Drawing.Size(34, 23);
            this.chooseOutputFolderButton.TabIndex = 7;
            this.chooseOutputFolderButton.Text = "...";
            this.chooseOutputFolderButton.UseVisualStyleBackColor = true;
            this.chooseOutputFolderButton.Click += new System.EventHandler(this.ChooseOutputFolderButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 340);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Output Folder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sentences";
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "fileDialog";
            // 
            // currentBackColorBox
            // 
            this.currentBackColorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentBackColorBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.currentBackColorBox.Location = new System.Drawing.Point(100, 4);
            this.currentBackColorBox.Margin = new System.Windows.Forms.Padding(2);
            this.currentBackColorBox.Name = "currentBackColorBox";
            this.currentBackColorBox.Size = new System.Drawing.Size(30, 30);
            this.currentBackColorBox.TabIndex = 11;
            this.currentBackColorBox.TabStop = false;
            this.currentBackColorBox.DoubleClick += new System.EventHandler(this.CurrentBackColorBox_DoubleClick);
            // 
            // DefaultBackColorBox
            // 
            this.DefaultBackColorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DefaultBackColorBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DefaultBackColorBox.Location = new System.Drawing.Point(100, 4);
            this.DefaultBackColorBox.Margin = new System.Windows.Forms.Padding(2);
            this.DefaultBackColorBox.Name = "DefaultBackColorBox";
            this.DefaultBackColorBox.Size = new System.Drawing.Size(30, 30);
            this.DefaultBackColorBox.TabIndex = 12;
            this.DefaultBackColorBox.TabStop = false;
            this.DefaultBackColorBox.DoubleClick += new System.EventHandler(this.DefaultBackColorBox_DoubleClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(11, 73);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(241, 118);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.ResetAllToDefault);
            this.tabPage1.Controls.Add(this.DefaultFontSizeLabel);
            this.tabPage1.Controls.Add(this.DefaultImageSizeLabel);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.defaultImageSizeTrackBar);
            this.tabPage1.Controls.Add(this.defaultFontSizeTrackBar);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.DefaultBackColorBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(233, 89);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Default";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ResetAllToDefault
            // 
            this.ResetAllToDefault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetAllToDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ResetAllToDefault.Location = new System.Drawing.Point(154, 5);
            this.ResetAllToDefault.Name = "ResetAllToDefault";
            this.ResetAllToDefault.Size = new System.Drawing.Size(72, 29);
            this.ResetAllToDefault.TabIndex = 27;
            this.ResetAllToDefault.Text = "Reset All";
            this.ResetAllToDefault.UseVisualStyleBackColor = true;
            this.ResetAllToDefault.Click += new System.EventHandler(this.ResetAllToDefault_Click);
            // 
            // DefaultFontSizeLabel
            // 
            this.DefaultFontSizeLabel.AutoSize = true;
            this.DefaultFontSizeLabel.Location = new System.Drawing.Point(58, 38);
            this.DefaultFontSizeLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.DefaultFontSizeLabel.Name = "DefaultFontSizeLabel";
            this.DefaultFontSizeLabel.Size = new System.Drawing.Size(19, 13);
            this.DefaultFontSizeLabel.TabIndex = 22;
            this.DefaultFontSizeLabel.Text = "20";
            // 
            // DefaultImageSizeLabel
            // 
            this.DefaultImageSizeLabel.AutoSize = true;
            this.DefaultImageSizeLabel.Location = new System.Drawing.Point(188, 38);
            this.DefaultImageSizeLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.DefaultImageSizeLabel.Name = "DefaultImageSizeLabel";
            this.DefaultImageSizeLabel.Size = new System.Drawing.Size(25, 13);
            this.DefaultImageSizeLabel.TabIndex = 21;
            this.DefaultImageSizeLabel.Text = "400";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(126, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Image Size";
            // 
            // defaultImageSizeTrackBar
            // 
            this.defaultImageSizeTrackBar.AutoSize = false;
            this.defaultImageSizeTrackBar.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.defaultImageSizeTrackBar.LargeChange = 50;
            this.defaultImageSizeTrackBar.Location = new System.Drawing.Point(129, 53);
            this.defaultImageSizeTrackBar.Margin = new System.Windows.Forms.Padding(2);
            this.defaultImageSizeTrackBar.Maximum = 2000;
            this.defaultImageSizeTrackBar.Minimum = 200;
            this.defaultImageSizeTrackBar.Name = "defaultImageSizeTrackBar";
            this.defaultImageSizeTrackBar.Size = new System.Drawing.Size(100, 30);
            this.defaultImageSizeTrackBar.SmallChange = 20;
            this.defaultImageSizeTrackBar.TabIndex = 19;
            this.defaultImageSizeTrackBar.TickFrequency = 150;
            this.defaultImageSizeTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.defaultImageSizeTrackBar.Value = 400;
            this.defaultImageSizeTrackBar.Scroll += new System.EventHandler(this.DefaultImageSizeTrackBar_Scroll);
            // 
            // defaultFontSizeTrackBar
            // 
            this.defaultFontSizeTrackBar.AutoSize = false;
            this.defaultFontSizeTrackBar.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.defaultFontSizeTrackBar.Location = new System.Drawing.Point(4, 53);
            this.defaultFontSizeTrackBar.Margin = new System.Windows.Forms.Padding(2);
            this.defaultFontSizeTrackBar.Maximum = 128;
            this.defaultFontSizeTrackBar.Minimum = 6;
            this.defaultFontSizeTrackBar.Name = "defaultFontSizeTrackBar";
            this.defaultFontSizeTrackBar.Size = new System.Drawing.Size(100, 30);
            this.defaultFontSizeTrackBar.SmallChange = 2;
            this.defaultFontSizeTrackBar.TabIndex = 18;
            this.defaultFontSizeTrackBar.TickFrequency = 10;
            this.defaultFontSizeTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.defaultFontSizeTrackBar.Value = 20;
            this.defaultFontSizeTrackBar.Scroll += new System.EventHandler(this.DefaultFontSizeTrackBar_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Font Size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Background Color";
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.ResetStyleToDefault);
            this.tabPage2.Controls.Add(this.CurrentImageSizeLabel);
            this.tabPage2.Controls.Add(this.CurrentFontSizeLabel);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.currentBackColorBox);
            this.tabPage2.Controls.Add(this.currentImageSizeTrackBar);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.currentFontSizeTrackBar);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(233, 89);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Current";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ResetStyleToDefault
            // 
            this.ResetStyleToDefault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetStyleToDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ResetStyleToDefault.Location = new System.Drawing.Point(175, 5);
            this.ResetStyleToDefault.Name = "ResetStyleToDefault";
            this.ResetStyleToDefault.Size = new System.Drawing.Size(51, 29);
            this.ResetStyleToDefault.TabIndex = 26;
            this.ResetStyleToDefault.Text = "Reset";
            this.ResetStyleToDefault.UseVisualStyleBackColor = true;
            this.ResetStyleToDefault.Click += new System.EventHandler(this.ResetStyleToDefault_Click);
            // 
            // CurrentImageSizeLabel
            // 
            this.CurrentImageSizeLabel.AutoSize = true;
            this.CurrentImageSizeLabel.Location = new System.Drawing.Point(188, 38);
            this.CurrentImageSizeLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.CurrentImageSizeLabel.Name = "CurrentImageSizeLabel";
            this.CurrentImageSizeLabel.Size = new System.Drawing.Size(25, 13);
            this.CurrentImageSizeLabel.TabIndex = 25;
            this.CurrentImageSizeLabel.Text = "400";
            // 
            // CurrentFontSizeLabel
            // 
            this.CurrentFontSizeLabel.AutoSize = true;
            this.CurrentFontSizeLabel.Location = new System.Drawing.Point(58, 38);
            this.CurrentFontSizeLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.CurrentFontSizeLabel.Name = "CurrentFontSizeLabel";
            this.CurrentFontSizeLabel.Size = new System.Drawing.Size(19, 13);
            this.CurrentFontSizeLabel.TabIndex = 23;
            this.CurrentFontSizeLabel.Text = "20";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(126, 38);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Image Size";
            // 
            // currentImageSizeTrackBar
            // 
            this.currentImageSizeTrackBar.AutoSize = false;
            this.currentImageSizeTrackBar.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.currentImageSizeTrackBar.LargeChange = 50;
            this.currentImageSizeTrackBar.Location = new System.Drawing.Point(129, 53);
            this.currentImageSizeTrackBar.Margin = new System.Windows.Forms.Padding(2);
            this.currentImageSizeTrackBar.Maximum = 2000;
            this.currentImageSizeTrackBar.Minimum = 200;
            this.currentImageSizeTrackBar.Name = "currentImageSizeTrackBar";
            this.currentImageSizeTrackBar.Size = new System.Drawing.Size(100, 30);
            this.currentImageSizeTrackBar.SmallChange = 21;
            this.currentImageSizeTrackBar.TabIndex = 19;
            this.currentImageSizeTrackBar.TickFrequency = 150;
            this.currentImageSizeTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.currentImageSizeTrackBar.Value = 400;
            this.currentImageSizeTrackBar.Scroll += new System.EventHandler(this.CurrentImageSizeTrackBar_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Background Color";
            // 
            // currentFontSizeTrackBar
            // 
            this.currentFontSizeTrackBar.AutoSize = false;
            this.currentFontSizeTrackBar.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.currentFontSizeTrackBar.Location = new System.Drawing.Point(4, 53);
            this.currentFontSizeTrackBar.Margin = new System.Windows.Forms.Padding(2);
            this.currentFontSizeTrackBar.Maximum = 128;
            this.currentFontSizeTrackBar.Minimum = 6;
            this.currentFontSizeTrackBar.Name = "currentFontSizeTrackBar";
            this.currentFontSizeTrackBar.Size = new System.Drawing.Size(100, 30);
            this.currentFontSizeTrackBar.SmallChange = 2;
            this.currentFontSizeTrackBar.TabIndex = 22;
            this.currentFontSizeTrackBar.TickFrequency = 10;
            this.currentFontSizeTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.currentFontSizeTrackBar.Value = 20;
            this.currentFontSizeTrackBar.Scroll += new System.EventHandler(this.CurrentFontSizeTrackBar_Scroll);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 38);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Font Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Style Settings";
            // 
            // ImageFormatComboBox
            // 
            this.ImageFormatComboBox.FormattingEnabled = true;
            this.ImageFormatComboBox.Items.AddRange(new object[] {
            "Jpg",
            "Png",
            "Bmp",
            "Tiff"});
            this.ImageFormatComboBox.Location = new System.Drawing.Point(27, 408);
            this.ImageFormatComboBox.Name = "ImageFormatComboBox";
            this.ImageFormatComboBox.Size = new System.Drawing.Size(55, 21);
            this.ImageFormatComboBox.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 392);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Image Format";
            // 
            // SentencesToImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 444);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ImageFormatComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chooseOutputFolderButton);
            this.Controls.Add(this.outputFolderTextBox);
            this.Controls.Add(this.saveImagesButton);
            this.Controls.Add(this.addSensFileButton);
            this.Controls.Add(this.sentencesListBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SentencesToImages";
            this.Text = "Sentences To Images";
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentBackColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefaultBackColorBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defaultImageSizeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultFontSizeTrackBar)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentImageSizeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentFontSizeTrackBar)).EndInit();
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
        private System.Windows.Forms.PictureBox currentBackColorBox;
        private System.Windows.Forms.PictureBox DefaultBackColorBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar defaultImageSizeTrackBar;
        private System.Windows.Forms.TrackBar defaultFontSizeTrackBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar currentImageSizeTrackBar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar currentFontSizeTrackBar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label DefaultFontSizeLabel;
        private System.Windows.Forms.Label DefaultImageSizeLabel;
        private System.Windows.Forms.Label CurrentFontSizeLabel;
        private System.Windows.Forms.Label CurrentImageSizeLabel;
        private System.Windows.Forms.Label ZoomLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button ResetStyleToDefault;
        private System.Windows.Forms.Button ResetAllToDefault;
        private System.Windows.Forms.ComboBox ImageFormatComboBox;
        private System.Windows.Forms.Label label12;
    }
}

