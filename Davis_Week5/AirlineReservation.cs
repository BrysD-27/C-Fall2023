using System;
using System.Windows.Forms;

namespace Davis_Week5
{
    public partial class AirlineReservation : Form
    {
        private bool[] seats;
        public AirlineReservation()
        {
            InitializeComponent();
            // initialize seats as empty
            seats = new bool[10];
            for(int i = 0; i < seats.Length; i++)
            {
                seats[i] = false;
            }
        }

        // Book button goes off selected class btn
        private void BookBtn_Click(object sender, EventArgs e)
        {
            // first class button checked
            if (firstClassBtn.Checked)
            {
                if (!FirstClassFull())
                {
                    
                    BookFirstClass();
                }
                else if (!EconClassFull())
                {
                    DialogResult result = MessageBox.Show("First class is fully booked!\n\n Would you like to book Economy?", "Class fully booked!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if(result == DialogResult.OK)
                    {
                        BookEconClass();
                    }
                    else
                    {
                        // if user doesn't want to book economy then they receive message below
                        MessageBox.Show("Next Flight leaves in 3 hours!", "Next flight", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    // else all seats are booked, message below displays to user 
                    MessageBox.Show("All seats are filled!", "Fully booked", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (econClassBtn.Checked)
            {
                if (!EconClassFull())
                {
                    BookEconClass();
                }
                else if (!FirstClassFull())
                {
                    DialogResult result = MessageBox.Show("Economy class is fully booked!\n\n Would you like to book First Class?", "Class fully booked!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        BookFirstClass();
                    }
                    else
                    {
                        // if user doesn't want to book first class then they receive message below
                        MessageBox.Show("Next Flight leaves in 3 hours!", "Next flight", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    // else all seats are booked, message below displays to user 
                    MessageBox.Show("All seats are filled!", "Fully booked", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        // if first class isn't full then a seat is booked
        private void BookFirstClass()
        {
            for (int i = 0; i <= 4; i++)
            {
                if (this.seats[i] == false)
                {
                    this.seats[i] = true;
                    MessageBox.Show("Your First class seat has been booked!", "Flight booked", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        // if economy class isn't full then a seat is booked
        private void BookEconClass()
        {
            for (int i = 5; i <= this.seats.Length; i++)
            {
                if (this.seats[i] == false)
                {
                    this.seats[i] = true;
                    MessageBox.Show("Your Economy class seat has been booked!", "Flight booked", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        // checks if first class seats are booked if not then returns false else return true
        private bool FirstClassFull()
        {
            for(int i = 0;i < 5; i++) 
            {
                if (this.seats[i] == false)
                    return false;
            }
            return true;
        }

        // checks if economy class seats are booked if not then returns false else return true
        private bool EconClassFull()
        {
            for (int i = 5; i < this.seats.Length; i++)
            {
                if (this.seats[i] == false)
                    return false;
            }
            return true;
        }
    }
}
