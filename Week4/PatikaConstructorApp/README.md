# Patika - Constructor App

This project demonstrates the use of constructors in C# through a simple application that models baby information. It includes a `Baby` class with constructors, properties, and methods to handle baby-related data.

## Project Purpose

The purpose of this project is to:

- Illustrate how constructors work in C#.
- Demonstrate the use of parameterless and parameterized constructors.
- Showcase encapsulation and the use of properties.
- Provide an example of a simple method to display object information.

---

## Application Features

- **Default Constructor**: Automatically initializes an object and prints a message.
- **Parameterized Constructor**: Initializes an object with specific values for the `Name` and `Surname` fields.
- **Properties**: Encapsulate the fields `Name`, `Surname`, and `BirthDate`.
- **Display Method**: Prints the details of a baby object in a formatted string.

---

## Code Structure

### Main Program

The `Program` class demonstrates the usage of the `Baby` class:

1. Creates two `Baby` objects using both constructors.
2. Sets the `BirthDate` for each baby.
3. Calls the `DisplayBaby` method to print details of each baby.

### Baby Class

The `Baby` class represents a baby with the following members:

#### Fields
- `_name`: Stores the baby's name.
- `_surname`: Stores the baby's surname.
- `_birthDate`: Stores the baby's birth date.

#### Constructors
- `Baby()`: A parameterless constructor that outputs "Ingaaaa" to simulate a baby's cry.
- `Baby(string name, string surname)`: A parameterized constructor that initializes the `Name` and `Surname` fields and outputs "Ingaaaa".

#### Properties
- `Name`: Gets or sets the baby's name.
- `Surname`: Gets or sets the baby's surname.
- `BirthDate`: Gets or sets the baby's birth date.

#### Methods
- `DisplayBaby(string name, string surname, DateTime birthDate)`: Displays the baby's full name and birth date in a formatted string.

---

## Technologies Used

- **C#**: Programming language used for development.
- **.NET Core**: Framework for project execution.

---

## Installation and Execution

Follow these steps to run the application:

1. **Clone the project:**
   ```bash
   git clone https://github.com/ulaskarakas/PatikaConstructorApp.git
   ```
2. **Install .NET SDK:**
   - If not already installed, download the appropriate version from the [.NET SDK](https://dotnet.microsoft.com/download) page.

3. **Navigate to the project directory and run the application:**
   ```bash
   cd PatikaConstructorApp
   dotnet run
   ```

---

## Example Output

```
Ingaaaa
Ingaaaa
Birinci bebegin adi-soyadi: Ahmet Pak. Dogum tarihi: 28.12.2024
Ikinci bebegin adi-soyadi: Mehmet Ekim. Dogum tarihi: 28.12.2024
```

---

## Key Concepts Demonstrated

- Constructors (default and parameterized).
- Encapsulation using properties.
- Object initialization and method calls.

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
