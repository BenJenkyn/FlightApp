using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class BookingManager
    {
        private static int currentBookingNumber;
        private int maxBookings;
        private int numBookings;
        private Booking[] bookingList;

        public BookingManager(int _currentBookingNumber, int maxBookings)
        {
            currentBookingNumber = _currentBookingNumber;
            this.maxBookings = maxBookings;
            this.numBookings = 0;
            this.bookingList = new Booking[maxBookings];
        }

        public bool addBooking(Flight flight, Customer customer)
        {
            if (numBookings >= maxBookings) { return false; }

            if (bookingExist(flight, customer))
            {
                return false;
            }

            Booking booking = new Booking(currentBookingNumber, flight, customer);
            bookingList[numBookings] = booking;

            currentBookingNumber++;
            numBookings++;

            return true;
        }

        public int findBooking(int bookingNumber)
        {
            for (int x = 0; x < numBookings; x++)
            {
                if (bookingList[x].getNumber() == bookingNumber)
                    return x;
            }
            return -1;
        }

        public bool bookingExist(int bookingNumber)
        {
            int loc = findBooking(bookingNumber);
            if (loc == -1) { return false; }
            return true;
        }

        public bool bookingExist(Flight flight, Customer customer)
        {
            for (int i = 0; i < numBookings; i++)
            {
                if (flight == bookingList[i].getFlight() && customer == bookingList[i].getCustomer())
                {
                    return true;
                }
            }

            return false;
        }

        public Booking getBooking(int bookingNumber)
        {
            int loc = findBooking(bookingNumber);
            if (loc == -1) { return null; }
            return bookingList[loc];
        }

        public Booking[] getAllBookings()
        {
            Booking[] allBookings = new Booking[numBookings];

            for (int i = 0; i < numBookings; i++)
            {
                allBookings[i] = bookingList[i];
            }

            return allBookings;
        }

        public bool deleteBooking(int bookingNumber)
        {
            int loc = findBooking(bookingNumber);
            if (loc == -1) { return false; }
            bookingList[loc] = bookingList[numBookings - 1];
            numBookings--;
            return true;
        }

        public string getBookingList()
        {
            string s = "Booking List:";
            s = s + "\tDate \nNumber \t Name \t  \t Phone \tFlight number";
            for (int x = 0; x < numBookings; x++)
            {
                s = s + "\n" + bookingList[x].getDate() + "\t" + bookingList[x].getNumber() + "\t" + bookingList[x].getCustomer().getFirstName() + " " + bookingList[x].getCustomer().getLastName() + "\t" + bookingList[x].getCustomer().getPhone() + "\t" + bookingList[x].getFlight().getFlightNumber();
            }
            return s;
        }
    }
}
