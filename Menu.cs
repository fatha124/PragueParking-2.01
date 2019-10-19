using System;
using System.Collections.Generic;
using System.Text;

namespace Pragueparking2._01 
{
  public class Menu
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
                    AddVehicle() ;
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

        public  void AddVehicle()
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
                if (registry.CheckForDup(regnumb) == false)
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
                    while (registry.CheckIfSpotIsTaken(parkspot, type))
                    {
                        Console.WriteLine("The chosen spot {0} is  already taken\n" + "Please try again... ", parkspot);
                        int.TryParse(Console.ReadLine(), out parkspot);
                        while (parkspot == 0 || parkspot > 100 || parkspot < 0)
                        {
                            Console.WriteLine("Invalid spot, choose a parkingspot between spot 1 - 100 ");
                            int.TryParse(Console.ReadLine(), out parkspot);
                            Console.Clear();
                        }
                    }
                    Console.Clear();
                    registry.RegisterVehicle(type, regnumb, parkspot, TimeWhenParked);
                    Console.WriteLine("Your {0} with regnumber {1} has been parked at spot {2}.\n" + " At the current time {3}\n" + "Press enter to continue...", type, regnumb, parkspot, TimeWhenParked);
                    Console.ReadKey();
                    MainMenu();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("{0} already exist in the system.\n" + "Press any key to continue", regnumb);
                    Console.ReadKey();
                    AddVehicle();
                }
            }
            else
            {
                AddVehicle();
            }
        }
        public void CollectVehicle() 
        {
            Console.Clear();
            Console.WriteLine("Enter registration number: ");
            string regnumb = Console.ReadLine();
            regnumb.ToLower();
            Vehicle vehicle = registry.SearchWithRegNumber(regnumb);
            while (vehicle == null)
            {

                Console.Clear();
                Console.WriteLine("Your vehicle with regnumber {0} does not exist in the system.\n" +
                    " Press enter to continue...", regnumb);
                Console.WriteLine("Or press {M} to return to the menu");
                string action = Console.ReadLine();
                action.ToLower();
                if (action == "M")
                {
                    MainMenu();
                }
                else
                {
                    CollectVehicle();
                }
                if (vehicle != null) 
                {
                
                }

            }

        }

    }
}

