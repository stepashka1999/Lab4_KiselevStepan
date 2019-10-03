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

        private Image<Gray, byte> AreaOfInterestImage;

        /*---Contours---*/

        private VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
        private List<VectorOfPoint> approxContour = new List<VectorOfPoint>();

        /*---Primitives---*/

        private List<Point[]> listOfTriangles = new List<Point[]>();
        private List<Point[]> listOfRectangles = new List<Point[]>();
        private List<PointF[]> listOfRectanglesF;
        private List<CircleF> listOfCircles;

        /*---Variables---*/

        public int threshold = 80;
        public int minArea = 500;
        public int minDistance = 250;
        public int acTreshold = 36;
        public int minRadius = 10;
        public int maxRadius = 300;
        public int minAreaOfRect = 300;


        public FinderPrimitives(string FileName)
        {
            SourseImage = new Image<Bgr, byte>(FileName);

            GrayImage = new Image<Gray, byte>(SourseImage.Size);
            GrayImage = SourseImage.Convert<Gray, byte>();

            var kernelSize = 5;
            GrayImage = GrayImage.SmoothGaussian(kernelSize);
        }

        public Image<Gray, byte> AreaOfInteres(int color = 255)
        {
            //if pixel.Data[i,j,0]>treshold pixel.Data[i,j,0] = color

            AreaOfInterestImage = GrayImage.Copy();

            AreaOfInterestImage = AreaOfInterestImage.ThresholdBinary(new Gray(threshold), new Gray(color));

            return AreaOfInterestImage;
        }

        private VectorOfVectorOfPoint FindOfContours()
        {
 
            CvInvoke.FindContours(AreaOfInterestImage, contours, null, RetrType.List, ChainApproxMethod.ChainApproxSimple);

            /*---Аргументы на вход
             * 1 - Бинаризованное чб изображение
             * 2 - Куда записывать Найденные контуры
             * объект для хранения иерархии контуров (в данном случае не используется)
             * структура возвращаемых данных
             * методика апроксимации (сжимает горизонтальные, вертикальные и диагональные сегменты и оставляет только их конечные точки)
            */
            return contours;
        }

        public Image<Bgr, byte> DrawContours()
        {
            FindOfContours();

            var ContoursImage = SourseImage.CopyBlank();

            for (int i = 0; i < contours.Size; i++)
            {
                Point[] points = new Point[contours[i].ToArray().Length];

                for(int j = 0; j < contours[i].ToArray().Length; j++)
                {
                    points[j] = Point.Round(contours[i].ToArray()[j]);
                }

                ContoursImage.Draw(points, new Bgr(Color.GreenYellow), 2); // 1 - массив точек, 2 - цвет, 3 - толщина
            }

            return ContoursImage;
        }

        private List<VectorOfPoint> FindPrimitives()
        {
            FindOfContours();

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

        private void FindTriangles()
        {
            FindPrimitives();
            for(int i = 0; i< approxContour.Count; i++)
            if (approxContour[i].Size == 3)
            {
                if (CvInvoke.ContourArea(approxContour[i], false) > minArea)
                    listOfTriangles.Add(approxContour[i].ToArray());
            }
        }

        public Image<Bgr, byte> DrawPrimitives(int choose)//0 - Triangles, 1 - Rectangles, 2 - Circles, 3 - All of Finded
        {
            var PrimitivesImage = SourseImage.CopyBlank();

            switch (choose)
            {
                case 0:

                    FindTriangles();

                    for (int i = 0; i < listOfTriangles.Count - 2; i++)
                    {
                        PrimitivesImage.Draw(new Triangle2DF(listOfTriangles[i][0], listOfTriangles[i][1], listOfTriangles[i][2]), new Bgr(Color.GreenYellow), 2);
                    }

                    break;
                case 1:

                    FindRectangles();
                    PointToPointF();

                    for (int i = 0; i < listOfRectangles.Count; i++)
                    {
                        PrimitivesImage.Draw(CvInvoke.MinAreaRect(listOfRectanglesF[i].ToArray()), new Bgr(Color.GreenYellow), 2);
                    }

                    break;
                case 2:

                    HoughtAlgoritm();

                    foreach (CircleF circle in listOfCircles) PrimitivesImage.Draw(circle, new Bgr(Color.GreenYellow), 2);

                    break;
                default:

                    FindTriangles();
                    FindRectangles();
                    PointToPointF();
                    HoughtAlgoritm();


                    if (listOfTriangles.Count > 0)
                    {
                        for (int i = 0; i < listOfTriangles.Count; i++)
                        {
                            PrimitivesImage.Draw(new Triangle2DF(listOfTriangles[i][0], listOfTriangles[i][1], listOfTriangles[i][2]), new Bgr(Color.GreenYellow), 2);
                        }
                    }

                    if (listOfRectangles.Count > 0)
                    {
                        PointToPointF();
                        for (int i = 0; i < listOfRectangles.Count; i++)
                        {
                            PrimitivesImage.Draw(CvInvoke.MinAreaRect(listOfRectanglesF[i]), new Bgr(Color.GreenYellow), 2);
                        }
                    }

                    if (listOfCircles.Count > 0)
                    {
                        foreach (CircleF circle in listOfCircles) PrimitivesImage.Draw(circle, new Bgr(Color.GreenYellow), 2);
                    }

                    break;
            }

            return PrimitivesImage;
        }

        private bool isRectangle(Point[] points)
        {
            int delta = 10;

            VectorOfPoint arr = new VectorOfPoint(points);

            LineSegment2D[] edges = PointCollection.PolyLine(points, true);

            for (int i = 0; i < edges.Length; i++)
            {
                double andle = Math.Abs(edges[(i + 1) % edges.Length].GetExteriorAngleDegree(edges[i]));

                if (andle < 90 - delta || andle > 90 + delta || CvInvoke.ContourArea(arr, false)<minAreaOfRect)
                {
                    return false;
                }
            }
            return true;
        }

        private void FindRectangles()
        {
            FindPrimitives();

            for (int i = 0; i < approxContour.Count; i++)
            {
                if (isRectangle(approxContour[i].ToArray()))
                   listOfRectangles.Add(approxContour[i].ToArray());

            } 
        }

        private void HoughtAlgoritm()
        {
            var grayImage = SourseImage.Convert<Gray, byte>();
            var bluredImage = grayImage.SmoothGaussian(9);

            listOfCircles = new List<CircleF>(CvInvoke.HoughCircles(bluredImage, HoughType.Gradient, 1.0, minDistance, 100, acTreshold, minRadius, maxRadius));
        }

        private void PointToPointF()
        {
            listOfRectanglesF = new List<PointF[]>(listOfRectangles.Count);
            for (int i = 0; i < listOfRectangles.Count; i++)
            {
                var point = new PointF[listOfRectangles[i].Length];

                for (int j = 0; j < listOfRectangles[i].Length; j++)
                {
                    point[j].X = listOfRectangles[i][j].X;
                    point[j].Y = listOfRectangles[i][j].Y;
                }
                listOfRectanglesF.Add(point);
            }
        }

        public Image<Gray, byte> FindColor(int color)
        {
            var hsvImage = SourseImage.Convert<Hsv, byte>();

            var hue = hsvImage.Split()[0];

            byte range = 10;

            var resultImage = hue.InRange(new Gray(Convert.ToByte(color) - range), new Gray(Convert.ToByte(color) + range));

            return resultImage;

        }

        public int GetNumberOfElement(int ch)//0-trianbles, 1 - rectangles, 2 - Circls
        {
            int num = 0;
            switch(ch)
            {
                case 0:
                    num = listOfTriangles.Count;
                    break;
                case 1:
                    num = listOfRectangles.Count;
                    break;
                case 2:
                    num = listOfCircles.Count;
                    break;
            }
            return num;
        }
    }
}
