using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)

        {   // Set app vars
            string appName = "Name Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Henry Ehalaas";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();

            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);

            // Init correct number
            int correctNumber = 7;

            // Int guess var
            int guess = 0;

            // Ask user for number
            Console.WriteLine("Guess a number between 1 and 10");

            // While guess is not correct
            while (guess != correctNumber) {
                // Get users input
                string input = Console.ReadLine();

                // Cast to int and put in guess
                guess = Int32.Parse(input);

                // Match guess to correct number
                if (guess != correctNumber) {
                    // Change text color
                    Console.ForegroundColor = ConsoleColor.Red;

                    // Write out app info
                    Console.WriteLine("Wrong number, please try again");

                    // Reset text color
                    Console.ResetColor();



                }
            }
            // Charge text color
            Console.ForegroundColor = ConsoleColor.Red;

            // Write out app info
            Console.WriteLine("Wrong number, please try again");

            // Reset text color
            Console.ResetColor();

            // Ask to play again
            Console.WriteLine("Pley Again? {Y or N}");

            if (Answer == "Y") {
                continue;


            }
            else
            {
                return;
            }
        }
    }
    // Get and display app info
    static void GetAppInfo() {
        // Set app vars
        string appName = "NumberGuesser";
        string appVersion = "1.0.0";
        string appAuthor = "Henry Ehalaas";

        // Charge text color
        Console.ForegroundColor = ConsoleColor.Green;

        // Write out app into
        Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

        // Reset text color
        Console.ResetColor();




            


