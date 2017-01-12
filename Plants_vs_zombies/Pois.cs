using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PvZ
{
    class Pois:GE
    {
        public int speedX;

        public Pois(int px, int py):base(px+40, py+25, "tir_pois", 1)
        {
            this.move = new Move(12, 0);
            this.isPois = true;
        }

        public override void DoIt()
        {
            base.DoIt();
            Point mvt = move.DoIt(x, y);
            x = mvt.X;
            y = mvt.Y;

            if (!(Coord.XtoColumn(x) <= 9))
                this.toDelete = true;                             
        }

        public override void Affichage()
        {
            base.Affichage();
            Global.Sprites.Get("tir_pois").DrawToScreen(x, y);
        }

    }
}
