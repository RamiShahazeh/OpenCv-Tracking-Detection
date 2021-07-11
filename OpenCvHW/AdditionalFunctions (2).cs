using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;
using System.Drawing;

namespace OpenCV.AdditionalFunctions
{
    public static class CvFunctions
    {
       


        public static void DrawContours(Mat binaryImg, Mat drawTargetImage, MCvScalar contourColor, MCvScalar centerColor)
        {
            using (Mat hierarchy = new Mat())
            using (VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint())
            {
                CvInvoke.FindContours(binaryImg, contours, hierarchy, RetrType.Tree, ChainApproxMethod.ChainApproxNone);

                for (int i = 0; i < contours.Size; i++)
                {

     
                    MCvMoments m = CvInvoke.Moments(contours[i], true);
                    int cX = (int)(m.M10 / m.M00);
                    int cY = (int)(m.M01 / m.M00);
                    CvInvoke.Circle(drawTargetImage, new Point(cX, cY), 1, centerColor, -1);
                    CvInvoke.DrawContours(drawTargetImage, contours, i, contourColor, 2);
                }
            }

        }
        static int pixelMapping(int x, int r1, int r2, int s1, int s2)
        {

            float result = 0;
            if (0 <= x && x <= r1)
            {
                result = s1 / r1 * x;
            }
            else if (r1 < x && x <= r2)
            {
                result = ((s2 - s1) / (r2 - r1)) * (x - r1) + s1;
            }
            else if (r2 < x && x <= 255)
            {
                result = ((255 - s2) / (255 - r2)) * (x - r2) + s2;
            }
            return (int)result;
        }

        public static Mat ContrastStretching(Mat grayImage, int inStart, int inEnd, int outStart, int outEnd)
        {
            if (inStart <= 0 | inStart >= inEnd | inEnd >= 255)
            {
                Console.WriteLine("No Changes: Input Range Must Be:\n 255>r2>r1>0");
                return grayImage;
            }
            Image<Gray, Byte> img = grayImage.ToImage<Gray, Byte>();
            for (int i = 0; i < img.Rows; i++)
            {
                for (int j = 0; j < img.Cols; j++)
                {
                    int res = pixelMapping(img.Data[i, j, 0], inStart, inEnd, outStart, outEnd);
                    img.Data[i, j, 0] = Convert.ToByte(res);
                }
            }
            return img.Mat;
        }
    }
}
