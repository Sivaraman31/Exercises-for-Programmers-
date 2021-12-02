using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesForProgrammers
{
    class Exercise04
    {
        public void ProgramSolution4()
        {
            Console.Write("\n Enter A Noun : ");
            string noun = Console.ReadLine();
            Console.Write("\n");

            Console.Write("\n Enter A Verb : ");
            string verb = Console.ReadLine();
            Console.Write("\n");

            Console.Write("\n Enter An Adjective : ");
            string adj = Console.ReadLine();
            Console.Write("\n");

            Console.Write("\n Anter An Adverb : ");
            string adv = Console.ReadLine();
            Console.Write("\n");

            Console.WriteLine("Do You " + verb + " Your " + adj + " " + noun + " " + adv + " ? That's Hilarious !");

        }
    }
}
