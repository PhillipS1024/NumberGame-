using System;

namespace NumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();
            GreetUser();

            while (true)
            {
                Random random = new Random();

                int correctNumber = random.Next(1, 10);
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please enter a actual number please");

                        continue;
                    }

                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, Please try again");
                    }
                }

                PrintColorMessage(ConsoleColor.Yellow, "CORRECT!! You got it");

                Console.WriteLine("Will you like to play again[Y or N]");
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
        static void GetAppInfo()
        {
            string appName = "NumberGame";
            string appVersion = "1.0.0";
            string author = "Phillip Stewart";

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, author);

            Console.ResetColor();

        }
        static void GreetUser()
        {
            Console.WriteLine("What is your name");
            string inputName = Console.ReadLine();
            Console.WriteLine("Hello {0} lets play a game...", inputName);


        }
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();



        }
    }
}
