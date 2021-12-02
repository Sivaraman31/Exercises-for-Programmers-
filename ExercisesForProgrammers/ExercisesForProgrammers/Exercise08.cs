using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesForProgrammers
{
    class Exercise08
    {
        public void ProgramSolution8()
        {
            Console.Write("\n How many people? ");
            int people = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");

            Console.Write("\n How Many Pizzas Do You Have? ");
            int pizza = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");

            // int left = people % pizza;
            Console.WriteLine(people + " people with " + pizza + " Pizzas\nEach person gets" + pizza + "pieces of pizza.");
            Console.WriteLine("There are " + (people % pizza)+ " leftover pieces.");
        }
    }
}
