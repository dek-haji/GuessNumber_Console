using System;
using System.Collections.Generic;
using System.Text;

namespace NumberGueser
{
    public class GetAppInfo
    {
       public static void GetAppInformation()
        {
            //set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuther = "dek";

            //change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuther);

            //reset text color
            Console.ResetColor();

        }
    }
}
