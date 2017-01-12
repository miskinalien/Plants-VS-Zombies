using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PvZ
{
    class Zombie:GE
    {
        int num_aff;        // manages the zombie walking animation

        public Zombie(int row):base(Coord.GetXBordDroitEcran(), Coord.RowToY(row)+15, "zombie_1", 100)
        {
            Coord.isInfected[row] += 1;
            this.isEnemy = true;
            this.isAlive = true;
            this.move = new Move(-1, 0);
        }

        public override void DoIt()
        {
            base.DoIt();

            Point mvt = move.DoIt(x, y);
            x = mvt.X;
            y = mvt.Y;

            if (this.isCollision())
                move.speedX = 0;
            else
                move.speedX = -1;    

            // manages the animation
            num_aff++;
        }


        public override void Affichage()
        {
            base.Affichage();

            // changes sprite every 20 displays
            int cycle = (num_aff / 10) % 4;

            if (this.healthBar.largeur > 1)
            {
                if (this.isHit == false)
                {
                    String[] T = { "zombie_1", "zombie_2", "zombie_3", "zombie_2" };
                    Global.Sprites.Get(T[cycle]).DrawToScreen(this.x, this.y);
                }
                else
                {
                    if (Global.Round % 2 == 0)
                        this.isHit = false;                    
                    else
                    {
                        String[] T = { "zombie_1_touche", "zombie_2_touche", "zombie_3_touche", "zombie_2_touche" };
                        Global.Sprites.Get(T[cycle]).DrawToScreen(this.x, this.y);
                    }
                }
            }
            else
            {
                // erases the zombie of the infected row
                Coord.isInfected[Coord.YtoRow(this.y)] -= 1;
                move.speedX = 0;
                this.hitBox.Y = 0;
                ZombieDead d = new ZombieDead(this.x, this.y);
                Global.A.Add(d);               
                this.toDelete = true;
            }
            
        }
    }
}
