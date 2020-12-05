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
            this.CurrentBackColorBox = new System.Windows.Forms.PictureBox();
            this.DefaultBackColorBox = new System.Windows.Forms.PictureBox();
            this.SetDefaultStyleToAllButton = new System.Windows.Forms.Button();
            this.DefaultFontSizeLabel = new System.Windows.Forms.Label();
            this.defaultFontSizeTrackBar = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SetDefaultStyleToCurrentButton = new System.Windows.Forms.Button();
            this.CurrentImageWidthLabel = new System.Windows.Forms.Label();
            this.CurrentFontSizeLabel = new System.Windows.Forms.Label();
            this.CurrentImageWidthTrackBar = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.CurrentFontSizeTrackBar = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ImageFormatComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.DefaultImageHeightLabel = new System.Windows.Forms.Label();
            this.DefaultImageHeightTrackBar = new System.Windows.Forms.TrackBar();
            this.label19 = new System.Windows.Forms.Label();
            this.DefaultImageWidthLabel = new System.Windows.Forms.Label();
            this.DefaultImageWidthTrackBar = new System.Windows.Forms.TrackBar();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.CurrentImageHeightLabel = new System.Windows.Forms.Label();
            this.CurrentImageHeightTrackBar = new System.Windows.Forms.TrackBar();
            this.label14 = new System.Windows.Forms.Label();
            this.CurrentVertAlignComboBox = new System.Windows.Forms.ComboBox();
            this.CurrentHoriAlignComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.DefaultVertAlignComboBox = new System.Windows.Forms.ComboBox();
            this.DefaultHoriAlignComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentBackColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefaultBackColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultFontSizeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentImageWidthTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentFontSizeTrackBar)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DefaultImageHeightTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefaultImageWidthTrackBar)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentImageHeightTrackBar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.sentencesListBox.Location = new System.Drawing.Point(796, 21);
            this.sentencesListBox.Margin = new System.Windows.Forms.Padding(2);
            this.sentencesListBox.Name = "sentencesListBox";
            this.sentencesListBox.Size = new System.Drawing.Size(189, 134);
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
            this.addSensFileButton.Size = new System.Drawing.Size(241, 42);
            this.addSensFileButton.TabIndex = 4;
            this.addSensFileButton.Text = "Add Sentences File";
            this.addSensFileButton.UseVisualStyleBackColor = true;
            this.addSensFileButton.Click += new System.EventHandler(this.AddSensFileButton_Click);
            // 
            // saveImagesButton
            // 
            this.saveImagesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveImagesButton.Location = new System.Drawing.Point(104, 379);
            this.saveImagesButton.Name = "saveImagesButton";
            this.saveImagesButton.Size = new System.Drawing.Size(149, 53);
            this.saveImagesButton.TabIndex = 5;
            this.saveImagesButton.Text = "Save Images";
            this.saveImagesButton.UseVisualStyleBackColor = true;
            this.saveImagesButton.Click += new System.EventHandler(this.SaveImagesButton_Click);
            // 
            // outputFolderTextBox
            // 
            this.outputFolderTextBox.Location = new System.Drawing.Point(12, 353);
            this.outputFolderTextBox.Name = "outputFolderTextBox";
            this.outputFolderTextBox.Size = new System.Drawing.Size(201, 20);
            this.outputFolderTextBox.TabIndex = 6;
            // 
            // chooseOutputFolderButton
            // 
            this.chooseOutputFolderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chooseOutputFolderButton.Location = new System.Drawing.Point(219, 352);
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
            this.label2.Location = new System.Drawing.Point(9, 334);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Output Folder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(793, 3);
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
            // CurrentBackColorBox
            // 
            this.CurrentBackColorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrentBackColorBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CurrentBackColorBox.Location = new System.Drawing.Point(122, 2);
            this.CurrentBackColorBox.Margin = new System.Windows.Forms.Padding(2);
            this.CurrentBackColorBox.Name = "CurrentBackColorBox";
            this.CurrentBackColorBox.Size = new System.Drawing.Size(30, 30);
            this.CurrentBackColorBox.TabIndex = 11;
            this.CurrentBackColorBox.TabStop = false;
            this.CurrentBackColorBox.DoubleClick += new System.EventHandler(this.CurrentBackColorBox_DoubleClick);
            // 
            // DefaultBackColorBox
            // 
            this.DefaultBackColorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DefaultBackColorBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DefaultBackColorBox.Location = new System.Drawing.Point(124, 2);
            this.DefaultBackColorBox.Margin = new System.Windows.Forms.Padding(2);
            this.DefaultBackColorBox.Name = "DefaultBackColorBox";
            this.DefaultBackColorBox.Size = new System.Drawing.Size(30, 30);
            this.DefaultBackColorBox.TabIndex = 12;
            this.DefaultBackColorBox.TabStop = false;
            this.DefaultBackColorBox.DoubleClick += new System.EventHandler(this.DefaultBackColorBox_DoubleClick);
            // 
            // SetDefaultStyleToAllButton
            // 
            this.SetDefaultStyleToAllButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetDefaultStyleToAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.SetDefaultStyleToAllButton.Location = new System.Drawing.Point(186, 62);
            this.SetDefaultStyleToAllButton.Name = "SetDefaultStyleToAllButton";
            this.SetDefaultStyleToAllButton.Size = new System.Drawing.Size(50, 50);
            this.SetDefaultStyleToAllButton.TabIndex = 27;
            this.SetDefaultStyleToAllButton.Text = "Set All";
            this.SetDefaultStyleToAllButton.UseVisualStyleBackColor = true;
            this.SetDefaultStyleToAllButton.Click += new System.EventHandler(this.SetDefaultStyleToAllButton_Click);
            // 
            // DefaultFontSizeLabel
            // 
            this.DefaultFontSizeLabel.AutoSize = true;
            this.DefaultFontSizeLabel.Location = new System.Drawing.Point(25, 49);
            this.DefaultFontSizeLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.DefaultFontSizeLabel.Name = "DefaultFontSizeLabel";
            this.DefaultFontSizeLabel.Size = new System.Drawing.Size(19, 13);
            this.DefaultFontSizeLabel.TabIndex = 22;
            this.DefaultFontSizeLabel.Text = "20";
            // 
            // defaultFontSizeTrackBar
            // 
            this.defaultFontSizeTrackBar.AutoSize = false;
            this.defaultFontSizeTrackBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.defaultFontSizeTrackBar.Location = new System.Drawing.Point(67, 36);
            this.defaultFontSizeTrackBar.Margin = new System.Windows.Forms.Padding(2);
            this.defaultFontSizeTrackBar.Maximum = 256;
            this.defaultFontSizeTrackBar.Minimum = 6;
            this.defaultFontSizeTrackBar.Name = "defaultFontSizeTrackBar";
            this.defaultFontSizeTrackBar.Size = new System.Drawing.Size(120, 30);
            this.defaultFontSizeTrackBar.TabIndex = 18;
            this.defaultFontSizeTrackBar.TickFrequency = 15;
            this.defaultFontSizeTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.defaultFontSizeTrackBar.Value = 20;
            this.defaultFontSizeTrackBar.Scroll += new System.EventHandler(this.DefaultFontSizeTrackBar_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Font Size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Background Color";
            // 
            // SetDefaultStyleToCurrentButton
            // 
            this.SetDefaultStyleToCurrentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetDefaultStyleToCurrentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.SetDefaultStyleToCurrentButton.Location = new System.Drawing.Point(186, 118);
            this.SetDefaultStyleToCurrentButton.Name = "SetDefaultStyleToCurrentButton";
            this.SetDefaultStyleToCurrentButton.Size = new System.Drawing.Size(50, 50);
            this.SetDefaultStyleToCurrentButton.TabIndex = 26;
            this.SetDefaultStyleToCurrentButton.Text = "Set Current";
            this.SetDefaultStyleToCurrentButton.UseVisualStyleBackColor = true;
            this.SetDefaultStyleToCurrentButton.Click += new System.EventHandler(this.SetDefaultStyleToCurrentButton_Click);
            // 
            // CurrentImageWidthLabel
            // 
            this.CurrentImageWidthLabel.AutoSize = true;
            this.CurrentImageWidthLabel.Location = new System.Drawing.Point(6, 35);
            this.CurrentImageWidthLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.CurrentImageWidthLabel.Name = "CurrentImageWidthLabel";
            this.CurrentImageWidthLabel.Size = new System.Drawing.Size(25, 13);
            this.CurrentImageWidthLabel.TabIndex = 25;
            this.CurrentImageWidthLabel.Text = "400";
            // 
            // CurrentFontSizeLabel
            // 
            this.CurrentFontSizeLabel.AutoSize = true;
            this.CurrentFontSizeLabel.Location = new System.Drawing.Point(25, 53);
            this.CurrentFontSizeLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.CurrentFontSizeLabel.Name = "CurrentFontSizeLabel";
            this.CurrentFontSizeLabel.Size = new System.Drawing.Size(19, 13);
            this.CurrentFontSizeLabel.TabIndex = 23;
            this.CurrentFontSizeLabel.Text = "20";
            // 
            // CurrentImageWidthTrackBar
            // 
            this.CurrentImageWidthTrackBar.AutoSize = false;
            this.CurrentImageWidthTrackBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.CurrentImageWidthTrackBar.LargeChange = 20;
            this.CurrentImageWidthTrackBar.Location = new System.Drawing.Point(49, 18);
            this.CurrentImageWidthTrackBar.Margin = new System.Windows.Forms.Padding(2);
            this.CurrentImageWidthTrackBar.Maximum = 2000;
            this.CurrentImageWidthTrackBar.Minimum = 200;
            this.CurrentImageWidthTrackBar.Name = "CurrentImageWidthTrackBar";
            this.CurrentImageWidthTrackBar.Size = new System.Drawing.Size(127, 30);
            this.CurrentImageWidthTrackBar.TabIndex = 19;
            this.CurrentImageWidthTrackBar.TickFrequency = 150;
            this.CurrentImageWidthTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.CurrentImageWidthTrackBar.Value = 400;
            this.CurrentImageWidthTrackBar.Scroll += new System.EventHandler(this.CurrentImageWidthTrackBar_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Background Color";
            // 
            // CurrentFontSizeTrackBar
            // 
            this.CurrentFontSizeTrackBar.AutoSize = false;
            this.CurrentFontSizeTrackBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.CurrentFontSizeTrackBar.Location = new System.Drawing.Point(64, 36);
            this.CurrentFontSizeTrackBar.Margin = new System.Windows.Forms.Padding(2);
            this.CurrentFontSizeTrackBar.Maximum = 256;
            this.CurrentFontSizeTrackBar.Minimum = 6;
            this.CurrentFontSizeTrackBar.Name = "CurrentFontSizeTrackBar";
            this.CurrentFontSizeTrackBar.Size = new System.Drawing.Size(120, 30);
            this.CurrentFontSizeTrackBar.TabIndex = 22;
            this.CurrentFontSizeTrackBar.TickFrequency = 15;
            this.CurrentFontSizeTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.CurrentFontSizeTrackBar.Value = 20;
            this.CurrentFontSizeTrackBar.Scroll += new System.EventHandler(this.CurrentFontSizeTrackBar_Scroll);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 40);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Font Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(793, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Current Style Settings";
            // 
            // ImageFormatComboBox
            // 
            this.ImageFormatComboBox.FormattingEnabled = true;
            this.ImageFormatComboBox.Items.AddRange(new object[] {
            "Jpg",
            "Png",
            "Bmp",
            "Tiff"});
            this.ImageFormatComboBox.Location = new System.Drawing.Point(27, 402);
            this.ImageFormatComboBox.Name = "ImageFormatComboBox";
            this.ImageFormatComboBox.Size = new System.Drawing.Size(55, 21);
            this.ImageFormatComboBox.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 386);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Image Format";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.SetDefaultStyleToAllButton);
            this.panel2.Controls.Add(this.SetDefaultStyleToCurrentButton);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.DefaultFontSizeLabel);
            this.panel2.Controls.Add(this.DefaultBackColorBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.defaultFontSizeTrackBar);
            this.panel2.Location = new System.Drawing.Point(12, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 249);
            this.panel2.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.DefaultImageHeightLabel);
            this.groupBox3.Controls.Add(this.DefaultImageHeightTrackBar);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.DefaultImageWidthLabel);
            this.groupBox3.Controls.Add(this.DefaultImageWidthTrackBar);
            this.groupBox3.Location = new System.Drawing.Point(3, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(181, 97);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Image Size";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 58);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Height";
            // 
            // DefaultImageHeightLabel
            // 
            this.DefaultImageHeightLabel.AutoSize = true;
            this.DefaultImageHeightLabel.Location = new System.Drawing.Point(6, 73);
            this.DefaultImageHeightLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.DefaultImageHeightLabel.Name = "DefaultImageHeightLabel";
            this.DefaultImageHeightLabel.Size = new System.Drawing.Size(25, 13);
            this.DefaultImageHeightLabel.TabIndex = 28;
            this.DefaultImageHeightLabel.Text = "400";
            this.DefaultImageHeightLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // DefaultImageHeightTrackBar
            // 
            this.DefaultImageHeightTrackBar.AutoSize = false;
            this.DefaultImageHeightTrackBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.DefaultImageHeightTrackBar.LargeChange = 20;
            this.DefaultImageHeightTrackBar.Location = new System.Drawing.Point(49, 56);
            this.DefaultImageHeightTrackBar.Margin = new System.Windows.Forms.Padding(2);
            this.DefaultImageHeightTrackBar.Maximum = 2000;
            this.DefaultImageHeightTrackBar.Minimum = 200;
            this.DefaultImageHeightTrackBar.Name = "DefaultImageHeightTrackBar";
            this.DefaultImageHeightTrackBar.Size = new System.Drawing.Size(127, 30);
            this.DefaultImageHeightTrackBar.TabIndex = 27;
            this.DefaultImageHeightTrackBar.TickFrequency = 150;
            this.DefaultImageHeightTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.DefaultImageHeightTrackBar.Value = 400;
            this.DefaultImageHeightTrackBar.Scroll += new System.EventHandler(this.DefaultImageHeightTrackBar_Scroll);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 13);
            this.label19.TabIndex = 26;
            this.label19.Text = "Width";
            // 
            // DefaultImageWidthLabel
            // 
            this.DefaultImageWidthLabel.AutoSize = true;
            this.DefaultImageWidthLabel.Location = new System.Drawing.Point(6, 35);
            this.DefaultImageWidthLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.DefaultImageWidthLabel.Name = "DefaultImageWidthLabel";
            this.DefaultImageWidthLabel.Size = new System.Drawing.Size(25, 13);
            this.DefaultImageWidthLabel.TabIndex = 25;
            this.DefaultImageWidthLabel.Text = "400";
            // 
            // DefaultImageWidthTrackBar
            // 
            this.DefaultImageWidthTrackBar.AutoSize = false;
            this.DefaultImageWidthTrackBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.DefaultImageWidthTrackBar.LargeChange = 20;
            this.DefaultImageWidthTrackBar.Location = new System.Drawing.Point(49, 18);
            this.DefaultImageWidthTrackBar.Margin = new System.Windows.Forms.Padding(2);
            this.DefaultImageWidthTrackBar.Maximum = 2000;
            this.DefaultImageWidthTrackBar.Minimum = 200;
            this.DefaultImageWidthTrackBar.Name = "DefaultImageWidthTrackBar";
            this.DefaultImageWidthTrackBar.Size = new System.Drawing.Size(127, 30);
            this.DefaultImageWidthTrackBar.TabIndex = 19;
            this.DefaultImageWidthTrackBar.TickFrequency = 150;
            this.DefaultImageWidthTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.DefaultImageWidthTrackBar.Value = 400;
            this.DefaultImageWidthTrackBar.Scroll += new System.EventHandler(this.DefaultImageWidthTrackBar_Scroll);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Default Style Settings";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.CurrentBackColorBox);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.CurrentFontSizeLabel);
            this.panel3.Controls.Add(this.CurrentFontSizeTrackBar);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(796, 184);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(189, 254);
            this.panel3.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.CurrentImageHeightLabel);
            this.groupBox1.Controls.Add(this.CurrentImageHeightTrackBar);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.CurrentImageWidthLabel);
            this.groupBox1.Controls.Add(this.CurrentImageWidthTrackBar);
            this.groupBox1.Location = new System.Drawing.Point(3, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 97);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image Size";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Height";
            // 
            // CurrentImageHeightLabel
            // 
            this.CurrentImageHeightLabel.AutoSize = true;
            this.CurrentImageHeightLabel.Location = new System.Drawing.Point(6, 73);
            this.CurrentImageHeightLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.CurrentImageHeightLabel.Name = "CurrentImageHeightLabel";
            this.CurrentImageHeightLabel.Size = new System.Drawing.Size(25, 13);
            this.CurrentImageHeightLabel.TabIndex = 28;
            this.CurrentImageHeightLabel.Text = "400";
            this.CurrentImageHeightLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CurrentImageHeightTrackBar
            // 
            this.CurrentImageHeightTrackBar.AutoSize = false;
            this.CurrentImageHeightTrackBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.CurrentImageHeightTrackBar.LargeChange = 20;
            this.CurrentImageHeightTrackBar.Location = new System.Drawing.Point(49, 56);
            this.CurrentImageHeightTrackBar.Margin = new System.Windows.Forms.Padding(2);
            this.CurrentImageHeightTrackBar.Maximum = 2000;
            this.CurrentImageHeightTrackBar.Minimum = 200;
            this.CurrentImageHeightTrackBar.Name = "CurrentImageHeightTrackBar";
            this.CurrentImageHeightTrackBar.Size = new System.Drawing.Size(127, 30);
            this.CurrentImageHeightTrackBar.TabIndex = 27;
            this.CurrentImageHeightTrackBar.TickFrequency = 150;
            this.CurrentImageHeightTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.CurrentImageHeightTrackBar.Value = 400;
            this.CurrentImageHeightTrackBar.Scroll += new System.EventHandler(this.CurrentImageHeightTrackBar_Scroll);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Width";
            // 
            // CurrentVertAlignComboBox
            // 
            this.CurrentVertAlignComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CurrentVertAlignComboBox.FormattingEnabled = true;
            this.CurrentVertAlignComboBox.Location = new System.Drawing.Point(66, 16);
            this.CurrentVertAlignComboBox.Name = "CurrentVertAlignComboBox";
            this.CurrentVertAlignComboBox.Size = new System.Drawing.Size(109, 21);
            this.CurrentVertAlignComboBox.TabIndex = 27;
            this.CurrentVertAlignComboBox.SelectedIndexChanged += new System.EventHandler(this.CurrentVertAlignComboBox_SelectedIndexChanged);
            // 
            // CurrentHoriAlignComboBox
            // 
            this.CurrentHoriAlignComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CurrentHoriAlignComboBox.FormattingEnabled = true;
            this.CurrentHoriAlignComboBox.Location = new System.Drawing.Point(66, 41);
            this.CurrentHoriAlignComboBox.Name = "CurrentHoriAlignComboBox";
            this.CurrentHoriAlignComboBox.Size = new System.Drawing.Size(109, 21);
            this.CurrentHoriAlignComboBox.TabIndex = 28;
            this.CurrentHoriAlignComboBox.SelectedIndexChanged += new System.EventHandler(this.CurrentHoriAlignComboBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Vertical";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Horizontal";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.CurrentVertAlignComboBox);
            this.groupBox2.Controls.Add(this.CurrentHoriAlignComboBox);
            this.groupBox2.Location = new System.Drawing.Point(3, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 70);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alignments";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.DefaultVertAlignComboBox);
            this.groupBox4.Controls.Add(this.DefaultHoriAlignComboBox);
            this.groupBox4.Location = new System.Drawing.Point(3, 174);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(181, 70);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Alignments";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 44);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "Horizontal";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 19);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 13);
            this.label18.TabIndex = 29;
            this.label18.Text = "Vertical";
            // 
            // DefaultVertAlignComboBox
            // 
            this.DefaultVertAlignComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DefaultVertAlignComboBox.FormattingEnabled = true;
            this.DefaultVertAlignComboBox.Location = new System.Drawing.Point(66, 16);
            this.DefaultVertAlignComboBox.Name = "DefaultVertAlignComboBox";
            this.DefaultVertAlignComboBox.Size = new System.Drawing.Size(109, 21);
            this.DefaultVertAlignComboBox.TabIndex = 27;
            // 
            // DefaultHoriAlignComboBox
            // 
            this.DefaultHoriAlignComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DefaultHoriAlignComboBox.FormattingEnabled = true;
            this.DefaultHoriAlignComboBox.Location = new System.Drawing.Point(66, 41);
            this.DefaultHoriAlignComboBox.Name = "DefaultHoriAlignComboBox";
            this.DefaultHoriAlignComboBox.Size = new System.Drawing.Size(109, 21);
            this.DefaultHoriAlignComboBox.TabIndex = 28;
            // 
            // SentencesToImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 444);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ImageFormatComboBox);
            this.Controls.Add(this.label4);
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
            ((System.ComponentModel.ISupportInitialize)(this.CurrentBackColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefaultBackColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultFontSizeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentImageWidthTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentFontSizeTrackBar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DefaultImageHeightTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefaultImageWidthTrackBar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentImageHeightTrackBar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.PictureBox CurrentBackColorBox;
        private System.Windows.Forms.PictureBox DefaultBackColorBox;
        private System.Windows.Forms.TrackBar defaultFontSizeTrackBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar CurrentImageWidthTrackBar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar CurrentFontSizeTrackBar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label DefaultFontSizeLabel;
        private System.Windows.Forms.Label CurrentFontSizeLabel;
        private System.Windows.Forms.Label CurrentImageWidthLabel;
        private System.Windows.Forms.Label ZoomLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button SetDefaultStyleToCurrentButton;
        private System.Windows.Forms.Button SetDefaultStyleToAllButton;
        private System.Windows.Forms.ComboBox ImageFormatComboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label CurrentImageHeightLabel;
        private System.Windows.Forms.TrackBar CurrentImageHeightTrackBar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label DefaultImageHeightLabel;
        private System.Windows.Forms.TrackBar DefaultImageHeightTrackBar;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label DefaultImageWidthLabel;
        private System.Windows.Forms.TrackBar DefaultImageWidthTrackBar;
        private System.Windows.Forms.ComboBox CurrentVertAlignComboBox;
        private System.Windows.Forms.ComboBox CurrentHoriAlignComboBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox DefaultVertAlignComboBox;
        private System.Windows.Forms.ComboBox DefaultHoriAlignComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

