using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesForProgrammers
{
    class Exercise01
    {
        public void ProgramSolution1()
        {
            string name;

            Console.Write("\n What is Your Name ?\t");

            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Hello ," + name + ", nice To Meet You..!\n");
        }
    }
}
