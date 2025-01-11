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
        static void BenchmarkWithoutIn(TestStruct value)
        {

        }
        static void BenchmarkWithIn(in TestStruct value)
        {

        }
        static void Main(string[] args)
        {
            /* in - ключевое слово которое устанавливает
             * флаг ReadOnly (только для чтения) на переменную
             * передоваемую в метод.
             * 
             * Это означает что мы можем только считывать данные из
             * этой переменной, а изменять данные полностью запрещенно.
             * 
             * Может возникнуть закономерный вопрос, а зачем нам
             * передовать перемунную по ссылке, ведь кроме защиты переменной
             * от записи больше приимущест нет, и мы можем просто передовать
             * переменную в метод без каких-либо модификаторов, однако это не так.
             * in позволяет значительно сократить нагрузку на оперативную
             * память и ускорить работу программы путём передачи переменной по ссылке.
             * 
             * Ниже приведён пример замеров скорости выполнения методов в
             * которые будет передана структура с данными типа decimal и в конце
             * выполнения методов будет показанно затраченное время на выполнение
             * каждого из них.
             */

            TestStruct s = new TestStruct();
            TimeSpan elapsed;
            string formattedTime;
            Stopwatch sw = Stopwatch.StartNew();

            Console.WriteLine("Дождитесь окончания тестирования...\n");

            for (int i = 0; i < int.MaxValue / 4; i++)
            {
                BenchmarkWithoutIn(s);
            }
            sw.Stop();
            elapsed = sw.Elapsed;
            formattedTime = string.Format("{0}сек. {1:D3}милисек.", elapsed.Seconds, elapsed.Milliseconds);
            Console.WriteLine($"Время выполнения БЕЗ in: {formattedTime}");


            sw.Restart();
            for (int i = 0; i < int.MaxValue / 4; i++)
            {
                BenchmarkWithIn(s);
            }
            elapsed = sw.Elapsed;
            formattedTime = string.Format("{0}сек. {1:D3}милисек.", elapsed.Seconds, elapsed.Milliseconds);
            Console.WriteLine($"Время выполнения  C  in: {formattedTime}\n\n\n\n");
            sw.Stop();

            Console.ReadLine();
        }
    }
}
