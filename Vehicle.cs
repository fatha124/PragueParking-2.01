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

        public Vehicle(string type, string RegNumb, int parkspot, DateTime TimeWhenParked) 
        {
            TypeOfVehicle = type;
            regnumber = RegNumb;
            ParkingSpot = parkspot;
            TimeParked = TimeWhenParked.ToString("HH:MM:ss");
            DateParked = TimeWhenParked.ToString("MM/DD/YYYY");
        }


        public int Parkspot
        {
            get { return this.ParkingSpot; }
            set { this.ParkingSpot = value; }
        }
        public string Type
        {
            get { return this.TypeOfVehicle; }
        }

        public string Reg
        {
            get { return this.regnumber; }
        }

        public string TimeWhenArrived
        {
            get { return this.TimeParked; }
        }
        public string DateWhenArrived
        {
            get { return this.DateParked; }
        }
        



    }
}