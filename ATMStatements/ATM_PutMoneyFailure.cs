using ATM_Sim.CashMachine;
using System;

namespace ATM_Sim.ATMStatements
{
    ///<inheritdoc/>
    ///<remarks>Класс, устанавливающий поведение элементов управления при невозможности внести деньги на счет 
    ///(кол-во купюр вложенных в купюроприемник превышает возможности приемного лотка)</remarks>
    class ATM_PutMoneyFailure : ATMState
    {
        public ATM_PutMoneyFailure(ATM_UI atm_UI) : base(atm_UI)
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
            if (!atm_UI.ReceivingShutter)
            {
                atm_UI.StateStartScreen();
            }
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
            if (!atm_UI.ReceivingShutter)
            {
                atm_UI.StateChoseOperation();
            }
        }
        public override void button_display_4_Click()
        {
        }
        public override void button_display_5_Click()
        {
        }
        public override void button_display_6_Click()
        {
            if (!atm_UI.ReceivingShutter)
            {
                atm_UI.StateStartScreen();
            }
        }
        public override void creditCard_Click()
        {
        }
        public override void dispensingShutter_Click()
        {
        }
        public override void clientMoney_Click()
        {
            atm_UI.SetReceivingShutterState(Properties.Resources.ReceivingShutterPasiv);
            if (atm_UI.ReceivingShutter)
                atm_UI.ClearReceivingShutter();
        }
    }
}
