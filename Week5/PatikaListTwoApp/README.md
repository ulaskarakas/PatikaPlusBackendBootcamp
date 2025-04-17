# Patika - List Two App

This is a simple C# console application where users can input and list their favorite coffee names. The program demonstrates basic usage of lists, loops, and console input/output operations in C#.

## Project Purpose

The purpose of this project is to:
- Provide a hands-on example of how to use collections in C#.
- Demonstrate how to gather and display user input via the console.
- Illustrate the use of loops (`for` and `foreach`) for data collection and processing.
- Serve as a foundational example for beginners to understand list manipulation in C#.

---

## Application Features

- Allows the user to input the names of 5 coffees.
- Displays the entered coffee names in the console.

---

## Key Concepts Demonstrated

- List Collection: The List<string> is used to store and manage a collection of coffee names.
- For Loop: Used to iterate and collect user input.
- Foreach Loop: Used to display the entered coffee names.
- Console Input/Output: Demonstrates how to interact with the user via the console.

---

## Code Example
```csharp
public class Program
{
    public static void Main(string[] args)
    {
        List<string> coffeeList = new List<string>();
        Console.WriteLine("Please enter the 5 coffee names you would like to list.");

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Coffee {i+1}: ");
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
   git clone https://github.com/ulaskarakas/PatikaListTwoApp.git
   ```
2. **Install .NET SDK:**
   - If not already installed, download the appropriate version from the [.NET SDK](https://dotnet.microsoft.com/download) page.

3. **Navigate to the project directory and run the application:**
   ```bash
   cd PatikaListTwoApp
   dotnet run
   ```

---

## Example Output

```
Please enter the 5 coffee names you would like to list.
Coffee 1: Espresso
Coffee 2: Latte
Coffee 3: Cappuccino
Coffee 4: Mocha
Coffee 5: Americano
-----------
Entered coffee names:
Espresso
Latte
Cappuccino
Mocha
Americano
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
