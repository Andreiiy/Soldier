using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Cscarp_Miki_Maus
{
    class Hat : OrganBody
    {
       
        private SolidBrush b;
     

        public Hat(int x, int y, int hight, int width, Color col)
        {
            this.x = x;
            this.y = y;
            this.x2 = x+ width/2;
            this.y2 = y + (hight- hight / 4);

            this.height = hight;
            this.width = width;
            this.width2 = width;
            this.height2 = hight / 4;
            
            b = new SolidBrush(col);
        }


        public void DrawHat(Graphics gr)
        {
            gr.FillRectangle(this.b, new Rectangle(this.x, this.y, this.width, this.height));
             gr.FillEllipse(this.b, new Rectangle(this.x2, this.y2, this.width2, this.height2));
        }
        
    }
}

