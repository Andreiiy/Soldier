using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Cscarp_Miki_Maus
{
    class Boot : OrganBody
    {
               
        private SolidBrush b;
        private SolidBrush b2;




        public Boot(int x, int y, int hight, int width, Color col)
        {
            this.x = x- width/2;
            this.y = y;
            this.height = hight;
            this.width = width;

            this.x2 = x - width / 2;
            this.y2 = y + hight;
            this.height2 = hight / 2*2;
            this.width2 = width * 2 - width / 8;


            b = new SolidBrush(col);
            b2 = new SolidBrush(col);
        }


        public void DrawBoot(Graphics gr)
        {
            gr.FillRectangle(this.b, new Rectangle(this.x, this.y, this.width, this.height));
            gr.FillRectangle(this.b2, new Rectangle(this.x2, this.y2, this.width2, this.height2));

        }
        public override void MoveR(int dx)
        {
            this.x2 = x ;
            this.x += dx;
            this.x2 += dx;

        }
        public override void MoveL(int dx)
        {
            this.x2 = x - width+ width/7;
            this.x -= dx;
            this.x2 -= dx;

        }
        
    }
}
