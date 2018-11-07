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
            int numberOfCircles = 0;
            bool continueTheProgram = true;
            while (continueTheProgram == true)
            {
                double radius = Validate.Radius();
                var newCircle = new Circle(radius);

                string formmatedCircumfernece = newCircle.CalculateFormattedCircumference(newCircle.Radius);
                Console.WriteLine($"Circumference: {formmatedCircumfernece}");
                string formmatedArea = newCircle.CalculateFormattedArea(newCircle.Radius);
                Console.WriteLine($"Area: {formmatedArea}");
                numberOfCircles++;
                continueTheProgram = Validate.ContinueTheProgram();
            }

            Console.WriteLine($"Goodbye! You created {numberOfCircles} Circle object(s).");
            Console.ReadKey();
        }
    }
}
