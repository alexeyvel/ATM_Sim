﻿namespace ATM_Sim.ATMStatements
{
    ///<inheritdoc/>
    ///<remarks>Класс, устанавливающий поведение элементов управления при неверно введенном PIN коде</remarks>
    class ATM_InputPINFault : ATMState
    {
        public ATM_InputPINFault(ATM_UI atm_UI) : base(atm_UI)
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
        ///<inheritdoc/>
        ///<remarks>Метод возвращает начальное состояние банкомата и извлекает кредитную карту.</remarks>
        public override void buttonCancel_Click()
        {
            atm_UI.StateStartScreen();
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
        ///<inheritdoc/>
        ///<remarks>Метод возвращает банкомат в состояние запроса PIN кода.</remarks>
        public override void button_display_3_Click()
        {
            atm_UI.StateRequestPIN();           
        }
        public override void button_display_4_Click()
        {
        }
        public override void button_display_5_Click()
        {
        }
        ///<inheritdoc/>
        ///<remarks>Метод возвращает начальное состояние банкомата и извлекает кредитную карту.</remarks>
        public override void button_display_6_Click()
        {
            atm_UI.StateStartScreen();
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
