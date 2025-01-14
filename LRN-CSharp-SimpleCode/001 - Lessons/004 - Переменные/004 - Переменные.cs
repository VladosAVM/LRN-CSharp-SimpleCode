﻿using System;

/*
 * Переменные в C#
 * 
 * Объявление (создание) переменных
 * 
 * Инициализация переменных
 * 
 * Присвоение значения переменной (размещение данных)
 * 
 * Источник: https://www.youtube.com/watch?v=JD3Ois6i298
 */

namespace _004___Переменные
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Переменная это именованный объект
             * который может хранить данные какого-то типа.
             *
             * Переменная является ссылкой на ячейку
             * в оперативной памяти в которой хранятся данные.
             */

            /* Объявление переменной
             * 
             * При объявлении переменной происходит выделение
             * области в оперативной памяти и создание ссылки(указателя)
             * на эту область.
             * 
             * Синтаксис объявления переменной:
             * Тип_данных имя_переменной;
            */
            int a;

            /* Присвоение значения переменной
             * 
             * Присвоение значения — это установка или изменение
             * значения переменной после её объявления.
             * 
             * При первичной установки значения переменной
             * происходит процесс инициализации.
             * 
             * Синтаксис присвоения значения:
             * Имя_переменной = присваемое_значение;
             */
            a = 1;

            // Вывод значения переменной "а" в консоль при помощи метода WriteLine
            Console.WriteLine(a);

            // Присвоение нового значения переменной а и вывод её значения в консоль
            a = 2;
            Console.WriteLine(a);

            /* Объвяление переменной и присвоение значения
             * 
             * Синтаксис объявления и присвоения значения:
             * Тип_данных имя_переменной = присваемое_значение;
             */
            int b = 2;            
            Console.WriteLine(b);

            /* Объявление нескольких переменных и присвоения им значений
             * 
             * Синтаксис объявления нескольких переменных:
             * Тип_данных имя_переменной_1, имя_переменной_2, имя_переменной_n...;
             */
            int c, d, e, f;
            c = 3;
            d = 4;
            e = d;
            f = 5;
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);

            /* Регистро-зависимость
             * 
             * Имена переменных являются регистро-зависимыми
             * Переменные abc, Abc, aBc, abC... и т.д. являются разными переменными
             * 
             * Они определяют разные области в оперативной памяти
             * и являются ссылками на свою собственную область в памяти.
             * 
             * Пример:
             */
            bool abc = false;
            bool ABC = true;
            Console.WriteLine(abc);
            Console.WriteLine(ABC);

            /* Символьный тип данных char
             * 
             * Тип данных char, является символьным типом данных
             * и может хронить в себе только 1-ин символ.
             * 
             * Синтаксис переменной типа char:
             * char имя_переменной = 'один_символ';
             */
            char one_char_symbol = 'a';
            Console.WriteLine(one_char_symbol);

            /* Строковый тип данных string
             * 
             * Тип данных string, является массивом данных типа char
             * и может хранить в себе как один символ, так множество символов.
             * 
             * Синтаксис переменной string
             * string имя_переменной = "один_или_множество_символов";
             * 
             * Синтаксис переменной типа string:
             * string имя_переменной = "один_или_множество символов";
             */
            string string_line = "Дратути, ет я сделяль !!!";
            Console.WriteLine(string_line);
        }
    }
}
