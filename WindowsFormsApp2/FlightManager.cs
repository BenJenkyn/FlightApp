using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class FlightManager
    {
        private int maxFlights;
        private int numFlights;
        private Flight[] flightList;

        public FlightManager(int max)
        {
            maxFlights = max;
            numFlights = 0;
            flightList = new Flight[maxFlights];
        }

        public bool addFlight(int fn, string origin, string destination, int maxSeats)
        {
            if (numFlights >= maxFlights) { return false; }
            Flight f = new Flight(fn, origin, destination, maxSeats);
            flightList[numFlights] = f;
            numFlights++;
            return true;
        }

        public bool addPassanger(Customer customer, int flightId)
        {
            int index;

            if (flightExists(flightId))
            {
                index = findFlight(flightId);
                if (flightList[index].addPassenger(customer))
                {
                    return true;
                }
            }

            return false;
        }

        public string getPassangerList(int flightId)
        {
            int index = findFlight(flightId);
            if (index == -1)
            {
                return null;
            }

            return flightList[index].getPassengerList();
        }

        public int findFlight(int fid)
        {
            for (int x = 0; x < numFlights; x++)
            {
                if (flightList[x].getFlightNumber() == fid)
                    return x;
            }
            return -1;
        }

        public bool flightExists(int fid)
        {
            int loc = findFlight(fid);
            if (loc == -1) { return false; }
            return true;
        }

        public Flight getFlight(int fid)
        {
            int loc = findFlight(fid);
            if (loc == -1) { return null; }
            return flightList[loc];
        }

        public Flight[] getAllFlights()
        {
            Flight[] allFlights = new Flight[numFlights];

            for(int i = 0; i < numFlights; i++)
            {
                allFlights[i] = flightList[i];
            }

            return allFlights;
        }

        public bool deleteFlight(int fid)
        {
            int loc = findFlight(fid);
            if (loc == -1) { return false; }
            flightList[loc] = flightList[numFlights - 1];
            numFlights--;
            return true;
        }

        public string getFlightList()
        {
            string s = "Flight List:";
            for (int x = 0; x < numFlights; x++)
            {
                s = s + "\n" + flightList[x].getFlightNumber() + " from " + flightList[x].getOrigin() + " to " + flightList[x].getDestination();
            }
            return s;
        }
    }
}
