# Patika - Patikaflix App

This project is a console-based application for managing and displaying a list of TV series using C#. It demonstrates the use of classes, LINQ queries, and list operations.

## Project Purpose

This project aims to:
- Demonstrate the basics of object-oriented programming (OOP) in C#.
- Showcase the use of LINQ for data filtering and transformation.
- Provide a practical example of managing and processing collections.

---

## Application Features

- Add TV series with details like name, genre, director, production year, release year, and release platform.
- Filter and display series based on specific criteria.
- Extract and sort basic information about comedy series.
- Demonstrates LINQ operations such as `Where`, `Select`, and `OrderBy`.

---

## Files Overview

### 1. `Program.cs`
The main entry point of the application. Handles user input, adds series to the list, filters comedy series, and displays sorted results.

### 2. `Series.cs`
Defines the `Series` class, which represents a TV series with detailed properties such as:
- `Name`
- `ProductionYear`
- `Genre`
- `ReleaseYear`
- `Director`
- `ReleasePlatform`

### 3. `BasicSerie.cs`
Defines the `BasicSerie` class, a simplified version of the `Series` class containing:
- `Name`
- `Genre`
- `Director`

---

## How to Use

1. **Add Series**: 
   - The application prompts the user to enter details for each series.
   - Continue adding series until you choose to stop.

2. **Filter Comedy Series**:
   - The program filters all series with the genre "Comedy".

3. **Sort and Display**:
   - Extracts basic information (name, genre, director) from comedy series.
   - Sorts them alphabetically by name and director.
   - Displays the sorted list.

---

## Example Output

```
Welcome to Patikaflix!
Please enter the information of the directory you want to add.
Name of serie: Friends
Production Year: 1994
Genre: Comedy
Release Year: 1994
Director: David Crane
Release Platform: NBC
Would you like to add a new serie? (Y/N): y

... (additional entries)

Comedy series: 
Name: Friends - Genre: Comedy - Director: David Crane
Name: The Office - Genre: Comedy - Director: Greg Daniels
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
   git clone https://github.com/ulaskarakas/PatikaPatikaflixApp.git
   ```
2. **Install .NET SDK:**
   - If not already installed, download the appropriate version from the [.NET SDK](https://dotnet.microsoft.com/download) page.

3. **Navigate to the project directory and run the application:**
   ```bash
   cd PatikaPatikaflixApp
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
