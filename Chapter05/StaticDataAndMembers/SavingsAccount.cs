namespace StaticDataAndMembers;

// A simple savings account class.
public class SavingsAccount
{
    // A static point of data. 
    public static double currInterestRate;

    // Instance level data
    public double currBalance;
    public SavingsAccount(double balance)
    {
        currBalance = balance;
    }

    // A static constructor
    static SavingsAccount()
    {
        Console.WriteLine("In static constructor");
        currInterestRate = 0.04;
    }

    // Static members to get/set interest rate.
    public static double SetInterestRate(double newRate)
       => currInterestRate = newRate;

    public static double GetInterestRate()
        => currInterestRate;
}
