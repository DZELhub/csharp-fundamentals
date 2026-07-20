//! Class Notes: String Formatting
{
    // int[] quarters = {1,2,3,4};
    // int[] sales = {100000, 150000, 200000, 223000};
    // double[] intlMixPct = {.386, .413, .421, .457};
    // string str1 = "TestStr";
    // int val1 = 1234;
    // decimal val2 = 1234.5678m;

    // //* Basic formatting information

    // Console.WriteLine("{0}", str1);

    // //* TODO: Specifying numerical formatting
    // //* General format is {index[,alignment]:[format]}
    // //* Common types are N (Number), G (General), F (Fixed-point), E (Exponential), D (Decimal), P (Percent), X (Hexadecimal), C (Currency in local format)
    
    // Console.WriteLine("{0:D}, {0:N}, {0:F}, {0:G}", val1);

    // Console.WriteLine("{0:E}, {0:N}, {0:F}, {0:G}", val2);

    // //* Add a number after the format to specify precision

    // Console.WriteLine("{0:D6}, {0:N2}, {0:F1}, {0:G3}", val1);

    // //* Formatting with alignment and spacing

    // Console.WriteLine("{0,12} {1,12} {2,12} {3,12}",
    //         quarters[0],quarters[1],quarters[2],quarters[3]);

    // Console.WriteLine("{0,12:C0} {1,12:C0} {2,12:C0} {3,12:C0}",
    //         sales[0],sales[1],sales[2],sales[3]);

    // Console.WriteLine("{0,12:P0} {1,12:P0} {2,12:P1} {3,12:P2}",
    //         intlMixPct[0],intlMixPct[1],intlMixPct[2],intlMixPct[3]);
}
//! Challenge 1: Take product and price → use C2
{
    // try
    // {
    //     Console.Write("Product Name: ");
    //     string productName = Console.ReadLine() ?? string.Empty;

    //     Console.Write("Price of Product: ");
    //     decimal productPrice = Convert.ToDecimal(Console.ReadLine());

    //     if (productPrice <= 0)
    //     {
    //         throw new ArgumentOutOfRangeException("Price cannot be lower from 0");
    //     }

    //     Console.WriteLine(
    //         $"""
    //         Product{"",2}: {productName}
    //         Price{"",4}: {productPrice:C2}
    //         """
    //     );
    // }
    // catch (FormatException e)
    // {
    //     Console.WriteLine(e.Message);
    // }
    // catch (ArgumentOutOfRangeException e)
    // {
    //     Console.WriteLine(e.Message);
    // }   
}
//! Challenge 2: Average grade is 87.45678 → return as 87.46
{
    // double averageGrade = 87.45678d;

    // Console.WriteLine($"Average Grade{"",1}: {averageGrade:F2}");
}
//! Challenge 3: 0.2754 → 27.54%
{
    // double saleRate = 0.2754d;

    // Console.WriteLine($"Rate Percentage{"",1}:{"",1}{saleRate:P2}");
}
//! Bonus Challenge → Use the array on below and make a table
{
    // string[] months = {"Jan", "Feb", "Mar"};

    // decimal[] incomes = {12500, 13990, 15880};

    // Console.WriteLine(
    //     $"""
    //     Month{"",7}Income
    //     ---------------------
    //     {months[0]}{"",7}{incomes[0]:C2}
    //     {months[1]}{"",7}{incomes[1]:C2}
    //     {months[2]}{"",7}{incomes[2]:C2}
    //     """
    // );
}
