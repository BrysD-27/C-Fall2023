using System;
using System.Windows.Forms;

namespace Davis_Week1
{
    public partial class DrivingCostCalculator_Form : Form
    {
        // Declare class variables that will be manipulated/displayed thru the app.
        double milesDriven;
        double mpg;
        double costOfGas;
        double parkingFees;
        double tollsFee;
        double costPerDay = 0;
        public DrivingCostCalculator_Form()
        {
            InitializeComponent();
        }

        //Calcute the cost on 'calculate' button click
        private void calculateBtn_Click(object sender, EventArgs e)
        {
            //using try catch block to
            //catch invalid exception
            try
            {
                //get input from text boxes
                milesDriven = Convert.ToDouble(milesDrivenBox.Text);
                mpg = Convert.ToDouble(costPerGallonBox.Text);
                costOfGas = Convert.ToDouble(avgMpgBox.Text);
                parkingFees = Convert.ToDouble(parkingFeeBox.Text);
                tollsFee = Convert.ToDouble(tollsPerDayBox.Text);

                //calculate cost per day
                costPerDay = (milesDriven / mpg) * costOfGas + parkingFees + tollsFee;

                //display result in label
                resultLabel.Text = costPerDay.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DrivingCostCalculator_Load(object sender, EventArgs e)
        {

        }
    }
}
