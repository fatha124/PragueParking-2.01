﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pragueparking2._01
{
    public class Registry
    {
        private string TypeOfVehicle;
        private string RegNumb;
        private string TimeParked;
        private string DateParked;
        private int ParkingSpot;

        public List<Vehicle> vehicles { get; }
        //Constructor
        public Registry()
        {

            vehicles = new List<Vehicle>();

        }

       
        public Vehicle SearchWithRegNumber(String RegNumb) 
        {
            foreach(Vehicle vehicle in vehicles) 
            {
                if(vehicle.regnumber == RegNumb) 
                {
                    return vehicle;
                }
            }
            return null;
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