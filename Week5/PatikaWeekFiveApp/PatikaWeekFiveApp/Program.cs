using PatikaWeekFiveApp;
public class Program
{
    public static void Main(string[] args)
    {
        string serialNumber;
        string brand;
        string model;
        string color;
        int numbersOfDoor = 0;

        List<Car> cars = new List<Car>();

        Console.WriteLine("-- Welcome to the Car Producer --");

        start:
        Console.WriteLine("Do you want to produce a new car?");
        string answer = Console.ReadLine();
        while (answer.ToLower() != "y" && answer.ToLower() != "n")
        {
            Console.WriteLine("Invalid value! Please enter Y(Yes) or N(No): ");
            answer = Console.ReadLine();
        }

        if (answer.ToLower() == "y")
        {
            Console.Write("Please enter serial number of the car: ");
            serialNumber = Console.ReadLine();
            Console.Write("Please enter brand of the car: ");
            brand = Console.ReadLine();
            Console.Write("Please enter model of the car: ");
            model = Console.ReadLine();
            Console.Write("Please enter color of the car: ");
            color = Console.ReadLine();
            label:
            try
            {
                Console.Write("Please enter numbers of door for the car: ");
                numbersOfDoor = int.Parse(Console.ReadLine());
            }
            catch(Exception)
            {
                Console.WriteLine("Invalid value! Please enter a number.");
                goto label;
            }

            Car car = new Car(serialNumber, brand, model, color, numbersOfDoor);
            car.Display();

            cars.Add(car);

            goto start;

        }
        else
        {
            if (cars.Count != 0)
            {
                Console.WriteLine("------------------");
                Console.WriteLine("All cars produced:");
                foreach (var item in cars)
                {
                    Console.WriteLine($"Brand: {item.Brand} | SerialNumber: {item.SerialNumber}");
                }
            }
        }

    }
}