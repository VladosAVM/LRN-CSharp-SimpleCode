using System;

/* Параметры по умолчанию - Необязательные
 * 
 * Источник: https://www.youtube.com/watch?v=W1RZ61lJDr4
 */

namespace _047___Параметры_по_умолчанию___Необязательные
{
    internal class Program
    {
        static int Sum(int num1, int num2, bool enableLogging = false)
        {
            int result = num1 + num2;

            if (enableLogging)
            {
                Console.WriteLine($"Пременная num1     = {num1}");
                Console.WriteLine($"Пременная num2     = {num2}");
                Console.WriteLine($"Результат сложения = {result}");
            }

            return result;
        }
        static void Main(string[] args)
        {
            /* Если при объявлении параметра метода, задать этому параметру
             * значение по умолчанию тогда этот параметр будет не обяхательным
             * при вызове метода, т.е. передовать значения в него будет не обязательно.
             * 
             * Параметры по умолчанию ДОЛЖНЫ БЫТЬ всегда В КОНЦЕ списка параметров метода.
             */

            Console.WriteLine($"Вызов метода Sum(6, 4): {Sum(6, 4)}");
            Console.WriteLine();

            Console.WriteLine($"Вызов метода Sum(6, 4, false): {Sum(6, 4, false)}");
            Console.WriteLine();

            Console.WriteLine($"Вызов метода Sum(6, 4, true): {Sum(6, 4, true)}");
            Console.WriteLine();
        }
    }
}
