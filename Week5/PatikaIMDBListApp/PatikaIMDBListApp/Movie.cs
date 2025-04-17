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
