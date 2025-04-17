public class Program
{
    public static void Main(string[] args)
    {
        List<int> numbers = new List<int>() { 10, -19, 50, 20, -8, 3, 100, 18, -14, 55};

        var evenNumbers = numbers.Where(num => num % 2 == 0);
        Console.WriteLine("Even numbers in the list:");
        foreach (var number in evenNumbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("***************************");

        var oddNumbers = numbers.Where(num => num % 2 != 0);
        Console.WriteLine("Odd numbers in the list:");
        foreach (var number in oddNumbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("***************************");

        var negativeNumbers = numbers.Where(num => num < 0);
        Console.WriteLine("Negative numbers in the list:");
        foreach (var number in negativeNumbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("***************************");

        var positiveNumbers = numbers.Where(num => num >= 0);
        Console.WriteLine("Positive numbers in the list:");
        foreach (var number in positiveNumbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("***************************");

        var rangeNumbers = numbers.Where(num => num > 15 && num < 22);
        Console.WriteLine("Numbers that between 15 and 22 in the list:");
        foreach (var number in rangeNumbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("***************************");

        var squareNumbers = numbers.Select(num => num * num);
        Console.WriteLine("Square of numbers in the list:");
        foreach (var number in squareNumbers)
        {
            Console.WriteLine(number);
        }
    }
}