using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Cscarp_Miki_Maus
{
    class Body:OrganBody
    {
                       
        private int xpr;
        private int ypr;

        private int heightpr;
        private int widthpr;

        private int xpl;
        private int ypl;

        private char tip;

        private int heightpl;
        private int widthpl;

        private SolidBrush b;
        private SolidBrush bp;
        private SolidBrush b2;

        private Arm l_arm;
        private Arm r_arm;

        private ArmTeror Tl_arm;
        private ArmTeror Tr_arm;

        private Leg l_leg;
        private Leg r_leg;

        


        public Body(int x, int y, int hight, int width,char tip, Color Scolbody, Color Scolarm, Color Scolleg, Color Scolboot)
        {
            this.x = x;
            this.y = y;
            this.height = hight;
            this.width = width;

            this.x2 = x;
            this.y2 = y+ hight/2;
            this.height2 = hight/10;
            this.width2 = width;

            this.xpr = x + width - width / 50;
            this.ypr = y- hight/13;
            this.heightpr = hight/6;
            this.widthpr = width/4;

            this.xpl = x - width / 4;
            this.ypl = y - hight / 13;
            this.heightpl = hight / 6;
            this.widthpl = width / 4;
            
            this.tip=tip;
            
            b = new SolidBrush(Scolbody);
            bp = new SolidBrush(Scolarm);

            b2 = new SolidBrush(Color.Brown);
            if(tip=='t')
            { 
            this.Tl_arm = new ArmTeror(this.x - this.width / 8, this.y, (this.height / 3) * 2, this.width / 4,'l' , Scolarm);
            this.Tr_arm = new ArmTeror(this.x + this.width + this.width / 8, this.y, (this.height / 3) * 2, this.width / 4,'r', Scolarm);
            }
            else
            {
                this.l_arm = new Arm(this.x - this.width / 8, this.y, (this.height / 3) * 2, this.width / 4, 'l', 's', Scolarm);
                this.r_arm = new Arm(this.x + this.width + this.width / 8, this.y, (this.height / 3) * 2, this.width / 4, 'l', 's', Scolarm);
            }
            this.l_leg = new Leg(this.x, this.y+ this.height, (this.height / 3) * 2, this.width / 3, Scolleg, Scolboot);
            this.r_leg = new Leg(this.x + (this.width/3)*2, this.y+ this.height, (this.height / 3) * 2, this.width / 3, Scolleg, Scolboot);

        }


        public void DrawBody(Graphics gr)
        {
             gr.FillEllipse(this.bp, new Rectangle(this.xpr, this.ypr, this.widthpr, this.heightpr));
            gr.FillEllipse(this.bp, new Rectangle(this.xpl, this.ypl, this.widthpl, this.heightpl));

            gr.FillRectangle(this.b, new Rectangle(this.x, this.y, this.width, this.height));
            gr.FillRectangle(this.b2, new Rectangle(this.x2, this.y2, this.width2, this.height2));
            if (tip == 't')
            {
             Tl_arm.DrawArm(gr);
             Tr_arm.DrawArm(gr);
            }
            else
            {
            l_arm.DrawArm(gr);
            r_arm.DrawArm(gr);
            }   

           

            l_leg.DrawLeg(gr);
            r_leg.DrawLeg(gr);
           
        }
        /// <summary>
        /// function moves the object to the right
        /// </summary>
        /// <param name="dx"></param>
        public override void MoveR(int dx)
        {
            this.x += dx;
            this.x2 += dx;
            this.xpl += dx;
            this.xpr += dx;

            if (tip == 't')
            {
            Tl_arm.MoveR(dx);
            Tr_arm.MoveR(dx);
            }
            else
            {
                l_arm.MoveR(dx);
                r_arm.MoveR(dx);
            }
            l_leg.MoveR(dx);
            r_leg.MoveR(dx);
        }
        /// <summary>
        /// function moves the object to the leftt
        /// </summary>
        /// <param name="dx"></param>
        public override void MoveL(int dx)
        {
            this.x -= dx;
            this.x2 -= dx;
            this.xpl -= dx;
            this.xpr -= dx;
            if (tip == 't')
            {
                Tl_arm.MoveL(dx);
                Tr_arm.MoveL(dx);
            }
            else
            {
            l_arm.MoveL(dx);
            r_arm.MoveL(dx);
            }
                

            l_leg.MoveL(dx);
            r_leg.MoveL(dx);
        }
        /// <summary>
        /// function raises a hand with a weapon
        /// </summary>
        /// <param name="dx"></param>
        public void Arm_Up_GunR(int dx)
        {
            if (tip == 't')
            {
                Tr_arm.Arm_Up_Gun(dx, 'r');
                Tl_arm.Arm_Up_Gun(0, 'l');
            }
            else
            {
            r_arm.Arm_Up_Gun(dx,'r');
            l_arm.Arm_Up_Gun(0, 'l');
            }
            
        }
        /// <summary>
        /// function raises a hand with a weapon
        /// </summary>
        /// <param name="dx"></param>
        public void Arm_Up_GunL(int dx)
        {
            if (tip == 't')
            {
                Tr_arm.Arm_Up_Gun(0, 'r');
                Tl_arm.Arm_Up_Gun(dx, 'l');
            }
            else
            {
            r_arm.Arm_Up_Gun(0, 'r');
            l_arm.Arm_Up_Gun(dx, 'l');
            }
            
        }
        /// <summary>
        ///  function raises his hands to the top
        /// </summary>
        /// <param int name="dx"></param>
        public void Arm_Up(int dx)
        {
            if (tip == 't')
            {
                Tr_arm.Arm_Up(dx, 'r');
                Tl_arm.Arm_Up(dx, 'l');
            }
            else
            {
              r_arm.Arm_Up(dx, 'r');
              l_arm.Arm_Up(dx, 'l');
            }
                
        }
        /// <summary>
        ///  function lowers hands in the bottom
        /// </summary>
        /// <param int name="dx"></param>
        public void Arm_Down(int dx)
        {
            if (tip == 't')
            {
                Tr_arm.Arm_Down(dx, 'r');
                Tl_arm.Arm_Down(dx, 'l');
            }
            else
            {
            r_arm.Arm_Down(dx, 'r');
            l_arm.Arm_Down(dx, 'l');
            }
                
        }
        /// <summary>
        ///  function lowers knife in the bottom
        /// </summary>
        /// <param int name="dx"></param>
        public void KnifeDown(int dx)
        {
            Tr_arm.KnifeDown(1);
            Tl_arm.KnifeDown(1);

        }
    }
}
