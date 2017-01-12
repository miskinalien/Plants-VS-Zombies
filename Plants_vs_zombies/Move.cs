using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing; 

namespace PvZ
{
    class Move
    {
        public int speedX, speedY;

        public Move(int _speedX, int _speedY)
        {
            this.speedX = _speedX;
            this.speedY = _speedY;
        }

        public Point DoIt(int x, int y)
        {           
            x += this.speedX;
            y += this.speedY;
            
            return new Point(x, y); 
        }
    }
}
