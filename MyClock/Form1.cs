using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyClock
{
    public partial class Form1 : Form
    {
        bool isFullScreen = false;
        bool isSecond = true;
        bool isDate = false;
        int X;
        int Y;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            X = this.Width;
            Y = this.Height;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isSecond)
            {
                label1.Text = System.DateTime.Now.ToString("HH:mm:ss");
            }
            else
            {
                label1.Text = System.DateTime.Now.ToString("HH:mm");
            }

            if (isDate)
            {
                label2.Visible = true;
                label2.Text = System.DateTime.Now.ToString("MM-dd");
            }
            else
            {
                label2.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.ResizeRedraw = false;
            Point p = new Point();
            p.X = 100; p.Y = 100;
            Point p0 = new Point();
            p0.X = 0; p0.Y = 0;

            if (!isFullScreen) 
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.Location = p0;
                this.Height = Screen.PrimaryScreen.Bounds.Height;
                this.Width = Screen.PrimaryScreen.Bounds.Width;
                label1.Font = new Font("Impact", 180);
                isFullScreen = true;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.Location = p;
                this.Height = Y;
                this.Width = X;
                label1.Font = new Font("Impact", 160);
                isFullScreen = false;
            }
            
            this.ResizeRedraw = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isSecond)
            {
                isSecond = false;
            }
            else
            {
                isSecond = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isDate)
            {
                isDate = false;
            }
            else
            {
                isDate = true;
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = Color.White;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Black;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.ForeColor = Color.White;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Black;
        }
    }
}
