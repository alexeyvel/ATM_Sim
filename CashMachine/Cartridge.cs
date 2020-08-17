using System;

namespace ATM_Sim.CashMachine
{
    /// <summary>
    /// Класс картриджа (кассеты для денег) у банкомата. 
    /// </summary>
    public abstract class Cartridge
    {
        /// <summary>Переменная, хранящая значение, о заполненности картриджа купюрами (<c>true</c> - если картридж заполнен)</summary>
        protected bool isFull = false;

        /// <summary>Переменная, хранящая значение, показывающее свободен ли картридж от купюр (<c>true</c> - если картридж пуст)</summary>
        protected bool isEmpty = true;

        /// <summary>Переменная, хранящая текущее колличество купюр в картридже</summary>
        protected uint currentQuantityBanknote = 0;

        /// <value>Свойство, показывающее, заполнен ли картридж купюрами полностью (<c>true</c> - если картридж заполнен)</value>
        public bool IsFull { get => isFull; protected set => isFull = value; }

        /// <value>Свойство, показывающее, свободен ли картридж от купюр (<c>true</c> - если картридж пуст)</value>
        public bool IsEmpty { get => isEmpty; protected set => isEmpty = value; }

        /// <value>Свойство, позволяющее получить/задать максимальное колличество купюр в картридже</value>
        public uint MaxCapacity { get; private set; }

        /// <value>Свойство, позволяющее получить/задать текущее колличество купюр в картридже</value>
        /// <exception cref="System.ArgumentOutOfRangeException">Генерируется исключение при попытке задать текущее значение больше чем MaxCapacity</exception>
        public uint CurrentQuantityBanknote
        {
            get
            {
                return currentQuantityBanknote;
            }
            set
            {
                if (value > MaxCapacity)
                    throw new ArgumentOutOfRangeException("Колличество банкнот превышает максимальную емкость картриджа");
                else if (value == 0)
                {
                    isEmpty = true;
                    isFull = false;
                }
                else if (value == MaxCapacity)
                {
                    isEmpty = false;
                    isFull = true;
                }
                else isEmpty = isFull = false;
                currentQuantityBanknote = value;
            }
        }

        /// <summary>
        /// Конструктор класса. Инициализирует автосвойство MaxCapacity в котором задается максимальная вместимость картриджа 
        /// </summary>
        public Cartridge()
        {
            MaxCapacity = SettingsATM.CARTRIDGE_CAPACITY;
        }
    }
}
