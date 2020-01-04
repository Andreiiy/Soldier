using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

using System.Threading.Tasks;

namespace Cscarp_Miki_Maus
{
    class Leg:OrganBody
    {
        
        private SolidBrush b;
        private SolidBrush b2;

        Pen pen;
        private Boot boot;
        


        public Leg(int x, int y, int hight, int width, Color colleg, Color colboot)
        {
            this.x = x+ width/2;
            this.y = y;
            this.height = hight;
            this.width = width;

            this.x2 = x + width / 2;
            this.y2 = y + hight;
            this.height2 = hight / 5;
            this.width2 = width*2- width / 8;


            b = new SolidBrush(colleg);
            b2 = new SolidBrush(Color.Bisque);

            this.boot = new Boot(this.x, this.y + this.height- this.height / 4, this.height / 4, this.width, colboot);
            pen = new Pen(b, this.width);


        }


        public void DrawLeg(Graphics gr)
        {
            
            gr.DrawLine(pen, this.x, this.y, this.x2, this.y2);
            boot.DrawBoot(gr);
            
        }
        /// <summary>
        /// function moves the object to the right
        /// </summary>
        /// <param name="dx"></param>
        public override void MoveR(int dx)
        {
            this.x += dx;
            this.x2 += dx;
            boot.MoveR(dx);
        }
        /// <summary>
        /// function moves the object to the leftt
        /// </summary>
        /// <param name="dx"></param>
        public override void MoveL(int dx)
        {
           
            this.x -= dx;
            this.x2 -= dx;
            boot.MoveL(dx);
        }
    }
}
