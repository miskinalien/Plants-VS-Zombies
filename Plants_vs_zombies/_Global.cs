using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PvZ
{
    class Global
    {
    
        static public SpriteManager Sprites;    // gestionnaire de sprites
        static public Graphics Ecran;           // utilisé pour les drawscreen
        static public int Height;               // hauteur de la zone d'affichage
        static public int dollar = 2000;         // money du joueur
        static public int Round = 1;            // compteur de tour
        static public Spawner spawner;
        
        /////////////////////////////////////////////////////////////////////

        static public Creature Button;            // indique la creature selectionnée

        public enum Creature  { Zombie, ZombieCone, ZombieSot, Tournesol, PistoPois,
                                Mine, Noix, DoublePistoPois, PistoGel, Cerises, Canon };     

        static public List<GE> LE = new List<GE>();  // global list that have all the elements of the game
        static public List<GE> A = new List<GE>(); // all the elements that have to be added to the global list

        // retour un nombre aléatoire entre 0 et n-1

        static public Random randNum = new Random();

        static public int Random(int n) { return randNum.Next(n); }

    }
}
