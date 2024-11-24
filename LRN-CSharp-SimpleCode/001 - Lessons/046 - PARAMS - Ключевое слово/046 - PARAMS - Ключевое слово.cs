using System;
using System.ComponentModel;

/* PARAMS - Ключевое слово
 * 
 * Источник: https://www.youtube.com/watch?v=gwYuiwelSQs
 */

namespace _046___PARAMS___Ключевое_слово
{
    internal class Program
    {
        static void Test(params object[] parameters)
        {
            string message = "Тип данных: {0}, \tЗначение: {1}";

            foreach (var item in parameters)
                Console.WriteLine(message, item.GetType(), item);
        }
        static int Sum(params int[] parameters)
        {
            int result = 0;

            for (int i = 0; i<parameters.Length; i++)
                result += parameters[i];

            return result;
        }
        static void Main(string[] args)
        {
            /* params - используется как модификатор при написании методов
             * который позволяет передовать в метод неограниченное число параметров.
             * 
             * При написании метода стоит учитывать что params необходимо указывать
             * последним принимаемым параметром:
             *      static int Sum(params int[] parameters, bool chachacha) <- !!! ОШИБКА !!!
             *      static int Sum(bool chachacha, params int[] parameters) <- Верно
             * Также в одном методе не может быть 2-х параметров с модификатором params.
             */
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;
            int e = 5;
            Console.WriteLine(Sum(a, b));
            Console.WriteLine(Sum(a, b, c, d, e));
            Console.WriteLine(Sum(a, b, c, 5));

            
            Console.WriteLine();

            Test("test", 5, 'q', 5.89f, true);
        }
    }
}
