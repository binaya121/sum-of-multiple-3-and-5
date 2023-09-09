using System;

namespace MultiplesSumCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize a variable to store the sum
            int sum = 0;

            // Loop through numbers from 1 to 100 (inclusive)
            for (int i = 1; i <= 100; i++)
            {
                // Check if the current number is a multiple of 3 or 5
                if (i % 3 == 0 || i % 5 == 0)
                {
                    // Add the current number to the sum
                    sum += i;
                }
            }

            // Display the sum of multiples of 3 and 5
            Console.WriteLine("The sum of multiples of 3 and 5 from 1 to 100 is: " + sum);

            // Wait for user input to exit
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
