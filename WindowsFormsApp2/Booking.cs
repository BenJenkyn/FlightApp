using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Booking
    {
        private string date;
        private int number;
        private Flight flight;
        private Customer customer;

        public Booking(int number, Flight flight, Customer customer)
        {
            this.date = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt"); ;
            this.number = number;
            this.flight = flight;
            this.customer = customer;
        }

        public string getDate()
        {
            return date;
        }

        public int getNumber()
        {
            return number;
        }

        public Flight getFlight()
        {
            return flight;
        }

        public Customer getCustomer()
        {
            return customer;
        }

        public string toString()
        {
            string s = "Booking number: " + number;
            s += "\nBooking date: " + date;
            s += "\n" + flight.toString();
            s += "\n" + customer.toString();
            return s;
        }
    }
}
