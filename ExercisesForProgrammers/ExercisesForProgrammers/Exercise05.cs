using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesForProgrammers
{
    class Exercise05
    {
        public void ProgramSolution5()
        {
            Console.Write("\n Enter The First Number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");

            Console.Write("\n Enter The Second Number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");

            int add = num1 + num2;
            Console.WriteLine(num1 + " + " + num2 + " = " + add);

            int sub = num1 - num2;
            Console.WriteLine(num1 + " - " + num2 + " = " + sub);

            int mul = num1 * num2;
            Console.WriteLine(num1 + " * " + num2 + " = " + mul);

            int div = num1 / num2;
            Console.WriteLine(num1 + " / " + num2 + " = " + div);
        }
    }
}
