using System;
using System.Windows.Forms;

namespace Davis_Week6
{
    public partial class Form1 : Form
    {
        string[,] conversionTable = {
           {"Miles to kilometers", "Miles", "Kilometers", "1.6093"},
           {"Kilometers to miles", "Kilometers", "Miles", "0.6214"},
           {"Feet to meters", "Feet", "Meters", "0.3048"},
           {"Meters to feet", "Meters", "Feet", "3.2808"},
           {"Inches to centimeters", "Inches", "Centimeters", "2.54"},
           {"Centimeters to inches", "Centimeters", "Inches", "0.3937"}
       };

        public Form1()
        {
            InitializeComponent();

            // Load conversion types into the combo box
            for (int i = 0; i < conversionTable.GetLength(0); i++)
            {
                conversionBox.Items.Add(conversionTable[i, 0]);
            }

            // Set default selection
            conversionBox.SelectedIndex = 0;
        }

        private void conversionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Change labels based on selected conversion
            int selectedIndex = conversionBox.SelectedIndex;
            fromLabel.Text = conversionTable[selectedIndex, 1] + ":";
            toLabel.Text = conversionTable[selectedIndex, 2] + ":";
            toMeasurement.Text = string.Empty;
        }

        private bool IsValidData()
        {
            if (decimal.TryParse(fromMeasurement.Text, out _))
                return true;

            MessageBox.Show(fromLabel.Text + " input must be a valid decimal number.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            fromMeasurement.Text = string.Empty;
            fromMeasurement.Focus();

            return false;
        }

        private void Calculate()
        {
            // Check for valid data
            if (!IsValidData())
                return;

            int selectedIndex = conversionBox.SelectedIndex;
            decimal length = Convert.ToDecimal(fromMeasurement.Text);
            decimal multiplier = Convert.ToDecimal(conversionTable[selectedIndex, 3]);

            decimal convertedLength = length * multiplier;
            toMeasurement.Text = convertedLength.ToString("0.00");
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            fromMeasurement.Text = string.Empty;
            toMeasurement.Text= string.Empty;
        }

        private void fromMeasurement_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) {
                Calculate();
            };
        }
    }
}
