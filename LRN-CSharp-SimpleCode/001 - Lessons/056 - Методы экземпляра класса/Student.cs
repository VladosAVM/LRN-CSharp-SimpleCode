using System;

namespace _056___Методы_экземпляра_класса
{
    class Student
    {
        public Guid id;
        public string firstName;
        public string lastName;
        public string middleName;
        public int age;
        public string group;

        public void Print()
        {
            Console.WriteLine($"Информация о студенте:\n" +
                              $"ID: {id}\n" +
                              $"Имя: {firstName}\n" +
                              $"Фамилия: {lastName}\n" +
                              $"Отчество: {middleName}\n" +
                              $"Возраст: {age}\n" +
                              $"Группа: {group}");
        }

        public string GetFullName()
        {
            return $"{firstName} {lastName} {middleName}";
        }
    }
}
