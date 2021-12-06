using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesForProgrammers
{
    class Exercise17
    {
        double dOunce, dWeight,dBAC, dHour, x = 5.14, y = .015;
        public void ProgramSolution17()
        {
            Console.WriteLine("Enter The Gender: ");
            string strGender = Console.ReadLine();

            Console.WriteLine("Alcohol Consumed, In Ounces(OZ): ");
            dOunce = double.Parse(Console.ReadLine());

            Console.WriteLine("Body Weight In Pounds: ");
            dWeight = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Number Of Hours Since The Last Drink: ");
            dHour = double.Parse(Console.ReadLine());

            if (strGender == "Male")
            {
                 dBAC = ((dOunce * x) / (dWeight * 0.73)) - (y * dHour);
                //Console.WriteLine("Your BAC Is: "+dBAC);
            }
            else if(strGender == "Female")
            {
                 dBAC = ((dOunce * x) / (dWeight * 0.66)) - (y * dHour);
                //Console.WriteLine("Your BAC Is: " + dBAC);
            }
            if(dBAC >= 0.08)
            {
                Console.WriteLine("Your BAC Is: " + dBAC + "\nIt is not legal for you to drive.");
            }
            else
            {
                Console.WriteLine("Your BAC Is: " + dBAC + "\nIt is legal for you to drive.");
            }
        }
    }
}
