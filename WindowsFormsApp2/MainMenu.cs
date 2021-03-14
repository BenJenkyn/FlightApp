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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void bookingBtn_Click(object sender, EventArgs e)
        {
            Hide();
            BookingMenu view = new BookingMenu();
            view.Show();
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            Hide();
            CustomerMenu view = new CustomerMenu();
            view.Show();
        }
    }
}
