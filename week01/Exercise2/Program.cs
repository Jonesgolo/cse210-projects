using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        // Step 2: Prompt the user for their grade percentage
        Console.WriteLine();
        Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        string letter;
        string sign = "";

       
        if (grade >= 90) {
            letter = "A";
        } else if (grade >= 80) {
            letter = "B";
        } else if (grade >= 70) {
            letter = "C";
        } else if (grade >= 60) {
            letter = "D";
        } else {
            letter = "F";
        }


        int lastDigit = grade % 10;

       
        if (letter != "A" && letter != "F") {
            if (lastDigit >= 7) {
                sign = "+";
            } else if (lastDigit <= 3) {
                sign = "-";
            } else {
                sign = "";
            }
        } else if (letter == "A") {
            // Only allow A or A-
            if (lastDigit <= 3) {
                sign = "-";
            }
        }
    

        Console.WriteLine($"Your grade is: {letter}{sign}");

        
        if (grade >= 70) {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else if (grade < 60) {
            Console.WriteLine("Unfortunately, you did not pass the course.");
        }
    }
}
