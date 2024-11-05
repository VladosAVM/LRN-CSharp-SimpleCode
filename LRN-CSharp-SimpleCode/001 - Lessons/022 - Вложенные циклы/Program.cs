using System;

/* Вложенные циклы
 * 
 * Источник: https://www.youtube.com/watch?v=KCv5gNkbS9c
 */

namespace _022___Вложенные_циклы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Вложеные циклы в основном используются для перебора
             * многомерных структур данных - массивов, списков,
             * матриц, таблиц, в алгоритмах сортировки и т.д.
             * 
             * Пример вложенного цикла:
             */

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}
