namespace ATM_Sim.CashMachine
{
    /// <summary>
    /// Класс общих нстроек банкомата. 
    /// </summary>
    class SettingsATM
    {
        /// <summary>
        /// Максимальная емкость в купюрах для картриджа. 
        /// </summary>
        public const uint CARTRIDGE_CAPACITY = 2500;
        /// <summary>
        /// Максимальная суммма денег в картридже. 
        /// </summary>
        public const uint MAX_CASH_VALUE_IN_CARTRIDGE = 1_000_000;
        /// <summary>
        /// Максимальная емкость купюр шуттера для приема/выдачи денег. 
        /// </summary>
        public const uint SHUTTER_CAPACITY = 40;
        /// <summary>
        /// Колличество символов в PIN коде. 
        /// </summary>
        public const uint PIN_CODE_NUMBER_OF_SIGN = 4;
    }
}
