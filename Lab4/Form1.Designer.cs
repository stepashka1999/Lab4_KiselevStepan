namespace Lab4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.FirstImageBox = new Emgu.CV.UI.ImageBox();
            this.SecondImageBox = new Emgu.CV.UI.ImageBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FiltrMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.blackWhiteBlurToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.findContursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findPrimitivesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drowTrianglesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drowCirclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawAllOfFindedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveImageMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ThresholdBar = new System.Windows.Forms.TrackBar();
            this.Threshhold_tb = new System.Windows.Forms.Label();
            this.Area_tb = new System.Windows.Forms.Label();
            this.AreaBar = new System.Windows.Forms.TrackBar();
            this.Dist_tb = new System.Windows.Forms.Label();
            this.DistBar = new System.Windows.Forms.TrackBar();
            this.ThreshCircl_tb = new System.Windows.Forms.Label();
            this.ThreshCirclBar = new System.Windows.Forms.TrackBar();
            this.MinRad_tb = new System.Windows.Forms.Label();
            this.MinRadBar = new System.Windows.Forms.TrackBar();
            this.MaxRad_tb = new System.Windows.Forms.Label();
            this.MaxRadBar = new System.Windows.Forms.TrackBar();
            this.MinAreaOfRect_tb = new System.Windows.Forms.Label();
            this.MinAreaOfRectBar = new System.Windows.Forms.TrackBar();
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l0 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.l5 = new System.Windows.Forms.Label();
            this.l6 = new System.Windows.Forms.Label();
            this.color_tb = new System.Windows.Forms.Label();
            this.ColorFind_tb = new System.Windows.Forms.Label();
            this.ColorBar = new System.Windows.Forms.TrackBar();
            this.HueColor = new Emgu.CV.UI.ImageBox();
            this.triangle_lbl = new System.Windows.Forms.Label();
            this.Rect_lbl = new System.Windows.Forms.Label();
            this.Circl_lbl = new System.Windows.Forms.Label();
            this.Prim_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FirstImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondImageBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThresholdBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AreaBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DistBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThreshCirclBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinRadBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxRadBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinAreaOfRectBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HueColor)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstImageBox
            // 
            this.FirstImageBox.Location = new System.Drawing.Point(2, 121);
            this.FirstImageBox.Name = "FirstImageBox";
            this.FirstImageBox.Size = new System.Drawing.Size(494, 383);
            this.FirstImageBox.TabIndex = 2;
            this.FirstImageBox.TabStop = false;
            // 
            // SecondImageBox
            // 
            this.SecondImageBox.Location = new System.Drawing.Point(502, 121);
            this.SecondImageBox.Name = "SecondImageBox";
            this.SecondImageBox.Size = new System.Drawing.Size(494, 383);
            this.SecondImageBox.TabIndex = 3;
            this.SecondImageBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Исходное изображение:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(499, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Результат:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadImageToolStripMenuItem,
            this.FiltrMenu,
            this.SaveImageMenuButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(999, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadImageToolStripMenuItem
            // 
            this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.loadImageToolStripMenuItem.Text = "Load Image";
            this.loadImageToolStripMenuItem.Click += new System.EventHandler(this.LoadImageToolStripMenuItem_Click);
            // 
            // FiltrMenu
            // 
            this.FiltrMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blackWhiteBlurToolStripMenuItem1,
            this.findContursToolStripMenuItem,
            this.findPrimitivesToolStripMenuItem,
            this.findColorToolStripMenuItem});
            this.FiltrMenu.Name = "FiltrMenu";
            this.FiltrMenu.Size = new System.Drawing.Size(39, 20);
            this.FiltrMenu.Text = "Filtr";
            this.FiltrMenu.Visible = false;
            // 
            // blackWhiteBlurToolStripMenuItem1
            // 
            this.blackWhiteBlurToolStripMenuItem1.Name = "blackWhiteBlurToolStripMenuItem1";
            this.blackWhiteBlurToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.blackWhiteBlurToolStripMenuItem1.Text = "BlackWhite + Blur";
            this.blackWhiteBlurToolStripMenuItem1.Click += new System.EventHandler(this.BlackWhiteBlurToolStripMenuItem1_Click);
            // 
            // findContursToolStripMenuItem
            // 
            this.findContursToolStripMenuItem.Name = "findContursToolStripMenuItem";
            this.findContursToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.findContursToolStripMenuItem.Text = "Draw Contours";
            this.findContursToolStripMenuItem.Click += new System.EventHandler(this.FindContursToolStripMenuItem_Click);
            // 
            // findPrimitivesToolStripMenuItem
            // 
            this.findPrimitivesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drowTrianglesToolStripMenuItem,
            this.drawRToolStripMenuItem,
            this.drowCirclesToolStripMenuItem,
            this.drawAllOfFindedToolStripMenuItem});
            this.findPrimitivesToolStripMenuItem.Name = "findPrimitivesToolStripMenuItem";
            this.findPrimitivesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.findPrimitivesToolStripMenuItem.Text = "Find Primitives";
            // 
            // drowTrianglesToolStripMenuItem
            // 
            this.drowTrianglesToolStripMenuItem.Name = "drowTrianglesToolStripMenuItem";
            this.drowTrianglesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.drowTrianglesToolStripMenuItem.Text = "Draw Triangles";
            this.drowTrianglesToolStripMenuItem.Click += new System.EventHandler(this.DrowTrianglesToolStripMenuItem_Click);
            // 
            // drawRToolStripMenuItem
            // 
            this.drawRToolStripMenuItem.Name = "drawRToolStripMenuItem";
            this.drawRToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.drawRToolStripMenuItem.Text = "Draw Rectangles";
            this.drawRToolStripMenuItem.Click += new System.EventHandler(this.DrawRToolStripMenuItem_Click);
            // 
            // drowCirclesToolStripMenuItem
            // 
            this.drowCirclesToolStripMenuItem.Name = "drowCirclesToolStripMenuItem";
            this.drowCirclesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.drowCirclesToolStripMenuItem.Text = "Drow Circles";
            this.drowCirclesToolStripMenuItem.Click += new System.EventHandler(this.DrowCirclesToolStripMenuItem_Click);
            // 
            // drawAllOfFindedToolStripMenuItem
            // 
            this.drawAllOfFindedToolStripMenuItem.Name = "drawAllOfFindedToolStripMenuItem";
            this.drawAllOfFindedToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.drawAllOfFindedToolStripMenuItem.Text = "Draw All of Finded";
            this.drawAllOfFindedToolStripMenuItem.Click += new System.EventHandler(this.DrawAllOfFindedToolStripMenuItem_Click);
            // 
            // findColorToolStripMenuItem
            // 
            this.findColorToolStripMenuItem.Name = "findColorToolStripMenuItem";
            this.findColorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.findColorToolStripMenuItem.Text = "Find Color";
            this.findColorToolStripMenuItem.Click += new System.EventHandler(this.FindColorToolStripMenuItem_Click);
            // 
            // SaveImageMenuButton
            // 
            this.SaveImageMenuButton.Name = "SaveImageMenuButton";
            this.SaveImageMenuButton.Size = new System.Drawing.Size(79, 20);
            this.SaveImageMenuButton.Text = "Save Image";
            this.SaveImageMenuButton.Visible = false;
            // 
            // ThresholdBar
            // 
            this.ThresholdBar.LargeChange = 1;
            this.ThresholdBar.Location = new System.Drawing.Point(2, 57);
            this.ThresholdBar.Maximum = 255;
            this.ThresholdBar.Minimum = 1;
            this.ThresholdBar.Name = "ThresholdBar";
            this.ThresholdBar.Size = new System.Drawing.Size(82, 45);
            this.ThresholdBar.TabIndex = 7;
            this.ThresholdBar.Value = 1;
            this.ThresholdBar.Visible = false;
            this.ThresholdBar.Scroll += new System.EventHandler(this.ThresholdBar_Scroll);
            // 
            // Threshhold_tb
            // 
            this.Threshhold_tb.AutoSize = true;
            this.Threshhold_tb.Location = new System.Drawing.Point(12, 41);
            this.Threshhold_tb.Name = "Threshhold_tb";
            this.Threshhold_tb.Size = new System.Drawing.Size(0, 13);
            this.Threshhold_tb.TabIndex = 8;
            this.Threshhold_tb.Visible = false;
            // 
            // Area_tb
            // 
            this.Area_tb.AutoSize = true;
            this.Area_tb.Location = new System.Drawing.Point(87, 41);
            this.Area_tb.Name = "Area_tb";
            this.Area_tb.Size = new System.Drawing.Size(0, 13);
            this.Area_tb.TabIndex = 10;
            this.Area_tb.Visible = false;
            // 
            // AreaBar
            // 
            this.AreaBar.LargeChange = 1;
            this.AreaBar.Location = new System.Drawing.Point(78, 57);
            this.AreaBar.Maximum = 1000;
            this.AreaBar.Minimum = 1;
            this.AreaBar.Name = "AreaBar";
            this.AreaBar.Size = new System.Drawing.Size(109, 45);
            this.AreaBar.TabIndex = 9;
            this.AreaBar.Value = 1;
            this.AreaBar.Visible = false;
            this.AreaBar.Scroll += new System.EventHandler(this.AreaBar_Scroll);
            // 
            // Dist_tb
            // 
            this.Dist_tb.AutoSize = true;
            this.Dist_tb.Location = new System.Drawing.Point(192, 41);
            this.Dist_tb.Name = "Dist_tb";
            this.Dist_tb.Size = new System.Drawing.Size(0, 13);
            this.Dist_tb.TabIndex = 12;
            this.Dist_tb.Visible = false;
            // 
            // DistBar
            // 
            this.DistBar.LargeChange = 1;
            this.DistBar.Location = new System.Drawing.Point(183, 57);
            this.DistBar.Maximum = 1000;
            this.DistBar.Minimum = 1;
            this.DistBar.Name = "DistBar";
            this.DistBar.Size = new System.Drawing.Size(125, 45);
            this.DistBar.TabIndex = 11;
            this.DistBar.Value = 1;
            this.DistBar.Visible = false;
            this.DistBar.Scroll += new System.EventHandler(this.DistBar_Scroll);
            // 
            // ThreshCircl_tb
            // 
            this.ThreshCircl_tb.AutoSize = true;
            this.ThreshCircl_tb.Location = new System.Drawing.Point(310, 41);
            this.ThreshCircl_tb.Name = "ThreshCircl_tb";
            this.ThreshCircl_tb.Size = new System.Drawing.Size(0, 13);
            this.ThreshCircl_tb.TabIndex = 14;
            this.ThreshCircl_tb.Visible = false;
            // 
            // ThreshCirclBar
            // 
            this.ThreshCirclBar.LargeChange = 1;
            this.ThreshCirclBar.Location = new System.Drawing.Point(313, 57);
            this.ThreshCirclBar.Maximum = 255;
            this.ThreshCirclBar.Minimum = 1;
            this.ThreshCirclBar.Name = "ThreshCirclBar";
            this.ThreshCirclBar.Size = new System.Drawing.Size(89, 45);
            this.ThreshCirclBar.TabIndex = 13;
            this.ThreshCirclBar.Value = 1;
            this.ThreshCirclBar.Visible = false;
            this.ThreshCirclBar.Scroll += new System.EventHandler(this.ThreshCirclBar_Scroll);
            // 
            // MinRad_tb
            // 
            this.MinRad_tb.AutoSize = true;
            this.MinRad_tb.Location = new System.Drawing.Point(401, 41);
            this.MinRad_tb.Name = "MinRad_tb";
            this.MinRad_tb.Size = new System.Drawing.Size(0, 13);
            this.MinRad_tb.TabIndex = 16;
            this.MinRad_tb.Visible = false;
            // 
            // MinRadBar
            // 
            this.MinRadBar.LargeChange = 1;
            this.MinRadBar.Location = new System.Drawing.Point(404, 57);
            this.MinRadBar.Maximum = 1000;
            this.MinRadBar.Minimum = 1;
            this.MinRadBar.Name = "MinRadBar";
            this.MinRadBar.Size = new System.Drawing.Size(92, 45);
            this.MinRadBar.TabIndex = 15;
            this.MinRadBar.Value = 1;
            this.MinRadBar.Visible = false;
            this.MinRadBar.Scroll += new System.EventHandler(this.MinRadBar_Scroll);
            // 
            // MaxRad_tb
            // 
            this.MaxRad_tb.AutoSize = true;
            this.MaxRad_tb.Location = new System.Drawing.Point(502, 41);
            this.MaxRad_tb.Name = "MaxRad_tb";
            this.MaxRad_tb.Size = new System.Drawing.Size(0, 13);
            this.MaxRad_tb.TabIndex = 18;
            this.MaxRad_tb.Visible = false;
            // 
            // MaxRadBar
            // 
            this.MaxRadBar.LargeChange = 1;
            this.MaxRadBar.Location = new System.Drawing.Point(505, 57);
            this.MaxRadBar.Maximum = 1000;
            this.MaxRadBar.Minimum = 1;
            this.MaxRadBar.Name = "MaxRadBar";
            this.MaxRadBar.Size = new System.Drawing.Size(95, 45);
            this.MaxRadBar.TabIndex = 17;
            this.MaxRadBar.Value = 1;
            this.MaxRadBar.Visible = false;
            this.MaxRadBar.Scroll += new System.EventHandler(this.MaxRadBar_Scroll);
            // 
            // MinAreaOfRect_tb
            // 
            this.MinAreaOfRect_tb.AutoSize = true;
            this.MinAreaOfRect_tb.Location = new System.Drawing.Point(604, 41);
            this.MinAreaOfRect_tb.Name = "MinAreaOfRect_tb";
            this.MinAreaOfRect_tb.Size = new System.Drawing.Size(0, 13);
            this.MinAreaOfRect_tb.TabIndex = 20;
            this.MinAreaOfRect_tb.Visible = false;
            // 
            // MinAreaOfRectBar
            // 
            this.MinAreaOfRectBar.LargeChange = 1;
            this.MinAreaOfRectBar.Location = new System.Drawing.Point(607, 57);
            this.MinAreaOfRectBar.Maximum = 1000;
            this.MinAreaOfRectBar.Minimum = 1;
            this.MinAreaOfRectBar.Name = "MinAreaOfRectBar";
            this.MinAreaOfRectBar.Size = new System.Drawing.Size(84, 45);
            this.MinAreaOfRectBar.TabIndex = 19;
            this.MinAreaOfRectBar.Value = 1;
            this.MinAreaOfRectBar.Visible = false;
            this.MinAreaOfRectBar.Scroll += new System.EventHandler(this.MinAreaOfRectBar_Scroll);
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(87, 27);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(102, 13);
            this.l1.TabIndex = 21;
            this.l1.Text = "MinArea of Triangle:";
            this.l1.Visible = false;
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(192, 27);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(116, 13);
            this.l2.TabIndex = 22;
            this.l2.Text = "MinDist btwn the circls:";
            this.l2.Visible = false;
            // 
            // l0
            // 
            this.l0.AutoSize = true;
            this.l0.Location = new System.Drawing.Point(12, 27);
            this.l0.Name = "l0";
            this.l0.Size = new System.Drawing.Size(60, 13);
            this.l0.TabIndex = 23;
            this.l0.Text = "Threshold: ";
            this.l0.Visible = false;
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Location = new System.Drawing.Point(312, 27);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(80, 13);
            this.l3.TabIndex = 24;
            this.l3.Text = "Thresgold Circl:";
            this.l3.Visible = false;
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.Location = new System.Drawing.Point(401, 27);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(95, 13);
            this.l4.TabIndex = 25;
            this.l4.Text = "MinRadius of Circl:";
            this.l4.Visible = false;
            // 
            // l5
            // 
            this.l5.AutoSize = true;
            this.l5.Location = new System.Drawing.Point(502, 27);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(98, 13);
            this.l5.TabIndex = 26;
            this.l5.Text = "MaxRadius of Circl:";
            this.l5.Visible = false;
            // 
            // l6
            // 
            this.l6.AutoSize = true;
            this.l6.Location = new System.Drawing.Point(604, 27);
            this.l6.Name = "l6";
            this.l6.Size = new System.Drawing.Size(87, 13);
            this.l6.TabIndex = 27;
            this.l6.Text = "MinArea of Rect:";
            this.l6.Visible = false;
            // 
            // color_tb
            // 
            this.color_tb.AutoSize = true;
            this.color_tb.Location = new System.Drawing.Point(900, 27);
            this.color_tb.Name = "color_tb";
            this.color_tb.Size = new System.Drawing.Size(31, 13);
            this.color_tb.TabIndex = 30;
            this.color_tb.Tag = "";
            this.color_tb.Text = "Color";
            this.color_tb.Visible = false;
            // 
            // ColorFind_tb
            // 
            this.ColorFind_tb.AutoSize = true;
            this.ColorFind_tb.Location = new System.Drawing.Point(909, 41);
            this.ColorFind_tb.Name = "ColorFind_tb";
            this.ColorFind_tb.Size = new System.Drawing.Size(0, 13);
            this.ColorFind_tb.TabIndex = 29;
            this.ColorFind_tb.Tag = "";
            this.ColorFind_tb.Visible = false;
            // 
            // ColorBar
            // 
            this.ColorBar.LargeChange = 1;
            this.ColorBar.Location = new System.Drawing.Point(864, 57);
            this.ColorBar.Maximum = 255;
            this.ColorBar.Minimum = 1;
            this.ColorBar.Name = "ColorBar";
            this.ColorBar.Size = new System.Drawing.Size(123, 45);
            this.ColorBar.TabIndex = 28;
            this.ColorBar.Tag = "";
            this.ColorBar.Value = 1;
            this.ColorBar.Visible = false;
            this.ColorBar.Scroll += new System.EventHandler(this.ColorBar_Scroll);
            // 
            // HueColor
            // 
            this.HueColor.Location = new System.Drawing.Point(794, 27);
            this.HueColor.Name = "HueColor";
            this.HueColor.Size = new System.Drawing.Size(76, 62);
            this.HueColor.TabIndex = 2;
            this.HueColor.TabStop = false;
            this.HueColor.Tag = "";
            this.HueColor.Visible = false;
            this.HueColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HueColor_MouseClick);
            // 
            // triangle_lbl
            // 
            this.triangle_lbl.AutoSize = true;
            this.triangle_lbl.Location = new System.Drawing.Point(697, 64);
            this.triangle_lbl.Name = "triangle_lbl";
            this.triangle_lbl.Size = new System.Drawing.Size(62, 13);
            this.triangle_lbl.TabIndex = 31;
            this.triangle_lbl.Text = "Triangles: 0";
            this.triangle_lbl.Visible = false;
            // 
            // Rect_lbl
            // 
            this.Rect_lbl.AutoSize = true;
            this.Rect_lbl.Location = new System.Drawing.Point(697, 80);
            this.Rect_lbl.Name = "Rect_lbl";
            this.Rect_lbl.Size = new System.Drawing.Size(73, 13);
            this.Rect_lbl.TabIndex = 32;
            this.Rect_lbl.Text = "Rectangles: 0";
            this.Rect_lbl.Visible = false;
            // 
            // Circl_lbl
            // 
            this.Circl_lbl.AutoSize = true;
            this.Circl_lbl.Location = new System.Drawing.Point(697, 99);
            this.Circl_lbl.Name = "Circl_lbl";
            this.Circl_lbl.Size = new System.Drawing.Size(50, 13);
            this.Circl_lbl.TabIndex = 33;
            this.Circl_lbl.Text = "Circles: 0";
            this.Circl_lbl.Visible = false;
            // 
            // Prim_lbl
            // 
            this.Prim_lbl.AutoSize = true;
            this.Prim_lbl.Location = new System.Drawing.Point(724, 49);
            this.Prim_lbl.Name = "Prim_lbl";
            this.Prim_lbl.Size = new System.Drawing.Size(45, 13);
            this.Prim_lbl.TabIndex = 34;
            this.Prim_lbl.Text = "Primitivs";
            this.Prim_lbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 507);
            this.Controls.Add(this.Prim_lbl);
            this.Controls.Add(this.Circl_lbl);
            this.Controls.Add(this.Rect_lbl);
            this.Controls.Add(this.triangle_lbl);
            this.Controls.Add(this.HueColor);
            this.Controls.Add(this.color_tb);
            this.Controls.Add(this.ColorFind_tb);
            this.Controls.Add(this.ColorBar);
            this.Controls.Add(this.l6);
            this.Controls.Add(this.l5);
            this.Controls.Add(this.l4);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.l0);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.MinAreaOfRect_tb);
            this.Controls.Add(this.MinAreaOfRectBar);
            this.Controls.Add(this.MaxRad_tb);
            this.Controls.Add(this.MaxRadBar);
            this.Controls.Add(this.MinRad_tb);
            this.Controls.Add(this.MinRadBar);
            this.Controls.Add(this.ThreshCircl_tb);
            this.Controls.Add(this.ThreshCirclBar);
            this.Controls.Add(this.Dist_tb);
            this.Controls.Add(this.DistBar);
            this.Controls.Add(this.Area_tb);
            this.Controls.Add(this.AreaBar);
            this.Controls.Add(this.Threshhold_tb);
            this.Controls.Add(this.ThresholdBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SecondImageBox);
            this.Controls.Add(this.FirstImageBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.FirstImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondImageBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThresholdBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AreaBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DistBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThreshCirclBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinRadBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxRadBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinAreaOfRectBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HueColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox FirstImageBox;
        private Emgu.CV.UI.ImageBox SecondImageBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveImageMenuButton;
        private System.Windows.Forms.ToolStripMenuItem FiltrMenu;
        private System.Windows.Forms.ToolStripMenuItem blackWhiteBlurToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem findContursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findPrimitivesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drowTrianglesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drowCirclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawAllOfFindedToolStripMenuItem;
        private System.Windows.Forms.TrackBar ThresholdBar;
        private System.Windows.Forms.Label Threshhold_tb;
        private System.Windows.Forms.Label Area_tb;
        private System.Windows.Forms.TrackBar AreaBar;
        private System.Windows.Forms.Label Dist_tb;
        private System.Windows.Forms.TrackBar DistBar;
        private System.Windows.Forms.Label ThreshCircl_tb;
        private System.Windows.Forms.TrackBar ThreshCirclBar;
        private System.Windows.Forms.Label MinRad_tb;
        private System.Windows.Forms.TrackBar MinRadBar;
        private System.Windows.Forms.Label MaxRad_tb;
        private System.Windows.Forms.TrackBar MaxRadBar;
        private System.Windows.Forms.Label MinAreaOfRect_tb;
        private System.Windows.Forms.TrackBar MinAreaOfRectBar;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l0;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.Label l5;
        private System.Windows.Forms.Label l6;
        private System.Windows.Forms.Label color_tb;
        private System.Windows.Forms.Label ColorFind_tb;
        private System.Windows.Forms.TrackBar ColorBar;
        private Emgu.CV.UI.ImageBox HueColor;
        private System.Windows.Forms.Label triangle_lbl;
        private System.Windows.Forms.Label Rect_lbl;
        private System.Windows.Forms.Label Circl_lbl;
        private System.Windows.Forms.Label Prim_lbl;
    }
}

