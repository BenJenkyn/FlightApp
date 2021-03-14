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
    public partial class CustomerManager : Form
    {
       
        public CustomerManager()
        {
            InitializeComponent();
        }

     

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTxt.Text;
            string lastName = lastNameTxt.Text;
            string phone = phoneTxt.Text;
            addCustomer(firstName, lastName, phone);
            Hide();
            CustomerMenu view = new CustomerMenu();
            view.Show();

        }

        private void lastNameTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
