# Patika - Patikafy App

Patikafy App is a simple C# console application that demonstrates how to use **LINQ (Language Integrated Query)** to filter, sort, and manipulate a collection of artist data. The application manages a list of artists, each with details such as name, genre, debut year, and album sales. It then performs various operations to display specific groups of artists based on these attributes.

This program is a great example for anyone looking to learn or practice using LINQ queries in C# to handle and manipulate data in a collection.

## Project Purpose

This program is designed to manage a list of artists and perform various operations using LINQ in C#. The program filters and sorts artists based on specific criteria, such as their names, album sales, debut year, and genre. The goal is to demonstrate how LINQ can be used to query and manipulate collections of data in C#.

---

## Application Features

- **Artists whose names start with 'S'**: Displays artists whose names begin with the letter 'S'.
- **Artists with album sales over 10 million**: Filters artists who have sold more than 10 million albums.
- **Artists who debuted before 2000 and made pop music**: Displays artists who started their career before 2000 and made pop music.
- **Best selling artist**: Displays the artist with the highest album sales.
- **Oldest artist**: Displays the artist with the earliest debut year.
- **Newest artist**: Displays the artist with the most recent debut year.

---


## Code Example

### Program.cs
```csharp
using PatikaPatikafyApp;

public class Program
{
    public static void Main(string[] args)
    {
        List<Artist> artists = new List<Artist> {
            new Artist("Ajda Pekkan", "Pop", 1968, 20000000),
            new Artist("Sezen Aksu", "Türk Halk Müziği/Pop", 1971, 10000000),
            new Artist("Funda Arar", "Pop", 1999, 300000),
            new Artist("Sertab Erener", "Pop", 1994, 1000000),
            new Artist("Sıla", "Pop", 2009, 3000000),
            new Artist("Serdar Ortaç", "Pop", 1994, 10000000),
            new Artist("Tarkan", "Pop", 1992, 40000000),
            new Artist("Hande Yener", "Pop", 1999, 7000000),
            new Artist("Hadise", "Pop", 2005, 5000000),
            new Artist("Gülben Ergen", "Türk Halk Müzigi/Pop", 1997, 10000000),
            new Artist("Neşet Ertaş", "Türk Halk Müzigi/Türk Sanat Müziği", 1960, 2000000),
        };

        Console.WriteLine("Artists whose names start with 'S':");
        var startWithS = artists.Where(artist => artist.NameSurname.StartsWith("S"));
        foreach (var artist in startWithS)
        {
            Console.WriteLine(artist.NameSurname);
        }

        Console.WriteLine("****************************************************");

        Console.WriteLine("Artists with album sales over 10 million:");
        var overTenMillion = artists.Where(artist => artist.SalesAmount > 10000000);
        foreach (var artist in overTenMillion)
        {
            Console.WriteLine(artist.NameSurname);
        }

        Console.WriteLine("****************************************************");

        Console.WriteLine("Artists who debuted before 2000 and made pop music:");
        var popAndBefore2000Group = artists.Where(artist => artist.ReleaseYear < 2000 && artist.Genre.Contains("Pop")).OrderBy(artist => artist.NameSurname).GroupBy(artist => artist.ReleaseYear);
        foreach (var group in popAndBefore2000Group)
        {
            foreach (var artist in group)
            {
                Console.WriteLine(artist.NameSurname);
            }
        }

        Console.WriteLine("****************************************************");

        Console.WriteLine("Best selling artist:");
        var bestSeller = artists.OrderByDescending(artist => artist.SalesAmount).First();
        Console.WriteLine(bestSeller.NameSurname);

        Console.WriteLine("****************************************************");

        Console.WriteLine("Newest artist:");
        var newestArtist = artists.OrderBy(artist => artist.ReleaseYear).Last();
        Console.WriteLine(newestArtist.NameSurname);

        Console.Write("\n");

        Console.WriteLine("Oldest artist:");
        var oldestArtist = artists.OrderBy(artist => artist.ReleaseYear).First();
        Console.WriteLine(oldestArtist.NameSurname);

        

    }
}
```

### Artist.cs
```csharp
namespace PatikaPatikafyApp
{
    public  class Artist
    {
        public string NameSurname {  get; set; }
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }
        public int SalesAmount {  get; set; }

        public Artist(string nameSurname, string genre, int releaseYear, int salesAmount)
        {
            NameSurname = nameSurname;
            Genre = genre;
            ReleaseYear = releaseYear;
            SalesAmount = salesAmount;
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
   git clone https://github.com/ulaskarakas/PatikaPatikafyApp.git
   ```
2. **Install .NET SDK:**
   - If not already installed, download the appropriate version from the [.NET SDK](https://dotnet.microsoft.com/download) page.

3. **Navigate to the project directory and run the application:**
   ```bash
   cd PatikaPatikafyApp
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
