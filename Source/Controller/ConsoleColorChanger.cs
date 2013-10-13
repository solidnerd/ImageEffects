using System;

namespace ImageEffects.Controller
{
    class ConsoleColorChanger 
    {
        public static void Write(ConsoleColor consolecolor, string text)
        {
            Console.ForegroundColor = consolecolor;
            Console.Write(text);
        }


        public static void WriteLine(ConsoleColor consolecolor, string text)
        {
            Console.ForegroundColor = consolecolor;
            Console.WriteLine(text);
        }
    }


   
}
