using ATM_Sim.CashMachine;

namespace ATM_Sim.ATMStatements
{
    ///<inheritdoc/>
    ///<remarks>Класс, устанавливающий поведение элементов управления при операции снятия денег со счета, колличество которых вводит пользователь</remarks>
    class ATM_WithdrawCashCustom : ATMState
    {
        public ATM_WithdrawCashCustom(ATM_UI atm_UI) : base(atm_UI)
        {
        }
        public override void clientMoney_Click()
        {
        }
        public override void cardReader_Click()
        {
        }
        ///<inheritdoc/>
        ///<remarks>Метод записывает в переменную снятия денег 0, и отображает на экране символ 0.</remarks>
        public override void button0_Click()
        {
            atm_UI.PrintAmountCashEntered(6, "0");
        }
        ///<inheritdoc/>
        ///<remarks>Метод записывает в переменную снятия денег 1, и отображает на экране символ 1.</remarks>
        public override void button1_Click()
        {
            atm_UI.PrintAmountCashEntered(6, "1");
        }
        ///<inheritdoc/>
        ///<remarks>Метод записывает в переменную снятия денег 2, и отображает на экране символ 2.</remarks>
        public override void button2_Click()
        {
            atm_UI.PrintAmountCashEntered(6, "2");
        }
        ///<inheritdoc/>
        ///<remarks>Метод записывает в переменную снятия денег 3, и отображает на экране символ 3.</remarks>
        public override void button3_Click()
        {
            atm_UI.PrintAmountCashEntered(6, "3");
        }
        ///<inheritdoc/>
        ///<remarks>Метод записывает в переменную снятия денег 4, и отображает на экране символ 4.</remarks>
        public override void button4_Click()
        {
            atm_UI.PrintAmountCashEntered(6, "4");
        }
        ///<inheritdoc/>
        ///<remarks>Метод записывает в переменную снятия денег 5, и отображает на экране символ 5.</remarks>
        public override void button5_Click()
        {
            atm_UI.PrintAmountCashEntered(6, "5");
        }
        ///<inheritdoc/>
        ///<remarks>Метод записывает в переменную снятия денег 6, и отображает на экране символ 6.</remarks>
        public override void button6_Click()
        {
            atm_UI.PrintAmountCashEntered(6, "6");
        }
        ///<inheritdoc/>
        ///<remarks>Метод записывает в переменную снятия денег 7, и отображает на экране символ 7.</remarks>
        public override void button7_Click()
        {
            atm_UI.PrintAmountCashEntered(6, "7");
        }
        ///<inheritdoc/>
        ///<remarks>Метод записывает в переменную снятия денег 8, и отображает на экране символ 8.</remarks>
        public override void button8_Click()
        {
            atm_UI.PrintAmountCashEntered(6, "8");
        }
        ///<inheritdoc/>
        ///<remarks>Метод записывает в переменную снятия денег 9, и отображает на экране символ 9.</remarks>
        public override void button9_Click()
        {
            atm_UI.PrintAmountCashEntered(6, "9");
        }
        ///<inheritdoc/>
        ///<remarks>Метод записывает в переменную снятия денег 000, и отображает на экране символы 000.</remarks>
        public override void button1000_Click()
        {
            for (int i = 0; i < 3; i++)
                atm_UI.PrintAmountCashEntered(6, "0");
        }
        ///<inheritdoc/>
        ///<remarks>Метод возвращает начальное состояние банкомата и извлекает кредитную карту.</remarks>
        public override void buttonCancel_Click()
        {
            atm_UI.StateStartScreen();
        }
        ///<inheritdoc/>
        ///<remarks>Метод удаляет последний введенный с основной клавиатуры символ из переменной снятия денег и перерисовывает основной экран, удаляя последний символ с экрана.</remarks>
        public override void buttonClear_Click()
        {
            atm_UI.AmoumtWithdrawCash = atm_UI.ClearSign(atm_UI.AmoumtWithdrawCash);
            atm_UI.textBoxMain.Text = atm_UI.AmoumtWithdrawCash;
            //atm_UI.ReDrawTextBox(atm_UI.textBoxMain, atm_UI.AmoumtWithdrawCash);
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
    }
}
