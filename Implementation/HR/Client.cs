namespace Practice.HR
{
    /// <summary>
    ///     Скрытая реализация представления о клиенте.
    /// </summary>
    internal class Client : AbstractPerson, IClient
    {
        /*
         * TODO #4: Реализуйте интерфейс IClient для класса Client
         */
        public float Discount { get; set; }

    }
}