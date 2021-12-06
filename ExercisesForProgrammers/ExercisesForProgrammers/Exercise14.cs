using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesForProgrammers
{
    class Exercise14
    {
        double dAmount, dTax, dTotal;
        string strState;
        public void ProgramSolution14()
        {
            Console.Write("\n What Is The Order Amount? ");
            dAmount = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n What is the State? ");
            strState = Console.ReadLine();

            if (strState == "WI" || strState == "wi" || strState == "Wi" || strState == "wI")
            {
                Console.WriteLine("\n The Subtotal Is: " + dAmount);
                dTax = (dAmount * 5.5) / 100;
                Console.WriteLine("The Tax Is: " + dTax);

                dTotal = dAmount + dTax;
                Console.WriteLine("The Total Is: " + dTotal);
                Environment.Exit(exitCode:0);
            }
                Console.WriteLine("\n The Total Is: " + dAmount);
        }
    }
}
