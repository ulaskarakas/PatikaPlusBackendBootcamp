# Patika - Library App

This project demonstrates the use of classes, properties, constructors, and other object-oriented programming concepts in C#. The application focuses on creating and managing `Book` objects with various attributes and behaviors.

## Project Purpose

This project serves as a practical example for understanding and applying object-oriented programming concepts in C#. It is a part of the Patika.dev platform's educational series to help developers strengthen their skills in class design and implementation.

---

## Application Features

- **Book Class**:
  - Represents a book with attributes such as:
    - `Name`: The title of the book.
    - `WriterName` and `WriterSurname`: The author's first and last name.
    - `NumbersOfPage`: Total number of pages in the book.
    - `Publisher`: The publishing company.
    - `RecordDate`: The date the book record was created (automatically set to the current date).
  - Includes constructors to initialize `Book` objects.
  - Automatically displays book details when a new object is created using the parameterized constructor.

---

## Code Structure

### Main Program

The `Program` class contains the `Main` method, which serves as the entry point for the application. It demonstrates the creation of `Book` objects and displays their details:

```csharp
namespace PatikaLibraryApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Book bookOne = new Book("Adı Aylin", "Ayşe", "Kulin", 398, "Remzi Kitabevi");
        }
    }
}
```

### `Book` Class

The `Book` class encapsulates the attributes and behaviors of a book. It includes:

- **Fields**: Private variables to store book data.
- **Properties**: Public accessors and mutators for encapsulation.
- **Constructors**:
  - A default constructor that initializes the `RecordDate` to the current date.
  - A parameterized constructor to initialize book attributes and display details.
- **Methods**: Additional methods can be added as needed to extend functionality.

```csharp
namespace PatikaLibraryApp
{
    public class Book
    {
        // Fields
        private string _name;
        private string _writerName;
        private string _writerSurname;
        private int _numbersOfPage;
        private string _publisher;
        private DateTime _recordDate;

        // Properties
        public string Name {  get { return _name; } set { _name = value; } }
        public string WriterName { get { return _writerName; } set { _writerName = value; } }
        public string WriterSurname { get { return _writerSurname;} set { _writerSurname = value; } }
        public int NumbersOfPage { get { return _numbersOfPage; } set { _numbersOfPage = value; } }
        public string Publisher { get { return _publisher; } set { _publisher = value; } }
        public DateTime DateTime { get { return _recordDate; } set { _recordDate = value; } }

        // Constructors
        public Book()
        {
            _recordDate = DateTime.Now;
        }

        public Book(string name, string writerName, string writerSurname, int numbersOfPage, string publisher)
        {
            _recordDate = DateTime.Now;
            Console.WriteLine($"Kitap Adi: {name} / Yazar Adi-Soyadi: {writerName} {writerSurname} / Sayfa Sayisi: {numbersOfPage} / Yayinevi: {publisher} / Kayit Tarihi: {_recordDate.ToString("dd-MM-yyyy")}");
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
   git clone https://github.com/ulaskarakas/PatikaLibraryApp.git
   ```
2. **Install .NET SDK:**
   - If not already installed, download the appropriate version from the [.NET SDK](https://dotnet.microsoft.com/download) page.

3. **Navigate to the project directory and run the application:**
   ```bash
   cd PatikaLibraryApp
   dotnet run
   ```
   
---

## Key Concepts Demonstrated

- **Class**: A blueprint for creating objects that encapsulate data and behavior.
- **Properties**: Encapsulate fields and provide controlled access.
- **Constructors**: Special methods used to initialize objects.
- **Object Creation**: Using the `new` keyword to instantiate objects.

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
