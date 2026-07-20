//! Class Notes
{
    // int x = 1001;
    // int y = 0;
    // int result;

    //* try - catch expressions make error checking easier

    // try
    // {
    //     if (x >= 1000)
    //     {
    //         throw new ArgumentOutOfRangeException("x has to be 1000 or less");
    //     }
    //     result = x / y;
    //     Console.WriteLine($"The result is: {result}");   
    // } catch (DivideByZeroException e)
    // {
    //     Console.WriteLine(e.Message);
    // } catch (ArgumentOutOfRangeException e)
    // {
    //     Console.WriteLine("1000 is the limit");
    //     Console.WriteLine(e.Message);
    // } finally
    // {
    //     Console.WriteLine("This code always run");
    // }
}
//! Challenge 1: Take two numbers and divide → DivideByZeroException
{
    // try
    // {
    //     Console.Write("First Number: ");
    //     int firstNumber = Convert.ToInt32(Console.ReadLine());

    //     Console.Write("Second Number: ");
    //     int secondNumber = Convert.ToInt32(Console.ReadLine());

    //     int result = firstNumber / secondNumber;
    //     Console.WriteLine($"{firstNumber} / {secondNumber} = {result}");
    // }
    // catch (DivideByZeroException e)
    // {
    //     Console.WriteLine($"Divider cannot be zero: {e.Message}");
    // } catch (FormatException e)
    // {
    //     Console.WriteLine($"Invalid Entry: {e.Message}");
    // }
}
//! Challenge 2: Take age from user between 0 - 120
{
    // try
    // {
    //     Console.Write("Enter Your Age: ");
    //     int age = Convert.ToInt32(Console.ReadLine());

    //     if (age < 0 || age > 120)
    //     {
    //         throw new ArgumentOutOfRangeException("Age must be between 0 - 120");
    //     }

    //     Console.WriteLine($"You are {age} years old.");
    // }
    // catch (ArgumentOutOfRangeException e)
    // {
    //     Console.WriteLine($"Out of Range: {e.Message}");
    // } 
    // catch (FormatException e)
    // {
    //     Console.WriteLine($"Invalid Entry: {e.Message}");
    // }
}
//! Challenge 3: Take number, if it is not a number ?
{
    // try
    // {
    //     Console.Write("Enter Number: ");
    //     int number = Convert.ToInt32(Console.ReadLine());
    // }
    // catch (FormatException e)
    // {
    //     Console.WriteLine($"Invalid Number: {e.Message}");
    // }
}
//! Bonus Challenge: Mini ATM Machine
{
    // decimal balanceAmount = 1000m;
    // int userChoice = 0;
    // do {
    // try
    // {
    //     Console.Write(
    //         """
    //         1 → Withdraw
    //         2 → Deposit
    //         3 → Balance
    //         4 → Exit
    //         Choose Your Option(1,2,3,4): 
    //         """
    //     );
    //     userChoice = Convert.ToInt32(Console.ReadLine());

    //     if (userChoice < 1 || userChoice > 4)
    //     {
    //         throw new ArgumentOutOfRangeException("Please make a valid choice(1 to 4)");
    //     } else if (userChoice == 1)
    //     {
    //         Console.Write("The amount you wish to withdraw: ");
    //         decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
    //         if (withdrawAmount > balanceAmount)
    //         {
    //           throw new ArgumentOutOfRangeException("The amount you wish to withdraw is greater than your balance");  
    //         }
    //         balanceAmount -= withdrawAmount;
    //         Console.WriteLine($"New Amount: {balanceAmount:C}");
    //     } else if (userChoice == 2)
    //     {
    //         Console.Write("The amount you wish to deposit: ");
    //         decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
    //         if (depositAmount > 500)
    //         {
    //             throw new ArgumentOutOfRangeException("You cannot deposit more than 500 ₺ at a time");
    //         }
    //         balanceAmount += depositAmount;
    //         Console.WriteLine($"New Balance: {balanceAmount:C}");
    //     } else if (userChoice == 3)
    //     {
    //         Console.WriteLine($"Your Balance: {balanceAmount:C}");
    //     } 
    // }
    // catch (FormatException e)
    // {
    //     Console.WriteLine($"Invalid Entry: {e.Message}");
    // } 
    // catch (ArgumentOutOfRangeException e)
    // {
    //     Console.WriteLine(e.Message);
    // }
    // } while (userChoice != 4);
}