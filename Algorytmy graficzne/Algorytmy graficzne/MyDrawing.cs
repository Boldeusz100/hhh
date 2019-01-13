using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Algorytmy_graficzne
{
    class MyDrawing
    {
        public static void drawLine(int x0, int y0, int x1, int y1, Bitmap bitmap, Color kolor, PictureBox picturebox)
        {
            int dl;
            float dx, dy, wspx, wspy;
            float a = (float)(y1 - y0) / (x1 - x0);
            if(Math.Abs(x1-x0)>=Math.Abs(y1-y0))
            {
                dl = Math.Abs(x1 - x0);
                if (x1 >= x0) dx = 1; else dx = -1;
                dy = a * dx;
            }
            else
            {
                dl = Math.Abs(y1 - y0);
                if (y1 >= y0) dy = 1; else dy = -1;
                dx = dy / a;

            }
            wspx = x0; wspy = y0;
            for (int i=1;i<dl;i++)
            {
                bitmap.SetPixel((int)Math.Round(wspx), (int)Math.Round(wspy), kolor);
                wspx += (float)dx; wspy += (float)dy;


            }
            picturebox.Image = bitmap;



        }
      }
}
