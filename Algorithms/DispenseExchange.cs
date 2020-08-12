using ATM_Sim.CashMachine;
using System.Collections.Generic;

namespace ATM_Sim.Algorithms
{
    /// <summary>
    /// Класс с алгоритмами для выдачи купюр преимущественно крупного достоинства. 
    /// </summary>
    class DispenseExchange : IDispensingAlgorithm
    {
        ///<inheritdoc/>
        ///<remarks>Метод возвращает список в котором преимущественно купюры крупного достоинства.</remarks>
        public List<DispensingCartridge> ReturnQuantityBanknote(List<List<DispensingCartridge>> dispensingCartridges)
        {
            // здесь могла бы быть более продвинутая логика выбора мелких купюр
            return dispensingCartridges[0];
        }
    }
}
