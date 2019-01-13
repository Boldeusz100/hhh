using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorytmy_graficzne
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;

        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void BTN_RysujOdcinek_Click(object sender, EventArgs e)
        {
            MyDrawing.drawLine(10, 20, 150, 95, bitmap, Color.Red, pictureBox1);
            MyDrawing.drawLine(5, 0, 120, 0, bitmap, Color.Blue, pictureBox1);
            MyDrawing.drawLine(0, 180, 0, 10, bitmap, Color.Green, pictureBox1);
        }

        

    }
}
