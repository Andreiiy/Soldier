using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Cscarp_Miki_Maus
{
    class Terorist
    {
        private int x;
        private int y;

        private int height;
        private int width;

        
        Body body;
        HeadTeror headteror;
        public Terorist(int x, int y, int hight, int width, Color Tcolbody, Color Tcolarm, Color Tcolleg, Color Tcolmasc, Color Tcolboot)
        {
            this.x = x;
            this.y = y;
            this.height = hight;
            this.width = width;

            
            headteror = new HeadTeror(this.x, this.y, this.height / 4, this.width, Color.Bisque, Tcolmasc);

            body = new Body(this.x, this.y + this.height / 4, this.height / 4 + this.height / 8, width,'t' , Tcolbody, Tcolarm, Tcolleg,  Tcolboot);


        }

        public void DrawTerorist(Graphics gr)
        {
            
            headteror.DrawHeadTeror(gr);

            body.DrawBody(gr);
        }
        /// <summary>
        /// function moves the object to the right
        /// </summary>
        /// <param tipe int></param>
        public void MoveR(int dx)
        {
            this.x += dx;
            headteror.MoveR(dx);
            body.MoveR(dx);

        }
        /// <summary>
        /// function moves the object to the leftt
        /// </summary>
        /// <param tipe int></param>
        public void MoveL(int dx)
        {
            this.x -= dx;
            headteror.MoveL(dx);
            body.MoveL(dx);

        }
        // <summary>
        ///  function raises a hand with a weapon
        /// </summary>
        /// <param int name="dx"></param>
        /// <param char name="ar"></param>
        public void Arm_Up_GunR(int dx, char ar)
        {
            body.Arm_Up_GunR(dx);

        }
        // <summary>
        ///  function raises a hand with a weapon
        /// </summary>
        /// <param int name="dx"></param>
        
        public void Arm_Up_GunL(int dx)
        {
            body.Arm_Up_GunL(dx);

        }

        /// <summary>
        ///  function raises his hands to the top
        /// </summary>
        /// <param int name="dx"></param>
       
        public void Arm_Up(int dx)
        {
            body.Arm_Up(dx);
        }

        /// <summary>
        ///  function lowers hands in the bottom
        /// </summary>
        /// <param int name="dx"></param>
        
        public void Arm_Down(int dx)
        {
            body.Arm_Down(dx);
        }
        public void MaskUp(int dx)
        {
            headteror.MaskUp(dx);

        }
        public void KnifeDown(int dx)
        {
            body.KnifeDown(1);
           
        }
    }
}
