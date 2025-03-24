using System;

/* ДЗ к уроку 026 - Работа с массивами
 * 
 * Разбор: https://www.youtube.com/watch?v=7rcwQQT2txY - заполнение массива с консоли
 * Разбор: https://www.youtube.com/watch?v=3af3DiaUL8g - вывод массива в обратном порядке
 * Разбор: https://www.youtube.com/watch?v=0nr8wRRMeTw - сумма 4ётных чисел в массиве
 * Разбор: https://www.youtube.com/watch?v=YN7P5y12FfE - поиск наименьшего элемента в массиве
 */

namespace _006___ДЗ_к_уроку_026___Работа_с_массивами
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Заполнением массива пользователем
            Console.Write("- Заполнение массива с клавиатуры -" +
                          "\nУкажите размер массива: ");

            int arrayLength = int.Parse(Console.ReadLine());
            int[] hwArray = new int[arrayLength];
            for (int i = 0; i < hwArray.Length; i++)
            {
                Console.Write($"Введите данные для элемента массива под индексом {i} :");
                hwArray[i] = int.Parse(Console.ReadLine());
            }

            // Вывод массива в обратном порядке
            Console.WriteLine("\n- Вывод массива в обратном порядке -");
            for (int i = hwArray.Length - 1; i >= 0; i--)
            {
                Console.Write($"{hwArray[i]} ");
            }

            // Сумма чётных чисел в массиве
            Console.WriteLine("\n\n- Сумма чётных чисел в массиве -");
            int evenSum = 0;

            for (int i = 0; i < hwArray.Length; i++)
            {
                evenSum += hwArray[i] % 2 == 0 ? hwArray[i] : 0;
            }
            Console.WriteLine($"Сумма чёт. чисел = {evenSum}");

            // Поиск наименьшего числа в массиве
            Console.WriteLine("\n- Поиск наименьшего числа в массиве -");
            if (hwArray != null) // Проверка существования массива
            {
                int minNum = hwArray[0]; // Сохранение первого значения из массива

                for (int i = 1; i < hwArray.Length; i++) // Стартовое значение i для перебора массива = 1
                    minNum = minNum > hwArray[i] ? hwArray[i] : minNum; // Поиск наименьшего значения

                Console.WriteLine($"Наименьшее число в массиве = {minNum}");
            }

            // ********************************************************************
            // Более сложный вариант заполнения массива пользователем
            // с использованием тернарного оператора ?:
            // ********************************************************************
            Console.WriteLine("\n--------------------------\n");
            Console.WriteLine("Заполнение массива");

            int[] arr = (int.TryParse(Console.ReadLine(), out int arrSize) && arrSize > 0 && arrSize < int.MaxValue) ? new int[arrSize] : null;

            if (arr != null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write($"Введите значение массива под индексом {i}: ");
                    arr[i] = (int.TryParse(Console.ReadLine(), out int arrValue)) ? arrValue : 0;
                }

                // Вывод массива циклом foreach
                foreach (var item in arr)
                {
                    Console.Write($"Значения в массиве: ");
                    Console.WriteLine(item);
                }
            }

            // ********************************************************************
            // Несколько других вариантом вычисления суммы чётных чисел в массиве
            // ********************************************************************
            int[] arr2 = { 2, 1, 6, 91, 4, 6, 88, 8, 15, 13, 31, 33, 44, 34, 82 };
            int evenSum2 = 0;

            // 1 способ
            for (int i = 0; i < arr2.Length; i++)
                if (arr2[i] % 2 == 0)
                    evenSum2 += arr2[i];

            // 2 способ
            foreach (int num in arr2)
                if (num % 2 == 0)
                    evenSum2 += num;

            // 3 способ
            for (int i = 0; i < arr2.Length; i++)
                evenSum2 = (arr2[i] % 2 == 0) ? evenSum2 + arr2[i] : evenSum2 + 0;
        }
    }
}
