using PatikaWeekFourApp;
public class Program
{
    public static void Main(string[] args)
    {
        int input;
        string request = string.Empty;
        while (request.ToLower() != "n")
        {
            

            Console.Write("Choose the product type you want to add [ (1) Computer / (2) Phone ]: ");
            while (!int.TryParse(Console.ReadLine(), out input) || (input != 1 && input != 2))
            {
                Console.Write("Invalid value! Please enter 1 or 2 [ (1) Computer / (2) Phone ]: ");
            }

            Console.Write("Please enter Serial Number: ");
            string serialNumber = Console.ReadLine();
            Console.Write("Please enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter Description: ");
            string description = Console.ReadLine();
            Console.Write("Please enter Operating System: ");
            string operatingSystem = Console.ReadLine();

            switch (input)
            {
                case 1:
                    int usbPortNumbers;
                    bool withBluetooth;
                    Console.Write("Please enter USB Port Numbers: ");
                    while (!int.TryParse(Console.ReadLine(), out usbPortNumbers))
                    {
                        Console.Write("Invalid value! Please enter a number: ");
                    }
                    Console.Write("Enter whether it has Bluetooth or not (true/false): ");
                    while (!bool.TryParse(Console.ReadLine(), out withBluetooth))
                    {
                        Console.Write("Invalid value! Please enter false or true: ");
                    }
                    BaseMachine computer = new Computer(serialNumber, name, description, operatingSystem, usbPortNumbers, withBluetooth);
                    Console.WriteLine("Computer created successfully.");
                    computer.PrintInformation();
                    break;
                case 2:
                    bool withLicense;
                    Console.Write("Please enter whether it has a TR license or not (true/false): ");
                    withLicense = bool.Parse(Console.ReadLine());
                    BaseMachine phone = new Phone(serialNumber, name, description, operatingSystem, withLicense);
                    Console.WriteLine("Computer created successfully.");
                    phone.PrintInformation(); 
                    break;
            }

            Console.Write("Would you like to add another product? [ Y/N ]: ");
            while (true)
            {
                request = Console.ReadLine();
                if (!(request.ToLower() == "y" || request.ToLower() == "n"))
                {
                    Console.Write("Invalid value! Please enter Y or N [ (Y) Yes / (N) No ]: ");
                }
                else
                {
                    break;
                }
            }

            if (request.ToLower() == "n")
            {
                Console.WriteLine("Good Bye! Have a nice day :)");
            }

            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}