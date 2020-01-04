using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Cscarp_Miki_Maus
{
    class HeadTeror:OrganBody
    {
       
        private Eye leye;
        private Eye reye;

        private Ear lear;
        private Ear rear;

        private Mouth mouth;

        private Mask maska;

        private SolidBrush b;


        public HeadTeror(int x, int y, int hight, int width, Color colhead, Color colmasc)
        {
            this.x = x;
            this.y = y;
            this.height = hight;
            this.width = width;
            this.leye = new Eye(x + width / 6, y + height / 7, hight / 2, width / 3, Color.White, Color.Black);
            this.reye = new Eye(x + width / 2, y + height / 7, hight / 2, width / 3, Color.White, Color.Black);

            this.lear = new Ear((x - width / 3) + width / 20, y + hight / 5, hight / 2, width / 3, Color.Bisque, Color.Black);
            this.rear = new Ear((x + width) - width / 20, y + hight / 5, hight / 2, width / 3, Color.Bisque, Color.Black);

            this.mouth = new Mouth(x + width / 6, y + (hight - (hight / 3)), hight / 4, (width / 3)*2, Color.Red, Color.Black);

            this.maska = new Mask(x  , y, hight , width , colmasc);
                  


            b = new SolidBrush(colhead);
        }


        public void DrawHeadTeror(Graphics gr)
        {
            gr.FillEllipse(this.b, new Rectangle(this.x, this.y, this.width, this.height));
            leye.DrawEye(gr);
            reye.DrawEye(gr);
            lear.DrawEar(gr);
            rear.DrawEar(gr);
            mouth.DrawMouth(gr);
            maska.DrawMask(gr);
            


        }
        /// <summary>
        /// function moves the object to the right
        /// </summary>
        /// <param name="dx"></param>
        public override void MoveR(int dx)
        {
            this.x += dx;

            this.leye.MoveR(dx);
            this.reye.MoveR(dx);
            this.lear.MoveR(dx);
            this.rear.MoveR(dx);
            this.mouth.MoveR(dx);
            this.maska.MoveR(dx);
            


        }
        /// <summary>
        /// function moves the object to the leftt
        /// </summary>
        /// <param name="dx"></param>
        public override void MoveL(int dx)
        {
            this.x -= dx;

            this.leye.MoveL(dx);
            this.reye.MoveL(dx);
            this.lear.MoveL(dx);
            this.rear.MoveL(dx);
            this.mouth.MoveL(dx);
            this.maska.MoveL(dx);



        }
        /// <summary>
        /// function raises a mask with a weapon
        /// </summary>
        /// <param name="dx"></param>
        public void MaskUp(int dx)
        {
            maska.MaskUp(dx);

        }

    }
}
