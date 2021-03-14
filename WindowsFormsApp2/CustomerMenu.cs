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
    public partial class CustomerMenu : Form
    {
       
        public CustomerMenu()
        {
            InitializeComponent();
        }

        private void Btn_backToMenu_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu view = new MainMenu();
            view.Show();
        }

        private void Btn_addCustomer_Click(object sender, EventArgs e)
        {
            Hide();
            CustomerManager view = new CustomerManager();
            view.Show();
        }

        private void btn_viewCustomer_Click(object sender, EventArgs e)
        {
            ViewCustomers viewCust = new ViewCustomers();
            Hide();
            viewCust.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CustomerMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
