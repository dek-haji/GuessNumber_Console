using System;

namespace NumberGueser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo.GetAppInformation(); //get the app information ;
            Greetings.UserGreetings();//ask users name and greet;
        
            while (true)
            {

                //lets CREATE A RANDOM USER
                Random random = new Random();
                int correctNumber = random.Next(1, 10);
                int guess = 0;

                Console.WriteLine("Guess number between 0 and 10");

                while (guess != correctNumber)
                {
                    //get users input
                    string input = Console.ReadLine();
                    //make sure it's anumber
                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage.PrintColor(ConsoleColor.Red, "Please use an actual number");
                        continue;
                    }

                    //cast to int to correct number
                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        PrintColorMessage.PrintColor(ConsoleColor.Yellow, "Wrong Number please try again");
                       
                    }
                    else if (guess == correctNumber)
                    {
                        PrintColorMessage.PrintColor(ConsoleColor.Blue, "Correct answer");
                        //ask to play again
                        Console.WriteLine("Play again? [Y or N]");

                        //Get answers
                        string answer = Console.ReadLine().ToUpper();
                        if (answer == "Y")
                        {
                            continue;
                        }
                        else if (answer == "N")
                        {
                            return;
                        }
                        else
                        {
                            return;
                        }
                    }
                }
            }
        }
    }
}