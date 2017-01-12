using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PvZ
{
    class Coord
    {
        ///////////////////////////////////////////////////////////////////////////////////////
        //
        //      permet de convertir (x,y) souris cartésiens => n° colonne / rangée 


        // les cases dans le jeu font 100 pixel de haut et 80 pixel de large.
        // Damier de 5x9 cases

        static int yRaw   = 60;   // hauteur de la rangée du bas
        static int xStart = 250;  // position de la première colonne à gauche
        static int xBordDroitEcran = 1024;
        static int largeur_case = 80;
        static int hauteur_case = 100;
        static public bool[,] isOccupied = new bool[5,9];
        static public int[] isInfected = new int[5];

        public static int YtoRow(int y)
        {
            // il y a 5 allées de 100 pixels de hauteur

            if ((y < yRaw) && (y >= yRaw + 5 * hauteur_case))
                return -1;

            // les rangées font 100 pixels de hauteur
            return (y - yRaw) / hauteur_case;
        }

        public static int XtoColumn(int x)
        {
            // il y a 9 colonnes de 80 pixels de largeur
            if ((x < xStart) || (x >= xStart + largeur_case * 9)) return -1;

            return (x - xStart) / largeur_case;
        }

        public static int RowToY(int row) { return row * hauteur_case + yRaw; }
        public static int ColToX(int col) { return col * largeur_case + xStart; }

        public static int GetXBordDroitEcran() { return xBordDroitEcran; }
    }
}
