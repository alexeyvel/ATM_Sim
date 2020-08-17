using ATM_Sim.Algorithms;
using ATM_Sim.ATMStatements;
using ATM_Sim.CashMachine;
using ATM_Sim.Server;
using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Sim
{
    /// <summary>
    /// Класс отвечающий за UI банкомата
    /// </summary>
    public partial class ATM_UI : Form
    {
        /// <summary>Сигнатура PIN кода, для отображения на экране</summary>
        public readonly string signPIN = "*";
        /// <value>Свойство, в котором хранится сигнатура PIN кода</value>
        public string StringPIN { get; set; }
        /// <value>Свойство, в котором хранится PIN код</value>
        public string FullPIN { get; set; }
        /// <value>Свойство, в котором хранится число - результат последенего нажатия на клавиатуре при вводе PIN кода</value>
        public string PartPIN { get; set; }
        /// <value>Свойство, в котором хранится сумма для сниятия</value>
        public string AmoumtWithdrawCash { get; set; }

        /// <value>Свойство, показывающее есть ли купюры в приемном лотке или нет</value>
        public bool ReceivingShutter { get; private set; } = false;

        internal Client client;
        internal Account account;
        internal ATM atm;
        internal ATMState state;
        public ATM_UI()
        {
            InitializeComponent();
            account = new Account();
            StartATMCondition();
            account.AccountOperation += GenerateServiceMessageWithTime;
            atm.ATMOperation += GenerateServiceMessage;
            ShowATMSettings();
            ShowClientSettings(splitContainer2.Panel2);
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
        public void SetCardReaderState(Bitmap currentImage)
        {
            cardReader.Image = currentImage;
        }

        /// <summary>Метод позволяющий менять картинки выдающего шуттера.</summary>
        public void SetDispensingShutterState(Bitmap currentImage)
        {
            dispensingShutter.Image = currentImage;
        }

        /// <summary>Метод позволяющий менять картинки принимающего шуттера.</summary>
        public void SetReceivingShutterState(Bitmap currentImage)
        {
            receivingShutter.Image = currentImage;
        }

        /// <summary>Метод меняющий видимость кредитной карты.</summary>
        public void ShowCreditCard(bool visible)
        {
            creditCard.Visible = visible;
        }

        /// <summary>Метод меняющий видимость денег которые клиент собирается внести на счет.</summary>
        public void ShowClientMoney(bool visible)
        {
            clientMoney.Visible = visible;
        }
        /// <summary>Метод переводящий текущее состояние банкомата в состояние запроса PIN кода, и инициализирующий свойства необходимые для ввода и считывания PIN кода.</summary>
        public void StateRequestPIN()
        {
            ATMGeneralScreenOperation(Properties.Resources.ATM_RequestPIN, textBoxMain, true);
            StringPIN = "";
            FullPIN = "";
            state = new ATM_RequestPIN(this);
        }

        /// <summary>Метод переводящий текущее состояние банкомата в состояние ошибки ввода PIN кода, и инициализирующий свойства необходимые для ввода и считывания PIN кода.</summary>
        public void StateInputPINFault()
        {
            ATMGeneralScreenOperation(Properties.Resources.ATM_InputPINFault, textBoxMain, false);
            StringPIN = "";
            FullPIN = "";
            state = new ATM_InputPINFault(this);
        }
        /// <summary>Метод переводящий текущее состояние банкомата в состояние выбора операций.</summary>
        public void StateChoseOperation()
        {
            LockAndResetClientSettings(false, splitContainer2.Panel2);
            SetReceivingShutterState(Properties.Resources.ReceivingShutterPasiv);
            ATMGeneralScreenOperation(Properties.Resources.ATM_ChoseOperation, textBoxMain, false);
            state = new ATM_ChoseOperation(this);
        }
        /// <summary>Метод переводящий текущее состояние банкомата в состояние успешного внесения средств на счет.</summary>
        public async void StatePutMoneySuccess()
        {
                      
            SetReceivingShutterState(Properties.Resources.ReceivingShutterPasiv);
            ShowClientMoney(false);
            ATMGeneralScreenOperation(Properties.Resources.ATM_Wait, textBoxMain, false);
            await Task.Run(() => { Thread.Sleep(1500); });
            if (GetObjectQuantityBanknote(splitContainer2.Panel2) <= SettingsATM.SHUTTER_CAPACITY)
            {
                foreach (var cartridge in atm.Cartridges)
                {
                    if (cartridge is ReceivingCartridge)
                    {
                        cartridge.CurrentQuantityBanknote += GetObjectQuantityBanknote(splitContainer2.Panel2);
                        numericUpDownReceiv.Value = cartridge.CurrentQuantityBanknote;
                    }
                }
                account.Put(GetObjectBalance(splitContainer2.Panel2), client);
                ReceivingShutter = false;
                clientMoney.Location = new Point(550, 570);
                ATMGeneralScreenOperation(Properties.Resources.ATM_PutMoneySuccess, textBoxMain, true);
                textBoxMain.Text = GetObjectBalance(splitContainer2.Panel2).ToString();
                LockAndResetClientSettings(false, splitContainer2.Panel2);
                state = new ATM_PutMoneySuccess(this);
            }
            else
            {
                LockSettingsQuantityBanknote(false, splitContainer2.Panel2);
                SetReceivingShutterState(Properties.Resources.ReceivingShutterActiv);
                ShowClientMoney(true);
                ATMGeneralScreenOperation(Properties.Resources.ATM_PutMoneyFailure, textBoxMain, false);
                state = new ATM_PutMoneyFailure(this);
            }

        }

        /// <summary>Метод переводящий текущее состояние банкомата в состояние снятия денежных средств, либо в состояние ошибки операции.</summary>
        public void StateWithdrawCash()
        {
            if (atm.CheckAllDispensingCartridgeOnEmpty())
            {
                ATMGeneralScreenOperation(Properties.Resources.ATM_OperationFault, textBoxMain, false);
                state = new ATM_OperationFault(this);
            }
            else
            {
                AmoumtWithdrawCash = "";
                ATMGeneralScreenOperation(Properties.Resources.ATM_WithdrawCash, textBoxMain, true);
                state = new ATM_WithdrawCash(this);
            }
        }

        ///<summary>Метод переводящий текущее состояние банкомата в состояние выбора способа выдачи наличных (крупными или с разменом), либо в состояние ошибки операции.</summary>
        public void StateWithdrawCashChoice()
        {
            ATMGeneralScreenOperation(null, textBox_MultipleCash, false);
            if (!string.IsNullOrEmpty(AmoumtWithdrawCash) && atm.CheckInputForMultiplicity(uint.Parse(AmoumtWithdrawCash)) && atm.CheckInputForQuantityInATM(uint.Parse(AmoumtWithdrawCash)))
            {
                ATMGeneralScreenOperation(Properties.Resources.ATM_WithdrawCashChoice, textBoxMain, false);
                state = new ATM_WithdrawCashChoice(this);
            }
            else
            {
                if (string.IsNullOrEmpty(AmoumtWithdrawCash) || !atm.CheckInputForMultiplicity(uint.Parse(AmoumtWithdrawCash)))
                {
                    ATMGeneralScreenOperation(Properties.Resources.ATM_WithdrawCashFailure2, textBoxMain, false);
                    PrintAvailableDenomination(textBox_MultipleCash);
                    state = new ATM_WithdrawCashFailure2(this);
                }
                else if (!atm.CheckInputForQuantityInATM(uint.Parse(AmoumtWithdrawCash)))
                {
                    ATMGeneralScreenOperation(Properties.Resources.ATM_WithdrawCashFailure3, textBoxMain, false);
                    state = new ATM_WithdrawCashFailure3(this);
                }
            }
        }

        ///<summary>Метод переводящий текущее состояние банкомата в состояние успешного снятия наличных (крупными или с разменом), либо в состояние ошибки операции.</summary>
        public async void StateWithdrawCashSuccess(IDispensingAlgorithm dispensingAlgorithm)
        {
            if (account.Withdraw(uint.Parse(AmoumtWithdrawCash), client))
            {
                ATMGeneralScreenOperation(Properties.Resources.ATM_WithdrawCashSuccess, textBoxMain, false);
                await Task.Run(() => { atm.GetAllPossibleDispense(uint.Parse(AmoumtWithdrawCash)); });
                atm.SetDispensingAlgorithm(dispensingAlgorithm);
                atm.DispenseFromATM();
                ShowATMSettings();
                SetCardReaderState(Properties.Resources.CartReaderCard);
                state = new ATM_WithdrawCashSuccess(this);
            }
            else
            {
                ATMGeneralScreenOperation(Properties.Resources.ATM_WithdrawCashFailure1, textBoxMain, false);
                state = new ATM_WithdrawCashFailure1(this);
            }
        }

        /// <summary>Метод переводящий текущее состояние банкомата в состояние приема наличных, либо в состояние ошибки операции.</summary>
        public void StatePutMoney()
        {
            uint cartridgeQuantityBanknote = 0;
            foreach (var cartridge in atm.Cartridges)
            {
                if (cartridge is ReceivingCartridge)
                    cartridgeQuantityBanknote = cartridge.CurrentQuantityBanknote;
            }
            if (cartridgeQuantityBanknote > SettingsATM.CARTRIDGE_CAPACITY - SettingsATM.SHUTTER_CAPACITY)
            {
                ATMGeneralScreenOperation(Properties.Resources.ATM_OperationFault, textBoxMain, false);
                state = new ATM_OperationFault(this);
            }
            else
            {
                ATMGeneralScreenOperation(Properties.Resources.ATM_PutMoney, textBoxMain, false);
                SetReceivingShutterState(Properties.Resources.ReceivingShutterActiv);
                LockAndResetClientSettings(true, splitContainer2.Panel2);
                state = new ATM_PutMoney(this);
            }
        }

        /// <summary>Метод переводящий текущее состояние банкомата в исходное состояние.</summary>
        public void StateStartScreen()
        {
            LockSettingButtons(true);
            LockAndResetClientSettings(false, splitContainer2.Panel2);
            ATMGeneralScreenOperation(null, textBox_MultipleCash, false);
            creditCard.Visible = true;
            cardReader.Image = Properties.Resources.CartReaderActiv;
            ATMGeneralScreenOperation(Properties.Resources.ATM_StartScreen, textBoxMain, false);
            state = new ATM_StartScreen(this);
        }

        /// <summary>Метод перерисовывающий главный дисплей банкомата.</summary>
        /// <param name="currentScreeen">Картинка которую необходимо отобразить</param>
        /// <param name="text">Текстовое поле, которе необходимо очистить или изменить его видимость</param>
        /// <param name="visible">Параметр отвечающий за сокрытие текстового поля. true - текстовое поле отображается</param>
        public void ATMGeneralScreenOperation(Bitmap currentScreeen, TextBox text, bool visible)
        {
            panelMainDisplay.BackgroundImage = currentScreeen;
            text.Clear();
            text.Visible = visible;
            panelMainDisplay.Refresh();
        }

        /// <summary>Метод переводящий текущее состояние банкомата в состояние проверки баланса.</summary>        
        public void StateCheckBalance()
        {
            panelMainDisplay.BackgroundImage = Properties.Resources.ATM_CheckBalance;
            textBoxMain.Text = account.ReturnBalance(client).ToString();
            textBoxMain.Visible = true;
            state = new ATM_CheckBalance(this);
        }

        /// <summary>Метод отображающий на основном дисплее номинал купюр которые в данный момент присутсвуют в банкомате.</summary>
        /// <param name="text">Текстовое поле, которе необходимо очистить или изменить его видимость</param>
        public void PrintAvailableDenomination(TextBox text)
        {
            text.Clear();
            text.Visible = true;
            foreach (var denomination in atm.GetAvailableDenomination())
            {
                text.Text += denomination.DenominationCash.GetHashCode() + ", ";
            }
        }

        /// <summary>Метод отображающий на основном дисплее выбранный пользователем пресет для снятия.</summary>
        /// <param name="value">Сумма для снятия</param>
        public void PrintPresetAmmountMoney(string value)
        {
            AmoumtWithdrawCash = value;
            textBoxMain.Text = value;
        }

        /// <summary>Метод отображающий на основном дисплее сумму для снятия, которую ввводит пользователь.</summary>
        /// <param name="limit">Максимальную разрядность вводимой суммы</param>
        /// <param name="number">Строковое значение, которое записывается в текстовое поле основного дисплея</param>
        public void PrintAmountCashEntered(uint limit, string number)
        {
            if (AmoumtWithdrawCash.Length < limit)
            {
                AmoumtWithdrawCash += number;
                textBoxMain.Text += number;
            }
        }

        /// <summary>Метод, формирующий PIN код и отображающий на основном дисплее символы ввода PIN кода.</summary>
        public void PrintPINSign()
        {
            if (StringPIN.Length < 4)
            {
                StringPIN += signPIN;
                textBoxMain.Text = StringPIN;
                FullPIN += PartPIN;
            }
        }

        /// <summary>Метод, удаляющий последний введенный символ PIN кода.</summary>
        public string ClearSign(string word)
        {
            if (word.Length > 0)
                return word.Remove(word.Length - 1, 1);
            else return word;
        }

        #region Обработчики событий нажатия на элементы управления банкомата
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
        private void clientMoney_Click(object sender, EventArgs e)
        {
            state.clientMoney_Click();
        }
        #endregion
        #region Методы обрабатывающие события в классах ATM и Account
        /// <summary>Метод отображающий в текстовом поле настроек клиента время и информацию по основным действиям клиента.</summary>
        /// <param name="sender">Инициатор события</param>
        /// <param name="e">Экземпляр класса, где содержаться данные о событиях</param>
        private void GenerateServiceMessageWithTime(object sender, OperationEventArgs e)
        {
            textClientInfo.AppendText($"{e.TimeStartOperation} - {e.Message}" + Environment.NewLine);
        }

        /// <summary>Метод отображающий в текстовом поле настроек клиента информацию по основным действиям клиента.</summary>
        /// <param name="sender">Инициатор события</param>
        /// <param name="e">Экземпляр класса, где содержаться данные о событиях</param>
        private void GenerateServiceMessage(object sender, OperationEventArgs e)
        {
            textClientInfo.AppendText($"{e.Message}");
        }
        #endregion
        #region Методы настройки колличества денег в банкомате

        /// <summary>Метод записывает в текстбоксы и числовые поля области настроек банкомата текущий баланс по каждому картриджу банкомата и колличество банкнот.</summary>
        private void ShowATMSettings()
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

        /// <summary>Метод обрабатывает изменение числовых полей области настроек банкомата.</summary>
        private void NumericChangedATM(object sender, EventArgs e)
        {
            if (sender is NumericUpDown)
            {
                var obj = sender as NumericUpDown;
                PrintAmmountCashInTextBox(obj, splitContainer2.Panel1);
                uint balance = GetObjectBalance(splitContainer2.Panel1);
                textTotalATMBalance.Text = balance.ToString();
            }
        }

        /// <summary>Метод обрабатывает нажатие на кнопку "НАСТРОИТЬ ВРУЧНУЮ".</summary>
        private void buttonManualSetting_Click(object sender, EventArgs e)
        {
            LockSettingsQuantityBanknote(true, splitContainer2.Panel1);
        }

        /// <summary>Метод обрабатывает нажатие на кнопку "ПОДТВЕРДИТЬ НАСТРОЙКИ".
        /// Выбранные настройки колличества банкнот (а следовательно колличество денег для выдачи) записываются в банкомат.</summary>
        private void buttonConfirmSettings_Click(object sender, EventArgs e)
        {
            LockSettingsQuantityBanknote(false, splitContainer2.Panel1);
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
                        else if (cartridge is ReceivingCartridge)
                            cartridge.CurrentQuantityBanknote = (uint)numericUpDownReceiv.Value;
                    }
                }
            }
        }

        /// <summary>Метод обрабатывает нажатие на кнопку "СБРОС НА ЗАВОДСКИЕ", и возвращает первоночальные настройки заполненности картриджей банкомата</summary>
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

        /// <summary>Метод блокирует/разблокирует кнопки области настроек банкомата.</summary>
        public void LockSettingButtons(bool value)
        {
            buttonCreateNewClient.Enabled = value;
            buttonManualSetting.Enabled = value;
            buttonConfirmSettings.Enabled = value;
            buttonResetDefault.Enabled = value;
        }
        #endregion

        #region Методы настройки клиента

        /// <summary>Метод отображающий в текстбоксах настроек клиента сумму денег в каждом из номиналов исходя из величины числовых полей.</summary>
        private void ShowClientSettings(SplitterPanel panel)
        {
            foreach (Control el in panel.Controls)
            {
                if (el is NumericUpDown)
                    PrintAmmountCashInTextBox((NumericUpDown)el, panel);
            }
            uint balance = GetObjectBalance(panel);
            textClientTotalSumm.Text = balance.ToString();
            uint totalQuantityBanknote = GetObjectQuantityBanknote(panel);
            textClientTotalQuantityBanknote.Text = totalQuantityBanknote.ToString();
        }

        /// <summary>Метод обрабатывает изменение числовых полей области настроек клиента.</summary>
        private void NumericChangedClient(object sender, EventArgs e)
        {
            if (sender is NumericUpDown)
            {
                var obj = sender as NumericUpDown;
                PrintAmmountCashInTextBox(obj, splitContainer2.Panel2);
                uint balance = GetObjectBalance(splitContainer2.Panel2);
                textClientTotalSumm.Text = balance.ToString();
                uint totalQuantityBanknote = GetObjectQuantityBanknote(splitContainer2.Panel2);
                textClientTotalQuantityBanknote.Text = totalQuantityBanknote.ToString();
            }
        }

        /// <summary>Метод увеличивает или уменьшает стопку купюр, в зависимости от колличества в текстбоксе.</summary>
        private void textClientTotalQuantityBanknote_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textClientTotalQuantityBanknote.Text) > 0)
            {
                ShowClientMoney(true);
                clientMoney.Size = new Size(175, 60 + int.Parse(textClientTotalQuantityBanknote.Text));
            }
            else ShowClientMoney(false);
        }

        /// <summary>Метод отвечает за перемещение денег в курюроприемник и из него.</summary>
        public void ClientMoneyMove()
        {
            foreach (var cartridge in atm.Cartridges)
            {
                if (cartridge is ReceivingCartridge)
                {
                    if (GetObjectQuantityBanknote(splitContainer2.Panel2) > SettingsATM.SHUTTER_CAPACITY * 2)
                    {
                        textClientInfo.AppendText("Куда столько пихаешь? Не лезет же!!!" + Environment.NewLine);
                        return;
                    }
                    if (!ReceivingShutter)
                    {
                        FillReceivingShutter();
                    }
                    else if (ReceivingShutter)
                    {
                        ClearReceivingShutter();
                    }
                }
            }
        }
        /// <summary>Метод отвечает за визуальное наполнение купюроприемника.</summary>
        public void FillReceivingShutter()
        {
            clientMoney.Location = new Point(550, 350);
            LockSettingsQuantityBanknote(false, splitContainer2.Panel2);
            ReceivingShutter = true;
        }
        /// <summary>Метод отвечает за визуальное очищение купюроприемника.</summary>
        public void ClearReceivingShutter()
        {
            clientMoney.Location = new Point(550, 570);
            LockSettingsQuantityBanknote(true, splitContainer2.Panel2);
            ReceivingShutter = false;
        }
        /// <summary>Метод получает полное колличество банкнот выбранное с помощью числовых полей области настроек клиента.</summary>
        private uint GetObjectQuantityBanknote(SplitterPanel panel)
        {
            decimal totalQuantityBanknote = 0;
            foreach (Control el in panel.Controls)
            {
                if (el is NumericUpDown)
                {
                    totalQuantityBanknote += ((NumericUpDown)el).Value;
                }
            }
            return (uint)totalQuantityBanknote;
        }

        /// <summary>Метод обнуляет значения в числовых полях области настроек.</summary>
        public void ResetSettingsQuantityBanknote()
        {
            foreach (Control obj in splitContainer2.Panel2.Controls)
            {
                if (obj is NumericUpDown)
                {
                    ((NumericUpDown)obj).Value = 0;
                }
            }
        }
        /// <summary>Метод обрабатывает нажатие кнопки "СОЗДАТЬ НОВОГО КЛИЕНТА".</summary>
        private void buttonCreateNewClient_Click(object sender, EventArgs e)
        {
            textClientInfo.Clear();
            client = new Client();
            account.AddNewClient(client);
            creditCard.Visible = true;
        }
        #endregion

        #region Общие методы для клиента и банкомата

        /// <summary>Метод делает доступным для управления числовые поля области настроек.</summary>
        private void LockSettingsQuantityBanknote(bool value, SplitterPanel panel)
        {
            foreach (Control obj in panel.Controls)
            {
                if (obj is NumericUpDown)
                {
                    obj.Enabled = value;
                }
            }
        }
        /// <summary>Метод получает суммарную величину денег опрашивая все числовые поля области настроек".</summary>
        /// <returns>Сумма всех банкнот умноженных на их номиннал выбранная с помощью числовых полей области настроек</returns>
        private uint GetObjectBalance(SplitterPanel panel)
        {
            decimal balance = 0;
            foreach (Control el in panel.Controls)
            {
                if (el is NumericUpDown && el.Tag.ToString() != "0")
                {
                    balance += ((NumericUpDown)el).Value * int.Parse(el.Tag.ToString());
                }
            }
            return (uint)balance;
        }

        /// <summary>Метод записывает в текстбоксы текущий баланс исходя из выбранного через числовые поля колличества банкнот.</summary>
        private void PrintAmmountCashInTextBox(NumericUpDown obj, SplitterPanel panel)
        {
            foreach (Control el in panel.Controls)
            {
                if (el is TextBox)
                {
                    if (el.Tag == obj.Tag)
                    {
                        el.Text = (obj.Value * int.Parse(obj.Tag.ToString())).ToString();
                    }
                }
            }
        }
        /// <summary>Метод управляет доступностью числовых полей и обнуляет их значения.</summary>
        public void LockAndResetClientSettings(bool value, SplitterPanel panel)
        {
            LockSettingsQuantityBanknote(value, panel);
            ResetSettingsQuantityBanknote();
        }
        #endregion
    }
}
