using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Cscarp_Miki_Maus
{
    class Mouth
    {
        private int x;
        private int y;
        private int x2;
        private int y2;
        private int height;
        private int width;
        private int width2;
        private int height2;


        private SolidBrush b;
        private SolidBrush b2;



        public Mouth(int x, int y, int hight, int width, Color col, Color col2)
        {
            this.x = x;
            this.y = y;
            this.x2 = x ;
            this.y2 = y + hight / 4;

            this.height = hight;
            this.width = width;
            this.width2 = width ;
            this.height2 = hight / 3;


            b = new SolidBrush(col);
            b2 = new SolidBrush(col2);

        }


        public void DrawMouth(Graphics gr)
        {
            gr.FillEllipse(this.b, new Rectangle(this.x, this.y, this.width, this.height));
            gr.FillEllipse(this.b2, new Rectangle(this.x2, this.y2, this.width2, this.height2));


        }
        public void MoveR(int dx)
        {
            this.x += dx;
            this.x2 += dx;

        }
        public void MoveL(int dx)
        {
            this.x -= dx;
            this.x2 -= dx;

        }
    }
}
