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
