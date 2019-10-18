using System;
using System.Collections.Generic;
using System.Text;

namespace Pragueparking2._01
{
    public class Registry
    {
        private string TypeOfVehicle;
        private string Registration;
        private string TimeParked;
        private string DateParked;
        private int ParkingSpot;

        public List<Vehicle> vehicles;
        //Constructor
        public Registry()
        {

            vehicles = new List<Vehicle>();

        }


        public void Add()
        {
            
        }

        public bool search() 
        {

            return true;
        }
    }
}