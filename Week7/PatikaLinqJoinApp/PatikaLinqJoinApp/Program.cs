using PatikaLinqJoinApp;

public class Program
{
    public static void Main(string[] args)
    {
        List<Author> authors = new List<Author>();
        authors.Add(new Author { AuthorId = 1, Name = "Orhan Pamuk" });
        authors.Add(new Author { AuthorId = 2, Name = "Elif Şafak" });
        authors.Add(new Author { AuthorId = 3, Name = "Ahmet Ümit" });

        List<Book> books = new List<Book>();
        books.Add(new Book { BookId = 1, Title = "Kar", AuthorId = 1 });
        books.Add(new Book { BookId = 2, Title = "İstanbul", AuthorId = 1 });
        books.Add(new Book { BookId = 3, Title = "10 Minutes 38 Seconds in This Strange World", AuthorId = 2 });
        books.Add(new Book { BookId = 4, Title = "Beyoğlu Rapsodisi", AuthorId = 3 });

        /*
        var mergedAuthorsAndBooks = authors.Join(books,
                                                 author => author.AuthorId,
                                                 book => book.AuthorId,
                                                 (author, book) => new
                                                 {
                                                     BookTitle = book.Title,
                                                     AuthorName = author.Name
                                                 }
                                                 );
        */
        
        var mergedAuthorsAndBooks = from author in authors
                                    join book in books on author.AuthorId equals book.AuthorId
                                    select new
                                    {
                                        BookTitle = book.Title,
                                        AuthorName = author.Name
                                    };

        foreach (var book in mergedAuthorsAndBooks)
        {
            Console.WriteLine($"Book Title: {book.BookTitle} - Author Name: {book.AuthorName}");
        }

    }
}