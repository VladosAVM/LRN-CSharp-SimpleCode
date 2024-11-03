using System;

/* While - Цикл
 * 
 * Источник: https://www.youtube.com/watch?v=MFSx0tbcRqc
 */

namespace _016___While___Цикл
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Задача любого цыкла - While, Do While, For, For Each,
             * это репитативное выполнение действий до тех пор, пока
             * соблюдено условие цикла.
             * 
             * Цикл While проверяет условие цикла и если оно = True,
             * исполняет код.
             * 
             * 
             * Синтаксис:
             * while (true)
             *  { 
             *      исполняемый_код
             *  }
             */

            Console.WriteLine("Сколько раз выполнить цикл While?");
            int i = int.Parse(Console.ReadLine());
            while (i > 0)
            {
                Console.WriteLine($"i = {i}");
                i--;
            }
        }
    }
}
