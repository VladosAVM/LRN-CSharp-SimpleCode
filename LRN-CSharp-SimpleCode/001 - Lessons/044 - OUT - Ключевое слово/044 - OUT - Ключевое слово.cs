using System;
using System.Runtime.InteropServices.ComTypes;

/* OUT - Ключевое слово
 * 
 * Источник: https://www.youtube.com/watch?v=R9i0XFWkFps
 */

namespace _044___OUT___Ключевое_слово
{
    internal class Program
    {
        static void TestRef(ref int value)
        {
            value++;
        }
        static void TestOut(out int value)
        {
            // value++; // Ошибка, переменной не присвоено значение
            value = 10;
        }
        static void Main(string[] args)
        {
            /* out - ключевое слово которое также как и ref позволяет
             * передавать переменные по ссылке.
             * INFO:
             *  1. Переменная НЕ обязательно должна быть ИНИЦИАЛИЗИРОВАННА при передаче через OUT.
             *  2. ОБЯЗАТЕЛЬНО присваивать новое значение переменной в методе.
             *     Можно присвоит ТАКОЕЖЕ значение которые было при передаче переменной в метод
             *  3. OUT нельзя присвоить базовое значение внутри параметров принимаемых методом
             *      void TEST(out int x = 0) - ОШИБКА
             *  4. Методы принимающие значения с модификатором ref, in, out не могут быть асинхронными.
             *      async void TEST(out int x) - НЕ скомпилируется
             * 
             * ref - обязывает присвивать значение переменной ДО передачи
             * в метод, но НЕ обязывает присваивать значение внутри метода.
             * 
             * out - НЕ обязывает присваивать значение переменной ДО передачи
             * в метод, но обязывает присваивать значение внутри метода.
             */

            // REF
            // Обязательное присвоение значения при передаче переменной в метод
            // с использованием REF
            // int testRefInt; // Ошибка, переменной не присвоено значение
            int testRefInt = 10;
            TestRef(ref testRefInt);
            Console.WriteLine($"Переменная testRefInt = {testRefInt}");

            // TestRef(ref int x); // Ошибка
            // Переменную с ключевым словом ref нельзя
            // определить прямо в параметрах вызова метода
            
            // OUT
            // НЕобязательное присвоение значения при передаче переменной в метод
            // с использованием OUT
            int testOutInt;  // Переменной передоваемой с помощью out
                             // не обязательно присваивать значение
            testOutInt = 10; // однако можно и присвоить значение перед
                             // передачей в метод, но внутри метода по
                             // прежнему будет ОБЯЗАТЕЛЬНЫМ присвоение
                             // нового значения
            TestOut(out testOutInt);
            Console.WriteLine($"Переменная testOutInt = {testOutInt}");

            TestOut(out int x); // Переменную с ключевым словом out можно
                                // определить прямо в параметрах вызова метода
            Console.WriteLine($"Переменная x = {x}");

            // Пример применения out
            Console.Write("\nВведите число: ");

            string str = Console.ReadLine();
            int.TryParse(str, out int result1);
            Console.WriteLine($"result = {result1}");

            // ИЛИ
            Console.Write("\nВведите число: ");

            int.TryParse(Console.ReadLine(), out int result2);
            Console.WriteLine($"result = {result2}");


        }
    }
}
