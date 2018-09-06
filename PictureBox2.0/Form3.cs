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
    public partial class Form3 : Form
    {
        Form1 draw = new Form1();
        Form2 change = new Form2();

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (draw == null || draw.IsDisposed)
            {
                draw = new Form1();
                draw.Show();
            }
            else
            {
                draw.WindowState = FormWindowState.Normal;
                draw.Show();
            }
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
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
            this.Hide();
        }
    }
}
