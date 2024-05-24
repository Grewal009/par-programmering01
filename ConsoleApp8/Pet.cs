namespace ConsoleApp8;

public class Pet
{
    private string _name;
    private int _age;
    private string _comfort;
    private string _petType;

    public Pet(string name, int age, string comfort, string petType)
    {
        _name = name;
        _age = age;
        _comfort = comfort;
        _petType = petType;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Virtual Pet -> Name:{_name}, Age: {_age}, Comfort: {_comfort}, Pet Type: {_petType}");
    }

    public void Menu()
    {
        Console.WriteLine($"press 1 to give food to {_name}");
        Console.WriteLine($"press 2 to play with {_name}");
        Console.WriteLine($"press 3 to clean/wash {_name}");
        Console.WriteLine($"press 5 to change pet");
        Console.WriteLine($"press any other key to exit");
    }
}