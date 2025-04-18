﻿using System;

/* ??= - Оператор присвоения объединения с null
 * 
 * Источник: https://www.youtube.com/watch?v=Jb-dFOXrSa0
 */

namespace _041___Оператор_присвоения_объединения_с_null
{
    internal class Program
    {
        static int[] GetArray()
        {
            int[] arr = null;
            return arr;
        }
        static void Main(string[] args)
        {
            /* ??= данный оператор позволяет не только проводить проверку
             * на наличие значения null в переменной но и сразуже присвоить
             * новое значение, позволяя избегать создание промежуточной переменной.
             * 
             * WARNING INFO:
             *      Обратите внимание что оператор ??= доступен начиная
             *      с версии C# 8.0 и в случае если версия вашего продукта
             *      ниже чем требуемая, то появится ошибка и использовать
             *      данный оператор не получится.
             *      
             * Для исправления данной ошибка есть 3 пути:
             *  1. Перенести проект на платформу с версией 8+
             *  2. Перейти в свойста проекта и в разделе debug, выбрать нужную вам версию.
             *  3. Перейти в папку с проектом
             *     Открыть файл - имя_проекта.csproj любым текстовым редактором
             *     Добавить строку <LangVersion>8.0</LangVersion> в группах
             *     <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
             *     и
             *     <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
             */

            // ПРИМЕР 1
            //
            // Оператор ??= позволяет присвоить новое значение
            // в исходную переменную если в ней находится значение NULL

            string str = null;      // Переменная со значением NULL
            str ??= string.Empty;   // Присвоение нового значения в случае
                                    // если в переменной находится NULL
            Console.WriteLine($"Длинна строки: {str.Length}");

            // Присвоение нового значения в переменную с NULL
            // во время обращения к этой переменной
            Console.WriteLine($"Длинна строки: {(str ??= string.Empty).Length}");


            // ПРИМЕР 2
            //
            // Предположим мы получаем данные из-вне и нам прилетает NULL
            int[] arr = GetArray();
            // Для того чтобы избежать появления исключения(ошибки),
            // необходимо использовать проверку на NULL
            arr ??= new int[0];
            // Это позволит избежать падения программы
            Console.WriteLine(arr.Length);
            // По аналогии с предидущим примером, проверку на NULL можно
            // делать во время обращения к переменной не создавая лишний код
            Console.WriteLine((arr ??= new int[0]).Length);
        }
    }
}
