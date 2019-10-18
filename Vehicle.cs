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
            TypeOfVehicle = type;
            regnumber = regnumb;
            ParkingSpot = parkspot;
            TimeParked = TimeWhenParked.ToString("HH:MM:ss");
            DateParked = TimeWhenParked.ToString("MM/DD/YYYY");
        }



        


    }
}