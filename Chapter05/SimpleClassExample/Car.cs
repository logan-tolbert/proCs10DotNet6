namespace SimpleClassExample;

class Car
{
    // The 'state' of the Car.
    public string petName;
    public int currSpeed;

    // A custom default constructor
    public Car()
    {
        petName = "Christine";
        currSpeed = 0;
    }

    // Here, currSpeed will recieve the default of an int (o)
    public Car(string pn)
    => petName = pn;
    
    // Let the caller set the full state of the Car
    public Car(string pn, int cs)
    {
        petName = pn;
        currSpeed = cs;
    }

    // The functionality of the Car.
    // Using the expression-bodied member syntax
    // covered in chapter 4
    public void PrintState()
        => Console.WriteLine("{0} is going {1} MPH.", petName, currSpeed);

    public void SpeedUp(int delta)
        => currSpeed += delta;
    
    // Constructor without parameters
    public Car(string pn, int cs, out bool inDanger)
    {
        petName = pn;
        currSpeed = cs;
        if (cs > 100)
        {
            inDanger = true;
        }
        else
        {
            inDanger = false;
        }
    }
}