using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace PvZ
{
    class _Sprite
    {
        float  _zoom = 1;
        public Bitmap _Bitmap;      
        public _Sprite(Bitmap B, float zoom)
        {
            _Bitmap = B;
            _zoom = zoom;
            // chaque pixel noir sera transparent 
            _Bitmap.MakeTransparent(Color.FromArgb(0, 0, 0));
        }

        public void DrawToScreen(float x, float y)
        {
            int xx = (int) x;
            int yy = (int) (Global.Height - y - _Bitmap.Height);

            int H = (int) ( _Bitmap.Height * _zoom );
            int L = (int) ( _Bitmap.Width  * _zoom );

            Global.Ecran.DrawImage(_Bitmap, xx, yy, L, H);
        }

    }
}
