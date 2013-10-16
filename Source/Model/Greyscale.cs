using System;
using System.Drawing;
using System.Collections.Generic;

namespace ImageEffects.Model
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
            for(int x = 0; x < targetimage.Width;x++)
            {
                for(int y = 0 ; y < targetimage.Height;y++)
                {
                   targetimage.SetPixel(x,y,calculateluminanz(targetimage.GetPixel(x, y)));
                }
            }

            return targetimage;
        }
 

        private Color calculateluminanz(Color color) 
        {
            return Color.FromArgb((int)(0.299 * color.R + 0.587 * color.G + 0.114 * color.B));
        }

    }
}
