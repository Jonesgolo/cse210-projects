using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        string playAgain;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Read inputs
        while (true)
        {
            Console.Write("Enter number: ");
            int input = int.Parse(Console.ReadLine());
            if (input == 0) break;
            numbers.Add(input);
        }


        int sum = 0;
        foreach (int n in numbers) sum += n;
        Console.WriteLine($"The sum is: {sum}");


        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");


        int max = numbers[0];
        foreach (int n in numbers) if (n > max) max = n;
        Console.WriteLine($"The largest number is: {max}");


        List<int> positives = numbers.FindAll(n => n > 0);
        if (positives.Count > 0)
        {
            int smallestPositive = positives[0];
            foreach (int p in positives)
                if (p < smallestPositive) smallestPositive = p;
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }
        else
        {
            Console.WriteLine("No positive numbers were entered.");
        }


        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }

    }
}

