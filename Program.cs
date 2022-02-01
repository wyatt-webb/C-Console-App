using System;
class Program
{
    public static void Main (string[] args) 
    {
        string menuselection = "";
        while( menuselection!= "Exit Menu")
        {
            Menu.PrintOptions();
            menuselection = Console.ReadLine();

            if(menuselection == "1")
            {
                Menu.GreetUser(Menu.GetName());
            }

            else if(menuselection == "2")
            {
                Menu.AreaCalculator();
            }

            else if(menuselection == "3")
            {
                Menu.MPGCalculator();
            }

            else if(menuselection == "4")
            {
                Menu.SearchString();
            }

            else if(menuselection == "")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Please enter a menu option.");
                Console.ResetColor();
            }

            else//User trying to exit or bad input
            {
                Console.ForegroundColor = ConsoleColor.Red;
                menuselection = menuselection.ToUpper();
                if(menuselection == "EXIT" || menuselection == "STOP" || menuselection == "QUIT")//Trying to exit
                {
                    Console.WriteLine("Exitting");
                    menuselection = "Exit Menu";
                    Console.ResetColor();
                }

                else//Bad input
                {
                    Console.WriteLine("\nThat is not a valid option.");
                    Console.ResetColor();
                }
            }
        }
    }

}


