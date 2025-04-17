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
            Console.WriteLine(group.Key);

            foreach (var artist in group)
            {
                Console.WriteLine(" " + artist.NameSurname);
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