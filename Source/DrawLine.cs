using System;
using System.Drawing;
public sealed class LinePoint
{
    public LinePoint(int x, int y) 
    {
        this.X = x;
        this.Y = y;
    }
    public int X { get; set; }
    public int Y { get; set; }
}

public class DrawLine
{
    public LinePoint From { get; set; }
    public LinePoint To { get; set; }

    public delegate void ImageCallBack(Bitmap setimage);
    
    public void Start(Bitmap fromimage , ImageCallBack setimage)
    {
        /*
         * m = (y1-y2)/(x1-x2)
            c= y1-m*x1
            Für alle x mit x1<x<x2
            y=round(m*x+c)
            färbe (x,y)*/
        double m = 0.0,c=0.0;
        double y=0;
        m = ((double)From.Y - (double)To.Y) / ((double)From.X - (double)To.X);
        c = (double)From.Y - m * (double)From.X;
                
        for (int x = From.X, width = To.X; x < width; x++)
        {
             y = Math.Round(m*(double)x + (double)c);
             fromimage.SetPixel(x, (int)y, Color.FromArgb(255, 0, 0));
        }

        setimage(fromimage);
    }

}

