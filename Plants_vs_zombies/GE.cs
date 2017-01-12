using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PvZ
{
    abstract class GE    
    {
        public String name;                 // sprite name
        public bool isHit, isClicked, isFighting = false;
                                            // different states of the element

        public int x, y;                    // position of the element

        public HealthBar healthBar;              // each element has a life, except Spawner, ZombieDead and Pois

        public Move move;                   // each element has a different move type
        protected Rectangle hitBox;         // each element has a hitbox to check collisions 

        public bool isAlive = false;        // indicates if the element is alive or not (if it has a Healthbar to show)
        public bool toDelete = false;       // indicates if the element has to be destroyed

        protected bool isFriend = false;       // indicates if the element is a friend or not
        protected bool isEnemy = false;        // indicates if the element is an enemy or not
        protected bool isNeutral = false;      // indicates if the element is neutral or not
        protected bool isPois = false;

        public GE(int px, int py, string _name, int _life)
        {        
            this.x = px;
            this.y = py;          
            this.name = _name;
            if(_name != "")
            {
                this.hitBox = new Rectangle(this.x, this.y, Global.Sprites.Get(name)._Bitmap.Size.Width, Global.Sprites.Get(name)._Bitmap.Size.Height);
                this.healthBar = new HealthBar(_life);
            }
        }

        public virtual void DoIt()
        {
            this.isCollision();

            // moves the hitbox of the element
            this.hitBox.X = x;
            this.hitBox.Y = y;

            // moves the healthbar of the element
            this.healthBar.x = x;
            this.healthBar.y = y;

            if (this.healthBar.value <= 0)
                this.isAlive = false;

            // checks if the element still has PV, if not, sets the element to delete
            if (this.healthBar.value <= 0)
            {
                this.toDelete = true;
                this.hitBox.Y = 0;
                this.hitBox.X = 0;
                Coord.isOccupied[Coord.YtoRow(this.y), Coord.XtoColumn(this.x)] = false;
            }               
        }

        public virtual void Affichage()
        {
            // the healthbar is shown only if the element is alive
            if (this.isAlive)
                this.healthBar.Affichage();
        }

        public virtual bool isCollision()
        {
            foreach (GE g in Global.LE)
            {
                if (this.hitBox.IntersectsWith(g.hitBox))
                {
                    if (this.isPois && g.isEnemy)
                    {
                        g.isHit = true;
                        g.healthBar.value -= 15;
                        this.toDelete = true;
                        return true;
                    }

                    if (this.isEnemy && g.isFriend)
                    {
                        g.healthBar.value -= 2;
                        return true;
                    }                    
                }
            }
            return false;
        }
    }
}
