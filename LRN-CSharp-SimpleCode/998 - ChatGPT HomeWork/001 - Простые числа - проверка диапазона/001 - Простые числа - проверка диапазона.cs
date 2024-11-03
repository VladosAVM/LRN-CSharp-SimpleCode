using System;

/* Определение простых чисел в заданнном диапазоне
 * 
 * Задание от ChatGPT
 */

namespace _001___Простые_числа___проверка_диапазона
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Запрос данных от пользователя
            Console.WriteLine("Введите начало диапазона");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите конец диапазона");
            int max = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine($"Список простых чисел в диапазоне от {min} до {max}");

            // Цикл перебора диапазона чисел 
            for (int i = min; i <= max; i++)
            {
                // Проверка числа на простоту
                int counter = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                    }
                }
                // Вывод числа в консоль - если оно простое
                if (counter == 2)
                {
                    Console.WriteLine($"{i}");
                }
            }
        }
    }
}
