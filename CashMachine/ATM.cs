using ATM_Sim.Server;
using ATM_Sim.Algorithms;
using System;
using System.Collections.Generic;

namespace ATM_Sim.CashMachine
{
    /// <summary>
    /// Класс бизнеслогики банкомата. 
    /// </summary>
    class ATM
    {
        OperationEventArgs args;
        /// <summary>
        /// Событие возникающее при выполнении операций с классом  Account
        /// </summary>
        public event EventHandler<OperationEventArgs> ATMOperation;

        private Account account;
        private DispensingCartridge tempCarttridge;
        private List<DispensingCartridge> availableDispensingCartridges;
        private List<DispensingCartridge> emptyDispensingCartridges;
        private List<List<DispensingCartridge>> allPossibleDispensingСases;
        private IDispensingAlgorithm dispensingAlgorithm;

        public List<Cartridge> Cartridges { get; private set; }
        public List<DispensingCartridge> WithdrawList { get; private set; }

        /// <summary>
        /// Конструктор класса. При создании экземпляра класса банкомата, так же создаются приемный и выдающие наличность картриджы. 
        /// </summary>
        /// <param name="account">Экземпляр класса аккаунт, в котором храняться даннные пользователей</param>
        public ATM(Account account)
        {
            this.account = account;
            Cartridges = new List<Cartridge>();
            Cartridges.Add(new ReceivingCartridge(0));
            foreach (Denomination den in Enum.GetValues(typeof(Denomination)))
                Cartridges.Add(new DispensingCartridge(den, SetRquiredCapacity(den)));
            args = new OperationEventArgs();
        }

        /// <summary>
        /// Метод необходимый для вызова события ATMOperation
        /// </summary>
        /// <param name="e">Параметр, определяющий объект данных события</param>
        private void OnATMOperation(OperationEventArgs e)
        {
            ATMOperation?.Invoke(this, e);
        }

        /// <summary>
        /// Метод позволяющий выбрать алгоритм выдачи наличных 
        /// </summary>
        /// <param name="dispensingAlgorithm">Требуемый алгоритм выдачи наличных</param>
        public void SetDispensingAlgorithm(IDispensingAlgorithm dispensingAlgorithm)
        {
            this.dispensingAlgorithm = dispensingAlgorithm;
        }

        /// <summary>
        /// Метод, устанавливающий требуемую емкость выдающих картриджей в зависимости от номинала купюры 
        /// </summary>
        /// <param name="denomination">Номинал используемых банкнот</param>
        /// <returns>Величина показывающая максимальную емкость картриджа</returns>
        // Для купюр номиналом до 500 включительно максимальная емкость устанавливается из класса настроек банкомата
        // Для купюр номиналом от 1000 и выше максимальная емкость расчитывается как максимальная сумма денег 
        // в картридже (устанавливается из класса настроек банкомата) деленная на номинал купюры
        private uint SetRquiredCapacity(Denomination denomination)
        {
            if (denomination.GetHashCode() > 500)
                return SettingsATM.MAX_CASH_VALUE_IN_CARTRIDGE / (uint)denomination.GetHashCode();
            else return SettingsATM.CARTRIDGE_CAPACITY;
        }

