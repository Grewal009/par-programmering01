using System.ComponentModel.Design;

namespace ConsoleApp8;

class Program
{
    static void Main(string[] args)
    {
        var pet1 = new Pet("Pushin", 3, "happy", "cat");
        var pet2 = new Pet("Garfield", 20, "super happy ", "cat");
        var pet3 = new Pet("Kanival", 5, "aggresive", "bird");
        var pet4 = new Pet("Simba", 21, "happy", "cat");
        var pet5 = new Pet("Diffen", 5, "happy", "dog");

        Pet[] petArray = [pet1,pet2,pet3,pet4,pet5];

        Random random = new Random();
        var index = random.Next(0, 5);
        //Console.WriteLine(index);

        /*pet1.ShowInfo();
        pet2.ShowInfo();*/
        petArray[index].ShowInfo();
        petArray[index].Menu();
        

        while (true)
        {   
            
            var input = Console.ReadKey(true);
            if (input.Key == ConsoleKey.D1)
            {
                Console.WriteLine("Thank you for the food.");
            }
            else if (input.Key == ConsoleKey.D2)
            {
                Console.WriteLine("Thank you!!🥰😀");
            }
            else if (input.Key == ConsoleKey.D3)
            {
                Console.WriteLine("Thank you!!!🫧🧽🛀");
            }
            else if (input.Key == ConsoleKey.D5)
            {
                Console.Clear();
                index = random.Next(0, 5);
                petArray[index].ShowInfo();
                petArray[index].Menu();
            }
            else
            {
                break;
            }
        }


    }
}