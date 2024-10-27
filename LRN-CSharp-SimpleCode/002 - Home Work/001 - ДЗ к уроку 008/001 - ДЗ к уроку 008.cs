using System;

/* ДЗ к уроку 008
 * 
 * Разбор ДЗ: https://www.youtube.com/watch?v=xFSGcf-B5oU
 */
namespace _001___ДЗ_к_уроку_008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1 Задание
             * 
             * Напишите программу вычисляющую
             * среднее арефметическое 2-х чисел
             */
            
            // Усложнённый вариант с использованием знаний из предидущих уроков
            Console.WriteLine($"+ - + - + - +\nЗадание #1\nВычисление среднего " +
                              $"арефметического 2-х чисел\n\n- - -Сложный " +
                              $"вариант - - -\nВведите первое число: ");
            int.TryParse(Console.ReadLine(), out int num1);
            Console.WriteLine("Введите второе число: ");
            int.TryParse(Console.ReadLine(), out int num2);
            Console.WriteLine($"\nСреднее арефметическое числа " +  num1+ "" +
                              " и числа " + num2 + " = "
                              + (double) (num1 + num2) / 2);

            // Упрощённый вариант
            Console.WriteLine("\n- - - Упрощённый вариант - - -");
            Console.WriteLine("Введите первое число: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            double y = double.Parse(Console.ReadLine());
            double result = (x + y) / 2;
            Console.WriteLine("\nСреднее арефметическое чисел = " + result);
            

            /* 2 задание 
             * 
             * Введите 3-и числа и вывидите на экран значение
             * суммы и произведения этих чисел
             */

            
            Console.WriteLine("\n\n+ - + - + - +\nЗадание #2\nВведите 1-ое число:");
            double.TryParse(Console.ReadLine(), out double sumAndMultOfThreeNum1);
            Console.WriteLine("Введите 2-ое число:");
            double.TryParse(Console.ReadLine(), out double sumAndMultOfThreeNum2);
            Console.WriteLine("Введите 3-е число:");
            double.TryParse(Console.ReadLine(), out double sumAndMultOfThreeNum3);

            double sumOfThree = sumAndMultOfThreeNum1 + sumAndMultOfThreeNum2 + sumAndMultOfThreeNum3;
            Console.WriteLine($"Сумма чисел {sumAndMultOfThreeNum1}, {sumAndMultOfThreeNum2} и {sumAndMultOfThreeNum3} = {sumOfThree}");

            double multOfThree = sumAndMultOfThreeNum1 * sumAndMultOfThreeNum2 * sumAndMultOfThreeNum3;
            Console.WriteLine($"Произведение чисел {sumAndMultOfThreeNum1}, {sumAndMultOfThreeNum2} и {sumAndMultOfThreeNum3} = {multOfThree}");
            

            /* 3 Задание
             * 
             * Напишите простой конвертер валют (без возможности динамического
             * выбора валют пользователем). Валюты заданы хардкодом
             * и не изменяются. Тип валют на выбор разработчика.
             */
            Console.WriteLine("\n\n+ - + - + - +\nЗадание #3\nПростой конвертер валют\nКурс валют от 27.10.2024");

            double USD = 0.010; double CNY = 0.073; double UAH = 0.43; 
            Console.WriteLine("\n- - - Конвертер Российсуих Рублей в Доллары, Юани, Гривны - - -\nВведите число в рублях для конвертации: ");
            double.TryParse(Console.ReadLine(), out double RUB);

            Console.WriteLine($"{RUB} рублей = " + RUB * USD + " USD\n" +
                              $"{RUB} рублей = " + RUB * CNY + " CNY\n" +
                              $"{RUB} рублей = " + RUB * UAH + " UAH");
        }
    }
}
