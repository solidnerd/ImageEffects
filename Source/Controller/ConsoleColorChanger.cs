using System;


namespace ImageEffects.Controller
{
    class ConsoleColorChanger : ConsoleColorEvent
    {
        public void Write(ConsoleColor consolecolor, string text)
        {
            Console.ForegroundColor = consolecolor;
            Console.Write(text);
        }


        public void WriteLine(ConsoleColor consolecolor, string text)
        {
            Console.ForegroundColor = consolecolor;
            Console.WriteLine(text);
        }
    }

    interface ConsoleColorEvent
    {
         void Write(ConsoleColor consolecolor, string text);
         void WriteLine(ConsoleColor consolecolor, string text);
    }

   
}
