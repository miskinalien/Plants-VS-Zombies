using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PvZ
{
    class Spawner
    {

        public int c, z;
        GE e;

        public void DoIt()
        {
            c = Global.Round; // compteur c = nombre de tours

            if(c%80 == 0) // tous les 80 tours
            {
                int x, y;
                
                x = Global.Random(9); // on crée un x random entre 0 et 9 car il y a 9 colonnes                             
                x = Coord.ColToX(x) + 15; // on convertit la coordonnée de case du jeu en coordonnée écran  
                y = Global.Random(5); // on crée un y random entre 0 et 5 car il y a 5 lignes
                y = Coord.RowToY(y) + 30; // on convertit la coordonnée de case du jeu en coordonnée écran

                // on crée un nouveau soleil avec les coordonnées obtenues et on l'ajoute à la liste des soleils  
                Soleil s = new Soleil(x, y);
               
                Global.LE.Add(s); // 
                
                c = 0; // on remet le compteur à zéro 
            }

            z = Global.Round; // compteur z = nombre de tours

            if (z % 40 == 0)
            {
                int y = Global.Random(5);
                e = new Zombie(y);
                
                Global.LE.Add(e);
                y = 0;
            }
            
        }
        
    }
}
