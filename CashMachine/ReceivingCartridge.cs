namespace ATM_Sim.CashMachine
{
    ///<inheritdoc/>
    ///<remarks>Этот класс представляет картриджы предназначенные только для приема купюр</remarks>
    public class ReceivingCartridge : Cartridge
    {
        /// <summary>
        /// Конструктор класса. Инициализирует начальное колличество банкнот в картридже 
        /// </summary>
        /// <param name="currentQuantityBanknote">Колличество банкнот в картридже</param>
        public ReceivingCartridge(uint currentQuantityBanknote) : base()
        {
            CurrentQuantityBanknote = currentQuantityBanknote;
        }
    }
}
