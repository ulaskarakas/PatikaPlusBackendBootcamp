# Patika - Week Four App

PatikaWeekFourApp is a C# console application designed to demonstrate the principles of object-oriented programming (OOP), specifically focusing on abstraction, inheritance, and polymorphism. The application allows users to create and manage different types of products (e.g., Computers and Phones) by leveraging a base class and derived classes.

## Project Purpose

The purpose of this project is to:

1. Illustrate the use of abstract classes and methods in OOP.
2. Demonstrate inheritance by creating a common base class for different product types.
3. Showcase polymorphism by overriding methods in derived classes.
4. Provide a practical example of input validation and user interaction in a console application.

---

## Application Features

1. **Product Creation:** Users can create products of type `Computer` or `Phone` by providing specific details such as serial number, name, description, and operating system.
2. **Dynamic Input Handling:** The program validates user input to ensure correctness and prompts for re-entry if needed.
3. **Polymorphic Behavior:** Both `Computer` and `Phone` classes override methods from the base class to display product-specific information.
4. **Interactive Console Application:** The application uses a loop to allow users to add multiple products until they choose to exit.

---

## Project Structure

- **BaseMachine (Abstract Class):**
  - Properties: `ProductionDate`, `SerialNumber`, `Name`, `Description`, `OperatingSystem`
  - Methods:
    - `PrintInformation()` (virtual): Displays general product information.
    - `GetProductName()` (abstract): Enforces implementation in derived classes.

- **Computer (Derived Class):**
  - Inherits: `BaseMachine`
  - Additional Properties: `UsbPortNumbers`, `WithBluetooth`
  - Overrides:
    - `PrintInformation()`: Displays detailed information about the computer.
    - `GetProductName()`: Prints the computer’s name.

- **Phone (Derived Class):**
  - Inherits: `BaseMachine`
  - Additional Property: `WithLicense`
  - Overrides:
    - `PrintInformation()`: Displays detailed information about the phone.
    - `GetProductName()`: Prints the phone’s name.

---

## Code Example

### Main Program
```csharp
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
                    Console.WriteLine("Phone created successfully.");
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
```

---

## Technologies Used

- **C#**: Programming language used for development.
- **.NET Core**: Framework for project execution.

---

## Installation and Execution

Follow these steps to run the application:

1. **Clone the project:**
   ```bash
   git clone https://github.com/ulaskarakas/PatikaWeekFourApp.git
   ```
2. **Install .NET SDK:**
   - If not already installed, download the appropriate version from the [.NET SDK](https://dotnet.microsoft.com/download) page.

3. **Navigate to the project directory and run the application:**
   ```bash
   cd PatikaWeekFourApp
   dotnet run
   ```

---

## Contributing
To contribute to this project, please submit a **Pull Request** or create an **Issue**.

---

## License
This project is licensed under the MIT License.

---

## Contact
For any questions or suggestions, feel free to contact me:
- **Email**: [ulaskarakas95@gmail.com](mailto:ulaskarakas95@gmail.com)
- **LinkedIn**: [Ulaş Karakaş](https://www.linkedin.com/in/ulas-karakas/)
