using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        float GetCountBread()
        {
            float Number = Convert.ToSingle(nudCountBread.Value);
            float Value = Convert.ToSingle(nudCountBread.Tag);
            return Number * Value;
        }
        float GetCountSammon()
        {
            float Number = Convert.ToSingle(nudCountSammon.Value);
            float Value = Convert.ToSingle(nudCountSammon.Tag);
            return Number * Value;
        }
        float GetBreadSandwitch()
        {
            float Number = Convert.ToSingle(nudBreadSandwtich.Value);
            float Value = Convert.ToSingle(nudBreadSandwtich.Tag);
            return Number * Value;
        }
        float GetSamoonSandwitch()
        {
            float Number = Convert.ToSingle(nudSamoonSandwitch.Value);
            float Value = Convert.ToSingle(nudSamoonSandwitch.Tag);
            return Number * Value;
        }
        float GetNumbertoEatKabab()
        {
            float Number = Convert.ToSingle(nudForOnePerson.Value);
            float Value = Convert.ToSingle(nudForOnePerson.Tag);
            return Number * Value;
        }
        float howManySizeKabab()
        {
            float Number = Convert.ToSingle(nudOneKilo.Value);
            float Value = Convert.ToSingle(nudOneKilo.Tag);
            return Number * Value;
        }
        float GetNumberOfPepis()
        {
            float Number = Convert.ToSingle(nudPepis.Value);
            float Value = Convert.ToSingle(nudPepis.Tag);
            return Number * Value;
        }
        float GetNumberOfFanta()
        {
            float Number = Convert.ToSingle(nudFanta.Value);
            float Value = Convert.ToSingle(nudFanta.Tag);
            return Number * Value;
        }
        float GetNumberOfOrangeJuice()
        {
            float Number = Convert.ToSingle(nudOrange.Value);
            float Value = Convert.ToSingle(nudOrange.Tag);
            return Number * Value;
        }
        float GetFalafelCust()
        {
            float Number = Convert.ToSingle(nudFalaelCrust.Value);
            float Value = Convert.ToSingle(nudFalaelCrust.Tag);
            return Number * Value;
        }
        float CalculateTotalPrice()
        {
            return GetCountBread() + GetCountSammon() + GetBreadSandwitch() +
                GetSamoonSandwitch() + GetNumbertoEatKabab() + howManySizeKabab() +
                GetNumberOfPepis() + GetNumberOfFanta() + GetNumberOfOrangeJuice() +
                GetFalafelCust();
        }
        void UpdateTotalPrice()
        {
            //float x = Convert.ToInt32(CnudCountBread.Value);
            //  float y = CalculateTotalPrice* Convert.ToDouble(nudCountBread.Value);
            //float total = CalculateTotalPrice() * CalculateTotalPrice2();
            lblTotalPrice.Text = "₪" +CalculateTotalPrice().ToString();
        }
        void UpdateBreadNumber()
        {
            UpdateTotalPrice();
            lblBreadNumber.Text =  nudCountBread.Value.ToString();
        }
        void UpdateCountSammon()
        {
            UpdateTotalPrice();
            lblSamoonNumber.Text = nudCountSammon.Value.ToString();
        }
        void UpdateBreadSandwitch()
        {
            UpdateTotalPrice();
            lblBreadSandwitch.Text = nudBreadSandwtich.Value.ToString();
        }
        void UpdateSamoonSandwitch()
        {
            UpdateTotalPrice();
            lblSamoonSandwitch.Text = nudSamoonSandwitch.Value.ToString();
        }
        void UpdateNumbertoEatKabab()
        {
            UpdateTotalPrice();
            lblKababOnePerson.Text = nudForOnePerson.Value.ToString();
        }
        void UpdatehowManySizeKabab()
        {
            UpdateTotalPrice();
            lblKababKilo.Text = nudOneKilo.Value.ToString();
        }
        void UpdateNumberOfFanta()
        {
            UpdateTotalPrice();
            lblFanta.Text = nudFanta.Value.ToString();
        }
        void UpdateNumberOfPepis()
        {
            UpdateTotalPrice();
            lblPepsi.Text = nudPepis.Value.ToString();
        }
        void UpdateFalafelCust()
        {
            UpdateTotalPrice();
            lblFalafelCrust.Text = nudFalaelCrust.Value.ToString();
        }
        void UpdateNumberOfOrangeJuice()
        {
            UpdateTotalPrice();
            lblOrange.Text = nudOrange.Value.ToString();
        }
        private void nudBreadSandwtich_ValueChanged(object sender, EventArgs e)
        {
            UpdateBreadSandwitch();
        }

        private void nudCountBread_ValueChanged(object sender, EventArgs e)
        {
            UpdateBreadNumber();
        }

        private void nudSamoonSandwitch_ValueChanged(object sender, EventArgs e)
        {
            UpdateSamoonSandwitch();
        }

        private void nudFalaelCrust_ValueChanged(object sender, EventArgs e)
        {
            UpdateFalafelCust();
        }

        private void nudCountSammon_ValueChanged(object sender, EventArgs e)
        {
            UpdateCountSammon();
        }

        private void nudForOnePerson_ValueChanged(object sender, EventArgs e)
        {
            UpdateNumbertoEatKabab();
        }

        private void nudOneKilo_ValueChanged(object sender, EventArgs e)
        {
            UpdatehowManySizeKabab();
        }

        private void nudPepis_ValueChanged(object sender, EventArgs e)
        {
            UpdateNumberOfPepis();
        }

        private void nudFanta_ValueChanged(object sender, EventArgs e)
        {
            UpdateNumberOfFanta();
        }

        private void nudOrange_ValueChanged(object sender, EventArgs e)
        {
            UpdateNumberOfOrangeJuice();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                btnOrder.Enabled = false;
                gbBread_Sammon.Enabled = false;
                gbDrinks.Enabled = false;
                gbFalafelSandwitch.Enabled = false;
                gbKabab.Enabled = false;
                gbOrderSummary.Enabled = false;
                gbFalafelCrust.Enabled = false;
                gbBread_Sammon.Enabled = false;

            }
            else

                MessageBox.Show("Update your order", "Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        void ResetForm()
        {

            //reset Groups
            btnOrder.Enabled = true;
            gbBread_Sammon.Enabled = true;
            gbDrinks.Enabled = true;
            gbFalafelSandwitch.Enabled = true;
            gbKabab.Enabled = true;
            gbOrderSummary.Enabled = true;
            gbFalafelCrust.Enabled = true;
            gbBread_Sammon.Enabled = true;
            lblBreadNumber.Text = "0";
            lblBreadSandwitch.Text = "0";
            lblFalafelCrust.Text = "0";
            lblFanta.Text = "0";
            lblKababKilo.Text = "0";
            lblKababOnePerson.Text = "0";
            lblOrange.Text = "0";
            lblPepsi.Text = "0";
            lblSamoonNumber.Text = "0";
            lblSamoonSandwitch.Text = "0";
            lblTotalPrice.Text = "0";

            nudBreadSandwtich.Value = 0;
            nudCountBread.Value = 0;
            nudCountSammon.Value = 0;

            nudFalaelCrust.Value = 0;
            nudFanta.Value = 0;
            nudForOnePerson.Value = 0;

            nudOneKilo.Value = 0;

            nudOrange.Value = 0;
            nudPepis.Value = 0;
            nudSamoonSandwitch.Value = 0;
            
        }
       
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
