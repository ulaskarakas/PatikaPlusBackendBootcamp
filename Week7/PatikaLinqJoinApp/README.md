# Patika - Linq Join App

This project demonstrates how to use LINQ (Language Integrated Query) in C# to perform a join operation between two lists: authors and books. It uses either the `Join` operator or the `from...join` query syntax to merge related data and create a new list of anonymous objects, each containing the book title and the author's name.

## Project Purpose

This project provides a simple example of a book and author relationship to illustrate the usage of LINQ's `Join` operator or query syntax. The goal is to showcase the power and ease of use of LINQ for querying relational data in a way that resembles database operations.

---

## Application Features

-  **Data Joining:** Demonstrates the use of LINQ's `Join` operator or `from...join` syntax to combine data from two related lists (authors and books) based on a common key (`AuthorId`).
-   **Simplified Data Access:** Provides a simplified way to access and query relational data in C# using LINQ, similar to how you would query a database.
-   **Clear and Concise Code:** The code is designed to be easy to understand and follow, making it a good learning resource for those new to LINQ.
-   **Anonymous Objects:** Shows how to create and use anonymous objects to store and display the results of the join operation.
-   **Console Output:** The application outputs the joined data to the console, making it easy to see the results of the query.
-   **Extensible:** The project structure is simple and extensible, allowing you to easily add more features or modify the existing ones.

---

## Project Structure

- `Program.cs`: The main application file. It creates the lists of authors and books and executes the LINQ query.
- `Book.cs`: A class representing a book object. It contains properties for `BookId`, `Title`, and `AuthorId`.
- `Author.cs`: A class representing an author object. It contains properties for `AuthorId` and `Name`.

---
## Code Example

### Program.cs
```csharp
using PatikaLinqJoinApp;

public class Program
{
    public static void Main(string[] args)
    {
        List<Author> authors = new List<Author>();
        authors.Add(new Author { AuthorId = 1, Name = "Orhan Pamuk" });
        authors.Add(new Author { AuthorId = 2, Name = "Elif Şafak" });
        authors.Add(new Author { AuthorId = 3, Name = "Ahmet Ümit" });

        List<Book> books = new List<Book>();
        books.Add(new Book { BookId = 1, Title = "Kar", AuthorId = 1 });
        books.Add(new Book { BookId = 2, Title = "İstanbul", AuthorId = 1 });
        books.Add(new Book { BookId = 3, Title = "10 Minutes 38 Seconds in This Strange World", AuthorId = 2 });
        books.Add(new Book { BookId = 4, Title = "Beyoğlu Rapsodisi", AuthorId = 3 });

        /*
        var mergedAuthorsAndBooks = authors.Join(books,
                                                 author => author.AuthorId,
                                                 book => book.AuthorId,
                                                 (author, book) => new
                                                 {
                                                     BookTitle = book.Title,
                                                     AuthorName = author.Name
                                                 }
                                                 );
        */
        
        var mergedAuthorsAndBooks = from author in authors
                                    join book in books on author.AuthorId equals book.AuthorId
                                    select new
                                    {
                                        BookTitle = book.Title,
                                        AuthorName = author.Name
                                    };

        foreach (var book in mergedAuthorsAndBooks)
        {
            Console.WriteLine($"Book Title: {book.BookTitle} - Author Name: {book.AuthorName}");
        }

    }
}
```

### Author.cs
```csharp
namespace PatikaLinqJoinApp
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
    }
}
```

### Book.cs
```csharp
namespace PatikaLinqJoinApp
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
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
   git clone https://github.com/ulaskarakas/PatikaLinqJoinApp.git
   ```
2. **Install .NET SDK:**
   - If not already installed, download the appropriate version from the [.NET SDK](https://dotnet.microsoft.com/download) page.

3. **Navigate to the project directory and run the application:**
   ```bash
   cd PatikaLinqJoinApp
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

