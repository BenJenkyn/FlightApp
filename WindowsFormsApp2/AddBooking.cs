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
    public partial class AddBooking : Form
    {
        BookingMenu f1;
        private AirlineCoordinator airlineCoordinator;
        private Flight[] flightList;
        private Customer[] customerList;

        Dictionary<string, Flight> flightSource = new Dictionary<string, Flight>();
        Dictionary<string, Customer> customerSource = new Dictionary<string, Customer>();

        //Map<string, Flight> flightList = new HashMap<String, Flight>();

        public AddBooking()
        {
            InitializeComponent();
        }

        public AddBooking(BookingMenu f, AirlineCoordinator airlineCoordinator)
        {
            f1 = f;
            this.airlineCoordinator = airlineCoordinator;
            InitializeComponent();

            flightList = this.airlineCoordinator.getAllFlights();
            customerList = this.airlineCoordinator.getAllCustomers();

            string s;

            foreach(Flight flight in flightList)
            {
                //cmb_selectFlight.Items.Add(new { Text = flight.getOrigin() + " to " + flight.getDestination(), Value = flight });
                s = flight.getOrigin() + " to " + flight.getDestination();
                flightSource.Add(s , flight);
            }

            cmb_selectFlight.DataSource = new BindingSource(flightSource, null);
            cmb_selectFlight.DisplayMember = "Key";
            cmb_selectFlight.ValueMember = "Value";

            foreach (Customer customer in customerList)
            {
                //cmb_selectFlight.Items.Add(new { Text = flight.getOrigin() + " to " + flight.getDestination(), Value = flight });
                s = customer.getFirstName() + " " + customer.getLastName();
                customerSource.Add(s, customer);
            }

            cmb_selectCustomer.DataSource = new BindingSource(customerSource, null);
            cmb_selectCustomer.DisplayMember = "Key";
            cmb_selectCustomer.ValueMember = "Value";
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            f1.Show();
            this.Close();
        }

        private void btn_saveBooking_Click(object sender, EventArgs e)
        {
            Customer customer = (Customer) cmb_selectCustomer.SelectedValue;
            Flight flight = (Flight) cmb_selectFlight.SelectedValue;

            if (!airlineCoordinator.bookingExist(flight, customer))
            {

                airlineCoordinator.addBooking(flight, customer);
                airlineCoordinator.addPassanger(customer, flight.getFlightNumber());

                f1.Show();
                this.Close();

            } else
            {
                lbl_error.Text = "ERROR: Booking already exists!";
            }
        }

        private void AddBooking_Load(object sender, EventArgs e)
        {
            Console.WriteLine("success");
        }
    }
}
