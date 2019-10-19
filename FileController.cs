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
       
        public FileController(Registry  registry) 
        {
            this.registry = registry;
        }
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

                while (read != null && read.Length > 5)
                {
                    for (int i = 0; i < read.Length - 1; i++)
                    {
                        if (read[i] == ' ')
                        {
                            Stringpoints.Add(i);
                        }
                    }
                    Type = read.Substring(Stringpoints[0] + 1, ((Stringpoints[1]) - (Stringpoints[1])));
                    regnumb = read.Substring(0, Stringpoints[0]);
                    parkspot = Convert.ToInt32(read.Substring(Stringpoints[2] + 1, read.Length - (Stringpoints[2] + 1)));
                    TimeWhenParked = Convert.ToDateTime(read.Substring(Stringpoints[1] + 1, 8));

                    registry.ReadFromFile(regnumb, Type, parkspot,(DateTime)TimeWhenParked);
                    Stringpoints.Clear();
                    read = ReadFile.ReadLine();
                }
            }
        }
    }
}

