
using System;

class Startup
{
    private static void Main(string[] args)
    {
        Engine engine = new Engine();

        engine.Run();

        //7
        //var suitArray = typeof(CardSuit).GetEnumValues();
        //var rankArray = typeof(CardRank).GetEnumValues();

        //foreach (var suit in suitArray)
        //{
        //    foreach (var rank in rankArray)
        //    {
        //        Console.WriteLine($"{rank} of {suit}");
        //    }
        //}

        //6
        //string input = Console.ReadLine();
        //object[] rankAttributes = typeof(CardRank).GetCustomAttributes(false);
        //object[] suitAttributes = typeof(CardSuit).GetCustomAttributes(false);
        //switch (input)
        //{
        //    case "Rank":
        //        foreach (TypeAttribute attr in rankAttributes)
        //        {
        //            Console.WriteLine($"Type = {attr.Type}, Description = {attr.Description}");
        //        }
        //        break;
        //    case "Suit":
        //        foreach (TypeAttribute attr in suitAttributes)
        //        {
        //            Console.WriteLine($"Type = {attr.Type}, Description = {attr.Description}");
        //        }
        //        break;
        //}
    }
}