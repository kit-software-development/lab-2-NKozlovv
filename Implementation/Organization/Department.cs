namespace Practice.Organization
{
    /// <summary>
    ///     Скрытая реализация представления об отделе предприятия.
    /// </summary>
    public struct Department : IDepartment
    {
        /*
         * TODO #2: Реализуйте интерфейс IDepartment для структуры Department
         */
        public string Name { get; }
        public Department(IDepartment department)
        {
            Name = department.Name;
        }     

        public Department(string name)
        {
            Name = name;
        }

    }
}