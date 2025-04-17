namespace PatikaMVCLibraryProject.Models
{
    public class AuthorListViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<Book> Books { get; set; } = new List<Book>();
    }
}
