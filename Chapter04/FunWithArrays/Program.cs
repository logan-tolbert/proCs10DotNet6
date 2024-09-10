using System.Diagnostics;
using System.Globalization;

WriteLine("***** Fun with Arrays *****");

SimpleArrays();
ReadLine();

static void SimpleArrays()
{
    WriteLine("=> Simple Array Creation");
    // Create and fill an array of 3 integers
    int[] myInts = new int[3];
    myInts[0] = 100;
    myInts[1] = 200;
    myInts[2] = 300;

    // Now print each value
    foreach(int i in myInts)
    {
        Console.WriteLine(i);
    }

    // Create a 100 item string array, indexed 0 - 99
    string[] booksOnDotNet = new string[100];
    WriteLine();
}

ArrayInitialization();

static void ArrayInitialization()
{
    WriteLine("=> Array Initialization");

    // Array initialization syntax using the new keyword.
    string[] stringArray = new string[]
    {"one", "two", "three" };
    WriteLine("stringArray has {0} elements", stringArray.Length);

    // Array initialization syntax without using the new keyword.
    bool[] boolArray = { false, false, true };
    WriteLine("boolArray has {0} elements", boolArray.Length);

    // Array initialization with new keyword and size.
    int[] intArray = new int[4] { 20, 22, 23, 0 };
    WriteLine("intArray had {0} elements", intArray.Length);
    WriteLine();
}

DeclareImplicitArrays();

static void DeclareImplicitArrays()
{
    WriteLine("=> Implicit Array Initialization");
    // a is really int[]
    var a = new[] { 1, 10, 100, 1000 };
    WriteLine("a is a: {0}", a.ToString());

    // b is really double[]
    var b = new[] { 1, 1.5, 2, 2.5 };
    WriteLine("b is a: {0}", b.ToString());

    // c is really string[]
    var c = new[] { "hello", null, "world" };
    WriteLine("c is a: {0}", c.ToString());
    WriteLine();

}

ArrayOfObjects();
static void ArrayOfObjects()
{
    WriteLine("=> Array of Objects");

    // An Array of Objects can be anything at all
    object[] myObjects = new object[4];
    myObjects[0] = 10;
    myObjects[1] = false;
    myObjects[2] = new DateTime(1969, 3, 24);
    myObjects[3] = "Form & Void";
    foreach (object obj in myObjects)
    {
        // Print the type and value for each item in array.
       WriteLine("Type: {0}, Value: {1}", obj.GetType(), obj);
    }
    WriteLine();
}


RectMultidimensionalArray();
static void RectMultidimensionalArray()
{
    WriteLine("=> Rectangular multidimensional array.");
    // A rectangular MD array
    int[,] myMatrix;
    myMatrix = new int[3, 4];
    
    // Populate (3*4) array
    for(int i = 0; i < 3; i++)
    {
        for(int j = 0; j < 4; j++)
        {
            myMatrix[i, j] = i * j;
        }
    } 

    // Print (3*4) array
    for (int i = 0; i < 3; i++)
    {
        for(int j = 0; j < 4; j++)
        {
            Write(myMatrix[i, j] + "\t");
        }
        WriteLine();
    }
    WriteLine();
}

JaggedMultidimensionalArray();

static void JaggedMultidimensionalArray()
{
    WriteLine("=> Jagged multidimensional array.");
    // A jagged MD array (i.e., an array of arrays).
    // Here we have an array of 5 different arrays 
    int[][] myJagArray = new int[5][];

    // Create the jagged array
    for (int i = 0; i < myJagArray.Length; i++)
    {
        myJagArray[i] = new int[i + 7];
    }

    // Print each row (remember, each element is defaulted to zero)
    for(int i = 0; i < 5; i++)
    {
        for(int j = 0; j < myJagArray[i].Length; j++)
        {
            Write(myJagArray[i][j] + " ");
        }
        WriteLine();
    }
    WriteLine();
}


static void PrintArray(int[] myInts)
{
    for (int i = 0; i < myInts.Length; i++) 
    {
        WriteLine("Item {0} is {1}", i, myInts[i]);
    }
}

static string[] GetStringArray()
{
    string[] theStrings = { "Hello", "from", "GetStringArray" };
    return theStrings;
}

PassAndReceiveArrays();
static void PassAndReceiveArrays()
{
    WriteLine("=> Arrays as params and return values.");
    // Pass array as parameters
    int[] ages = { 20, 22, 23, 0 };
    PrintArray(ages);
    WriteLine();
    // Get array as return value
    string[] strs = GetStringArray();
    foreach(string s in strs)
    {
        WriteLine(s);
    }
    WriteLine();
}