using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PvZ
{
    class DoublePistoPois:Plant
    {
        public DoublePistoPois(int row, int col):base(row, col, "plante_pois_double", 100)
        {
            this.isFriend = true;
        }

        public override void DoIt()
        {
            base.DoIt();

            int z = Global.Round;
            if ((z % 20 == 0) && (Coord.isInfected[Coord.YtoRow(this.y)] > 0))
            {
                Pois pois = new Pois(this.x, this.y);
                Global.A.Add(pois);
            }

        }

    }
}
