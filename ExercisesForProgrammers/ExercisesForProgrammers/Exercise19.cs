using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesForProgrammers
{
    class Exercise19
    {
        double dHeight, dWeight, dBMI, BMI;
        public void ProgramSolution19()
        {
            Console.WriteLine("Enter Your Height in Cm: ");
            dHeight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Your Weight in Pounts: ");
            dWeight = Convert.ToDouble(Console.ReadLine());

            dBMI = (dWeight / (dHeight * dHeight)) * 703;
            BMI = Math.Round(dBMI, 1);

            if (BMI >= 18.5 && BMI <= 25)
            {
                Console.WriteLine("Your BMI is "+BMI+ ". \nYou are within the ideal weight range. ");
            }else if (BMI < 18.5)
            {
                Console.WriteLine("Your BMI is " + BMI + ". \nYou are underweight. You should see your doctor. ");
            }
            else if (BMI > 25)
            {
                Console.WriteLine("Your BMI is " + BMI + ". \nYou are overweight. You should see your doctor. ");
            }
        }
    }
}
