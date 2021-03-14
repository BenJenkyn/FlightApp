using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class AirlineCoordinator
    {
        FlightManager flManager;
        CustomerManager custManager;
        BookingManager bookingManager;


        public AirlineCoordinator(int custIdSeed, int maxCust, int maxFlights, int currentBookingNumber, int maxBookings)
        {
            flManager = new FlightManager(maxFlights);
            custManager = new CustomerManager(custIdSeed, maxCust);
            bookingManager = new BookingManager(currentBookingNumber, maxBookings);
        }

        public bool addFlight(int flightNo, string origin, string destination, int maxSeats)
        {
            return flManager.addFlight(flightNo, origin, destination, maxSeats);
        }

        public bool addCustomer(string fname, string lname, string phone)
        {
            return custManager.addCustomer(fname, lname, phone);
        }

        public bool addBooking(Flight flight, Customer customer)
        {
            return bookingManager.addBooking(flight, customer);
        }

        public string flightList()
        {
            return flManager.getFlightList();
        }

        public string customerList()
        {
            return custManager.getCustomerList();
        }

        public string bookingList()
        {
            return bookingManager.getBookingList();
        }

        public bool deleteCustomer(int id)
        {
            return custManager.deleteCustomer(id);
        }

        public bool deleteFlight(int fid)
        {
            return flManager.deleteFlight(fid);
        }

        public bool customerExist(int customerId)
        {
            return custManager.customerExist(customerId);
        }

        public bool flightExist(int flightId)
        {
            return flManager.flightExists(flightId);
        }

        public bool bookingExist(Flight flight, Customer customer) {
            return bookingManager.bookingExist(flight, customer);
        }

        public bool addPassanger(Customer customer, int flightId)
        {
            return flManager.addPassanger(customer, flightId);
        }

        public Customer getCustomer(int customerId)
        {
            return custManager.getCustomer(customerId);
        }

        public Flight getFlight(int flightId)
        {
            return flManager.getFlight(flightId);
        }

        public string getPassangerList(int flightId)
        {
            return flManager.getPassangerList(flightId);
        }

        public Flight[] getAllFlights()
        {
            return flManager.getAllFlights();
        }

        public Customer[] getAllCustomers()
        {
            return custManager.getAllCustomers();
        }

        public Booking[] getAllBookings()
        {
            return bookingManager.getAllBookings();
        }
    }
}
