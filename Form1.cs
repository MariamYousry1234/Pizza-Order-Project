using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class frmPizzaOrder : Form
    {
        
        public frmPizzaOrder()
        {
            InitializeComponent();
        }

        float GetTotalSize()
        {
            if (rbSmall.Checked)
            {
              
                return Convert.ToSingle(rbSmall.Tag);
            }
            if (rbMedium.Checked)
            {
                
                return Convert.ToSingle(rbMedium.Tag);
            }
            if (rbLarge.Checked)
            {
              
                return Convert.ToSingle(rbLarge.Tag);
            }

            return 0f;
        }

        float GetTotalToppings()
        {
            float TotalToppings = 0;

            if (chkExtraCheese.Checked)
            {
                TotalToppings+= Convert.ToSingle(chkExtraCheese.Tag);
              
            }
            if (chkTomatoes.Checked)
            {

                TotalToppings += Convert.ToSingle(chkTomatoes.Tag);
            }
            if (chkOlives.Checked)
            {

                TotalToppings += Convert.ToSingle(chkOlives.Tag);
            }

            if (chkGreenPeppers.Checked)
            {

                TotalToppings += Convert.ToSingle(chkGreenPeppers.Tag);
            }

            if (chkMushrooms.Checked)
            {
                TotalToppings += Convert.ToSingle(chkMushrooms.Tag);
            }

            if (chkOnion.Checked)
            {
                TotalToppings += Convert.ToSingle(chkOnion.Tag);
            }
            return TotalToppings ;
        }

        float GetTotalCrustType()
        {
            if (rbThinCrust.Checked)
            {

                return Convert.ToSingle(rbThinCrust.Tag);
            }
            if (rbThickCrust.Checked)
            {
                return Convert.ToSingle(rbThickCrust.Tag);
            }
            return 0f;
        }

        float GetHowManyPizza()
        {
            return (float)numericUpDown1.Value;
        }
        float GetTotalPrice()
        {
            return (GetTotalSize() + GetTotalToppings() + GetTotalCrustType()) * GetHowManyPizza();
        }

 
        void UpdateTotalPrice()
        {
            txtTotalPrice.Text = " $ " + Convert.ToString(GetTotalPrice());
        }

        void AddCommaToText(ref string  Text)
        {
            if (Text.Length > 0)
            {
                Text += ",";
            }
        }

        void UpdateToppings()
        {
            string sToppings = "";

            if (chkExtraCheese.Checked)
            {
                AddCommaToText(ref sToppings);
                sToppings += "Extra Cheese";
               
            }
            if (chkMushrooms.Checked)
            {
                AddCommaToText(ref sToppings);
                sToppings += "Mushrooms";
               
            }
            if (chkTomatoes.Checked)
            {
                AddCommaToText(ref sToppings);
                sToppings += "Tomatoes";
            }

            if (chkOnion.Checked)
            {

                AddCommaToText(ref sToppings);
                sToppings += "Onion";
            }

            if (chkOlives.Checked)
            {
                AddCommaToText(ref sToppings);
                sToppings += "Olives";
            }

            if (chkGreenPeppers.Checked)
            {
                AddCommaToText(ref sToppings);
                sToppings += "Green Peppers";
            }

            txtToppings.Text = sToppings;
            UpdateTotalPrice();
        }

        string ShowDetailsToConfirm()
        {
            string Results = "";

            Results += "\nSize : " + Convert.ToString(txtSize.Text);
            Results += "\nToppings : " + Convert.ToString(txtToppings.Text);
            Results += "\nCrust Type : " + Convert.ToString(txtCrustType.Text);
            Results += "\nWhere To Eat  : " + Convert.ToString(txtWhereToEat.Text);
            Results += "\nTotal Price : " + Convert.ToString(txtTotalPrice.Text);
            Results += "\n\n\nConfirm Order ";


            return Results;
        }
        void ResetForm()
        {
            rbMedium.Checked = true;
            rbThinCrust.Checked = true;
            rbEatIn.Checked = true;

            chkGreenPeppers.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkOnion.Checked = false;
            chkExtraCheese.Checked = false;
            chkTomatoes.Checked = false;


            txtSize.Text = "Medium";
            txtCrustType.Text = "Thin Crust";
            txtWhereToEat.Text = "Eat In";
            txtToppings.Text = "        No Toppings";

            txtTotalPrice.Text = " $ " + Convert.ToString(GetTotalPrice());
        }

        void UpdateSize()
        {
            UpdateTotalPrice();
            if (rbSmall.Checked)
            {
                txtSize.Text = "Small";
                return;
            }
            if(rbMedium.Checked)
            {
                txtSize.Text = "Medium";
                return;
            }
            if(rbLarge.Checked)
            {
                txtSize.Text = "Large";
                return;
            }
        }

        void UpdateCrustType()
        {
            UpdateTotalPrice();
            if (rbThinCrust.Checked)
            {
                txtCrustType.Text = "Thin Crust";
                return;
            }
            if (rbThickCrust.Checked)
            {
                txtCrustType.Text = "Thick Crust";
                return;
            }
        }
        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            
            UpdateSize();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        { 
            UpdateSize();
        }

      
        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }

        private void rbThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }

        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
          

            UpdateToppings();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {

          
            UpdateToppings();
        }

        private void frmPizzaOrder_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
         
            txtWhereToEat.Text = "Eat In";

          
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
          txtWhereToEat.Text = "Take Out";

        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show(ShowDetailsToConfirm(), "Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)== DialogResult.OK)
            {
               if( MessageBox.Show("Order Placed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)==DialogResult.OK)
                {
                    gpSize.Enabled = false;
                    gpToppings.Enabled = false;
                    gpCrustType.Enabled = false;
                    gpWhereToEat.Enabled = false;

                    btnOrderPizza.Enabled = false;


                }
            }
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            gpSize.Enabled = true;
            gpToppings.Enabled = true;
            gpCrustType.Enabled = true;
            gpWhereToEat.Enabled = true;


            btnOrderPizza.Enabled = true;

            ResetForm();
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void numericUpDown1_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
    }
}
