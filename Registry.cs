using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pragueparking2._01
{
    public class Registry
    {
        public List<Vehicle> Vehicles { get; }
        //Constructor
        public Registry()
        {

            Vehicles = new List<Vehicle>();

        }

       
        public Vehicle SearchWithRegNumber(string RegNumb) 
        {
            foreach(Vehicle vehicle in Vehicles) 
            {
                if(vehicle.RegNumber == RegNumb) 
                {
                    return vehicle;
                }
            }
            return null;
        }
        public void Add()
        {
            
            
        }

        public bool Search() 
        {

            return true;
        }
        
        public Vehicle RegisterVehicle(string type, string regnumb, int spot, DateTime timewhenparked) 
        {
            Vehicle vehicle = new Vehicle(type, regnumb, spot, timewhenparked);
            return vehicle;
        }
        public bool CheckIfSpotIsTaken(int parkspot, string type) 
        {
            if (Vehicles.Count == 0)
            {
                return false;
            }
            foreach(Vehicle vehicles in Vehicles) 
            {
                int check = CheckSpot(parkspot);
                if (check == 0)
                {
                    return false;
                }
                if(type == "mc") 
                {
                    if(vehicles.TypeOfVehicle == "mc" && CheckSpot(parkspot) < 2) 
                    {
                        return false;
                    }
                }
            }
             return true;
        }

        public int CheckSpot(int parkspot)
        {
            int i = 0;
            foreach (Vehicle vehicles in Vehicles)
            {
                if (vehicles.ParkingSpot == parkspot)
                {
                    i++;
                }
            }

            return i;
        }

        static bool CheckForDup(string regnumb) 
        {
            return false;
        }
    }   
    
}