using System.Windows.Forms;

namespace ATM_Sim
{
    partial class ATM_UI
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ATM_UI));
            this.panel_Keyboard = new System.Windows.Forms.Panel();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.button1000 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.receivingShutter = new System.Windows.Forms.PictureBox();
            this.cardReader = new System.Windows.Forms.PictureBox();
            this.dispensingShutter = new System.Windows.Forms.PictureBox();
            this.creditCard = new System.Windows.Forms.PictureBox();
            this.button_display_6 = new System.Windows.Forms.Button();
            this.button_display_5 = new System.Windows.Forms.Button();
            this.button_display_4 = new System.Windows.Forms.Button();
            this.button_display_3 = new System.Windows.Forms.Button();
            this.button_display_2 = new System.Windows.Forms.Button();
            this.button_display_1 = new System.Windows.Forms.Button();
            this.panelMainDisplay = new System.Windows.Forms.Panel();
            this.textBox_MultipleCash = new System.Windows.Forms.TextBox();
            this.textBoxMain = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.buttonResetDefault = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.buttonConfirmSettings = new System.Windows.Forms.Button();
            this.numericUpDownReceiv = new System.Windows.Forms.NumericUpDown();
            this.textTotalSummReceiv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown5000 = new System.Windows.Forms.NumericUpDown();
            this.textTotalSumm5000 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown2000 = new System.Windows.Forms.NumericUpDown();
            this.textTotalSumm2000 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1000 = new System.Windows.Forms.NumericUpDown();
            this.textTotalSumm1000 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown500 = new System.Windows.Forms.NumericUpDown();
            this.textTotalSumm500 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown200 = new System.Windows.Forms.NumericUpDown();
            this.textTotalSumm200 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.numericUpDown100 = new System.Windows.Forms.NumericUpDown();
            this.textTotalSumm100 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label_ATMSettings = new System.Windows.Forms.Label();
            this.buttonManualSetting = new System.Windows.Forms.Button();
            this.textTotalATMBalance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonCreateNewClient = new System.Windows.Forms.Button();
            this.textClientTotalSumm = new System.Windows.Forms.TextBox();
            this.textClientInfo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textClientTotalAmount = new System.Windows.Forms.TextBox();
            this.label_clientSettings = new System.Windows.Forms.Label();
            this.numericUpDownPut5000 = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonPutMoney = new System.Windows.Forms.Button();
            this.textClientTotalSumm5000 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.numericUpDownPut2000 = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.textClientTotalSumm2000 = new System.Windows.Forms.TextBox();
            this.textClientTotalSumm100 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDownPut100 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPut1000 = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.textClientTotalSumm1000 = new System.Windows.Forms.TextBox();
            this.textClientTotalSumm200 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDownPut200 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPut500 = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.textClientTotalSumm500 = new System.Windows.Forms.TextBox();
            this.panel_Keyboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receivingShutter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardReader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispensingShutter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditCard)).BeginInit();
            this.panelMainDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReceiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5000)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2000)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1000)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown500)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown200)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown100)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPut5000)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPut2000)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPut100)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPut1000)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPut200)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPut500)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Keyboard
            // 
            this.panel_Keyboard.AutoSize = true;
            this.panel_Keyboard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Keyboard.Controls.Add(this.buttonEnter);
            this.panel_Keyboard.Controls.Add(this.buttonClear);
            this.panel_Keyboard.Controls.Add(this.buttonCancel);
            this.panel_Keyboard.Controls.Add(this.button1000);
            this.panel_Keyboard.Controls.Add(this.button0);
            this.panel_Keyboard.Controls.Add(this.button12);
            this.panel_Keyboard.Controls.Add(this.button9);
            this.panel_Keyboard.Controls.Add(this.button8);
            this.panel_Keyboard.Controls.Add(this.button7);
            this.panel_Keyboard.Controls.Add(this.button6);
            this.panel_Keyboard.Controls.Add(this.button5);
            this.panel_Keyboard.Controls.Add(this.button4);
            this.panel_Keyboard.Controls.Add(this.button3);
            this.panel_Keyboard.Controls.Add(this.button2);
            this.panel_Keyboard.Controls.Add(this.button1);
            this.panel_Keyboard.Location = new System.Drawing.Point(75, 435);
            this.panel_Keyboard.Name = "panel_Keyboard";
            this.panel_Keyboard.Padding = new System.Windows.Forms.Padding(5);
            this.panel_Keyboard.Size = new System.Drawing.Size(386, 260);
            this.panel_Keyboard.TabIndex = 0;
            // 
            // buttonEnter
            // 
            this.buttonEnter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEnter.BackgroundImage")));
            this.buttonEnter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnter.ForeColor = System.Drawing.Color.Green;
            this.buttonEnter.Location = new System.Drawing.Point(254, 131);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(120, 50);
            this.buttonEnter.TabIndex = 15;
            this.buttonEnter.Tag = "Enter";
            this.buttonEnter.Text = "ENTER";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClear.BackgroundImage")));
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonClear.Location = new System.Drawing.Point(254, 67);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(120, 50);
            this.buttonClear.TabIndex = 14;
            this.buttonClear.Tag = "Clear";
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCancel.BackgroundImage")));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonCancel.Location = new System.Drawing.Point(254, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(120, 50);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Tag = "Cancel";
            this.buttonCancel.Text = "CANCEL\r\n";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // button1000
            // 
            this.button1000.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1000.BackgroundImage")));
            this.button1000.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1000.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1000.Location = new System.Drawing.Point(155, 198);
            this.button1000.Name = "button1000";
            this.button1000.Size = new System.Drawing.Size(70, 50);
            this.button1000.TabIndex = 12;
            this.button1000.Tag = "";
            this.button1000.Text = "000";
            this.button1000.UseVisualStyleBackColor = true;
            this.button1000.Click += new System.EventHandler(this.button1000_Click);
            // 
            // button0
            // 
            this.button0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button0.BackgroundImage")));
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button0.Location = new System.Drawing.Point(79, 198);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(70, 50);
            this.button0.TabIndex = 0;
            this.button0.Tag = "";
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // button12
            // 
            this.button12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button12.BackgroundImage")));
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12.Location = new System.Drawing.Point(3, 198);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(70, 50);
            this.button12.TabIndex = 10;
            this.button12.Tag = "";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(155, 131);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(70, 50);
            this.button9.TabIndex = 9;
            this.button9.Tag = "";
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(79, 131);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(70, 50);
            this.button8.TabIndex = 8;
            this.button8.Tag = "";
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(3, 131);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(70, 50);
            this.button7.TabIndex = 7;
            this.button7.Tag = "";
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(155, 67);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 50);
            this.button6.TabIndex = 6;
            this.button6.Tag = "";
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(79, 67);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 50);
            this.button5.TabIndex = 5;
            this.button5.Tag = "";
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(3, 67);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 50);
            this.button4.TabIndex = 4;
            this.button4.Tag = "";
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(155, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 50);
            this.button3.TabIndex = 3;
            this.button3.Tag = "";
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(79, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 50);
            this.button2.TabIndex = 2;
            this.button2.Tag = "";
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 50);
            this.button1.TabIndex = 1;
            this.button1.Tag = "";
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.receivingShutter);
            this.splitContainer1.Panel1.Controls.Add(this.cardReader);
            this.splitContainer1.Panel1.Controls.Add(this.dispensingShutter);
            this.splitContainer1.Panel1.Controls.Add(this.creditCard);
            this.splitContainer1.Panel1.Controls.Add(this.button_display_6);
            this.splitContainer1.Panel1.Controls.Add(this.panel_Keyboard);
            this.splitContainer1.Panel1.Controls.Add(this.button_display_5);
            this.splitContainer1.Panel1.Controls.Add(this.button_display_4);
            this.splitContainer1.Panel1.Controls.Add(this.button_display_3);
            this.splitContainer1.Panel1.Controls.Add(this.button_display_2);
            this.splitContainer1.Panel1.Controls.Add(this.button_display_1);
            this.splitContainer1.Panel1.Controls.Add(this.panelMainDisplay);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1085, 720);
            this.splitContainer1.SplitterDistance = 780;
            this.splitContainer1.TabIndex = 2;
            // 
            // receivingShutter
            // 
            this.receivingShutter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.receivingShutter.Image = global::ATM_Sim.Properties.Resources.ReceivingShutterPasiv;
            this.receivingShutter.Location = new System.Drawing.Point(518, 313);
            this.receivingShutter.Name = "receivingShutter";
            this.receivingShutter.Size = new System.Drawing.Size(241, 150);
            this.receivingShutter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.receivingShutter.TabIndex = 25;
            this.receivingShutter.TabStop = false;
            // 
            // cardReader
            // 
            this.cardReader.Image = ((System.Drawing.Image)(resources.GetObject("cardReader.Image")));
            this.cardReader.Location = new System.Drawing.Point(559, 46);
            this.cardReader.Name = "cardReader";
            this.cardReader.Size = new System.Drawing.Size(200, 143);
            this.cardReader.TabIndex = 0;
            this.cardReader.TabStop = false;
            this.cardReader.Click += new System.EventHandler(this.cardReader_Click);
            // 
            // dispensingShutter
            // 
            this.dispensingShutter.Image = global::ATM_Sim.Properties.Resources.DispensShutterOff;
            this.dispensingShutter.Location = new System.Drawing.Point(75, 326);
            this.dispensingShutter.Name = "dispensingShutter";
            this.dispensingShutter.Size = new System.Drawing.Size(376, 80);
            this.dispensingShutter.TabIndex = 24;
            this.dispensingShutter.TabStop = false;
            this.dispensingShutter.Click += new System.EventHandler(this.dispensingShutter_Click);
            // 
            // creditCard
            // 
            this.creditCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.creditCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.creditCard.Image = global::ATM_Sim.Properties.Resources.CreditCard;
            this.creditCard.Location = new System.Drawing.Point(597, 523);
            this.creditCard.Name = "creditCard";
            this.creditCard.Size = new System.Drawing.Size(108, 172);
            this.creditCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.creditCard.TabIndex = 23;
            this.creditCard.TabStop = false;
            this.creditCard.Visible = false;
            this.creditCard.Click += new System.EventHandler(this.creditCard_Click);
            // 
            // button_display_6
            // 
            this.button_display_6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_display_6.BackgroundImage")));
            this.button_display_6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_display_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_display_6.Location = new System.Drawing.Point(464, 217);
            this.button_display_6.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.button_display_6.Name = "button_display_6";
            this.button_display_6.Size = new System.Drawing.Size(50, 50);
            this.button_display_6.TabIndex = 21;
            this.button_display_6.Tag = "";
            this.button_display_6.UseVisualStyleBackColor = true;
            this.button_display_6.Click += new System.EventHandler(this.button_display_6_Click);
            // 
            // button_display_5
            // 
            this.button_display_5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_display_5.BackgroundImage")));
            this.button_display_5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_display_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_display_5.Location = new System.Drawing.Point(464, 127);
            this.button_display_5.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.button_display_5.Name = "button_display_5";
            this.button_display_5.Size = new System.Drawing.Size(50, 50);
            this.button_display_5.TabIndex = 20;
            this.button_display_5.Tag = "";
            this.button_display_5.UseVisualStyleBackColor = true;
            this.button_display_5.Click += new System.EventHandler(this.button_display_5_Click);
            // 
            // button_display_4
            // 
            this.button_display_4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_display_4.BackgroundImage")));
            this.button_display_4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_display_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_display_4.Location = new System.Drawing.Point(464, 37);
            this.button_display_4.Name = "button_display_4";
            this.button_display_4.Size = new System.Drawing.Size(50, 50);
            this.button_display_4.TabIndex = 19;
            this.button_display_4.Tag = "";
            this.button_display_4.UseVisualStyleBackColor = true;
            this.button_display_4.Click += new System.EventHandler(this.button_display_4_Click);
            // 
            // button_display_3
            // 
            this.button_display_3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_display_3.BackgroundImage")));
            this.button_display_3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_display_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_display_3.Location = new System.Drawing.Point(16, 217);
            this.button_display_3.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.button_display_3.Name = "button_display_3";
            this.button_display_3.Size = new System.Drawing.Size(50, 50);
            this.button_display_3.TabIndex = 18;
            this.button_display_3.Tag = "";
            this.button_display_3.UseVisualStyleBackColor = true;
            this.button_display_3.Click += new System.EventHandler(this.button_display_3_Click);
            // 
            // button_display_2
            // 
            this.button_display_2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_display_2.BackgroundImage")));
            this.button_display_2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_display_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_display_2.Location = new System.Drawing.Point(16, 127);
            this.button_display_2.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.button_display_2.Name = "button_display_2";
            this.button_display_2.Size = new System.Drawing.Size(50, 50);
            this.button_display_2.TabIndex = 17;
            this.button_display_2.Tag = "";
            this.button_display_2.UseVisualStyleBackColor = true;
            this.button_display_2.Click += new System.EventHandler(this.button_display_2_Click);
            // 
            // button_display_1
            // 
            this.button_display_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_display_1.BackgroundImage")));
            this.button_display_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_display_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_display_1.Location = new System.Drawing.Point(16, 37);
            this.button_display_1.Name = "button_display_1";
            this.button_display_1.Size = new System.Drawing.Size(50, 50);
            this.button_display_1.TabIndex = 16;
            this.button_display_1.Tag = "";
            this.button_display_1.UseVisualStyleBackColor = true;
            this.button_display_1.Click += new System.EventHandler(this.button_display_1_Click);
            // 
            // panelMainDisplay
            // 
            this.panelMainDisplay.BackgroundImage = global::ATM_Sim.Properties.Resources.ATM_ChoseOperation;
            this.panelMainDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelMainDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMainDisplay.Controls.Add(this.textBox_MultipleCash);
            this.panelMainDisplay.Controls.Add(this.textBoxMain);
            this.panelMainDisplay.Location = new System.Drawing.Point(75, 27);
            this.panelMainDisplay.Name = "panelMainDisplay";
            this.panelMainDisplay.Size = new System.Drawing.Size(380, 250);
            this.panelMainDisplay.TabIndex = 1;
            // 
            // textBox_MultipleCash
            // 
            this.textBox_MultipleCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(154)))));
            this.textBox_MultipleCash.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_MultipleCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_MultipleCash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(172)))), ((int)(((byte)(83)))));
            this.textBox_MultipleCash.Location = new System.Drawing.Point(90, 49);
            this.textBox_MultipleCash.Name = "textBox_MultipleCash";
            this.textBox_MultipleCash.ReadOnly = true;
            this.textBox_MultipleCash.Size = new System.Drawing.Size(200, 13);
            this.textBox_MultipleCash.TabIndex = 8;
            this.textBox_MultipleCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_MultipleCash.Visible = false;
            // 
            // textBoxMain
            // 
            this.textBoxMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(154)))));
            this.textBoxMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(172)))), ((int)(((byte)(83)))));
            this.textBoxMain.Location = new System.Drawing.Point(120, 120);
            this.textBoxMain.Name = "textBoxMain";
            this.textBoxMain.ReadOnly = true;
            this.textBoxMain.Size = new System.Drawing.Size(140, 19);
            this.textBoxMain.TabIndex = 6;
            this.textBoxMain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxMain.Visible = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer2.Panel1.Controls.Add(this.buttonResetDefault);
            this.splitContainer2.Panel1.Controls.Add(this.label20);
            this.splitContainer2.Panel1.Controls.Add(this.buttonConfirmSettings);
            this.splitContainer2.Panel1.Controls.Add(this.numericUpDownReceiv);
            this.splitContainer2.Panel1.Controls.Add(this.textTotalSummReceiv);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.numericUpDown5000);
            this.splitContainer2.Panel1.Controls.Add(this.textTotalSumm5000);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.numericUpDown2000);
            this.splitContainer2.Panel1.Controls.Add(this.textTotalSumm2000);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.numericUpDown1000);
            this.splitContainer2.Panel1.Controls.Add(this.textTotalSumm1000);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.numericUpDown500);
            this.splitContainer2.Panel1.Controls.Add(this.textTotalSumm500);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.numericUpDown200);
            this.splitContainer2.Panel1.Controls.Add(this.textTotalSumm200);
            this.splitContainer2.Panel1.Controls.Add(this.label16);
            this.splitContainer2.Panel1.Controls.Add(this.numericUpDown100);
            this.splitContainer2.Panel1.Controls.Add(this.textTotalSumm100);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.label19);
            this.splitContainer2.Panel1.Controls.Add(this.label18);
            this.splitContainer2.Panel1.Controls.Add(this.label17);
            this.splitContainer2.Panel1.Controls.Add(this.label_ATMSettings);
            this.splitContainer2.Panel1.Controls.Add(this.buttonManualSetting);
            this.splitContainer2.Panel1.Controls.Add(this.textTotalATMBalance);
            this.splitContainer2.Panel1.Tag = "1";
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label7);
            this.splitContainer2.Panel2.Controls.Add(this.buttonCreateNewClient);
            this.splitContainer2.Panel2.Controls.Add(this.textClientTotalSumm);
            this.splitContainer2.Panel2.Controls.Add(this.textClientInfo);
            this.splitContainer2.Panel2.Controls.Add(this.label15);
            this.splitContainer2.Panel2.Controls.Add(this.textClientTotalAmount);
            this.splitContainer2.Panel2.Controls.Add(this.label_clientSettings);
            this.splitContainer2.Panel2.Controls.Add(this.numericUpDownPut5000);
            this.splitContainer2.Panel2.Controls.Add(this.label14);
            this.splitContainer2.Panel2.Controls.Add(this.buttonPutMoney);
            this.splitContainer2.Panel2.Controls.Add(this.textClientTotalSumm5000);
            this.splitContainer2.Panel2.Controls.Add(this.label24);
            this.splitContainer2.Panel2.Controls.Add(this.label9);
            this.splitContainer2.Panel2.Controls.Add(this.label23);
            this.splitContainer2.Panel2.Controls.Add(this.numericUpDownPut2000);
            this.splitContainer2.Panel2.Controls.Add(this.label22);
            this.splitContainer2.Panel2.Controls.Add(this.textClientTotalSumm2000);
            this.splitContainer2.Panel2.Controls.Add(this.textClientTotalSumm100);
            this.splitContainer2.Panel2.Controls.Add(this.label10);
            this.splitContainer2.Panel2.Controls.Add(this.numericUpDownPut100);
            this.splitContainer2.Panel2.Controls.Add(this.numericUpDownPut1000);
            this.splitContainer2.Panel2.Controls.Add(this.label21);
            this.splitContainer2.Panel2.Controls.Add(this.textClientTotalSumm1000);
            this.splitContainer2.Panel2.Controls.Add(this.textClientTotalSumm200);
            this.splitContainer2.Panel2.Controls.Add(this.label11);
            this.splitContainer2.Panel2.Controls.Add(this.numericUpDownPut200);
            this.splitContainer2.Panel2.Controls.Add(this.numericUpDownPut500);
            this.splitContainer2.Panel2.Controls.Add(this.label12);
            this.splitContainer2.Panel2.Controls.Add(this.textClientTotalSumm500);
            this.splitContainer2.Size = new System.Drawing.Size(301, 720);
            this.splitContainer2.SplitterDistance = 325;
            this.splitContainer2.TabIndex = 23;
            // 
            // buttonResetDefault
            // 
            this.buttonResetDefault.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonResetDefault.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonResetDefault.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonResetDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResetDefault.ForeColor = System.Drawing.Color.Snow;
            this.buttonResetDefault.Location = new System.Drawing.Point(200, 282);
            this.buttonResetDefault.Name = "buttonResetDefault";
            this.buttonResetDefault.Size = new System.Drawing.Size(91, 38);
            this.buttonResetDefault.TabIndex = 73;
            this.buttonResetDefault.Text = "СБРОС НА \r\nЗАВОДСКИЕ";
            this.buttonResetDefault.UseVisualStyleBackColor = false;
            this.buttonResetDefault.Click += new System.EventHandler(this.buttonResetToDefault_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(11, 29);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 16);
            this.label20.TabIndex = 72;
            this.label20.Text = "номинал";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonConfirmSettings
            // 
            this.buttonConfirmSettings.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonConfirmSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonConfirmSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConfirmSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonConfirmSettings.ForeColor = System.Drawing.Color.Snow;
            this.buttonConfirmSettings.Location = new System.Drawing.Point(104, 282);
            this.buttonConfirmSettings.Name = "buttonConfirmSettings";
            this.buttonConfirmSettings.Size = new System.Drawing.Size(90, 38);
            this.buttonConfirmSettings.TabIndex = 71;
            this.buttonConfirmSettings.Text = "ПРИМЕНИТЬ";
            this.buttonConfirmSettings.UseVisualStyleBackColor = false;
            this.buttonConfirmSettings.Click += new System.EventHandler(this.buttonConfirmSettings_Click);
            // 
            // numericUpDownReceiv
            // 
            this.numericUpDownReceiv.Enabled = false;
            this.numericUpDownReceiv.Location = new System.Drawing.Point(104, 208);
            this.numericUpDownReceiv.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numericUpDownReceiv.Name = "numericUpDownReceiv";
            this.numericUpDownReceiv.Size = new System.Drawing.Size(61, 20);
            this.numericUpDownReceiv.TabIndex = 70;
            this.numericUpDownReceiv.Tag = "1";
            this.numericUpDownReceiv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textTotalSummReceiv
            // 
            this.textTotalSummReceiv.Location = new System.Drawing.Point(208, 208);
            this.textTotalSummReceiv.Name = "textTotalSummReceiv";
            this.textTotalSummReceiv.ReadOnly = true;
            this.textTotalSummReceiv.Size = new System.Drawing.Size(60, 20);
            this.textTotalSummReceiv.TabIndex = 69;
            this.textTotalSummReceiv.Tag = "1";
            this.textTotalSummReceiv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 68;
            this.label6.Text = "ПРИЕМ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown5000
            // 
            this.numericUpDown5000.Enabled = false;
            this.numericUpDown5000.Location = new System.Drawing.Point(104, 182);
            this.numericUpDown5000.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numericUpDown5000.Name = "numericUpDown5000";
            this.numericUpDown5000.Size = new System.Drawing.Size(61, 20);
            this.numericUpDown5000.TabIndex = 67;
            this.numericUpDown5000.Tag = "5000";
            this.numericUpDown5000.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown5000.ValueChanged += new System.EventHandler(this.NumericChanged);
            // 
            // textTotalSumm5000
            // 
            this.textTotalSumm5000.Location = new System.Drawing.Point(208, 181);
            this.textTotalSumm5000.Name = "textTotalSumm5000";
            this.textTotalSumm5000.ReadOnly = true;
            this.textTotalSumm5000.Size = new System.Drawing.Size(60, 20);
            this.textTotalSumm5000.TabIndex = 66;
            this.textTotalSumm5000.Tag = "5000";
            this.textTotalSumm5000.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "5000";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown2000
            // 
            this.numericUpDown2000.Enabled = false;
            this.numericUpDown2000.Location = new System.Drawing.Point(104, 156);
            this.numericUpDown2000.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numericUpDown2000.Name = "numericUpDown2000";
            this.numericUpDown2000.Size = new System.Drawing.Size(61, 20);
            this.numericUpDown2000.TabIndex = 64;
            this.numericUpDown2000.Tag = "2000";
            this.numericUpDown2000.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown2000.ValueChanged += new System.EventHandler(this.NumericChanged);
            // 
            // textTotalSumm2000
            // 
            this.textTotalSumm2000.Location = new System.Drawing.Point(208, 155);
            this.textTotalSumm2000.Name = "textTotalSumm2000";
            this.textTotalSumm2000.ReadOnly = true;
            this.textTotalSumm2000.Size = new System.Drawing.Size(60, 20);
            this.textTotalSumm2000.TabIndex = 63;
            this.textTotalSumm2000.Tag = "2000";
            this.textTotalSumm2000.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "2000";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown1000
            // 
            this.numericUpDown1000.Enabled = false;
            this.numericUpDown1000.Location = new System.Drawing.Point(104, 130);
            this.numericUpDown1000.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numericUpDown1000.Name = "numericUpDown1000";
            this.numericUpDown1000.Size = new System.Drawing.Size(61, 20);
            this.numericUpDown1000.TabIndex = 61;
            this.numericUpDown1000.Tag = "1000";
            this.numericUpDown1000.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1000.ValueChanged += new System.EventHandler(this.NumericChanged);
            // 
            // textTotalSumm1000
            // 
            this.textTotalSumm1000.Location = new System.Drawing.Point(208, 129);
            this.textTotalSumm1000.Name = "textTotalSumm1000";
            this.textTotalSumm1000.ReadOnly = true;
            this.textTotalSumm1000.Size = new System.Drawing.Size(60, 20);
            this.textTotalSumm1000.TabIndex = 60;
            this.textTotalSumm1000.Tag = "1000";
            this.textTotalSumm1000.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "1000";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown500
            // 
            this.numericUpDown500.Enabled = false;
            this.numericUpDown500.Location = new System.Drawing.Point(104, 104);
            this.numericUpDown500.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numericUpDown500.Name = "numericUpDown500";
            this.numericUpDown500.Size = new System.Drawing.Size(61, 20);
            this.numericUpDown500.TabIndex = 58;
            this.numericUpDown500.Tag = "500";
            this.numericUpDown500.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown500.ValueChanged += new System.EventHandler(this.NumericChanged);
            // 
            // textTotalSumm500
            // 
            this.textTotalSumm500.Location = new System.Drawing.Point(208, 103);
            this.textTotalSumm500.Name = "textTotalSumm500";
            this.textTotalSumm500.ReadOnly = true;
            this.textTotalSumm500.Size = new System.Drawing.Size(60, 20);
            this.textTotalSumm500.TabIndex = 57;
            this.textTotalSumm500.Tag = "500";
            this.textTotalSumm500.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "500";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown200
            // 
            this.numericUpDown200.Enabled = false;
            this.numericUpDown200.Location = new System.Drawing.Point(104, 78);
            this.numericUpDown200.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numericUpDown200.Name = "numericUpDown200";
            this.numericUpDown200.Size = new System.Drawing.Size(61, 20);
            this.numericUpDown200.TabIndex = 55;
            this.numericUpDown200.Tag = "200";
            this.numericUpDown200.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown200.ValueChanged += new System.EventHandler(this.NumericChanged);
            // 
            // textTotalSumm200
            // 
            this.textTotalSumm200.Location = new System.Drawing.Point(208, 77);
            this.textTotalSumm200.Name = "textTotalSumm200";
            this.textTotalSumm200.ReadOnly = true;
            this.textTotalSumm200.Size = new System.Drawing.Size(60, 20);
            this.textTotalSumm200.TabIndex = 54;
            this.textTotalSumm200.Tag = "200";
            this.textTotalSumm200.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(29, 80);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 13);
            this.label16.TabIndex = 53;
            this.label16.Text = "200";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown100
            // 
            this.numericUpDown100.Enabled = false;
            this.numericUpDown100.Location = new System.Drawing.Point(104, 52);
            this.numericUpDown100.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numericUpDown100.Name = "numericUpDown100";
            this.numericUpDown100.Size = new System.Drawing.Size(61, 20);
            this.numericUpDown100.TabIndex = 52;
            this.numericUpDown100.Tag = "100";
            this.numericUpDown100.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown100.ValueChanged += new System.EventHandler(this.NumericChanged);
            // 
            // textTotalSumm100
            // 
            this.textTotalSumm100.Location = new System.Drawing.Point(208, 51);
            this.textTotalSumm100.Name = "textTotalSumm100";
            this.textTotalSumm100.ReadOnly = true;
            this.textTotalSumm100.Size = new System.Drawing.Size(60, 20);
            this.textTotalSumm100.TabIndex = 51;
            this.textTotalSumm100.Tag = "100";
            this.textTotalSumm100.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "100";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(197, 29);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 16);
            this.label19.TabIndex = 46;
            this.label19.Text = "сумма денег";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(87, 29);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 16);
            this.label18.TabIndex = 45;
            this.label18.Text = "кол-во купюр";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(74, 233);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(150, 13);
            this.label17.TabIndex = 38;
            this.label17.Text = "ДОСТУПНО ДЛЯ ВЫДАЧИ";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_ATMSettings
            // 
            this.label_ATMSettings.AutoSize = true;
            this.label_ATMSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ATMSettings.Location = new System.Drawing.Point(55, 0);
            this.label_ATMSettings.Name = "label_ATMSettings";
            this.label_ATMSettings.Size = new System.Drawing.Size(184, 24);
            this.label_ATMSettings.TabIndex = 24;
            this.label_ATMSettings.Text = "НАСТРОЙКА И ДИАГНОСТИКА КОЛ-ВА\r\nКУПЮР В КАРТРИДЖАХ БАНКОМАТА";
            this.label_ATMSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonManualSetting
            // 
            this.buttonManualSetting.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonManualSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonManualSetting.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonManualSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonManualSetting.ForeColor = System.Drawing.Color.Snow;
            this.buttonManualSetting.Location = new System.Drawing.Point(7, 282);
            this.buttonManualSetting.Name = "buttonManualSetting";
            this.buttonManualSetting.Size = new System.Drawing.Size(91, 38);
            this.buttonManualSetting.TabIndex = 1;
            this.buttonManualSetting.Text = "НАСТРОИТЬ\r\nВРУЧНУЮ";
            this.buttonManualSetting.UseVisualStyleBackColor = false;
            this.buttonManualSetting.Click += new System.EventHandler(this.buttonManualSetting_Click);
            // 
            // textTotalATMBalance
            // 
            this.textTotalATMBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textTotalATMBalance.Location = new System.Drawing.Point(76, 248);
            this.textTotalATMBalance.Name = "textTotalATMBalance";
            this.textTotalATMBalance.ReadOnly = true;
            this.textTotalATMBalance.Size = new System.Drawing.Size(145, 29);
            this.textTotalATMBalance.TabIndex = 3;
            this.textTotalATMBalance.Tag = "totalATMAmmount";
            this.textTotalATMBalance.Text = "1250000";
            this.textTotalATMBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(11, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 97;
            this.label7.Text = "номинал";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonCreateNewClient
            // 
            this.buttonCreateNewClient.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonCreateNewClient.FlatAppearance.BorderSize = 5;
            this.buttonCreateNewClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCreateNewClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateNewClient.Location = new System.Drawing.Point(6, 348);
            this.buttonCreateNewClient.Name = "buttonCreateNewClient";
            this.buttonCreateNewClient.Size = new System.Drawing.Size(141, 36);
            this.buttonCreateNewClient.TabIndex = 25;
            this.buttonCreateNewClient.Text = "СОЗДАТЬ НОВОГО КЛИЕНТА";
            this.buttonCreateNewClient.UseVisualStyleBackColor = false;
            this.buttonCreateNewClient.Click += new System.EventHandler(this.buttonCreateNewClient_Click);
            // 
            // textClientTotalSumm
            // 
            this.textClientTotalSumm.Location = new System.Drawing.Point(174, 325);
            this.textClientTotalSumm.Name = "textClientTotalSumm";
            this.textClientTotalSumm.ReadOnly = true;
            this.textClientTotalSumm.Size = new System.Drawing.Size(73, 20);
            this.textClientTotalSumm.TabIndex = 35;
            // 
            // textClientInfo
            // 
            this.textClientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textClientInfo.Location = new System.Drawing.Point(1, 17);
            this.textClientInfo.Multiline = true;
            this.textClientInfo.Name = "textClientInfo";
            this.textClientInfo.ReadOnly = true;
            this.textClientInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textClientInfo.Size = new System.Drawing.Size(295, 102);
            this.textClientInfo.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(76, 327);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "Общей суммой: ";
            // 
            // textClientTotalAmount
            // 
            this.textClientTotalAmount.Location = new System.Drawing.Point(174, 299);
            this.textClientTotalAmount.Name = "textClientTotalAmount";
            this.textClientTotalAmount.ReadOnly = true;
            this.textClientTotalAmount.Size = new System.Drawing.Size(73, 20);
            this.textClientTotalAmount.TabIndex = 33;
            // 
            // label_clientSettings
            // 
            this.label_clientSettings.AutoSize = true;
            this.label_clientSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_clientSettings.Location = new System.Drawing.Point(77, 0);
            this.label_clientSettings.Name = "label_clientSettings";
            this.label_clientSettings.Size = new System.Drawing.Size(146, 12);
            this.label_clientSettings.TabIndex = 23;
            this.label_clientSettings.Text = "СОЗДАНИЕ НОВОГО КЛИЕНТА";
            // 
            // numericUpDownPut5000
            // 
            this.numericUpDownPut5000.Enabled = false;
            this.numericUpDownPut5000.Location = new System.Drawing.Point(104, 275);
            this.numericUpDownPut5000.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownPut5000.Name = "numericUpDownPut5000";
            this.numericUpDownPut5000.Size = new System.Drawing.Size(61, 20);
            this.numericUpDownPut5000.TabIndex = 93;
            this.numericUpDownPut5000.Tag = "5000";
            this.numericUpDownPut5000.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(41, 303);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Всего выбрано купюр: ";
            // 
            // buttonPutMoney
            // 
            this.buttonPutMoney.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPutMoney.Enabled = false;
            this.buttonPutMoney.FlatAppearance.BorderSize = 5;
            this.buttonPutMoney.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPutMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPutMoney.ForeColor = System.Drawing.Color.Snow;
            this.buttonPutMoney.Location = new System.Drawing.Point(152, 348);
            this.buttonPutMoney.Name = "buttonPutMoney";
            this.buttonPutMoney.Size = new System.Drawing.Size(141, 36);
            this.buttonPutMoney.TabIndex = 22;
            this.buttonPutMoney.Text = "ПОЛОЖИТЬ ДЕНЬГИ В КУПЮРОПРИЕМНИК";
            this.buttonPutMoney.UseVisualStyleBackColor = false;
            this.buttonPutMoney.Click += new System.EventHandler(this.buttonPutMoney_Click);
            // 
            // textClientTotalSumm5000
            // 
            this.textClientTotalSumm5000.Location = new System.Drawing.Point(208, 274);
            this.textClientTotalSumm5000.Name = "textClientTotalSumm5000";
            this.textClientTotalSumm5000.ReadOnly = true;
            this.textClientTotalSumm5000.Size = new System.Drawing.Size(60, 20);
            this.textClientTotalSumm5000.TabIndex = 92;
            this.textClientTotalSumm5000.Tag = "5000";
            this.textClientTotalSumm5000.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.Location = new System.Drawing.Point(87, 122);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(95, 16);
            this.label24.TabIndex = 74;
            this.label24.Text = "кол-во купюр";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 91;
            this.label9.Text = "5000";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(197, 122);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(90, 16);
            this.label23.TabIndex = 75;
            this.label23.Text = "сумма денег";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericUpDownPut2000
            // 
            this.numericUpDownPut2000.Enabled = false;
            this.numericUpDownPut2000.Location = new System.Drawing.Point(104, 249);
            this.numericUpDownPut2000.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownPut2000.Name = "numericUpDownPut2000";
            this.numericUpDownPut2000.Size = new System.Drawing.Size(61, 20);
            this.numericUpDownPut2000.TabIndex = 90;
            this.numericUpDownPut2000.Tag = "2000";
            this.numericUpDownPut2000.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(29, 147);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(25, 13);
            this.label22.TabIndex = 76;
            this.label22.Text = "100";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textClientTotalSumm2000
            // 
            this.textClientTotalSumm2000.Location = new System.Drawing.Point(208, 248);
            this.textClientTotalSumm2000.Name = "textClientTotalSumm2000";
            this.textClientTotalSumm2000.ReadOnly = true;
            this.textClientTotalSumm2000.Size = new System.Drawing.Size(60, 20);
            this.textClientTotalSumm2000.TabIndex = 89;
            this.textClientTotalSumm2000.Tag = "2000";
            this.textClientTotalSumm2000.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textClientTotalSumm100
            // 
            this.textClientTotalSumm100.Location = new System.Drawing.Point(208, 144);
            this.textClientTotalSumm100.Name = "textClientTotalSumm100";
            this.textClientTotalSumm100.ReadOnly = true;
            this.textClientTotalSumm100.Size = new System.Drawing.Size(60, 20);
            this.textClientTotalSumm100.TabIndex = 77;
            this.textClientTotalSumm100.Tag = "100";
            this.textClientTotalSumm100.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 88;
            this.label10.Text = "2000";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownPut100
            // 
            this.numericUpDownPut100.Enabled = false;
            this.numericUpDownPut100.Location = new System.Drawing.Point(104, 145);
            this.numericUpDownPut100.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownPut100.Name = "numericUpDownPut100";
            this.numericUpDownPut100.Size = new System.Drawing.Size(61, 20);
            this.numericUpDownPut100.TabIndex = 78;
            this.numericUpDownPut100.Tag = "100";
            this.numericUpDownPut100.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDownPut1000
            // 
            this.numericUpDownPut1000.Enabled = false;
            this.numericUpDownPut1000.Location = new System.Drawing.Point(104, 223);
            this.numericUpDownPut1000.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownPut1000.Name = "numericUpDownPut1000";
            this.numericUpDownPut1000.Size = new System.Drawing.Size(61, 20);
            this.numericUpDownPut1000.TabIndex = 87;
            this.numericUpDownPut1000.Tag = "1000";
            this.numericUpDownPut1000.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(29, 173);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(25, 13);
            this.label21.TabIndex = 79;
            this.label21.Text = "200";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textClientTotalSumm1000
            // 
            this.textClientTotalSumm1000.Location = new System.Drawing.Point(208, 222);
            this.textClientTotalSumm1000.Name = "textClientTotalSumm1000";
            this.textClientTotalSumm1000.ReadOnly = true;
            this.textClientTotalSumm1000.Size = new System.Drawing.Size(60, 20);
            this.textClientTotalSumm1000.TabIndex = 86;
            this.textClientTotalSumm1000.Tag = "1000";
            this.textClientTotalSumm1000.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textClientTotalSumm200
            // 
            this.textClientTotalSumm200.Location = new System.Drawing.Point(208, 170);
            this.textClientTotalSumm200.Name = "textClientTotalSumm200";
            this.textClientTotalSumm200.ReadOnly = true;
            this.textClientTotalSumm200.Size = new System.Drawing.Size(60, 20);
            this.textClientTotalSumm200.TabIndex = 80;
            this.textClientTotalSumm200.Tag = "200";
            this.textClientTotalSumm200.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 85;
            this.label11.Text = "1000";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownPut200
            // 
            this.numericUpDownPut200.Enabled = false;
            this.numericUpDownPut200.Location = new System.Drawing.Point(104, 171);
            this.numericUpDownPut200.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownPut200.Name = "numericUpDownPut200";
            this.numericUpDownPut200.Size = new System.Drawing.Size(61, 20);
            this.numericUpDownPut200.TabIndex = 81;
            this.numericUpDownPut200.Tag = "200";
            this.numericUpDownPut200.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDownPut500
            // 
            this.numericUpDownPut500.Enabled = false;
            this.numericUpDownPut500.Location = new System.Drawing.Point(104, 197);
            this.numericUpDownPut500.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownPut500.Name = "numericUpDownPut500";
            this.numericUpDownPut500.Size = new System.Drawing.Size(61, 20);
            this.numericUpDownPut500.TabIndex = 84;
            this.numericUpDownPut500.Tag = "500";
            this.numericUpDownPut500.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 82;
            this.label12.Text = "500";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textClientTotalSumm500
            // 
            this.textClientTotalSumm500.Location = new System.Drawing.Point(208, 196);
            this.textClientTotalSumm500.Name = "textClientTotalSumm500";
            this.textClientTotalSumm500.ReadOnly = true;
            this.textClientTotalSumm500.Size = new System.Drawing.Size(60, 20);
            this.textClientTotalSumm500.TabIndex = 83;
            this.textClientTotalSumm500.Tag = "500";
            this.textClientTotalSumm500.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ATM_UI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1085, 720);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ATM_UI";
            this.panel_Keyboard.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.receivingShutter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardReader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispensingShutter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditCard)).EndInit();
            this.panelMainDisplay.ResumeLayout(false);
            this.panelMainDisplay.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReceiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5000)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2000)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1000)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown500)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown200)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown100)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPut5000)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPut2000)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPut100)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPut1000)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPut200)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPut500)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Keyboard;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1000;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Panel panelMainDisplay;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button_display_6;
        private System.Windows.Forms.Button button_display_5;
        private System.Windows.Forms.Button button_display_4;
        private System.Windows.Forms.Button button_display_3;
        private System.Windows.Forms.Button button_display_2;
        private System.Windows.Forms.Button button_display_1;
        private Button buttonManualSetting;
        private TextBox textTotalATMBalance;
        private Button buttonPutMoney;
        private SplitContainer splitContainer2;
        private Label label_clientSettings;
        private Label label_ATMSettings;
        private TextBox textClientTotalSumm;
        private Label label15;
        private TextBox textClientTotalAmount;
        private Label label14;
        private Button buttonCreateNewClient;
        public TextBox textClientInfo;
        public TextBox textBoxMain;
        public TextBox textBox_MultipleCash;
        private PictureBox cardReader;
        private PictureBox dispensingShutter;
        private PictureBox creditCard;
        private Label label17;
        private Label label19;
        private Label label18;
        private Button buttonResetDefault;
        private Label label20;
        private Button buttonConfirmSettings;
        private NumericUpDown numericUpDownReceiv;
        private TextBox textTotalSummReceiv;
        private Label label6;
        private NumericUpDown numericUpDown5000;
        private TextBox textTotalSumm5000;
        private Label label5;
        private NumericUpDown numericUpDown2000;
        private TextBox textTotalSumm2000;
        private Label label4;
        private NumericUpDown numericUpDown1000;
        private TextBox textTotalSumm1000;
        private Label label3;
        private NumericUpDown numericUpDown500;
        private TextBox textTotalSumm500;
        private Label label2;
        private NumericUpDown numericUpDown200;
        private TextBox textTotalSumm200;
        private Label label16;
        private NumericUpDown numericUpDown100;
        private TextBox textTotalSumm100;
        private Label label1;
        private PictureBox receivingShutter;
        private Label label7;
        private NumericUpDown numericUpDownPut5000;
        private TextBox textClientTotalSumm5000;
        private Label label9;
        private NumericUpDown numericUpDownPut2000;
        private TextBox textClientTotalSumm2000;
        private Label label10;
        private NumericUpDown numericUpDownPut1000;
        private TextBox textClientTotalSumm1000;
        private Label label11;
        private NumericUpDown numericUpDownPut500;
        private TextBox textClientTotalSumm500;
        private Label label12;
        private NumericUpDown numericUpDownPut200;
        private TextBox textClientTotalSumm200;
        private Label label21;
        private NumericUpDown numericUpDownPut100;
        private TextBox textClientTotalSumm100;
        private Label label22;
        private Label label23;
        private Label label24;
    }
}

