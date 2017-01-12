using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PvZ
{
    class Soleil:GE
    {
        public int y_arrivee;            // sun position, speed, and final position 

        public Soleil(int px, int py):base(px, py, "soleil", 500)
        {
            this.y = 626;
            this.y_arrivee = py;
            this.isNeutral = true;
            this.move = new Move(0, -5);
        }

        public override void DoIt()
        {
            base.DoIt();

            Point mvt = move.DoIt(x, y);
            x = mvt.X;
            
            if (y > y_arrivee)      // if sun height hasn't reach the height goal
                y = mvt.Y;          // sun continues to go down 
            else 
            {
                if (this.isClicked == false)
                    Coord.isOccupied[Coord.YtoRow(this.y), Coord.XtoColumn(this.x)] = true;
                else
                    Coord.isOccupied[Coord.YtoRow(this.y), Coord.XtoColumn(this.x)] = false;                       
            }
            this.healthBar.value--;    // sun life decreases at each round
        }

        public override void Affichage()
        {
            base.Affichage();
            Global.Sprites.Get("soleil").DrawToScreen(x, y);
        }
    }
}
