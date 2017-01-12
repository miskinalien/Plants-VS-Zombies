using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Imaging;
 

namespace PvZ
{
    public partial class _Form1 : Form
    {

        static TimeMeasure Timer;      // gestionnaire de temps
       
       
        public _Form1()
        {
            InitializeComponent();
        }

        Bitmap B;
        System.Windows.Forms.Timer timer1;

        private void Form1_Load(object sender, EventArgs e)
        {
            B = new Bitmap(1024,640, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            pictureBox1.Image = B;
            Global.Ecran = Graphics.FromImage(B);


            // paramètres importants pour eviter le flickering dans la fenêtre
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true); // double buffer

            // mise en place des divers services utilisés par le jeu

            Timer   = new TimeMeasure();
            Global.Sprites = new SpriteManager();
            Global.spawner = new Spawner();
          
            // timer

            // lance la boucle de callback
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new System.EventHandler(GameLoop);
            timer1.Interval = 50;   // demande l'appel toutes les 30ms
            timer1.Enabled = true; // 
            timer1.Start();
            
            // pour la conversion en cartésien
            Global.Height = pictureBox1.Height; // pour tenir compte epaisseur du bandeau

        }

        // fonction appellée par le choronomètre toutes les xxx ms
        
        void GameLoop(Object myObject, EventArgs myEventArgs)
        {
            // boucle sur l'IA
         
            MainLoop.DoIt();
            Draw();
            Global.Round++;
            pictureBox1.Invalidate();
            pictureBox1.Update();       // demande l'affichage
        }



        // Lorsque le système est prêt à afficher, il appelle cette fonction 
        
        private void Draw()
        {
            // affichage des personnages

            Global.Sprites.Get("decor").DrawToScreen(0, 0);

            MainLoop.Affichage();

           
            label1.Text = Timer.GetStringTime();
            label4.Text = "fps : " +  Timer.GetFPS();

            label5.Text = "Tour : " + Global.Round;
            label2.Text = ""+Global.dollar;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Timer.PaintFinished();
        }




        private void _Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // passage en coord cartérsienne
            int y = Global.Height - e.Y;
            MouseClic.Event(e.X, y);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Global.Button = Global.Creature.Zombie;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Global.Button = Global.Creature.Tournesol;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Global.Button = Global.Creature.PistoPois;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            Global.Button = Global.Creature.Canon;
        }

        private void MineButton_CheckedChanged(object sender, EventArgs e)
        {
            Global.Button = Global.Creature.Mine;
        }

        private void ZombieConeButton_CheckedChanged(object sender, EventArgs e)
        {
            Global.Button = Global.Creature.ZombieCone;
        }

        private void ZombieSautButton_CheckedChanged(object sender, EventArgs e)
        {
            Global.Button = Global.Creature.ZombieSot;
        }

        private void NoixButton_CheckedChanged(object sender, EventArgs e)
        {
            Global.Button = Global.Creature.Noix;
        }

        private void PistoPoisButton2_CheckedChanged(object sender, EventArgs e)
        {
            Global.Button = Global.Creature.DoublePistoPois;
        }

        private void PistoGelButton_CheckedChanged(object sender, EventArgs e)
        {
            Global.Button = Global.Creature.PistoGel;
        }

        private void CerisesButton_CheckedChanged(object sender, EventArgs e)
        {
            Global.Button = Global.Creature.Cerises;
        }


    }
}
