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
            throw new NotImplementedException();
        }
        public override void button0_Click()
        {
            throw new NotImplementedException();
        }

        public override void button1_Click()
        {
            throw new NotImplementedException();
        }

        public override void button2_Click()
        {
            throw new NotImplementedException();
        }

        public override void button3_Click()
        {
            throw new NotImplementedException();
        }

        public override void button4_Click()
        {
            throw new NotImplementedException();
        }

        public override void button5_Click()
        {
            throw new NotImplementedException();
        }

        public override void button6_Click()
        {
            throw new NotImplementedException();
        }

        public override void button7_Click()
        {
            throw new NotImplementedException();
        }

        public override void button8_Click()
        {
            throw new NotImplementedException();
        }

        public override void button9_Click()
        {
            throw new NotImplementedException();
        }

        public override void button1000_Click()
        {
            throw new NotImplementedException();
        }

        public override void buttonCancel_Click()
        {
            throw new NotImplementedException();
        }

        public override void buttonClear_Click()
        {
            throw new NotImplementedException();
        }

        public override void buttonEnter_Click()
        {
            throw new NotImplementedException();
        }

        public override void button_display_1_Click()
        {
            throw new NotImplementedException();
        }
        public override void button_display_2_Click()
        {
            throw new NotImplementedException();
        }
        public override void button_display_3_Click()
        {
            throw new NotImplementedException();
        }
        public override void button_display_4_Click()
        {
            throw new NotImplementedException();
        }
        public override void button_display_5_Click()
        {
            throw new NotImplementedException();
        }
        public override void button_display_6_Click()
        {
            throw new NotImplementedException();
        }
        public override void creditCard_Click()
        {
        }
        public override void dispensingShutter_Click()
        {
        }
    }
}
