using System;

/* Параметры по умолчанию - Необязательные
 * 
 * Источник: https://www.youtube.com/watch?v=W1RZ61lJDr4
 */

namespace _047___Параметры_по_умолчанию___Необязательные
{
    internal class Program
    {
        static int SumWithDefArg(int num1, int num2, bool enableLogging = false)
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

        static void SumWithDefArgAndParams(string str, bool log = false, params int[] args) { }

        static void Main(string[] args)
        {
            int a = 4;
            int b = 15;
            /* Если при объявлении аргумента метода, задать этому аргументу
             * значение по умолчанию - тогда этот аргумент будет не обязательным
             * при вызове метода, т.е. передовать значения в него будет не обязательно.
             * 
             * Параметры по умолчанию ДОЛЖНЫ БЫТЬ всегда В КОНЦЕ списка аргументов метода,
             * но ДО аргумента PARAMS.
             */

            // Метод с параметром по умолчанию
            Console.WriteLine($"Вызов метода Sum(6, 4): {SumWithDefArg(6, 4)}");
            Console.WriteLine();

            Console.WriteLine($"Вызов метода Sum(6, 4, false): {SumWithDefArg(6, 4, false)}");
            Console.WriteLine();

            Console.WriteLine($"Вызов метода Sum(6, 4, true): {SumWithDefArg(6, 4, true)}");
            Console.WriteLine();

            // Метод с аргументом по умолчанию и params
            //  При вызове метода в котором есть аргументы по умолчанию и params
            //  одновременно, params должен идти последним, а передача необязательных
            //  аргументов становится обязательной.
            //  SumWithDefArgAndParams("test", 1, 2, 3); <-- ОШИБКА, нужно обязательно
            //                                               передать необязательный
            //                                               аргумент.
            // Для того чтобы вызвать этот метод без обязательно передачи необязательного
            // аргумента, необходимо использовать передачу по имени аргумента - эта тема
            // будет расмотренна в слудеющем уроке.
            //  Пример:
            SumWithDefArgAndParams("test", args: new int[] { b, a, 3, b, 99 });
        }
    }
}
