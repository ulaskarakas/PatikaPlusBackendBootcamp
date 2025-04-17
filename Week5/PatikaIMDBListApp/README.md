# Patika - IMDB List App

Patika IMDB List App is a console application that allows users to add movies, list them based on specific criteria, and analyze them according to their IMDB ratings.

## Project Purpose

The purpose of the Patika IMDB List App is to provide users with a simple and interactive way to manage their movie lists. It allows users to add movies with their IMDB ratings, view the list of movies they’ve added, and filter the movies based on specific criteria, such as IMDB rating or movies starting with a particular letter. This application helps users practice fundamental programming concepts like object-oriented design, list management, and filtering operations in C#.

---

## Application Features

1. **Add Movie:** Users can add movies to the list by entering the movie name and IMDB rating.
2. **View Movie List:** Users can view the movies they have added.
3. **Filter by IMDB Rating:** Lists movies with IMDB ratings between 4 and 9.
4. **List Movies Starting with a Specific Letter:** Lists movies that start with the letter "A".

---


## Code Example

### Program.cs
```csharp
using PatikaIMDBListApp;

public class Program
{
    public static void Main(string[] args)
    {
        List<Movie> movies = new List<Movie>();
        string? answer;

        do
        {
            double point;
            Console.WriteLine("Enter the IMDB score and name of the movie you want to add.");
            Console.Write("IMDB Point: ");
            while (!double.TryParse(Console.ReadLine(), out point))
            {
                Console.Write("Invalid value! Please enter a double: ");
            }
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Movie movie = new Movie(point, name);
            movies.Add(movie);

            Console.WriteLine("Would you like to add a new movie? (Y/N)");
            answer = Console.ReadLine();
            while (answer.ToLower() != "y" && answer.ToLower() != "n")
            {
                Console.WriteLine("Invalid value! Please enter Y(Yes) or N(No): ");
                answer = Console.ReadLine();
            }
        }
        while (answer.ToLower() == "y");

        Console.WriteLine("****************************************\n");

        // Show added movies
        Console.WriteLine("Added Movies");
        Console.WriteLine("------------");
        foreach (var movie in movies)
        {
           Console.WriteLine(movie.Name);
        }

        // Show movies with IMDB score between 4 and 9
        Console.WriteLine("Movies with IMDB score between 4 and 9");
        Console.WriteLine("--------------------------------------");
        bool foundMovie = false;
        foreach (var movie in movies)
        {
            if (movie.IMDBpoint >= 4 && movie.IMDBpoint <= 9)
            {
                Console.WriteLine(movie.Name);
                foundMovie = true;
            }
        }
        if (!foundMovie)
        {
            Console.WriteLine("There are no movies with IMDB score between 4 and 9.");
        }

        // Show movies starting with 'A'
        foundMovie = false;
        Console.WriteLine("Movies starting with 'A'");
        Console.WriteLine("------------------------");
        foreach (var movie in movies)
        {
            if (movie.Name == "A" || movie.Name == "a")
            {
                Console.WriteLine(movie.Name);
                foundMovie = true;
            }
        }
        if (!foundMovie)
        {
            Console.WriteLine("There are no movies starting with 'A'");
        }
    }
}
```

### Movie.cs
```csharp
namespace PatikaIMDBListApp
{
    public class Movie
    {
        public double IMDBpoint { get; set; }
        public string Name { get; set; }

        public Movie(double imdbPoint, string name)
        {
            IMDBpoint = imdbPoint;
            Name = name;
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
   git clone https://github.com/ulaskarakas/PatikaIMDBListApp.git
   ```
2. **Install .NET SDK:**
   - If not already installed, download the appropriate version from the [.NET SDK](https://dotnet.microsoft.com/download) page.

3. **Navigate to the project directory and run the application:**
   ```bash
   cd PatikaIMDBListApp
   dotnet run
   ```

---

## Example Output

![image](https://github.com/user-attachments/assets/708235a9-9590-4384-8fc2-48cfba6f473a)

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
