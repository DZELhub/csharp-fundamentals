//! Class Notes: String Interpolation
{
    // //* Declare some variables
    // string make = "Mercedes-Benz";
    // string model = "G Class";
    // int year = 2020;
    // float miles = 8_450.27f;
    // decimal price = 60_275.0m;

    // //* Output information using formatting

    // Console.WriteLine("This car is a {0} {1} {2}, with {3} miles and costs {4}₺", year, make, model, miles, price);

    // //* Using string interpolation

    // Console.WriteLine($"This car is a {year} {make} {model}, with {miles} miles and costs {price:C2}");

    // //* With inline expressions

    // Console.WriteLine($"This car is a {year} {make} {model}, with {miles * 1.6:F2} km and costs {price:C2}");
}
//! Challenge 1: Take name, age and city → return Hello Name, you are age years old and live in City.
{
    // try
    // {
    //     Console.Write("First Name: ");
    //     string firstName = Console.ReadLine() ?? string.Empty;

    //     Console.Write("Age: ");
    //     int age = Convert.ToInt32(Console.ReadLine());

    //     Console.Write("City: ");
    //     string city = Console.ReadLine() ?? string.Empty;

    //     if (age <= 0 || age > 120)
    //     {
    //         throw new ArgumentOutOfRangeException("Age must be between 1 - 120.");
    //     }

    //     Console.WriteLine($"Hello {firstName}, you are {age} years old and live in {city}.");
    // }
    // catch (ArgumentOutOfRangeException e)
    // {
    //     Console.WriteLine(e.Message);
    // }
    // catch (FormatException e)
    // {
    //     Console.WriteLine(e.Message);
    // }
}
//! Challenge 2: Take product name, amount, unit price → return with interpolation
{
    // try
    // {
    //     Console.Write("Product Name: ");
    //     string productName = Console.ReadLine() ?? string.Empty;

    //     Console.Write("Amount: ");
    //     int amount = Convert.ToInt32(Console.ReadLine());

    //     Console.Write("Unit Price: ");
    //     decimal unitPrice = Convert.ToDecimal(Console.ReadLine());

    //     if (amount <= 0)
    //     {
    //         throw new ArgumentOutOfRangeException("Amount must be greater than 0.");
    //     }

    //     if (unitPrice <= 0)
    //     {
    //         throw new ArgumentOutOfRangeException("Unit price must be greater than 0.");
    //     }

    //     Console.WriteLine($"For an order {amount} units of product {productName} at a unit price of {unitPrice:C}, the total amount to be paid is {amount * unitPrice:C}.");
    // }
    // catch (ArgumentOutOfRangeException e)
    // {
    //     Console.WriteLine(e.Message);
    // }
    // catch (FormatException e)
    // {
    //     Console.WriteLine(e.Message);
    // }
}
//! Challenge 3
{
    // string name = "D.Z.E.L.";
    // double average = 91.456;

    // Console.WriteLine(
    //     $"""
    //     {"Student",-9}: {name}
    //     {"Average",-9}: {average}
    //     {"Status",-9}: {(average >= 50 ? "Passed":"Failed")}
    //     """
    // );
}
//! Bonus: Create car info → km to mile / mile to km in interpolation
{
    // string carModel = "Mustang";
    // string brand = "Ford";
    // int year = 1967;
    // decimal price = 8500000m;
    // double mile = 37282d;
    // double kmPerMile = 1.60934d;

    // Console.WriteLine($"This {year} {brand} {carModel} with {mile * kmPerMile:F2} km and costs {price:C2}");
}