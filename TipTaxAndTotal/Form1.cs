using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipTaxAndTotal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
			//Variables
            double bill = 0;
            double taxes = 0;
            double tip = 0;
            double total = 0;
            if (double.TryParse(Bill.Text, out bill))
            {
				//hides the errors
                errorLabel.Visible = false;
                emptyLabel.Visible = false;
				//This does the math, rounding to 2 decimal places.
                taxes = Math.Round(bill * 0.07, 2);
                tip = Math.Round(bill * 0.15, 2);
                total = Math.Round(bill + taxes + tip, 2);
				//This converts the numbers to text, and adds a $ before to make it pretty
                Tax.Text = "$" + taxes.ToString();
                Tip.Text = "$" + tip.ToString();
                Total.Text = "$" + total.ToString();


            }//This basically combines the Try Catch method with Parse
            else if (Bill.Text == "")
            {
                emptyLabel.Visible = true;
                errorLabel.Visible = false;

            }//This hides all errors except the ones with the text empty
            else {
                errorLabel.Visible = true;
                emptyLabel.Visible = false;
            }//This shows the error
            
        }//Runs whenever the text changes
    }
}
