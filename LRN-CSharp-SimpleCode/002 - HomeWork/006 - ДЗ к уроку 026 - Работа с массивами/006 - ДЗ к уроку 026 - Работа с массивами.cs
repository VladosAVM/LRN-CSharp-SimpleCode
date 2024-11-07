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
            Console.Write("- Заполнение массива с клавиатуры -" +
                          "\nУкажите размер массива: ");

            int arrayLength = int.Parse(Console.ReadLine());
            int[] hwArray = new int[arrayLength];
            for (int i = 0; i < hwArray.Length; i++)
            {
                Console.Write($"Введите данные для элемента массива под индексом {i} :");
                hwArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n- Вывод массива в обратном порядке -");
            for (int i = hwArray.Length - 1; i >= 0; i--)
            {
                Console.Write($"{hwArray[i]} ");
            }

            Console.WriteLine("\n\n- Сумма чётных чисел в массиве -");
            int evenSum = 0;

            for (int i = 0; i < hwArray.Length; i++)
            {
                evenSum += hwArray[i] % 2 == 0 ? hwArray[i] : 0;
            }
            Console.WriteLine($"Сумма чёт. чисел = {evenSum}");

            Console.WriteLine("\n- Поиск наименьшего числа в массиве -");
            int minNum = hwArray[0];
            for (int i = 0; i < hwArray.Length; i++)
            {
                minNum = minNum > hwArray[i] ? hwArray[i] : minNum;
            }
            Console.WriteLine($"Наименьшее число в массиве = {minNum}");
        }
    }
}
