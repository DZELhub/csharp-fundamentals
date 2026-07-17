//! Class Notes
using System.IO.Pipelines;
{
    // int myVal = 15;
    // int[] nums = new int[] {3, 14, 15, 92, 6};
    // string str = "The quick brown fox jumps over the lazy dog";

    // //* Basic for loop

    // for (int i = 0; i <= myVal; i++)
    // {
    //     Console.WriteLine($"i is currently {i}");
    // }

    // //* foreach loop

    // foreach (int i in nums)
    // {
    //     Console.WriteLine($"i is currently {i}");
    // }

    // //* count the number of "o" in the string

    // int count = 0;

    // foreach (char c in str)
    // {
    //     if (c == 'o')
    //     {
    //         count ++;
    //     }
    // }
    // Console.WriteLine($"Counted {count} 'o' characters");
}
//! Challenge 1 Even Numbers: 1 to 100 → find the even numbers
{
    // for (int i = 1; i <= 100; i++)
    // {
    //     if (i % 2 == 0)
    //     {
    //         Console.WriteLine(i);
    //     }
    // }

    //* foreach için elimde 1-100 arası sayıların bulunduğu bir collection olması lazım. O nedenle for daha uygun.
}
//! Challenge 2 Multiplication Table: take a number and multiplicate from 1 to 10
{
    // Console.Write("Enter Number: ");
    // int number = Convert.ToInt32(Console.ReadLine());

    // for (int i = 1; i <= 10; i++)
    // {
    //     int result = number * i;
    //     Console.WriteLine($"{number} x {i} = {result}");
    // }
}
//! Challenge 3 Count Vowels: Taka a text and count vowels
{
    // Console.Write("Write a Text: ");
    // string enteredText = Console.ReadLine() ?? string.Empty;

    // char[] vowels = new char[] {'a','e','ı','i','o','ö','u','ü'};

    // int counter = 0;

    // foreach (char c in enteredText.ToLowerInvariant())
    // {
    //     foreach (char v in vowels)
    //     {
    //         if (c == v)
    //         {
    //             counter ++;
    //         }
    //     }
    // }

    // Console.WriteLine($"Number of vowels in your text: {counter}");
}
//! Bonus Challenge: Find Maximum from an array
{
    // int[] numbers = { 14, 8, 25, 3, 19, 42, 11 };

    // int maxNumber = 0;

    // foreach (int num in numbers)
    // {
    //     if (num > maxNumber)
    //     {
    //         maxNumber = num;
    //     }
    // }
    // Console.WriteLine($"Max Number is: {maxNumber}");
}