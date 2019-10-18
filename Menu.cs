using System;
using System.Collections.Generic;
using System.Text;

namespace Pragueparking2._01 
{
    class Menu
    {
        private Registry registry;

        public Menu(Registry registry) 
        {
            this.registry = registry;
        }
        public void MainMenu() 
        {
            Console.Clear();
            DateTime localDate = DateTime.Now;
            DayOfWeek wk = DateTime.Today.DayOfWeek;
            Console.WriteLine("******************************\n" + "******************************\n"
               + "*                             *\n"
               + "* Prague Parking System 2.0.  *\n" + "*                             *\n" + "{0},{1}\n" + "*******************************", localDate, wk);
            Console.WriteLine("*******************************");
            Console.WriteLine("*******************************");
            Console.WriteLine("*What do you want to do?*******");
            Console.WriteLine("*(1)-{Add new Vehicle}\n" + "*(2)-{Search Vehicle}\n" + "*(3)-{Collect Vehicle}\n" + "*(4)-{ParkingList}\n" + "*(5)-{MoveVehicle}\n" + "*(6)-{Save File}\n" + "*(7)-{Read File}\n" + "*(8)-{Exit Application}");
            string Action = Console.ReadLine();
            Action.ToLower();
            switch (Action)
            {
                case "1":
                    Console.Clear();
                    registry.Add();
                    break;
                case "2":
                    //SearchVehicle();
                    break;
                case "3":
                   // CollectVehicle();
                    break;
                case "4":
                   // ParkingList();
                    break;
                case "5":
                   // MoveVehicle();
                    break;
                case "6":
                   // SaveToFile();

                    break;
                case "7":
                   // LoadFromFile();
                    break;
                case "8":
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    MainMenu();
                    break;
            }
        }
    }
}

