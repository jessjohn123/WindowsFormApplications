using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdersEntryForm
{
    public partial class Form1 : Form   
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Validate values on the form. If there are errors, 
        // tell the user and set focus to the appropriate TextBox.
        // If there are errors. display a success msg and exit.
        private void okButton_Click(object sender, EventArgs e)
        {
            int quantity;
            decimal priceEach, extendedPrice, subtotal;

            // Validate the rows. If any fails, just return.
            subtotal = 0;
            if (ValidateRow(descTextBox1, quantityTextBox1, priceEachTextBox1, out quantity, out priceEach)) return;
            extendedPrice = quantity * priceEach;
            if (extendedPrice == 0m) extendedPriceTextBox1.Clear();
            else extendedPriceTextBox1.Text = extendedPrice.ToString();
            subtotal += extendedPrice;

            if (ValidateRow(descTextBox2, quantityTextBox2, priceEachTextBox2, out quantity, out priceEach)) return;
            extendedPrice = quantity * priceEach;
            if (extendedPrice == 0m) extendedPriceTextBox2.Clear();
            else extendedPriceTextBox2.Text = extendedPrice.ToString();
            subtotal += extendedPrice;

            if (ValidateRow(descTextBox3, quantityTextBox3, priceEachTextBox3, out quantity, out priceEach)) return;
            extendedPrice = quantity * priceEach;
            if (extendedPrice == 0m) extendedPriceTextBox3.Clear();
            else extendedPriceTextBox3.Text = extendedPrice.ToString();
            subtotal += extendedPrice;

            if (ValidateRow(descTextBox4, quantityTextBox4, priceEachTextBox4, out quantity, out priceEach)) return;
            extendedPrice = quantity * priceEach;
            if (extendedPrice == 0m) extendedPriceTextBox4.Clear();
            else extendedPriceTextBox4.Text = extendedPrice.ToString();
            subtotal += extendedPrice;

            // Display subtotal
            subTotalTextBox.Text = subtotal.ToString();

            // Try to get the sales tax rate.
            if (taxRateTextBox.Text == "")
            {
                // Complain.
                DisplayErrorMsg(
                    "Missing Tax Rate. Tax Rate is required.",
                    "Missing Tax Rate", taxRateTextBox);
                return;
            }

            decimal taxRate;
            if(!decimal.TryParse(taxRateTextBox.Text, out taxRate))
            {
                DisplayErrorMsg(
                    "Invalid Format. Tax Rate must be an integer",
                    "Invalid Format", taxRateTextBox);
                return;
            }

            // Make sure the tax rate is between 0.00 and 0.20.
            if((taxRate < 0m) || (taxRate > 0.2m))
            {
                DisplayErrorMsg(
                    "Invalid Tax Rate. Tax Rate must be beween 0.00 and 0.20",
                    "Invalid Tax Rate", taxRateTextBox);
                return;
            }

            // At this point we have all the data reuired for further calculations, see below.

            decimal salesTax = subtotal * taxRate;
            salesTaxTextBox.Text = salesTax.ToString();

            decimal grandTotal = subtotal + salesTax;
            grandTotalTextBox.Text = grandTotal.ToString();

            // Display the success msg and ask if we should continue or not
            if(MessageBox.Show("This order is valid. Continue?", "Continue?",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // The user clicked yes.
                Close();
            }
        }

        private bool ValidateRow(TextBox descrTextBox, TextBox quantityTextBox, TextBox priceEachTextBox, out int quantity, out decimal priceEach)
        {
            // Assume they are zero
            priceEach = 0;
            quantity = 0;

            // If no values are present and the row is okay/
            if ((descrTextBox.Text == "") && (quantityTextBox.Text == "") && (priceEachTextBox.Text == ""))
                return false;

            // Some values are present to make sure all are.
            if (ValidateRequiredTextBox(descrTextBox, "Description"))  return true;
            if (ValidateRequiredTextBox(quantityTextBox, "Quantity")) return true;
            if (ValidateRequiredTextBox(priceEachTextBox, "Price Each")) return true;

            // All values are present.
            // Try to parse quantity.
            if(!int.TryParse(quantityTextBox.Text, out quantity))
            {
                // Error Msg
                DisplayErrorMsg(
                    "Invalid Format. Quantity must be an integer.",
                    "Invalid Format", quantityTextBox);
                return true;
            }

            // Make sure the quantity is between 1 and 100
            if((quantity < 1) || (quantity > 100))
            {
                DisplayErrorMsg(
                    "Invalid Quantity. Quantity must be between 0 and 100",
                    "Invalid Quantity", quantityTextBox);
                return true;
            }

            // Try to parse price
            if(!decimal.TryParse(priceEachTextBox.Text, NumberStyles.Currency, null, out priceEach))
            {
                DisplayErrorMsg(
                    "Inavlid Format. Price Each must be an currency value.",
                    "Inavlid Format", priceEachTextBox);
                return true;
            }

            // Make sure the priceEach is between $0.01 and $100,000.00.
            if((priceEach < 0.01m) || (priceEach > 1000000.00m))
            {
                DisplayErrorMsg(
                    "Invalid Price Each. Price Each must be between $0.01 and $100000.00",
                    "Invalid Price Each", priceEachTextBox);
                return true;
            }

            // If we get here, we've all the data.
            // Return false to indicate there is no error on this line.
            return false;
        }


        // Tell the user there is an error, select all the text in the TextBox,
        // and set focus to the TextBox
        private void DisplayErrorMsg(string msg, string title, TextBox txtBox)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtBox.SelectAll();
            txtBox.Focus();
        }

        // This TextBox is required. If it is blank
        // tell the user, set focus to it, and return true.
        private bool ValidateRequiredTextBox(TextBox txtBox, string name)
        {
            // If the TextBox is not blank, return false.
            if (txtBox.Text != "") return false;

            // If the TextBox is blank. Throw in the user msg
            DisplayErrorMsg(name + " is required", "Missing Value", txtBox);

            return true;
        }
        // Exit.
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
