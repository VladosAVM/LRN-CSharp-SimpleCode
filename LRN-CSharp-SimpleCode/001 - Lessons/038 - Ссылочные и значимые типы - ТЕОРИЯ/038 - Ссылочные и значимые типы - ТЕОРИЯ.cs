﻿using System;

/* Ссылочные и значимые типы - ТЕОРИЯ
 * 
 * Источник: https://www.youtube.com/watch?v=_RUluZNOwfY
 */

namespace _038___Ссылочные_и_значимые_типы___ТЕОРИЯ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* В C# все данные распределяются на 2 типа:
             *      1. Значимые типы (Value types)
             *      2. Ссылочные типы (Reference types)
             * Значимые типы (struct, enum) хронятся в стеке.
             * Ссылочные типы (class) хронятся в куче.
             * 
             * Стек (Stack) и Куча (Heap) это область в оперативной
             * памяти, но работают и используются они по разному.
             * 
             * Стек (Stack) это небольшой объём оперативной памяти который 
             * выделяется для кадого потока, т.е. каждый поток в программе
             * имеет свой Стек.
             * Дефолтное значение для Стека = 1 мегабайт.
             * Стек используется для хранения создаваемых переменных,
             * для выполнения операция над этими переменными, а также
             * используется для вызова методов которые используются в программе.
             * 
             * Куча (Heap) это что-то вроде склада в оперативной памяти которое
             * мы можем использовать по мере появления необходимости.
             * Объём Кучи зависит от того на какой аппаратной платформе
             * запускается программа и от операционной системы.
             * К примеру в 32-х разрядной системе выделяется около 1.5 гигабайта,
             * а в 64-х разрядной системе выделяется до 8 терабайт.
             * 
             * Если говорить просто, то Стек - быстрый, но мленький,
             * а Куча - медленная, но большая.
             * 
             * Одной из ключевых особенностей различия Стека и Кучи является
             * процесс очищения данных из оперативной памяти.
             * Значимые типы находящиеся в Стеке, удаляются из оперативной
             * памяти сразу после того как программа покидает контекст в
             * котором эти переменный были объявленны.
             * Ссылочные типы находящиеся в Куче, удаляются из оперативной
             * памяти при помощи сборщика мусора. Описать весь принцип работы
             * сборщика мусора здесь не получится, поэтому данную информацию
             * лучше поискать в интернете.
             * 
             * INFO: Стек работает по принципу Last In --> First Out, т.е. последняя
             *       задача которая попала в Стек, будет извлечена первой.
             * 
             * Значимые и Ссылочные типы также различаются по принципу передачи
             * данных от одной переменной к другой.
             *      1. Значимые типы - при присвоении значения одной переменной
             *      в другую, происходит копирования ДАННЫХ из источника в СТЕКЕ.
             *      2. Ссылочные типы - при присвоении значения одной переменной
             *      в другую, происходит копирования ССЫЛКИ на источник в КУЧЕ.
             * 
             * Дополнительное видео по стеку: https://www.youtube.com/watch?v=B3VHHfMW0Pg
             */
        }
    }
}
