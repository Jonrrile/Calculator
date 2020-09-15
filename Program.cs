using System;
using Calculator_Challenge.UserInterfaceManagers;

namespace Calculator_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserInterfaceManager ui = new MainMenuManager();
            while (ui != null)
            {
                ui = ui.Execute();
            }
        }
    }
}