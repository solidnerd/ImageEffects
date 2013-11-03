using System;
using System.Drawing;
public enum FilterOperations 
{
    Weichzeichner,
    Boost,
    Sobel,
    GaußWeichzeichner
}
public  class Filteroperation
{
    private  float ScaleFactor { get; set; }
    private FilterOperations filteroperations;
    public delegate void ImageCallBack(Bitmap setimage);
    private Bitmap _image;
    //int[,] multidimesionales array in c# wird über die Index werte gesteuert Bsp: array[0,3] 0 Zeile 3 Spalte
   
    private Color[,] PointMatrix {get;set;}

    public Filteroperation() { }
    public Filteroperation(Bitmap Image,FilterOperations FilterOperationType) 
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
      int[,] FilterMatrix = {{1,1,1},{1,1,1},{1,1,1}};
    
      PointMatrix = new Color[3, 3];
      ScaleFactor = 1 / 9;
      int R=0 , A=0 , G=0, B =0;
      for (int x = 0; x < _image.Width - 2; x++)
      {
          for (int y = 0; y < _image.Height - 2; y++)
          {
            #region oldcode
              /* PointMatrix[0, 0] = ((x-1 >= 0 && x-1 < imagewidth) && (y-1 >= 0 && y-1 < imageheight)) ? _image.GetPixel(x - 1, y - 1): Color.FromArgb(0,0,0,0);
             PointMatrix[0, 1] = ((x >= 0 && x < imagewidth) && (y - 1 >= 0 && y - 1 < imageheight)) ? _image.GetPixel(x, y - 1) : Color.FromArgb(0, 0, 0, 0);
             PointMatrix[0, 2] = ((x + 1 >= 0 && x + 1 < imagewidth) && (y - 1 >= 0 && y - 1 < imageheight)) ? _image.GetPixel(x + 1, y - 1) : Color.FromArgb(0, 0, 0, 0);
             PointMatrix[1, 0] = ((x - 1 >= 0 && x - 1 < imagewidth) && (y >= 0 && y < imageheight)) ? _image.GetPixel(x - 1, y) : Color.FromArgb(0, 0, 0, 0);
             PointMatrix[1, 1] = ((x >= 0 && x < imagewidth) && (y >= 0 && y < imageheight)) ? _image.GetPixel(x, y) : Color.FromArgb(0, 0, 0, 0);
             PointMatrix[1, 2] = ((x + 1 >= 0 && x + 1 < imagewidth) && (y >= 0 && y < imageheight)) ? _image.GetPixel(x + 1, y) : Color.FromArgb(0, 0, 0, 0);
             PointMatrix[2, 0] = ((x - 1 >= 0 && x - 1 < imagewidth) && (y + 1 >= 0 && y + 1 < imageheight)) ? _image.GetPixel(x - 1, y + 1) : Color.FromArgb(0, 0, 0, 0);
             PointMatrix[2, 1] = ((x >= 0 && x < imagewidth) && (y + 1 >= 0 && y + 1 < imageheight)) ? _image.GetPixel(x, y + 1) : Color.FromArgb(0, 0, 0,0);
             PointMatrix[2, 2] = ((x + 1 >= 0 && x + 1 < imagewidth) && (y + 1 >= 0 && y + 1 < imageheight)) ? _image.GetPixel(x + 1, y + 1) : Color.FromArgb(0, 0, 0, 0);
            */
#endregion
             PointMatrix[0, 0] = _image.GetPixel(x, y);  
             PointMatrix[0, 1] = _image.GetPixel(x, y + 1);  
             PointMatrix[0, 2] = _image.GetPixel(x, y + 2);  
             PointMatrix[1, 0] = _image.GetPixel(x + 1, y);  
             PointMatrix[1, 1] = _image.GetPixel(x + 1, y + 1);  
            PointMatrix[1, 2] = _image.GetPixel(x + 1, y + 2);  
            PointMatrix[2, 0] = _image.GetPixel(x + 2, y);  
            PointMatrix[2, 1] = _image.GetPixel(x + 2, y + 1);  
            PointMatrix[2, 2] = _image.GetPixel(x + 2, y + 2); 
         

              A = PointMatrix[1, 1].A;  
  
            R = (int)((((PointMatrix[0, 0].R * FilterMatrix[0, 0]) +  
                         (PointMatrix[1, 0].R * FilterMatrix[1, 0]) +  
                         (PointMatrix[2, 0].R * FilterMatrix[2, 0]) +  
                         (PointMatrix[0, 1].R * FilterMatrix[0, 1]) +  
                         (PointMatrix[1, 1].R * FilterMatrix[1, 1]) +  
                         (PointMatrix[2, 1].R * FilterMatrix[2, 1]) +  
                         (PointMatrix[0, 2].R * FilterMatrix[0, 2]) +  
                         (PointMatrix[1, 2].R * FilterMatrix[1, 2]) +  
                         (PointMatrix[2, 2].R * FilterMatrix[2, 2]))  
                                / ScaleFactor) +1  );  
  
            if (R < 0)  
            {  
                R = 0;  
            }  
            else if (R > 255)  
            {  
                R = 255;  
            }  
  
            G = (int)((((PointMatrix[0, 0].G * FilterMatrix[0, 0]) +  
                         (PointMatrix[1, 0].G * FilterMatrix[1, 0]) +  
                         (PointMatrix[2, 0].G * FilterMatrix[2, 0]) +  
                         (PointMatrix[0, 1].G * FilterMatrix[0, 1]) +  
                         (PointMatrix[1, 1].G * FilterMatrix[1, 1]) +  
                         (PointMatrix[2, 1].G * FilterMatrix[2, 1]) +  
                         (PointMatrix[0, 2].G * FilterMatrix[0, 2]) +  
                         (PointMatrix[1, 2].G * FilterMatrix[1, 2]) +  
                         (PointMatrix[2, 2].G * FilterMatrix[2, 2]))  
                                / ScaleFactor) +1 );  
  
            if (G < 0)  
            {  
                G = 0;  
            }  
            else if (G > 255)  
            {  
                G = 255;  
            }  
             
            B = (int)((((PointMatrix[0, 0].B * FilterMatrix[0, 0]) +  
                         (PointMatrix[1, 0].B * FilterMatrix[1, 0]) +  
                         (PointMatrix[2, 0].B * FilterMatrix[2, 0]) +  
                         (PointMatrix[0, 1].B * FilterMatrix[0, 1]) +  
                         (PointMatrix[1, 1].B * FilterMatrix[1, 1]) +  
                         (PointMatrix[2, 1].B * FilterMatrix[2, 1]) +  
                         (PointMatrix[0, 2].B * FilterMatrix[0, 2]) +  
                         (PointMatrix[1, 2].B * FilterMatrix[1, 2]) +  
                         (PointMatrix[2, 2].B * FilterMatrix[2, 2]))  
                                / ScaleFactor) +1 );  
  
            if (B < 0)  
            {  
                B = 0;  
            }  
            else if (B > 255)  
            {  
                B = 255;  
            }  
            _image.SetPixel(x+1, y+1, Color.FromArgb(A, R, G, B));

                  }
              }
          }
 } 
