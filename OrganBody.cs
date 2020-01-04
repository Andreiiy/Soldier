using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cscarp_Miki_Maus
{
   public class OrganBody
    {
        protected int x;
        protected int y;

        protected int height;
        protected int width;

        protected int x2;
        protected int y2;

        protected int height2;
        protected int width2;

       

        /// <summary>
        /// function moves the object to the right
        /// </summary>
        /// <param tipe int></param>
        public virtual void MoveR(int dx)
        {
            this.x += dx;
            this.x2 += dx;
        }
        /// <summary>
        /// function moves the object to the leftt
        /// </summary>
        /// <param tipe int></param>
        public virtual void MoveL(int dx)
        {
            this.x -= dx;
            this.x2 -= dx;
        }
    }
}
