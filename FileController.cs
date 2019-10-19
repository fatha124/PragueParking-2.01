using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Pragueparking2._01
{
    public class FileController
    {
        private static StreamReader ReadFile;
        private static StreamWriter WriteFile;
        private Registry registry;
        public void SaveToFile()
        {
            using (WriteFile = new StreamWriter("ParkingLot.txt"))
            {
                WriteFile.Write(Save());
            }
        }
        public StringBuilder Save()
        {
            StringBuilder BuiltString = new StringBuilder();
            foreach (Vehicle vehicle in registry.Vehicles)
            {
                BuiltString.Append($"{vehicle.TypeOfVehicle}\n"
                + $"{vehicle.RegNumber}\n"
                    + $"{vehicle.DateAndTimeParked}\n"
                    + $"{vehicle.ParkingSpot}");
            }
            return BuiltString;
        }
        public void Read() 
        {
            List<int> Stringpoints = new List<int>();

            string Type = null;
            string regnumb = null;
            int parkspot;
            DateTime? TimeWhenParked = null;
            using (ReadFile = new StreamReader("ParkingLot.txt")) 
            {
                string read = ReadFile.ReadLine();

            }
        }
    }
}

