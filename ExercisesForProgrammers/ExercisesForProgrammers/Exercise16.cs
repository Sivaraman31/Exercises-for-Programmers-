using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesForProgrammers
{
    class Exercise16
    {
        int nAge;
        public void ProgramSolution16()
        {
            Console.WriteLine("What Is Your Age: ");
            nAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(nAge <= 19 ? "You Are Not Old Enough To Legally Drive." : "You Are Old Enough To Legally Drive..");
        }
    }
}
