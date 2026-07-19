//! Class Notes
{
    //* Basic while loop executes while the gate condition is true

    // string inputStr = " ";
    // while (inputStr != "exit")
    // {
    //     Console.Write("Exit/Continue: ");
    //     inputStr = (Console.ReadLine() ?? string.Empty).ToLowerInvariant();
    //     Console.WriteLine($"You entered: {inputStr}");
    // } 

    //* The do-while loop always executes at least one time

    // do {
    //     Console.Write("Exit/Continue: ");
    //     inputStr = (Console.ReadLine() ?? string.Empty).ToLowerInvariant();
    //     Console.WriteLine($"You entered: {inputStr}");
    // } while (inputStr != "exit");
}
//! Challenge 1 — Password Retry
{
    // string password = "123456";
    // string enteredPassword = "";
   
    // while (enteredPassword != password)
    // {
    //     Console.Write("Password: ");
    //     enteredPassword = Console.ReadLine() ?? string.Empty;
    //    if (enteredPassword != password)
    //     {
    //         Console.WriteLine("Password invalid. Please try again.");
    //     } else
    //     {
    //         Console.WriteLine("Welcome!");
    //     } 
    // }
}
//! Challenge 2 — Guess the Number
{
    // int secretNumber = 42;
    // int inputNumber = 0;

    // while (inputNumber != secretNumber)
    // {
    //     Console.Write("Guess the Secret Number: ");
    //     inputNumber = Convert.ToInt32(Console.ReadLine());
    //     if (inputNumber < secretNumber)
    //     {
    //         Console.WriteLine("Too Low");
    //     } else if (inputNumber > secretNumber)
    //     {
    //         Console.WriteLine("Too High");
    //     } else
    //     {
    //         Console.WriteLine("Correct!");
    //     }
    // }
}
//! Challenge 3 — Mini Menu: 1 - Say Hello | 2 - Show Time | 3 - Exit
{
    // int userChoice = 0;

    // do
    // {
    //     Console.Write(
    //         """
    //         1 - Say Hello
    //         2 - Show Time
    //         3 - Exit
    //         Choose(1,2,3): 
    //         """
    //     );
    //     userChoice = Convert.ToInt32(Console.ReadLine());
    // } while (userChoice != 3);
}
//! Bonus Challenge — Calculator Loop
{
//     Console.WriteLine(
//         """
//         --- Welcome to D.Z.E.L. ---
//         --- Calculator.exe 1.0  ---
//         """
//     );

// bool isProceed = false;

// do
// {
//     Console.Write("Enter First Number: ");
//     int firstNumber = Convert.ToInt32(Console.ReadLine());

//     Console.Write("Enter Second Number: ");
//     int secondNumber = Convert.ToInt32(Console.ReadLine());

//     Console.Write("Choose the Operator (+,-,*,/): ");
//     char operatorSign = Convert.ToChar((Console.ReadLine()??string.Empty).ToLowerInvariant());

//     int result = 0;
    
//     switch (operatorSign)
//     {
//         case '+':
//             result = firstNumber + secondNumber;
//             break;
//         case '-':
//             result = firstNumber - secondNumber;
//             break;
//         case '*':
//             result = firstNumber * secondNumber;
//             break;
//         case '/':
//             if (secondNumber == 0)
//                 {
//                     Console.WriteLine("The divisor cannot be zero");
//                     return;
//                 } else
//                 {
//                     result = firstNumber / secondNumber;
//                 }
//             break;
//         default:
//             Console.WriteLine("Invalid Operation");
//             break;
//     }
//     Console.WriteLine($"{firstNumber} {operatorSign} {secondNumber} = {result}");
//     Console.Write("Do another calculation? (Y/N): ");
//     string userChoice = (Console.ReadLine()??string.Empty).ToLowerInvariant();
//     isProceed = userChoice == "y" ? true : false;
// } while (isProceed);
   
}