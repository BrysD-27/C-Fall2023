using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using OrderOptionsMaintenance.Models.DataLayer;
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;


namespace OrderOptionsMaintenance
{
    public partial class frmOptionsMaint : Form
    {
        private MMABooksContext context = new MMABooksContext();

        private OrderOptions orderOption; 
        public frmOptionsMaint()
        {
            InitializeComponent();
        }

        private void frmOptionsMaint_Load(object sender, EventArgs e)
        {
            orderOption = context.OrderOptions.Single();
            txtSalesTax.Text = orderOption.SalesTaxRate.ToString("P");
            txtShipFirstBook.Text = orderOption.FirstBookShipCharge.ToString("C");
            txtShipAddlBook.Text = orderOption.AdditionalBookShipCharge.ToString("C");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                orderOption.SalesTaxRate = decimal.Parse(txtSalesTax.Text.Replace("%", "")) / 100;
                orderOption.FirstBookShipCharge = decimal.Parse(txtShipFirstBook.Text, NumberStyles.Currency);
                orderOption.AdditionalBookShipCharge = decimal.Parse(txtShipAddlBook.Text, NumberStyles.Currency);

                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Order options have been updated.", "Save Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.frmOptionsMaint_Load(sender, e);
                }
                catch (DbUpdateException ex)
                {
                    string errorMessage = "";
                    var sqlException = (SqlException)ex.InnerException;
                    foreach (SqlError error in sqlException.Errors)
                    {
                        errorMessage += "ERROR CODE:  " + error.Number +
                                        " " + error.Message + "\n";
                    }
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    context.Entry(orderOption).Reload();
                }
            }
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(txtSalesTax) &&
                   Validator.IsDecimal(txtSalesTax) &&
                   Validator.IsPresent(txtShipFirstBook) &&
                   Validator.IsDecimal(txtShipFirstBook) &&
                   Validator.IsPresent(txtShipAddlBook) &&
                   Validator.IsDecimal(txtShipAddlBook);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
