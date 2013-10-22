using System;
using System.Collections.Generic;
using System.Drawing;

namespace ImageEffectswithGUI
{
    class BlackAndWhite
    {
        public static int Threshold { get; set; }
        public delegate void SetImageCallBack(Bitmap setimage);
        
        public static void StartBlackAndWhite(Bitmap targetimage, SetImageCallBack setimagecallback ) 
        {
            for (int x = 0, imagewidth = targetimage.Width; x < imagewidth; x++)
            {
                for (int y = 0, imageheight = targetimage.Height; y < imageheight; y++)
                {
                    targetimage.SetPixel(x, y, calculateBlackAndWhite(targetimage.GetPixel(x,y)));
                }
            }
            setimagecallback(targetimage);
        }

        private static Color calculateBlackAndWhite(Color color) 
        {
            //f'(x,y) = 1 , falls f(x,y) > w ansonsten 0 
            int grayscalevalue = (int)((0.299 * color.R) + (0.587 * color.G) + (0.114 * color.B));
            return grayscalevalue > BlackAndWhite.Threshold ? Color.White : Color.Black;
        }
        
    }
}
