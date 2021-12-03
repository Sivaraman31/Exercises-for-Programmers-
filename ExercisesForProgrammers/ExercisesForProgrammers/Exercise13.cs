using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesForProgrammers
{
    class Exercise13
    {
        int principal, year, CompoYr;
        float rate;
        public void ProgramSolution13()
        {
            Console.Write("\n Enter the principal: ");
            principal = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n What is the rate? ");
            rate = float.Parse(Console.ReadLine());

            Console.Write("\n What is the number of years? ");
            year = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n What is the number of times the interestis compounded per year ? ");
            CompoYr = Convert.ToInt32(Console.ReadLine());

           double tot= principal * Math.Pow((1+(rate / 100) / CompoYr),(CompoYr * year));
            Console.WriteLine("$"+principal+ " invested at "+rate+" For "+year+" Years\nCompounded "+CompoYr+" Time Per Year Is $"+Math.Round(tot,2));
        }
    }
}
