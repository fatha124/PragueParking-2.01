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

        public bool Search() 
        {

            return true;
        }
    
        
    }   
    
}