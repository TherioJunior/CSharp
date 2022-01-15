using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandline_Calculator_Csharp
{
    class Program
    {
        private static string Option = "";
        private static string Continue = "";
        private static string Continue2 = "";

        private static double NumberOne = 0;
        private static double NumberTwo = 0;
        private static double Result = 0;

        private static bool ContinueBool1 = false;
        private static bool ContinueBool2 = false;

        static void Main(string[] args)
        {
            Console.WriteLine("Simple C# Commandline Calculator by TherioJunior");
            Console.WriteLine();

            Console.WriteLine("Available mathematical options: +, -, * and /");
            Console.Write("What do you want to do? ");

            Option = Console.ReadLine();
            Console.WriteLine();

            do
            {
                switch (Option)
                {
                    case "+":
                        Console.WriteLine("Please write 2 numbers you want to add.");
                        Console.WriteLine();
                        Console.Write("Number one: ");
                        NumberOne = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Number two: ");
                        NumberTwo = Convert.ToDouble(Console.ReadLine());

                        Result = NumberOne + NumberTwo;
                        Console.WriteLine();
                        Console.WriteLine("The result of your addition is " + Result);
                        Console.WriteLine();
                        break;
                    case "-":
                        Console.WriteLine("Please write 2 numbers you want to substract.");
                        Console.WriteLine();
                        Console.Write("Number one: ");
                        NumberOne = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Number two: ");
                        NumberTwo = Convert.ToDouble(Console.ReadLine());

                        Result = NumberOne - NumberTwo;
                        Console.WriteLine();
                        Console.WriteLine("The result of your substraction is " + Result);
                        Console.WriteLine();
                        break;
                    case "*":
                        Console.WriteLine("Please write 2 numbers you want to multiply.");
                        Console.WriteLine();
                        Console.Write("Number one: ");
                        NumberOne = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Number two: ");
                        NumberTwo = Convert.ToDouble(Console.ReadLine());

                        Result = NumberOne * NumberTwo;
                        Console.WriteLine();
                        Console.WriteLine("The result of your multiplication is " + Result);
                        Console.WriteLine();
                        break;
                    case "/":
                        Console.WriteLine("Please write 2 numbers you want to divide.");
                        Console.WriteLine();
                        Console.Write("Number one: ");
                        NumberOne = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Number two: ");
                        NumberTwo = Convert.ToDouble(Console.ReadLine());

                        Result = NumberOne / NumberTwo;
                        Console.WriteLine();
                        Console.WriteLine("The result of your dividation is " + Result);
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Invalid math option.");
                        break;
                }

                Console.WriteLine("Do you want to continue? (Y/N)");
                Continue = Console.ReadLine();
                Console.WriteLine();
                
                if (Continue == "y" || Continue == "Y")
                {
                    ContinueBool1 = true;

                    Console.WriteLine("Do you want to use a different math option? (Y/N)");
                    Continue2 = Console.ReadLine();
                    Console.WriteLine();

                    if (Continue2 == "y" || Continue2 == "Y")
                    {
                        Console.WriteLine("Available mathematical options: +, -, * and /");
                        Console.Write("What do you want to do? ");

                        Option = Console.ReadLine();
                        Console.WriteLine();

                        ContinueBool2 = true;
                    }
                    else
                    {
                        ContinueBool2 = true;
                    }
                }
                else
                {
                    ContinueBool1 = false;
                }
            } while (ContinueBool1 && ContinueBool2);

            return;
        }
    }
}