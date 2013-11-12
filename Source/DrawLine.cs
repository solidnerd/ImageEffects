using System;
using System.Drawing;

  public sealed class Point {

  public Point(int x, int y) {
        X = x;
        Y = y;
    }

    public int X { get; set; }
    public int Y { get; set; }
  }

  public class DrawLine {
    public delegate void ImageCallBack(Bitmap setimage);

    public Point From { get; set; }
    public Point To { get; set; }

    public void Draw(Bitmap whitebox,ImageCallBack setimage) {
   
        Color Black = Color.FromArgb(0, 0, 0);
        double m = ((double)From.Y - (double)To.Y) / ((double)From.X - (double)To.X);
        double c = ((double)From.Y - m * (double)From.X);
         
       
         
         //Wenn der Start Punkt > End Punkt Vertausche die beiden damit normal weiter gezeichnet werden kann
        if(From.X > To.X) 
        {
            int x = To.X;
            To.X = From.X;
            From.X = x;
        }
         
        if(m > -1 && m < 1) {
            for(int x = From.X; x <= To.X; x++)
            {
                int y = (int)(m * x + c);
                whitebox.SetPixel(x, y, Black);
            }
        } else if(From.X == To.X) {
            if(From.Y > To.Y) {
                int y = To.Y;
                To.Y = From.Y;
                From.Y = y;
            }
            for(int y = From.Y; y < To.Y; y++) {
                whitebox.SetPixel(From.X, y, Black);
            }
        } else {
            for(int y = From.Y; y <= To.Y; y++) {
                int x = (int)(((double)y - c) / m);
                whitebox.SetPixel(x, y, Black);
            }
        }
        setimage(whitebox);
    }

    public Bitmap DrawWhiteBox() {
        Bitmap whitebox = new Bitmap(500, 500);
        for (int x = 0 ,width=whitebox.Width; x < width; x++) {
            for (int y = 0,height=whitebox.Height; y < height; y++) {
                whitebox.SetPixel(x, y, Color.FromArgb(255, 255, 255));
            }
        }
        return whitebox;
    }
}