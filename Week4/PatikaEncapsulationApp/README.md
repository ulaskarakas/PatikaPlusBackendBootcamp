# Patika - Encapsulation App

PatikaEncapsulationApp is a simple C# console application designed to demonstrate the concept of encapsulation in object-oriented programming. The project includes a `Car` class that encapsulates the properties and behaviors of a car, showcasing how fields, properties, and methods can work together to ensure data integrity and controlled access. 

## Project Purpose

This project serves as a learning tool for understanding and applying the principles of encapsulation in C#. It is designed to be simple and beginner-friendly, focusing on foundational object-oriented programming concepts.

---

## Application Features

- **Encapsulation**: Demonstrates encapsulation by using private fields and public properties.
- **Validation**: Ensures that the number of doors for a car is either 2 or 4.
- **Constructor Usage**: Initializes objects with specific values using a parameterized constructor.
- **Display Method**: Outputs the details of the car in a formatted manner.

---

## Project Structure
The project consists of the following components:

### Program.cs
The entry point of the application, which creates a `Car` object and calls its methods.

```csharp
namespace PatikaEncapsulationApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car carOne = new Car("Ford", "GT", "Red", 2);
            carOne.Display();
        }
    }
}
```

### Car.cs
Defines the `Car` class with encapsulated fields, properties, and methods.

```csharp
namespace PatikaEncapsulationApp
{
    public class Car
    {
        // Fields
        private string _brand;
        private string _model;
        private string _color;
        private int _numbersOfDoor;

        // Constructors
        public Car(string brand, string model, string color, int numbersOfDoor)
        {
            _brand = brand;
            _model = model;
            _color = color;
            _numbersOfDoor = numbersOfDoor;
        }

        // Properties
        public string Brand 
        { 
            get { return _brand; }
            set { _brand = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public int NumbersOfDoor
        {
            get { return _numbersOfDoor; }
            set 
            {
                if (value == 2 || value == 4)
                {
                    _numbersOfDoor = value;
                }
                else
                {
                    Console.WriteLine("A car must have either 2 or 4 doors!");
                    _numbersOfDoor = -1;
                }
            }
        }

        // Methods
        public void Display()
        {
            Console.WriteLine($"Brand: {Brand} / Model: {Model} / Color: {Color} / Numbers Of Door: {NumbersOfDoor}");
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
   git clone https://github.com/ulaskarakas/PatikaEncapsulationApp.git
   ```
2. **Install .NET SDK:**
   - If not already installed, download the appropriate version from the [.NET SDK](https://dotnet.microsoft.com/download) page.

3. **Navigate to the project directory and run the application:**
   ```bash
   cd PatikaEncapsulationApp
   dotnet run
   ```

---

## Example Output

```
Brand: Ford / Model: GT / Color: Red / Numbers Of Door: 2
```

---

## Key Concepts Demonstrated
### Encapsulation
- Private fields ensure that the internal state of the object is hidden from external access.
- Public properties provide controlled access to the fields, allowing for validation and other logic.

### Constructors
- The `Car` class uses a parameterized constructor to initialize the object with predefined values.

### Validation
- The `NumbersOfDoor` property includes validation logic to ensure that only valid values (2 or 4) are accepted.

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
