using System;

/* Перегрузка методов
 * 
 * Источник: https://www.youtube.com/watch?v=zTwElCN9FzU
 */

namespace _036___Перегрузка_методов
{
    internal class Program
    {
        /// <summary>
        /// Возвращает сумму 2-х целых чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Sum(int a, int b)
        {
            return a + b;
        }
        /// <summary>
        /// Возвращает сумму 3-х целых чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
        /// <summary>
        /// Возвращает сумму 2-х дробных чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static double Sum(double a, double b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            /* Перегрузка методов позволяет вызывать метод с
             * одним и темже именем, но при этом работа и\или
             * реализация метода будет отличаться.
             * Как пример мы создали метод под именем Sum, которой
             * будет складывать несколько чисел.
             * 
             * В первой реализации метод складывает 2-а целых числа,
             * во второй реализации метод складывает 3-и целых числа
             * и в третьей реализации метод складывает 2 дробных числа.
             * 
             * При этом разный функцианал метода вызывается по
             * одному и томуже имени метода.
             * 
             * Также, каждой перегрузке метода можно добавить описание
             * которые будет высвечиваться в качестве подсказки при
             * вызове отдной из перегрузок метода.
             * Для того чтобы добавить описание перегрузке метода,
             * достаточно перед самим методомом или его перегрузкой
             * поставить ///
             */

            int resultInt;
            double resultDouble;

            resultInt = Sum(2, 5);
            Console.WriteLine(resultInt);

            resultInt = Sum(2, 5, 3);
            Console.WriteLine(resultInt);

            resultDouble = Sum(3.4, 6.2);
            Console.WriteLine(resultDouble);
        }
    }
}
