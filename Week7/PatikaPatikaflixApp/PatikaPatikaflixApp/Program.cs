using PatikaPatikaflixApp;

public class Program
{
    public static void Main(string[] args)
    {
        List<Series> series = new List<Series>();
        string answer = "y";
        string name, genre, director, releasePlatform;
        int productionYear, releaseYear;

        Console.WriteLine("Welcome to Patikaflix!");

        do
        {
            Console.WriteLine("Please enter the information of the directory you want to add.");

            Console.Write("Name of serie: ");
            name = Console.ReadLine();

            Console.Write("Production Year: ");
            while (!int.TryParse(Console.ReadLine(), out productionYear))
            {
                Console.Write("Invalid value! Please enter production year: ");
            }

            Console.Write("Genre: ");
            genre = Console.ReadLine();

            Console.Write("Release Year: ");
            while (!int.TryParse(Console.ReadLine(), out releaseYear))
            {
                Console.Write("Invalid value! Please enter release year: ");
            }

            Console.Write("Director: ");
            director = Console.ReadLine();

            Console.Write("Release Platform: ");
            releasePlatform = Console.ReadLine();

            series.Add(new Series(name, productionYear, genre, releaseYear, director, releasePlatform));

            Console.WriteLine("Would you like to add a new serie? (Y/N)");
            answer = Console.ReadLine().ToLower();
            while (answer != "y" && answer!= "n")
            {
                Console.WriteLine("Invalid value! Please enter Y(Yes) or N(No): ");
                answer = Console.ReadLine();
            }
        }
        while (answer == "y");

        var comedySeries = series.Where(serie => serie.Genre == "Comedy");

        List<BasicSerie> basicSeries = comedySeries
            .Select(serie => new BasicSerie
            {
                Name = serie.Name,
                Genre = serie.Genre,
                Director = serie.Director
            })
            .ToList();

        var sortedSeriesList = basicSeries.OrderBy(serie => serie.Name)
                                          .ThenBy(serie => serie.Director)
                                          .ToList();

        Console.WriteLine("Comedy series: ");
        foreach (var serie in sortedSeriesList)
        {
            Console.WriteLine($"Name: {serie.Name} - Genre: {serie.Genre} - Director: {serie.Director}");
        }

    }
}