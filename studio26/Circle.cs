using System;
namespace studio26
{
    // Create a new class named Circle and methods to use them in studio26
    public class Circle
    {
       public static double CircleArea(double radius)
       {
            return Math.PI * radius * radius;
       }

        public static double Circumference(double radius)
        {
            return 2 * Math.PI * radius;
        }

        public static double Diameter(double radius)
        {
            return 2 * radius;
        }
    }
}
