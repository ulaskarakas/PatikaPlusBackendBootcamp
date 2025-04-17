namespace PatikaPatikaflixApp
{
    public class Series
    {
        public string Name { get; set; }
        public int ProductionYear { get; set; }
        public string Genre { get; set; }
        public int ReleaseYear {  get; set; }
        public string Director { get; set; }
        public string ReleasePlatform { get; set; }

        public Series(string name, int productionYear, string genre, int releaseYear, string director, string releasePlatfrom)
        {
            Name = name;
            ProductionYear = productionYear;
            Genre = genre;
            ReleaseYear = releaseYear;
            Director = director;
            ReleasePlatform = releasePlatfrom;
        }
    }
}
