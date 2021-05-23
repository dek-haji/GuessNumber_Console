using System;
using System.Collections.Generic;
using System.Text;

namespace NumberGueser
{
    public class Greetings
    {
       public static void UserGreetings()
        {
            //Ask users name
            Console.WriteLine("what is your name?");

            //user input string
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game....", inputName);
        }
      

    }
}
