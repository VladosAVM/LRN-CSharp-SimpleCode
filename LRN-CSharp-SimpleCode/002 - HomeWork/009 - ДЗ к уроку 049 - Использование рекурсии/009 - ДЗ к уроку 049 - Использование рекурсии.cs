using System;

/* ДЗ к уроку 049 - Использование рекурсии
 * 
 * Разбор: https://www.youtube.com/watch?v=ovQXWqRt3Z8 - Рекурсивный вывод массива
 * Разбор: https://www.youtube.com/watch?v=5dEg9Ed9iqA - Сумма элементов массива
 * Разбор: https://www.youtube.com/watch?v=c4h0FKXkWf8 - Сумма цифр числа
 */

namespace _009___ДЗ_к_уроку_049___Использование_рекурсии
{
    internal class Program
    {
        // Задача 1
        static void PrintArray(int[] arr, int i = 0)
        {
            if (i < arr.Length)
            {
                Console.Write($"{arr[i]} ");
                PrintArray(arr, i + 1);
            }
        }

        // Задача 2
        static int SumOfArrayElements(int[] arr, int i = 0)
        {
            if (i >= arr.Length)
                return 0;

            return arr[i] += SumOfArrayElements(arr, i + 1);
        }

        // Задача 3
        static int SumOfInteger1(int num)
        {
            if (num < 10)
                return num;

            int digit = num % 10; // Получить последнюю цифру числа
            int newNum = num / 10; // Уменшить число на десяток
            
            return SumOfInteger1(newNum) + digit;
        }
        static int SumOfInteger2(int num)
        {
            if (num < 10)
                return num;

            return num % 10 + SumOfInteger2(num / 10);
        }
        static void Main(string[] args)
        {
            /* 1. Вывод массива с помощью рекурсии
             * 2. Сумма элементов массива с помощью рекурсии
             * 3. Сумма цифр числа с помощью рекурсии
             */

            // Задача 1
            Console.WriteLine("Задача 1");
            int[] arr1 = { 1, 2, 3 };
            PrintArray(arr1);

            // Задача 2
            Console.WriteLine("\n\nЗадача 2");
            int[] arr2 = { 1, 2, 3, 4, 5 };
            int result1 = SumOfArrayElements(arr2);
            Console.WriteLine(result1);

            // Задача 3
            Console.WriteLine("\nЗадача 3");
            int i = 151;
            int result2 = SumOfInteger1(i);
            Console.WriteLine(result2);
            

        }
    }
}
