# Patika - Create First Class App

This project demonstrates the creation and usage of a simple class in C#. The `Person` class is used to represent individuals with properties such as name, surname, and birth date. The application creates multiple instances of the `Person` class and displays their information on the console.

## Project Purpose

The purpose of this project is to:

- Introduce the basics of class creation in C#.
- Demonstrate encapsulation using properties.
- Show how to create and use methods within a class.
- Practice working with objects and their attributes.

---

## Application Features

- **Encapsulation**: The `Person` class encapsulates its properties (`Name`, `Surname`, `BirthDate`) using getters and setters.
- **Object Instantiation**: Creates multiple instances of the `Person` class to represent students and teachers.
- **Method Usage**: Includes a `DisplayPerson` method to display an individual's information in a formatted manner.

---

## Code Structure

### Main Program

The `Program` class is the entry point of the application. It:

1. Creates instances of the `Person` class.
2. Sets the properties (`Name`, `Surname`, `BirthDate`) for each instance.
3. Calls the `DisplayPerson` method to print the details of each person.

### Person Class

The `Person` class includes:

- **Properties**:
  - `Name`: Stores the person's first name.
  - `Surname`: Stores the person's last name.
  - `BirthDate`: Stores the person's date of birth.
- **Method**:
  - `DisplayPerson`: Prints the person's name, surname, and formatted birth date.

---

## Technologies Used

- **C#**: Programming language used for development.
- **.NET Core**: Framework for project execution.

---

## Installation and Execution

Follow these steps to run the application:

1. **Clone the project:**
   ```bash
   git clone https://github.com/ulaskarakas/PatikaCreateFirstClassApp.git
   ```
2. **Install .NET SDK:**
   - If not already installed, download the appropriate version from the [.NET SDK](https://dotnet.microsoft.com/download) page.

3. **Navigate to the project directory and run the application:**
   ```bash
   cd PatikaCreateFirstClassApp
   dotnet run
   ```

---

## Example Output

```
Birinci ögrencinin adi-soyadi: Mehmet Akyüz. Dogum tarihi: 15.12.1994
İkinci ögrencinin adi-soyadi: Ahmet Ekim. Dogum tarihi: 03.02.1995
Birinci ögretmenin adi-soyadi: Murat Akın. Dogum tarihi: 30.08.1985
İkinci ögretmenin adi-soyadi: Kerem Solmaz. Dogum tarihi: 12.04.1988
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
