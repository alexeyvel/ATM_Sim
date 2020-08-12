using ATM_Sim.Algorithms;
using System.Threading.Tasks;

namespace ATM_Sim.ATMStatements
{
    ///<inheritdoc/>
    ///<remarks>Класс, устанавливающий поведение элементов управления при операции выбора выдачи купюр (крупными или с разменом)</remarks>
    class ATM_WithdrawCashChoice : ATMState
    {
        public ATM_WithdrawCashChoice(ATM_UI atm_UI) : base(atm_UI)
        {
        }
        public override void cardReader_Click()
        {
        }
        public override void button0_Click()
        {
        }

        public override void button1_Click()
        {
        }

        public override void button2_Click()
        {
        }

        public override void button3_Click()
        {
        }

        public override void button4_Click()
        {
        }

        public override void button5_Click()
        {
        }

        public override void button6_Click()
        {
        }

        public override void button7_Click()
        {
        }

        public override void button8_Click()
        {
        }

        public override void button9_Click()
        {
        }

        public override void button1000_Click()
        {
        }

        public override void buttonCancel_Click()
        {
        }

        public override void buttonClear_Click()
        {
        }

        public override void buttonEnter_Click()
        {
        }

        public override void button_display_1_Click()
        {
        }
        public override void button_display_2_Click()
        {
        }
        public override void button_display_3_Click()
        {
        }
        public override void button_display_4_Click()
        {
        }
        ///<inheritdoc/>
        ///<remarks>Метод производит обращение к "серверу" на наличие заппрошенной суммы для снятия на счету у клиента.
        ///В случае успеха устанавливается способ выдачи запрошенной суммы преимущественно крупными купюрами
        ///и банкомат переходит в состояние выдачи наличных.
        ///В случае провала банкомат переходит в состояние - недостаточно средств на счете</remarks>
        public override async void button_display_5_Click()
        {
            if (atm_UI.account.Withdraw(uint.Parse(atm_UI.AmoumtWithdrawCash), atm_UI.client))
            {               
                atm_UI.ATMGeneralScreenOperation(Properties.Resources.ATM_WithdrawCashSuccess, atm_UI.textBoxMain, false);
                //atm_UI.atm.GetAllPossibleDispense(uint.Parse(atm_UI.amoumtWithdrawCash));
                await Task.Run(() => {atm_UI.atm.GetAllPossibleDispense(uint.Parse(atm_UI.AmoumtWithdrawCash));});
                atm_UI.atm.SetDispensingAlgorithm(new DispenseLargeBanknotes());
                atm_UI.atm.DispenseFromATM();
                atm_UI.ShowATMSettings();
                atm_UI.SetCardReaderState(Properties.Resources.CartReaderCard);
                atm_UI.state = new ATM_WithdrawCashSuccess(atm_UI);
            }
            else
            {               
                atm_UI.ATMGeneralScreenOperation(Properties.Resources.ATM_WithdrawCashFailure1, atm_UI.textBoxMain, false);
                atm_UI.state = new ATM_WithdrawCashFailure1(atm_UI);
            }
        }
        ///<inheritdoc/>
        ///<remarks>Метод производит обращение к "серверу" на наличие заппрошенной суммы для снятия на счету у клиента.
        ///В случае успеха устанавливается способ выдачи запрошенной суммы преимущественно мелкими купюрами
        ///и банкомат переходит в состояние выдачи наличных.
        ///В случае провала банкомат переходит в состояние - недостаточно средств на счете</remarks>
        public override async void button_display_6_Click()
        {
            if (atm_UI.account.Withdraw(uint.Parse(atm_UI.AmoumtWithdrawCash), atm_UI.client))
            {
                atm_UI.ATMGeneralScreenOperation(Properties.Resources.ATM_WithdrawCashSuccess, atm_UI.textBoxMain, false);
                //atm_UI.atm.GetAllPossibleDispense(uint.Parse(atm_UI.amoumtWithdrawCash));
                await Task.Run(() => { atm_UI.atm.GetAllPossibleDispense(uint.Parse(atm_UI.AmoumtWithdrawCash)); });
                atm_UI.atm.SetDispensingAlgorithm(new DispenseExchange());
                atm_UI.atm.DispenseFromATM();
                atm_UI.ShowATMSettings();
                atm_UI.SetCardReaderState(Properties.Resources.CartReaderCard);
                atm_UI.state = new ATM_WithdrawCashSuccess(atm_UI);
            }
            else
            {
                atm_UI.ATMGeneralScreenOperation(Properties.Resources.ATM_WithdrawCashFailure1, atm_UI.textBoxMain, false);
                atm_UI.state = new ATM_WithdrawCashFailure1(atm_UI);
            }
        }
        public override void creditCard_Click()
        {
        }
        public override void dispensingShutter_Click()
        {
        }
    }
}
