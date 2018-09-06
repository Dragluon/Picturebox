using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox2._0
{
    public partial class Form2 : Form
    {
        

        string fileName;

        public Form2()
        {
            InitializeComponent();
        }

        #region 亮度处理
        private void btnAdjust_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(fileName);
            int width = bmp.Width;
            int height = bmp.Height;
            int val = int.Parse(txtVal.Text);
            Bitmap newBmp = ImageClass.LDPic(bmp, width, height, val);
            picChange.BackgroundImage = newBmp;
        }
        #endregion

        #region 打开文件
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image file(*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileName = ofd.FileName;
                picOrigin.BackgroundImage = Image.FromFile(fileName);
            }
        }
        #endregion

        #region 黑白
        private void btnBlack_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(fileName);
            int width = bmp.Width;
            int height = bmp.Height;
            Bitmap newBmp = ImageClass.BWPic(bmp, width, height);
            picChange.BackgroundImage = newBmp;
        }
        #endregion

        #region 浮雕
        private void btnCameo_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(fileName);
            int width = bmp.Width;
            int height = bmp.Height;
            Bitmap newBmp = ImageClass.FD(bmp, width, height);
            picChange.BackgroundImage = newBmp;
        }
        #endregion

        #region 反色处理
        private void btnBackcolor_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(fileName);
            int width = bmp.Width;
            int height = bmp.Height;
            Bitmap newBmp = ImageClass.RePic(bmp, width, height);
            picChange.BackgroundImage = newBmp;
        }
        #endregion

        #region 滤色处理
        private void btnColation_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(fileName);
            int width = bmp.Width;
            int height = bmp.Height;
            Bitmap newBmp = ImageClass.FilPic(bmp, width, height);
            picChange.BackgroundImage = newBmp;
        }
        #endregion
       
        #region 左右翻转
        private void btnLeft_right_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(fileName);
            int width = bmp.Width;
            int height = bmp.Height;
            Bitmap newBmp = ImageClass.RevPicLR(bmp, width, height);
            picChange.BackgroundImage = newBmp;
        }
        #endregion

        #region 上下翻转
        private void btnUp_down_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(fileName);
            int width = bmp.Width;
            int height = bmp.Height;
            Bitmap newBmp = ImageClass.RevPicUD(bmp, width, height);
            picChange.BackgroundImage = newBmp;
        }
        #endregion

        #region 保存
        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "jpg|*.jpg|png|*.png|bmp|*.bmp";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                picChange.BackgroundImage.Save(sfd.FileName);
            }
        }
        #endregion

        #region 图片灰度化
        private void btnGray_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(fileName);
            for(int x=0;x<bmp.Width;x++)
                for(int y=0;y<bmp.Height;y++)
                {
                    Color c = bmp.GetPixel(x, y);

                    Color c2 = ImageClass.Gray(c);

                    bmp.SetPixel(x, y, c2);
                }
            
            picChange.BackgroundImage = bmp;
        }
        #endregion
    }
}
