using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void label_coordinates_Click(object sender, EventArgs e)
        {
            Point p = PointToClient(Cursor.Position);
            string coordinates = string.Format("({0},{1})", p.X, p.Y);
            label_coordinates.Text = coordinates;
        }
    }
}
