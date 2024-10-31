using System;

/* ДЗ к уроку 015 - Консольный калькулятор
 * 
 * Разбор: https://www.youtube.com/watch?v=4aL0YVKt880
 */

namespace _003___ДЗ_к_уроку_015___Консольный_калькулятор
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Калькулятор через Switch Case
            Console.WriteLine("Введите первое число:");
            double numSC1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double numSC2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Укажите арефметическую операцию: + - * /");
            string mathOperationSC = Console.ReadLine();

            switch (mathOperationSC)
            {
                case "+":
                    Console.WriteLine($"{numSC1} + {numSC2} = " + (numSC1 + numSC2));
                    break;
                case "-":
                    Console.WriteLine($"{numSC1} - {numSC2} = " + (numSC1 - numSC2));
                    break;
                case "*":
                    Console.WriteLine($"{numSC1} * {numSC2} = " + (numSC1 * numSC2));
                    break;
                case "/":
                    if (numSC1 != 0 && numSC2 != 0)
                    {
                        Console.WriteLine($"{numSC1} / {numSC2} = " + (numSC1 / numSC2));
                    }
                    else
                    {
                        Console.WriteLine("На ноль делить нельзя");
                    }
                    break;
                default:
                    Console.WriteLine("\n!!! Выбрана неверная математическая операция !!!");
                    break;
            }

            // Калькулятор через If Else
            Console.WriteLine("Введите первое число:");
            double numIE1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double numIE2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Укажите арефметическую операцию: + - * /");
            string mathOperationIE = Console.ReadLine();

            if (mathOperationIE == "+")
            {
                Console.WriteLine($"{numIE1} + {numIE2} = " + (numIE1 + numIE2));
            }
            else if (mathOperationIE == "-")
            {
                Console.WriteLine($"{numIE1} - {numIE2} = " + (numIE1 - numIE2));
            }
            else if (mathOperationIE == "*")
            {
                Console.WriteLine($"{numIE1} * {numIE2} = " + (numIE1 * numIE2));
            }
            else if (mathOperationIE == "/")
            {
                if (numIE1 != 0 && numIE2 != 0)
                {
                    Console.WriteLine($"{numIE1} / {numIE2} = " + (numIE1 / numIE2));
                }
                else
                {
                    Console.WriteLine("На ноль делить нельзя");
                }
            }
            else
            {
                Console.WriteLine("\n!!! Выбрана неверная математическая операция !!!");
            }
            Console.ReadLine();

        }
    }
}
