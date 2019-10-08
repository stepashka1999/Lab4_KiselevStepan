using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace Lab4
{
    class FinderPrimitives
    {
        /*---Images---*/

        public Image<Bgr, byte> SourseImage { get; private set; }
        public Image<Gray, byte> GrayImage { get; private set; }


        public FinderPrimitives(string FileName)
        {
            SourseImage = new Image<Bgr, byte>(FileName);

            GrayImage = new Image<Gray, byte>(SourseImage.Size);
            GrayImage = SourseImage.Convert<Gray, byte>();

            var kernelSize = 5;
            GrayImage = GrayImage.SmoothGaussian(kernelSize);
        }

        public Image<Gray, byte> AreaOfInteres(int threshold = 80, int color = 255)
        {
            //if pixel.Data[i,j,0]>treshold pixel.Data[i,j,0] = color

            var areaOfInterestImage = GrayImage.Copy();

            areaOfInterestImage = areaOfInterestImage.ThresholdBinary(new Gray(threshold), new Gray(color));

            return areaOfInterestImage;

        }

        private VectorOfVectorOfPoint FindOfContours(int threshold = 80, int choose = 0)
        {
            var contours = new VectorOfVectorOfPoint();

            if(choose == 0)
            CvInvoke.FindContours(AreaOfInteres(threshold), contours, null, RetrType.List, ChainApproxMethod.ChainApproxSimple);
            else
                CvInvoke.FindContours(CannyCont(threshold), contours, null, RetrType.List, ChainApproxMethod.ChainApproxSimple);
            /*---Аргументы на вход
             * 
             * 1 - Бинаризованное чб изображение
             * 2 - Куда записывать Найденные контуры
             * объект для хранения иерархии контуров (в данном случае не используется)
             * структура возвращаемых данных
             * методика апроксимации (сжимает горизонтальные, вертикальные и диагональные сегменты и оставляет только их конечные точки)
             *
             */
            return contours;
        }

        public Image<Bgr, byte> DrawContours( int threshold = 80, int choose = 0)
        {
            var contours = FindOfContours(threshold, choose );

            var ContoursImage = SourseImage.CopyBlank();

            for (int i = 0; i < contours.Size; i++)
            {
                ContoursImage.Draw(contours[i].ToArray(), new Bgr(Color.GreenYellow), 2); // 1 - массив точек, 2 - цвет, 3 - толщина
            }

            return ContoursImage;
        }

        public List<VectorOfPoint> FindPrimitives(int threshold, int choose = 0)
        {
            var contours = FindOfContours(threshold, choose);
   
            var approxContour = new List<VectorOfPoint>();

            for (int i = 0; i < contours.Size; i++)
            {
                var approx = new VectorOfPoint();

                CvInvoke.ApproxPolyDP(contours[i], approx, CvInvoke.ArcLength(contours[i], true) * 0.05, true);
                /*---Данные на вход
                 * 1 - Исходный контур
                 * 2 - Контур после аппроксимации
                 * 3 - Точность апроксимации, прямо пропорциональная площади контура
                 * 4 - Контур становится закрытым ( Первая и последняя точки соединяются )
                */

                approxContour.Add(approx);
            }

            return approxContour;
        }

        public List<Point[]> FindTriangles(int minArea = 500, int threshold = 80, int choose = 0)
        {
            var approxContour = FindPrimitives(threshold, choose);

            var listOfTriangles = new List<Point[]>();

            for(int i = 0; i< approxContour.Count; i++)
            if (approxContour[i].Size == 3)
            {
                if (CvInvoke.ContourArea(approxContour[i], false) > minArea)
                    listOfTriangles.Add(approxContour[i].ToArray());
            }

            return listOfTriangles;
        }

        public Image<Bgr, byte> DrawPrimitives(int choose, int area = 300, int threshold = 80, int minArea = 500, int minDistance = 250, int acTreshold = 36, int minRadius = 10, int maxRadius = 300, int choose_m = 0)//0 - Triangles, 1 - Rectangles, 2 - Circles, 3 - All of Finded
        {
            var PrimitivesImage = SourseImage.CopyBlank();

            var listOfRect = FindRectangles(area, threshold, choose_m);
            var listOfTriangles = FindTriangles(minArea, threshold, choose_m);
            var listOfCircles = HoughtAlgoritm(minDistance, acTreshold, minRadius, maxRadius);

            switch (choose)
            {
                case 0:

                    for (int i = 0; i < listOfTriangles.Count - 2; i++)
                        PrimitivesImage.Draw(new Triangle2DF(listOfTriangles[i][0], listOfTriangles[i][1], listOfTriangles[i][2]), new Bgr(Color.GreenYellow), 2);

                    break;
                case 1:
                    
                    for (int i = 0; i < listOfRect.Count; i++)
                        PrimitivesImage.Draw(CvInvoke.MinAreaRect(listOfRect[i].ToArray()), new Bgr(Color.GreenYellow), 2);
                    
                    break;
                case 2:

                    for (int i = 0; i < listOfCircles.Count; i++)
                        PrimitivesImage.Draw(listOfCircles[i], new Bgr(Color.GreenYellow), 2);

                    break;
                default:

                    if (listOfTriangles.Count > 0 )
                    {
                        for (int i = 0; i < listOfTriangles.Count; i++)
                            PrimitivesImage.Draw(new Triangle2DF(listOfTriangles[i][0], listOfTriangles[i][1], listOfTriangles[i][2]), new Bgr(Color.GreenYellow), 2);
                    }

                    if (listOfRect.Count > 0)
                    {
                        for (int i = 0; i < listOfRect.Count; i++)
                            PrimitivesImage.Draw(CvInvoke.MinAreaRect(listOfRect[i]), new Bgr(Color.GreenYellow), 2);
                    }

                    if (listOfCircles.Count > 0 && listOfCircles != null)
                    {
                        for (int i = 0; i < listOfCircles.Count; i++)
                            PrimitivesImage.Draw(listOfCircles[i], new Bgr(Color.GreenYellow), 2);
                    }

                    break;
            }

            return Sum(SourseImage, PrimitivesImage);
        }

         public Image<Bgr,byte> DrowSelectedPrimitives(int index, int threshold = 80)
         {
            var primitives = FindPrimitives(threshold);;

            var primitivesImage = SourseImage.CopyBlank();

            for(int i = 0; i < primitives[index].ToArray().Length; i++)
                primitivesImage.Draw(primitives[index].ToArray(), new Bgr(Color.Red), 3);

            var result = SourseImage.Copy();

            result = Sum(result, primitivesImage);

            return result;
         }


        private bool isRectangle(Point[] points, int minAreaOfRect)
        {
            int delta = 10;

            VectorOfPoint arr = new VectorOfPoint(points);

            LineSegment2D[] edges = PointCollection.PolyLine(points, true);

            for (int i = 0; i < edges.Length; i++)
            {
                double andle = Math.Abs(edges[(i + 1) % edges.Length].GetExteriorAngleDegree(edges[i]));

                if (andle < 90 - delta || andle > 90 + delta || CvInvoke.ContourArea(arr, false) < minAreaOfRect)
                {
                    return false;
                }
            }
            return true;
        }

        public List<PointF[]> FindRectangles(int area = 300, int threshold = 80, int choose = 0 )
        {
            var approxContour = FindPrimitives(threshold, choose);
            var listOfRect = new List<Point[]>();

            for (int i = 0; i < approxContour.Count; i++)
            {
                if (isRectangle(approxContour[i].ToArray(), area))
                   listOfRect.Add(approxContour[i].ToArray());
            }

            var findedRect = PointToPointF(listOfRect);

            return findedRect;
        }

        public List<CircleF> HoughtAlgoritm(int minDistance = 250, int acTreshold = 36, int minRadius = 10, int maxRadius = 300 )
        {
            var grayImage = SourseImage.Convert<Gray, byte>();
            var bluredImage = grayImage.SmoothGaussian(9);

            var listOfCircles = new List<CircleF>(CvInvoke.HoughCircles(bluredImage, HoughType.Gradient, 1.0, minDistance, 100, acTreshold, minRadius, maxRadius));

            return listOfCircles;
        }

        private List<PointF[]> PointToPointF(List<Point[]> point)
        {
            var listOfRectanglesF = new List<PointF[]>(point.Count);
            for (int i = 0; i < point.Count; i++)
            {
                var row = new PointF[point[i].Length];

                for (int j = 0; j < point[i].Length; j++)
                {
                    row[j].X = point[i][j].X;
                    row[j].Y = point[i][j].Y;
                }
                listOfRectanglesF.Add(row);
            }

            return listOfRectanglesF;
        }

        public Image<Gray, byte> FindColor(int color)
        {
            var hsvImage = SourseImage.Convert<Hsv, byte>();

            var hue = hsvImage.Split()[0];

            byte range = 10;

            var resultImage = hue.InRange(new Gray(Convert.ToByte(color) - range), new Gray(Convert.ToByte(color) + range));

            return resultImage;

        }

        public Image<Bgr,byte> RectOfInteres(int threshold = 80, int i = 0)
        {
            var primitives = FindPrimitives(threshold);
            var image = SourseImage.Copy();

            Rectangle rect = CvInvoke.BoundingRectangle(primitives[i]);
            image.ROI = rect;

            return image;
        }

        private Image<Bgr, byte> Sum(Image<Bgr,byte> img1, Image<Bgr, byte> img2)
        {
            img2.Resize(img1.Width, img1.Height, Inter.Linear);

            var res = img1.Copy();
           
            for(int y = 0; y< res.Height; y++)
                for(int x = 0; x < res.Width; x++)
                {
                    for(int ch = 0; ch < 3; ch++)
                    if(img2.Data[y, x, ch] > 0) res.Data[y, x, ch] = img2.Data[y, x, ch];
                }

            return res;
        }

        public int GetNumOfPrimitives(int threshold = 80)
        {
            return FindPrimitives(threshold).Count;
        }

        /*---Modified Methods*/

        public Image<Gray, byte> CannyCont(int threshold = 80)
        {
            var cannyEdges = GrayImage.Canny(threshold, threshold);

            return cannyEdges;
        }


    }
}
