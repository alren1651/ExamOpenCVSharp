namespace ExamOpenCVSharp
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Txt_Log = new System.Windows.Forms.RichTextBox();
            this.Btn_Capture = new System.Windows.Forms.Button();
            this.Btn_OCR_Tesseract = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GrpBx_Binarization = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Lbl_bin_deg = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.RadBtn_Triangle = new System.Windows.Forms.RadioButton();
            this.RadBtn_Mask = new System.Windows.Forms.RadioButton();
            this.RadBtn_Tozero = new System.Windows.Forms.RadioButton();
            this.RadBtn_BinaryInv = new System.Windows.Forms.RadioButton();
            this.RadBtn_Otsu = new System.Windows.Forms.RadioButton();
            this.RadBtn_TozeroInv = new System.Windows.Forms.RadioButton();
            this.RadBtn_Trunc = new System.Windows.Forms.RadioButton();
            this.RadBtn_Binary = new System.Windows.Forms.RadioButton();
            this.GrpBx_EdgeDetection = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.RadBtn_Canny = new System.Windows.Forms.RadioButton();
            this.RadBtn_Scharr = new System.Windows.Forms.RadioButton();
            this.RadBtn_GaussianDetect = new System.Windows.Forms.RadioButton();
            this.RadBtn_Sobel = new System.Windows.Forms.RadioButton();
            this.GrpBx_Blurring = new System.Windows.Forms.GroupBox();
            this.RadBtn_BilateralFilter = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.RadBtn_GaussianBlur = new System.Windows.Forms.RadioButton();
            this.RadBtn_BoxFilter = new System.Windows.Forms.RadioButton();
            this.RadBtn_MedianBlur = new System.Windows.Forms.RadioButton();
            this.RadBtn_BlurNone = new System.Windows.Forms.RadioButton();
            this.RadBtn_Blur = new System.Windows.Forms.RadioButton();
            this.GrpBx_BorderTypes = new System.Windows.Forms.GroupBox();
            this.RadBtn_Border_Isolated = new System.Windows.Forms.RadioButton();
            this.RadBtn_Border_Default = new System.Windows.Forms.RadioButton();
            this.RadBtn_Border_Wrap = new System.Windows.Forms.RadioButton();
            this.RadBtn_Border_Replicate = new System.Windows.Forms.RadioButton();
            this.RadBtn_Border_Transparent = new System.Windows.Forms.RadioButton();
            this.RadBtn_Border_Reflect101 = new System.Windows.Forms.RadioButton();
            this.RadBtn_Border_Reflect = new System.Windows.Forms.RadioButton();
            this.RadBtn_Border_Constant = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GrpBx_Binarization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.GrpBx_EdgeDetection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.GrpBx_Blurring.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.GrpBx_BorderTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(150, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 360);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Txt_Log
            // 
            this.Txt_Log.Font = new System.Drawing.Font("나눔고딕코딩", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_Log.Location = new System.Drawing.Point(1660, 120);
            this.Txt_Log.Name = "Txt_Log";
            this.Txt_Log.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.Txt_Log.Size = new System.Drawing.Size(230, 820);
            this.Txt_Log.TabIndex = 4;
            this.Txt_Log.Text = "";
            // 
            // Btn_Capture
            // 
            this.Btn_Capture.Font = new System.Drawing.Font("나눔고딕코딩", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Capture.Location = new System.Drawing.Point(1772, 20);
            this.Btn_Capture.Name = "Btn_Capture";
            this.Btn_Capture.Size = new System.Drawing.Size(120, 40);
            this.Btn_Capture.TabIndex = 5;
            this.Btn_Capture.Text = "Capture";
            this.Btn_Capture.UseVisualStyleBackColor = true;
            this.Btn_Capture.Click += new System.EventHandler(this.Btn_Capture_Click);
            // 
            // Btn_OCR_Tesseract
            // 
            this.Btn_OCR_Tesseract.Font = new System.Drawing.Font("나눔고딕코딩", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_OCR_Tesseract.Location = new System.Drawing.Point(1742, 70);
            this.Btn_OCR_Tesseract.Name = "Btn_OCR_Tesseract";
            this.Btn_OCR_Tesseract.Size = new System.Drawing.Size(150, 40);
            this.Btn_OCR_Tesseract.TabIndex = 5;
            this.Btn_OCR_Tesseract.Text = "[OCR] Tesseract";
            this.Btn_OCR_Tesseract.UseVisualStyleBackColor = true;
            this.Btn_OCR_Tesseract.Click += new System.EventHandler(this.Btn_OCR_Tesseract_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GrpBx_Binarization
            // 
            this.GrpBx_Binarization.Controls.Add(this.pictureBox3);
            this.GrpBx_Binarization.Controls.Add(this.Lbl_bin_deg);
            this.GrpBx_Binarization.Controls.Add(this.trackBar1);
            this.GrpBx_Binarization.Controls.Add(this.RadBtn_Triangle);
            this.GrpBx_Binarization.Controls.Add(this.RadBtn_Mask);
            this.GrpBx_Binarization.Controls.Add(this.RadBtn_Tozero);
            this.GrpBx_Binarization.Controls.Add(this.RadBtn_BinaryInv);
            this.GrpBx_Binarization.Controls.Add(this.RadBtn_Otsu);
            this.GrpBx_Binarization.Controls.Add(this.RadBtn_TozeroInv);
            this.GrpBx_Binarization.Controls.Add(this.RadBtn_Trunc);
            this.GrpBx_Binarization.Controls.Add(this.RadBtn_Binary);
            this.GrpBx_Binarization.Location = new System.Drawing.Point(20, 490);
            this.GrpBx_Binarization.Name = "GrpBx_Binarization";
            this.GrpBx_Binarization.Size = new System.Drawing.Size(790, 450);
            this.GrpBx_Binarization.TabIndex = 6;
            this.GrpBx_Binarization.TabStop = false;
            this.GrpBx_Binarization.Text = "Binarization";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(130, 30);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(640, 360);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // Lbl_bin_deg
            // 
            this.Lbl_bin_deg.AutoSize = true;
            this.Lbl_bin_deg.Location = new System.Drawing.Point(289, 410);
            this.Lbl_bin_deg.Name = "Lbl_bin_deg";
            this.Lbl_bin_deg.Size = new System.Drawing.Size(140, 14);
            this.Lbl_bin_deg.TabIndex = 3;
            this.Lbl_bin_deg.Text = "Binary Degree : 120";
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Location = new System.Drawing.Point(435, 400);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(334, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Value = 120;
            // 
            // RadBtn_Triangle
            // 
            this.RadBtn_Triangle.AutoSize = true;
            this.RadBtn_Triangle.Location = new System.Drawing.Point(20, 198);
            this.RadBtn_Triangle.Name = "RadBtn_Triangle";
            this.RadBtn_Triangle.Size = new System.Drawing.Size(81, 18);
            this.RadBtn_Triangle.TabIndex = 1;
            this.RadBtn_Triangle.Text = "Triangle";
            this.RadBtn_Triangle.UseVisualStyleBackColor = true;
            // 
            // RadBtn_Mask
            // 
            this.RadBtn_Mask.AutoSize = true;
            this.RadBtn_Mask.Location = new System.Drawing.Point(20, 150);
            this.RadBtn_Mask.Name = "RadBtn_Mask";
            this.RadBtn_Mask.Size = new System.Drawing.Size(53, 18);
            this.RadBtn_Mask.TabIndex = 1;
            this.RadBtn_Mask.Text = "Mask";
            this.RadBtn_Mask.UseVisualStyleBackColor = true;
            // 
            // RadBtn_Tozero
            // 
            this.RadBtn_Tozero.AutoSize = true;
            this.RadBtn_Tozero.Checked = true;
            this.RadBtn_Tozero.Location = new System.Drawing.Point(20, 102);
            this.RadBtn_Tozero.Name = "RadBtn_Tozero";
            this.RadBtn_Tozero.Size = new System.Drawing.Size(67, 18);
            this.RadBtn_Tozero.TabIndex = 1;
            this.RadBtn_Tozero.TabStop = true;
            this.RadBtn_Tozero.Text = "Tozero";
            this.RadBtn_Tozero.UseVisualStyleBackColor = true;
            // 
            // RadBtn_BinaryInv
            // 
            this.RadBtn_BinaryInv.AutoSize = true;
            this.RadBtn_BinaryInv.Location = new System.Drawing.Point(20, 54);
            this.RadBtn_BinaryInv.Name = "RadBtn_BinaryInv";
            this.RadBtn_BinaryInv.Size = new System.Drawing.Size(88, 18);
            this.RadBtn_BinaryInv.TabIndex = 1;
            this.RadBtn_BinaryInv.Text = "BinaryInv";
            this.RadBtn_BinaryInv.UseVisualStyleBackColor = true;
            // 
            // RadBtn_Otsu
            // 
            this.RadBtn_Otsu.AutoSize = true;
            this.RadBtn_Otsu.Location = new System.Drawing.Point(20, 174);
            this.RadBtn_Otsu.Name = "RadBtn_Otsu";
            this.RadBtn_Otsu.Size = new System.Drawing.Size(53, 18);
            this.RadBtn_Otsu.TabIndex = 0;
            this.RadBtn_Otsu.Text = "Otsu";
            this.RadBtn_Otsu.UseVisualStyleBackColor = true;
            // 
            // RadBtn_TozeroInv
            // 
            this.RadBtn_TozeroInv.AutoSize = true;
            this.RadBtn_TozeroInv.Location = new System.Drawing.Point(20, 126);
            this.RadBtn_TozeroInv.Name = "RadBtn_TozeroInv";
            this.RadBtn_TozeroInv.Size = new System.Drawing.Size(88, 18);
            this.RadBtn_TozeroInv.TabIndex = 0;
            this.RadBtn_TozeroInv.Text = "TozeroInv";
            this.RadBtn_TozeroInv.UseVisualStyleBackColor = true;
            // 
            // RadBtn_Trunc
            // 
            this.RadBtn_Trunc.AutoSize = true;
            this.RadBtn_Trunc.Location = new System.Drawing.Point(20, 78);
            this.RadBtn_Trunc.Name = "RadBtn_Trunc";
            this.RadBtn_Trunc.Size = new System.Drawing.Size(60, 18);
            this.RadBtn_Trunc.TabIndex = 0;
            this.RadBtn_Trunc.Text = "Trunc";
            this.RadBtn_Trunc.UseVisualStyleBackColor = true;
            // 
            // RadBtn_Binary
            // 
            this.RadBtn_Binary.AutoSize = true;
            this.RadBtn_Binary.Location = new System.Drawing.Point(20, 30);
            this.RadBtn_Binary.Name = "RadBtn_Binary";
            this.RadBtn_Binary.Size = new System.Drawing.Size(67, 18);
            this.RadBtn_Binary.TabIndex = 0;
            this.RadBtn_Binary.Text = "Binary";
            this.RadBtn_Binary.UseVisualStyleBackColor = true;
            // 
            // GrpBx_EdgeDetection
            // 
            this.GrpBx_EdgeDetection.Controls.Add(this.pictureBox4);
            this.GrpBx_EdgeDetection.Controls.Add(this.RadBtn_Canny);
            this.GrpBx_EdgeDetection.Controls.Add(this.RadBtn_Scharr);
            this.GrpBx_EdgeDetection.Controls.Add(this.RadBtn_GaussianDetect);
            this.GrpBx_EdgeDetection.Controls.Add(this.RadBtn_Sobel);
            this.GrpBx_EdgeDetection.Location = new System.Drawing.Point(830, 490);
            this.GrpBx_EdgeDetection.Name = "GrpBx_EdgeDetection";
            this.GrpBx_EdgeDetection.Size = new System.Drawing.Size(810, 450);
            this.GrpBx_EdgeDetection.TabIndex = 7;
            this.GrpBx_EdgeDetection.TabStop = false;
            this.GrpBx_EdgeDetection.Text = "Edge Detection";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(150, 30);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(640, 360);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // RadBtn_Canny
            // 
            this.RadBtn_Canny.AutoSize = true;
            this.RadBtn_Canny.Location = new System.Drawing.Point(20, 102);
            this.RadBtn_Canny.Name = "RadBtn_Canny";
            this.RadBtn_Canny.Size = new System.Drawing.Size(95, 18);
            this.RadBtn_Canny.TabIndex = 4;
            this.RadBtn_Canny.Text = "Canny Edge";
            this.RadBtn_Canny.UseVisualStyleBackColor = true;
            // 
            // RadBtn_Scharr
            // 
            this.RadBtn_Scharr.AutoSize = true;
            this.RadBtn_Scharr.Location = new System.Drawing.Point(20, 54);
            this.RadBtn_Scharr.Name = "RadBtn_Scharr";
            this.RadBtn_Scharr.Size = new System.Drawing.Size(67, 18);
            this.RadBtn_Scharr.TabIndex = 5;
            this.RadBtn_Scharr.Text = "Scharr";
            this.RadBtn_Scharr.UseVisualStyleBackColor = true;
            // 
            // RadBtn_GaussianDetect
            // 
            this.RadBtn_GaussianDetect.AutoSize = true;
            this.RadBtn_GaussianDetect.Checked = true;
            this.RadBtn_GaussianDetect.Location = new System.Drawing.Point(20, 78);
            this.RadBtn_GaussianDetect.Name = "RadBtn_GaussianDetect";
            this.RadBtn_GaussianDetect.Size = new System.Drawing.Size(81, 18);
            this.RadBtn_GaussianDetect.TabIndex = 2;
            this.RadBtn_GaussianDetect.TabStop = true;
            this.RadBtn_GaussianDetect.Text = "Gaussian";
            this.RadBtn_GaussianDetect.UseVisualStyleBackColor = true;
            // 
            // RadBtn_Sobel
            // 
            this.RadBtn_Sobel.AutoSize = true;
            this.RadBtn_Sobel.Location = new System.Drawing.Point(20, 30);
            this.RadBtn_Sobel.Name = "RadBtn_Sobel";
            this.RadBtn_Sobel.Size = new System.Drawing.Size(60, 18);
            this.RadBtn_Sobel.TabIndex = 3;
            this.RadBtn_Sobel.Text = "Sobel";
            this.RadBtn_Sobel.UseVisualStyleBackColor = true;
            // 
            // GrpBx_Blurring
            // 
            this.GrpBx_Blurring.Controls.Add(this.GrpBx_BorderTypes);
            this.GrpBx_Blurring.Controls.Add(this.RadBtn_BilateralFilter);
            this.GrpBx_Blurring.Controls.Add(this.pictureBox2);
            this.GrpBx_Blurring.Controls.Add(this.RadBtn_GaussianBlur);
            this.GrpBx_Blurring.Controls.Add(this.RadBtn_BoxFilter);
            this.GrpBx_Blurring.Controls.Add(this.RadBtn_MedianBlur);
            this.GrpBx_Blurring.Controls.Add(this.RadBtn_BlurNone);
            this.GrpBx_Blurring.Controls.Add(this.RadBtn_Blur);
            this.GrpBx_Blurring.Location = new System.Drawing.Point(830, 20);
            this.GrpBx_Blurring.Name = "GrpBx_Blurring";
            this.GrpBx_Blurring.Size = new System.Drawing.Size(810, 450);
            this.GrpBx_Blurring.TabIndex = 8;
            this.GrpBx_Blurring.TabStop = false;
            this.GrpBx_Blurring.Text = "Blurring";
            // 
            // RadBtn_BilateralFilter
            // 
            this.RadBtn_BilateralFilter.AutoSize = true;
            this.RadBtn_BilateralFilter.Checked = true;
            this.RadBtn_BilateralFilter.Location = new System.Drawing.Point(20, 150);
            this.RadBtn_BilateralFilter.Name = "RadBtn_BilateralFilter";
            this.RadBtn_BilateralFilter.Size = new System.Drawing.Size(130, 18);
            this.RadBtn_BilateralFilter.TabIndex = 7;
            this.RadBtn_BilateralFilter.TabStop = true;
            this.RadBtn_BilateralFilter.Text = "BilateralFilter";
            this.RadBtn_BilateralFilter.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(150, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(640, 360);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // RadBtn_GaussianBlur
            // 
            this.RadBtn_GaussianBlur.AutoSize = true;
            this.RadBtn_GaussianBlur.Location = new System.Drawing.Point(20, 126);
            this.RadBtn_GaussianBlur.Name = "RadBtn_GaussianBlur";
            this.RadBtn_GaussianBlur.Size = new System.Drawing.Size(109, 18);
            this.RadBtn_GaussianBlur.TabIndex = 4;
            this.RadBtn_GaussianBlur.Text = "GaussianBlur";
            this.RadBtn_GaussianBlur.UseVisualStyleBackColor = true;
            // 
            // RadBtn_BoxFilter
            // 
            this.RadBtn_BoxFilter.AutoSize = true;
            this.RadBtn_BoxFilter.Location = new System.Drawing.Point(20, 78);
            this.RadBtn_BoxFilter.Name = "RadBtn_BoxFilter";
            this.RadBtn_BoxFilter.Size = new System.Drawing.Size(88, 18);
            this.RadBtn_BoxFilter.TabIndex = 5;
            this.RadBtn_BoxFilter.Text = "BoxFilter";
            this.RadBtn_BoxFilter.UseVisualStyleBackColor = true;
            // 
            // RadBtn_MedianBlur
            // 
            this.RadBtn_MedianBlur.AutoSize = true;
            this.RadBtn_MedianBlur.Location = new System.Drawing.Point(20, 102);
            this.RadBtn_MedianBlur.Name = "RadBtn_MedianBlur";
            this.RadBtn_MedianBlur.Size = new System.Drawing.Size(95, 18);
            this.RadBtn_MedianBlur.TabIndex = 2;
            this.RadBtn_MedianBlur.Text = "MedianBlur";
            this.RadBtn_MedianBlur.UseVisualStyleBackColor = true;
            // 
            // RadBtn_BlurNone
            // 
            this.RadBtn_BlurNone.AutoSize = true;
            this.RadBtn_BlurNone.Location = new System.Drawing.Point(20, 30);
            this.RadBtn_BlurNone.Name = "RadBtn_BlurNone";
            this.RadBtn_BlurNone.Size = new System.Drawing.Size(53, 18);
            this.RadBtn_BlurNone.TabIndex = 3;
            this.RadBtn_BlurNone.Text = "None";
            this.RadBtn_BlurNone.UseVisualStyleBackColor = true;
            // 
            // RadBtn_Blur
            // 
            this.RadBtn_Blur.AutoSize = true;
            this.RadBtn_Blur.Location = new System.Drawing.Point(20, 54);
            this.RadBtn_Blur.Name = "RadBtn_Blur";
            this.RadBtn_Blur.Size = new System.Drawing.Size(53, 18);
            this.RadBtn_Blur.TabIndex = 3;
            this.RadBtn_Blur.Text = "Blur";
            this.RadBtn_Blur.UseVisualStyleBackColor = true;
            // 
            // GrpBx_BorderTypes
            // 
            this.GrpBx_BorderTypes.Controls.Add(this.RadBtn_Border_Isolated);
            this.GrpBx_BorderTypes.Controls.Add(this.RadBtn_Border_Default);
            this.GrpBx_BorderTypes.Controls.Add(this.RadBtn_Border_Wrap);
            this.GrpBx_BorderTypes.Controls.Add(this.RadBtn_Border_Replicate);
            this.GrpBx_BorderTypes.Controls.Add(this.RadBtn_Border_Transparent);
            this.GrpBx_BorderTypes.Controls.Add(this.RadBtn_Border_Reflect101);
            this.GrpBx_BorderTypes.Controls.Add(this.RadBtn_Border_Reflect);
            this.GrpBx_BorderTypes.Controls.Add(this.RadBtn_Border_Constant);
            this.GrpBx_BorderTypes.Font = new System.Drawing.Font("나눔고딕코딩", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GrpBx_BorderTypes.Location = new System.Drawing.Point(20, 200);
            this.GrpBx_BorderTypes.Name = "GrpBx_BorderTypes";
            this.GrpBx_BorderTypes.Size = new System.Drawing.Size(110, 230);
            this.GrpBx_BorderTypes.TabIndex = 8;
            this.GrpBx_BorderTypes.TabStop = false;
            this.GrpBx_BorderTypes.Text = "BorderTypes";
            // 
            // RadBtn_Border_Isolated
            // 
            this.RadBtn_Border_Isolated.AutoSize = true;
            this.RadBtn_Border_Isolated.Location = new System.Drawing.Point(20, 198);
            this.RadBtn_Border_Isolated.Name = "RadBtn_Border_Isolated";
            this.RadBtn_Border_Isolated.Size = new System.Drawing.Size(71, 16);
            this.RadBtn_Border_Isolated.TabIndex = 1;
            this.RadBtn_Border_Isolated.Text = "Isolated";
            this.RadBtn_Border_Isolated.UseVisualStyleBackColor = true;
            // 
            // RadBtn_Border_Default
            // 
            this.RadBtn_Border_Default.AutoSize = true;
            this.RadBtn_Border_Default.Checked = true;
            this.RadBtn_Border_Default.Location = new System.Drawing.Point(20, 150);
            this.RadBtn_Border_Default.Name = "RadBtn_Border_Default";
            this.RadBtn_Border_Default.Size = new System.Drawing.Size(65, 16);
            this.RadBtn_Border_Default.TabIndex = 1;
            this.RadBtn_Border_Default.TabStop = true;
            this.RadBtn_Border_Default.Text = "Default";
            this.RadBtn_Border_Default.UseVisualStyleBackColor = true;
            // 
            // RadBtn_Border_Wrap
            // 
            this.RadBtn_Border_Wrap.AutoSize = true;
            this.RadBtn_Border_Wrap.Location = new System.Drawing.Point(20, 102);
            this.RadBtn_Border_Wrap.Name = "RadBtn_Border_Wrap";
            this.RadBtn_Border_Wrap.Size = new System.Drawing.Size(47, 16);
            this.RadBtn_Border_Wrap.TabIndex = 1;
            this.RadBtn_Border_Wrap.Text = "Wrap";
            this.RadBtn_Border_Wrap.UseVisualStyleBackColor = true;
            // 
            // RadBtn_Border_Replicate
            // 
            this.RadBtn_Border_Replicate.AutoSize = true;
            this.RadBtn_Border_Replicate.Location = new System.Drawing.Point(20, 54);
            this.RadBtn_Border_Replicate.Name = "RadBtn_Border_Replicate";
            this.RadBtn_Border_Replicate.Size = new System.Drawing.Size(77, 16);
            this.RadBtn_Border_Replicate.TabIndex = 1;
            this.RadBtn_Border_Replicate.Text = "Replicate";
            this.RadBtn_Border_Replicate.UseVisualStyleBackColor = true;
            // 
            // RadBtn_Border_Transparent
            // 
            this.RadBtn_Border_Transparent.AutoSize = true;
            this.RadBtn_Border_Transparent.Location = new System.Drawing.Point(20, 174);
            this.RadBtn_Border_Transparent.Name = "RadBtn_Border_Transparent";
            this.RadBtn_Border_Transparent.Size = new System.Drawing.Size(89, 16);
            this.RadBtn_Border_Transparent.TabIndex = 0;
            this.RadBtn_Border_Transparent.Text = "Transparent";
            this.RadBtn_Border_Transparent.UseVisualStyleBackColor = true;
            // 
            // RadBtn_Border_Reflect101
            // 
            this.RadBtn_Border_Reflect101.AutoSize = true;
            this.RadBtn_Border_Reflect101.Location = new System.Drawing.Point(20, 126);
            this.RadBtn_Border_Reflect101.Name = "RadBtn_Border_Reflect101";
            this.RadBtn_Border_Reflect101.Size = new System.Drawing.Size(83, 16);
            this.RadBtn_Border_Reflect101.TabIndex = 0;
            this.RadBtn_Border_Reflect101.Text = "Reflect101";
            this.RadBtn_Border_Reflect101.UseVisualStyleBackColor = true;
            // 
            // RadBtn_Border_Reflect
            // 
            this.RadBtn_Border_Reflect.AutoSize = true;
            this.RadBtn_Border_Reflect.Location = new System.Drawing.Point(20, 78);
            this.RadBtn_Border_Reflect.Name = "RadBtn_Border_Reflect";
            this.RadBtn_Border_Reflect.Size = new System.Drawing.Size(65, 16);
            this.RadBtn_Border_Reflect.TabIndex = 0;
            this.RadBtn_Border_Reflect.Text = "Reflect";
            this.RadBtn_Border_Reflect.UseVisualStyleBackColor = true;
            // 
            // RadBtn_Border_Constant
            // 
            this.RadBtn_Border_Constant.AutoSize = true;
            this.RadBtn_Border_Constant.Location = new System.Drawing.Point(20, 30);
            this.RadBtn_Border_Constant.Name = "RadBtn_Border_Constant";
            this.RadBtn_Border_Constant.Size = new System.Drawing.Size(71, 16);
            this.RadBtn_Border_Constant.TabIndex = 0;
            this.RadBtn_Border_Constant.Text = "Constant";
            this.RadBtn_Border_Constant.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1904, 1001);
            this.Controls.Add(this.GrpBx_Blurring);
            this.Controls.Add(this.GrpBx_EdgeDetection);
            this.Controls.Add(this.GrpBx_Binarization);
            this.Controls.Add(this.Btn_OCR_Tesseract);
            this.Controls.Add(this.Btn_Capture);
            this.Controls.Add(this.Txt_Log);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("나눔고딕코딩", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GrpBx_Binarization.ResumeLayout(false);
            this.GrpBx_Binarization.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.GrpBx_EdgeDetection.ResumeLayout(false);
            this.GrpBx_EdgeDetection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.GrpBx_Blurring.ResumeLayout(false);
            this.GrpBx_Blurring.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.GrpBx_BorderTypes.ResumeLayout(false);
            this.GrpBx_BorderTypes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox pictureBox1;
        private RichTextBox Txt_Log;
        private Button Btn_Capture;
        private Button Btn_OCR_Tesseract;
        private System.Windows.Forms.Timer timer1;
        private GroupBox GrpBx_Binarization;
        private RadioButton RadBtn_Triangle;
        private RadioButton RadBtn_Mask;
        private RadioButton RadBtn_Tozero;
        private RadioButton RadBtn_BinaryInv;
        private RadioButton RadBtn_Otsu;
        private RadioButton RadBtn_TozeroInv;
        private RadioButton RadBtn_Trunc;
        private RadioButton RadBtn_Binary;
        private TrackBar trackBar1;
        private Label Lbl_bin_deg;
        private GroupBox GrpBx_EdgeDetection;
        private RadioButton RadBtn_Canny;
        private RadioButton RadBtn_Scharr;
        private RadioButton RadBtn_GaussianDetect;
        private RadioButton RadBtn_Sobel;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private GroupBox GrpBx_Blurring;
        private PictureBox pictureBox2;
        private RadioButton RadBtn_GaussianBlur;
        private RadioButton RadBtn_BoxFilter;
        private RadioButton RadBtn_MedianBlur;
        private RadioButton RadBtn_Blur;
        private RadioButton RadBtn_BilateralFilter;
        private RadioButton RadBtn_BlurNone;
        private GroupBox GrpBx_BorderTypes;
        private RadioButton RadBtn_Border_Isolated;
        private RadioButton RadBtn_Border_Default;
        private RadioButton RadBtn_Border_Wrap;
        private RadioButton RadBtn_Border_Replicate;
        private RadioButton RadBtn_Border_Transparent;
        private RadioButton RadBtn_Border_Reflect101;
        private RadioButton RadBtn_Border_Reflect;
        private RadioButton RadBtn_Border_Constant;
    }
}