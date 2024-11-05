using System;

/* Continue - Оператор (ключевое слово)
 * 
 * Источник: https://www.youtube.com/watch?v=SLmBwMtIebo
 */

namespace _021___Continue___Оператор__ключевое_слово_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Continue - ключевое слово позволяет прервать
             * выполнение цикла без выхода из тела самого цикла.
             * 
             * В данном примере, при выводе в консоль будут пропущенны
             * все чётные числа.
             */

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                    continue;

                Console.WriteLine(i);
            }
        }
    }
}
