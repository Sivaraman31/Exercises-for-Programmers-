using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesForProgrammers
{
    class Exercise18
    {
        char cChoice;
        double dFahrenheit, dCelsius;
        public void ProgramSolution18()
        {
            Console.WriteLine("Press C to convert from Fahrenheit to Celsius.\n" +
                "Press F to convert from Celsius to Fahrenheit.");
            Console.Write("Your Choice: ");
            cChoice = Convert.ToChar (Console.ReadLine());

            if (cChoice == 'C')
            {
                Console.Write("\n Please enter the temperature in Fahrenheit: ");
                dFahrenheit = double.Parse (Console.ReadLine());

                dCelsius = (dFahrenheit - 32) * 5 / 9;
                Console.WriteLine("\n The temperature in Celsius is: "+dCelsius);
            }
            else if(cChoice == 'F')
            {
                Console.Write("\n Please enter the temperature in Celsius: ");
                dCelsius = double.Parse(Console.ReadLine());

                dFahrenheit = (dCelsius * 9 / 5) + 32;
                Console.WriteLine("\n The temperature in Celsius is: " + dFahrenheit);
            }
            else
            {
                Console.WriteLine("\n Invalid Choice.. :(");
            }
        }
    }
}
