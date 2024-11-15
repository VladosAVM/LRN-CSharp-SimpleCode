using System;

/* ДЗ к уроку 035 - Методы
 * 
 * Разбор: https://www.youtube.com/watch?v=5qKuA53LKhQ - Метод вывода строки
 * Разбор: https://www.youtube.com/watch?v=ZJ4CZDBLOc0 - Метод поиска и вывода индекса элемента массива
 *         
 */

namespace _007___ДЗ_к_уроку_035___Методы
{
    internal class Program
    {

        static void PrintString(string str, int counter) // 1. Метод вывода строки заданной пользователем
        {
            for (int i = 0; i < counter; i++)
            {
                Console.Write(str);
            }
        }

        static int IndexSearch(int[] array , int userNum) // 2. Метод поиска и вывода индекса элемента массива
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == userNum)
                {
                    Console.WriteLine($"Индекс элемента {userNum} = {i}");
                    return i;
                }
            }
            Console.WriteLine($"Элемента со значением {userNum} нет в массиве");
            return -1;
        }
        static void Main(string[] args)
        {
            // 1. Метод вывода строки заданной пользователем
            Console.Write("Укажите какой символ или строку вывести: ");
            string userString = Console.ReadLine();
            Console.Write("Укажите сколько раз повторить вывод: ");
            int numOfRepeats = int.Parse( Console.ReadLine());
            PrintString(userString, numOfRepeats);
            
            Console.WriteLine();

            // 2. Метод поиска и вывода индекса элемента массива
            Random random = new Random();
            int[] testArray = {78,34,55,61,66,51,12,31,11,72};
            Console.WriteLine("Элементы массива:");
            for (int i = 0; i < testArray.Length; i++)
            {
                Console.Write($"{testArray[i]} ");
            }

            Console.WriteLine("Поиск индекса элемента массива...\n" +
                              "Укажите элемент:");
            int userNum = int.Parse(Console.ReadLine());
            int index = IndexSearch(testArray, userNum);
        }
    }
}
