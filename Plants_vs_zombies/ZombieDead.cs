using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PvZ
{
    class ZombieDead:GE
    {

        public ZombieDead(int posX, int posY):base(posX, posY, "zombie_dead", 100)
        {
            this.isNeutral = true;
        }

        public override void DoIt()
        {
            base.DoIt();
            this.healthBar.value--;
        }

        public override void Affichage()
        {
            base.Affichage();
            Global.Sprites.Get("zombie_dead").DrawToScreen(x, y);
        }
    }
}
