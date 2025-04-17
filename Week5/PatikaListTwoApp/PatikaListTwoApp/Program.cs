public class Program
{
    public static void Main(string[] args)
    {
        List<string> coffeeList = new List<string>();
        Console.WriteLine("Please enter the 5 coffee names you would like to list.");

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Coffee {i + 1}: ");
            coffeeList.Add(Console.ReadLine());
        }

        Console.WriteLine("-----------");

        Console.WriteLine("Entered coffee names:");
        foreach (var item in coffeeList)
        {
            Console.WriteLine(item);
        }
    }
}