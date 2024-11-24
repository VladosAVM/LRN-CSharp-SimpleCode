using System;

/* Именованные параметры (аргументы)
 * 
 * Источник: https://www.youtube.com/watch?v=4nPxbyd3CyY
 */

namespace _048___Именованные_параметры
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
            /* Именованные параметры 
             * По умолчанию при передаче аргументов в мтеод необходимо соблюдать
             * порядок аргументов который прописан в методе.
             * Однако мы можем нарушить порядок указания аргументов используя
             * именованные параметры() аргументы.
             * 
             * Пример:
             *      Sum(num2: 3, num1:5);
             */
            Sum(5, 3); // Порядок по умолчанию
            Sum(num2: 3, num1: 5); // Использование именованных параметров
                                   // для изменения порядка передачи
                                   // аргументов в метод




        }
    }
}
