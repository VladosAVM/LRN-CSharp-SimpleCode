using System;

/* ДЗ к уроку 016 - Сумма и кол-во чёт. и НЕчёт чисел
 * 
 * Разбор: https://www.youtube.com/watch?v=bJ4DtsojdrI
 */

namespace _004___ДЗ_к_уроку_016___Сумма_и_количество_чётный_и_не_чётных_чисел
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Подсчёт количеств и суммы чётных и НЕчётных чисел диапазона");
            Console.WriteLine("Укажите начало диапазона");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Укажите конец диапазона");
            int end = int.Parse(Console.ReadLine());

            uint even = 0; uint odd = 0;
            int sumOfEven = 0; int sumOfOdd = 0;

            Console.WriteLine($"В диапазоне от {start} до {end}\n");

            while (start <= end)
            {
                if (start % 2 == 0)
                {
                    even++;
                    sumOfEven += start;
                }
                else
                {
                    odd++;
                    sumOfOdd += start;
                }
                start++;
            }
            Console.WriteLine($"\nКоливество чётных чисел   = {even}" +
                              $"\nСумма чётных чисел        = {sumOfEven}\n" +
                              $"\nКоливество НЕчётных чисел = {odd}" +
                              $"\nСумма НЕчётных чисел      = {sumOfOdd}\n\n\n\n");

        }
    }
}
