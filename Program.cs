using System;

namespace Pragueparking2._01
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Run();
        }
        private Menu menu;
        private Registry registry;
        private FileController fileController;
        private Vehicle vehicle;
        //constructor
        public Program()
        {
            registry = new Registry();
            fileController = new FileController();
            menu = new Menu(registry,fileController);
            
        }
        private void Run()
        {
            //Test
            string reg = "123456";
            DateTime now = DateTime.Now;
            var testTime = now.Subtract(TimeSpan.FromHours(5));
            registry.RegisterVehicle("mc", reg, 1, testTime);
            Vehicle vehicle = registry.SearchWithRegNumber(reg);
            registry.RemoveVehicle(vehicle);
            double cost = registry.CalculateTheCost(vehicle);
            Console.WriteLine($"Cost: {cost}");
            Console.ReadKey();

            menu.MainMenu();

        }
    }
}
