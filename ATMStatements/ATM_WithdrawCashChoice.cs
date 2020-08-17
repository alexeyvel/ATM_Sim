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
        public override void button_display_5_Click()
        {
            atm_UI.StateWithdrawCashSuccess(new DispenseLargeBanknotes());
        }
        ///<inheritdoc/>
        ///<remarks>Метод производит обращение к "серверу" на наличие заппрошенной суммы для снятия на счету у клиента.
        ///В случае успеха устанавливается способ выдачи запрошенной суммы преимущественно мелкими купюрами
        ///и банкомат переходит в состояние выдачи наличных.
        ///В случае провала банкомат переходит в состояние - недостаточно средств на счете</remarks>
        public override void button_display_6_Click()
        {
            atm_UI.StateWithdrawCashSuccess(new DispenseExchange());
        }
        public override void creditCard_Click()
        {
        }
        public override void dispensingShutter_Click()
        {
        }
        public override void clientMoney_Click()
        {
        }
    }
}
