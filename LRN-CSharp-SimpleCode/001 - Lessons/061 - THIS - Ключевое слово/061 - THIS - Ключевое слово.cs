using System;

/* THIS - Ключевое слово
 * 
 * Источник: https://www.youtube.com/watch?v=OD_rUWpAuDg
 */
namespace _061___THIS___Ключевое_слово
{
    class Student
    {
        public Student(string lastName, DateTime birthDate)
        {
            // this - говорит компилятору что необходимо
            // присвоить значение принимаемого аргумента
            // в поле класса в текущем экземпляре класса
            this.lastName = lastName;
            this.birthDate = birthDate;
        }

        // Использование Инициализатора Конструктора (:) для вызова Цепочки Конструкторов и
        // использование this для передачи аргументов Текущего Конструктора в Вызываемый Конструктор текущего экземпляра класса
        // Синтаксис:
        //      конструктор(принимаемые аргументы) : this (передаваемые аргументы)
        
        public Student(string lastName, string firstName, string middleName, DateTime birthDate) : this(lastName, birthDate)
        {
            this.firstName = firstName;
            this.middleName = middleName;
        }

        public Student(Student student)
        {
            lastName = student.lastName;
            firstName = student.firstName;
            middleName = student.middleName;
            birthDate = student.birthDate;
        }

        private string firstName;
        private string lastName;
        private string middleName;
        private DateTime birthDate;

        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public void Print()
        {
            Console.WriteLine($"Фамилия: {lastName}\n" +
                              $"Имя: {firstName}\n" +
                              $"Отчество: {middleName}\n" +
                              $"Дата рождения: {birthDate:dd.MM.yyyy}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            /* Благодаря ключевому слову this, можно получить доступ к текущему экземпляру класса -
             * к его полям, методам, свойствам...
             * 
             * this, говорит компилятору что нужно работать с текущим экземпляром класса.
             * 
             * Использование this, позволяет по новому реализовывать функционал программы.
             * Например при помощи this можно одинаково именовать поля класса и принимаемые аргументы.
             *  Пример:
             *           class x
             *           {
             *               public x(string firstName, string lastName)
             *               {
             *                   this.firstName = firstName;
             *                   this.lastName = lastName;
             *               }
             *               
             *               private string firstName;
             *               public string lastName;
             *           }
             *           
             * Ранее приватным полям приходилось давать имена начиная с "_", не только для явного
             * указания приватности поля но и для того чтобы присвоение значения внутри конструктора
             * функционировало нормально. Если имена переменных совпадали то компилятор присваивал
             * значение переменной в эту же переменную.
             * 
             * Публичные поля так и вовсе всегда совпадали по названиям и приходилось выдумывать
             * кастыли для корректной работы компилятора.
             * 
             * Даже сама Visual Studio при использовании быстрого переименования (Ctrl + R + R) -
             * автоматически заменяет имя приватного поля с _firstName на this.firstName
             * 
             * 
             * Кроме того, появляется возможность использовать Инициализатор Конструктора (:) для
             * вызова Цепочки Конструкторов.
             *  Пример:
             *           class Xyz
             *           {
             *               public Xyz(string firstName)
             *               {
             *                  this.firstName = firstName;
             *               }
             *               
             *               public Xyz(string firstName, string lastName) : this(firstName)
             *               {
             *                   this.lastName = lastName;
             *               }
             *               
             *               private string firstName;
             *               public string lastName;
             *           }
             *           
             * Использование Цепочки Конструкторов позволяет уменьшить количество повторяющегося кода
             * делегируя часть работы одного конструктора - другому конструктору, который содержит весь
             * необходимый функционал для инициализации текущего конструктора.
             * Также позволяет избежать ошибок в работе программы, когда необходимо внести изменения
             * в какой-то из конструкторов.
             */

            Student student1 = new Student("A", "B", "C", new DateTime(2220, 02, 22));
            Student student2 = new Student("X", "Y", "Z", new DateTime(1111, 11, 11));
        }
    }
}
