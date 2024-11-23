using System;

/* ДЗ к уроку 043 - Изменение размеров массива
 * 
 * Разбор: https://www.youtube.com/watch?v=5WUhcX72YYw - Изменение размера массива
 * Разбор: https://www.youtube.com/watch?v=iO0Q-G746eU - Добавление элементов в массив
 * Разбор: https://www.youtube.com/watch?v=ps2VQaFF1FA - Удаление элементов из массива
 */

namespace _008___ДЗ_к_уроку_043___Изменение_размеров_массива
{
    internal class Program
    {
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]} ");
        }
        static void ArrayResize<T>(ref T[] arr, uint numberOfElements)
        {
            T[] newArray = new T[numberOfElements];

            for (int i = 0; i < arr.Length && i < newArray.Length; i++)
                newArray[i] = arr[i];

            arr = newArray;
        }
        static void ArrayAddFirstElement(ref int[] arr, int elementValue)
        {
            ArrayAddElementByIndex(ref arr, elementValue, 0);
        }
        static void ArrayAddLastElement(ref int[] arr, int elementValue)
        {
            ArrayAddElementByIndex(ref arr, elementValue, arr.Length);
        }
        static void ArrayAddElementByIndex(ref int[] arr, int elementValue, int index)
        {
            int[] newArray = new int[arr.Length + 1];

            for (int i = 0; i < arr.Length; i++)
                newArray[i] = arr[i];

            for (int i = index; i < arr.Length; i++)
                newArray[i + 1] = arr[i];

            newArray[index] = elementValue;
            arr = newArray;
        }
        static void ArrayDeleteFirstElement(ref int[] arr)
        {
            ArrayDeleteElementByIndex(ref arr, 0);
        }
        static void ArrayDeleteLastElement(ref int[] arr)
        {
            ArrayDeleteElementByIndex(ref arr, arr.Length - 1);
        }
        static void ArrayDeleteElementByIndex(ref int[] arr, int index)
        {
            int[] newArray = new int[arr.Length - 1];

            for (int i = 0; i < index; i++)
                newArray[i] = arr[i];

            for (int i = index; i < newArray.Length; i++)
                newArray[i] = arr[i + 1];

            arr = newArray;
        }
        static void Main(string[] args)
        {
            
            // 1. Написать метод изменяющий количество элементов
            // массива (метод должен иметь возможность уменьшить или
            // увеличить размер массива).
            int[] testArray1 = { 1, 2, 3, 4, 5 };

            Console.Write($"--- Изменение кол-ва элементов массива ---\n\n" +
                          $"Текущая длинна массива: {testArray1.Length}\n" +
                          $"Укажите новую длинну массива: ");
            uint numberOfElements = uint.Parse(Console.ReadLine());

            ArrayResize(ref testArray1, numberOfElements);
            Console.WriteLine($"\nНовая длинна массива = {testArray1.Length}");
            PrintArray(testArray1);
            // 2. Написать методы для добавления элемента в начало
            // массива, в конец массива и по указанному адресу.

            // Добавление элемента в начало массива
            int[] testArray2 = { 1, 2, 3 };
            Console.Write("\n\n\n--- Добавление элемента в начало массива ---\n" +
                              "Текущий массив: ");
            PrintArray(testArray2);
            Console.Write("\nУкажите зачение новго элемента: ");
            int elementValue = int.Parse(Console.ReadLine());
            ArrayAddFirstElement(ref testArray2, elementValue);
            Console.Write($"Массив с новым элементом в начале: ");
            PrintArray(testArray2);
            Console.WriteLine();

            // Добавление элемента в конец массива
            Console.Write("\n\n\n--- Добавление элемента в конец массива ---\n" +
                              "Текущий массив: ");
            PrintArray(testArray2);
            Console.Write("\nУкажите зачение новго элемента: ");
            elementValue = int.Parse(Console.ReadLine());
            ArrayAddLastElement(ref testArray2, elementValue);
            Console.Write($"Массив с новым элементом в конце: ");
            PrintArray(testArray2);
            Console.WriteLine();

            // Добавление элемента по указанному индексу массива
            Console.Write("\n\n\n--- Добавление элемента по индексу массива ---\n" +
                              "Текущий массив: ");
            PrintArray(testArray2);
            Console.Write("\nУкажите зачение новго элемента: ");
            elementValue = int.Parse(Console.ReadLine());
            Console.Write("\nУкажите индекс в массиве: ");
            int newElementIndex = int.Parse(Console.ReadLine());
            ArrayAddElementByIndex(ref testArray2, elementValue, newElementIndex);
            Console.Write($"Массив с новым элементом под индексом {newElementIndex}: ");
            PrintArray(testArray2);
            Console.WriteLine();

            // 3. Написать методы для удаления элемента массива - первого,
            // последнего, по индексу.
            int[] testArray3 = { 1, 2, 3, 4, 5, 6, 7, 8 };

            // Удаление первого элемента массива
            Console.Write("\n\n\n--- Удаление первого элемента массива ---\n" +
                              "Текущий массив: ");
            PrintArray(testArray3);
            ArrayDeleteFirstElement(ref testArray3);
            Console.Write($"\nМассив после удаления первого элемента: ");
            PrintArray(testArray3);
            Console.WriteLine();

            // Удаление последнего элемента массива
            Console.Write("\n\n\n--- Удаление последнего элемента массива ---\n" +
                              "Текущий массив: ");
            PrintArray(testArray3);
            ArrayDeleteLastElement(ref testArray3);
            Console.Write($"\nМассив после удаления последнего элемента: ");
            PrintArray(testArray3);
            Console.WriteLine();

            // Удаление элемента массива по индексу
            Console.Write("\n\n\n--- Удаление элемента массива по индексу ---\n" +
                              "Текущий массив: ");
            PrintArray(testArray3);
            Console.Write($"\nУкажите индекс элемента который необходимо удалить: ");
            int deleteElementIndex = int.Parse(Console.ReadLine());
            ArrayDeleteElementByIndex(ref testArray3, deleteElementIndex);
            Console.Write($"\nМассив после удаления элемента под индексом {deleteElementIndex}: ");
            PrintArray(testArray3);
            Console.WriteLine();
        }
    }
}
