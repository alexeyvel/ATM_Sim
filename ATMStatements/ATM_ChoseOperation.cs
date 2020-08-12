namespace ATM_Sim.ATMStatements
{
    ///<inheritdoc/>
    ///<remarks>Класс, устанавливающий поведение элементов управления в состоянии выбора операций пользователем</remarks>
    class ATM_ChoseOperation : ATMState
    {
        public ATM_ChoseOperation(ATM_UI atm_UI) : base(atm_UI)
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
            atm_UI.StateCompleteUsed();
            atm_UI.state = new ATM_StartScreen(atm_UI);
        }

        public override void buttonClear_Click()
        {
        }

        public override void buttonEnter_Click()
        {
        }
        ///<inheritdoc/>
        ///<remarks>Метод устанавливает банкомат в состояние проверки баланса.</remarks>
        public override void button_display_1_Click()
        {
            atm_UI.StateCheckBalance();
            atm_UI.state = new ATM_CheckBalance(atm_UI);
        }
        ///<inheritdoc/>
        ///<remarks>Метод пытается установить банкомат в состояние снятия наличных.
        ///Если в банкомате имеется хотя бы 1 банкнота для выдачи - будет установлено состояние снятия наличных.
        ///Иначе банкомат перейдет в состояние недоступности операции снятия</remarks>
        public override void button_display_2_Click()
        {
            if (atm_UI.atm.CheckAllDispensingCartridgeOnEmpty())
            {
                atm_UI.ATMGeneralScreenOperation(Properties.Resources.ATM_OperationFault, atm_UI.textBoxMain, false);
                atm_UI.state = new ATM_OperationFault(atm_UI);
            }
            else
            {
                atm_UI.ATMGeneralScreenOperation(Properties.Resources.ATM_WithdrawCash, atm_UI.textBoxMain, true);
                atm_UI.state = new ATM_WithdrawCash(atm_UI);
            }
        }
        ///<inheritdoc/>
        ///<remarks>Метод устанавливает банкомат в состояние приема наличных.</remarks>
        public override void button_display_3_Click()
        {
            //atm_UI.state = new ATM_PutMoney(atm_UI);
            atm_UI.StatePutMoney();
        }
        ///<inheritdoc/>
        ///<remarks>Метод устанавливает банкомат в состояние запроса лога по операциям клиента.</remarks>
        public override void button_display_4_Click()
        {
            //реализация в процессе...
            atm_UI.ATMGeneralScreenOperation(Properties.Resources.ATM_UnknownStatement, atm_UI.textBoxMain, false);
            atm_UI.state = new ATM_UnknownStatement(atm_UI);
        }
        ///<inheritdoc/>
        ///<remarks>Метод устанавливает банкомат в состояние смены PIN кода.</remarks>
        public override void button_display_5_Click()
        {
            //реализация в процессе...
            atm_UI.ATMGeneralScreenOperation(Properties.Resources.ATM_UnknownStatement, atm_UI.textBoxMain, false);
            atm_UI.state = new ATM_UnknownStatement(atm_UI);
        }
        ///<inheritdoc/>
        ///<remarks>Метод возвращает начальное состояние банкомата и извлекает кредитную карту.</remarks>
        public override void button_display_6_Click()
        {
            atm_UI.StateCompleteUsed();
            atm_UI.state = new ATM_StartScreen(atm_UI);
        }
        public override void creditCard_Click()
        {
        }
        public override void dispensingShutter_Click()
        {
        }
    }
}
