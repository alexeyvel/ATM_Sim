namespace ATM_Sim.ATMStatements
{
    ///<inheritdoc/>
    ///<remarks>Класс, устанавливающий поведение элементов управления при операции снятия денег со счета из зарянее подготовленных пресетов</remarks>
    class ATM_WithdrawCash : ATMState
    {
        public ATM_WithdrawCash(ATM_UI atm_UI) : base(atm_UI)
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
        ///<inheritdoc/>
        ///<remarks>Метод удаляет выбранную из пресетов сумму для снятия.</remarks>
        public override void buttonClear_Click()
        {
            atm_UI.PrintPresetAmmountMoney("");
        }
        ///<inheritdoc/>
        ///<remarks>Метод проверяет введенную пользователем сумму для снятия на возможность формирования запрошенной суммы из купюр в наличии.
        ///В случае успеха банкомат переходит в состояние выбора способа получения денег (крупными или с разменом).
        ///В случае провала метод проверяет введенную пользователем сумму на кратность доступным купюрам и на возможность составления запрошенной суммы из купюр в наличии.
        ///Если проверка кратности не пройдена банкомат перейдет в состояние ошибки кратности.
        ///В противном случае банкомат перейдет в состояние ошибки по наличию доступных к формированию сумммы купюр</remarks>
        public override void buttonEnter_Click()
        {
            atm_UI.StateWithdrawCashChoice();
        }
        ///<inheritdoc/>
        ///<remarks>Метод устанавливает сумму для снятия в размере 200 у.е.</remarks>
        public override void button_display_1_Click()
        {
            atm_UI.PrintPresetAmmountMoney("200");
        }
        ///<inheritdoc/>
        ///<remarks>Метод устанавливает сумму для снятия в размере 500 у.е.</remarks>
        public override void button_display_2_Click()
        {
            atm_UI.PrintPresetAmmountMoney("500");
        }
        ///<inheritdoc/>
        ///<remarks>Метод устанавливает сумму для снятия в размере 1000 у.е.</remarks>
        public override void button_display_3_Click()
        {
            atm_UI.PrintPresetAmmountMoney("1000");
        }
        ///<inheritdoc/>
        ///<remarks>Метод устанавливает сумму для снятия в размере 2000 у.е.</remarks>
        public override void button_display_4_Click()
        {
            atm_UI.PrintPresetAmmountMoney("2000");
        }
        ///<inheritdoc/>
        ///<remarks>Метод устанавливает сумму для снятия в размере 5000 у.е.</remarks>
        public override void button_display_5_Click()
        {
            atm_UI.PrintPresetAmmountMoney("5000");
        }
        ///<inheritdoc/>
        ///<remarks>Метод очищает переменную для хранения суммы снятия и переводит банкомат в режим ручного ввода требуемой суммы .</remarks>
        public override void button_display_6_Click()
        {
            atm_UI.AmoumtWithdrawCash = "";
            atm_UI.PrintAvailableDenomination(atm_UI.textBox_MultipleCash);
            atm_UI.ATMGeneralScreenOperation(Properties.Resources.ATM_WithdrawCashCustom, atm_UI.textBoxMain, true);
            atm_UI.state = new ATM_WithdrawCashCustom(atm_UI);
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
