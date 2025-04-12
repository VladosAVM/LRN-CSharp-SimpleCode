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
        /// <summary>
        /// Вывод всех передоваемых переменных с инфрмацией об их типе данных и значении.
        /// </summary>
        /// <param name="parameters"></param>
        static void TypeInfoPrint(params object[] parameters)
        {
            string message = "Тип данных: {0}, \tЗначение: {1}";

            foreach (var item in parameters)
                Console.WriteLine(message, item.GetType().Name, item);
        }

        /// <summary>
        /// Суммирует неограниченное число переменных.
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        static int Sum1(params int[] parameters)
        {
            int result = 0;

            for (int i = 0; i < parameters.Length; i++)
                result += parameters[i];

            return result;
        }

        /// <summary>
        /// Сумма неограниченного числа переменных разного типа.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="parametrs"></param>
        /// <returns></returns>
        static T Sum2<T>(params T[] parametrs)
        {
            dynamic sum = default(T);

            for (int i = 0; i < parametrs.Length; i++)
                sum += parametrs[i];

            return sum;
        }
        /// <summary>
        /// <para>Заглушка для вызова метода без передачи параметров.</para>
        /// <para>Возвращает 0.</para>
        /// </summary>
        /// <returns></returns>
        static int Sum2()
        {
            return 0;
        }
        static void Main(string[] args)
        {
            /* params - используется как модификатор при написании методов
             * который позволяет передовать в метод неограниченное число аргументов.
             * 
             * При написании метода стоит учитывать что params необходимо указывать
             * последним принимаемым аргументом:
             *      static int Sum(params int[] parameters, bool chachacha) <- !!! ОШИБКА !!!
             *      static int Sum(bool chachacha, params int[] parameters) <- Верно
             * Также в одном методе не может быть 2-х аргументов с модификатором params.
             */
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;
            int e = 5;
            
            // Передеча разного количества переменных в метод с params аргументом
            Console.WriteLine(Sum1(a, b));
            Console.WriteLine(Sum1(a, b, c, d, e));
            Console.WriteLine(Sum1(a, b, c, 5));

            // Передеча разного количества переменных в ДЖЕНЕРИК метод
            // с params аргументом
            Console.WriteLine(Sum2(a, b, c, 5, 4.6));
            Console.WriteLine(Sum2());

            Console.WriteLine();

            // Передача разного количества аргументов разного типа в метод
            // с params аргументом
            TypeInfoPrint("test", 5, 'q', 5.89f, true);
        }
    }
}
