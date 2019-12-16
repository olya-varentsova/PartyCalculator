using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApplication5
{
    public partial class MainForm : Form
        {

        public const int priceOfMusic = 5000;
        public const int priceOfDJ = 5000;
        public const int priceOfStar = 5000;
        public const int priceOfCapForAdult = 500;
        public const int priceofCapForChild = 300;
        public const int priceOfGiftForAdult = 300;
        public const int priceofGiftForChild = 200;
        public const int priceOfSnackForAdult = 1000;
        public const int priceofSnacksForChild = 500;
        public const int priceOfBanquetForAdult = 2000;
        public const int priceofBanquetForChild = 1000;
        public const int priceOfBuffetForAdult = 4000;
        public const int priceofBuffetForChild = 2000;
        public const double ratioOfPriceInMidday = 0.25;
        public const double ratioOfPriceInEvening = 0.5;
        public MainForm()
            {
                InitializeComponent();
            }

            private void labelEnableStar_Click(object sender, EventArgs e)
            {

            }
            private void labelEnableDJ_Click(object sender, EventArgs e)
            {

            }
            private void labelTypesOfFood_Click(object sender, EventArgs e)
            {

            }

            private void labelEnableMusic_Click(object sender, EventArgs e)
            {

            }

            private void labelPartyMaker_Click(object sender, EventArgs e)
            {

            }

            private void checkBoxBanquet_CheckedChanged(object sender, EventArgs e)
            {

            }
            private void checkBoxBuffet_CheckedChanged(object sender, EventArgs e)
            {

            }
            private void checkBoxSnacks_CheckedChanged(object sender, EventArgs e)
            {

            }
            private void groupBoxTimeOfParty_Enter(object sender, EventArgs e)
            {

            }
            private void checkBoxPartyTimeIsMidday_CheckedChanged(object sender, EventArgs e)
            {

            }
            private void checkBoxPartyTimeIsMorning_CheckedChanged(object sender, EventArgs e)
            {

            }
            private void labelEnableGifts_Click(object sender, EventArgs e)
            {

            }
            private void checkBoxPartyTimeIsEvening_CheckedChanged(object sender, EventArgs e)
            {

            }
            private void labelTimeOfParty_Click(object sender, EventArgs e)
            {

            }
            private void groupBoxTypesOfFoods_Enter(object sender, EventArgs e)
            {

            }
            private void labelEnableCap_Click(object sender, EventArgs e)
            {

            }
            private void checkBoxOnOffMusic_Click(object sender, EventArgs e)
            {
            
            }
            int amountOfAdult,amountOfChildren;
            double s = 0;
            private void textBoxAmountOfAdult_Click(object sender, EventArgs e)
            {
                amountOfAdult = Convert.ToInt32(textBoxAmountOfAdult.Text);
            }

            private void buttonCalculate_Click(object sender, EventArgs e)
            {
                s = 0;
                if (checkBoxOnOffMusic.Checked) s+= priceOfMusic;
                if (checkBoxStar.Checked) s += priceOfStar;
                if (checkBoxDJ.Checked) s += priceOfDJ;
                if (checkBoxWithCap.Checked) s += priceofCapForChild * amountOfChildren + priceOfCapForAdult * amountOfAdult;
                if (checkBoxWithGifts.Checked) s += priceofGiftForChild * amountOfChildren + priceOfGiftForAdult * amountOfAdult;
                if (radioButtonSnacks.Checked) s += priceOfSnackForAdult * amountOfAdult + priceofSnacksForChild * amountOfChildren;
                if (radioButtonBanquet.Checked) s += priceofBanquetForChild * amountOfChildren + priceOfBanquetForAdult * amountOfAdult;
                if (radioButtonBuffet.Checked) s += priceOfBuffetForAdult * amountOfAdult + priceofBuffetForChild * amountOfChildren;
                if (checkBoxPartyTimeIsMidday.Checked) s += ratioOfPriceInMidday * s;
                if (checkBoxPartyTimeIsEvening.Checked) s += ratioOfPriceInEvening * s;
                labelSammury.Text = Convert.ToString(s);
                if (s > maxs)
                {
                    label14.Visible = true;
                    label14.ForeColor = System.Drawing.Color.Red;
                    label14.Text = "Слишком дорого";
                }







            }

            private void checkBoxStar_CheckedChanged(object sender, EventArgs e)
            {

            }

            private void checkBoxWithGifts_CheckedChanged(object sender, EventArgs e)
            {

            }

            private void labelTooExpensive_Click(object sender, EventArgs e)
            {

            }

            private void checkBoxHaveLimitMoney_CheckedChanged(object sender, EventArgs e)
            {
                textBoxBudjet.Visible = true;
            }
            int maxs=20000000;
            private void textBoxBudjet_TextChanged(object sender, EventArgs e)
            {
                maxs = Convert.ToInt32 (textBoxBudjet.Text);
            }

            private void checkBoxWithCap_CheckedChanged(object sender, EventArgs e)
            {

            }

            private void checkBoxDJ_CheckedChanged(object sender, EventArgs e)
            {

            }

            private void MainForm_Load(object sender, EventArgs e)
            {

            }
            private void labelAmountOfAdults_Click(object sender, EventArgs e)
            {

            }

            private void labelAmountOfChildren_Click(object sender, EventArgs e)
            {

            }

            private void labelSammury_Click(object sender, EventArgs e)
            {

            }

        private void radioButtonSnacks_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonBanquet_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonBuffet_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAmountOfChildren_Click(object sender, EventArgs e)
            {
                amountOfChildren = Convert.ToInt32(textBoxAmountOfChildren.Text);
            }

        }
}
