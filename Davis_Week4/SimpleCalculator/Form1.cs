using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal operand1 = Convert.ToDecimal(txtOperand1.Text);
                string operator1 = txtOperator.Text;
                decimal operand2 = Convert.ToDecimal(txtOperand2.Text);
                decimal result = Calculate(operand1, operator1, operand2);

                result = Math.Round(result, 4);
                this.txtResult.Text = result.ToString();
                txtOperand1.Focus();
            }
            catch(FormatException ex)
            {
                DisplayError(ex);
            }
            catch (OverflowException ex)
            {
                DisplayError(ex);
            }
            catch (DivideByZeroException ex)
            {
                DisplayError(ex);
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
        }

        private void DisplayError(Exception ex)
        {
            MessageBox.Show($"{ex.GetType().Name.ToUpper()}\n\nMESSAGE: {ex.Message}\n\nSTACK TRACE: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private decimal Calculate(decimal operand1, string operator1,
            decimal operand2)
        {
            decimal result = 0;
            if (operator1 == "+")
                result = operand1 + operand2;
            else if (operator1 == "-")
                result = operand1 - operand2;
            else if (operator1 == "*")
                result = operand1 * operand2;
            else if (operator1 == "/")
                result = operand1 / operand2;
            return result;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearResult(object sender, EventArgs e)
        {
            this.txtResult.Text = "";
        }
    }
}
