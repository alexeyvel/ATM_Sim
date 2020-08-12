using System;
using System.Collections.Generic;

namespace ATM_Sim.Server
{
    /// <summary>
    /// Класс банковского счета (акаунта). Содержит инструменты для снятия и пополнения средств, запроса баланса, проверки подлинности PIN кода
    /// </summary>
    class Account
    {
        /// <value>Свойство, позволяющее получить ID клиента</value>
        public static int id { get; private set; } = 0;

        /// <value>Свойство, позволяющее получить список клиентов</value>
        public List<Client> Clients { get; private set; }

        /// <summary>
        /// Конструктор класса. Инициализирует новый список клиентов по умолчанию
        /// </summary>
        public Account()
        {
            Clients = new List<Client>();
        }

        /// <summary>
        /// Перегруженный конструктор класса. Инициализирует переданный список клиентов 
        /// </summary>
        /// <param name="clients">Список клиентов</param>
        public Account(List<Client> clients)
        {
            Clients = clients;
        }

        /// <summary>
        /// Метод генерирующий каждый раз новый ID клиента 
        /// </summary>
        /// <returns>Целое натуральное число - ID клиента</returns>
        public static int GetPersonalID()
        {
            ++id;
            return id;
        }

        /// <summary>
        /// Метод, добавляющий клиента в список клиентов 
        /// </summary>
        /// <param name="client">Клиент</param>
        public void AddNewClient(Client client)
        {
            Clients.Add(client);
        }

        /// <summary>
        /// Метод, удаляющий клиента из списка клиентов 
        /// </summary>
        /// <param name="client">Клиент</param>
        public void RemoveClient(Client client)
        {
            Clients.Remove(client);
        }

        /// <summary>
        /// Метод, проверяющий корректность введенного клиентом PIN кода
        /// </summary>
        /// <param name="client">Клиент</param>
        /// <param name="pin">PIN код</param>
        /// <returns>true - если PIN корректен, иначе false</returns>
        public bool CheckingPIN(Client client, string pin)
        {
            int id = client.ID;
            if (GetCurrentClient(id).PIN == pin)
                return true;
            else return false;
        }

        /// <summary>
        /// Метод, проверяющий баланс клиента
        /// </summary>
        /// <param name="client">Клиент</param>
        /// <returns>Целое натуральное число - баланс</returns>
        public uint ReturnBalance(Client client)
        {
            int id = client.ID;
            return GetCurrentClient(id).HasMoney;
        }

        /// <summary>
        /// Метод, позволяющий пополнить счет
        /// </summary>
        /// <param name="value">Сумма для пополнения</param>
        /// <param name="client">Клиент</param>
        public void Put(uint value, Client client)
        {
            int id = client.ID;
            GetCurrentClient(id).HasMoney += value;
        }

        /// <summary>
        /// Метод, позволяющий снять средства со счета
        /// </summary>
        /// <param name="value">Сумма для сеятия</param>
        /// <param name="client">Клиент</param>
        /// <returns>true в случае успешного выполнения, в противнос случае false</returns>
        public bool Withdraw(uint value, Client client)
        {
            int id = client.ID;
            if (GetCurrentClient(id).HasMoney >= value)
            {
                GetCurrentClient(id).HasMoney -= value;
                return true;
            }
            else return false;    
        }

        /// <summary>
        /// Метод, позволяющий получить данные на клиента по его ID (используя алгоритм бинарного поиска)
        /// </summary>
        /// <param name="id">ID клиента</param>
        /// <returns>Клиент с указанным ID</returns>
        /// /// <exception cref="System.ArgumentException">Генерируется исключение если ID не найден</exception>
        private User BinarySearchClient(int id)
        {
            int leftBorder = 0;
            int rightBorder = Clients.Count;
            int midList;

            while (leftBorder < rightBorder)
            {
                midList = leftBorder + (rightBorder - leftBorder) / 2;
                if(Clients[midList].ID == id)
                    return Clients[midList];
                if (Clients[midList].ID > id)
                    rightBorder = midList;
                else leftBorder = midList + 1;
            }
            throw new ArgumentException($"Пользователь с ID: {id} не найден.");
        }

        /// <summary>
        /// Метод, позволяющий получить данные на клиента по его ID (используя алгоритм линейного поиска)
        /// </summary>
        /// <param name="id">ID клиента</param>
        /// <returns>Клиент с указанным ID</returns>
        /// /// <exception cref="System.ArgumentException">Генерируется исключение если ID не найден</exception>
        private Client GetCurrentClient(int id)
        {
            foreach (var client in Clients)
            {
                if (client.ID == id)
                    return client;
            }
            throw new ArgumentException($"Пользователь с ID: {id} не найден.");
        }
    }
}
