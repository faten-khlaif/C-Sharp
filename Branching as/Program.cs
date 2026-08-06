using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Display the mandatory welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // 2. Prompt the user for the package weight
            Console.WriteLine("Please enter the package weight:");
            double weight = Convert.ToDouble(Console.ReadLine());

            // 3. Check if the weight exceeds 50 lbs
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // Ends the program execution
            }

            // 4. Prompt the user for the package width
            Console.WriteLine("Please enter the package width:");
            double width = Convert.ToDouble(Console.ReadLine());

            // 5. Prompt the user for the package height
            Console.WriteLine("Please enter the package height:");
            double height = Convert.ToDouble(Console.ReadLine());

            // 6. Prompt the user for the package length
            Console.WriteLine("Please enter the package length:");
            double length = Convert.ToDouble(Console.ReadLine());

            // 7. Check if the total dimensions (width + height + length) exceed 50
            double totalDimensions = width + height + length;
            if (totalDimensions > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // Ends the program execution
            }

            // 8. Calculate the shipping quote: (dimensions multiplied together, then by weight, divided by 100)
            double quote = (width * height * length * weight) / 100;

            // 9. Display the final calculated quote formatted as a currency/dollar amount ($0.00)
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");
        }
    }
}
