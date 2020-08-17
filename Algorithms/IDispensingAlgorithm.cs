using ATM_Sim.CashMachine;
using System.Collections.Generic;

namespace ATM_Sim.Algorithms
{
    /// <summary>
    /// Интерфейс обязующий реализовать метод, который возвращает список c колличеством купюр разного номинала. 
    /// </summary>
    public interface IDispensingAlgorithm
    {
        /// <summary>
        /// метод, который возвращает список c колличеством купюр разного номинала согласно выбранного алгоритма. 
        /// </summary>
        /// /// <param name="dispensingCartridges">Список в котором храняться списки всех возможных комбинаций колличества купюр и их номинала</param>
        /// <returns>Список c колличеством купюр разного номинала согласно выбранного алгоритма</returns>
        List<DispensingCartridge> ReturnQuantityBanknote(List<List<DispensingCartridge>> dispensingCartridges);
    }
}
