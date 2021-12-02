using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesForProgrammers
{
    class Exercise06
    {
        public void ProgramSolution6()
        {
            Console.Write("\n What Is Your Current Age? ");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");

            Console.Write("\n At what age would you like to retire? ");
            int Ret = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");

            int left = Ret - Age;
            int year = 2015;

            int Retyr = year + left;
            Console.WriteLine("You Have " + left + " Years Left Until You Can Retire.\nIt's " + year + ", So You Can Retire In " + Retyr + ".\n");
        }
    }
}
