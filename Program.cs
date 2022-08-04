using System;

namespace studio_area_of_a_circle
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double r;
            double pi = 3.1415926535897931;
            double A;
            double C;
            string input;
            string input2;
            double mpg;
            double gallons;

            Console.WriteLine("Radius of circle:");
            input = Console.ReadLine();
            r = double.Parse(input);

            A = (r * r * pi);
            Console.WriteLine("Area of circle is: " + A);

            C = 2 * r * pi;
            Console.WriteLine("Circumference of circle is: " + C);

            Console.WriteLine("Provide car's miles per gallon:");
            input2 = Console.ReadLine();
            mpg = double.Parse(input2);

            gallons = C / mpg;

            Console.WriteLine("Gallons used to travel circumference of circle: " + gallons);
        }
    }
}