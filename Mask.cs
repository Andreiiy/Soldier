using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Cscarp_Miki_Maus
{
    class Mask:OrganBody
    {
             

        private SolidBrush b;
        private Eye leye;
        private Eye reye;
        public Mask(int x, int y, int hight, int width, Color col)
        {
            this.x = x;
            this.y = y;
            this.height = hight;
            this.width = width;

            this.x2 = x;
            this.y2 = y + hight / 2;
            this.height2 = hight / 2;
            this.width2 = width;

            b = new SolidBrush(col);
            this.leye = new Eye(x + width / 6, y + height / 7, hight / 3, width / 3, Color.White, Color.Black);
            this.reye = new Eye(x + width / 2, y + height / 7, hight / 3, width / 3, Color.White, Color.Black);

        }
        public void DrawMask(Graphics gr)
        {
            gr.FillEllipse(this.b, new Rectangle(this.x, this.y, this.width, this.height));
            gr.FillRectangle(this.b, new Rectangle(this.x2, this.y2, this.width2, this.height2));
            leye.DrawEye(gr);
            reye.DrawEye(gr);

        }
        public override void MoveR(int dx)
        {
            this.x += dx;
            this.x2 += dx;
            this.leye.MoveR(dx);
            this.reye.MoveR(dx);
        }
        public override void MoveL(int dx)
        {
            this.x -= dx;
            this.x2 -= dx;
            this.leye.MoveL(dx);
            this.reye.MoveL(dx);
        }
        public void MaskUp(int dx)
        {
            this.y -= dx;
            this.y2 -= dx;
            
        }


    }
}
