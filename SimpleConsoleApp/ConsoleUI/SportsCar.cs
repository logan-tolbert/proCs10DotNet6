using System.Diagnostics.Contracts;

namespace ConsoleUI;

public class SportsCar : Car
{
 public string GetPetName()
 {
    PetName = "red";
        return PetName;
 }
}
