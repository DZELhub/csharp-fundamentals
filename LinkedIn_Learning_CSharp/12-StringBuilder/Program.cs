//! Class Notes
using System.Globalization;
using System.Text;
{
    // int jumpCount = 10;
    // string[] animals = {"goats", "cats", "pigs"};

    // //* Create string builder

    // StringBuilder sb = new StringBuilder("Initial string.",200);

    // //* Print some basic stats about the StringBuilder

    // Console.WriteLine($"Capacity: {sb.Capacity}; Length: {sb.Length}");

    // //* Add some strings to the builder using Append

    // sb.Append("The quick brown fox ");
    // sb.Append("jumped over the lazy dog.");

    // //* AppendLine can append a line ending

    // sb.AppendLine();

    // //* AppendFormat can be used to append formatted strings

    // sb.AppendFormat($"He did this {jumpCount} times.");
    // sb.AppendLine();

    // //* AppendJoin can iterate over a set of values

    // sb.Append("He als jumped over ");
    // sb.AppendJoin(",", animals);

    // //* Modify the content using Replace

    // sb.Replace("fox","cat");

    // //* Insert content at any index

    // sb.Insert(0, "This is the ");

    // //* Convert to a single string

    // Console.WriteLine($"Capacity: {sb.Capacity}; Length: {sb.Length}");
    // Console.WriteLine(sb.ToString());
}
//! Game Challenge: Create RPG Character Screen → playerName, level, health, mana, gold
{
    // string playerName = "Arin";
    // int level = 18;
    // int health = 240;
    // int mana = 90;
    // int gold = 1250;
    
    // StringBuilder character = new StringBuilder ("Player Status", 200);

    // character.Insert(0,"=================\n");
    // character.AppendLine();
    // character.Append("=================");
    // character.AppendLine();
    // character.AppendFormat("{0,-7}: {1}", "Name", playerName);
    // character.AppendLine();
    // character.AppendFormat("{0,-7}: {1}", "Level", level);
    // character.AppendLine();
    // character.AppendFormat("{0,-7}: {1}", "HP", health);
    // character.AppendLine();
    // character.AppendFormat("{0,-7}: {1}", "Mana", mana);
    // character.AppendLine();
    // character.AppendFormat(new CultureInfo("tr-TR"),"{0,-7}: {1:N0}", "Gold", gold);

    // Console.WriteLine(character.ToString());
}
//! Sector Challenge: Create order summary → customerName, orderNumber, product[], prices[]
{
    // string customerName = "D.Z.E.L.";
    // int orderNumber = 11122022;
    // string[] products = {"Mouse", "Keyboard", "Monitor"};
    // decimal[] prices = {500m, 1800m, 7500m};
    // decimal total = 0;

    // StringBuilder sb = new StringBuilder("ORDER SUMMARY",200);
    // sb.AppendLine();
    // sb.AppendLine();
    // sb.AppendFormat("{0,-10}: {1}", "Customer", customerName);
    // sb.AppendLine();
    // sb.AppendFormat("{0,-10}: {1}", "Order No", orderNumber);
    // sb.AppendLine();
    // sb.AppendLine();
    // sb.AppendFormat("{0,-10} {1}", "Products", "Prices");
    // sb.AppendLine();
    // sb.Append("---------------------");
    // sb.AppendLine();
    // for (int i = 0; i < products.Length; i++)
    // {
    //     sb.AppendFormat("{0,-10} {1:C}\n", products[i], prices[i]);
    // }
    // sb.AppendLine();
    // sb.Append("---------------------");
    // sb.AppendLine();
    // foreach (decimal price in prices)
    // {
    //     total+=price;
    // }
    // sb.AppendFormat("{0,-10}:{1:C}\n", "Total", total);

    // Console.WriteLine(sb.ToString());
}
//! Bonus Challenge
{   
    // StringBuilder sb = new StringBuilder("",200);
    // sb.AppendLine("Day 14");
    // sb.AppendLine();
    // sb.AppendLine("Weather : Rainy");
    // sb.AppendLine();
    // sb.AppendLine("Location : Old Pier");
    // sb.AppendLine();
    // sb.AppendLine("Drink : Tea");
    // sb.AppendLine();
    // sb.AppendLine("People Passed : 7");
    // sb.AppendLine();
    // sb.AppendLine("Nothing happened today.");
    // Console.WriteLine(sb.ToString());
}