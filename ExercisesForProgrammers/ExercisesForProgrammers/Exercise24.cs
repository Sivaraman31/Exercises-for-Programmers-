using System;

namespace ExercisesForProgrammers
{
    class Exercise24
    {
        public void ProgramSolution24()
        {
            string strFirst, strSecond;
            
            Console.WriteLine("Enter Two String And I'll Tell Yoy if They Are Anagram: ");
            Console.WriteLine("Enter The First Stirng: ");
            strFirst = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter The First Stirng: ");
            strSecond = Convert.ToString(Console.ReadLine());

            Anagram(strFirst, strSecond);
        }
        public void Anagram(string first, string second)
        {
            char[] strfirst = first.ToUpper().ToCharArray();
            char[] strsecond = second.ToUpper().ToCharArray();

            Array.Sort(strfirst);
            Array.Sort(strsecond);

            string strFirst = new string(strfirst);
            string strSecond = new string(strsecond);

            if (strFirst == strSecond)
            {
                Console.WriteLine("\"" +first + "\" and \"" + second + "\" are Anagram");
            }
            else
            {
                Console.WriteLine("\"" + first + "\" and \"" + second + "\" are Not Anagram");
            }
        }
    }
}
