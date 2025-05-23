﻿using System;

/* GET SET - Геттеры и Сеттеры - Свойства класса
 * 
 * Источник: https://www.youtube.com/watch?v=2or3h5m3VbA
 */

namespace _062___GET_SET___Геттеры_и_Сеттеры___Свойства_класса
{
    /* Свойства класса это один из инструментов при помощи которого реализуется инкапсуляция.
     * Тема инкапсуляции разбиралась в уроке 58. 
     * 
     * Свойства это прокаченые Геттеры и Сеттеры, можно сказать что это их более совершенная версия.
     * Прежде чем переходить к свойствам - сначала надо разобрать что такое Геттеры и Сеттеры.
     * 
     * Геттеры и Сеттеры позволяют УСТАНАВЛИВАТЬ, ИЗВЛЕКАТЬ и ОБРАБАТЫВАТЬ значения полей класса.
     * 
     * 
     * Предположим нам надо реализовать класс который будет принимать и возвращать значение переменной типа int.
     * Внутри класса будет обработчик который не позволит установить значение переменной МЕНЬШЕ 1 или БОЛЬШЕ 5.
     * 
     * Для реализации подобной задачи можно написать методы которые будут обрабатывать данные события.
     *      Пример: смотрите класс - GetterSetterByMethod
     */
    class GetterSetterByMethod
    {
        // Приватное поле класса
        private int x;

        // Обычный метод класса который работает как Геттер
        // Метод Геттер - который возвращает значение приватного поля класса
        public int GetX()
        {
            return x;
        }

        // Обычный метод класса который работает как Сеттер
        // Метод Сеттер - который устанавливает значение приватного поля класса в переделах от 1 до 5
        public void SetX(int x)
        {
            if (x < 1)
            {
                this.x = 1;
                return;
            }

            if (x > 5)
            {
                this.x = 5;
                return;
            }

            this.x = x;
        }
        /* Пример обращения к приватному полю через методы Геттер и Сеттер:
         *       GetterSetterByMethod getterSetterByMethod = new GetterSetterByMethod();
         *       getterSetterByMethod.SetX(10);
         *       getterSetterByMethod.GetX();
         */
    }

    /* ПОЛНОЕ Свойство Класса
     * 
     * В C# существует более удобный формат Геттеров и Сеттеров, который позволяет
     * реализовывать данный функционал гараздо быстрей, удобней и к томуже без использования
     * вызова методов.
     * 
     * !!! Какраз эта конструкция уже называется Свойство Класса !!!
     * 
     * Для быстрого создания подобных Геттеров и Сеттеров можно использовать сниппеты:
     *      propfull + Tab + Tab
     *      propf + Tab + Tab
     * 
     * При использовании данного сниппета - автоматически сгенерируется:
     *  Приватное поле класса
     *  Геттер
     *  Сеттер
     *  
     * Get и Set в свойстве класса называются АКСЕССОРЫ.
     * 
     * Это полный Геттер Сеттер который может выполнять все теже самые задачи что и Геттер Сеттер
     * который был реализован ранее через методы.
     * 
     * Данная реализация проще и короче чем то что было реализовано через методы.
     * К томуже она позволяет НЕ вызывать методы, а обращаться напрямую к приватному полю через
     * Геттер или Сеттер при работе с экземпляром класса.
     * А благодаря использованию ключевого слова value - мы избавляемся от проблемы конфликта имён,
     * которую ранее приходилось обходить при помощи ключевого слова this или именованием приватных полей через _имяПоля
     */
    class FullGetterSetter
    {
        // Приватное поле класса
        private int y;

