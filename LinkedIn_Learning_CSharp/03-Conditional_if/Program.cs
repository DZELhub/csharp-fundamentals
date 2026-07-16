//! Class Notes
{
    //* if - else

    // int  theVal = 56;

    // if (theVal == 50)
    // {
    //     Console.WriteLine("theVal is 50");
    // } 
    // else if (theVal >= 51 && theVal <= 60)
    // {
    //     Console.WriteLine("theVal is between 51 and 60");
    // }
    // else
    // {
    //     Console.WriteLine("theVal is something else");
    // }

    //* Using ternary operator

    // string ternaryOp = theVal < 50 ? "theVal is smaller than 50" : "theVal is larger than 50";
    // Console.WriteLine(ternaryOp);
}
//! Challenge 1 - Number Checker: Take a number → return Positive | Negative | Zero
{
    // Console.Write("Enter a Number: ");
    // int number = Convert.ToInt32(Console.ReadLine());

    // if (number > 0)
    // {
    //     Console.WriteLine("Positive");
    // } else if (number < 0)
    // {
    //     Console.WriteLine("Negative");
    // } else
    // {
    //     Console.WriteLine("Zero");
    // }

    // string numberStatus = number > 0 ? "Positive" : number < 0 ? "Negative" : "Zero";
    // Console.WriteLine(numberStatus);
}
//! Challenge 2 - Age Category: Take an age → 0-12 Child | 13-17 Teenager | 18-64 Adult | 65+ Senior
{
    // Console.Write("Enter Your Age: ");
    // int age = Convert.ToInt32(Console.ReadLine());

    // if (age >= 0 && age < 13)
    // {
    //     Console.WriteLine("Child");
    // } else if ( age >= 13 && age < 18)
    // {
    //     Console.WriteLine("Teenager");
    // } else if ( age >= 18 && age < 65)
    // {
    //     Console.WriteLine("Adult");
    // } else if ( age >= 65)
    // {
    //     Console.WriteLine("Senior");
    // } else
    // {
    //     Console.WriteLine("Invalid Entry");
    // }

    // string ageStatus = 
    //         age >= 0 && age < 13 ? "Child" :
    //         age >= 13 && age < 18 ? "Teenager" :
    //         age >= 18 && age < 65 ? "Adult" :
    //         age >= 65 ? "Senior" : "Invalid Entry";
    
    // Console.WriteLine(ageStatus);
}
//! Challenge 3 - Login System: Take username and password → username: admin, password: 12345 → Login Successful | Invalid Username or Password
{
    // string username = "admin";
    // string password = "12345";
    
    // Console.Write("Username: ");
    // string enteredUsername = Console.ReadLine() ?? string.Empty;

    // Console.Write("Password: ");
    // string enteredPassword = Console.ReadLine() ?? string.Empty;

    // if (enteredUsername == username && enteredPassword == password)
    // {
    //     Console.WriteLine("Login Successful");
    // } else if (enteredUsername != username && enteredPassword == password)
    // {
    //     Console.WriteLine("Invalid Username");
    // } else if (enteredUsername == username && enteredPassword != password)
    // {
    //     Console.WriteLine("Invalid Password");
    // } else
    // {
    //     Console.WriteLine("Invalid Username or Password");
    // }
}
//! Bonus Challenge: Take three numbers → return greatest one
{
    // Console.WriteLine(
    //     """
    //     ---------------------------------------
    //     -- Enter Three Number, Find Greatest --
    //     ---------------------------------------
    //     """
    // );
    // Console.Write("Number One: ");
    // int numberOne = Convert.ToInt32(Console.ReadLine());

    // Console.Write("Number Two: ");
    // int numberTwo = Convert.ToInt32(Console.ReadLine());

    // Console.Write("Number Three: ");
    // int numberThree = Convert.ToInt32(Console.ReadLine());

    // int greatest = numberOne;

    // if (numberTwo > greatest)
    // {
    //     greatest = numberTwo;       
    // }
    // if (numberThree > greatest)
    // {
    //     greatest = numberThree;
    // }

    // Console.WriteLine($"Greatest number is {greatest}");
}
//! Extra Challenge (Senior Level): Take midterm and final grade → Average >= 90 → AA | 80-89 → BA | 70-79 → BB | 60-69 → CB | 50-59 → CC | 40-49 → DC | 30-39 → DD | <30 → FF → If final < 50: Failed
{
    // Console.Write("Enter Your Midterm Grade: ");
    // int midterm = Convert.ToInt32(Console.ReadLine());
    // Console.Write("Enter Your Final Grade: ");
    // int final = Convert.ToInt32(Console.ReadLine());

    // int midtermRate = 40;
    // int finalRate = 60;

    // int midtermAverage = midterm * midtermRate / 100;
    // int finalAverage = final * finalRate / 100;

    // int average = midtermAverage + finalAverage;
    // string letterGrade = null ?? string.Empty;

    // string message =
    //         $"""
    //         Midterm Grade   : {midterm}
    //         Final Grade     : {final}
    //         Average Grade   : {average}
    //         """;
    
    // if (final < 0 || midterm  < 0)
    // {
    //     Console.WriteLine("Midterm or final grades cannot be less than 0.");
        
    // } else if (final < 50)
    // {
    //     Console.WriteLine("Failed");
    // } else if ( average >= 90 && average <= 100)
    // {
    //     letterGrade = "AA";
    //     Console.WriteLine(
    //         $"""
    //         {message}
    //         Letter Grade    : {letterGrade} 
    //         """
    //     );
    // } else if ( average >= 80 && average < 90)
    // {
    //     letterGrade = "BA";
    //     Console.WriteLine(
    //         $"""
    //         {message}
    //         Letter Grade    : {letterGrade} 
    //         """
    //     );
    // } else if (average >= 70 && average < 80)
    // {
    //     letterGrade = "BB";
    //     Console.WriteLine(
    //         $"""
    //         {message}
    //         Letter Grade    : {letterGrade} 
    //         """
    //     );
    // } else if (average >= 60 && average < 70)
    // {
    //     letterGrade = "CB";
    //     Console.WriteLine(
    //         $"""
    //         {message}
    //         Letter Grade    : {letterGrade} 
    //         """
    //     );
    // } else if (average >= 50 && average < 60)
    // {
    //     letterGrade = "CC";
    //     Console.WriteLine(
    //         $"""
    //         {message}
    //         Letter Grade    : {letterGrade} 
    //         """
    //     );
    // } else if (average >= 40 && average < 50)
    // {
    //     letterGrade = "DC";
    //     Console.WriteLine(
    //         $"""
    //         {message}
    //         Letter Grade    : {letterGrade} 
    //         """
    //     );
    // } else if (average >= 30 && average < 40)
    // {
    //     letterGrade = "DD";
    //     Console.WriteLine(
    //         $"""
    //         {message}
    //         Letter Grade    : {letterGrade} 
    //         """
    //     );
    // } else if (average >= 0 && average < 40)
    // {
    //     letterGrade = "FF";
    //     Console.WriteLine(
    //         $"""
    //         {message}
    //         Letter Grade    : {letterGrade} 
    //         """
    //     );
    // } else
    // {
    //     Console.WriteLine("Invalid Entry");
    // }
}