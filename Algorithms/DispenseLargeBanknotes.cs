using ATM_Sim.CashMachine;
using System.Collections.Generic;

namespace ATM_Sim.Algorithms
{
    /// <summary>
    /// Класс с алгоритмами для выдачи купюр преимущественно мелкого достоинства. 
    /// </summary>
    public class DispenseLargeBanknotes : IDispensingAlgorithm
    {
        ///<inheritdoc/>
        ///<remarks>Метод возвращает список в котором преимущественно купюры мелкого достоинства.</remarks>
        public List<DispensingCartridge> ReturnQuantityBanknote(List<List<DispensingCartridge>> dispensingCartridges)
        {
            // здесь могла бы быть более продвинутая логика выбора крупных купюр
            return dispensingCartridges[dispensingCartridges.Count - 1];
        }
    }
}