        // Конструкция Геттер Сеттер
        public int Y
        {
            // Геттер Аксессор
            get
            {
                return y;
            }

            // Сеттер Аксессор
            set
            {
                if (value < 1)
                {
                    y = 1;
                    return;
                }

                if (value > 5)
                {
                    y = 5;
                    return;
                }

                // value в Аксессоре set является ключевым словом и используется как аналог
                // принимаемого аргумента метода Сеттера из предидущей реализации через методы
                y = value;
            }
        }
        /* Пример обращения к полю через Полное Свойство (Геттер Сеттер):
         *          FullGetterSetter fullGetterSetter = new FullGetterSetter();
         *          fullGetterSetter.Y = 10;
         *          int y = fullGetterSetter.Y;
         */
    }

    /* АВТОМАТИЧЕСКОЕ Свойство Класса
     * Оно используется когда задачей поля класса является простое присвоение и вывод значения,
     * или просто вывод значения.
     * 
     * Для быстрого создания Автоматического Свойства Класса можно использовать сниппет:
     *      prop + Tab + Tab
     * 
     * При использовании данного сниппета - автоматически сгенерируется:
     *      Приватное поле класса (Геттер; Сеттер;)
     */
    class AutomatedGetterSetter
    {
        // Работает аналогично базовой кострукции Полного Свойства Класса
        public int Z { get; set; }

        /*
         * Пример интерпритации "Автоматического Свойства" в форме "Полного Свойства":
         
                private int z;

                public int Z
                {
                    get { return z; }
                    set { z = value; }
                }
        */

    }

    // Демонстрация некоторых возможных модификаций Свойста Класса и Аксессоров get и set
    class PossibleModifiersForGetterSetter
    {
        // Поле класса можно сделать публичным, но тогда нарушится инкапсуляция
        public int a = 10;

        // Свойство можно сделать приватным, но тогда в нём не будет смысла т.к. оно будет недоступно извне,
        // при этом данная реализация является частью паттерна Singleton
        private int A  //- тип данных свойства доложен совпадать с типом данных поля
     // private string A - если тип данны не совпадает то свойство работать не будет
        {
            // Можно убрать Геттер или Сеттер. Такой подход используется для настройки работы класса под наши нужды.
            // Например можно убрать Геттер если работа класса подразумивает что класс НЕ должен выдавать данные наружу.
            // Или убрать Сеттер если работой класса подразумивается что класс НЕ должен принимать данные извне.

            set { a = value; } // ошибка приведения типов - в случае НЕсовпадении типа данных
        }

        // Также можно устанавливать модификаторы доступа напрямую в сами Аксессоры get и set.
        // Однако необходимо соблюдать ряд правил:
        // 1. Для установки модификатора доступа должно быть объявлено 2 аксессора
        // 2. Только один из аксессоров может иметь явный модификатор доступа
        // 3. Модификатор доступа Аксессора не может быть более открытым чем модификатор доступа Свойства
        private int b = 20;
        public int B
        {
            // Установка модификатора private для Аксессора get
            private get { return b; }
            set { b = value; }
        }

        // 1. При объявлении Автоматического Свойства можно сразу присвоить значение в переменную
        // 2. Можно убрать Сеттер и оставить только Геттер
        // 3. При наличии Геттера, ОБЯЗАТЕЛЬНО должен быть объявлен Сеттер
        public int C { get; } = 30;
     // public int C { set; } = 30; // В Автоматическом Свойстве НЕЛЬЗЯ использовать set БЕЗ get
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Использование Геттера и Сеттера через метод класса
            GetterSetterByMethod getterSetterByMethod = new GetterSetterByMethod();
            getterSetterByMethod.SetX(10);
            getterSetterByMethod.GetX();

            // Использование Аксессора Геттера и Сеттера через Полное Свойство Класса
            FullGetterSetter fullGetterSetter = new FullGetterSetter();
            fullGetterSetter.Y = 10;
            int y = fullGetterSetter.Y;

            // Использование Геттера и Сеттера через Автоматическое Свойство Класса
            AutomatedGetterSetter automatedGetterSetter = new AutomatedGetterSetter();
            automatedGetterSetter.Z = 10;
            int z = automatedGetterSetter.Z;
        }
    }
}
