Console.WriteLine(
    """
    Hello World!
    What is your name?
    """
);
string name = Console.ReadLine() ?? string.Empty;

Console.WriteLine(
    $"""
    Welcome {name}...
    """
);

//! Practise 1: Person Card

Console.Write("Enter Your Name: ");
string name1 = Console.ReadLine() ?? string.Empty;

Console.Write("Enter Your Surname: ");
string surname = Console.ReadLine() ?? string.Empty;

Console.Write("Enter Your Age: ");
int age = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Your City: ");
string city = Console.ReadLine() ?? string.Empty;

Console.WriteLine(
    $"""
    --------------------
    PERSON CARD

    Name    : {name1}
    Surname : {surname}
    Age     : {age}
    City    : {city}
    --------------------
    """
);

//! Practise 2: Favorite programming language

Console.Write("What is your favorite programming language: ");
string favLang = Console.ReadLine() ?? string.Empty;

Console.WriteLine($"Your favorite language is {favLang}");

//! Practise 3: Career Info

Console.Write("Enter Your Name: ");
string name2 = Console.ReadLine() ?? string.Empty;

Console.Write("Enter Your Job: ");
string job = Console.ReadLine() ?? string.Empty;

Console.WriteLine(
    $"""
    Hello {name2}!
    You are a {job}.
    """
);

//! Practise 4: Student Card

Console.Write("Enter Your Name: ");
string name3 = Console.ReadLine() ?? string.Empty;

Console.Write("Enter Your Surname: ");
string surname1 = Console.ReadLine() ?? string.Empty;

Console.Write("Enter Your University Name: ");
string university = Console.ReadLine() ?? string.Empty;

Console.Write("Enter Your Department Name: ");
string department = Console.ReadLine() ?? string.Empty;

Console.WriteLine(
    $"""
    --------------------
    {university} STUDENT CARD

    Name         : {name3}
    Surname      : {surname1}     
    Department   : {department}
    --------------------
    """
);