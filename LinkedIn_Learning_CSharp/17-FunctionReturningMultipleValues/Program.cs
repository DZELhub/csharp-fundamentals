//! ClassNote: Returning Multiple Values
{
    // //* Tuples are grouped values added in C# 7

    // (int a, int b) tup1 = (5, 10);

    // var tup2 = ("Some text", 10.5f);

    // //* Tuple values are mutable

    // tup1.b = 20;

    // tup2.Item1 = "New String";

    // Console.WriteLine($"{tup1.a}, {tup1.b}");
    // Console.WriteLine($"{tup2.Item1}, {tup2.Item2}");

    // //* Functions can work with tuples

    // (int, int) result = PlusTimes(6, 12);
    // Console.WriteLine($"Sum: {result.Item1}, Product: {result.Item2}");

    // //* Functions can return multiple values using tuples

    // static (int, int) PlusTimes (int a, int b)
    // {
    //     return (a+b, a*b);
    // }
}
//! Game Challenge
{
// (int damage, bool critical) = Attack(20);

// Console.WriteLine(
//     $"""
//     {new string('=', 20)}
//     {new string('=', 6)} Attack {new string('=', 6)}
//     {new string('=', 20)}

//     {"Damage",-9}: {damage}
//     {"Critical",-9}: {critical}
//     """
// );

// static (int damage, bool critical) Attack(int strength)
// {   
//     Random rnd = new Random();
//     int octahedralDice = rnd.Next(1,9);
//     int strBonus = (strength - 10) / 2;
//     int damage = strBonus + octahedralDice;
//     bool critical = false;
//     if (damage >= 10)
//     {
//         critical = true;
//         if (critical)
//         {
//             damage *= 2;
//         }                   
//     }

    

//     return (damage, critical);
// }
}
//! Business Challenge
{
// (decimal subtotal, decimal tax, decimal grandTotal) = CalculateInvoice(100m,10);

// static (decimal subtotal, decimal tax, decimal grandTotal) CalculateInvoice(decimal unitPrice, int quantity)
//     {
//         decimal subtotal = unitPrice * quantity;
//         decimal taxRate = 0.20m;
//         decimal tax = subtotal * taxRate;
//         decimal grandTotal = subtotal + tax;
//         return (subtotal, tax, grandTotal );
//     }

// void PrintInvoice (decimal subtotal, decimal tax, decimal grandTotal)
//     {
//         Console.WriteLine(
//             $"""
//             {new string('=', 6)} Invoice {new string('=', 6)}

//             {"Sub Total",-11}: {subtotal:C}
//             {"Tax",-11}: {tax:C}
//             {"Grand Total", -11}: {grandTotal:C}

//             {new string('=', 21)}
//             """
//         );
//     }

// PrintInvoice(subtotal, tax, grandTotal);
}
//! Bonus Challenge 
{
// (string enemyName, int remainingHp, bool defeated) = AttackEnemy ("Harlan", 25, 20);

// static (string enemyName, int remainingHp, bool defeated) AttackEnemy(string enemyName, int enemyHp, int playerStrength)
//     {
//         Random rnd = new Random();
//         int octahedralDice = rnd.Next(1,9);
//         int strBonus = (playerStrength - 10) / 2;
//         int damage = strBonus + octahedralDice;
//         bool critical = false;
//         bool defeated = false;
//         if (damage >= 10)
//         {
//             critical = true;
//             if(critical)
//             {
//                 damage *= 2;
//             }
//         }
//         int remainingHp = enemyHp - damage;
        
//         if (remainingHp <= 0)
//         {
//             defeated = true;
//         }

//         return (enemyName, Math.Max(0, remainingHp), defeated);
//     }

// void PrintBattle (string enemyName, int remainingHp, bool defeated)
//     {
//         Console.WriteLine(
//             $"""
//             {new string('=', 6)} BATTLE {new string('=', 6)}
//             {"Enemy Name",-12}: {enemyName}
//             {"Remaining HP",-12}: {remainingHp}
//             {"Defeated",-12}: {defeated}
//             {new string('=', 20)}
//             """
//         );
//     }

// PrintBattle(enemyName, remainingHp, defeated);
}