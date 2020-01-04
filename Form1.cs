using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Cscarp_Miki_Maus
{
    

    public partial class Form1 : Form
    {
      private  int x, y, w, h,count;
        
        Soldier soldier;
        
        Terorist terorist;

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

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Prog = new Form2();
            Colors color = new Colors();
            Scolhat = color.Set_Color(comboBox1.Text);
            Scolbody = color.Set_Color(comboBox2.Text);
            Scolarm = color.Set_Color(comboBox3.Text);
            Scolleg = color.Set_Color(comboBox4.Text);
            Scolboot = color.Set_Color(comboBox5.Text);

            Tcolmasc = color.Set_Color(comboBox6.Text);
            Tcolbody = color.Set_Color(comboBox7.Text);
            Tcolarm = color.Set_Color(comboBox8.Text);
            Tcolleg = color.Set_Color(comboBox9.Text);
            Tcolboot = color.Set_Color(comboBox10.Text);



            Prog.Get_Color( Scolbody, Scolarm, Scolleg, Scolhat, Scolboot, Tcolbody, Tcolarm,Tcolleg, Tcolmasc, Tcolboot);
            Prog.Hide();
            Prog.Show();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            count = 0;
            x = 440;
            y =150;
            h = 440;
            w = 100;
            terorist = new Terorist(x+300, y, h, w, Color.Bisque, Color.Bisque, Color.Bisque, Color.Bisque, Color.Bisque);
            soldier = new Soldier(x, y, h, w, Color.Bisque, Color.Bisque, Color.Bisque, Color.Bisque, Color.Bisque);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            soldier.DrawSoldier(e.Graphics);

            terorist.DrawTerorist(e.Graphics);
        }
    }
}
