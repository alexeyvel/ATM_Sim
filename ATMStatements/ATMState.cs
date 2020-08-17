namespace ATM_Sim.ATMStatements
{
    /// <summary>
    /// Класс описывающий поведение элементов управления банкомата исходя из его состояния. 
    /// </summary>
    abstract class ATMState
    {
        //поле класса типа ATM_UI - необходима для механизма агрегации.  
        protected ATM_UI atm_UI;

        /// <summary>
        /// Конструктор класса. Инициализирует поле atm_UI, куда присваивается экземпляр класса отвечающего за UI 
        /// </summary>
        /// <param name="atm_UI">поле для хранения данных экземпляра класса типа ATM_UI</param>
        public ATMState(ATM_UI atm_UI)
        {
            this.atm_UI = atm_UI;
        }
        /// <summary>
        /// Метод отрабатывающий событие клика мыши на выдающем купюры шуттере. 
        /// </summary>
        public abstract void dispensingShutter_Click();
        /// <summary>
        /// Метод отрабатывающий событие клика мыши на кредитной карте. 
        /// </summary>
        public abstract void creditCard_Click();
        /// <summary>
        /// Метод отрабатывающий событие клика мыши на картридере. 
        /// </summary>
        public abstract void cardReader_Click();
        /// <summary>
        /// Метод отрабатывающий событие клика мыши на клавиши "0" основной клавиатуры. 
        /// </summary>
        public abstract void button0_Click();
        /// <summary>
        /// Метод отрабатывающий событие клика мыши на клавиши "1" основной клавиатуры. 
        /// </summary>
        public abstract void button1_Click();
        /// <summary>
        /// Метод отрабатывающий событие клика мыши на клавиши "2" основной клавиатуры. 
        /// </summary>
        public abstract void button2_Click();
        /// <summary>
        /// Метод отрабатывающий событие клика мыши на клавиши "3" основной клавиатуры. 
        /// </summary>
        public abstract void button3_Click();
        /// <summary>
        /// Метод отрабатывающий событие клика мыши на клавиши "4" основной клавиатуры. 
        /// </summary>
        public abstract void button4_Click();
        /// <summary>
        /// Метод отрабатывающий событие клика мыши на клавиши "5" основной клавиатуры. 
        /// </summary>
        public abstract void button5_Click();
        /// <summary>
        /// Метод отрабатывающий событие клика мыши на клавиши "6" основной клавиатуры. 
        /// </summary>
        public abstract void button6_Click();
        /// <summary>
        /// Метод отрабатывающий событие клика мыши на клавиши "7" основной клавиатуры. 
        /// </summary>
        public abstract void button7_Click();
        /// <summary>
        /// Метод отрабатывающий событие клика мыши на клавиши "8" основной клавиатуры. 
        /// </summary>
        public abstract void button8_Click();
        /// <summary>
        /// Метод отрабатывающий событие клика мыши на клавиши "9" основной клавиатуры. 
        /// </summary>
        public abstract void button9_Click();
        /// <summary>
        /// Метод отрабатывающий событие клика мыши на клавиши "000" основной клавиатуры. 
        /// </summary>
        public abstract void button1000_Click();
        /// <summary>
        /// Метод отрабатывающий событие клика мыши на клавиши "CANCEL" основной клавиатуры. 
        /// </summary>
        public abstract void buttonCancel_Click();
        /// <summary>
        /// Метод отрабатывающий событие клика мыши на клавиши "CLEAR" основной клавиатуры. 
        /// </summary>
        public abstract void buttonClear_Click();
        /// <summary>
        /// Метод отрабатывающий событие клика мыши на клавиши "ENTER" основной клавиатуры. 
        /// </summary>
        public abstract void buttonEnter_Click();
        /// <summary>
        /// Метод отрабатывающий событие клика мыши на клавиши левой верхней клавиши клавиатуры экрана. 
        /// </summary>
        public abstract void button_display_1_Click();
        /// <summary>
        /// Метод отрабатывающий событие клика мыши на клавиши левой средней клавиши клавиатуры экрана. 
        /// </summary>
        public abstract void button_display_2_Click();
        /// <summary>
        /// Метод отрабатывающий событие клика мыши на клавиши левой нижней клавиши клавиатуры экрана. 
        /// </summary>
        public abstract void button_display_3_Click();
        /// <summary>
        /// Метод отрабатывающий событие клика мыши на клавиши правой верхней клавиши клавиатуры экрана. 
        /// </summary>
        public abstract void button_display_4_Click();
        /// <summary>
        /// Метод отрабатывающий событие клика мыши на клавиши правой средней клавиши клавиатуры экрана. 
        /// </summary>
        public abstract void button_display_5_Click();
        /// <summary>
        /// Метод отрабатывающий событие клика мыши на клавиши правой нижней клавиши клавиатуры экрана. 
        /// </summary>
        public abstract void button_display_6_Click();

        /// <summary>
        /// Метод отрабатывающий событие клика мыши на стопке денег.
        /// </summary>
        public abstract void clientMoney_Click();
    }
}
