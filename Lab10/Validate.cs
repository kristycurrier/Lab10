using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Validate
    {
        public Validate()
        {
        }

        public static double Radius()
        {
            bool realDouble = false;
            double radius = -1;
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
            return radius;
        }

        public static bool ContinueTheProgram()
        {
            
            bool continueProgram = false;
            bool validInput = false;
            while (validInput == false)
            {
                Console.Write("Would you like to continue the program? (y/n) ");
                string yesNoAnswer = Console.ReadLine();

                if (yesNoAnswer.Equals("y", StringComparison.OrdinalIgnoreCase))
                {
                    continueProgram = true;
                    validInput = true;
                }
                else if (yesNoAnswer.Equals("n", StringComparison.OrdinalIgnoreCase))
                {
                    continueProgram = false;
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Sorry, that isn't a valid answer.  Type y for yes or n for no.");
                    validInput = false;
                }
            }
            return continueProgram;
        }
    }
}
