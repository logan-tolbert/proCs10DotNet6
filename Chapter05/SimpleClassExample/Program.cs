using SimpleClassExample;

Console.WriteLine("***** Fun with Class Types *****\n");

#region Car
// Allocate and configure a Car object
Car myCar = new Car();
myCar.petName = "Henry";
myCar.currSpeed = 10;

// Speed up the car a few times a print out the new state
for (int i = 0; i <= 10; i++)
{
    myCar.SpeedUp(5);
    myCar.PrintState();
}
Console.ReadLine();

// Initialize a new object with a default constructor
Car defaultCar = new Car();

// Initialize objects with custom constructors
Car chuck = new Car("Chuck");

Car mary = new Car("Daisy", 75);
#endregion

#region Motorcycle
Motorcycle mc = new Motorcycle();
mc.PopAWheely();

// Create an object invoking the constructor requiring a single int
Motorcycle mc2 = new Motorcycle(5);
mc2.SetDriverName("Tiny");
mc2.PopAWheely();
Console.WriteLine("Rider name is {0}.", mc2.driverName);
Console.ReadLine();
#endregion

