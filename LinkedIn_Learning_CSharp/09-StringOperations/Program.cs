//! Class Notes
{
    // //* Declare some strings for the exercises

    // string outstr;
    // string str1 = "The quick brown fox jumps over the lazy dog.";
    // string str2 = "This is a string";
    // string str3 = "THIS is a STRING";
    // string[] strs = {"one","two","three","four"};

    // //* Length of a string

    // Console.WriteLine(str1.Length);

    // //* Access individual characters

    // Console.WriteLine(str1[14]);

    // //* Iterate over a string like any other sequence of values

    // foreach (char ch in str1)
    // {
    //     Console.Write(ch);
    //     if (ch == 'b')
    //     {
    //         Console.WriteLine();
    //         break;
    //     }
    // }

    // //* String concatenation

    // outstr = String.Concat(strs);
    // Console.WriteLine(outstr);

    // //* Joining strings together with Join

    // outstr = String.Join('.', strs);
    // Console.WriteLine(outstr);

    // outstr = String.Join('-', strs);
    // Console.WriteLine(outstr);

    // //* String comparison
    // //* Compare will perform an ordinal comparison and return
    // //* < 0 → first string comes before second in sort order
    // //* 0 → first and second strings are same position in sort order
    // //* > 0 → first string comes after the second in sort order

    // int result = String.Compare(str2, "This is a string");
    // Console.WriteLine(result);

    // //* Equals just returns a regular Boolean

    // bool isEqual = str2.Equals(str3);
    // Console.WriteLine(isEqual);

    // //* String searching

    // Console.WriteLine(str1.IndexOf('e'));
    // Console.WriteLine(str1.IndexOf("fox"));

    // Console.WriteLine(str1.LastIndexOf('e'));
    // Console.WriteLine(str1.LastIndexOf("the"));

    // //* Replace

    // outstr = str1.Replace("fox", "cat");
    // Console.WriteLine(outstr);
    // Console.WriteLine(outstr.IndexOf("fox"));
}
//! Challenge 1: Take full name from user → Length, First Char, Last Char
{
    // Console.Write("Full Name: ");
    // string fullName = (Console.ReadLine() ?? string.Empty).Replace(" ","");

    // int lengthOfFullName = fullName.Length;
    // Console.WriteLine($"Length of Your Full Name is {lengthOfFullName} characters");

    // char firstChar = fullName[0];
    // char lastChar = fullName[lengthOfFullName - 1];

    // Console.WriteLine(
    //     $"""
    //     First character of your full name is '{firstChar}'
    //     Last character of your full name is '{lastChar}'
    //     """
    // );
}
//! Challenge 2: Take a text from user, find how many "a" char.
{
    // Console.Write("Write a text: ");
    // string inputText = (Console.ReadLine() ?? string.Empty).Trim();
    // int counter = 0;
    // foreach (char ch in inputText)
    // {
    //     if (ch == 'a')
    //     {
    //         counter ++;
    //     }
    // }
    // Console.WriteLine($"Number of 'a' chars in the text: {counter}");
}
//! Challenge 3: Take an e-mail address from user, contains @ and finish with .com ?
{
    // Console.Write("Enter e-mail address: ");
    // string inputEmail = (Console.ReadLine() ?? string.Empty).ToLowerInvariant().Trim();

    // bool containsAt = inputEmail.Contains('@');
    // string atControl = containsAt ? "Yes" : "No";

    // bool isFinishDotCom = inputEmail.EndsWith(".com");
    // string dotComControl = isFinishDotCom ? "Yes" : "No";

    // Console.WriteLine(
    //     $"""
    //     Does your email address contain "@": {atControl}
    //     Does your email address end with ".com": {dotComControl}
    //     """
    // );
}
//! Bonus: Use this array → {"C#",".NET","SQL","Git"} and return My skills: C#, .NET, SQL, Git
{   
    // string[] skills = {"C#",".NET","SQL","Git"};

    // string joinedSkills = string.Join(", ",skills);

    // Console.WriteLine($"My skills: {joinedSkills}");
}