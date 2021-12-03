using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesForProgrammers
{
    class Exercise12
    {
        float interest, US;
        int principal,year,tot;
        public void ProgramSolution12()
        {
            Console.Write("\n Enter the principal: ");
            principal = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n Enter the rate of interest: ");
            interest = float.Parse(Console.ReadLine());

            Console.Write("\n Enter the number of years: ");
            year = Convert.ToInt32(Console.ReadLine());

            tot = principal + ((int)(principal * interest * year)/100);
            Console.WriteLine(tot);
        }
    }
}
