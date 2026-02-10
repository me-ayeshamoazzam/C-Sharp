using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your operator");
            string opt = Console.ReadLine();
            if (opt == "+")
            {
                Console.WriteLine(firstNumber + secondNumber);
            }
            else if (opt == "-")
            {
                Console.WriteLine(firstNumber - secondNumber);
            }
            else if (opt == "*")
            {
                Console.WriteLine(firstNumber * secondNumber);
            }
            else if (opt == "/")
            {
                Console.WriteLine(firstNumber / secondNumber);
            }
            else if (opt == "%")
            {
                Console.WriteLine(firstNumber % secondNumber);
            }
            else {
                Console.WriteLine("Unknown Operator");
            }
        }
    }
}
