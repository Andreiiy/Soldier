using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Cscarp_Miki_Maus
{
    class Bashnya
    {
        private int x,x1,x2,x3,x4,x5,x6;
        private int y,y1,y2,y3,y4,y5,y6;

        private int height, height1, height2, height3, height4, height5, height6;
        private int width, width1, width2, width3, width4, width5, width6;

        private SolidBrush b,b1, b2, b3, b4, b5, b6;
        Pen pen;
        public Bashnya(int x, int y, int hight, int width)
        {
            this.x = x;
            this.y = y;
            this.height = hight;
            this.width = width/2;

            this.x1 = x- width/6;
            this.y1 = y;
            this.height1 = hight;
            this.width1 = width/3;

            this.x2 = x + width/2- width /6;
            this.y2 = y;
            this.height2 = hight;
            this.width2 = width / 3;

            this.x3 = x + width/2 + width / 6- width / 6;
            this.y3 = y + hight / 2;
            
            this.x4 = x + width*2 ;
            this.y4 = y + hight / 2;
            b = new SolidBrush(Color.DarkGreen);
            b1 = new SolidBrush(Color.DarkGreen);
            b2 = new SolidBrush(Color.DarkGreen);
            b3 = new SolidBrush(Color.DarkGreen);

            pen = new Pen(Color.DarkGray, this.width/4);
        }
        public void DrawBashnya(Graphics gr)
        {

            gr.DrawLine(pen, this.x3, this.y3, this.x4, this.y4);
            gr.FillRectangle(this.b, new Rectangle(this.x, this.y, this.width, this.height));
            gr.FillEllipse(this.b1, new Rectangle(this.x1, this.y1, this.width1, this.height1));
            gr.FillEllipse(this.b2, new Rectangle(this.x2, this.y2, this.width2, this.height2));
            
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
                       
        }
    }
    }
