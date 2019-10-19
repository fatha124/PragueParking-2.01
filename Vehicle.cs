using System;

namespace Pragueparking2._01
{
    public class Vehicle
    {
       

        public string TypeOfVehicle { get; set; }
        public string RegNumber { get; set; }
        public string TimeParked { get; set; }
        public string DateParked { get; set; }
        public int ParkingSpot { get; set; }
        public DateTime DateAndTimeParked { get; set; }


        public Vehicle(string type, string regnumb, int parkspot, DateTime timewhenparked) 
        {
            TypeOfVehicle = type;
            RegNumber = regnumb;
            ParkingSpot = parkspot;
            TimeParked = timewhenparked.ToString("HH:MM:ss");
            DateParked = timewhenparked.ToString("dd/mm/yyyy");
            DateAndTimeParked = timewhenparked;
        }
        public string GetTimeParked()
        {
            string s = DateAndTimeParked.ToString("HH:MM:ss");
            return s;
        }

        public string GetDateParked()
        {
            string s = DateAndTimeParked.ToString("dd/mm/yyyy");
            return s;
        }





    }
}