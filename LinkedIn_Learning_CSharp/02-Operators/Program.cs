//! Class Notes
{
    // int x = 10;
    // int y = 5;

    // string a = "abcd";
    // string b = "efgh";

    // //* Basic math operators: +, -, /, *

    // Console.WriteLine(
    //     $"""
    //     ----------------------------------
    //     ----------- Basic Math -----------
    //     ----------------------------------
    //     (x / y) * x = {(x / y) * x};
    //     x + y = {x + y};
    //     x - y = {x - y}
    //     a + b = {a + b} //? Concatenate: To link or join squential items
    //     """
    // );

    // //* Increment / decrement operators

    // Console.WriteLine(
    //     $"""
    //     ----------- Before -----------
    //     x = {x}
    //     y = {y}
    //     """
    // );

    // x ++; //? x + 1
    // y --; //? y - 1
 
    // Console.WriteLine(
    //     $"""
    //     ----------- After -----------
    //     x = {x}
    //     y = {y}
    //     """
    // );

    // //* Shorthand operators: a = a + b → a += b

    // Console.WriteLine(
    //     $"""
    //     ----------- Shorthand -----------
    //     a + b = {a + b}
    //     a += b → {a += b} //? It changes "a" variable
    //     """
    // );

    // //* Logical Operators: &&, ||

    // Console.WriteLine(
    //     $"""
    //     ----------- Logical Operators -----------
    //     x > y && y >= 5 → true && false = {x > y && y >= 5}
    //     x > y || y >=5  → true || false = {x > y || y >=5 }
    //     """
    // );

    // //* null-coalesing operators

    // string str = null;
    // Console.WriteLine(
    //     $"""
    //     ----------- null-coalesing -----------
    //     {str ?? "Unknown string"}  
    //     """ 
    // );
}
//! Challenge 1: Take product price, take tax rate → calculate total price
{
    // Console.Write("Price: ");
    // decimal price = Convert.ToDecimal(Console.ReadLine());

    // Console.Write("Tax Rate(ex. %20): %");
    // int taxRate = Convert.ToInt32(Console.ReadLine());

    

    // decimal totalPrice = price + ((price * taxRate) / 100);

    // Console.WriteLine(
    //     $"""
    //     Ürün Fiyatı: {price :C}
    //     Vergi Oranı: {taxRate :P}
    //     Vergi Dahil Fiyat: {totalPrice :C}
    //     """
    // );
}
//! Challenge 2: Take midterm point and final point → calculate average → write pass or fail
{
    // Console.Write("Midterm Grade: ");
    // double midterm = Convert.ToDouble(Console.ReadLine());

    // Console.Write("Final Grade: ");
    // double final = Convert.ToDouble(Console.ReadLine());

    // double average = (midterm + final) / 2;

    // string isPass = average >= 50 ? "Pass" : "Fail";

    // Console.WriteLine(
    //     $"""
    //     Your Midterm Grade  : {midterm}
    //     Your Final Grade    : {final}
    //     Your Average Grade  : {average}
    //     Passing Status      : {isPass}
    //     """
    // );
}
//! Challenge 3: Take name and salary → calculate salary with a 25% raise
{
    // Console.Write("Enter Your Name: ");
    // string name = Console.ReadLine() ?? string.Empty;

    // Console.Write("Enter Your Salary: ");
    // double salary = Convert.ToDouble(Console.ReadLine());

    // double raiseRate = 1.25;

    // double increasedSalary = salary * raiseRate;

    // Console.WriteLine(
    //     $"""
    //     Hello {name},
    //     Your Increased Salary: {increasedSalary :C}
    //     """
    // );
}
//! Final Challenge: Take Product Name, Unit Price, Quantity, Tax Rate → create shopping receipt
{
    // Console.Write("Product Name: ");
    // string productName = Console.ReadLine() ?? string.Empty;
    // Console.Write("Unit Price: ");
    // decimal unitPrice = Convert.ToDecimal(Console.ReadLine());
    // Console.Write("Quantity: ");
    // int quantity = Convert.ToInt32(Console.ReadLine());
    // Console.Write("Tax Rate: %");
    // int taxRate = Convert.ToInt32(Console.ReadLine());

    // decimal subTotal = unitPrice * quantity;
    // decimal tax = (subTotal / 100) * taxRate;
    // decimal totalPrice = subTotal + tax;

    // Console.WriteLine(
    //     $"""
    //     ==============================
    //     ====== SHOPPING RECEIPT ======
    //     ==============================

    //     Product         : {productName}
    //     Unit Price      : {unitPrice :C}
    //     Quantity        : {quantity}
    //     Subtotal        : {subTotal}
    //     Tax (%{taxRate})       : {tax :C}
    //     Total Price     : {totalPrice :C}

    //     ==============================
    //     === Thank you for shopping ===
    //     ==============================
    //     """
    // );
}