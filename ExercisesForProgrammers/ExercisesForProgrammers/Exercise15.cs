using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesForProgrammers
{
    class Exercise15
    {
        string strName, strPassword;
        public void ProgramSolution15()
        {
            Console.WriteLine("Entar User Name:");
            strName = Console.ReadLine();
            Console.WriteLine("Entar Password:");
            strPassword = Console.ReadLine();

            if (strPassword == "ab@45")
            {
                Console.WriteLine("\n Welcome..!");
            }
            else
            {
                Console.WriteLine("\n I Don't Know You...");
            }
        }
    }
}
