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
        
        //constructor
        public Program()
        {
            registry = new Registry();
            fileController = new FileController();
            menu = new Menu(registry);
           

        }

        private void Run()
        {
            menu.MainMenu();
        }


    }
}
