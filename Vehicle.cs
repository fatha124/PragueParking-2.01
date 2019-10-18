using System;

namespace Pragueparking2._01
{
    public class Vehicle
    {
        internal static int parkspot;

        public string TypeOfVehicle { get; set; }
        public string RegNumber { get; set; }
        public string TimeParked { get; set; }
        public string DateParked { get; set; }
        public int ParkingSpot { get; set; }

        public  Vehicle(string type, string regnumb, int parkspot, DateTime timewhenparked) 
        {
            TypeOfVehicle = type;
            RegNumber = regnumb;
            ParkingSpot = parkspot;
            TimeParked = timewhenparked.ToString("HH:MM:ss");
            DateParked = timewhenparked.ToString("MM/DD/YYYY");
        }


  
        


    }
}