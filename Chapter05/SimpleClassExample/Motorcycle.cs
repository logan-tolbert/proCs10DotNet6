namespace SimpleClassExample;
public class Motorcycle
{
    public int driverIntensity;
    public string driverName;

    
    #region Methods


    public void SetDriverName(string name)
    {
        // These two statements are functionally the same
        driverName = name;
        this.driverName = name;
    }
    public void PopAWheely()
    {
        for (int i = 0; i <= driverIntensity; i++)
        {
            Console.WriteLine("Yeeeeeee Haaaaaaaeewwww!");
        }
    }

    

    #endregion


    #region Constructors
    // Put back the default constructor,
    // which will set all data members to default values
    public Motorcycle()
    {
        Console.WriteLine("In default Constructor");
    }

    // Out custom constructors. 
    // Constructor chaining 
    public Motorcycle(int intensity)
        : this(intensity, "")
    {
        Console.WriteLine("In constructor taking an int");
    }

    public Motorcycle(string name)
        : this(0, name)
    {
        Console.WriteLine("In constructor taking a string");
    }

    // This is the 'main' constructor that does all the real work.
    public Motorcycle(int intensity, string name)
    {
        Console.WriteLine("In 'Main' constructor");
        if (intensity > 10)
        {
            intensity = 10;
        }
        driverIntensity = intensity;
        driverName = name;
    }
   

    #endregion

}
