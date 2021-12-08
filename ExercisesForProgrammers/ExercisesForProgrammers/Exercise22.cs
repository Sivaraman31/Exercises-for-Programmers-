using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesForProgrammers
{
    class Exercise22
    {
        public void ProgramSolution22()
        {
            int[] nNum = new int[4];
            int i, nLarg;

            Console.Write("Enter the First Number ");
            nNum[0] = int.Parse(Console.ReadLine());

            Console.Write("Enter the Second Number ");
            nNum[1] = int.Parse(Console.ReadLine());

            Console.Write("Enter the Third Number ");
            nNum[2] = int.Parse(Console.ReadLine());

            Console.Write("Enter the Fourth Number ");
            nNum[3] = int.Parse(Console.ReadLine());

            nLarg = nNum[0];
            for (i = 1; i < nNum.Length; i++)
            {
                if (nNum[i] > nLarg)
                {
                    nLarg = nNum[i];
                }
            }
            Console.WriteLine("The Largest Number is: "+nLarg);
        }
    }
}
