using ATM_Sim.Person;
using System;

namespace ATM_Sim.Server
{
    /// <summary>
    /// Класс пользователя. Содержит основные данные, такие как ФИО и начальное колличество денег
    /// </summary>
    class User
    {
        //Данное поле необходимо для коррекной работы генератора псевдослучайных чисел
        protected static int randomKey = 1;
        //Данное поле необходимо для коррекной работы генератора псевдослучайных чисел
        protected DateTime time;
        //Данное поле необходимо для коррекной работы генератора псевдослучайных чисел
        protected Random rand;

        /// <value>Свойство, позволяющее получить/задать Имя пользователя</value>
        public string Name { get; private set; }

        /// <value>Свойство, позволяющее получить/задать Фамилию пользователя</value>
        public string Surname { get; private set; }

        /// <value>Свойство, позволяющее получить/задать Отчество пользователя</value>
        public string Patrinymic { get; private set; }

        /// <value>Свойство, позволяющее получить/задать первоначальное колличество денег у пользователя/value>
        public uint HasMoney { get; set; }

        /// <summary>
        /// Конструктор класса. Автоматически создает случайного пользователя с случайным колличеством денег 
        /// </summary>
        public User()
        {
            time = DateTime.Now;
            randomKey += 10000 + time.Millisecond * 10; // необходимо что бы избежать повторений подряд пр работе с генератором псевдослучайных чисел
            GenerateNewPersonData();
        }

        /// <summary>
        /// Перегруженный конструктор класса. Создает пользователя с заданными ФИО и заданным колличеством денег 
        /// </summary>
        public User(string name, string patrinymic, string surname, uint money)
        {
            Name = name;
            Surname = surname;
            Patrinymic = patrinymic;
            HasMoney = money;           
        }

        /// <summary>
        /// Метод для создания нового пользователя со случайными параметрами. 
        /// </summary>
        protected virtual void GenerateNewPersonData()
        {                      
            rand = new Random(randomKey + time.Millisecond);
            this.Name = PersonDataCreator(PersonalData.Name, PersonalData.Name.Length);
            this.Patrinymic = PersonDataCreator(PersonalData.Patrinymic, PersonalData.Patrinymic.Length);
            this.Surname = PersonDataCreator(PersonalData.Surname, PersonalData.Surname.Length);
            this.HasMoney = (uint)rand.Next(3_00_000);
        }

        /// <summary>
        /// Метод для получения случайного значения из массива значений. 
        /// </summary>
        /// <param name="upLimit">Верхний предел числовой выборки</param>
        ///<typeparam name = "T" >Тип данных из которого нужно произвести случайную выборку</typeparam>
        protected T PersonDataCreator<T>(T[] args , int upLimit)
        {           
            return args[rand.Next(upLimit)];
        }
    }
}
