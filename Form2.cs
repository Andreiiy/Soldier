using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Cscarp_Miki_Maus
{
    public partial class Form2 : Form
    {
        private int x, y, w, h, count;

        Soldier soldier;
        Terorist terorist;

        Terorist terorist0;
        Terorist terorist1;
        Terorist terorist2;
        Terorist terorist3;
        Terorist terorist4;


        Color Scolbody;
        Color Scolarm;
        Color Scolleg;
        Color Scolhat;
        Color Scolboot;



        Color Tcolbody;
        Color Tcolarm;
        Color Tcolleg;
        Color Tcolmasc;
        Color Tcolboot;

        Terorist[] listOfTerorist;
        Tank tank;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(count<1000)
            terorist.MoveL(1);

            if (count > 1000 && count < 1090)
            terorist.Arm_Up_GunL(20);

            if (count > 1090 && count < 1180)
            soldier.Arm_Up_GunR(20);

            if (count > 1180 && count < 1390)
                terorist.KnifeDown(10);

            if (count > 1390 && count < 1480)
                terorist.Arm_Up(10);

            if (count > 1480 && count < 2000)
                terorist.MaskUp(100);

            if (count > 2000 && count < 2190)
                terorist.Arm_Down(10);

            if (count > 2190 && count < 2290)
                terorist.MoveR(1);

            if (count > 2290 && count < 2790)
            {
             terorist.MoveR(1);
             soldier.MoveR(1);

            }
            if (count > 2790 && count < 3100)
            {
                for(int i = 0; i < listOfTerorist.Length; i++)
                {
                    listOfTerorist[i].MoveL(1);
                }

            }
            if (count > 3100 && count < 3650)
            {
                tank.MoveR(1);
            }

            if (count > 3670 && count < 3820)
            {
                
                for (int i = 0; i < listOfTerorist.Length; i++)
                {
                    listOfTerorist[i].KnifeDown(1);
                }

            }
            if (count > 3820 && count < 3830)
            {
                
                for (int i = 0; i < listOfTerorist.Length; i++)
                {
                    listOfTerorist[i].MaskUp(100);
                }

            }
            if (count > 3820 && count < 3910)
            {

                for (int i = 0; i < listOfTerorist.Length; i++)
                {
                    listOfTerorist[i].Arm_Up(1);
                }
                terorist.Arm_Up(10);
            }

            count++;
                        
            Invalidate();
        }

        public Form2()
        {
            InitializeComponent();
            count = 0;
            x = 140;
            y = 450;
            h = 220;
            w = 50;
                       
            tank = new Tank(-550, 500, 320, 400);

            soldier = new Soldier(30, 450, this.h, this.w,
            this.Scolbody, this.Scolarm, this.Scolleg, this.Scolhat, this.Scolboot);

            terorist = new Terorist(this.x + 1200, 450, this.h, this.w,
            this.Tcolbody, this.Tcolarm, this.Tcolleg, this.Tcolmasc, this.Tcolboot);

            terorist0 = new Terorist(this.x + 1200, 450, this.h, this.w,
                this.Tcolbody, this.Tcolarm, this.Tcolleg, this.Tcolmasc, this.Tcolboot);
            terorist1 = new Terorist(this.x + 1250, 450, this.h + 20, this.w,
                this.Tcolbody, this.Tcolarm, this.Tcolleg, this.Tcolmasc, this.Tcolboot);
            terorist2 = new Terorist(this.x + 1300, 450, this.h, this.w,
                this.Tcolbody, this.Tcolarm, this.Tcolleg, this.Tcolmasc, this.Tcolboot);
            terorist3 = new Terorist(this.x + 1350, 450, this.h, this.w,
                this.Tcolbody, this.Tcolarm, this.Tcolleg, this.Tcolmasc, this.Tcolboot);
            terorist4 = new Terorist(this.x + 1400, 450, this.h + 10, this.w,
                this.Tcolbody, this.Tcolarm, this.Tcolleg, this.Tcolmasc, this.Tcolboot);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            count = 0;
            x = 140;
            y = 450;
            h = 220;
            w = 50;



            tank = new Tank(-550, 500, 320, 400);

            soldier = new Soldier(30, 450, this.h, this.w,
            this.Scolbody, this.Scolarm, this.Scolleg, this.Scolhat, this.Scolboot);

            terorist = new Terorist(this.x + 1200, 450, this.h, this.w,
            this.Tcolbody, this.Tcolarm, this.Tcolleg, this.Tcolmasc, this.Tcolboot);

            terorist0 = new Terorist(this.x + 1200, 450, this.h, this.w, 
                this.Tcolbody, this.Tcolarm, this.Tcolleg, this.Tcolmasc, this.Tcolboot);
            terorist1 = new Terorist(this.x + 1250, 450, this.h+20, this.w,
                this.Tcolbody, this.Tcolarm, this.Tcolleg, this.Tcolmasc, this.Tcolboot);
            terorist2 = new Terorist(this.x + 1300, 450, this.h, this.w,
                this.Tcolbody, this.Tcolarm, this.Tcolleg, this.Tcolmasc, this.Tcolboot);
            terorist3 = new Terorist(this.x + 1350, 450, this.h, this.w,
                this.Tcolbody, this.Tcolarm, this.Tcolleg, this.Tcolmasc, this.Tcolboot);
            terorist4 = new Terorist(this.x + 1400, 450, this.h+10, this.w,
                this.Tcolbody, this.Tcolarm, this.Tcolleg, this.Tcolmasc, this.Tcolboot);

            listOfTerorist = new Terorist[5];
            listOfTerorist[0] = terorist0;
            listOfTerorist[1] = terorist1;
            listOfTerorist[2] = terorist2;
            listOfTerorist[3] = terorist3;
            listOfTerorist[4] = terorist4;
            
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            
            soldier.DrawSoldier(e.Graphics);
            
            terorist.DrawTerorist(e.Graphics);
            terorist0.DrawTerorist(e.Graphics);
            terorist1.DrawTerorist(e.Graphics);
            terorist2.DrawTerorist(e.Graphics);
            terorist3.DrawTerorist(e.Graphics);
            terorist4.DrawTerorist(e.Graphics);

            tank.DrawBashnya(e.Graphics);
            timer1.Start();
        }
        public void Get_Color(Color Scolbody, Color Scolarm, Color Scolleg, Color Scolhat, Color Scolboot, 
            Color Tcolbody, Color Tcolarm, Color Tcolleg, Color Tcolmasc, Color Tcolboot)
        {

            this.Scolbody = Scolbody;
            this.Scolarm = Scolarm;
            this.Scolleg = Scolleg;
            this.Scolhat = Scolhat;
            this.Scolboot = Scolboot;

            this.Tcolbody = Tcolbody;
            this.Tcolarm = Tcolarm;
            this.Tcolleg = Tcolleg;
            this.Tcolmasc = Tcolmasc;
            this.Tcolboot = Tcolboot;

        }
    }
}
