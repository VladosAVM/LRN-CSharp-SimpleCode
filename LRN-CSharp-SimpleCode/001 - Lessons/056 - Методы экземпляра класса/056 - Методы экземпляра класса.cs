using System;

/* Методы объекта (экземпляра) класса
 * 
 * Источник: https://www.youtube.com/watch?v=PVtmZ1YeOD8
 */

namespace _056___Методы_экземпляра_класса
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* У класса могут быть свои собственные методы которые будут вызвать
             * при обращении к экземпляру класса.
             * Для создания таких методов, их необходимо написать внутри самого класса.
             *  Пример:
             *      Class имя_класса
             *          {
             *              поле_класса...
             *              поле_класса...
             *              поле_класса...
             *              ...
             *              
             *              метод_класса...
             *              метод_класса...
             *              ...
             *          }
             *          
             * Готовый пример смотрите в классе Student.cs
             * 
             * Внутренняя структура подобных методов не требует объявление экземпляра
             * класса и позволяет обращаться к полям класса напрямую.
             * 
             * 
             * 
             * Подобные методы будут доступны сразуже при обращении к экземпляру класса.
             *  Пример:
             *      имя_экземпляра_класса.метод_класса();
             * 
             * !!!
             * ИНФО
             * Класс Student.cs нарушет принципы SOLID, а именно Dependency Inversion.
             * Причиной тому является использование класса Concole, для вывода информации о студенте.
             * Класс Student теперь зависит от класса Console и обязан всюду тянуть его за собой.
             * Решить эту проблему можно при помощи Dependency Injection, но об этом будет сказано
             * позже в курсе.
             * !!!
             * 
             */

            var firstStudent = new Student();   // Создание экземпляра класса Student
            // Заполнение данных в полях экзмпляра класса
            firstStudent.id = Guid.NewGuid();   // ID
            firstStudent.firstName = "Чел";     // Имя
            firstStudent.lastName = "Медведа";  // Фамилия
            firstStudent.middleName = "Свин";   // Отчество
            firstStudent.age = -1;              // Возраст
            firstStudent.group = "ZzYzX";       // Группа
            firstStudent.Print();               // Вызов метода Print класса Student

            Console.WriteLine();                // Отступ строки

            var secondStudent = new Student();  // Создание экземпляра класса Student
            secondStudent.Print();              // Вызов метода Print класса Student

            Console.WriteLine($"\n{firstStudent.GetFullName()}");

            var car1 = new Car();

            car1.PrintSpeed();      // Информация о скорости
            car1.DriveForward();    // Ехать вперёд
            car1.PrintSpeed();
            car1.DriveBackward();   // Ехать назад
            car1.PrintSpeed();
            car1.Stop();            // Остановиться
            car1.PrintSpeed();


        }
    }
}

