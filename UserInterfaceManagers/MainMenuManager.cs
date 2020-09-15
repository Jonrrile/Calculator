using System;

namespace Calculator_Challenge.UserInterfaceManagers
{
    public class MainMenuManager : IUserInterfaceManager
    {

        public IUserInterfaceManager Execute()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Welcome to Calculatron 3000!");
            Console.WriteLine("1) Add two numbers");
            Console.WriteLine("2) Subtract two numbers");
            Console.WriteLine("3) Multiply two numbers");
            Console.WriteLine("4) Divide two numbers");
            Console.WriteLine("0) Exit");

            Console.WriteLine("> ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    return null;
                case "2":
                    return null;
                case "3":
                    return null;
                case "4":
                    return null;
                case "0":

                    return null;
                default:
                    Console.WriteLine("You idiot");
                    return this;
            }
        }
    }
}