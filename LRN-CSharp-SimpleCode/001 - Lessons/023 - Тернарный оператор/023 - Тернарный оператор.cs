using System;

/* Тернарный оператор
 * 
 * Источниик: https://www.youtube.com/watch?v=iQhVp4TGf64
 */

namespace _023___Тернарный_оператор
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ?: - тернарный оператор 
             * 
             * Тернарный оператор используется, когда требуется
             * простая проверка условий, чтобы избежать многословного
             * блока If Else.
             * 
             * Синтаксис:
             * переменная = первый_операнд (условие) ? второй_операнд (if_true) : третий_операнд (if_else)
             */

            bool accessAllowed;

            string storedPassword = "qwert";
            string enteredPassword = Console.ReadLine();

            accessAllowed = enteredPassword == storedPassword ? true : false;
            Console.WriteLine(accessAllowed);

            int inputData = int.Parse(Console.ReadLine());
            int outputData = inputData >= 0 ? inputData : 0;
            Console.WriteLine(outputData); 
        }
    }
}
