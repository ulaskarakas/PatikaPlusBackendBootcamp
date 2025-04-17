# Patika - Try Catch App

This is a simple console application written in C# that prompts the user to enter a number, validates the input, and calculates the square of the entered number. The program ensures that the input is a valid integer and handles invalid inputs gracefully using exception handling.

## Project Purpose

The purpose of this project is to:
- Demonstrate the use of exception handling in C#.
- Validate user input in a console application.
- Provide a simple example of mathematical operations in C#.

---

## Application Features

- **Input Validation**: Ensures the user enters a valid integer.
- **Error Handling**: Displays an error message for invalid inputs and allows the user to try again.
- **Mathematical Calculation**: Calculates and displays the square of the entered number.

---


## Code Example

```csharp
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
   git clone https://github.com/ulaskarakas/PatikaTryCatchApp.git
   ```
2. **Install .NET SDK:**
   - If not already installed, download the appropriate version from the [.NET SDK](https://dotnet.microsoft.com/download) page.

3. **Navigate to the project directory and run the application:**
   ```bash
   cd PatikaTryCatchApp
   dotnet run
   ```

---

## Example Output

![image](https://github.com/user-attachments/assets/d4f0e35b-87a4-49c0-b805-5c3ae532e798)

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

