using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PvZ
{
    class Noix:Plant
    {
        public Noix(int row, int col):base(row, col, "noix_1", 2000)
        {
            this.isFriend = true;
        }

        public override void DoIt()
        {
            base.DoIt();   
        }

        public override void Affichage()
        {
            base.Affichage();
            if(this.healthBar.value > ((2000/3) * 2))
                Global.Sprites.Get("noix_1").DrawToScreen(this.x, this.y);
            if(this.healthBar.value > 2000/3 && this.healthBar.value < ((2000/3) * 2))
                Global.Sprites.Get("noix_2").DrawToScreen(this.x, this.y);
            if(this.healthBar.value < 2000/3)
                Global.Sprites.Get("noix_3").DrawToScreen(this.x, this.y);

        }
        
    }
}
