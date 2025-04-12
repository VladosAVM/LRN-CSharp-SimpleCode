using System;
using System.Diagnostics;

/* IN - Ключевое слово (модификатор)
 * 
 * Источник: https://www.youtube.com/watch?v=4Z6e-qwK_Wc
 */

namespace _045___IN___Ключевое_слово
{
    internal class Program
    {
        struct TestStruct
        {
            public decimal a;
            public decimal b;
            public decimal c;
            public decimal d;
            public decimal e;
            public decimal f;
            public decimal g;
            public decimal h;
            public decimal i;
        }
        static void BenchmarkWithoutIn(TestStruct value){ }
        static void BenchmarkWithIn(in TestStruct value){ }

        static void DefaultIn(in int x = 10)
        {
            Console.WriteLine(x);
        }


        static void Main(string[] args)
        {
            /*  INFO:
             *  1. Переменная ОБЯЗАТЕЛЬНО должна быть ИНИЦИАЛИЗИРОВАННА при передаче через IN.
             *  2. НЕЛЬЗЯ присваивать новое значение переменной в методе т.к. она получает свойство - ReadOnly.
             *  3. Методы принимающие значения с модификатором ref, in, out не могут быть асинхронными.
             *      async void TEST(in int x) - НЕ скомпилируется
             * 
             * in - ключевое слово которое устанавливает
             * флаг ReadOnly (только для чтения) на переменную
             * передоваемую в метод.
             * 
             * Это означает что мы можем только считывать данные из
             * этой переменной, а изменять данные полностью запрещенно.
             * 
             * Может возникнуть закономерный вопрос, а зачем нам
             * передавать перемунную по ссылке, ведь кроме защиты переменной
             * от записи больше приимущест нет, и мы можем просто передавать
             * переменную в метод без каких-либо модификаторов, однако это не так.
             * in позволяет значительно сократить нагрузку на оперативную
             * память и ускорить работу программы путём передачи переменной по ссылке.
             * 
             * Ниже приведён пример замеров скорости выполнения методов в
             * которые будет передана структура с данными типа decimal и в конце
             * выполнения методов будет показанно затраченное время на выполнение
             * каждого из них.
             */

            TestStruct testStruct = new TestStruct();
            TimeSpan elapsed;
            string formattedTime;
            Stopwatch sw = Stopwatch.StartNew();

            Console.WriteLine("Дождитесь окончания тестирования...\n");

            for (int i = 0; i < int.MaxValue / 4; i++)
            {
                BenchmarkWithoutIn(testStruct);
            }
            sw.Stop();
            elapsed = sw.Elapsed;
            formattedTime = string.Format("{0}сек. {1:D3}милисек.", elapsed.Seconds, elapsed.Milliseconds);
            Console.WriteLine($"Время выполнения БЕЗ in: {formattedTime}");


            sw.Restart();
            for (int i = 0; i < int.MaxValue / 4; i++)
            {
                BenchmarkWithIn(testStruct);
            }
            elapsed = sw.Elapsed;
            formattedTime = string.Format("{0}сек. {1:D3}милисек.", elapsed.Seconds, elapsed.Milliseconds);
            Console.WriteLine($"Время выполнения  C  in: {formattedTime}\n\n\n\n");
            sw.Stop();

            // Работа метода с аргументом имеющим модификатор IN и установленным значением по умолчянию
            // Если передать переменную в метод который принимает значение с модификатором IN, то переменная
            // передастся по ссылке, но иизменить её будет невозможно т.к. будет установлен флаг ReadOnly.
            // Если вызвать метод без передачи в него переменной то к аргументу метода будет применено
            // установленное значение по умолчанию.
            Console.WriteLine("------Default in - void DefaultIn(in int x = 10) -------");

            int x = 5;

            DefaultIn();
            DefaultIn(x);

            Console.WriteLine(x);
        }
    }
}
