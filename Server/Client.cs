using System;
using System.Collections.Generic;
using ATM_Sim.CashMachine;
using ATM_Sim.Person;

namespace ATM_Sim.Server
{
    ///<inheritdoc/>
    ///<remarks>Этот класс представляет клиента. Содержит дополнительно данные о PIN коде, логе операций и уникальном ID</remarks>
    class Client : User
    {
        /// <summary>Переменная, хранящая уникальный ID</summary>
        public readonly int ID;
        /// <value>Свойство, позволяющее получить PIN код</value>
        public string PIN { get; private set; }
        public uint TotalMoney { get; private set; } = 0;
        /// <value>Свойство, позволяющее получить лог операций клиента</value>
        public List<string> LogOperation { get; private set; }
       
        ///<inheritdoc/>
        ///<remarks>Присваивает клиенту PIN код и ID</remarks>
        public Client() : base() 
        {
            base.GenerateNewPersonData();
            ID = Account.GetPersonalID();
        }
        ///<inheritdoc/>
        ///<remarks>Присваивает клиенту PIN код и ID</remarks>
        public Client(string name, string patrinymic, string surname, uint money) : base(name, patrinymic, surname, money)
        {
            randomKey += 10000 + time.Millisecond * 10; 
            ID = Account.GetPersonalID();
            GenerateNewPersonData();
            LogOperation = new List<string>();
        }

        ///<remarks>Переопределенный метод для генерации клиенту PIN кода</remarks>
        protected override void GenerateNewPersonData()
        {           
            rand = new Random(randomKey);
            string sign;
            for (int i = 0; i < SettingsATM.PIN_CODE_NUMBER_OF_SIGN; i++)
            {
                sign = PersonDataCreator(PersonalData.AllowedSignForPin, PersonalData.AllowedSignForPin.Length);
                PIN += sign;
            }
        }
    }
}
