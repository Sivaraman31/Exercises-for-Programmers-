using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesForProgrammers
{
    class Exercise02
    {
        public void ProgramSolution2()
        {
            Console.Write("\n What is The Input String ? ");
            string str = Console.ReadLine();
            Console.Write("\n");

            int len = str.Length;
            Console.WriteLine(str + " has " + len + " Characters..!\n");
        }
    }
}
