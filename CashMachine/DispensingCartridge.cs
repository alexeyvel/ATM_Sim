namespace ATM_Sim.CashMachine
{
    ///<inheritdoc/>
    ///<remarks>Этот класс представляет картриджы где храняться деньги только для выдачи</remarks>
    public class DispensingCartridge : Cartridge
    {
        /// <value>Свойство, позволяющее получить номинал купюр</value>
        public Denomination DenominationCash { get; private set; }

        /// <summary>
        /// Конструктор класса. Инициализирует начальное колличество банкнот в картридже и их номинал 
        /// </summary>
        /// <param name="money">Номинальное значение купюры</param>
        /// <param name="currentQuantityBanknote">Колличество банкнот в картридже</param>
        public DispensingCartridge(Denomination money, uint currentQuantityBanknote) : base()
        {
            DenominationCash = money;
            CurrentQuantityBanknote = currentQuantityBanknote;
        }
    }
}
