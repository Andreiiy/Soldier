using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Cscarp_Miki_Maus
{
    class Gun2 : OrganBody
    {
     
        private SolidBrush b;


        public Gun2(int x, int y, int hight, int width, Color col)
        {
            this.x = x;
            this.y = y- hight / 3-10;
            this.height = hight/2;
            this.width = width;

            this.x2 = x;
            this.y2 = y-10;
            this.height2 = hight;
            this.width2 = width/3;

            b = new SolidBrush(col);



        }
        public void DrawGun2(Graphics gr)
        {

            gr.FillRectangle(this.b, new Rectangle(this.x, this.y, this.width, this.height));
            gr.FillRectangle(this.b, new Rectangle(this.x2, this.y2, this.width2, this.height2));
        }
        public void MoveGun(int gx,int gy)
        {
            this.x = gx;
            this.y = gy-10  ;

            this.x2 = gx;
            this.y2 = gy-10;
        }
               
    }
}
