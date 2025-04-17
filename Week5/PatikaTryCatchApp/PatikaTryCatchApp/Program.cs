public class Program
{
    public static void Main(string[] args)
    {
        bool isValidValue = false;

        while (!isValidValue)
        {
            try
            {
                Console.Write("Please enter a number: ");
                int number = int.Parse(Console.ReadLine());

                isValidValue = true;

                Console.WriteLine($"{number} to power of 2: {Math.Pow(number, 2)}");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid value! Please enter a number.");
            }
        }

    }
}