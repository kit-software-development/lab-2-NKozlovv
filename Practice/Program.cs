using Practice.HR;
using Practice.Common;
using Practice.Organization;
using System;

namespace Practice
{
    /// <summary>
    ///     Цели работы:
    ///     1. на практике познакомиться с механизмом наследования;
    ///     2. научиться использовать полиморфизм;
    ///     3. научиться разделять контексты;
    ///     4. научиться использовать инкапсуляцию на уровне библиотеки;
    ///     5. научиться использовать абстрактные типы данных.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IClient client = Builders.ClientBuilder()
                .Name("Иванов", "Иван", "Иванович") 
                .Discount(.1f)
                .Build();
            IEmployee employee = Builders.EmployeeBuilder()
                .Name("Сидоров", "Григорий", "Петрович")
                .Department("Бухгалтерия")
                .Build();

            /*
             * TODO #8: Собрать приложение. 
             */

            /*
             * TODO #9: При помощи отладчика проверить типы и структуру объектов, адресованных переменными client и employee.
             */
            
            client.Name = new Name("Сидоров", "Иван", "Иванович");
            Console.WriteLine("______________________________");
            employee.Name = new Name("Иванов", "Григорий", "Игоревич");
            Console.WriteLine("______________________________");
            employee.Department = new Department("Отдел продаж");
        }
    }
}
