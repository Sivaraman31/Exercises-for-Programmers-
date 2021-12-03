using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesForProgrammers
{
    class Exercise09
    {
        int gallon;
        public void ProgramSolution9()
        {
            Console.Write("\n Length: ");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n Width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            int area = length * width;
            //Console.WriteLine(area);
            if (area % 350==0)
            {
                gallon =(area / 350);
            }
            else
            {
                gallon =(area / 350 )+ 1;
                
            }
            
            Console.WriteLine("\n You Will Need To Purchase "+gallon+" Gallons Of\nPanint To Cover "+area+" Square Feet.");
        }
        
    }
}
