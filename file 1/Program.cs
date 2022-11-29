using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
         static void Main(string[] args)
        {
            double operand1, operand2;
            string sign;

            Console.WriteLine("Ввести число1");
            operand1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ввести число2");
            operand2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Обрати опреацію:'+' '-' '*' '/'");
            sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                    Console.WriteLine(operand1 + operand2);
                    break;
                case "-":
                    Console.WriteLine(operand1 - operand2);
                    break;
                case "*":
                    Console.WriteLine(operand1 * operand2);
                    break;
                case "/":
                    if (operand2 == 0)
                    {
                        Console.WriteLine("Операція неможлива!");
                    }
                    else
                    {
                        Console.WriteLine(operand1 / operand2);
                    }
                    break;
                default:
                    Console.WriteLine("Невідома дія");
                    break;
            }
            Console.ReadLine();

        }
    }
}
