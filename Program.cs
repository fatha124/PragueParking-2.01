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
        
        //konstruktor
        public Program()
        {
            menu = new Menu(registry);
            registry = new Registry();
            fileController = new FileController();

        }

        private void Run()
        {
            menu.MainMenu();
        }


    }
}
