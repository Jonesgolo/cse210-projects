using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        {
            // 1. Welcome message
            DisplayWelcome();

            // 2. Prompt for and retrieve user name
            string userName = PromptUserName();

            // 3. Prompt for and retrieve favorite number
            int favoriteNumber = PromptUserNumber();

            // 4. Compute square of the number
            int squaredNumber = SquareNumber(favoriteNumber);

            // 5. Display final result
            DisplayResult(userName, squaredNumber);
        }

        // Displays a welcome message
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            return Console.ReadLine();
        }

        // Asks the user for their favorite number and returns it
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string input = Console.ReadLine();
            return int.Parse(input);
        }

        static int SquareNumber(int number)
        {
            return number * number;
        }
        
        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
    }
}

    
