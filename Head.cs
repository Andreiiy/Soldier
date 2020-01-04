using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Cscarp_Miki_Maus
{
    class Head
    {
        private int x;
        private int y;
        private int height;
        private int width;
        private Eye leye;
        private Eye reye;

        private Ear lear;
        private Ear rear;

        private Mouth mouth;

        private Hat hat;

        private Nose nose;
        
        private SolidBrush b;


        public Head(int x, int y, int hight, int width, Color colhead, Color colhat)
        {
            this.x = x;
            this.y = y;
            this.height = hight;
            this.width = width;
            this.leye = new Eye(x + width / 6, y + height / 7, hight / 3, width / 3, Color.White, Color.Black);
            this.reye = new Eye(x + width / 2, y + height / 7, hight / 3, width / 3, Color.White, Color.Black);

            this.lear = new Ear((x - width / 8) + width / 20, y + hight / 3, hight / 5, width / 8, Color.Bisque, Color.Black);
            this.rear = new Ear((x + width) - width / 20, y + hight / 3, hight / 5, width / 8, Color.Bisque, Color.Black);

            this.mouth = new Mouth(x + width / 4, y + (hight - (hight / 3)), hight / 8, width / 2, Color.Red, Color.Black);

            this.hat = new Hat(x + width / 6, y - hight / 8, hight / 4, (width / 3) * 2, colhat);

            this.nose = new Nose(this.x + (width / 2 ), y + height / 2, height / 5,height / 2);
            
            b = new SolidBrush(colhead);
        }


        public void DrawHead(Graphics gr)
        {
            gr.FillEllipse(this.b, new Rectangle(this.x, this.y, this.width, this.height));
            leye.DrawEye(gr);
            reye.DrawEye(gr);
            lear.DrawEar(gr);
            rear.DrawEar(gr);
            mouth.DrawMouth(gr);
            hat.DrawHat(gr);
            nose.DrawNose(gr);


        }
        public void MoveR(int dx)
        {
            this.x += dx;
           
            this.leye.MoveR(dx);
            this.reye.MoveR(dx);
            this.lear.MoveR(dx);
            this.rear.MoveR(dx);
            this.mouth.MoveR(dx);
            this.hat.MoveR(dx);
            this.nose.MoveR(dx);


        }
        public void MoveL(int dx)
        {
            this.x -= dx;

            this.leye.MoveL(dx);
            this.reye.MoveL(dx);
            this.lear.MoveL(dx);
            this.rear.MoveL(dx);
            this.mouth.MoveL(dx);
            this.hat.MoveL(dx);
            this.nose.MoveL(dx);


        }
    }
}