        /// <summary>
        /// Метод, получающий список в котором храняться списки всех возможных комбинаций купюр для выдачи запрошенной суммы.
        /// </summary>
        /// <param name="value">Сумма для выдачи</param>
        /// <returns>Список в котором храняться списки всех возможных комбинаций купюр для выдачи запрошенной суммы</returns>
        // Метод "захардкожен". Писался на скорую руку, что бы проверить. Следует переписать в более универсальном виде.
        // Данный метод используется после того как сумма для снятия была проверена на кратность, на возможность формирования этой суммы купюрами банкомата, 
        // и на наличие этой суммы на счете клиента.
        // Суть метода: Сумма единоразовой выдачи не может быть больше самого большого номинала купюры помноженного на емкость шуттера для выдачи денег
        // Метод перебирает все возможные комбинации выдачи опираясь на то, что колличество купюр не должно превысить емкость шуттера.
        // Создается список временных картриджей куда копируются данные по колличеству банкнот в картриджах банкомата, если банкнот больше чем емкость шуттура, 
        // то во временный картридж заносится величина емкости шуттера. 
        // Далее циклом мы перебираем суммы банкнот во всех картриджах с соблюдением условия не превышения банкнотами емкости шуттера и когда сумма банкнот 
        // равняется запрошенной мы формируем новый список типа DispensingCartridge, куда в качестве свойства CurrentQuantityBanknote заносим получившиеся коэффициенты 
        // полученный список добавляем в список списков :). 
        // Результатом работы данного метода является список из списков всех возможный вариантов комбинаций купюр для выдачи запрошенного зачения
        // Имея все возможные комбинации к выдаче их можно анализировать и настраивать алгоритмы выдачи купюр крупными или с разменом исходя из внешних условий.
        public List<List<DispensingCartridge>> GetAllPossibleDispense(uint value)
        {
            if (GetATMBalance() >= value)
            {
                uint currentSumm;
                List<DispensingCartridge> finalDispensingList;
                allPossibleDispensingСases = new List<List<DispensingCartridge>>();
                var tempDispensingList = new List<DispensingCartridge>();
                for (int i = 0; i < Cartridges.Count; i++)
                {
                    // tempCarttridge = Cartridges[i] as DispensingCartridge;
                    // if (tempCarttridge == null)
                    //    continue;
                    if (Cartridges[i] is DispensingCartridge)
                    {
                        tempCarttridge = new DispensingCartridge(((DispensingCartridge)Cartridges[i]).DenominationCash, Cartridges[i].CurrentQuantityBanknote);
                        if (tempCarttridge.CurrentQuantityBanknote > SettingsATM.SHUTTER_CAPACITY)
                            tempCarttridge.CurrentQuantityBanknote = SettingsATM.SHUTTER_CAPACITY;
                        tempDispensingList.Add(tempCarttridge);
                    }                   
                }
                // перебираем все возможные комбинации. Перебор не универсален. Стоит изменить кол-во номиналов в enum Denomination и все крашнется
                for (int f = 0; f <= tempDispensingList[5].CurrentQuantityBanknote; f++)
                {
                    for (int e = 0; e <= tempDispensingList[4].CurrentQuantityBanknote; e++)
                    {
                        if (e + f > SettingsATM.SHUTTER_CAPACITY)
                            continue;
                        for (int d = 0; d <= tempDispensingList[3].CurrentQuantityBanknote; d++)
                        {
                            if (d + e + f > SettingsATM.SHUTTER_CAPACITY)
                                continue;
                            for (int c = 0; c <= tempDispensingList[2].CurrentQuantityBanknote; c++)
                            {
                                if (c + d + e + f > SettingsATM.SHUTTER_CAPACITY)
                                    continue;
                                for (int b = 0; b <= tempDispensingList[1].CurrentQuantityBanknote; b++)
                                {
                                    if (b + c + d + e + f > SettingsATM.SHUTTER_CAPACITY)
                                        continue;
                                    for (int a = 0; a <= tempDispensingList[0].CurrentQuantityBanknote; a++)
                                    {
                                        if (a + b + c + d + e + f > SettingsATM.SHUTTER_CAPACITY)
                                            continue;
                                        // расчт суммы удовлетворяющий условиям емкости шуттера
                                        currentSumm = (uint)tempDispensingList[0].DenominationCash.GetHashCode() * (uint)a
                                            + (uint)tempDispensingList[1].DenominationCash.GetHashCode() * (uint)b
                                            + (uint)tempDispensingList[2].DenominationCash.GetHashCode() * (uint)c
                                            + (uint)tempDispensingList[3].DenominationCash.GetHashCode() * (uint)d
                                            + (uint)tempDispensingList[4].DenominationCash.GetHashCode() * (uint)e
                                            + (uint)tempDispensingList[5].DenominationCash.GetHashCode() * (uint)f;
                                        // формирование нового списка типа DispensingCartridge куда в качестве свойства CurrentQuantityBanknote 
                                        // заносим получившиеся коэффициенты
                                        if (currentSumm == value)
                                        {
                                            finalDispensingList = new List<DispensingCartridge>();
                                            foreach (Denomination den in Enum.GetValues(typeof(Denomination)))
                                                finalDispensingList.Add(new DispensingCartridge(den, 0));
                                            finalDispensingList[0].CurrentQuantityBanknote = (uint)a;
                                            finalDispensingList[1].CurrentQuantityBanknote = (uint)b;
                                            finalDispensingList[2].CurrentQuantityBanknote = (uint)c;
                                            finalDispensingList[3].CurrentQuantityBanknote = (uint)d;
                                            finalDispensingList[4].CurrentQuantityBanknote = (uint)e;
                                            finalDispensingList[5].CurrentQuantityBanknote = (uint)f;
                                            // добавление получившегося списка в список всех возможный состояний
                                            allPossibleDispensingСases.Add(finalDispensingList);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return allPossibleDispensingСases;
        }

        /// <summary>
        /// Метод, проверяющий возможность банкомата сформировать запрошенную сумму к выдаче.
        /// </summary>
        /// <param name="value">Сумма для выдачи</param>
        /// <returns>true - в случае успешного выполнения, false - в случае невозможности выдачи</returns>
        public bool CheckInputForQuantityInATM(uint value)
        {
            // Суть метода в том, что запрошенную сумму метод делит на свой самый высокий номинал купюры,
            // который в данный момент в наличии и таким образом получает множитель и остаток от деления.
            // Далее полученный множитель сравнивается с колличеством банкнот делителя и если множитель 
            // превышает колличество доступных банкнот делителя, ему присваивается колличество доступных банкнот делителя,
            // и на основании этого пересчитывается остаток от деления путем вычитания из запрошенной суммы множителя умноженного на номинал купюры.
            // К переменной counter прибавляется множитель, а в переменную value ложится остаток от деления.
            // Даннные операции продолжаются циклически с более низкими номиналами пока остаток от деления не станет равным 0;
            // После этого переменная counter сравнивается с максимальной вместимостью шуттера и если она менше или равна ему метод возвращает true,
            // в противном случае false.
            if (GetATMBalance() >= value)
            {
                //локальная переменая - счетчик
                uint counter = 0;
                //локальная переменая - множитель
                uint multiplier;
                //локальная переменая - остаток от деления
                uint remainderOfTheDivision = 1;
                GetAvailableDenomination();
                int count = availableDispensingCartridges.Count;
                for (int i = 0; i < count; i++)
                {
                    multiplier = value / (uint)availableDispensingCartridges[count - 1 - i].DenominationCash.GetHashCode();
                    remainderOfTheDivision = value % (uint)availableDispensingCartridges[count - 1 - i].DenominationCash.GetHashCode();
                    if (multiplier == 0 && remainderOfTheDivision != 0)
                        continue;
                    else if (multiplier > availableDispensingCartridges[count - 1 - i].CurrentQuantityBanknote)
                    {
                        multiplier = availableDispensingCartridges[count - 1 - i].CurrentQuantityBanknote;
                        remainderOfTheDivision = value - (uint)availableDispensingCartridges[count - 1 - i].DenominationCash.GetHashCode() * multiplier;
                        value = remainderOfTheDivision;
                        counter += multiplier;
                    }
                    else
                    {
                        value = remainderOfTheDivision;
                        counter += multiplier;
                    }
                }
                if (remainderOfTheDivision == 0 && counter <= SettingsATM.SHUTTER_CAPACITY)
                    return true;
                else return false;
            }
            else return false;
        }

        /// <summary>
        /// Метод, проверяющий введенную сумму для выдачи на кратность доступным купюрам банкомата.
        /// </summary>
        /// <param name="value">Сумма для выдачи</param>
        /// <returns>true - в случае успешного выполнения, false - в случае невозможности выдачи</returns>
        public bool CheckInputForMultiplicity(uint value)
        {
            GetAvailableDenomination();
            uint result = 0;
            if (value == 0)
                return false;
            foreach (var cartridges in availableDispensingCartridges)
            {
                result = value % (uint)cartridges.DenominationCash.GetHashCode();
                if (result == 0)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Метод, позволяющий получить список картриджей для выдачи, которые не пусты.
        /// </summary>
        /// <returns>Список картриджей для выдачи, колличество купюр в которых больше 0</returns>
        public List<DispensingCartridge> GetAvailableDenomination()
        {
            availableDispensingCartridges = new List<DispensingCartridge>();
            foreach (var cartridge in Cartridges)
            {
                if (cartridge is DispensingCartridge)
                    if (!cartridge.IsEmpty)
                        availableDispensingCartridges.Add((DispensingCartridge)cartridge);
            }
            return availableDispensingCartridges;
        }

        /// <summary>
        /// Метод, позволяющий получить список картриджей для выдачи, которые пусты.
        /// </summary>
        /// <returns>Список картриджей для выдачи, колличество купюр в которых равно 0</returns>
        public List<DispensingCartridge> GetMissingDenomination()
        {
             emptyDispensingCartridges = new List<DispensingCartridge>();
            foreach (var cartridge in Cartridges)
            {
                if (cartridge is DispensingCartridge)
                    if (cartridge.IsEmpty)
                        emptyDispensingCartridges.Add((DispensingCartridge)cartridge);
            }
            return emptyDispensingCartridges;
        }

        /// <summary>
        /// Метод, проверяющий все картриджи для выдачи на то, что они пусты.
        /// </summary>
        /// <returns>true - если колличество купюр во всех картриджах для выдачи равно 0, в обратном случае false</returns>
        public bool CheckAllDispensingCartridgeOnEmpty()
        {
            bool result = true;
            foreach (var cartridge in Cartridges)
            {
                if (cartridge is DispensingCartridge)
                    result &= cartridge.IsEmpty;
            }
            return result;
        }

        /// <summary>
        /// Метод, получающий баланс наличных банкомата.
        /// </summary>
        /// <returns>Величина, показывающая какой суммой распологает банкомат</returns>
        public uint GetATMBalance()
        {
            uint result = 0;
            foreach (var cartridge in Cartridges)
            {
                tempCarttridge = cartridge as DispensingCartridge;
                if (tempCarttridge == null)
                    continue;
                else result += tempCarttridge.CurrentQuantityBanknote * (uint)tempCarttridge.DenominationCash.GetHashCode();
            }
            return result;
        }

        /// <summary>
        /// Перегруженный метод, получающий баланс наличных в каком либо картридже для выдачи.
        /// </summary>
        /// <param name="denomination">Номинал используемых банкнот</param>
        /// <returns>Величина, показывающая какой суммой распологает банкомат</returns>
        public uint GetATMBalance(Denomination denomination)
        {
            uint result = 0;
            foreach (var cartridge in Cartridges)
            {
                tempCarttridge = cartridge as DispensingCartridge;
                if (tempCarttridge == null)
                    continue;
                else
                {
                    if (tempCarttridge.DenominationCash == denomination)
                        result = tempCarttridge.CurrentQuantityBanknote * (uint)tempCarttridge.DenominationCash.GetHashCode();
                }
            }
            return result;
        }

        /// <summary>
        /// Метод, вычитающий требуемое колличество банкнот нужного номинала из своих картриджей при выдачи денег клиенту.
        /// </summary>
        public void DispenseFromATM()
        {
            if ( allPossibleDispensingСases != null && allPossibleDispensingСases.Count > 0 && dispensingAlgorithm != null)
            {
                args.Message = "Всего выдано банкнот:" + Environment.NewLine;
                OnATMOperation(args);
                int i = 0;
                WithdrawList = dispensingAlgorithm.ReturnQuantityBanknote(allPossibleDispensingСases);                
                foreach (var cartridge in Cartridges)
                {
                    if (cartridge is DispensingCartridge)
                    {
                        cartridge.CurrentQuantityBanknote -= WithdrawList[i].CurrentQuantityBanknote;
                        if(WithdrawList[i].CurrentQuantityBanknote > 0)
                        {
                            args.Message = $"{((DispensingCartridge)cartridge).DenominationCash.GetHashCode()} - {WithdrawList[i].CurrentQuantityBanknote} шт." + Environment.NewLine;
                            OnATMOperation(args);
                        }                        
                        i++;
                    }
                }
            }
        }
    }
}
