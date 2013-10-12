using System;
using System.Collections.Generic;
using ImageEffects.Controller;

namespace ImageEffects.View
{
    class Display 
    {
        private ConsoleColorEvent consolecolorevent;
        private const string programmname = "ImageEffects";
        private string filepath;
        public Display(ConsoleColorChanger ccc) 
        {
            consolecolorevent = ccc;
            filepath = null;
        }

       public void show()
       {
           consolecolorevent.Write(ConsoleColor.Gray, programmname + "\t\t");
           consolecolorevent.WriteLine(((filepath != null) ? ConsoleColor.Green:ConsoleColor.Red),((filepath != null) ? filepath:"No File Loaded"));
           consolecolorevent.WriteLine(ConsoleColor.Gray,"===============");
       }
    }
}
