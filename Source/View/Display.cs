using System;
using System.Collections.Generic;
using ImageEffects.Controller;

namespace ImageEffects.View
{
    class Display 
    {
        private const string programname = "ImageEffects";
        private string filepath;
        private List<string> menupoints = new List<string>();
        
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
           ConsoleColorChanger.Write(ConsoleColor.Gray, programname + "\t\t");
           ConsoleColorChanger.WriteLine((filepath != null ? ConsoleColor.Green : ConsoleColor.Red), (filepath != null ? filepath : "No File Loaded"));
           ConsoleColorChanger.WriteLine(ConsoleColor.Gray, "===============");
           for (int i = 0; i < menupoints.Count; i++)
           {
               ConsoleColorChanger.WriteLine(ConsoleColor.Gray, String.Format("({0}) {1}", i + 1, menupoints[i]));
           }
       }
    }
}
