using ATM_Sim.ATMStatements;
using ATM_Sim.CashMachine;
using ATM_Sim.Server;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ATM_Sim
{
    public partial class ATM_UI : Form
    {

        public readonly string signPIN = "*";
        public string StringPIN { get; set; }
        public string FullPIN { get; set; }
        public string PartPIN { get; set; }
        public string AmoumtWithdrawCash { get; set; } = "0";

        internal Client client;
        internal Account account;
        internal ATM atm;
        internal ATMState state;
        public ATM_UI()
        {
            InitializeComponent();
            account = new Account();
            StartATMCondition();
            ShowATMSettings();
            state = new ATM_StartScreen(this);
        }
        /// <summary>
        /// Метод задания начального состояния банкомата. Инициализирует новый экземпляр класса банкомата, 
        /// и отображает стартовое состояние основного диспдея банкомата
        /// </summary>
        private void StartATMCondition()
        {
            atm = new ATM(account);
            panelMainDisplay.BackgroundImage = Properties.Resources.ATM_StartScreen;
        }
        /// <summary>Метод позволяющий менять картинки картридера.</summary>
        // Возможно можно было просто объявить поле cardReader публичным и не парится
        public void SetCardReaderState(Bitmap currentImage)
        {
            cardReader.Image = currentImage;
        }
        /// <summary>Метод позволяющий менять картинки выдающего шуттера.</summary>
        // Возможно можно было просто объявить поле dispensingShutter публичным и не парится
        public void SetDispensingShutterState(Bitmap currentImage)
        {
            dispensingShutter.Image = currentImage;
        }
        /// <summary>Метод позволяющий менять картинки принимающего шуттера.</summary>
        // Возможно можно было просто объявить поле  receivingShutter публичным и не парится
        public void SetReceivingShutterState(Bitmap currentImage)
        {
            receivingShutter.Image = currentImage;
        }
        /// <summary>Метод меняющий видимость кредитной карты.</summary>
        // Возможно можно было просто объявить поле  creditCard публичным и не парится
        public void ShowCreditCard(bool visible)
        {
            creditCard.Visible = visible;
        }
        /// <summary>Метод перерисовывающий экран на экран запроса PIN кода и инициализирующий свойства необзодимые для ввода и считывания PIN кода.</summary>
        public void StateRequestPIN()
        {
            ATMGeneralScreenOperation(Properties.Resources.ATM_RequestPIN, textBoxMain, true);
            StringPIN = "";
            FullPIN = "";
        }
        /// <summary>Метод перерисовывающий экран на экран ошибки ввода PIN кода и инициализирующий свойства необзодимые для ввода и считывания PIN кода.</summary>
        public void StateInputPINFault()
        {
            ATMGeneralScreenOperation(Properties.Resources.ATM_InputPINFault, textBoxMain, false);
            StringPIN = "";
            FullPIN = "";
        }
        /// <summary>Метод перерисовывающий экран на экран приема наличных от клиента, также производит смену состояния.</summary>
        // подумать, где лучше размещать операцию по смене состояния банкоматом. Тут или в классах состояния.
        public void StatePutMoney()
        {
            ATMGeneralScreenOperation(Properties.Resources.ATM_PutMoney, textBoxMain, false);
            SetReceivingShutterState(Properties.Resources.ReceivingShutterActiv);          
            SwitchSettingsQuantityBanknote(true, splitContainer2.Panel2);
            buttonPutMoney.Enabled = true;
            state = new ATM_PutMoney(this);
        }

        /// <summary>Метод перерисовывающий экран на экран завершения обслуживания.</summary>
        public void StateCompleteUsed()
        {
            LockSettingButtons(true);
            ATMGeneralScreenOperation(null, textBox_MultipleCash, false);
            creditCard.Visible = true;
            cardReader.Image = Properties.Resources.CartReaderActiv;
            ATMGeneralScreenOperation(Properties.Resources.ATM_StartScreen, textBoxMain, false);
        }



        public void ATMGeneralScreenOperation(Bitmap currentScreeen, TextBox text, bool visible)
        {
            panelMainDisplay.BackgroundImage = currentScreeen;
            text.Clear();
            text.Visible = visible;
            panelMainDisplay.Refresh();
        }

        public void StateCheckBalance()
        {
            panelMainDisplay.BackgroundImage = Properties.Resources.ATM_CheckBalance;
            ReDrawTextBox(textBoxMain, account.ReturnBalance(client).ToString());
            textBoxMain.Visible = true;
        }

        public void PrintAvailableDenomination(TextBox text)
        {
            text.Clear();
            text.Visible = true;
            foreach (var denomination in atm.GetAvailableDenomination())
            {
                text.Text += denomination.DenominationCash.GetHashCode() + ", ";
            }
        }
        public void PrintPresetAmmountMoney(string value)
        {
            AmoumtWithdrawCash = value;
            ReDrawTextBox(textBoxMain, value);
        }
        public void PrintAmountCashEntered(uint limit, string number)
        {
            if (AmoumtWithdrawCash.Length < limit)
            {
                AmoumtWithdrawCash += number;
                textBoxMain.Text += number;
            }
        }
        public void PrintPINSign()
        {
            if (StringPIN.Length < 4)
            {
                StringPIN += signPIN;
                textBoxMain.Text += signPIN;
                FullPIN += PartPIN;
            }
        }
        public string ClearSign(string word)
        {
            if (word.Length > 0)
                return word.Remove(word.Length - 1, 1);
            else return word;
        }
        public void ReDrawTextBox(TextBox textBox, string message)
        {
            textBox.Clear();
            textBox.Text = message;
        }
        private void creditCard_Click(object sender, EventArgs e)
        {
            state.creditCard_Click();
        }
        public void cardReader_Click(object sender, EventArgs e)
        {
            state.cardReader_Click();
        }
        private void dispensingShutter_Click(object sender, EventArgs e)
        {
            state.dispensingShutter_Click();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            state.button0_Click();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            state.button1_Click();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            state.button2_Click();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            state.button3_Click();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            state.button4_Click();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            state.button5_Click();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            state.button6_Click();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            state.button7_Click();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            state.button8_Click();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            state.button9_Click();
        }

        private void button1000_Click(object sender, EventArgs e)
        {
            state.button1000_Click();
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            state.buttonCancel_Click();
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            state.buttonClear_Click();
        }
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            state.buttonEnter_Click();
        }
        private void button_display_1_Click(object sender, EventArgs e)
        {
            state.button_display_1_Click();
        }
        private void button_display_2_Click(object sender, EventArgs e)
        {
            state.button_display_2_Click();
        }
        private void button_display_3_Click(object sender, EventArgs e)
        {
            state.button_display_3_Click();
        }

        private void button_display_4_Click(object sender, EventArgs e)
        {
            state.button_display_4_Click();
        }

        private void button_display_5_Click(object sender, EventArgs e)
        {
            state.button_display_5_Click();
        }
        private void button_display_6_Click(object sender, EventArgs e)
        {
            state.button_display_6_Click();
        }



        //########################################################################
        public void ShowATMSettings()
        {
            foreach (Control el in splitContainer2.Panel1.Controls)
            {
                if (el is TextBox)
                {
                    foreach (Denomination den in Enum.GetValues(typeof(Denomination)))
                    {
                        if (el.Tag.ToString() == den.GetHashCode().ToString())
                            el.Text = atm.GetATMBalance(den).ToString();
                    }
                }
                else if (el is NumericUpDown)
                {
                    foreach (Cartridge cartridge in atm.Cartridges)
                    {
                        if (cartridge is DispensingCartridge)
                        {
                            if (el.Tag.ToString() == ((DispensingCartridge)cartridge).DenominationCash.GetHashCode().ToString())
                                ((NumericUpDown)el).Value = cartridge.CurrentQuantityBanknote;
                        }
                        else ((NumericUpDown)el).Value = cartridge.CurrentQuantityBanknote;
                    }
                }
            }
            textTotalATMBalance.Text = atm.GetATMBalance().ToString();
        }
        private void SwitchSettingsQuantityBanknote(bool value, SplitterPanel panel)
        {
            foreach (Control obj in panel.Controls)
            {
                if (obj is NumericUpDown)
                {
                    obj.Enabled = value;
                }
            }
        }
        public void LockSettingButtons(bool value)
        {
            buttonCreateNewClient.Enabled = value;
            buttonManualSetting.Enabled = value;
            buttonConfirmSettings.Enabled = value;
            buttonResetDefault.Enabled = value;
        }
        private void buttonManualSetting_Click(object sender, EventArgs e)
        {
            SwitchSettingsQuantityBanknote(true, splitContainer2.Panel1);
        }

        private void buttonConfirmSettings_Click(object sender, EventArgs e)
        {
            SwitchSettingsQuantityBanknote(false, splitContainer2.Panel1);
            foreach (Control el in splitContainer2.Panel1.Controls)
            {
                if (el is NumericUpDown)
                {
                    foreach (Cartridge cartridge in atm.Cartridges)
                    {
                        if (cartridge is DispensingCartridge)
                        {
                            if (el.Tag.ToString() == ((DispensingCartridge)cartridge).DenominationCash.GetHashCode().ToString())
                                cartridge.CurrentQuantityBanknote = (uint)((NumericUpDown)el).Value;
                        }
                    }
                }
            }
        }

        private void getBalanceButt_Click(object sender, EventArgs e)
        {
            textTotalATMBalance.Text = atm.GetATMBalance().ToString();
        }

        private void NumericChanged(object sender, EventArgs e)
        {
            if (sender is NumericUpDown)
            {
                decimal balance = 0;
                var obj = sender as NumericUpDown;
                foreach (Control el in splitContainer2.Panel1.Controls)
                {
                    if (el is TextBox)
                    {
                        if (el.Tag == obj.Tag)
                        {
                            el.Text = (obj.Value * int.Parse(obj.Tag.ToString())).ToString();
                        }
                    }
                    if (el is NumericUpDown)
                    {
                        balance += ((NumericUpDown)el).Value * int.Parse(el.Tag.ToString());
                    }
                }
                textTotalATMBalance.Text = balance.ToString();
            }
        }

        private void buttonCreateNewClient_Click(object sender, EventArgs e)
        {
            client = new Client();
            account.AddNewClient(client);
            creditCard.Visible = true;
            textClientInfo.Text = client.Name + " " + client.Patrinymic + " " + client.Surname + Environment.NewLine +
                "ID: " + client.ID.ToString() + Environment.NewLine +
              "PIN: " + client.PIN + Environment.NewLine + "Текущий баланс: " + client.HasMoney.ToString() + Environment.NewLine;
        }



        private void buttonResetToDefault_Click(object sender, EventArgs e)
        {
            foreach (var cartridge in atm.Cartridges)
            {
                if (cartridge is ReceivingCartridge)
                    cartridge.CurrentQuantityBanknote = 0;
                else if (cartridge is DispensingCartridge)
                {
                    if (((DispensingCartridge)cartridge).DenominationCash.GetHashCode() > 500)
                        cartridge.CurrentQuantityBanknote = SettingsATM.MAX_CASH_VALUE_IN_CARTRIDGE / (uint)((DispensingCartridge)cartridge).DenominationCash.GetHashCode();
                    else cartridge.CurrentQuantityBanknote = SettingsATM.CARTRIDGE_CAPACITY;
                }
            }
            ShowATMSettings();
        }

        private void buttonPutMoney_Click(object sender, EventArgs e)
        {
            //реализация в процессе
        }

    }
}
