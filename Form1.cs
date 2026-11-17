using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza____Poject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void UpdateSize()
        {
            UpdateTotalPrice();

            if (rbSmall.Checked)
            {
                lbSize.Text = "Small";
                return;
            }

            if (rbMeduim.Checked)
            {
                lbSize.Text = "Medium";
                return;
            }

            if (rbLarg.Checked)
            {
                lbSize.Text = "Large";
                return;
            }
        }

        void UpdateToppings()
        {
            UpdateTotalPrice();

            string sToppings = "";

            if (chkExtraChees.Checked)
            {
                sToppings = "Extra Chees";
            }

            if (chkOnion.Checked)
            {
                sToppings += ", Onion";
            }

            if (chkMushrooms.Checked)
            {
                sToppings += ", Mushrooms";
            }

            if (chkOlives.Checked)
            {
                sToppings += ", Olives";
            }

            if (chkTomatoes.Checked)
            {
                sToppings += ", Tomatos";
            }

            if (chkGreenPeppers.Checked)
            {
                sToppings += ", Green Peppars";
            }

            if (sToppings.StartsWith(","))
            {
                sToppings = sToppings.Substring(1, sToppings.Length - 1).Trim();
            }

            if (sToppings == "")
                sToppings = "No Toppings";

            lbToppings.Text = sToppings;
        }

        void UpdateCrust()
        {
            UpdateTotalPrice();

            if (rbThinCrust.Checked)
            {
                lbCrustType.Text = "Think Crust";
                return;
            }

            if (rbThickCrust.Checked)
            {
                lbCrustType.Text = "Thick Crust";
                return;
            }
        }

        void UpdateWhereToEat()
        {
            UpdateTotalPrice();

            if (rbEatIn.Checked)
            {
                lbWhereToEat.Text = "Eat In.";
                return;
            }

            if (rbTakeOut.Checked)
            {
                lbWhereToEat.Text = "Take Out";
            }
        }

        float GetSelectedSizePrice()
        {
            if (rbSmall.Checked)
                return Convert.ToSingle(rbSmall.Tag);

            else if (rbMeduim.Checked)
                return Convert.ToSingle(rbMeduim.Tag);

            else
                return Convert.ToSingle(rbLarg.Tag);
        }

        float CalculateToppingsPrice()
        {
            float ToppingsTotalPrice = 0;

            if (chkExtraChees.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkExtraChees.Tag);
            }

            if (chkOnion.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkOnion.Tag);
            }

            if (chkMushrooms.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkMushrooms.Tag);
            }

            if (chkOlives.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkOlives.Tag);
            }

            if (chkTomatoes.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkTomatoes.Tag);
            }

            if (chkGreenPeppers.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkGreenPeppers.Tag);
            }


            return ToppingsTotalPrice;
        }

        float GetSelectedCrutPrice()
        {
            if (rbThinCrust.Checked)
                return Convert.ToSingle(rbThinCrust.Tag);

            else
                return Convert.ToSingle(rbThickCrust.Tag);
        }

        float CalculateTotalPrice()
        {

            return GetSelectedSizePrice() + CalculateToppingsPrice() +
                GetSelectedCrutPrice();
        
        }

        void UpdateTotalPrice()
        {
            lbTotalPrice.Text = "$" + CalculateTotalPrice().ToString();
        }

        void UpdateOrderSummary()
        {
            UpdateSize();
            UpdateToppings();
            UpdateCrust();
            UpdateWhereToEat();
            UpdateTotalPrice();
        }

        void ResetForm()
        {
            //reset Groups
            gbSize.Enabled = true;
            gbToppings.Enabled = true;
            gbCrustType.Enabled = true;
            gbWhereToEat.Enabled = true;

            //reset Size
            rbMeduim.Checked = true;

            //reset Toppings.
            chkExtraChees.Checked = false;
            chkOnion.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkTomatoes.Checked = false;
            chkGreenPeppers.Checked = false;

            //reset CrustType
            rbThinCrust.Checked = true;

            //reset Where to Eat
            rbEatIn.Checked = true;

            //Reset Order Button
            btOrderPizza.Enabled = true;
        }

        private void btOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                btOrderPizza.Enabled = false;
                gbCrustType.Enabled = false;
                gbSize.Enabled = false;
                gbToppings.Enabled = false;
                gbWhereToEat.Enabled = false;
            }

            else
            {
                MessageBox.Show("Update your order", "Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbMeduim_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbLarg_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void gbOrderSummary_Enter(object sender, EventArgs e)
        {

        }
    }
}
