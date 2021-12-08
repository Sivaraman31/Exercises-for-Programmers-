using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesForProgrammers
{
    class Exercise21
    {
        public void ProgramSolution21()
        {
            int nNumber;
            Console.Write("Please enter the number of the month: ");
            nNumber = Convert.ToInt32(Console.ReadLine());
            switch (nNumber)
            {
                case 1:
                    Console.WriteLine("The name of the month is January.");
                    break;
                case 2:
                    Console.WriteLine("The name of the month is February.");
                    break;
                case 3:
                    Console.WriteLine("The name of the month is March.");
                    break;
                case 4:
                    Console.WriteLine("The name of the month is April.");
                    break;
                case 5:
                    Console.WriteLine("The name of the month is May.");
                    break;
                case 6:
                    Console.WriteLine("The name of the month is June.");
                    break;
                case 7:
                    Console.WriteLine("The name of the month is July.");
                    break;
                case 8:
                    Console.WriteLine("The name of the month is August.");
                    break;
                case 9:
                    Console.WriteLine("The name of the month is September.");
                    break;
                case 10:
                    Console.WriteLine("The name of the month is October.");
                    break;
                case 11:
                    Console.WriteLine("The name of the month is November.");
                    break;
                case 12:
                    Console.WriteLine("The name of the month is December.");
                    break;
                default:
                    Console.WriteLine("Invalid Number");
                    break;
            }
        }
    }
}
