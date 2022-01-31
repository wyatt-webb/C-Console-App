
using System;
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
        Console.WriteLine("Hello " + username + ".");
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
        Console.Write("Please enter the length of the rectangle: ");
        float length = float.Parse(Console.ReadLine());
        Console.Write("Please enter the width of the rectangle: ");
        float width = float.Parse(Console.ReadLine());

    }

    public static void MPGCalculator()
    {
        Console.Write("Please enter the miles travled: ");
        float miles = float.Parse(Console.ReadLine());
        Console.Write("Please enter the gallons of fuel used: ");
        float gallons = float.Parse(Console.ReadLine());

        float mpg = miles / gallons;

        Console.WriteLine(mpg);
    }

    public static void SearchString()
    {
        string aaiw = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";

        Console.Write("Please enter the string you would like to look for within the the first sentence of Alice's Adventures in Wonderland: ");
        string searchString = Console.ReadLine();

    }
}