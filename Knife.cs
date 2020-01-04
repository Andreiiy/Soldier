using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Cscarp_Miki_Maus
{
  public  class Knife
    {

        private int x;
        private int y;

        private int height;
        private int width;

        private int x2;
        private int y2;

        private int height2;
        private int width2;

        private SolidBrush b;
        private SolidBrush b2;



        public Knife(int x, int y, int hight, int width, Color col)
        {
            this.x = x- width;
            this.y = y- hight / 4;
            this.height = hight / 4;
            this.width = width;

            this.x2 = x - width/3;
            this.y2 = y - hight/2+ hight /40;
            this.height2 = hight;
            this.width2 = width / 15;

            b = new SolidBrush(col);
            b2 = new SolidBrush(Color.Black);




        }
        public void DrawKnife(Graphics gr)
        {

            gr.FillRectangle(this.b, new Rectangle(this.x, this.y, this.width, this.height));
            gr.FillRectangle(this.b2, new Rectangle(this.x2, this.y2, this.width2, this.height2));
        }
        /// <summary>
        /// function moves the knife in hand
        /// </summary>
        /// <param name="gx"></param>
        /// <param name="gy"></param>
        public void MoveKnife(int gx, int gy)
        {
            this.x = gx- width;
            this.y = gy - height + 10;
            
            this.x2 = gx- width / 3;
            this.y2 = gy- this.height * 2 + this.height / 10 + 10;
            
        }
        /// <summary>
        /// function moves the object to the right
        /// </summary>
        /// <param name="dx"></param>
        public void MoveR(int dx)
        {
            this.x += dx;
            this.x2 += dx;
        }
        /// <summary>
        /// function moves the object to the leftt
        /// </summary>
        /// <param name="dx"></param>
        public void MoveL(int dx)
        {
            this.x -= dx;
            this.x2 -= dx;
        }
        /// <summary>
        /// function raises a hand with a weapon
        /// </summary>
        /// <param name="dx"></param>
        public void KnifeDown(int dx)
        {
            this.y += dx;
            this.y2 += dx;
        }
    }
}
