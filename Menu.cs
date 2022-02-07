using System;
using System.Text.RegularExpressions;
public class Menu
{
    public static string GetName()
    {
        Console.Write("Please enter your name: ");
        string username = Console.ReadLine();
        if(username == null) username = "Username";
        return username;
    }

    public static void GreetUser(string username)
    {
        Console.Clear();
        Console.WriteLine($"Hello {username}.");
    }

    public static void PrintOptions()
    {
        string[] options = {"1. Greeting", "2. Area Calculator", "3. MPG Calculator", "4. Search String"};
        Console.WriteLine("\nPlease enter exit to stop the program.");
        foreach (string item in options)
        {
            Console.WriteLine(item);
        }
    }

    public static void AreaCalculator()
    {
        Console.Clear();
        Console.Write("Please enter the length of the rectangle: ");
        float length = float.Parse(Console.ReadLine());
        Console.Write("Please enter the width of the rectangle: ");
        float width = float.Parse(Console.ReadLine());

        float area = length * width;
        Console.WriteLine($"The area is: {area}");
    }

    public static void MPGCalculator()
    {
        Console.Clear();
        Console.Write("Please enter the miles travled: ");
        float miles = float.Parse(Console.ReadLine());
        Console.Write("Please enter the gallons of fuel used: ");
        float gallons = float.Parse(Console.ReadLine());

        float mpg = miles / gallons;
        Console.WriteLine($"The vehicle had an MPG of {mpg}");
    }

    public static void SearchString()
    {
        Console.Clear();
        string aaiw = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
        
        Console.WriteLine("Do you wish to search the first sentence of Adventures of Alice in Wonderland with case-senstivity? (Yes) or (No)");
        string searchSensitivity = Console.ReadLine();
        if(searchSensitivity.Contains("Y") == true || searchSensitivity.Contains("y") == true)
		{
            Console.Write("\nPlease enter the string you would like to look for within the the first sentence of Alice's Adventures in Wonderland: ");
            string searchString = Console.ReadLine();
            if (searchString == "")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nYou have searched for a space.");
                Console.ResetColor();
            }
            
            bool searchResult = aaiw.Contains(searchString);
            if (searchResult == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n{searchString} found: {searchResult}");
                Console.ResetColor();
            }
            else//String not found
			{
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\n{searchString} found: {searchResult}");
                Console.ResetColor();
            }
        }
        else//Case-sensitivity off
        {
            Console.Write("Please enter the string you would like to look for within the the first sentence of Alice's Adventures in Wonderland: ");
            string searchString = Console.ReadLine();

            //Make it insensitive
            searchString = searchString.ToLower();
            string aaiwLower = aaiw.ToLower();

            bool searchResult = aaiwLower.Contains(searchString);
            if (searchString == " ")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You have searched for a space.");
                Console.ResetColor();
                Console.WriteLine($"\nA space was found: {searchResult}");
                return;
            }

            if (searchString == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nYou have searched for nothing.");
                Console.ResetColor();
                Console.WriteLine("\nIs it possible to find nothing?");
                return;
            }

            if (searchResult == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n{searchString} found: {searchResult}");
                Console.ResetColor();
            }

            else//String not found
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\n{searchString} found: {searchResult}");
                Console.ResetColor();
            }            
        }
    }
}