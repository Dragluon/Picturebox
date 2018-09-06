using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace PictureBox2._0
{
    public partial class Form1 : Form
    {

        Bitmap originImg;
        Image finishImg;
        Graphics g;
        DrawType dType;
        Point StartPoint, EndPoint, FontPoint;
        Pen p = new Pen(Color.Black, 1);
        bool IsDraw;
        Font font;
        Rectangle FontRect;
        Form2 change = new Form2();

        #region 画笔颜色
        Color DrawColor
        {
            get { return p.Color; }
            set { p.Color = value; }
        }
        #endregion

        #region 画笔宽度
        float PenWidth
        {
            set { p.Width = value; }
        }
        #endregion

        public Form1()
        {
            InitializeComponent();

            cmbThickness.SelectedIndex = 0;
            
            txtWrite.Parent = picDraw;

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint, true);
            this.UpdateStyles();

            
            p.StartCap = LineCap.Round;
            p.EndCap = LineCap.Round;

            originImg = new Bitmap(picDraw.Width, picDraw.Height);
            g = Graphics.FromImage(originImg);
            
            g.Clear(Color.White);

            picDraw.Image = originImg;
            finishImg = (Image)originImg.Clone();
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtWrite.Visible = false;
            txtWrite.Text = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image file(*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(ofd.FileName);
                //int height = Image.FromFile(ofd.FileName).Height;
                //int width = Image.FromFile(ofd.FileName).Width;
                int width = bmp.Width;
                int height = bmp.Height;

                picDraw.Size = new Size(width, height);

                originImg = new Bitmap(picDraw.Width, picDraw.Height);
                g = Graphics.FromImage(originImg);


                picDraw.Image = originImg;
                finishImg = (Image)originImg.Clone();
                DrawImage(Image.FromFile(ofd.FileName));
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                IsDraw = true;
                StartPoint = e.Location;
                switch (dType)
                {
                    case DrawType.Pen:
                    case DrawType.Eraser:
                        finishImg = (Image)originImg.Clone();
                        break;
                    case DrawType.Write:     
                        if (!txtWrite.Bounds.Contains(StartPoint))
                        {
                            txtWrite.Visible = false;
                            DrawString(txtWrite.Text);
                            txtWrite.Text = "";
                            return;
                        }
                        break;
                }
            }
        }

        private void btnArrow_Click(object sender, EventArgs e)
        {
            dType = DrawType.None;
            txtWrite.Visible = false;
            txtWrite.Text = "";
        }

        private void btnPen_Click(object sender, EventArgs e)
        {
            dType = DrawType.Pen;
            txtWrite.Visible = false;
            txtWrite.Text = "";
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtWrite.Visible = false;
            txtWrite.Text = "";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "jpg|*.jpg|png|*.png|bmp|*.bmp";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                finishImg.Save(sfd.FileName);
            }
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            dType = DrawType.Line;
            txtWrite.Visible = false;
            txtWrite.Text = "";
        }

        private void btnRec_Click(object sender, EventArgs e)
        {
            dType = DrawType.Rect;
            txtWrite.Visible = false;
            txtWrite.Text = "";
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            dType = DrawType.Ellipse;
            txtWrite.Visible = false;
            txtWrite.Text = "";
        }

        private void btnEraser_Click(object sender, EventArgs e)
        {
            dType = DrawType.Eraser;
            txtWrite.Visible = false;
            txtWrite.Text = "";
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            dType = DrawType.Write;
            FontDialog fd = new FontDialog(); 
            if (fd.ShowDialog() == DialogResult.OK)
            {
                font = fd.Font;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtWrite.Visible = false;
            txtWrite.Text = "";
            g.Clear(Color.White);
            reDraw();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.FullOpen = true;
            cd.Color = DrawColor;
            if (cd.ShowDialog() == DialogResult.OK)
            {
                DrawColor = cd.Color;
            }
        }

        private void cmbThickness_SelectedIndexChanged(object sender, EventArgs e)
        {
            PenWidth = Convert.ToSingle(cmbThickness.Text);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDraw)
            {
                EndPoint = e.Location;
                if (dType != DrawType.Pen && dType != DrawType.Eraser)
                {
                    finishImg = (Image)originImg.Clone();
                }
                g = Graphics.FromImage(finishImg);
                g.SmoothingMode = SmoothingMode.AntiAlias;   
                switch (dType)
                {
                    case DrawType.Line:
                        g.DrawLine(p, StartPoint, EndPoint);
                        break;
                    case DrawType.Pen:
                        g.DrawLine(p, StartPoint, EndPoint);
                        StartPoint = EndPoint;
                        break;
                    case DrawType.Rect:
                        Point leftTop = new Point(StartPoint.X, StartPoint.Y);
                        int width = Math.Abs(StartPoint.X - e.X), height = Math.Abs(StartPoint.Y - e.Y);
                        if (e.X < StartPoint.X)
                            leftTop.X = e.X;
                        if (e.Y < StartPoint.Y)
                            leftTop.Y = e.Y;
                        Rectangle rect = new Rectangle(leftTop, new Size(width, height));
                        g.DrawRectangle(p, rect);
                        break;
                    case DrawType.Ellipse:
                        leftTop = new Point(StartPoint.X, StartPoint.Y);
                        int Ewidth = Math.Abs(StartPoint.X - e.X), Eheight = Math.Abs(StartPoint.Y - e.Y);
                        if (e.X < StartPoint.X)
                            leftTop.X = e.X;
                        if (e.Y < StartPoint.Y)
                            leftTop.Y = e.Y;
                        rect = new Rectangle(leftTop, new Size(Ewidth, Eheight));
                        g.DrawEllipse(p, rect);
                        break;
                    case DrawType.Eraser:
                        Pen pen1 = new Pen(Color.White, 20);
                        pen1.StartCap = LineCap.Round;
                        pen1.StartCap = LineCap.Round;
                        g.DrawLine(pen1, StartPoint, EndPoint);
                        StartPoint = EndPoint;
                        pen1.Dispose();
                        break;
                    case DrawType.Write:    
                        leftTop = new Point(StartPoint.X, StartPoint.Y);
                        int w = Math.Abs(StartPoint.X - e.X);
                        int h = Math.Abs(StartPoint.Y - e.Y);
                        if (e.X < StartPoint.X)
                            leftTop.X = e.X;
                        if (e.Y < StartPoint.Y)
                            leftTop.Y = e.Y;
                        FontRect = new Rectangle(leftTop, new Size(w, h));
                        Pen pRect = new Pen(Color.Black);
                        pRect.DashPattern = new float[] { 4.0F, 2.0F, 1.0F, 3.0F };
                        g.DrawRectangle(pRect, FontRect);
                        pRect.Dispose();
                        break;
                }
                reDraw();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            IsDraw = false;
            originImg = (Bitmap)finishImg;
            if (dType == DrawType.Write)
            {
                  
                Pen pRect = new Pen(Color.White);
                g.DrawRectangle(pRect, FontRect);
                pRect.Dispose();

                  
                txtWrite.SetBounds(FontRect.Left, FontRect.Top, FontRect.Width, FontRect.Height);
                txtWrite.Font = font;
                FontPoint = FontRect.Location;
                txtWrite.Visible = true;
                txtWrite.Focus();
            }

             
            picDraw.Image = originImg;
        }

        private void DrawString(string str)
        {
            g.DrawString(str, font, new SolidBrush(DrawColor), FontPoint);
            reDraw();
        }

        private void DrawImage(Image img)
        {
            g = Graphics.FromImage(finishImg);
            g.DrawImage(img, new Point(0, 0));
            reDraw();
        }

        private void 线ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dType = DrawType.Line;
            txtWrite.Visible = false;
            txtWrite.Text = "";
        }

        private void 矩形ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dType = DrawType.Rect;
            txtWrite.Visible = false;
            txtWrite.Text = "";
        }

        private void 椭圆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dType = DrawType.Ellipse;
            txtWrite.Visible = false;
            txtWrite.Text = "";
        }

        private void 灰度化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(picDraw.Image);
            
            for (int x = 0; x < bmp.Width; x++)
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color c = bmp.GetPixel(x, y);

                    int gray = (int)(c.R * 0.299 + c.G * 0.587 + c.B * 0.114);

                    Color c2 = Color.FromArgb(gray, gray, gray);

                    bmp.SetPixel(x, y, c2);
                }

            if (change == null || change.IsDisposed)
            {
                change = new Form2();
                change.Show();
            }
            else
            {
                change.WindowState = FormWindowState.Normal;
                change.Show();
            }
            change.picChange.Size = new Size(picDraw.Image.Width, picDraw.Image.Height);
            change.picChange.BackgroundImage = bmp;
            
            
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (change == null || change.IsDisposed)
            {
                change = new Form2();
                change.Show();
            }
            else
            {
                change.WindowState = FormWindowState.Normal;
                change.Show();
            }
        }

        private void reDraw()
        {
            Graphics graphics = picDraw.CreateGraphics();
            graphics.DrawImage(finishImg, new Point(0, 0));
            graphics.Dispose();
        }

        enum DrawType
        {
            None,
            Pen,
            Line,
            Rect,
            Ellipse,
            Eraser,
            Write
        }
    }

}
