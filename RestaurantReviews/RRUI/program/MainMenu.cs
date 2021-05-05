using System;
namespace RRUI
{
    public class MainMenu: IMenu
    {
        public void Start()
        {
            bool repeat = true;
            do{
                Console.WriteLine("Welcome to my Restaurant Reviews Application!");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("[0] View a restaurant");
                Console.WriteLine("[1] Exit");
                string input = Console.ReadLine();
            switch(input)
            {
                case "0":

                    break;
                case "1":
                    Console.WriteLine("Goodbye cruel World");
                    repeat = false;
                    break;
                default:
                    Console.WriteLine("Please choose a valid option");
                    break;
            }
            }while(repeat);
        }
    }

    
}