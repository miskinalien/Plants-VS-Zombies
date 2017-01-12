using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Resources;
using System.Collections;
using System.Globalization;

namespace PvZ
{
    
    class SpriteManager
    {

        Dictionary<string, _Sprite> SpritesList = new Dictionary<string, _Sprite>();

        public SpriteManager()
        {
            Load();
        }

        private void Load()
        {
            // zombies !!!!!!!!!!!

            SpritesList.Add("cone_1", new _Sprite(Properties.Resources.cone_1, 1.0f));
            SpritesList.Add("cone_2", new _Sprite(Properties.Resources.cone_2, 1.0f));
            SpritesList.Add("cone_3", new _Sprite(Properties.Resources.cone_3, 1.0f));

            SpritesList.Add("sot_1", new _Sprite(Properties.Resources.sot_1, 1.0f));
            SpritesList.Add("sot_2", new _Sprite(Properties.Resources.sot_2, 1.0f));
            SpritesList.Add("sot_3", new _Sprite(Properties.Resources.sot_3, 1.0f));
            

            SpritesList.Add("zombie_1", new _Sprite(Properties.Resources.zombie_1, 1.0f));
            SpritesList.Add("zombie_2", new _Sprite(Properties.Resources.zombie_2, 1.0f));
            SpritesList.Add("zombie_3", new _Sprite(Properties.Resources.zombie_3, 1.0f));

            SpritesList.Add("zombie_1_touche", new _Sprite(Properties.Resources.zombie_1_touche, 1.0f));
            SpritesList.Add("zombie_2_touche", new _Sprite(Properties.Resources.zombie_2_touche, 1.0f));
            SpritesList.Add("zombie_3_touche", new _Sprite(Properties.Resources.zombie_3_touche, 1.0f));
            SpritesList.Add("zombie_dead", new _Sprite(Properties.Resources.zombie_dead, 1.0f));



            // plante defense

            SpritesList.Add("mine_1", new _Sprite(Properties.Resources.mine_1, 1.0f));
            SpritesList.Add("mine_2", new _Sprite(Properties.Resources.mine_2, 1.0f));
            SpritesList.Add("noix_1", new _Sprite(Properties.Resources.noix_1, 1.0f));
            SpritesList.Add("noix_2", new _Sprite(Properties.Resources.noix_2, 1.0f));
            SpritesList.Add("noix_3", new _Sprite(Properties.Resources.noix_3, 1.0f));
            SpritesList.Add("plante_gel", new _Sprite(Properties.Resources.plante_gel, 1.0f));
            SpritesList.Add("plante_pois", new _Sprite(Properties.Resources.plante_pois, 1.0f));
            SpritesList.Add("plante_soleil", new _Sprite(Properties.Resources.plante_soleil, 1.0f));
            SpritesList.Add("canon", new _Sprite(Properties.Resources.canon, 1.0f));
            SpritesList.Add("tondeuse", new _Sprite(Properties.Resources.tondeuse, 1.0f));
            SpritesList.Add("cerises", new _Sprite(Properties.Resources.cerises, 1.0f));
            SpritesList.Add("plante_pois_double", new _Sprite(Properties.Resources.plante_pois_double, 1.0f));           

            // animation

            SpritesList.Add("boulet_canon", new _Sprite(Properties.Resources.boulet_canon, 1.0f));
            SpritesList.Add("gel", new _Sprite(Properties.Resources.gel, 1.0f));
            SpritesList.Add("soleil", new _Sprite(Properties.Resources.soleil, 1.0f));
            SpritesList.Add("tir_gel", new _Sprite(Properties.Resources.tir_gel, 1.0f));
            SpritesList.Add("tir_pois", new _Sprite(Properties.Resources.tir_pois, 1.0f));

            // décoration

            SpritesList.Add("decor", new _Sprite(Properties.Resources.decor, 1.0f));
            SpritesList.Add("dollar", new _Sprite(Properties.Resources.dollar, 1.0f));

         
            
        }


        public _Sprite Get(String name)
        {
            return SpritesList[name];
        }
    }
}
