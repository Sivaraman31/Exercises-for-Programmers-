using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesForProgrammers
{
    class Exercise11
    {
        float dollar,rate,US;
        public void ProgramSolution11()
        {
            Console.Write("\n How many euros are you exchanging? ");
            int euro = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n What is the exchange rate? ");
            rate = float.Parse(Console.ReadLine());

            dollar = (float)euro * rate;
            US = dollar / 100;
            Console.WriteLine(euro+ " euros at an exchange rate of "+rate+" Is " + Math.Round(US,2)+" U.S. Dollars.");
        }
    }
}
