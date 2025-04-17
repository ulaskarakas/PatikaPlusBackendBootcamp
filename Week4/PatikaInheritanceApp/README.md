# Patika - Inheritance App

This project demonstrates the use of inheritance and polymorphism in C# by creating a simple application with `BasePerson`, `Student`, and `Teacher` classes. The project highlights how common properties and methods can be defined in a base class and then specialized in derived classes.

## Project Purpose

The purpose of this project is to:

1. Illustrate the fundamental principles of inheritance in OOP.
2. Show how to use abstract classes and methods to enforce implementation in derived classes.
3. Provide a practical example of code reuse and polymorphism.
4. Highlight how to structure and organize related classes in a hierarchical manner.

---

## Application Features

1. **Abstract Base Class:**
   - The `BasePerson` class serves as a blueprint for derived classes, enforcing the implementation of the `Introduce()` method.

2. **Specialized Classes:**
   - `Student` and `Teacher` extend `BasePerson`, demonstrating how to add unique properties and behaviors to derived classes.

3. **Encapsulation:**
   - Properties like `Name`, `Surname`, `StudentNumber`, and `Salary` are encapsulated within their respective classes.

4. **Polymorphism:**
   - The `Introduce()` method is overridden in each derived class, allowing for behavior specific to `Student` and `Teacher` objects.

5. **Reusability:**
   - Common functionality is defined in the base class and reused across derived classes, reducing code duplication.

---

## Project Structure
- **BasePerson (Abstract Class):**
  - Properties: `Name`, `Surname`
  - Abstract Method: `Introduce()`

- **Student (Derived Class):**
  - Inherits: `BasePerson`
  - Additional Property: `StudentNumber`
  - Overrides: `Introduce()`

- **Teacher (Derived Class):**
  - Inherits: `BasePerson`
  - Additional Property: `Salary`
  - Overrides: `Introduce()`

---

## How It Works

1. The `BasePerson` class defines common properties (`Name`, `Surname`) and an abstract method `Introduce()` that must be implemented by derived classes.
2. The `Student` class extends `BasePerson`, adding a `StudentNumber` property and implementing the `Introduce()` method to display student-specific information.
3. The `Teacher` class extends `BasePerson`, adding a `Salary` property and implementing the `Introduce()` method to display teacher-specific information.
4. The `Program` class creates instances of `Student` and `Teacher`, demonstrating polymorphism and inheritance by calling their `Introduce()` methods.

---

## Technologies Used

- **C#**: Programming language used for development.
- **.NET Core**: Framework for project execution.

---

## Installation and Execution

Follow these steps to run the application:

1. **Clone the project:**
   ```bash
   git clone https://github.com/ulaskarakas/PatikaInheritanceApp.git
   ```
2. **Install .NET SDK:**
   - If not already installed, download the appropriate version from the [.NET SDK](https://dotnet.microsoft.com/download) page.

3. **Navigate to the project directory and run the application:**
   ```bash
   cd PatikaInheritanceApp
   dotnet run
   ```

---

## Example Output

```
Salary: 50000 TL / Name: Orhan / Surname: Akın
Student Number: 253496 / Name: Ahmet / Surname: Ekim
```

---

## Key Concepts Demonstrated
- **Inheritance:** Common properties and methods are inherited from `BasePerson`.
- **Abstract Classes and Methods:** The `Introduce()` method is enforced in derived classes.
- **Polymorphism:** Different implementations of `Introduce()` are called based on the object type.

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
