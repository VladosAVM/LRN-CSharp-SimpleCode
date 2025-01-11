using System;

/* REF - Ключевое слово
 * 
 * Источник: https://www.youtube.com/watch?v=H3gznh97TlQ
 */

namespace _043___REF___Ключевое_слово
{
    internal class Program
    {
        struct TestStruct
        {
            public int f;
            public int g;
            public int h;
        }
        class TestClass
        {
            public int i;
            public int j;
            public int k;
        }
        static void Foo(int a)
        {
            a = -5;
        }
        static void FooRef(ref int a)
        {
            a = -5;
        }
        static void Foo3Ref(ref int c, ref int d, ref int e)
        {
            c = 3;
            d = 9;
            e = 5;
        }
        static void FooStructRef(ref TestStruct testStruct)
        {
            testStruct.f = 18;
            testStruct.g = 14;
            testStruct.h = 17;
        }
        static void FooClassRef(ref TestClass testClass)
        {
            testClass.i = 21;
            testClass.j = 44;
            testClass.k = 32;
        }
        static void FooArray(int[] testArray)
        {
            testArray = null;
        }
        static void FooArrayRef(ref int[] testArray)
        {
            testArray = null;
        }
        static ref int FooRefReturn(int[] testArray)
        {
            return ref testArray[1];
        }
        static void PrintArray(int[] arr)
        {
            Console.Write("Данные в массиве: ");
            
            for (int i = 0; i < arr?.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            if (arr == null)
                Console.Write("null");

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            /* ref - передаёт аргумент по ссылке.
             * 
             * Чтоже это значит:
             * По умолчанию при передаче аргумента(переменной) значимого типа
             * в вызываемый метод, происход копирование данных.
             * Передавая переменную "a" из метода Main в метод Foo, данные из
             * переменной a.Main копируются в переменную a.Foo. Внутри метода Foo происходит
             * изменение данных в переменной a.Foo. После выхода из метода, данные в
             * переменной a.Main остаются прежними.
             * Это происходит по причине того что наш метод не возвращает значение, а также
             * по причине того что переменная a.Foo, находится в другой области памяти и
             * никак не связана с переменной a.Main.
             * 
             * Если мы будет использовать ключевое слово ref при указании принимаемых
             * аргументов в методе, и передавать аргумент в метод также с ключевым
             * словом ref, тогда наша переменная a.Main начнёт изменяться и присваивать
             * значения из метода Foo.
             * По сути ключевое слово ref, позволяет изменить поведение значимых
             * переменных, а точнее сделать его похожим на поведение ссылочных типов.
             */
            int a = 2;

            Foo(a);
            Console.WriteLine($"Foo a = {a}");

            FooRef(ref a);
            Console.WriteLine($"FooRef a = {a}");

            /* Подобное изменение поведения позволит нам создавать методы которые
             * будут возвращать не 1-но значение а срзуже несколько.
             */
            int c = 0;
            int d = 0;
            int e = 0;
            Foo3Ref(ref c, ref d, ref e);
            Console.WriteLine($"\nFoo3Ref c = {c}\n" +
                              $"        d = {d}\n" +
                              $"        e = {e}\n");

            /* Однако подобное использования ключевого слова ref, больше говорит
             * о плохой реализации метода и нарушает принципы SOLID, поэтому так
             * делать не стоит.
             * 
             * Но есть похожий пример и он используется в реальной разработке.
             * 
             * Этот пример касается создания структур с полями (структуры будут расмотренны
             * в разделе про ООП).
             */
            TestStruct testStruct = new TestStruct();
            FooStructRef(ref testStruct);
            Console.WriteLine($"\ntestStruct.f = {testStruct.f}\n" +
                              $"             = {testStruct.g}\n" +
                              $"             = {testStruct.h}\n");


            /* ref также используется при передаче ссылочных типов в методы.
             * 
             * При передаче ссылочного типа в метод мы передаём ссылку на данные в Куче.
             * Переменная которая принимает данную ссылку, создаёт копию этой ссылки.
             * При изменении данных по ссылке в Куче, данные в переменной ВНЕ метода
             * также изменятся, потамучто происходит изменение непосредственно в самой куче,
             * но если мы попытаемся удалить ссылку, например присвоив значение null,
             * то ссылка будет стёрта только внутри метода, а снаружи переменная продолжит
             * хранить ссылку.
             *
             * Для того чтобы уничтожитm или изменить ссылку необходимо передать её с
             * помощью ref.
             * 
             * Аналогичное поведение будет происходить в том случае если мы будем
             * переопределять старый вассив - новым массивом при передаче старого
             * массива по ссылке с помощью ref
             * 
             * Пример ниже демонстрирует именно это поведение.
             */
            int[] testArray1 = { 1, 2, 3 };
            Console.WriteLine("Вызов метода FooArray");
            FooArray(testArray1);
            PrintArray(testArray1);

            Console.WriteLine("\nВызов метода FooArrayRef");
            FooArrayRef(ref testArray1);
            PrintArray(testArray1);

            /* ref можно использовать для объявление ссылочных локальных переменных.
             * Подобные переменные позволят работать с сылочными типами - хронить и 
             * изменять данные в них.
             * 
             * Например - если в ссылочную переменную передать значение из массива,
             * то при изменении значения такой переменной будет изменено значение
             * в массиве.
             */

            // Попытка изменения значения в массиве при помощи локальной переменной
            int[] testArray2 = { 9, 8, 7 };
            int l = testArray2[0];
            l = -5;
            Console.WriteLine($"\nСсылочные локальные переменные\n" +
                              $"int l = {l}");
            PrintArray(testArray2);

            // Попытка изменения значения в массиве при помощи локальной ref переменной
            ref int m = ref testArray2[0];
            m = -4;
            Console.WriteLine($"\nint m = {m}");
            PrintArray(testArray2);

            /* ref также применяется для возвращения ссылочного зачения из метода
             * 
             * Если мы при создании метода укажем ключевое слово ref перед типом 
             * возвращаемого значения и также укажим ref при вызове ключевого слова
             * return, то мы сможем вернуть в переменную ссылку на объект, и в
             * дальнейшем также изменять данные при помощи этой переменной.
             */
            ref int n = ref FooRefReturn(testArray2);
            n = -9;
            Console.WriteLine($"\nВозвращаемые ссылочные значения\n" +
                              $"int n = {n}");
            PrintArray(testArray2);

            Console.WriteLine();
        }
    }
}
