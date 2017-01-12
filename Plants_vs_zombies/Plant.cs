using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PvZ
{
    class Plant:GE
    {
        public Plant(int row, int col, string _spriteName, int _life):base(Coord.ColToX(col)+15, Coord.RowToY(row)+25, _spriteName, _life)
        {
            this.isAlive = true;
            Coord.isOccupied[row, col] = true;
        }

        public override void Affichage() 
        {
            base.Affichage();
            Global.Sprites.Get(name).DrawToScreen(x, y);
        }
       
    }
}
