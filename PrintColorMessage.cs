using System;
using System.Collections.Generic;
using System.Text;

namespace NumberGueser
{
    public class PrintColorMessage
    {
        public static void PrintColor(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
