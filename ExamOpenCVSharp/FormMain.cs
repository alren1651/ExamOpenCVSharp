
using OpenCvSharp;
using OpenCvSharp.Dnn;
using OpenCvSharp.Extensions;

using Tesseract;

namespace ExamOpenCVSharp
{
    public partial class FormMain : Form
    {
        private VideoCapture capture;
        private Mat src;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
            timer1.Dispose();
            
            if(src != null && src.IsEnabledDispose) src.Dispose();

            if(capture != null && capture.IsEnabledDispose) capture.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lbl_bin_deg.Text = trackBar1.Value.ToString();

            //-----------------------------------------------------------------------------------------
            src = capture.RetrieveMat();

            Mat blur = Fn_Blurring(src);
            Mat bin  = Fn_Binarization(blur);
            Mat Edge = Fn_EdgeDetection(bin);

            // Original Camera Source
            pictureBox1.Image?.Dispose();
            pictureBox1.Image = BitmapConverter.ToBitmap(src);

            // 흐림 효과(Blurring)
            pictureBox2.Image?.Dispose();
            pictureBox2.Image = BitmapConverter.ToBitmap(blur);

            // 영상 이진화(Binarization)
            pictureBox3.Image?.Dispose();
            pictureBox3.Image = BitmapConverter.ToBitmap(bin);

            // 가장자리 검출(Edge Detection)
            pictureBox4.Image?.Dispose();
            pictureBox4.Image = BitmapConverter.ToBitmap(Edge);

            blur.Dispose();
            bin.Dispose();
            Edge.Dispose();
        }

        private void Btn_Capture_Click(object sender, EventArgs e)
        {
            try
            {
                capture = new();
                capture.FrameWidth = 640;
                capture.FrameHeight = 360;
                capture.Open(0, VideoCaptureAPIs.ANY);

                src = new();    // 원영상을 저장하는 공간

                if (capture.IsOpened())
                    timer1.Enabled = true;
                else
                {
                    capture.Dispose();
                    timer1.Enabled = false;
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_OCR_Tesseract_Click(object sender, EventArgs e)
        {
            Bitmap oc = (Bitmap)pictureBox3.Image;
            string ocr = OcrProcess(oc);

            Txt_Log.BeginInvoke(new MethodInvoker(delegate
            {
                Txt_Log.Text = ocr;
            }));
        }

        private string OcrProcess(Bitmap oc)
        {
            try
            {
                using (var engine = new TesseractEngine(@"./tessdata_best", "eng+kor", EngineMode.Default))
                {
                    using (var img = PixConverter.ToPix(oc))
                    {
                        using (var page = engine.Process(img))
                        {
                            return "Mean confidence: " + page.GetMeanConfidence() + "\r\nText : " + page.GetText();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        #region 흐림 효과(Blurring) 선택

        private Mat Fn_Blurring(Mat src)
        {
            Mat dst = new();
            BorderTypes borderTypes = BorderTypes.Default;
            if (RadBtn_Border_Constant.Checked)
                borderTypes = BorderTypes.Constant;
            if (RadBtn_Border_Replicate.Checked)
                borderTypes = BorderTypes.Replicate;
            if (RadBtn_Border_Reflect.Checked)
                borderTypes = BorderTypes.Reflect;
            if (RadBtn_Border_Wrap.Checked)
                borderTypes = BorderTypes.Wrap;
            if (RadBtn_Border_Reflect101.Checked)
                borderTypes = BorderTypes.Reflect101;
            if (RadBtn_Border_Default.Checked)
                borderTypes = BorderTypes.Default;
            if (RadBtn_Border_Transparent.Checked)
                borderTypes = BorderTypes.Transparent;
            if (RadBtn_Border_Isolated.Checked)
                borderTypes = BorderTypes.Isolated;

            Mat gray = new();
            Cv2.CvtColor(src, gray, ColorConversionCodes.BGR2GRAY);

            if (RadBtn_BlurNone.Checked)
                dst = gray;
            if (RadBtn_Blur.Checked)
                Cv2.Blur(gray, dst, new OpenCvSharp.Size(9, 9), new OpenCvSharp.Point(-1, -1), borderTypes);
            if (RadBtn_BoxFilter.Checked)
                Cv2.BoxFilter(gray, dst, MatType.CV_8UC3, new OpenCvSharp.Size(9, 9), new OpenCvSharp.Point(-1, -1), true, borderTypes);
            if (RadBtn_MedianBlur.Checked)
                Cv2.MedianBlur(gray, dst, 9);
            if (RadBtn_GaussianBlur.Checked)
                Cv2.GaussianBlur(gray, dst, new OpenCvSharp.Size(9, 9), 1, 1, borderTypes);
            if (RadBtn_BilateralFilter.Checked)
            {
                if (borderTypes == BorderTypes.Transparent) borderTypes = BorderTypes.Default;
                Cv2.BilateralFilter(gray, dst, 9, 3, 3, borderTypes);
            }

            return dst;
        }

        #endregion


        #region 영상 이진화(Binarization) 선택

        private Mat Fn_Binarization(Mat src)
        {
            Mat dst = new();
            ThresholdTypes bintype = ThresholdTypes.Binary;

            if(RadBtn_Binary.Checked)
                bintype = ThresholdTypes.Binary;
            if (RadBtn_BinaryInv.Checked)
                bintype = ThresholdTypes.BinaryInv;
            if (RadBtn_Trunc.Checked)
                bintype = ThresholdTypes.Trunc;
            if (RadBtn_Tozero.Checked)
                bintype = ThresholdTypes.Tozero;
            if (RadBtn_TozeroInv.Checked)
                bintype = ThresholdTypes.TozeroInv;
            if (RadBtn_Mask.Checked)
                bintype = ThresholdTypes.Mask;
            if (RadBtn_Otsu.Checked)
                bintype = ThresholdTypes.Otsu;
            if (RadBtn_Triangle.Checked)
                bintype = ThresholdTypes.Triangle;

            Cv2.Threshold(src, dst, trackBar1.Value, 255, bintype);

            return dst;
        }

        #endregion


        #region 가장자리 검출(Edge Detection) 선택

        private Mat Fn_EdgeDetection(Mat src)
        {
            Mat dst = new();

            if (RadBtn_Sobel.Checked)
            {
                Cv2.Sobel(src, dst, MatType.CV_32F, 1, 0, ksize: 3, scale: 1, delta: 0, BorderTypes.Default);
                dst.ConvertTo(dst, MatType.CV_8UC1);
            }

            if (RadBtn_Scharr.Checked)
            {
                Cv2.Scharr(src, dst, MatType.CV_32F, 1, 0, scale: 1, delta: 0, BorderTypes.Default);
                dst.ConvertTo(dst, MatType.CV_8UC1);
            }

            if (RadBtn_GaussianDetect.Checked)
            {
                Cv2.Laplacian(src, dst, MatType.CV_32F, ksize: 3, scale: 1, delta: 0, BorderTypes.Default);
                dst.ConvertTo(dst, MatType.CV_8UC1);
            }

            if (RadBtn_Canny.Checked)
            {
                Cv2.Canny(src, dst, 100, 200, 3, true);
            }

            return dst;
        }

        #endregion
    }
}