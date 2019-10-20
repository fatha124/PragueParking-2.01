using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Pragueparking2._01
{
    public class FileController
    {
        // private static StreamReader ReadFile;
        //private static StreamWriter WriteFile;
        private Registry registry;

        public FileController(Registry registry)
        {
            this.registry = registry;
        }
        public void SaveToFile()
        {
            Save();
        }
        public StringBuilder Save()
        {
            StringBuilder BuiltString = new StringBuilder();
            foreach (Vehicle vehicle in registry.Vehicles)
            {
                BuiltString.Append($"{vehicle.TypeOfVehicle}\n"
                + $"{vehicle.RegNumber}\n"
                    + $"{vehicle.DateAndTimeParked}\n"
                    + $"{vehicle.ParkingSpot}\n");
            }
            string s = BuiltString.ToString();
            File.WriteAllText("ParkingLot.txt", s);
            return BuiltString;
        }
        public void Read()
        {
            string[] input = File.ReadAllLines("ParkingLot.txt");
            for (int i = 0; i < input.Length; i += 4)
            {
                registry.Vehicles.Clear();
                string Type = input[i];
                string regnumb = input[i + 1];
                string TimeWhenParked = input[i + 2];
                string parkspot = input[i + 3];
                int park = Int32.Parse(parkspot);
                DateTime time = Convert.ToDateTime(TimeWhenParked);
                registry.RegisterVehicle(regnumb, Type, park, time);
            }
        }
    }
}

