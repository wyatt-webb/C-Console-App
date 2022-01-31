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
                Console.WriteLine("Please enter a menu option.");
            }

            else
            {
                menuselection = menuselection.ToUpper();
                if(menuselection == "Exit" || menuselection == "Stop")
                {
                    menuselection = "Exit Menu";
                }
            }
        }
    }

}


