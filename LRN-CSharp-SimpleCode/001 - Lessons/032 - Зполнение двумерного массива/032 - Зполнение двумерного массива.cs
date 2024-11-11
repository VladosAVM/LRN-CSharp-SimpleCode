using System;

/* Зполнение двумерного массива
 * 
 * Источник: https://www.youtube.com/watch?v=JDDI5DASxl4
 */
namespace _032___Зполнение_двумерного_массива
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* По сути заполнение двумерного массива отличается от
             * одномерного только вложенностью циклов.
             */
            bool autoArrayPhase = true;

            while (autoArrayPhase == true)
            {
                // Зполнение двумерного массива случайными числами

                Console.WriteLine("- - - Автоматически заполненный двумерный массив - - -");

                Random rnd = new Random(); // Создание экземпляра класса генерации случайных чисел
                int[,] randomArray = new int[3, 5]; // Инициализация двумерного массива

                // Заполнение двумерного массива случайными числами
                for (int i = 0; i < randomArray.GetLength(0); i++) // Переход строк при заполнении
                {
                    for (int j = 0; j < randomArray.GetLength(1); j++) // Переход столбцов при заполнении
                    {
                        randomArray[i, j] = rnd.Next(12, 99); // Генерация случайных чисел от 12 до 99
                    }
                }
                // Вывод двумерного массива заполненного случайными числами
                for (int i = 0; i < randomArray.GetLength(0); i++) // Вывод строк
                {
                    for (int j = 0; j < randomArray.GetLength(1); j++) // Вывод столбцов
                    {
                        Console.Write($"{randomArray[i, j]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\n\nНажмите Enter для перехода к ручному заполнению массива...");
                Console.ReadLine();

                autoArrayPhase = false; // Переменная перехода в другую фазу цикла

                // Ручное заполнение двумерного массива
                while (autoArrayPhase ==  false)
                {
                    Console.Clear();

                    Console.WriteLine("- - - Ручное заполнение двумерного массива - - -");

                    Console.Write("Укажите высоту массива: ");
                    int height = int.Parse(Console.ReadLine()); // высота массива
                    Console.Write("Укажите ширину массива: ");
                    int width = int.Parse(Console.ReadLine()); // ширина массива
                    int[,] testArray = new int[height, width];
                    Console.Clear();

                    for (int i = 0; i < testArray.GetLength(0); i++) // Переход строк при заполнении
                    {
                        for (int j = 0; j < testArray.GetLength(1); j++) // Переход столбцов при заполнении
                        {
                            for (int y = 0; y < testArray.GetLength(0); y++) // Вывод строк
                            {
                                for (int x = 0; x < testArray.GetLength(1); x++) // Вывод столбцов
                                {
                                    Console.Write($"{testArray[y, x]}\t");
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine("\n\nЗаполнение массива\n");
                            Console.Write($"\nВведите данные для строки - {i}, столбца - {j}: ");
                            testArray[i, j] = int.Parse(Console.ReadLine());

                            Console.Clear();
                        }
                    }

                    Console.WriteLine("Заполненный двумерный массив");
                    for (int y = 0; y < testArray.GetLength(0); y++)
                    {
                        for (int x = 0; x < testArray.GetLength(1); x++)
                        {
                            Console.Write($"{testArray[y, x]}\t");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\n\nНажмите Enter для перехода к автоматическому заполнению массива...");
                    Console.ReadLine();

                    autoArrayPhase = true;// Переменная перехода в другую фазу цикла
                    Console.Clear();
                }
            }
        }
    }
}
