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
            foreach(Vehicle vehicle in registry.Vehicles) 
            {
            
            }
            return BuiltString;
        }
    }
}

