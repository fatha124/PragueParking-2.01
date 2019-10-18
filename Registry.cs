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
            DateTime TimeWhenParked = DateTime.Now;
            Console.Clear();
            Console.WriteLine("*******************************************\n" +
                "Please enter the type of vehicle\n" + "{Car}\n" + "or\n" + "{MC}\n" + "*******************************************");
            string type = Console.ReadLine();
            type.ToLower();
            if (type == "car" || type == "mc" || type == "m" || type == "c") 
            {
                Console.WriteLine("Enter registration number: ");
                string regnumb = Console.ReadLine();
                regnumb.ToLower();
                while (regnumb.Length != 6) 
                {
                    Console.WriteLine("Invalid registration number.");
                    regnumb = Console.ReadLine();
                    regnumb.ToLower();
                    Console.Clear();
                }
                if (CheckForDup(regnumb) == false) 
                {
                    Console.Clear();
                    Console.WriteLine("Choose parkingspot.");
                    int parkspot = 0;
                    string chosenspot = Console.ReadLine();
                    int.TryParse(chosenspot, out parkspot);
                    while (parkspot == 0 || parkspot > 100 || parkspot < 0) 
                    {
                        Console.WriteLine("Invalid spot, choose a parkingspot between spot 1 - 100 ");
                        int.TryParse(Console.ReadLine(), out parkspot);
                        Console.Clear();
                    }
                    while (CheckIfSpotIsTaken(parkspot, type)) 
                    {
                        Console.WriteLine("The chosen spot {0} is  already taken\n" + "Please try again... ", parkspot);
                        int.TryParse(Console.ReadLine(), out parkspot);
                    }
                    while (parkspot == 0 || parkspot > 100 || parkspot < 0) 
                    {
                        Console.WriteLine("Invalid spot, choose a parkingspot between spot 1 - 100 ");
                        int.TryParse(Console.ReadLine(), out parkspot);
                        Console.Clear();
                    }
                 }
                Console.Clear();
                RegisterVehicle(type,regnumb,parkspot);
            }
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