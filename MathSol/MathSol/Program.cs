using System;

namespace MathSol
{
    internal class Program
    {
        static void Main()
        {
            int stage = 1;
            Console.CursorVisible = false;
            Console.WriteLine("Hello! This is MathSol by kordiP. I can solve many types of math problems and now I will try to solve yours. So, what is the type of your problem?");
            Console.WriteLine("(Type H for help, C to clear text)");
            Console.CursorVisible = true;
            string input = Console.ReadLine();
            bool succ = false;
            while (succ == false)
            {
                if (WorkCode.Checks(input, stage) != 0)
                {
                    Console.WriteLine(WorkCode.Checks(input, stage));
                    succ = true;
                }
                else 
                {
                    switch (input)
                    {
                        case "H":
                            WorkCode.Helper(1);
                            break;
                        case "C":
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("Hmm... I couldn't find that.");
                            WorkCode.Helper(stage);
                            Console.WriteLine("Try with one of these!");
                            break;
                    }
                    input = Console.ReadLine();
                }   
            }
            stage++;

        }
    }
}
