using System;

/* ДЗ к уроку 013 - Проверка числа на чётность
 * 
 * Разбор ДЗ: https://www.youtube.com/watch?v=bTSpiLPTVvQ
 */

namespace _002___ДЗ_к_уроку_013___Проверка_числа_на_чётность
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- - - Проверка числа на чётность - - -" +
                              "\nВведите число для проверкаи:");
            int evenNum = int.Parse(Console.ReadLine());
            if (evenNum % 2 == 0)
            {
                Console.WriteLine($"Число {evenNum} чётное");
            }
            else
            {
                Console.WriteLine($"Число {evenNum} НЕчётное");
            }

        }
    }
}
