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

        public Vehicle(string type, string RegNumb, int parkspot, DateTime TimeWhenParked) 
        {
            TypeOfVehicle = type;
            RegNumber = RegNumb;
            ParkingSpot = parkspot;
            TimeParked = TimeWhenParked.ToString("HH:MM:ss");
            DateParked = TimeWhenParked.ToString("MM/DD/YYYY");
        }


        public int parkspot { get; set; }
        
        public string type { get; }
       

        public string reg
        {
            get { return this.RegNumber; }
        }

        public string timeWhenArrived
        {
            get { return this.TimeParked; }
        }
        public string datewhenarrived
        {
            get { return this.DateParked; }
        }
        



    }
}