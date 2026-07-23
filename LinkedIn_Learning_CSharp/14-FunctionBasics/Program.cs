using System;

//! Class Notes: Function Basics
{
    // //* Functions are used to group re-usable code together in a single unit that can be customized with parameters

    // //* Functions have return type, name, and optional parameters

    // float MilesToKm(float miles)
    // {
    //     float result = miles * 1.6f;
    //     return result;
    // }

    // //* A function with no return value has a 'void' type

    // void PrintWithPrefix(string theStr)
    // {
    //     Console.WriteLine($"::> {theStr}");
    // }

    // //* Call first function

    // Console.WriteLine($"The result is: {MilesToKm(8.0f)}");
    // Console.WriteLine($"The result is: {MilesToKm(52.0f)}");

    // //* Call second function

    // PrintWithPrefix("Test String");
    // PrintWithPrefix("Another Test String");
}
//! Game Challenge
{
// string ReadName()
//     {
//         Console.Write("Name: ");
//         string name = Console.ReadLine() ?? string.Empty;
//         return name;
//     }

// int ReadLevel()
//     {
//         int level;
        
//         while (true)
//         {
//             Console.Write("Level: ");
//             if (int.TryParse(Console.ReadLine(), out level) && level > 0)
//             {
//                 break;
//             }
//             Console.WriteLine("Invalid Level");
//         }
//         return level;
//     }

// int hpPerLevel = 10;

// int CalculateHealth(int level)
//     {   
        
//         int health = level * hpPerLevel;
//         return health;
//     }

// void PrintCharacter(string name, int health, int level)
//     {
//         Console.WriteLine(
//             $"""
//             Character Name : {name}
//             Character Level : {level}
//             Charactet Hp : {health}
//             """
//         );
//     }

// string name = ReadName();

// int level = ReadLevel();

// int health = CalculateHealth(level);

// PrintCharacter(name, health, level);
}
//! Business Challenge
{
    // decimal ReadPrice()
    // {
    //     decimal price;
    //     while (true)
    //     {
    //        Console.Write("Price: ");
    //        if (decimal.TryParse(Console.ReadLine(), out price) && price > 0)
    //         {
    //             break;
    //         }
    //         Console.WriteLine("Invalid Price");
    //     }
    //     return price;
    // }

    // int ReadAmount()
    // {
    //     int amount;
    //     while (true)
    //     {
    //         Console.Write("Amount: ");
    //         if (int.TryParse(Console.ReadLine(), out amount) && amount > 0)
    //         {
    //             break;
    //         }
    //         Console.WriteLine("Invalid Amount");
    //     }
    //     return amount;
    // }

    // decimal CalculateTotal(decimal price, int amount)
    // {
    //     decimal totalPrice = price * amount;
    //     return totalPrice;
    // }

    // const decimal taxRate = 0.18m;

    // decimal CalculateTax(decimal totalPrice)
    // {
    //     decimal taxAmount = totalPrice * taxRate;
    //     return taxAmount;
    // }

    // void PrintReceipt (decimal price, int amount, decimal totalPrice, decimal taxAmount)
    // {
    //     Console.WriteLine(
    //         $"""
    //         ============ RECEIPT ============
    //         {"Unit Price",-19}: {price:C}
    //         {"Amount",-19}: {amount}
    //         {"Total Price",-19}: {totalPrice:C}
    //         {"Total Tax",-19}: {taxAmount:C}
    //         {"Price Including Tax",-19}: {totalPrice + taxAmount:C}
    //         =================================
    //         """
    //     );
    // }

    // decimal price = ReadPrice();
    // int amount = ReadAmount();
    // decimal totalPrice = CalculateTotal(price, amount);
    // decimal taxAmount = CalculateTax(totalPrice);
    // PrintReceipt(price, amount, totalPrice, taxAmount);
}
//! Bonus Challenge
{
    // int RollDice()
    // {
    //     Random rnd = new Random();
    //     int octahedralDice = rnd.Next(1,9);
    //     return octahedralDice;
    // }

    // const int Strength = 20;

    // int CalculateStrBonus ()
    // {
    //     int strBonus = (Strength - 10) / 2;
    //     return strBonus;
    // }
    
    // int CalculateDamage(int octahedralDice, int strBonus)
    // {
    //     int damage = strBonus + octahedralDice;
    //     return damage;
    // }

    // const int SkeletonHp = 30;
    // const string CharacterName = "Arin";
    // const string FirstEnemy = "Skeleton";

    // void PrintBattleLog (int damage)
    // {
    //     Console.WriteLine(
    //         $"""
    //         {CharacterName} attacks {FirstEnemy}

    //         Damage: {damage}

    //         {FirstEnemy} HP: {SkeletonHp - damage}
    //         """
    //     );
    // }

    // int octahedralDice = RollDice();
    // int strBonus = CalculateStrBonus();
    // int damage = CalculateDamage(octahedralDice, strBonus);

    // PrintBattleLog(damage);
}