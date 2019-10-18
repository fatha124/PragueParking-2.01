using System;

namespace Pragueparking2._01
{
    public class Vehicle
    {
        public string regnumber;
        public string TypeOfVehicle;
        public string TimeParked;
        public string DateParked;
        public int ParkingSpot;

        public Vehicle(string type, string regnumb, int parkspot, DateTime TimeWhenParked) 
        {
            this.TypeOfVehicle = type;
            this.regnumber = regnumb;
            this.ParkingSpot = parkspot;
            this.TimeParked = TimeWhenParked.ToString("HH:MM:ss");
            this.DateParked = TimeWhenParked.ToString("MM/DD/YYYY");
        }



        


    }
}