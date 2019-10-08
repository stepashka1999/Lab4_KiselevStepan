using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Image<Hsv, byte> hueImage;
        private FinderPrimitives Finder;

        private void Config()
        {
            var bgrImage = new Image<Bgr, byte>(HueColor.Size);

            for(int y = 0; y<bgrImage.Height; y++)
                for(int x = 0; x < bgrImage.Width; x++)
                {     
                    bgrImage[y, x] = new Bgr(Color.White);
                }
            hueImage = bgrImage.Convert<Hsv, byte>();
            HueColor.Image = hueImage;
        }

        private void VisibleElements()
        {
            FiltrMenu.Visible = true;
            SaveImageMenuButton.Visible = true;

            Threshhold_tb.Visible = ThresholdBar.Visible = true;

            Area_tb.Visible = AreaBar.Visible = true;

            Dist_tb.Visible = DistBar.Visible = true;

            ThreshCircl_tb.Visible = ThreshCirclBar.Visible = true;

            MinRad_tb.Visible = MinRadBar.Visible = true;

            MaxRad_tb.Visible = MaxRadBar.Visible = true;

            MinAreaOfRect_tb.Visible = MinAreaOfRectBar.Visible = true;

            l0.Visible = l1.Visible = l2.Visible = l3.Visible = l4.Visible = l5.Visible = l6.Visible = true;

            Prim_lbl.Visible = triangle_lbl.Visible = Rect_lbl.Visible = Circl_lbl.Visible = true;
        }

        private void LoadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFD = new OpenFileDialog();

            var result = OpenFD.ShowDialog();

            if(result == DialogResult.OK)
            {
                Finder = new FinderPrimitives(OpenFD.FileName);
            }

            FirstImageBox.Image = Finder.SourseImage.Resize(FirstImageBox.Width, FirstImageBox.Height, Inter.Linear);

            VisibleElements();
        }

        private void BlackWhiteBlurToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SecondImageBox.Image = Finder.GrayImage.Resize(SecondImageBox.Width, SecondImageBox.Height, Inter.Linear);
        }

        private void FindContursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FirstImageBox.Image = Finder.AreaOfInteres(ThresholdBar.Value).Resize(FirstImageBox.Width, FirstImageBox.Height, Inter.Linear);

            SecondImageBox.Image = Finder.DrawContours(ThresholdBar.Value).Resize(SecondImageBox.Width, SecondImageBox.Height, Inter.Linear);
        }

        /*---Draw Primitives---*/
        private void DrowTrianglesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FirstImageBox.Image = Finder.AreaOfInteres(ThresholdBar.Value).Resize(FirstImageBox.Width, FirstImageBox.Height, Inter.Linear);

            Finder.FindTriangles(AreaBar.Value, ThresholdBar.Value);

            SecondImageBox.Image = Finder.DrawPrimitives(choose: 0, threshold: ThresholdBar.Value, minArea: AreaBar.Value).Resize(SecondImageBox.Width, SecondImageBox.Height, Inter.Linear);

            triangle_lbl.Text = $"Triangles: {Finder.FindTriangles(AreaBar.Value, ThresholdBar.Value).Count -2}";
            Circl_lbl.Text = "Circles: 0";
            Rect_lbl.Text = "Rectangles: 0";
        }

        private void DrawRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FirstImageBox.Image = Finder.AreaOfInteres(ThresholdBar.Value).Resize(FirstImageBox.Width, FirstImageBox.Height, Inter.Linear);

            SecondImageBox.Image = Finder.DrawPrimitives(1, MinAreaOfRectBar.Value, ThresholdBar.Value).Resize(SecondImageBox.Width, SecondImageBox.Height, Inter.Linear);

            Rect_lbl.Text = $"Rectangles: {Finder.FindRectangles( MinAreaOfRectBar.Value, ThresholdBar.Value).Count}";
            Circl_lbl.Text = "Circles: 0";
            triangle_lbl.Text = "Triangles: 0";
        }

        private void DrowCirclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FirstImageBox.Image = Finder.AreaOfInteres(ThresholdBar.Value).Resize(FirstImageBox.Width, FirstImageBox.Height, Inter.Linear);

            SecondImageBox.Image = Finder.DrawPrimitives(2, minDistance: DistBar.Value, acTreshold: ThreshCirclBar.Value, minRadius: MinRadBar.Value, maxRadius: MaxRadBar.Value).Resize(SecondImageBox.Width, SecondImageBox.Height, Inter.Linear);

            Circl_lbl.Text = $"Circles: {Finder.HoughtAlgoritm(DistBar.Value, ThreshCirclBar.Value,MinRadBar.Value, MaxRadBar.Value).Count}";
            Rect_lbl.Text = "Rectangles: 0";
            triangle_lbl.Text = "Triangles: 0";
        }

        private void DrawAllOfFindedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FirstImageBox.Image = Finder.AreaOfInteres(ThresholdBar.Value).Resize(FirstImageBox.Width, FirstImageBox.Height, Inter.Linear);

            SecondImageBox.Image = Finder.DrawPrimitives(3, MinAreaOfRectBar.Value, ThresholdBar.Value, DistBar.Value, ThreshCirclBar.Value, MinRadBar.Value, MaxRadBar.Value).Resize(SecondImageBox.Width, SecondImageBox.Height, Inter.Linear);

            Circl_lbl.Text = $"Circles: {Finder.HoughtAlgoritm(DistBar.Value, ThreshCirclBar.Value, MinRadBar.Value, MaxRadBar.Value).Count}";
            Rect_lbl.Text = $"Rectangles: {Finder.FindRectangles(MinAreaOfRectBar.Value, ThresholdBar.Value).Count}";
            triangle_lbl.Text = $"Triangles: {Finder.FindTriangles(AreaBar.Value, ThresholdBar.Value).Count - 2}";

        }

        /*---Scroll Bars---*/
        private void ThresholdBar_Scroll(object sender, EventArgs e)
        {
            Threshhold_tb.Text =ThresholdBar.Value.ToString();
        }

        private void AreaBar_Scroll(object sender, EventArgs e)
        {
            Area_tb.Text = AreaBar.Value.ToString();   
        }

        private void DistBar_Scroll(object sender, EventArgs e)
        {
            Dist_tb.Text = DistBar.Value.ToString();
            Finder.HoughtAlgoritm(DistBar.Value, ThreshCirclBar.Value,MinRadBar.Value, MaxRadBar.Value);
        }

        private void ThreshCirclBar_Scroll(object sender, EventArgs e)
        {
            ThreshCircl_tb.Text = ThreshCirclBar.Value.ToString();
            Finder.HoughtAlgoritm(DistBar.Value, ThreshCirclBar.Value, MinRadBar.Value, MaxRadBar.Value);
        }

        private void MinRadBar_Scroll(object sender, EventArgs e)
        {
            MinRad_tb.Text = MinRadBar.Value.ToString();
            Finder.HoughtAlgoritm(DistBar.Value, ThreshCirclBar.Value, MinRadBar.Value, MaxRadBar.Value);
        }

        private void MaxRadBar_Scroll(object sender, EventArgs e)
        {
            MaxRad_tb.Text =MaxRadBar.Value.ToString();
            Finder.HoughtAlgoritm(DistBar.Value, ThreshCirclBar.Value, MinRadBar.Value, MaxRadBar.Value);
        }

        private void MinAreaOfRectBar_Scroll(object sender, EventArgs e)
        {
            MinAreaOfRect_tb.Text =MinAreaOfRectBar.Value.ToString();
            Finder.FindRectangles(MinAreaOfRectBar.Value, ThresholdBar.Value);
        }

        private void ColorBar_Scroll(object sender, EventArgs e)
        {
            ColorFind_tb.Text = ColorBar.Value.ToString();

            
            for(int y = 0; y < hueImage.Height; y++)
                for(int x = 0; x < hueImage.Width; x++)
                {
                    hueImage.Data[y, x, 0] = Convert.ToByte(ColorBar.Value * (360 / 255));
                    hueImage.Data[y, x, 2] = Convert.ToByte(255 - (ColorBar.Value * (360 / 255)));
                }

            HueColor.Image = hueImage;
        }

        /*-----------------*/

        private void FindColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Config();

            HueColor.Visible = !HueColor.Visible;
            color_tb.Visible = !color_tb.Visible;
            ColorBar.Visible = !ColorBar.Visible;
            ColorFind_tb.Visible = !ColorFind_tb.Visible;

        }

        private void HueColor_MouseClick(object sender, MouseEventArgs e)
        {
            SecondImageBox.Image = Finder.FindColor(ColorBar.Value * (360 / 255)).Resize(SecondImageBox.Width, SecondImageBox.Height, Inter.Linear);
        }

        private void ROIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SecondImageBox.Image = Finder.RectOfInteres(1).Resize(SecondImageBox.Width,SecondImageBox.Height, Inter.Linear);
        }


        /*---Another Modified Methods---*/
        private void CannyEdgesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SecondImageBox.Image = Finder.CannyCont(ThresholdBar.Value).Resize(SecondImageBox.Width, SecondImageBox.Height, Inter.Linear);
        }

        private void DrawContoursCannyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SecondImageBox.Image = Finder.DrawContours(ThresholdBar.Value, 1).Resize(FirstImageBox.Width, FirstImageBox.Height, Inter.Linear);
        }

        private void TrianglesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SecondImageBox.Image = Finder.DrawPrimitives(choose: 0, threshold: ThresholdBar.Value, minArea: AreaBar.Value, choose_m: 1).Resize(SecondImageBox.Width, SecondImageBox.Height, Inter.Linear);
        }

        private void RectanglesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SecondImageBox.Image = Finder.DrawPrimitives(1, MinAreaOfRectBar.Value, ThresholdBar.Value, choose_m: 1).Resize(SecondImageBox.Width, SecondImageBox.Height, Inter.Linear);
        }

        private void ROIToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ROI_lbl.Visible = !ROI_lbl.Visible;
            ROI_Bar.Visible = !ROI_Bar.Visible;

            ROI_Bar.Maximum = Finder.GetNumOfPrimitives(ThresholdBar.Value) - 1;
        }

        private void ROI_Bar_Scroll(object sender, EventArgs e)
        {
            ROI_lbl.Text = $"ROI: {ROI_Bar.Value}";
            SecondImageBox.Image = Finder.RectOfInteres(ThresholdBar.Value, ROI_Bar.Value).Resize(SecondImageBox.Width, SecondImageBox.Height, Inter.Linear);
        }

        private void ShowPrimitivesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var primitives = Finder.FindPrimitives(ThresholdBar.Value);

            Area_cb.Visible = !Area_cb.Visible;
            Primitives_ComboBox.Visible = !Primitives_ComboBox.Visible;

            for (int i = 0; i < primitives.Count; i++)
            { 
                if (CvInvoke.ContourArea(primitives[i]) > 500.0)
                {
                    Primitives_ComboBox.Items.Add(i);
                }
            }
        }

        private void Primitives_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var primitives = Finder.FindPrimitives(ThresholdBar.Value);

            SecondImageBox.Image = Finder.DrowSelectedPrimitives((int)Primitives_ComboBox.SelectedItem, ThresholdBar.Value).Resize(SecondImageBox.Width, SecondImageBox.Height, Inter.Linear);
            Area_cb.Text = $"Area: {CvInvoke.ContourArea(primitives[(int)Primitives_ComboBox.SelectedItem])}";
        }

    }
}
