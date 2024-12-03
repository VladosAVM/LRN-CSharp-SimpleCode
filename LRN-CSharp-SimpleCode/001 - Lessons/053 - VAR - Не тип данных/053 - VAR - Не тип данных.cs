using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

/* VAR - Не тип данных
 * 
 * Источник: https://www.youtube.com/watch?v=vbuZkuMfQ3k
 */

namespace _053___VAR___Не_тип_данных
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* VAR - ключевое слово которое является НЕявно типизированной ЛОКАЛЬНОЙ переменной.
             * 
             * Ключевое слово var сообщает компилятору о том что необходимо
             * определить тип входящих данных.
             * Превичное определение типа данных к которому будет принадлежать
             * переменная var, определяется в момент инициализации.
             * В дальнейшем в эту переменную необходимо будет присваивать значения того типа
             * который был определён при инициализации. Присвоение другого значения
             * будет невозможным.
             */

            var a = 4;
            //a = "";              // ошибка приведения типов

            // var не может присвоить значение null до тех пор, пока не будет
            // проинициализирован ссылочным типом данных - string, int[]..., либо явно приведён
            // к ссылочному типу данных, но от этого нет смысла.
            var b = "";
            b = null;

            //var c = null;       // Ошибка инициализации
            var d = (string)null; // бесполезный кусок кода

            // var применяется при создании Объектов, Классов, Коллекий....
            Dictionary<int, string> e = new Dictionary<int, string>(); // Создание коллекции БЕЗ var
            var f = new Dictionary<int, string>();                     // Создание коллекции  С  var

            // var удобно применять при работе с анонимными типами
            var g = new { Name = "John", Age = 42 };

            // Также var сильно упрощает работу при формировании запросов через Linq
            int[] numbers = { 11, 21, 7, 49, 3, 105, 199, 22, 6, 23, 14, 82 };
            var result = from i in numbers where i > 80 orderby i select i; // выборка значений > 80 из массива numbers

            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine($"\nТип данных result: {result.GetType()}");

            // var может быть ТОЛЬКО ЛОКАЛЬНОЙ переменной
            // var НЕЛЬЗЯ применять в следующих случаях

            //static void xxx1(var a)
            //{
            //}

            //static var xxx2()
            //{
            //}

            //class xxx3
            //{
            //    public var a;
            //    public var b = 0;
            //}

            // Допустимые варианты применения var

            void Test()
            {
                var h = Sum(2, 7);
            }

            int Sum(int x, int y)
            {
                var sumResult = x + y;
                return sumResult;
            }


        }
    }
}
