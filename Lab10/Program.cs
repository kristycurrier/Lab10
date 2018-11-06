using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Circle Tester");
            bool realDouble = false;
            double radius=-1;
            while (realDouble == false || radius <= 0)
            {
                Console.Write("Enter radius: ");
                string input = Console.ReadLine();
                realDouble = double.TryParse(input, out radius);

                if (radius <= 0)
                {
                    Console.WriteLine("Sorry, that is not a valid radius.  It must a number greater then zero.");
                }
            }
            var newCircle = new Circle(radius);

            Console.WriteLine(newCircle.Radius);
            string formmatedCircumfernece =  newCircle.CalculateFormattedCircumference(newCircle.Radius);
            Console.WriteLine($"Circumference: {formmatedCircumfernece}");
            string formmatedArea = newCircle.CalculateFormattedArea(newCircle.Radius);
            Console.WriteLine($"Area: {formmatedArea}");
            Console.ReadKey();

        }
    }
}
