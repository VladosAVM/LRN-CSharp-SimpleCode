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
            while (true)
            {
                Console.Clear();
                Console.WriteLine("- - - Консольный калькулятор - - -" +
                                  "\nВыбирите вариант калькулятора:" +
                                  "\n1. Switch Case" +
                                  "\n2. If Else");
                string calcVariation = Console.ReadLine();
                switch (calcVariation)
                {
                    case "1":
                        // Калькулятор через Switch Case
                        double numSC1;
                        double numSC2;

                        try
                        {
                            Console.WriteLine("\nВведите первое число:");
                            numSC1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Введите второе число:");
                            numSC2 = double.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("!!! Введены НЕкорректные данные !!!");
                            Console.ReadLine();
                            continue;
                        }
                        

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
                                if (numSC2 != 0)
                                    Console.WriteLine($"{numSC1} / {numSC2} = " + (numSC1 / numSC2));
                                else
                                    Console.WriteLine("На ноль делить нельзя");
                                break;
                            default:
                                Console.WriteLine("\n!!! Выбрана неверная математическая операция !!!");
                                break;
                        }
                        Console.ReadLine();
                        break;
                    case "2":
                        // Калькулятор через If Else
                        double numIE1;
                        double numIE2;

                        try
                        {
                            Console.WriteLine("\nВведите первое число:");
                            numIE1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Введите второе число:");
                            numIE2 = double.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("!!! Введены НЕкорректные данные !!!");
                            Console.ReadLine();
                            continue;
                        }                       

                        Console.WriteLine("Укажите арефметическую операцию: + - * /");
                        string mathOperationIE = Console.ReadLine();

                        if (mathOperationIE == "+")
                            Console.WriteLine($"{numIE1} + {numIE2} = " + (numIE1 + numIE2));
                        else if (mathOperationIE == "-")
                            Console.WriteLine($"{numIE1} - {numIE2} = " + (numIE1 - numIE2));
                        else if (mathOperationIE == "*")
                            Console.WriteLine($"{numIE1} * {numIE2} = " + (numIE1 * numIE2));
                        else if (mathOperationIE == "/")
                        {
                            if (numIE2 != 0)
                                Console.WriteLine($"{numIE1} / {numIE2} = " + (numIE1 / numIE2));
                            else
                                Console.WriteLine("На ноль делить нельзя");
                        }
                        else
                            Console.WriteLine("\n!!! Выбрана неверная математическая операция !!!");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("!!! Такого варианта калькулятора нет !!!");
                        Console.ReadLine();
                        break;
                }
            }





        }
    }
}
