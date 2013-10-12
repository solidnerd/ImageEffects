using System;
using System.Collections.Generic;
using ImageEffects.Controller;

namespace ImageEffects.View
{
    class Display 
    {
        private ConsoleColorEvent consolecolorevent;
        private const string programname = "ImageEffects";
        private string filepath;
        private List<string> menupoints = new List<string>();
        public string Filepath
        {
            get { return filepath; }
            set { filepath = value; }
        }
      
        public Display(ConsoleColorChanger ccc) 
        {
            consolecolorevent = ccc;
            filepath = null;
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
           consolecolorevent.Write(ConsoleColor.Gray, programname + "\t\t");
           consolecolorevent.WriteLine((filepath != null ? ConsoleColor.Green:ConsoleColor.Red),(filepath != null ? filepath:"No File Loaded"));
           consolecolorevent.WriteLine(ConsoleColor.Gray,"===============");
           for (int i = 0; i < menupoints.Count; i++)
           {
               consolecolorevent.WriteLine(ConsoleColor.Gray,String.Format("({0}) {1}",i+1,menupoints[i]));
           }
       }
    }
}
