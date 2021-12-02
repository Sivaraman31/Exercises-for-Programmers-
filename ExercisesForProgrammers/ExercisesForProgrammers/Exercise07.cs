using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesForProgrammers
{
    class Exercise07
    {
        public void ProgramSolution7()
        {
            float F = 0.09290304f;
            Console.Write("\n What is the length of the room in feet? ");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");

            Console.Write("\n What is the width of the room in feet? ");
            int w = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            Console.WriteLine("You entered dimensions of " + l + " Feet By " + w + " Feet. \nThe Area IS");

            int sqrft = l * w;
            Console.WriteLine(sqrft + " Square Feet.");

            float sqrm = sqrft * F;
            Console.WriteLine(sqrm + " square meters.");
        }
    }
}
