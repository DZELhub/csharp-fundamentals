//! Class Notes: String Parsing
using System.Globalization;
{
    // string numStr1 = "1";
    // string numStr2 = "2.00";
    // string numStr3 = "3,000";
    // string numStr4 = "3,000.00";

    // //* The parse function attempts to parse a string into a number, but it might throw an exception, so we need to catch that

    // int targetNum = 0;

    // try
    // {
    //     //* Use Parse to try a simple integer

    //     targetNum = int.Parse(numStr1);
    //     Console.WriteLine(targetNum);

    //     //* Use Parse to try a floating point number: This only works if the decimal value is 0

    //     targetNum = int.Parse(numStr2, NumberStyles.Float);
    //     Console.WriteLine(targetNum);

    //     //* Use Parse to try a number with thousands marker

    //     targetNum = int.Parse(numStr3, NumberStyles.AllowThousands);
    //     Console.WriteLine(targetNum);

    //     //* Use Parse to try a number with thousands marker and decimal

    //     targetNum = int.Parse(numStr4, NumberStyles.Float | NumberStyles.AllowThousands);
    //     Console.WriteLine(targetNum);

    //     //* This works with other types too, like bool

    //     Console.WriteLine($"{bool.Parse("True")}");

    //     //* or floating point numbers

    //     Console.WriteLine($"{float.Parse("1.235"):F2}");
    // }
    // catch 
    // {
    //     Console.Write("Conversion Failed!!!");
    // }

    // //* TryParse function is similar but handles the exception for us

    // bool succeeded = false;
    // succeeded = Int32.TryParse(numStr1,out targetNum);

    // if (succeeded)
    // {
    //     Console.WriteLine($"{targetNum}");
    // }
}
//! Game Challenge: Make character creation screen, take characterName and level from user → Rules: level must be number, level must be between 1 - 100, use TryParse(), if it is wrong ask again
{
    // Console.Write("Character Name: ");
    // string characterName = Console.ReadLine() ?? string.Empty;

    // int number;
    
    // while (true)
    // {
    //     Console.Write("Enter Level: ");

    //     if (int.TryParse(Console.ReadLine(), out number) && number >= 1 && number <= 100)
    //     {
    //         break;
    //     }
    //     Console.WriteLine("Invalid Level");
    // }
}
//! Sector Challenge: Take deposit amount from user, use TryParse, if it is not a number ask again, cannot be zero or negative, if it is success return Deposit Successful
{
    // int number;

    // while (true)
    // {
    //     Console.Write("Deposit Amount: ");

    //     if (int.TryParse(Console.ReadLine(), out number) && number > 0)
    //     {
    //         Console.WriteLine("Deposit Successful");
    //         break;
    //     }
    //     Console.WriteLine("Invalid Entry");
        
    // }
}
//! Bonus Challenge: Take health, mana, gold from user and use TryParse;
{
// int health;
// int mana;
// int gold;

// Console.Write("Health: ");
// int.TryParse(Console.ReadLine(), out health);

// Console.Write("Mana: ");
// int.TryParse(Console.ReadLine(), out mana);

// Console.Write("Gold: ");
// int.TryParse(Console.ReadLine(), out gold);

// Console.WriteLine(
//     $"""
//     PLAYER STATUS

//     Health : {health}

//     Mana : {mana}

//     Gold : {gold}   
//     """
// );
}