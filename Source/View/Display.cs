using System;
using System.Collections.Generic;
using ImageEffects.Controller;
using ImageEffects.Model;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace ImageEffects.View
{
    class Display 
    {
        private const string programname = "ImageEffects";
        private string filepath;
        private List<string> menupoints = new List<string>();
        private Bitmap selectedimage;
        public string Filepath
        {
            get { return filepath; }
            set { filepath = value; }
        }
      
        public Display() 
        {
          initatemenupoints();
        }

        private void initatemenupoints() 
        {
            menupoints.Add("Datei Laden");
            menupoints.Add("Datei Speichern");
            menupoints.Add("S/W Bild");
        }

       public void show()
       {
           header();
           for (int i = 0; i < menupoints.Count; i++)
           {
               ConsoleColorChanger.WriteLine(ConsoleColor.Gray, String.Format("({0}) {1}", i + 1, menupoints[i]));
           }
       }

       private void header() 
       {
           ConsoleColorChanger.Write(ConsoleColor.Gray, programname + "\t\t");
           ConsoleColorChanger.WriteLine((filepath != null ? ConsoleColor.Green : ConsoleColor.Red), (filepath != null ? filepath : "No File Loaded"));
           ConsoleColorChanger.WriteLine(ConsoleColor.Gray, "===============");
       }
       public void ReadMenuInput() 
       {
           int input = 0;
           try 
	       {
              input = int.Parse(Console.ReadLine());
	       }
           catch (FormatException)
	       {
               ConsoleColorChanger.WriteLine(ConsoleColor.Red, "Bitte Geben Sie eine Zahl ein");
	       }
           switch (input - 1) 
           {
               case 0:
                   loadimage();
                   break;
               case 1:
                   break;
               case 2:
                   greyscaleimage();
                   break;

           }
       }

        private void greyscaleimage()
        {
           Greyscale greyscaledimage = new Greyscale(selectedimage);
           Bitmap bitmapsave = greyscaledimage.startgreyscale();
           bitmapsave.Save(new FileStream("a.png", FileMode.Create), ImageFormat.Png);
        }
        private void  loadimage()
        {
            Console.Clear();
            header();
            ConsoleColorChanger.WriteLine(ConsoleColor.Gray, "Bitte geben Sie den Pfad an:");
            string imagepath = Console.ReadLine();

            PersistentImage imagefromhdd = new PersistentImage(imagepath);
            Console.Clear();
            filepath = imagefromhdd.Path;
            selectedimage = imagefromhdd.Bitmap;
            show();
            Console.Read();
            
        }
    }
}
