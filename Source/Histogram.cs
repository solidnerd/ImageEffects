using System;
using System.Collections.Generic;
using System.Drawing;

namespace ImageEffectswithGUI
{
    class HistogramStretch
    {
        public static int hmin { get; set; }
        public static int hmax { get; set; }
        public delegate void SetImageCallBack(Bitmap image);

        public static void StartHistogramStretch(Bitmap targetimage, SetImageCallBack setimage)
        {
            for (int x = 0, imagewidth = targetimage.Width; x < imagewidth; x++)
            {
                for (int y = 0, imageheight = targetimage.Height; y < imageheight; y++)
                {
                    Color color = targetimage.GetPixel(x, y);
                    int greyscalevalue = color.ToArgb();
                    if (greyscalevalue > hmax)
                        hmax = greyscalevalue;
                    if (greyscalevalue < hmin)
                        hmin = greyscalevalue;
                }
         }
           
           
          for (int x = 0, imagewidth = targetimage.Width; x < imagewidth; x++)
          {
          for (int y = 0, imageheight = targetimage.Height; y < imageheight; y++)
          {
            targetimage.SetPixel(x, y, calcHistogram(targetimage.GetPixel(x, y)));
          }
        }

            setimage(targetimage);
        }

        private static Color calcHistogram(Color color) 
        {
            int colorvalue = ((color.ToArgb()-hmin)*255)/(hmax-hmin);
            return Color.FromArgb(colorvalue, colorvalue, colorvalue) ;
        }
    }
}
