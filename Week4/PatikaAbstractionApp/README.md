# Patika - Abstraction App

This project demonstrates the concept of Abstraction in C# using both `Interface` and `Abstract Class`. The project implements abstraction through two different approaches to illustrate their usage.

## Project Purpose

This project aims to demonstrate the two different methods of abstraction (interface and abstract class) and explain their use cases.

---

## Application Features

- **Abstraction Demonstration**: Showcases the use of abstraction using both interfaces and abstract classes.
- **Polymorphism**: Demonstrates polymorphism by calling the Task() method on objects of different types through a common base type.
- **Code Modularity**: Encapsulates employee-related logic in separate classes, ensuring a clean and modular code structure.
- **Extensibility**: Easily extendable to include more roles or departments by adding new classes that implement the interface or inherit from the abstract class.

---

## Code Description

### Using Interface
An IEmployee interface is defined with the following properties and method:

- **Properties**:
  - `Name`: The employee's first name.
  - `Surname`: The employee's last name.
  - `Department`: The department the employee works in.
- **Methods**:
  - `Task()`: A method to define the employee's task.

Classes implementing the IEmployee interface:
- `SoftwareDeveloper`
- `ProjectManager`
- `SalesRepresentative`

Each class overrides the `Task()` method to provide a specific implementation.

### Using Abstract Class
An Employee abstract class is defined with the following properties and method:

- **Properties**:
  - `Name`: The employee's first name.
  - `Surname`: The employee's last name.
  - `Department`: The department the employee works in.
- **Methods**:
  - `Task()`: A method to define the employee's task.
 
Classes inheriting from the Employee abstract class:
- `SoftwareDeveloperWithClass`
- `ProjectManagerWithClass`
- `SalesRepresentativeWithClass`

Each class overrides the `Task()` method to provide a specific implementation.

---

## Technologies Used

- **C#**: Programming language used for development.
- **.NET Core**: Framework for project execution.

---

## Installation and Execution

Follow these steps to run the application:

1. **Clone the project:**
   ```bash
   git clone https://github.com/ulaskarakas/PatikaAbstractionApp.git
   ```
2. **Install .NET SDK:**
   - If not already installed, download the appropriate version from the [.NET SDK](https://dotnet.microsoft.com/download) page.

3. **Navigate to the project directory and run the application:**
   ```bash
   cd PatikaAbstractionApp
   dotnet run
   ```

---

## Example Output

```
** Abstraction with Interface **
My name is Ahmet Ekim. I'm working as Software Developer in Sofware Department.
My name is Cengiz Erden. I'm working as Project Manager in Sofware Department.
My name is Ümit Avcı. I'm working as Sales Representative in Sales Department.

*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*

** Abstraction with Abstract Class **
My name is Ahmet Ekim. I'm working as Software Developer in Sofware Department.
My name is Cengiz Erden. I'm working as Software Developer in Sofware Department.
My name is Ümit Avcı. I'm working as Software Developer in Sofware Department.
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
