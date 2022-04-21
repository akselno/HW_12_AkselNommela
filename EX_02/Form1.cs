using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Point x;
        private Point y;
        private int movement = 1;
        private void button_start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            StartDrawing();
        }

        private void StartDrawing()
        {
            Graphics graphics = CreateGraphics();
            Random random = new Random();
            Pen pen = new Pen(Color.FromArgb((byte)random.Next(0, 255), (byte)random.Next(0, 255),
                (byte)random.Next(0, 255)), 4);
            
            if (movement % 2 == 1)
            {
                y = new Point(x.X, y.Y + 10);
                graphics.DrawLine(pen, x, y);
                x = y;
            }
            else
            {
                y = new Point(x.X, y.Y - 10);
                graphics.DrawLine(pen, x, y);
                x = y;
            }
            if (x.Y == 0 || x.Y > this.ClientSize.Height)
            {
                y = new Point(x.X + 4, x.Y);
                graphics.DrawLine(pen, x, y);
                x = y;
                movement++;
            }
        }
    }
}
