using System;

namespace studio26
{
    class Program
    {        
        static void Main(string[] args)
        {
            // Calculate the area of circle
            Console.WriteLine("Enter a radius in miles: ");
            string r = Console.ReadLine();

            // Print an error message and exit if user enters non-numeric characters, or empty string
            if (r == "" || !String.IsNumeric(r))
            {
                Console.WriteLine("Error: radius cannot be non-numeric!");
                return;
            }

            // Re-prompt user if user enters negative numbers
            while (double.Parse(r) <= 0)
            {
                Console.WriteLine("Enter a positive number");
                r = Console.ReadLine();

            }
            Console.WriteLine($"The area of a circle of radius {r}: {Circle.CircleArea(double.Parse(r))}");

            // Calculate circumference
            double circumference = Circle.Circumference(double.Parse(r));
            Console.WriteLine($"The circumference of the circle: {circumference}");

            // Calculate diameter
            double diameter = Circle.Diameter(double.Parse(r));
            Console.WriteLine($"The diameter of the circle: {diameter}");

            // Calculate the gas amount user needs to complete one round around cirle. Ask user for gas mileage of the vehicle
            Console.WriteLine("\nGas mileage of your vehivle: ");
            string gasMileage = Console.ReadLine();

            // Print an error message and exit if user enters non-numeric characters, or empty string
            if (gasMileage == "" || !String.IsNumeric(gasMileage))
            {
                Console.WriteLine("Error: gas mileage cannot be non-numeric!");
                return;
            }

            // Re-prompt user if user enters negative numbers
            while (double.Parse(gasMileage) <= 0)
            {
                Console.WriteLine("Enter a positive number");
                gasMileage = Console.ReadLine();

            }
            double gasNeeded = circumference / double.Parse(gasMileage);
            Console.WriteLine($"\nYou need {gasNeeded} gallon of gas in order to comlete of this circle.");
        }
    }
}
