using StaticDataAndMembers;

// SavingsAccount sa = new(5);
// Console.WriteLine(sa.currBalance);

// double value = SavingsAccount.currInterestRate;
// Console.WriteLine(value);

Console.WriteLine("***** Fun with Static Data *****");
SavingsAccount s1 = new SavingsAccount(50);
SavingsAccount s2 = new SavingsAccount(100);

// Print the current interest rate
Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());

// Make new object, this does NOT reset the interst rate.
SavingsAccount s3 = new SavingsAccount(100000.75);
Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());
Console.ReadLine();


TimeUtilClass.PrintDate();
TimeUtilClass.PrintTime();