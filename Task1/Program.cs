using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> numbers = new Dictionary<string, int>()
            {
                { "one", 1},
                { "two", 2},
                { "three", 3},
                { "four", 4},
                { "five", 5},
                { "six", 6},
                { "seven", 7},
                { "eight", 8},
                { "nine", 9}
            };
            int n1;
            int n2;
            try
            {
                Console.Write("enter first num: ");
                n1 = numbers[Console.ReadLine()];
                Console.Write("enter second num: ");
                n2 = numbers[Console.ReadLine()];

            }
            catch (System.Collections.Generic.KeyNotFoundException)
            {
                Console.Write("incorrect input");
                Console.ReadKey();
                return;
            }

            Console.Write("enter operation: ");
            string op = Console.ReadLine();
            switch (op)
            {
                case "+":
                    Console.Write($"{n1} + {n2} = {n1 + n2}");
                    break;
                case "-":
                    Console.Write($"{n1} - {n2} = {n1 - n2}");
                    break;
                case "*":
                    Console.Write($"{n1} * {n2} = {n1 * n2}");
                    break;
                case "/":
                    Console.Write($"{n1} / {n2} = {(double)n1 / (double)n2}");
                    break;
                default:
                    Console.Write("incorrect input");
                    break;
            }
            Console.ReadKey();
            return;
        }
    }
}
