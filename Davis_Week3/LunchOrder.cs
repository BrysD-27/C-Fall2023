using System;
using System.Windows.Forms;

namespace Davis_Week3
{
    public partial class LunchOrder : Form
    {
        double subtotal;
        double tax;
        double orderTotal;
        public LunchOrder()
        {
            InitializeComponent();
        }

        private void updateMainCourse(object sender, EventArgs e)
        {
            ClearAddOns();
            ClearTotals(sender, null);

            if(hamburgerBtn.Checked)
            {
                addonBox.Text = "Add-on items ($.75/each)";
                addonBox1.Text = "Lettuce, tomato, and onions";
                addonBox2.Text = "Ketchup, mustard, and mayo";
                addonBox3.Text = "French fries";
            }
            else if(pizzaBtn.Checked)
            {
                addonBox.Text = "Add-on items ($.50/each)";
                addonBox1.Text = "Pepperoni";
                addonBox2.Text = "Sausage";
                addonBox3.Text = "Olives";
            }
            else if(saladBtn.Checked)
            {
                addonBox.Text = "Add-on items ($.25/each)";
                addonBox1.Text = "Croutons";
                addonBox2.Text = "Bacon bits";
                addonBox3.Text = "Bread sticks";
            }
        }

        private void PlaceOrder(object sender, EventArgs e)
        {
            ClearTotals(sender, null);
            subtotal = 0;

            if (hamburgerBtn.Checked)
            {
                subtotal = 6.95;
                subtotal += addonBox1.Checked ? .75 : 0;
                subtotal += addonBox2.Checked ? .75 : 0;
                subtotal += addonBox3.Checked ? .75 : 0;
            }
            else if (pizzaBtn.Checked) {
                subtotal = 5.95;
                subtotal += addonBox1.Checked ? .5 : 0;
                subtotal += addonBox2.Checked ? .5 : 0;
                subtotal += addonBox3.Checked ? .5 : 0;
            }
            else if (saladBtn.Checked)
            {
                subtotal = 4.95;
                subtotal += addonBox1.Checked ? .25 : 0;
                subtotal += addonBox2.Checked ? .25 : 0;
                subtotal += addonBox3.Checked ? .25 : 0;
            }

            subtotalBox.Text = "$" + subtotal.ToString("0.00");

            tax = CalculateTax(subtotal);
            taxBox.Text = "$" + tax.ToString("0.00");

            orderTotal = tax + subtotal;
            orderTotalBox.Text = "$" + orderTotal.ToString("0.00");
        }

        private double CalculateTax(double subtotal)
        {
            double tax = (subtotal * 7.75) / 100;
            return tax;
        }

        private void ClearTotals(object sender, EventArgs e)
        {
            subtotalBox.Clear();
            taxBox.Clear();
            orderTotalBox.Clear();
        }

        private void ClearAddOns()
        {
            addonBox1.Checked = false; 
            addonBox2.Checked = false; 
            addonBox3.Checked = false;
        }

        private void Exit(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
