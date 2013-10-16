using System;
using System.Collections.Generic;
using ImageEffects.View;
namespace ImageEffects.Controller
{
    
    class Program 
    {
        static void Main(string[] args)
        {
            Display display = new Display();
            display.show();
            display.ReadMenuInput();
            
            
        }
    }
}
