using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Cscarp_Miki_Maus
{
    class Tank
    {
        Bashnya bas;
        Korpus kor;
    
    public Tank(int x, int y, int hight, int width)
    {
            
            bas = new Bashnya(x+ width / 3, y- hight/3, hight/3, width/2);
        kor = new Korpus(x, y , (hight / 3)*2, width);
    }
        public void DrawBashnya(Graphics gr)
        {
            bas.DrawBashnya(gr);
            kor.DrawBashnya(gr);
        }
        /// <summary>
        /// function moves the object to the right
        /// </summary>
        /// <param name="dx"></param>
        public void MoveR(int dx)
        {
            kor.MoveR(dx);
            bas.MoveR(dx);
                       
        }
    }
}
