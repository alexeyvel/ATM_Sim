namespace ATM_Sim.ATMStatements
{
    ///<inheritdoc/>
    ///<remarks>Класс, устанавливающий поведение элементов управления при после успешной операции снятия денег со счета</remarks>
    class ATM_WithdrawCashSuccess : ATMState
    {
        public ATM_WithdrawCashSuccess(ATM_UI atm_UI) : base(atm_UI)
        {
        }
        ///<inheritdoc/>
        ///<remarks>Метод устанавливает банкомат в режим "забрать деньги из шуттера выдачи".
        ///Дополнительно перерисовывает картридер, шуттер выдачи денег и отображает кредитную карту</remarks>
        public override void cardReader_Click()
        {
            atm_UI.SetCardReaderState(Properties.Resources.CartReaderPasiv);
            atm_UI.ShowCreditCard(true);
            atm_UI.SetDispensingShutterState(Properties.Resources.DispensShutterOn);
            atm_UI.state = new ATM_TakeTheMoney(atm_UI);
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
        public override void button_display_5_Click()
        {
        }
        public override void button_display_6_Click()
        {
        }

        public override void creditCard_Click()
        {
        }
        public override void dispensingShutter_Click()
        {
        }
    }
}
