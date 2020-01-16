namespace WindowsFormsApplication5
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelAmountOfAdults = new System.Windows.Forms.Label();
            this.labelAmountOfChildren = new System.Windows.Forms.Label();
            this.textBoxAmountOfAdult = new System.Windows.Forms.TextBox();
            this.textBoxAmountOfChildren = new System.Windows.Forms.TextBox();
            this.labelEnableMusic = new System.Windows.Forms.Label();
            this.checkBoxOnOffMusic = new System.Windows.Forms.CheckBox();
            this.labelEnableStar = new System.Windows.Forms.Label();
            this.checkBoxStar = new System.Windows.Forms.CheckBox();
            this.checkBoxDJ = new System.Windows.Forms.CheckBox();
            this.labelEnableDJ = new System.Windows.Forms.Label();
            this.labelEnableCap = new System.Windows.Forms.Label();
            this.checkBoxWithCap = new System.Windows.Forms.CheckBox();
            this.labelTypesOfFood = new System.Windows.Forms.Label();
            this.groupBoxTypesOfFoods = new System.Windows.Forms.GroupBox();
            this.radioButtonBuffet = new System.Windows.Forms.RadioButton();
            this.radioButtonBanquet = new System.Windows.Forms.RadioButton();
            this.radioButtonSnacks = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labelTimeOfParty = new System.Windows.Forms.Label();
            this.groupBoxTimeOfParty = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBoxPartyTimeIsEvening = new System.Windows.Forms.CheckBox();
            this.checkBoxPartyTimeIsMidday = new System.Windows.Forms.CheckBox();
            this.checkBoxPartyTimeIsMorning = new System.Windows.Forms.CheckBox();
            this.labelPartyMaker = new System.Windows.Forms.Label();
            this.labelEnableGifts = new System.Windows.Forms.Label();
            this.checkBoxWithGifts = new System.Windows.Forms.CheckBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelSammury = new System.Windows.Forms.Label();
            this.checkBoxHaveLimitMoney = new System.Windows.Forms.CheckBox();
            this.textBoxBudjet = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBoxTypesOfFoods.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxTimeOfParty.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAmountOfAdults
            // 
            this.labelAmountOfAdults.AutoSize = true;
            this.labelAmountOfAdults.Location = new System.Drawing.Point(1, 60);
            this.labelAmountOfAdults.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAmountOfAdults.Name = "labelAmountOfAdults";
            this.labelAmountOfAdults.Size = new System.Drawing.Size(232, 20);
            this.labelAmountOfAdults.TabIndex = 0;
            this.labelAmountOfAdults.Text = "Количество взрослый гостей";
            // 
            // labelAmountOfChildren
            // 
            this.labelAmountOfChildren.AutoSize = true;
            this.labelAmountOfChildren.Location = new System.Drawing.Point(82, 96);
            this.labelAmountOfChildren.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAmountOfChildren.Name = "labelAmountOfChildren";
            this.labelAmountOfChildren.Size = new System.Drawing.Size(151, 20);
            this.labelAmountOfChildren.TabIndex = 1;
            this.labelAmountOfChildren.Text = "Количество детей";
            // 
            // textBoxAmountOfAdult
            // 
            this.textBoxAmountOfAdult.Location = new System.Drawing.Point(242, 60);
            this.textBoxAmountOfAdult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAmountOfAdult.Name = "textBoxAmountOfAdult";
            this.textBoxAmountOfAdult.Size = new System.Drawing.Size(148, 26);
            this.textBoxAmountOfAdult.TabIndex = 2;
            this.textBoxAmountOfAdult.TextChanged += new System.EventHandler(this.textBoxAmountOfAdult_Click);
            // 
            // textBoxAmountOfChildren
            // 
            this.textBoxAmountOfChildren.Location = new System.Drawing.Point(242, 96);
            this.textBoxAmountOfChildren.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAmountOfChildren.Name = "textBoxAmountOfChildren";
            this.textBoxAmountOfChildren.Size = new System.Drawing.Size(148, 26);
            this.textBoxAmountOfChildren.TabIndex = 3;
            this.textBoxAmountOfChildren.TextChanged += new System.EventHandler(this.textBoxAmountOfChildren_Click);
            // 
            // labelEnableMusic
            // 
            this.labelEnableMusic.AutoSize = true;
            this.labelEnableMusic.Location = new System.Drawing.Point(82, 133);
            this.labelEnableMusic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEnableMusic.Name = "labelEnableMusic";
            this.labelEnableMusic.Size = new System.Drawing.Size(151, 20);
            this.labelEnableMusic.TabIndex = 4;
            this.labelEnableMusic.Text = "Включить музыку?";
            // 
            // checkBoxOnOffMusic
            // 
            this.checkBoxOnOffMusic.AutoSize = true;
            this.checkBoxOnOffMusic.Location = new System.Drawing.Point(242, 132);
            this.checkBoxOnOffMusic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxOnOffMusic.Name = "checkBoxOnOffMusic";
            this.checkBoxOnOffMusic.Size = new System.Drawing.Size(22, 21);
            this.checkBoxOnOffMusic.TabIndex = 5;
            this.checkBoxOnOffMusic.UseVisualStyleBackColor = true;
            // 
            // labelEnableStar
            // 
            this.labelEnableStar.AutoSize = true;
            this.labelEnableStar.Location = new System.Drawing.Point(146, 162);
            this.labelEnableStar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEnableStar.Name = "labelEnableStar";
            this.labelEnableStar.Size = new System.Drawing.Size(87, 20);
            this.labelEnableStar.TabIndex = 6;
            this.labelEnableStar.Text = "Ведущий?";
            // 
            // checkBoxStar
            // 
            this.checkBoxStar.AutoSize = true;
            this.checkBoxStar.Location = new System.Drawing.Point(242, 161);
            this.checkBoxStar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxStar.Name = "checkBoxStar";
            this.checkBoxStar.Size = new System.Drawing.Size(22, 21);
            this.checkBoxStar.TabIndex = 7;
            this.checkBoxStar.UseVisualStyleBackColor = true;
            // 
            // checkBoxDJ
            // 
            this.checkBoxDJ.AutoSize = true;
            this.checkBoxDJ.Location = new System.Drawing.Point(242, 192);
            this.checkBoxDJ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxDJ.Name = "checkBoxDJ";
            this.checkBoxDJ.Size = new System.Drawing.Size(22, 21);
            this.checkBoxDJ.TabIndex = 8;
            this.checkBoxDJ.UseVisualStyleBackColor = true;
            // 
            // labelEnableDJ
            // 
            this.labelEnableDJ.AutoSize = true;
            this.labelEnableDJ.Location = new System.Drawing.Point(112, 191);
            this.labelEnableDJ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEnableDJ.Name = "labelEnableDJ";
            this.labelEnableDJ.Size = new System.Drawing.Size(121, 20);
            this.labelEnableDJ.TabIndex = 9;
            this.labelEnableDJ.Text = "Вызов диджея";
            // 
            // labelEnableCap
            // 
            this.labelEnableCap.AutoSize = true;
            this.labelEnableCap.Location = new System.Drawing.Point(76, 221);
            this.labelEnableCap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEnableCap.Name = "labelEnableCap";
            this.labelEnableCap.Size = new System.Drawing.Size(157, 20);
            this.labelEnableCap.TabIndex = 11;
            this.labelEnableCap.Text = "Колпаки на гостях?";
            // 
            // checkBoxWithCap
            // 
            this.checkBoxWithCap.AutoSize = true;
            this.checkBoxWithCap.Location = new System.Drawing.Point(242, 221);
            this.checkBoxWithCap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxWithCap.Name = "checkBoxWithCap";
            this.checkBoxWithCap.Size = new System.Drawing.Size(22, 21);
            this.checkBoxWithCap.TabIndex = 10;
            this.checkBoxWithCap.UseVisualStyleBackColor = true;
            // 
            // labelTypesOfFood
            // 
            this.labelTypesOfFood.AutoSize = true;
            this.labelTypesOfFood.Location = new System.Drawing.Point(130, 337);
            this.labelTypesOfFood.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTypesOfFood.Name = "labelTypesOfFood";
            this.labelTypesOfFood.Size = new System.Drawing.Size(103, 20);
            this.labelTypesOfFood.TabIndex = 12;
            this.labelTypesOfFood.Text = "Тип питания";
            // 
            // groupBoxTypesOfFoods
            // 
            this.groupBoxTypesOfFoods.Controls.Add(this.radioButtonBuffet);
            this.groupBoxTypesOfFoods.Controls.Add(this.radioButtonBanquet);
            this.groupBoxTypesOfFoods.Controls.Add(this.radioButtonSnacks);
            this.groupBoxTypesOfFoods.Controls.Add(this.groupBox2);
            this.groupBoxTypesOfFoods.Controls.Add(this.label8);
            this.groupBoxTypesOfFoods.Location = new System.Drawing.Point(242, 283);
            this.groupBoxTypesOfFoods.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxTypesOfFoods.Name = "groupBoxTypesOfFoods";
            this.groupBoxTypesOfFoods.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxTypesOfFoods.Size = new System.Drawing.Size(300, 154);
            this.groupBoxTypesOfFoods.TabIndex = 13;
            this.groupBoxTypesOfFoods.TabStop = false;
            // 
            // radioButtonBuffet
            // 
            this.radioButtonBuffet.AutoSize = true;
            this.radioButtonBuffet.Location = new System.Drawing.Point(6, 96);
            this.radioButtonBuffet.Name = "radioButtonBuffet";
            this.radioButtonBuffet.Size = new System.Drawing.Size(150, 24);
            this.radioButtonBuffet.TabIndex = 18;
            this.radioButtonBuffet.TabStop = true;
            this.radioButtonBuffet.Text = "Шведский стол";
            this.radioButtonBuffet.UseVisualStyleBackColor = true;
            // 
            // radioButtonBanquet
            // 
            this.radioButtonBanquet.AutoSize = true;
            this.radioButtonBanquet.Location = new System.Drawing.Point(4, 52);
            this.radioButtonBanquet.Name = "radioButtonBanquet";
            this.radioButtonBanquet.Size = new System.Drawing.Size(89, 24);
            this.radioButtonBanquet.TabIndex = 17;
            this.radioButtonBanquet.TabStop = true;
            this.radioButtonBanquet.Text = "Банкет";
            this.radioButtonBanquet.UseVisualStyleBackColor = true;
            // 
            // radioButtonSnacks
            // 
            this.radioButtonSnacks.AutoSize = true;
            this.radioButtonSnacks.Location = new System.Drawing.Point(4, 12);
            this.radioButtonSnacks.Name = "radioButtonSnacks";
            this.radioButtonSnacks.Size = new System.Drawing.Size(94, 24);
            this.radioButtonSnacks.TabIndex = 16;
            this.radioButtonSnacks.TabStop = true;
            this.radioButtonSnacks.Text = "Закуски";
            this.radioButtonSnacks.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox8);
            this.groupBox2.Controls.Add(this.checkBox9);
            this.groupBox2.Controls.Add(this.checkBox10);
            this.groupBox2.Location = new System.Drawing.Point(-24, 169);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(300, 154);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(9, 103);
            this.checkBox8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(113, 24);
            this.checkBox8.TabIndex = 2;
            this.checkBox8.Text = "checkBox8";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(10, 66);
            this.checkBox9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(113, 24);
            this.checkBox9.TabIndex = 1;
            this.checkBox9.Text = "checkBox9";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(10, 29);
            this.checkBox10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(122, 24);
            this.checkBox10.TabIndex = 0;
            this.checkBox10.Text = "checkBox10";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-94, 182);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "label8";
            // 
            // labelTimeOfParty
            // 
            this.labelTimeOfParty.AutoSize = true;
            this.labelTimeOfParty.Location = new System.Drawing.Point(91, 510);
            this.labelTimeOfParty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTimeOfParty.Name = "labelTimeOfParty";
            this.labelTimeOfParty.Size = new System.Drawing.Size(142, 20);
            this.labelTimeOfParty.TabIndex = 14;
            this.labelTimeOfParty.Text = "Время вечеринки";
            // 
            // groupBoxTimeOfParty
            // 
            this.groupBoxTimeOfParty.Controls.Add(this.groupBox4);
            this.groupBoxTimeOfParty.Controls.Add(this.label10);
            this.groupBoxTimeOfParty.Controls.Add(this.checkBoxPartyTimeIsEvening);
            this.groupBoxTimeOfParty.Controls.Add(this.checkBoxPartyTimeIsMidday);
            this.groupBoxTimeOfParty.Controls.Add(this.checkBoxPartyTimeIsMorning);
            this.groupBoxTimeOfParty.Location = new System.Drawing.Point(242, 442);
            this.groupBoxTimeOfParty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxTimeOfParty.Name = "groupBoxTimeOfParty";
            this.groupBoxTimeOfParty.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxTimeOfParty.Size = new System.Drawing.Size(300, 154);
            this.groupBoxTimeOfParty.TabIndex = 16;
            this.groupBoxTimeOfParty.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox11);
            this.groupBox4.Controls.Add(this.checkBox12);
            this.groupBox4.Controls.Add(this.checkBox13);
            this.groupBox4.Location = new System.Drawing.Point(-24, 169);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(300, 154);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(9, 103);
            this.checkBox11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(122, 24);
            this.checkBox11.TabIndex = 2;
            this.checkBox11.Text = "checkBox11";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(10, 66);
            this.checkBox12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(122, 24);
            this.checkBox12.TabIndex = 1;
            this.checkBox12.Text = "checkBox12";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new System.Drawing.Point(10, 29);
            this.checkBox13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(122, 24);
            this.checkBox13.TabIndex = 0;
            this.checkBox13.Text = "checkBox13";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-94, 182);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "label10";
            // 
            // checkBoxPartyTimeIsEvening
            // 
            this.checkBoxPartyTimeIsEvening.AutoSize = true;
            this.checkBoxPartyTimeIsEvening.Location = new System.Drawing.Point(9, 103);
            this.checkBoxPartyTimeIsEvening.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxPartyTimeIsEvening.Name = "checkBoxPartyTimeIsEvening";
            this.checkBoxPartyTimeIsEvening.Size = new System.Drawing.Size(82, 24);
            this.checkBoxPartyTimeIsEvening.TabIndex = 2;
            this.checkBoxPartyTimeIsEvening.Text = "Вечер";
            this.checkBoxPartyTimeIsEvening.UseVisualStyleBackColor = true;
            // 
            // checkBoxPartyTimeIsMidday
            // 
            this.checkBoxPartyTimeIsMidday.AutoSize = true;
            this.checkBoxPartyTimeIsMidday.Location = new System.Drawing.Point(10, 66);
            this.checkBoxPartyTimeIsMidday.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxPartyTimeIsMidday.Name = "checkBoxPartyTimeIsMidday";
            this.checkBoxPartyTimeIsMidday.Size = new System.Drawing.Size(74, 24);
            this.checkBoxPartyTimeIsMidday.TabIndex = 1;
            this.checkBoxPartyTimeIsMidday.Text = "День";
            this.checkBoxPartyTimeIsMidday.UseVisualStyleBackColor = true;
            // 
            // checkBoxPartyTimeIsMorning
            // 
            this.checkBoxPartyTimeIsMorning.AutoSize = true;
            this.checkBoxPartyTimeIsMorning.Location = new System.Drawing.Point(10, 29);
            this.checkBoxPartyTimeIsMorning.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxPartyTimeIsMorning.Name = "checkBoxPartyTimeIsMorning";
            this.checkBoxPartyTimeIsMorning.Size = new System.Drawing.Size(72, 24);
            this.checkBoxPartyTimeIsMorning.TabIndex = 0;
            this.checkBoxPartyTimeIsMorning.Text = "Утро";
            this.checkBoxPartyTimeIsMorning.UseVisualStyleBackColor = true;
            // 
            // labelPartyMaker
            // 
            this.labelPartyMaker.AutoSize = true;
            this.labelPartyMaker.Location = new System.Drawing.Point(159, 20);
            this.labelPartyMaker.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPartyMaker.Name = "labelPartyMaker";
            this.labelPartyMaker.Size = new System.Drawing.Size(192, 20);
            this.labelPartyMaker.TabIndex = 17;
            this.labelPartyMaker.Text = "Организатор вечеринок";
            // 
            // labelEnableGifts
            // 
            this.labelEnableGifts.AutoSize = true;
            this.labelEnableGifts.Location = new System.Drawing.Point(91, 251);
            this.labelEnableGifts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEnableGifts.Name = "labelEnableGifts";
            this.labelEnableGifts.Size = new System.Drawing.Size(142, 20);
            this.labelEnableGifts.TabIndex = 19;
            this.labelEnableGifts.Text = "Подарки гостям?";
            // 
            // checkBoxWithGifts
            // 
            this.checkBoxWithGifts.AutoSize = true;
            this.checkBoxWithGifts.Location = new System.Drawing.Point(242, 252);
            this.checkBoxWithGifts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxWithGifts.Name = "checkBoxWithGifts";
            this.checkBoxWithGifts.Size = new System.Drawing.Size(22, 21);
            this.checkBoxWithGifts.TabIndex = 18;
            this.checkBoxWithGifts.UseVisualStyleBackColor = true;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(242, 643);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(112, 35);
            this.buttonCalculate.TabIndex = 20;
            this.buttonCalculate.Text = "Вычислить";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelSammury
            // 
            this.labelSammury.AutoSize = true;
            this.labelSammury.Location = new System.Drawing.Point(244, 706);
            this.labelSammury.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSammury.Name = "labelSammury";
            this.labelSammury.Size = new System.Drawing.Size(54, 20);
            this.labelSammury.TabIndex = 21;
            this.labelSammury.Text = "Итого";
            // 
            // checkBoxHaveLimitMoney
            // 
            this.checkBoxHaveLimitMoney.AutoSize = true;
            this.checkBoxHaveLimitMoney.Location = new System.Drawing.Point(242, 609);
            this.checkBoxHaveLimitMoney.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxHaveLimitMoney.Name = "checkBoxHaveLimitMoney";
            this.checkBoxHaveLimitMoney.Size = new System.Drawing.Size(254, 24);
            this.checkBoxHaveLimitMoney.TabIndex = 22;
            this.checkBoxHaveLimitMoney.Text = "Есть максимальный бюджет";
            this.checkBoxHaveLimitMoney.UseVisualStyleBackColor = true;
            this.checkBoxHaveLimitMoney.CheckedChanged += new System.EventHandler(this.checkBoxHaveLimitMoney_CheckedChanged);
            // 
            // textBoxBudjet
            // 
            this.textBoxBudjet.Location = new System.Drawing.Point(512, 609);
            this.textBoxBudjet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxBudjet.Name = "textBoxBudjet";
            this.textBoxBudjet.Size = new System.Drawing.Size(148, 26);
            this.textBoxBudjet.TabIndex = 23;
            this.textBoxBudjet.Visible = false;
            this.textBoxBudjet.TextChanged += new System.EventHandler(this.textBoxBudjet_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(224, 666);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 20);
            this.label14.TabIndex = 24;
            this.label14.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1914, 914);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxBudjet);
            this.Controls.Add(this.checkBoxHaveLimitMoney);
            this.Controls.Add(this.labelSammury);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelEnableGifts);
            this.Controls.Add(this.checkBoxWithGifts);
            this.Controls.Add(this.labelPartyMaker);
            this.Controls.Add(this.groupBoxTimeOfParty);
            this.Controls.Add(this.labelTimeOfParty);
            this.Controls.Add(this.groupBoxTypesOfFoods);
            this.Controls.Add(this.labelTypesOfFood);
            this.Controls.Add(this.labelEnableCap);
            this.Controls.Add(this.checkBoxWithCap);
            this.Controls.Add(this.labelEnableDJ);
            this.Controls.Add(this.checkBoxDJ);
            this.Controls.Add(this.checkBoxStar);
            this.Controls.Add(this.labelEnableStar);
            this.Controls.Add(this.checkBoxOnOffMusic);
            this.Controls.Add(this.labelEnableMusic);
            this.Controls.Add(this.textBoxAmountOfChildren);
            this.Controls.Add(this.textBoxAmountOfAdult);
            this.Controls.Add(this.labelAmountOfChildren);
            this.Controls.Add(this.labelAmountOfAdults);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Расчет стоимости вечеринки";
            this.groupBoxTypesOfFoods.ResumeLayout(false);
            this.groupBoxTypesOfFoods.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxTimeOfParty.ResumeLayout(false);
            this.groupBoxTimeOfParty.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAmountOfAdults;
        private System.Windows.Forms.Label labelAmountOfChildren;
        private System.Windows.Forms.TextBox textBoxAmountOfAdult;
        private System.Windows.Forms.TextBox textBoxAmountOfChildren;
        private System.Windows.Forms.Label labelEnableMusic;
        private System.Windows.Forms.CheckBox checkBoxOnOffMusic;
        private System.Windows.Forms.Label labelEnableStar;
        private System.Windows.Forms.CheckBox checkBoxStar;
        private System.Windows.Forms.CheckBox checkBoxDJ;
        private System.Windows.Forms.Label labelEnableDJ;
        private System.Windows.Forms.Label labelEnableCap;
        private System.Windows.Forms.CheckBox checkBoxWithCap;
        private System.Windows.Forms.Label labelTypesOfFood;
        private System.Windows.Forms.GroupBox groupBoxTypesOfFoods;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelTimeOfParty;
        private System.Windows.Forms.GroupBox groupBoxTimeOfParty;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBoxPartyTimeIsEvening;
        private System.Windows.Forms.CheckBox checkBoxPartyTimeIsMidday;
        private System.Windows.Forms.CheckBox checkBoxPartyTimeIsMorning;
        private System.Windows.Forms.Label labelPartyMaker;
        private System.Windows.Forms.Label labelEnableGifts;
        private System.Windows.Forms.CheckBox checkBoxWithGifts;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelSammury;
        private System.Windows.Forms.CheckBox checkBoxHaveLimitMoney;
        private System.Windows.Forms.TextBox textBoxBudjet;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton radioButtonBanquet;
        private System.Windows.Forms.RadioButton radioButtonSnacks;
        private System.Windows.Forms.RadioButton radioButtonBuffet;
    }
}

