using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Cscarp_Miki_Maus
{
    class Eye:OrganBody
    {
               
        private SolidBrush b;
        private SolidBrush b2;


        public Eye(int x,int y,int hight,int width, Color col, Color col2)
        {
            this.x = x;
            this.y = y;
            this.x2 = (x+ width / 2)-(width / 8);
            this.y2 = y+ hight/3;

            this.height = hight;
            this.width = width;
            this.width2 = width/3;
            this.height2 = hight/3;


            b = new SolidBrush(col);
            b2 = new SolidBrush(col2);
            
        }


        public void DrawEye(Graphics gr)
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
