using System;
using System.Drawing;
public enum FilterOperations
{
    Weichzeichner,
    Boost,
    Sobel,
    GaußWeichzeichner
}

public sealed class ConvolutionMatrix
{
    public int MatrixSize = 3;

    public double[,] Matrix;
    public double Factor = 1;
    public double Offset = 1;

    public ConvolutionMatrix(int size)
    {
        MatrixSize = 3;
        Matrix = new double[size, size];
    }

    public void SetAll(double value)
    {
        for (int i = 0; i < MatrixSize; i++)
        {
            for (int j = 0; j < MatrixSize; j++)
            {
                Matrix[i, j] = value;
            }
        }
    }

}
public class Filteroperation
{
    private float ScaleFactor { get; set; }
    private FilterOperations filteroperations;
    public delegate void ImageCallBack(Bitmap setimage);
    private Bitmap _image;
    //int[,] multidimesionales array in c# wird über die Index werte gesteuert Bsp: array[0,3] 0 Zeile 3 Spalte

    private Color[,] PointMatrix { get; set; }

    public Filteroperation() { }
    public Filteroperation(Bitmap Image, FilterOperations FilterOperationType)
    {
        this._image = Image;
        this.filteroperations = FilterOperationType;
    }

    public void Start(ImageCallBack setImage)
    {

        switch (filteroperations)
        {
            case FilterOperations.Weichzeichner:
                Weichzeichner();
                break;
            case FilterOperations.Boost:
                break;
            case FilterOperations.Sobel:
                break;
            case FilterOperations.GaußWeichzeichner:
                break;
        }

        setImage(_image);
    }

    private void Weichzeichner()
    {
        ConvolutionMatrix m = new ConvolutionMatrix(3);
        m.SetAll(1);
        m.Factor = 9;
        m.Matrix[1, 1] = 1;
        PointMatrix = new Color[3, 3];
        Color[,] pixelColor = new Color[3, 3];
        int A, R, G, B;

        for (int y = 0; y < _image.Height - 2; y++)
        {
            for (int x = 0; x < _image.Width - 2; x++)
            {
                pixelColor[0, 0] = _image.GetPixel(x, y);
                pixelColor[0, 1] = _image.GetPixel(x, y + 1);
                pixelColor[0, 2] = _image.GetPixel(x, y + 2);
                pixelColor[1, 0] = _image.GetPixel(x + 1, y);
                pixelColor[1, 1] = _image.GetPixel(x + 1, y + 1);
                pixelColor[1, 2] = _image.GetPixel(x + 1, y + 2);
                pixelColor[2, 0] = _image.GetPixel(x + 2, y);
                pixelColor[2, 1] = _image.GetPixel(x + 2, y + 1);
                pixelColor[2, 2] = _image.GetPixel(x + 2, y + 2);

                A = pixelColor[1, 1].A;

                R = (int)((((pixelColor[0, 0].R * m.Matrix[0, 0]) +
                             (pixelColor[1, 0].R * m.Matrix[1, 0]) +
                             (pixelColor[2, 0].R * m.Matrix[2, 0]) +
                             (pixelColor[0, 1].R * m.Matrix[0, 1]) +
                             (pixelColor[1, 1].R * m.Matrix[1, 1]) +
                             (pixelColor[2, 1].R * m.Matrix[2, 1]) +
                             (pixelColor[0, 2].R * m.Matrix[0, 2]) +
                             (pixelColor[1, 2].R * m.Matrix[1, 2]) +
                             (pixelColor[2, 2].R * m.Matrix[2, 2]))
                                    / m.Factor) + m.Offset);

                if (R < 0)
                {
                    R = 0;
                }
                else if (R > 255)
                {
                    R = 255;
                }

                G = (int)((((pixelColor[0, 0].G * m.Matrix[0, 0]) +
                             (pixelColor[1, 0].G * m.Matrix[1, 0]) +
                             (pixelColor[2, 0].G * m.Matrix[2, 0]) +
                             (pixelColor[0, 1].G * m.Matrix[0, 1]) +
                             (pixelColor[1, 1].G * m.Matrix[1, 1]) +
                             (pixelColor[2, 1].G * m.Matrix[2, 1]) +
                             (pixelColor[0, 2].G * m.Matrix[0, 2]) +
                             (pixelColor[1, 2].G * m.Matrix[1, 2]) +
                             (pixelColor[2, 2].G * m.Matrix[2, 2]))
                                    / m.Factor) + m.Offset);

                if (G < 0)
                {
                    G = 0;
                }
                else if (G > 255)
                {
                    G = 255;
                }

                B = (int)((((pixelColor[0, 0].B * m.Matrix[0, 0]) +
                             (pixelColor[1, 0].B * m.Matrix[1, 0]) +
                             (pixelColor[2, 0].B * m.Matrix[2, 0]) +
                             (pixelColor[0, 1].B * m.Matrix[0, 1]) +
                             (pixelColor[1, 1].B * m.Matrix[1, 1]) +
                             (pixelColor[2, 1].B * m.Matrix[2, 1]) +
                             (pixelColor[0, 2].B * m.Matrix[0, 2]) +
                             (pixelColor[1, 2].B * m.Matrix[1, 2]) +
                             (pixelColor[2, 2].B * m.Matrix[2, 2]))
                                    / m.Factor) + m.Offset);

                if (B < 0)
                {
                    B = 0;
                }
                else if (B > 255)
                {
                    B = 255;
                }
                _image.SetPixel(x + 1, y + 1, Color.FromArgb(A, R, G, B));
            }
        }
    }
}
