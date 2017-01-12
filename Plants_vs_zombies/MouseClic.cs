using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PvZ
{
    class MouseClic
    {

        ///////////////////////////////////////////////////////////////////////////////////////////

            // fonction d'entrée du clic SOURIS
            // les coordonnées sont cartésiennes
        
        static public void Event(int x, int y)
        {
            Point p = new Point(x, y); // point correspondant aux coordonnées de la souris
            int z = Global.Round;

            if (Global.Button == Global.Creature.PistoPois)
            {
                int colonne = Coord.XtoColumn(x);
                int rangee = Coord.YtoRow(y);

                if (rangee >= 0 && rangee < 5 && colonne < 9 && colonne >= 0)
                {
                    if (Coord.isOccupied[rangee, colonne] == false && Global.dollar >= 100)
                    {
                        Global.LE.Add(new PistoPois(rangee, colonne));
                        Global.dollar -= 100;
                    }
                }
            }

            if (Global.Button == Global.Creature.DoublePistoPois)
            {
                int colonne = Coord.XtoColumn(x);
                int rangee = Coord.YtoRow(y);

                if (rangee >= 0 && rangee < 5 && colonne < 9 && colonne >= 0)
                {
                    if (Coord.isOccupied[rangee, colonne] == false && Global.dollar >= 200)
                    {
                        Global.LE.Add(new DoublePistoPois(rangee, colonne));
                        Global.dollar -= 200;
                    }
                }
            }

            if (Global.Button == Global.Creature.Tournesol)
            {
                int colonne = Coord.XtoColumn(x);
                int rangee = Coord.YtoRow(y);

                if (rangee >= 0 && rangee < 5 && colonne < 9 && colonne >= 0)
                {
                    if (Coord.isOccupied[rangee, colonne] == false && Global.dollar >= 50)
                    {
                        Global.LE.Add(new Tournesol(rangee, colonne));
                        Global.dollar -= 50;
                    }
                }
            }      
            
            if(Global.Button == Global.Creature.Noix)
            {
                int colonne = Coord.XtoColumn(x);
                int rangee = Coord.YtoRow(y);

                if (rangee >= 0 && rangee < 5 && colonne < 9 && colonne >= 0)
                {
                    if (Coord.isOccupied[rangee, colonne] == false && Global.dollar >= 50)
                    {
                        Global.LE.Add(new Noix(rangee, colonne));
                        Global.dollar -= 50;
                    }
                }
            }      

            // pour chaque soleil de la liste
            foreach (GE g in Global.LE)
            {
                if (g.name == "soleil")
                {
                    // on associe un rectangle au soleil s
                    Rectangle r = new Rectangle(g.x, g.y, Properties.Resources.soleil.Width, Properties.Resources.soleil.Height);

                    if (isMouseIn(r, p)) // si la souris a cliqué dans le rectangle associé au soleil s
                    {
                        // le joueur a cliqué sur le soleil s
                        g.isClicked = true;
                        Global.dollar += 50;
                        g.toDelete = true;
                    }
                }
            }
        }

        // fonction booléenne retournant vrai si la souris clique dans un rectangle entré en paramètre
        static public bool isMouseIn(Rectangle r, Point p)
        {        
            return (r.Contains(p));         
        }
    }
}
