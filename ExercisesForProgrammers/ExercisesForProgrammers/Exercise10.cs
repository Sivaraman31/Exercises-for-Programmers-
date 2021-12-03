using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesForProgrammers
{
    class Exercise10
    {
        float F = 5.5f;
        public void ProgramSolution10()
        {
            Console.Write("\n Enter The Price Of Item 1: ");
            int price1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n Enter The Quantity Of Iten 1: ");
            int Quantity1 = Convert.ToInt32(Console.ReadLine());

            int item1Tot = price1 * Quantity1;

            Console.Write("\n Enter The Price Of Item 2: ");
            int price2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n Enter The Quantity Of Iten 1: ");
            int Quantity2 = Convert.ToInt32(Console.ReadLine());

            int item2Tot = price2 * Quantity2;

            Console.Write("\n Enter The Price Of Item 3: ");
            int price3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n Enter The Quantity Of Iten 3: ");
            int Quantity3 = Convert.ToInt32(Console.ReadLine());

            int item3Tot = price3 * Quantity3;
            int Subtotal = item1Tot + item2Tot + item3Tot;
            Console.WriteLine("Subtotal: "+ Subtotal);

            float Tax = (Subtotal * F) / 100;
            Console.WriteLine("Tax: "+Tax);
            Console.WriteLine("Total: "+(Subtotal+Tax));

        }
    }
}
