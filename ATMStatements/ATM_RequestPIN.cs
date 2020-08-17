namespace ATM_Sim.ATMStatements
{
    ///<inheritdoc/>
    ///<remarks>Класс, устанавливающий поведение элементов управления при введении PIN кода</remarks>
    class ATM_RequestPIN : ATMState
    {
        public ATM_RequestPIN(ATM_UI atm_UI) : base(atm_UI)
        {
        }
        ///<inheritdoc/>
        ///<remarks>Метод записывает в переменную PIN кода символ 0, и отображает на экране символ *.</remarks>
        public override void button0_Click()
        {
            atm_UI.PartPIN = "0";
            atm_UI.PrintPINSign();
        }

        public override void button1000_Click()
        {
        }
        ///<inheritdoc/>
        ///<remarks>Метод записывает в переменную PIN кода символ 1, и отображает на экране символ *.</remarks>
        public override void button1_Click()
        {
            atm_UI.PartPIN = "1";
            atm_UI.PrintPINSign();
        }
        ///<inheritdoc/>
        ///<remarks>Метод записывает в переменную PIN кода символ 2, и отображает на экране символ *.</remarks>
        public override void button2_Click()
        {
            atm_UI.PartPIN = "2";
            atm_UI.PrintPINSign();
        }
        ///<inheritdoc/>
        ///<remarks>Метод записывает в переменную PIN кода символ 3, и отображает на экране символ *.</remarks>
        public override void button3_Click()
        {
            atm_UI.PartPIN = "3";
            atm_UI.PrintPINSign();
        }
        ///<inheritdoc/>
        ///<remarks>Метод записывает в переменную PIN кода символ 4, и отображает на экране символ *.</remarks>
        public override void button4_Click()
        {
            atm_UI.PartPIN = "4";
            atm_UI.PrintPINSign();
        }
        ///<inheritdoc/>
        ///<remarks>Метод записывает в переменную PIN кода символ 5, и отображает на экране символ *.</remarks>
        public override void button5_Click()
        {
            atm_UI.PartPIN = "5";
            atm_UI.PrintPINSign();
        }
        ///<inheritdoc/>
        ///<remarks>Метод записывает в переменную PIN кода символ 6, и отображает на экране символ *.</remarks>
        public override void button6_Click()
        {
            atm_UI.PartPIN = "6";
            atm_UI.PrintPINSign();
        }
        ///<inheritdoc/>
        ///<remarks>Метод записывает в переменную PIN кода символ 7, и отображает на экране символ *.</remarks>
        public override void button7_Click()
        {
            atm_UI.PartPIN = "7";
            atm_UI.PrintPINSign();
        }
        ///<inheritdoc/>
        ///<remarks>Метод записывает в переменную PIN кода символ 8, и отображает на экране символ *.</remarks>
        public override void button8_Click()
        {
            atm_UI.PartPIN = "8";
            atm_UI.PrintPINSign();
        }
        ///<inheritdoc/>
        ///<remarks>Метод записывает в переменную PIN кода символ 9, и отображает на экране символ *.</remarks>
        public override void button9_Click()
        {
            atm_UI.PartPIN = "9";
            atm_UI.PrintPINSign();
        }
        ///<inheritdoc/>
        ///<remarks>Метод возвращает начальное состояние банкомата и извлекает кредитную карту.</remarks>
        public override void buttonCancel_Click()
        {
            atm_UI.StateStartScreen();
        }
        ///<inheritdoc/>
        ///<remarks>Метод удаляет последний введенный с основной клавиатуры символ из переменной где хранится PIN код и перерисовывает основной экран, удаляя *.</remarks>
        public override void buttonClear_Click()
        {
            atm_UI.StringPIN = atm_UI.ClearSign(atm_UI.StringPIN);
            atm_UI.FullPIN = atm_UI.ClearSign(atm_UI.FullPIN);
            atm_UI.textBoxMain.Text = atm_UI.StringPIN;
        }
        ///<inheritdoc/>
        ///<remarks>Метод проверяет введеный PIN код. Если PIN код правильный - банкомат переходит в режим выбора операций.
        ///Если PIN код не правильный  - банкомат переходит в режим запроса на повторный ввод PIN кода</remarks>
        public override void buttonEnter_Click()
        {
            if (atm_UI.account.CheckingPIN(atm_UI.client, atm_UI.FullPIN))
            {
                atm_UI.ATMGeneralScreenOperation(Properties.Resources.ATM_ChoseOperation, atm_UI.textBoxMain, false);
                atm_UI.state = new ATM_ChoseOperation(atm_UI);
            }
            else 
            {
                atm_UI.StateInputPINFault();                
            }
                
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

        public override void cardReader_Click()
        {
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
