using System;

namespace ExercisesForProgrammers
{
    class Exercise23
    {
        public void ProgramSolution23()
        {
			char cAns;
			Console.WriteLine("Is the car silent when you turn the key?");
			cAns = Convert.ToChar(Console.ReadLine());

			if (cAns == 'y' || cAns == 'Y')
			{
				Console.WriteLine("Are the battery terminals corroded ? ");
				cAns = Convert.ToChar(Console.ReadLine());
				if (cAns == 'y' || cAns == 'Y')
				{
					Console.WriteLine("Clean terminals and try starting again.");
					Console.WriteLine("No More Questions here...");
				}
				else if (cAns == 'n' || cAns == 'N')
				{
					Console.WriteLine("The Battery cables may be damaged .\nReplace cables and try again.\n");
					Console.WriteLine("No More Questions here...\n");
				}
                else
                {
					Console.WriteLine("No More Option TO Select. Please Select: \"Y/N\" here...");
				}
			}
			else if(cAns == 'n' || cAns== 'N')
			{
				Console.WriteLine("Does the car make a clicking noise ?");
				cAns = Convert.ToChar(Console.ReadLine());
				if (cAns == 'y' || cAns == 'Y')
				{
					Console.WriteLine("Replace the battery.");
				}
				else if(cAns == 'n' || cAns == 'N')
				{
					Console.WriteLine(" Does the car crank up but fail to start ?");
					cAns = Convert.ToChar(Console.ReadLine());
					if (cAns == 'y' || cAns == 'Y')
					{
						Console.WriteLine("Check spark plug connections.");
					}
					else if (cAns == 'n' || cAns == 'N')
					{
						Console.WriteLine("Does the engine start and then die?");
						cAns = Convert.ToChar(Console.ReadLine());
						if (cAns == 'y' || cAns == 'Y')
						{
							Console.WriteLine("Does your car have fuel injection?");
							cAns = Convert.ToChar(Console.ReadLine());
							if (cAns == 'y' || cAns == 'Y')
							{
								Console.WriteLine("Get it in for service.");
							}
							else if (cAns == 'n' || cAns == 'N')
							{
								Console.WriteLine("Check to ensure the choke is opening and closing.");
							}
						}
					}
				}
				else
				{
					Console.WriteLine("No More Question TO Select.");
				}
			}
			else
			{
				Console.WriteLine("No More Questions TO Select here...");
			}
		}
    }
}
