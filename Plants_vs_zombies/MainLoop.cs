using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace PvZ
{
    class MainLoop
    {

        public static void DoIt()
        {
            foreach (GE E in Global.LE)
                E.DoIt();

            foreach (GE x in Global.A)
                Global.LE.Add(x);

            Global.A.Clear(); 

            Global.spawner.DoIt();
            
            Global.LE.RemoveAll(element => element.toDelete == true);
            
        }


        public static void Affichage()
        {
            foreach (GE E in Global.LE)
                E.Affichage();                     
        }
    }
}
