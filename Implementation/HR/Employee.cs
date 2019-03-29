using Practice.HR.Events;
using Practice.Organization;
using System;

namespace Practice.HR
{
    /// <summary>
    ///     Скрытая реализация представления о сотруднике.
    /// </summary>
    internal class Employee : AbstractPerson, IEmployee
    {
        /*
         * TODO #5: Реализуйте интерфейс IEmployee для класса Employee
         */

        private Department department;
        
        public event EventHandler<ValueChangeEventArgs<IDepartment>> DepartmentChange;

        public IDepartment Department
        {
            get { return department; }
            set
            {
                ValueChangeEventArgs<IDepartment> args = new ValueChangeEventArgs<IDepartment>(Department);
                
                department = new Department(value);

                if (DepartmentChange != null)
                {
                    DepartmentChange(this, args);
                }
            }
        }

 
    }
}