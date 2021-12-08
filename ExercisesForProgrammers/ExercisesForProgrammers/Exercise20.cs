using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesForProgrammers
{
    class Exercise20
    {
        public void ProgramSolution20()
        {
            double dAmount, dTax, dTotal;
            string strState;

            Console.WriteLine("What is The Order Amount? ");
            dAmount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What State do You Live in? ");
            strState = Console.ReadLine();

            if(strState=="WI"|| strState == "Wi" || strState == "wI" || strState == "wi")
            {
                dTax = (dAmount * 5.0) / 100;
                Console.WriteLine("The Tax is $" + dTax);
                dTotal = dAmount + dTax;
                Console.WriteLine("The total is $"+dTotal);
            }
            else if (strState == "EW" || strState == "Ew" || strState == "eW" || strState == "ew")
            {
                dTax = (dAmount * 5.0) / 100;
                Console.WriteLine("The Tax is $" + dTax);
                double dAddTax = 0.005;
                dTotal = dAmount + dTax + dAddTax;
                Console.WriteLine("The total is $" + dTotal);
            }
            else if (strState == "DN" || strState == "Dn" || strState == "dN" || strState == "dn")
            {
                dTax = (dAmount * 5.0) / 100;
                Console.WriteLine("The Tax is $" + dTax);
                double dAddTax = 0.004;
                dTotal = dAmount + dTax + dAddTax;
                Console.WriteLine("The total is $" + dTotal);
            }
            else if (strState == "IL" || strState == "Il" || strState == "iL" || strState == "il")
            {
                dTax = (dAmount * 8.0) / 100;
                Console.WriteLine("The Tax is $" + dTax);
                dTotal = dAmount + dTax;
                Console.WriteLine("The total is $" + dTotal);
            }
        }
    }
}
