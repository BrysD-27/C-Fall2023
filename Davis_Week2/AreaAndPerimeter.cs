using System;
using System.Windows.Forms;

namespace Davis_Week2
{
    public partial class AreaAndPerimeterForm : Form
    {
        // Declare class variables that will be used in the app
        int length;
        int width;
        int area;
        int perimeter;
        public AreaAndPerimeterForm()
        {
            InitializeComponent();
        }

        // Calculate button click method
        private void calcBtn_Click(object sender, EventArgs e)
        {
            // using try catch block to
            // catch invalid exception
            try
            {
                // assign inputs to variables
                length = Convert.ToInt32(lengthBox.Text);
                width = Convert.ToInt32(widthBox.Text);
                // calculate area and perimeter from inputs
                area = length * width;
                perimeter = (length * 2) + (width * 2);
                // display results in both area and perimeter text boxes
                areaBox.Text = area.ToString();
                perimeterBox.Text = perimeter.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Exit Button click method
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Key down press method: Whether escape or enter were pressed
        private void AreaAndPerimeterForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Exit method on escape key down 
            if (e.KeyCode == Keys.Escape)
            {
                exitBtn_Click(sender, null);
            }
            // Calculate method on enter key down
            else if (e.KeyCode == Keys.Enter)
            {
                calcBtn_Click(sender, null);
            }
        }
    }
}
