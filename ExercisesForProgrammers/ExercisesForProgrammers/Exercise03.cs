using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesForProgrammers
{
    class Exercise03
    {
        public void ProgramSolution3()
        {
            Console.Write("\n What is The Quote ? ");
            string Quot = Console.ReadLine();
            Console.Write("\n");

            Console.Write("\n Who Said It ? ");
            string Say = Console.ReadLine();
            Console.Write("\n");

            Console.WriteLine(Say + " Says," + "\"" + Quot + "\"" + "\n");
        }
    }
}
