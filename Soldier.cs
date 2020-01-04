using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Cscarp_Miki_Maus
{
    class Soldier
    {
        private int x;
        private int y;

        private int height;
        private int width;

        Head head;
        Body body;
        
        public Soldier(int x, int y, int hight, int width,
            Color Scolbody, Color Scolarm, Color Scolleg, Color Scolhat, Color Scolboot)
        {
            this.x = x;
            this.y = y;
            this.height = hight;
            this.width = width;

            head = new Head(this.x, this.y, this.height/4, this.width, Color.Bisque, Scolhat);
           

            body = new Body(this.x, this.y + this.height/4, this.height / 4 + this.height / 8, width,'s', Scolbody, Scolarm, Scolleg,  Scolboot);


        }

        public void DrawSoldier(Graphics gr)
        {
            head.DrawHead(gr);
           

            body.DrawBody(gr);
        }
        /// <summary>
        /// function moves the object to the right
        /// </summary>
        /// <param name="dx"></param>
        public void MoveR(int dx)
        {
            this.x += dx;
            head.MoveR(dx);
            body.MoveR(dx);

        }
        /// <summary>
        /// function moves the object to the leftt
        /// </summary>
        /// <param name="dx"></param>
        public void MoveL(int dx)
        {
            this.x -= dx;
            head.MoveL(dx);
            body.MoveL(dx);

        }
        /// <summary>
        /// function raises a hand with a weapon
        /// </summary>
        /// <param name="dx"></param>
        public void Arm_Up_GunR(int dx)
        {
            body.Arm_Up_GunR(dx);

        }
        /// <summary>
        /// function raises a hand with a weapon
        /// </summary>
        /// <param name="dx"></param>
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
    }
}
