using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PvZ
{
    class Tournesol:Plant
    {
        public Tournesol(int row, int col):base(row, col, "plante_soleil", 1)
        {
            this.isNeutral = true;
        }

        public override void DoIt()
        {
            base.DoIt();

            int z = Global.Round;
            if (z % 300 == 0)
            {
                Soleil s = new Soleil(this.x, this.y+50);
                Global.A.Add(s);
                s.y = this.y;
                s.move.speedY = 5;                              
            }

        }

    }
}
