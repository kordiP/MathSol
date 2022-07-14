using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSol
{
    internal class WorkCode
    {
        public static string[] allTypes = { "Algebra", "Geometry", "Calculus", "Statistics" };
        public static ConsoleKey klik;
        public static int Checks(string input, int stage)   // 1 --> Algebra & Arithmetic; 2 --> Geometry; 3 --> Calculus; 4 --> Probability & Statistics **** THERE ARE PROBABLY MORE *****
        {
            int returnThat = 0;
            if (stage == 1)
            {
                for (int i = 0; i < allTypes.Length; i++)
                    if (allTypes[i] == input)
                        returnThat = i + 1;
            }
            return returnThat;
        }
        public static void Helper(int stageNumber) // 1 -> Type Check
        {
            if (stageNumber == 1)
            {
                Console.WriteLine("All types of math problems:");
                for (int i = 0; i < allTypes.Length; i++) Console.WriteLine(allTypes[i]);
            }
        }

    }
}
