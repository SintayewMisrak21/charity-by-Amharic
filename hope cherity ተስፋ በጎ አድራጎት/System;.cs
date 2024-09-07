using System;

class Program
{
    static void Main()
    {
        // Prompt user to enter the value of N
        Console.Write("Enter the value of N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        // Initialize sum to 0
        int sum = 0;

        // Loop through numbers from 1 to N and accumulate the sum
        for (int i = 1; i <= N; i++)
        {
            sum += i;
        }

        // Display the sum
        Console.WriteLine("Sum of numbers from 1 to {0} is: {1}", N, sum);

        Console.ReadLine(); // Keep the console window open until a key is pressed
    }
}

s