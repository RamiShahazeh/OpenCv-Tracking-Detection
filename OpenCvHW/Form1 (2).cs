using Emgu.CV;
using System;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV.CvEnum;
using OpenCV.AdditionalFunctions;
using Emgu.CV.Util;
using Emgu.CV.Structure;
using System.Threading.Tasks;

namespace OpenCvHW
{

    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            //tumorDetection();
            objectTracking();

        }


        void tumorDetection()
        {
            Mat img = new Mat();
            Mat grayImg = new Mat();
            Mat ReducedNoiseImage = new Mat();
            Mat ReducedContrast = new Mat();

            //read image
            img = CvInvoke.Imread("mri.jpg");
            CvInvoke.Imshow("original image", img);

            //convert it to gray scale
            CvInvoke.CvtColor(img, grayImg, ColorConversion.Bgr2Gray);
            //show image
            CvInvoke.Imshow("gray image", grayImg);
            //Reduce noise
            CvInvoke.GaussianBlur(grayImg, ReducedNoiseImage,new Size(3,3),0.5);
            //CvInvoke.Imshow("Reduced Noise image", ReducedNoiseImage);

            Mat CSImage = CvFunctions.ContrastStretching(ReducedNoiseImage, 150, 200, 200, 255);
            CvInvoke.Imshow("Contrast image", CSImage);

            Mat BinaryImage = new Mat();
            CvInvoke.Threshold(CSImage, BinaryImage, 200, 255, ThresholdType.Binary);
            CvInvoke.Imshow("Binary image", BinaryImage);

            Mat EnhancedImage = new Mat();

            Mat se = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new Point(-1, -1));


            CvInvoke.MorphologyEx(BinaryImage, EnhancedImage, MorphOp.Open, se, new Point(-1, -1), 1, BorderType.Default, CvInvoke.MorphologyDefaultBorderValue);

            CvInvoke.MorphologyEx(EnhancedImage, EnhancedImage, MorphOp.Close, se, new Point(-1, -1), 1, BorderType.Default, CvInvoke.MorphologyDefaultBorderValue);

            CvInvoke.Imshow("Enhanced image", EnhancedImage);
            Mat threshImEdges = new Mat();
            Mat contrastIm = new Mat();

            CvInvoke.Canny(EnhancedImage, threshImEdges, 0.5, 1);

            CvInvoke.Imshow("canny", threshImEdges);

            MCvScalar red = new MCvScalar(0, 0, 255);
            MCvScalar white = new MCvScalar(255, 255, 255);

            CvFunctions.DrawContours(threshImEdges, img, red, white);

            CvInvoke.Imshow("final result", img);

        }


        async void objectTracking()
        {

            string filename = "track.mkv";
            VideoCapture capture = new VideoCapture(filename);
            Mat frame = new Mat();
            Mat Enhancedframe = new Mat();
            Mat se = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new Point(-1, -1));
            Mat HSVFrame = new Mat();
            Mat binaryImg = new Mat();
            Mat EnhancedBinaryImg = new Mat();

            double TotalFrames = capture.GetCaptureProperty(CapProp.FrameCount);
            double Fps = capture.GetCaptureProperty(CapProp.Fps);
            int FrameNo = 0;
            while (FrameNo <= TotalFrames)
            {
                FrameNo++;
                capture.SetCaptureProperty(CapProp.PosFrames, FrameNo);
                capture.Read(frame);
                CvInvoke.GaussianBlur(frame, Enhancedframe, new Size(3, 3), 0.5);
                ImgBlurred.Image = frame;

                CvInvoke.CvtColor(Enhancedframe, HSVFrame, ColorConversion.Bgr2Hsv);
                CvInvoke.InRange(HSVFrame, new ScalarArray(new MCvScalar(0,50,50)), new ScalarArray(new MCvScalar(10,255,255)), binaryImg);
                imgBinary.Image = binaryImg;

                CvInvoke.MorphologyEx(binaryImg, EnhancedBinaryImg, MorphOp.Close, se, new Point(-1, -1), 3, BorderType.Default, CvInvoke.MorphologyDefaultBorderValue);
                imgMorph.Image = EnhancedBinaryImg;
                await Task.Delay(500 / (int)Fps);
            }

        }

    }
}
