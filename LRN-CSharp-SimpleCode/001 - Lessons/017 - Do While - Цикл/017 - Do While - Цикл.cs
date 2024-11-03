using System;

/* Do While - Цикл
 * 
 * Источник: https://www.youtube.com/watch?v=NZPr9ucAj7I
 */

namespace _017___Do_While___Цикл
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Задача любого цыкла - While, Do While, For, For Each,
             * это репитативное выполнение действий до тех пор, пока
             * соблюдено условие цикла.
             * 
             * Цикл Do While исполняет первую итерацию цикла, после чего
             * проверяет условие цкла.
             * 
             * 
             * Синтаксис:
             * do 
             *  {
             *      исполняемый_код
             *  } while (true);
             */

            Console.WriteLine("Сколько раз выполнить цикл While?");
            int i = int.Parse(Console.ReadLine());

            int whileI = i;
            int doWhileI = i;

            Console.WriteLine("\n\nWhile");
            while (whileI > 0)
            {
                Console.WriteLine($"i = {whileI}");
                whileI--;
            } 

            Console.WriteLine("\nDo While");
            do
            {
                Console.WriteLine($"i = {doWhileI}");
                doWhileI--;
            } while (doWhileI > 0);

        }
    }
}
