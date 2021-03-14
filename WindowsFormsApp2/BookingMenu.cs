using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class BookingMenu : Form
    {
        private AirlineCoordinator airlineCoordinator;

        public BookingMenu()
        {
            InitializeComponent();
        }

        public BookingMenu(AirlineCoordinator airlineCoordinator)
        {

            this.airlineCoordinator = airlineCoordinator;
            InitializeComponent();
        }

        private void btn_addBooking_Click(object sender, EventArgs e)
        {
            AddBooking addBooking = new AddBooking(this, airlineCoordinator);
            Hide();
            addBooking.Show();
        }

        private void btn_viewBookings_Click(object sender, EventArgs e)
        {
            ViewBooking viewBooking = new ViewBooking(this, airlineCoordinator);
            Hide();
            viewBooking.Show();
        }

        private void btn_backToMainMenu_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu view = new MainMenu();
            view.Show();
        }

        private void BookingMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
