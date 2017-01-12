using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PvZ
{
    class HealthBar
    {
        public int largeur, hauteur, x, y;
        public float initValue, value;        

        public HealthBar(int _value)
        {
            this.largeur = 50;
            this.hauteur = 10;
            this.value = _value;
            this.initValue = _value;
        }

        public void Affichage()
        {
            SolidBrush brush = new SolidBrush(Color.Black);
            SolidBrush brush2 = new SolidBrush(Color.Blue);
            Rectangle r = new Rectangle(this.x, Global.Height - this.y, 50, this.hauteur);
            float ratioLife = this.value / this.initValue;
            Rectangle r2 = new Rectangle(this.x+2, Global.Height - this.y+2, (int)((ratioLife*50) - 3), this.hauteur - 4);
            Global.Ecran.FillRectangle(brush, r);
            Global.Ecran.FillRectangle(brush2, r2);
        }
    }
}
