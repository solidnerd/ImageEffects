using System;
using System.Drawing;

namespace ImageEffectswithGUI
{
    class Greyscale
    {
        public delegate void SetImageCallBack(Bitmap setimage);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="targetimage"></param>
        /// <param name="setimagecallback">Funtction to set</param>
        public static void startgreyscale(Bitmap targetimage,SetImageCallBack setimagecallback) 
        {
            for(int x = 0 ,imagewidth =targetimage.Width ; x < imagewidth;x++)
            {
                for (int y = 0, imageheight = targetimage.Height; y < imageheight; y++)
                {
                   targetimage.SetPixel(x,y,calculateluminanz(targetimage.GetPixel(x, y)));
                }
            }
            setimagecallback(targetimage);
        }

        private static Color calculateluminanz(Color color) 
        {
            int grayscalevalue = (int)((0.299 * color.R) + ( 0.587 * color.G)+( 0.114 * color.B));
            return Color.FromArgb(grayscalevalue, grayscalevalue, grayscalevalue);
        }

    }
}

    

