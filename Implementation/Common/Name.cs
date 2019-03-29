namespace Practice.Common
{
    /// <summary>
    ///     Скрытая реализация представления об имени человека.
    /// </summary>
    public struct Name : IName
    {
        /*
         * TODO #1: Реализуйте интерфейс IName для структуры Name
         */
       
        /// <summary>
        ///     Имя.
        /// </summary>
        public string FirstName { get; }

        /// <summary>
        ///     Фамилия.
        /// </summary>
        public string Surname { get; }

        /// <summary>
        ///     Отчество.
        /// </summary>
        public string Patronymic { get; }
        
        public string FullName { get; }
        public string ShortName { get; }
        
        public Name(string surname, string firstname, string patronymic)
        {
            Surname = surname;
            FirstName = firstname;
            Patronymic = patronymic;
            FullName = surname + ' ' + firstname + ' ' + patronymic;
            ShortName = surname + ' ' + firstname.Substring(0,1) + "." + patronymic.Substring(0,1) + '.';
        }


        public Name(IName name)
        {
            FullName = name.FullName;
            ShortName = name.ShortName;

            var arrName = FullName.Split(' ');

            Surname = arrName[0];
            FirstName = arrName[1];
            Patronymic = arrName[2];
        }

       


    }
}