namespace ATM_Sim.ATMStatements
{
    ///<inheritdoc/>
    ///<remarks>Класс, устанавливающий поведение элементов управления при операции снятия денег со счета, 
    ///когда банкомат не может выдать запрошенную сумму (нет нужного колличества купур, сумма, запрошенная пользователем не собирается)</remarks>
    class ATM_WithdrawCashFailure3 : ATMState
    {
        public ATM_WithdrawCashFailure3(ATM_UI atm_UI) : base(atm_UI)
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
        ///<remarks>Метод устанавливает банкомат в режим выбора операций.</remarks>
        public override void button_display_3_Click()
        {
            atm_UI.ATMGeneralScreenOperation(null, atm_UI.textBox_MultipleCash, false);
            atm_UI.ATMGeneralScreenOperation(Properties.Resources.ATM_ChoseOperation, atm_UI.textBoxMain, false);
            atm_UI.state = new ATM_ChoseOperation(atm_UI);
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
