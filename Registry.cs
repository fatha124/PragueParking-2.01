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
            foreach (Vehicle vehicle in Vehicles)
            {
                if (vehicle.RegNumber == RegNumb)
                {
                    return vehicle;
                }
            }
            return null;
        }
        public Vehicle RegisterVehicle(string type, string regnumb, int spot, DateTime timewhenparked)
        {
            Vehicle vehicle = new Vehicle(type, regnumb, spot, timewhenparked);
            Vehicles.Add(vehicle);

            return vehicle;
        }
        public void RemoveVehicle(Vehicle vehicle)
        {
            Vehicles.Remove(vehicle);
        }

        public bool CheckIfSpotIsTaken(int parkspot, string type)
        {
            if (Vehicles.Count == 0)
            {
                return false;
            }
            foreach (Vehicle vehicles in Vehicles)
            {
                int check = CheckSpot(parkspot);
                if (check == 0)
                {
                    return false;
                }
                if (type == "mc")
                {
                    if (vehicles.TypeOfVehicle == "mc" && CheckSpot(parkspot) < 2)
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

        public bool CheckForDup(string regnumb)
        {
            foreach (Vehicle vehicles in Vehicles)
            {
                if (vehicles.RegNumber == regnumb)
                {
                    return true;
                }
            }
            return false;
        }

        public double Collect(Vehicle vehicle)
        {
            RemoveVehicle(vehicle);
            double cost = CalculateTheCost(vehicle);
            return cost;
        }
        public double CalculateTheCost(Vehicle vehicle)
        {
            TimeSpan TimeParked = DateTime.Now - Convert.ToDateTime(vehicle.DateAndTimeParked);
            double TimeSinceParked = Convert.ToInt32(TimeParked.TotalMinutes);
            double TotalCost = 0;
            if (TimeSinceParked > 5 && TimeSinceParked < 120)
            {
                if (vehicle.TypeOfVehicle == "mc")
                {
                    TotalCost = (int)Price.Mc * 2;
                }
                else
                {
                    TotalCost = (int)Price.Car * 2;
                }
            }
            else if (TimeSinceParked >= 120)
            {
                double parkedMinutes = Math.Abs(TimeSinceParked);

                if (vehicle.TypeOfVehicle == "mc")
                {
                    TotalCost = Math.Ceiling((parkedMinutes / 60)) * (int)Price.Mc;
                }
                else
                {
                    TotalCost = Math.Ceiling((parkedMinutes / 60)) * (int)Price.Car;
                }
            }

            return TotalCost;
        }

    }
}