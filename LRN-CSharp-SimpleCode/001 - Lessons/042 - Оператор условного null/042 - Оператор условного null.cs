﻿using System;
using System.Linq;

/* ?. - Оператор условного null
 * 
 * Источник: https://www.youtube.com/watch?v=UwVYKGi0XJk
 */

namespace _042___Оператор_условного_null
{
    internal class Program
    {
        static int[] GoodArray()
        {
            int[] testArray = { 1, 2, 3, 4 };
            return testArray;
        }
        static int[] NullArray()
        {
            int[] testArray = null;
            return testArray;
        }
        static void Main(string[] args)
        {
            /* ?. оператор условного null используется для проверки переменной
             * на наличия в ней значения null.
             * В случае если переменная = null то дальниейшие действия с
             * переменной не выполняются.
             * 
             * Как пример можно расмотреть метод Sum() вызываемый к массиву.
             * Данный метод возвращает сумму всех элементов массива.
             * Предположим что мы получаем какието данные из-вне, и к нам приходит
             * пустой массив, а если точней то отсутсвие ссылки на массива т.е. null.
             * В таком случае при дальнейшем выполнении метода Sum мы
             * получим ошибку ArgumentNullException.
             * Чтобы избежать подобного мы осуществлять проверку на наличие null при
             * помощи конструкции if else, но чтобы не городить лишний код и записать
             * всё в более краткой форме, мы можем использовать оператор .?
             * 
             * Пример:
             *      имя_массива?.Sum();
             * 
             * Данный оператор можно использовать в сочитании с оператором объединения
             * с null ??
             * 
             * Пример:
             *      имя_массива?.Sum() ?? 0
             * 
             * Это позволит нам избежать возникновения ошибки и установит указанное
             * нами дефолтное значение.
             */

            int[] testArray1 = GoodArray();
            Console.WriteLine($"Сумма элементов массива = {testArray1.Sum()}");

            // Пример комбинации операторов условного null и объединения с null
            int[] testArray2 = NullArray();
            Console.WriteLine($"Сумма элементов массива = {testArray2?.Sum() ?? 0}");
        }
    }
}
