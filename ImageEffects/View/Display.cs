using System;
using System.Collections.Generic;
using ImageEffects.Controller;

namespace ImageEffects.View
{
    class Display 
    {
        private ConsoleColorEvent consolecolorevent;
        private const string programmname = "ImageEffects";
        private bool fileloaed = false;
        public Display(ConsoleColorChanger ccc) 
        {
            consolecolorevent = ccc;
        }

       public void show()
       {
           consolecolorevent.Write(ConsoleColor.Gray, programmname + "\t\t");
           if (fileloaed)
           {
               consolecolorevent.Write(ConsoleColor.Green, "HI");
           }
           else 
           {
               consolecolorevent.WriteLine(ConsoleColor.Red, "No File Loaded");
           }
       }
    }
}
