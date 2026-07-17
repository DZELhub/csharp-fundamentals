//! Class Notes
{
    // int theVal = 50;

    // //* Switch statement

    // switch (theVal)
    // {
    //     case 50:
    //         Console.WriteLine("theVal is 50");
    //         break;
    //     case 51:
    //         Console.WriteLine("theVal is 51");
    //         break;
    //     case 52:
    //     case 53:
    //     case 54:
    //         Console.WriteLine("theVal is between 52 and 54");
    //         break;
    //     default:
    //         Console.WriteLine("theVal is something else");
    //         break;
    // }
}
//! Challenge 1 Calculator: Take two number and operation → calculate
{
    // Console.WriteLine(
    //     """
    //     --------------------------------
    //     ---------- Calculator ----------
    //     --------------------------------
    //     """
    // );

    // Console.Write("Enter Number One: ");
    // int numberOne = Convert.ToInt32(Console.ReadLine());

    // Console.Write("Enter Number Two: ");
    // int numberTwo = Convert.ToInt32(Console.ReadLine());

    // Console.Write("Choose an Operator (+,-,/,*): ");
    // char operatorSign = Convert.ToChar(Console.ReadLine() ?? string.Empty);

    // int result = 0;

    // switch (operatorSign)
    // {
    //     case '+':
    //        result = numberOne + numberTwo;
    //        break;
    //     case '-':
    //         result = numberOne - numberTwo;
    //        break;
    //     case '/':
    //         if (numberTwo == 0)
    //         {
    //             Console.WriteLine("Bölen 0 olamaz");
    //         } else
    //         {
    //            result = numberOne / numberTwo; 
    //         }
    //        break;
    //     case '*':
    //         result = numberOne * numberTwo;
    //        break;
    // }
    //     Console.WriteLine($"{numberOne} {operatorSign} {numberTwo} = {result}");
}
//! Challenge 2 Day Finder: Take a number 1 to 7 → Find the day
{
    // Console.WriteLine(
    //     """
    //     --------------------------------
    //     ---------- Day Finder ----------
    //     --------------------------------
    //     """
    // );

    // Console.Write("Enter Number: ");
    // int number = Convert.ToInt32(Console.ReadLine());

    // string result = number switch
    // {
    //     1 => "Monday",
    //     2 => "Tuesday",
    //     3 => "Wednesday",
    //     4 => "Thursday",
    //     5 => "Friday",
    //     6 => "Saturday",
    //     7 => "Sunday",
    //     _ => "Invalid Entry"
    // };

    // Console.WriteLine($"{number}. day is {result}");
}
//! Challenge 3 Traffic Light: Take color (red, yellow, green) → return STOP | READY | GO
{
    // Console.WriteLine(
    //     """
    //     ---------------------------------
    //     --------- Traffic Light ---------
    //     ---------------------------------
    //     """
    // );

    // Console.Write("Choose the Color (Red, Yellow, Green): ");
    // string lightColor = Console.ReadLine() ?? string.Empty;

    // string light = lightColor.ToLower() switch
    // {
    //   "red" => "STOP",
    //   "yellow" => "READY",
    //   "green" => "GO",
    //   _ => "Invalid Entry"  
    // };

    // Console.WriteLine(light);
}
//! Bonus Challenge ATM Menu: 1 → Withdraw | 2 → Deposit | 3 → Balance | 4 → Exit
{
    // Console.WriteLine(
    //     """
    //     ----------------------------
    //     --------- ATM Menu ---------
    //     ----------------------------
    //     """
    // );

    // Console.Write(
    //     """
    //     1 → Withdraw
    //     2 → Deposit
    //     3 → Balance
    //     4 → Exit
    //     Choose Your Option(1,2,3,4): 
    //     """
    // );
    // string operationOption = Console.ReadLine() ?? string.Empty;

    // string choice = operationOption switch
    // {
    //     "1" => "Withdraw",
    //     "2" => "Deposit",
    //     "3" => "Balance",
    //     "4" => "Exit",
    //     _ => "Invalid Option"
    // };

    // Console.WriteLine($"You selected {choice}");
}