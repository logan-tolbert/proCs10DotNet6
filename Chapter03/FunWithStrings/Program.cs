BasicStringFunctionality();
static void BasicStringFunctionality()
{
    Console.WriteLine("=> Basic String functionality:");
    string firstName = "Freddy";
    Console.WriteLine("Value of firstName: {0}", firstName);
    Console.WriteLine("firstName has {0} characters.", firstName.Length);
    Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
    Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
    Console.WriteLine("firstName contains the letter y?: {0}", firstName.Contains("y"));
    Console.WriteLine("New first name: {0}", firstName.Replace("dy", ""));
    Console.WriteLine();
}

StringConcatenation();
static void StringConcatenation()
{
    Console.WriteLine("=> String concatenation:");
    string s1 = "Programming the ";
    string s2 = "PsychoDrill (PTP)";
    string s3 = s1 + s2;
    Console.WriteLine(s3);
    Console.WriteLine();
}

EscapeChars();
static void EscapeChars()
{
    Console.WriteLine("=> Escape characters:");
    string strWithTabs = "Moodel\tColor\tSpeed\tPet Name ";
    Console.WriteLine(strWithTabs);

    Console.WriteLine("Every one loves \"Hello World\" ");
    Console.WriteLine("C:\\MyApp\\bin\\Debug ");

    // Adds a total of 4 blank lines (3 escaped, 1 from WriteLine)
    Console.WriteLine("All finished.\n\n\n ");
    Console.WriteLine();
}

StringInterpolation();
static void StringInterpolation()
{
    Console.WriteLine("=> String interpolation:");

    // Some local variables we will plug into out larger string 
    int age = 4;
    string name = "Soren";

    // Using curly bracket syntax.
    string greeting = string.Format("Hello {0} you are {1} years old.", name, age);
    Console.WriteLine(greeting);

    // Using string interpolation
    string greeting2 = $"Hello {name} you are {age} years old.";
    Console.WriteLine(greeting2);
}

// StringInterpolationWithDefaultInterpolatedStringHandler();
// static void StringInterpolationWithDefaultInterpolatedStringHandler()
// {
//     Console.WriteLine("=> String interpolation under the covers:\a");
//     int age = 4;
//     string name = "Soren";

//     var builder = new DefaultInterpolatedStringHandler(3, 2);
//     builder.AppendLiteral("\tHell0");
//     builder.AppendForamatted(name);
//     builder.AppendLiteral(" you are ");
//     builder.AppendFormatted(age);
//     builder.AppendLiteral(" years old ");
//     var greeting = builder.ToStringAndClear();
//     Console.WriteLine(greeting);
// }

StringEquality();
StringEquality()
{
    Console.WriteLine("=> String equality:");
    string s1 = "Hello!";
    string s2 = "Yo!";
    Console.WriteLine("s1 = {0}", s1);
    Console.WriteLine9"s2 = {0}", s2);
    Console.WriteLine();
    
    // Test the strings for equality. pg 144

}
