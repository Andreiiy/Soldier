using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Cscarp_Miki_Maus
{
    class ArmTeror:OrganBody
    {
        private float x2;
        private float y2;

        private int x3;
        private int y3;

        private SolidBrush b;
                
        Knife knife;
        Pen pen;
        
        int fimin;
        int fimin1;

        

        int r;


        public ArmTeror(int x, int y, int height, int width, char tip, Color col)
        {
            this.x = x;
            this.y = y;
            this.height = height;
            this.width = width;

            this.x2 = x;
            this.y2 = y + height;

            this.x3 = x - width / 2;
            this.y3 = y + height;

            this.height2 = height / 6;
            this.width2 = width;
                        
            knife = new Knife((int)this.x2, (int)this.y2, height / 3, width * 5, Color.Black);
             

            pen = new Pen(col, this.width);
            fimin = 90;
            fimin1 = 90;
                    

            r = height;
           
        }


        public void DrawArm(Graphics gr)
        {
            gr.DrawLine(pen, this.x, this.y, this.x2, this.y2);

            knife.DrawKnife(gr);

        }
        /// <summary>
        /// function moves the object to the right
        /// </summary>
        /// <param name="dx"></param>
        public override void MoveR(int dx)
        {
            this.x += dx;
            this.x2 += dx;

            knife.MoveR(dx);

        }
        /// <summary>
        /// function moves the object to the leftt
        /// </summary>
        /// <param name="dx"></param>
        public override void MoveL(int dx)
        {
            this.x -= dx;
            this.x2 -= dx;
            knife.MoveL(dx);



        }
        /// <summary>
        /// function raises a hand with a weapon
        /// </summary>
        /// <param name="dx"></param>
        public  void Arm_Up_Gun(int dx, char ar)
        {
            if (ar == 'r')
            {
                if (fimin > 0)
                {
                    fimin -= dx;

                    float cosFimin = (float)Math.Cos(((Math.PI * fimin) / 180));
                    float sinFimin = (float)Math.Sin(((Math.PI * fimin) / 180));

                    x2 = x + r * cosFimin;
                    y2 = y + r * sinFimin;


                    knife.MoveKnife((int)this.x2, (int)this.y2);
                }
            }
            else if (ar == 'l')
            {
                if (fimin1 < 180)
                {
                    fimin1 += dx;

                    float cosFimin = (float)Math.Cos(((Math.PI * fimin1) / 180));
                    float sinFimin = (float)Math.Sin(((Math.PI * fimin1) / 180));

                    x2 = x + r * cosFimin;
                    y2 = y + r * sinFimin;


                    knife.MoveKnife((int)this.x2, (int)this.y2);
                }
            }


        }
        /// <summary>
        ///  function raises his hands to the top
        /// </summary>
        /// <param int name="dx"></param>

        public  void Arm_Up(int dx, char ar)
        {
            if (ar == 'r')
            {
                if (fimin > -90)
                {

                    while (fimin > -90)
                    {
                        fimin -= dx;
                        float cosFimin = (float)Math.Cos(((Math.PI * fimin) / 180));
                        float sinFimin = (float)Math.Sin(((Math.PI * fimin) / 180));

                        x2 = x + r * cosFimin;
                        y2 = y + r * sinFimin;
                    }
                }
            }
            else if (ar == 'l')
            {
                if (fimin1 < 270)
                {
                    while (fimin1 < 270)
                    {
                        fimin1 += dx;
                        float cosFimin1 = (float)Math.Cos(((Math.PI * fimin1) / 180));
                        float sinFimin1 = (float)Math.Sin(((Math.PI * fimin1) / 180));

                        x2 = x + r * cosFimin1;
                        y2 = y + r * sinFimin1;
                    }
                }
            }
        }

        /// <summary>
        ///  function lowers hands in the bottom
        /// </summary>
        /// <param int name="dx"></param>
        public  void Arm_Down(int dx, char ar)
        {
            if (ar == 'r')
            {
                if (fimin < 90)
                {
                    fimin += dx;

                    float cosFimin = (float)Math.Cos(((Math.PI * fimin) / 180));
                    float sinFimin = (float)Math.Sin(((Math.PI * fimin) / 180));

                    x2 = x + r * cosFimin;
                    y2 = y + r * sinFimin;
                                        
                }
            }
            else if (ar == 'l')
            {
                if (fimin1 > 90)
                {
                    fimin1 -= dx;

                    float cosFimin1 = (float)Math.Cos(((Math.PI * fimin1) / 180));
                    float sinFimin1 = (float)Math.Sin(((Math.PI * fimin1) / 180));

                    x2 = x + r * cosFimin1;
                    y2 = y + r * sinFimin1;
                                        
                }
            }


        }
        /// <summary>
        ///  function lowers knife in the bottom
        /// </summary>
        /// <param int name="dx"></param>
        public void KnifeDown(int dx)
        {
            knife.KnifeDown(1);
        }
    }
}
