using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Cscarp_Miki_Maus
{
    class Korpus
    {
        private int x, x1, x2, x3, x4, x5, x6, x7;
        private int y, y1, y2, y3, y4, y5, y6, y7;

        private int height, height1, height2, height3, height4, height5, height6, height7;
        private int width, width1, width2, width3, width4, width5, width6, width7;

        private SolidBrush b, b1, b2, b3, b4, b5, b6, b7;
        

        public Korpus(int x, int y, int hight, int width)
        {
            this.x = x;
            this.y = y;
            this.height = hight/5;
            this.width = width ;

            this.x1 = x +width / 6;
            this.y1 = y+ hight / 5;
            this.height1 = hight- hight / 2;
            this.width1 = (width / 3)*2;

            this.x2 = x + width / 13 ;
            this.y2 = y + hight / 5;
            this.height2 = hight - hight / 2;
            this.width2 = ((width / 4) * 2)/3;

            this.x3 = (x +  width / 3 )- width / 15;
            this.y3 = y + hight / 5;
            this.height3 = hight - hight / 2;
            this.width3 = ((width / 4) * 2) / 3;

            this.x4 = x + width/2;
            this.y4 = y + hight / 5;
            this.height4 = hight - hight / 2;
            this.width4 = ((width / 4) * 2) / 3;

            this.x5 = x + width - width / 4;
            this.y5 = y + hight / 5;
            this.height5 = hight - hight / 2;
            this.width5 = ((width / 4) * 2) / 3;

            this.x6 = (x + width)- width / 20;
            this.y6= y ;
            this.height6 =  hight / 2;
            this.width6 = width / 20;

            this.x7 = x;
            this.y7 = y- hight / 5;
            this.height7 = hight /5;
            this.width7 = width / 15;


            b = new SolidBrush(Color.DarkGreen);
            b1 = new SolidBrush(Color.Gray);
            b2 = new SolidBrush(Color.Black);
            b3 = new SolidBrush(Color.Black);
            b4 = new SolidBrush(Color.Black);
            b5 = new SolidBrush(Color.Black);
            b6 = new SolidBrush(Color.DarkGreen);
            b7 = new SolidBrush(Color.Brown);

        }
        public void DrawBashnya(Graphics gr)
        {

            
            gr.FillRectangle(this.b, new Rectangle(this.x, this.y, this.width, this.height));
            gr.FillRectangle(this.b1, new Rectangle(this.x1, this.y1, this.width1, this.height1));
            gr.FillEllipse(this.b2, new Rectangle(this.x2, this.y2, this.width2, this.height2));
            gr.FillEllipse(this.b3, new Rectangle(this.x3, this.y3, this.width3, this.height3));
            gr.FillEllipse(this.b4, new Rectangle(this.x4, this.y4, this.width4, this.height4));
            gr.FillEllipse(this.b5, new Rectangle(this.x5, this.y5, this.width5, this.height5));
            gr.FillRectangle(this.b6, new Rectangle(this.x6, this.y6, this.width6, this.height6));
            gr.FillEllipse(this.b7, new Rectangle(this.x7, this.y7, this.width7, this.height7));
                        
        }
        /// <summary>
        /// function moves the object to the right
        /// </summary>
        /// <param name="dx"></param>
        public void MoveR(int dx)
        {
            this.x += dx;
            this.x1 += dx;
            this.x2 += dx;
            this.x3 += dx;
            this.x4 += dx;
            this.x5 += dx;
            this.x6 += dx;
            this.x7+= dx;
            
        }
    }
}

