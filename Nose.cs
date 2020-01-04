using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;

namespace Cscarp_Miki_Maus
{
    class Nose
    {

        private int xNose;
        private int yNose;
        private int wNose;
        private int hNose;
        Point[] p = new Point[3];
       

        public Nose(int x, int y, int w, int h)
        {
            this.wNose = w / 2;
            this.hNose = this.wNose;
            this.xNose = x + (w / 2 - this.wNose / 2);
            this.yNose = y;


        }
        public void MoveR(int dx)
        {

            this.xNose += dx;
            
        }
        public void MoveL(int dx)
        {

            this.xNose -= dx;

        }


        public void DrawNose(Graphics gr)
        {
            this.p[0] = new Point(xNose, yNose);
            this.p[1] = new Point(xNose - wNose, yNose + hNose);
            this.p[2] = new Point(xNose + wNose, yNose + hNose);
            

            gr.FillPolygon(Brushes.CadetBlue, p);
            
        }
    }
}
