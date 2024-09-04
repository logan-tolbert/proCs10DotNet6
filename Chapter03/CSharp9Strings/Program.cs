namespace CSharp9Strings
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int age = 4;
            string name = "Soren";
            string greeting = string.Format("\tHello {0} you are {1} years old.", nameof.ToUpper(), age);
            string greetings = $"\tHello {name.ToUpper()} you are {age} years old.";
        }
    }
}

