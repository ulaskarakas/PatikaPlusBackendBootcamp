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