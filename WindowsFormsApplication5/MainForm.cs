using System;
using System.Windows.Forms;
namespace WindowsFormsApplication5
{
    public partial class MainForm : Form
    {
        public const int PriceOfMusic = 5000;
        public const int PriceOfDJ = 5000;
        public const int PriceOfStar = 5000;
        public const int PriceOfCapForAdult = 500;
        public const int PriceofCapForChild = 300;
        public const int PriceOfGiftForAdult = 300;
        public const int PriceofGiftForChild = 200;
        public const int PriceOfSnackForAdult = 1000;
        public const int PriceofSnacksForChild = 500;
        public const int PriceOfBanquetForAdult = 2000;
        public const int PriceofBanquetForChild = 1000;
        public const int PriceOfBuffetForAdult = 4000;
        public const int PriceofBuffetForChild = 2000;
        public const double ratioOfPriceInMidday = 0.25;
        public const double ratioOfPriceInEvening = 0.5;

        private int maxs = 20000000;
        private int amountOfAdult, amountOfChildren;
        public MainForm()
        {
                this.InitializeComponent();
        }

        private void textBoxAmountOfAdult_Click(object sender, EventArgs e)
        {
            this.amountOfAdult = Convert.ToInt32(this.textBoxAmountOfAdult.Text);
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double s = 0;
            if (this.checkBoxOnOffMusic.Checked) s+= PriceOfMusic;
            if (this.checkBoxStar.Checked) s += PriceOfStar;
            if (this.checkBoxDJ.Checked) s += PriceOfDJ;
            if (this.checkBoxWithCap.Checked) s += PriceofCapForChild * this.amountOfChildren + PriceOfCapForAdult * this.amountOfAdult;
            if (this.checkBoxWithGifts.Checked) s += PriceofGiftForChild * this.amountOfChildren + PriceOfGiftForAdult * this.amountOfAdult;
            if (this.radioButtonSnacks.Checked) s += PriceOfSnackForAdult * this.amountOfAdult + PriceofSnacksForChild * this.amountOfChildren;
            if (this.radioButtonBanquet.Checked) s += PriceofBanquetForChild * this.amountOfChildren + PriceOfBanquetForAdult * this.amountOfAdult;
            if (this.radioButtonBuffet.Checked) s += PriceOfBuffetForAdult * this.amountOfAdult + PriceofBuffetForChild * this.amountOfChildren;
            if (this.checkBoxPartyTimeIsMidday.Checked) s += ratioOfPriceInMidday * s;
            if (this.checkBoxPartyTimeIsEvening.Checked) s += ratioOfPriceInEvening * s;
            this.labelSammury.Text = Convert.ToString(s);
            if (s > this.maxs)
            {
                this.label14.Visible = true;
                this.label14.ForeColor = System.Drawing.Color.Red;
                this.label14.Text = "Слишком дорого";
            }
        }

        private void checkBoxHaveLimitMoney_CheckedChanged(object sender, EventArgs e)
        {
            this.textBoxBudjet.Visible = true;
        }

        private void textBoxBudjet_TextChanged(object sender, EventArgs e)
        {
            this.maxs = Convert.ToInt32 (this.textBoxBudjet.Text);
        }

        private void textBoxAmountOfChildren_Click(object sender, EventArgs e)
        {
            this.amountOfChildren = Convert.ToInt32(this.textBoxAmountOfChildren.Text);
        }

    }
}
