using System;
using System.Collections.Generic;

class Program
{
    static List<string> pizzaMenu = new List<string>
    {
        "Margherita - $10",
        "Pepperoni - $12",
        "Vegetarian - $11",
        "BBQ Chicken - $13",
        "Hawaiian - $14"
    };

    static List<string> todayOffers = new List<string>
    {
        "Buy 1 Get 1 Free on Margherita!",
        "20% off on BBQ Chicken!",
        "Free drink with any large pizza!"
    };

    static List<string> ratings = new List<string>();

    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Welcome to Pizza Management System!");
            Console.WriteLine("1. Pizza Menu");
            Console.WriteLine("2. Today's Offers");
            Console.WriteLine("3. Rate Us");
            Console.WriteLine("0. Exit");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ShowPizzaMenu();
                    break;
                case "2":
                    ShowOffers();
                    break;
                case "3":
                    RateUs();
                    break;
                case "0":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Press any key to try again.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void ShowPizzaMenu()
    {
        Console.Clear();
        Console.WriteLine("Pizza Menu:");
        foreach (var pizza in pizzaMenu)
        {
            Console.WriteLine(pizza);
        }
        Console.WriteLine("Press 0 to back");
        Console.ReadLine();
    }

    static void ShowOffers()
    {
        Console.Clear();
        Console.WriteLine("Today's Offers:");
        foreach (var offer in todayOffers)
        {
            Console.WriteLine(offer);
        }
        Console.WriteLine("Press 0 to back");
        Console.ReadLine();
    }

    static void RateUs()
    {
        Console.Clear();
        Console.Write("Please rate us (1 to 5): ");
        string rating = Console.ReadLine();

        if (int.TryParse(rating, out int ratingValue) && ratingValue >= 1 && ratingValue <= 5)
        {
            ratings.Add(rating);
            Console.WriteLine("Thank you for your rating!");
        }
        else
        {
            Console.WriteLine("Invalid rating. Please enter a number between 1 and 5.");
        }

        Console.WriteLine("Press 0 to back");
        Console.ReadLine();
    }
}
