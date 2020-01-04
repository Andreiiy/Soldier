using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

using System.Threading.Tasks;

namespace Cscarp_Miki_Maus
{
    class Arm:OrganBody
    {
        private float x2;
        private float y2;

        private int x3;
        private int y3;

        private SolidBrush b;

        private Gun2 gun;
        private Pen pen;
        char mi;
        int fimin;
        int fimin1;

        int fimin2;

        int r;


        public Arm(int x, int y, int hight, int width,char tip,char mi, Color col)
        {
            this.x = x;
            this.y = y;
            this.height = hight;
            this.width = width;

            this.x2 = x;
            this.y2 = y + hight;

            this.x3 = x - width / 2;
            this.y3 = y + hight;

            this.height2 = hight / 6;
            this.width2 = width;
            this.mi = mi;
            
                gun = new Gun2((int)this.x2, (int)this.y2, hight / 3, width * 2, Color.Black);
            
                
            pen = new Pen(col, this.width);
            fimin = 90;
            fimin1 = 90;

            fimin2 = 90;

            r = hight;
           
        }


    public void DrawArm(Graphics gr)
        {
            gr.DrawLine(pen, this.x, this.y, this.x2, this.y2);
            gun.DrawGun2(gr);
            
        }
        /// <summary>
        /// function moves the object to the right
        /// </summary>
        /// <param tipe int></param>
        public override void MoveR(int dx)
        {
            this.x +=dx;
            this.x2 += dx;
            gun.MoveR(dx);


          }
        /// <summary>
        /// function moves the object to the leftt
        /// </summary>
        /// <param tipe int></param>
        public override void MoveL(int dx)
        {
            this.x -= dx;
            this.x2 -= dx;
            gun.MoveL(dx);


        }
        /// <summary>
        ///  function raises a hand with a weapon
        /// </summary>
        /// <param int name="dx"></param>
        /// <param char name="ar"></param>
        public void Arm_Up_Gun(int dx,char ar)
        {
            if (ar == 'r')
            {
                if (fimin >0)
                {
                    fimin -= dx;

                    float cosFimin = (float)Math.Cos(((Math.PI * fimin) / 180));
                    float sinFimin = (float)Math.Sin(((Math.PI * fimin) / 180));

                    x2 = x + r * cosFimin;
                    y2 = y + r * sinFimin;


                    gun.MoveGun((int)this.x2, (int)this.y2);
                }
            }
            else if(ar == 'l')
            {
                if (fimin2 < 180)
                {
                    fimin2 += dx;

                    float cosFimin = (float)Math.Cos(((Math.PI * fimin2) / 180));
                    float sinFimin = (float)Math.Sin(((Math.PI * fimin2) / 180));

                    x2 = x + r * cosFimin;
                    y2 = y + r * sinFimin;


                    gun.MoveGun((int)this.x2, (int)this.y2);
                }
            }
            
            
        }
        /// <summary>
        ///  function raises his hands to the top
        /// </summary>
        /// <param int name="dx"></param>
        /// <param char name="ar"></param>
        public void Arm_Up(int dx, char ar)
        {
            if (ar == 'r')
            {
                if (fimin1 >-90 || fimin1 < -90)
                {
                    fimin1 = -90;

                    float cosFimin1 = (float)Math.Cos(((Math.PI * fimin1) / 180));
                    float sinFimin1 = (float)Math.Sin(((Math.PI * fimin1) / 180));

                    x2 = x + r * cosFimin1;
                    y2 = y + r * sinFimin1;


                    gun.MoveGun((int)this.x2, (int)this.y2);
                }
            }
            else if (ar == 'l')
            {
                if (fimin1 < 270 || fimin1 > 270)
                {
                    fimin1 = 270;

                    float cosFimin1 = (float)Math.Cos(((Math.PI * fimin1) / 180));
                    float sinFimin1 = (float)Math.Sin(((Math.PI * fimin1) / 180));

                    x2 = x + r * cosFimin1;
                    y2 = y + r * sinFimin1;


                    gun.MoveGun((int)this.x2, (int)this.y2);
                }
            }


        }


        /// <summary>
        ///  function lowers hands in the bottom
        /// </summary>
        /// <param int name="dx"></param>
        /// <param char name="ar"></param>
        public void Arm_Down(int dx, char ar)
        {
            if (ar == 'r'&& fimin1!=90)
            {
                if (fimin1 < 90)
                {
                    fimin1 += dx;

                    float cosFimin = (float)Math.Cos(((Math.PI * fimin1) / 180));
                    float sinFimin = (float)Math.Sin(((Math.PI * fimin1) / 180));

                    x2 = x + r * cosFimin;
                    y2 = y + r * sinFimin;
                                        
                }
            }
            else if (ar == 'l')
            {
                if (fimin1 > 90)
                {
                    fimin1 -= dx;

                    float cosFimin = (float)Math.Cos(((Math.PI * fimin1) / 180));
                    float sinFimin = (float)Math.Sin(((Math.PI * fimin1) / 180));

                    x2 = x + r * cosFimin;
                    y2 = y + r * sinFimin;
                                        
                }
            }


        }

        ///////////////////////////////////////////////////////////////
    }
}
