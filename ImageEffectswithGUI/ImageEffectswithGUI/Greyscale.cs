using System;
using System.Drawing;

namespace ImageEffectswithGUI
{
    class Greyscale
    {
        private Bitmap targetimage;
        public Greyscale(Bitmap image) 
        {
            targetimage = image;
        }


        public Bitmap startgreyscale() 
        {
            for(int x = 0 ,imagewidth =targetimage.Width ; x < imagewidth;x++)
            {
                for (int y = 0, imageheigth = targetimage.Height; y < imageheigth; y++)
                {
                   targetimage.SetPixel(x,y,calculateluminanz(targetimage.GetPixel(x, y)));
                }
            }

            return targetimage;
        }
 

        private Color calculateluminanz(Color color) 
        {
            int grayscalevalue = (int)((0.299 * color.R) + ( 0.587 * color.G)+( 0.114 * color.B));
            return Color.FromArgb(grayscalevalue, grayscalevalue, grayscalevalue);
        }

    }
}

    

