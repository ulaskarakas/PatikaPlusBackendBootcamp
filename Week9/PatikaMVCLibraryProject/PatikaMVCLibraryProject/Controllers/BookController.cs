using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PatikaMVCLibraryProject.Models;

namespace PatikaMVCLibraryProject.Controllers
{
    public class BookController : Controller
    {
        public static List<Book> books = new List<Book>();

        // Show book list screen 
        [HttpGet]
        public IActionResult List()
        {
            var viewModel = books.Select(a => new BookListViewModel()
            {
                Id = a.Id,
                Title = a.Title,
                Genre = a.Genre,
                AuthorName = a.AuthorName,
                CopiesAvailable = a.CopiesAvailable
            }).ToList();

            return View(viewModel);
        }

        // Show create book screen
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Authors = AuthorController.authors
                .Select(a => new SelectListItem
                {
                    Value = a.Id.ToString(),
                    Text = $"{a.FirstName} {a.LastName}"
                }).ToList();

            return View();
        }

        // Add a new book
        [HttpPost]
        public IActionResult Create(BookCreateViewModel model)
        {
            var author = AuthorController.authors.FirstOrDefault(a => a.Id == model.AuthorId);

            if (author == null)
                return NotFound();

            var newBook = new Book
            {
                Id = books.Any() ? books.Max(b => b.Id) + 1 : 1,
                Title = model.Title,
                Genre = model.Genre,
                ISBN = model.ISBN,
                PublishDate = model.PublishDate,
                CopiesAvailable = model.CopiesAvailable,
                AuthorId = author.Id,
                AuthorName = $"{author.FirstName} {author.LastName}"
            };

            books.Add(newBook);

            if (author != null)
                author.Books.Add(newBook);

            return RedirectToAction("List");
        }

        // Show edit book screen
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Authors = AuthorController.authors
                .Select(a => new SelectListItem
                {
                    Value = a.Id.ToString(),
                    Text = $"{a.FirstName} {a.LastName}"
                }).ToList();

            var book = books.FirstOrDefault(a => a.Id == id);

            if (book == null)
                return NotFound();

            var author = AuthorController.authors.FirstOrDefault(a => a.Id == book.AuthorId);

            if (author == null)
                return NotFound();

            var viewModel = new BookEditViewModel()
            {
                Id = books.Any() ? books.Max(b => b.Id) + 1 : 1,
                Title = book.Title,
                Genre = book.Genre,
                ISBN = book.ISBN,
                PublishDate = book.PublishDate,
                CopiesAvailable = book.CopiesAvailable,
                AuthorId = author.Id,
                AuthorName = $"{author.FirstName} {author.LastName}"
            };

            return View(viewModel);
        }

        // Edit a book
        [HttpPost]
        public IActionResult Edit(BookEditViewModel updatedBook)
        {
            var book = books.FirstOrDefault(b => b.Id == updatedBook.Id);

            if (book == null)
                return NotFound();

            // Remove from previous author book list 
            var oldAuthor = AuthorController.authors.FirstOrDefault(a => a.Id == book.AuthorId);
            if (oldAuthor != null)
            {
                oldAuthor.Books.Remove(book);
            }

            // Update book information
            book.Title = updatedBook.Title;
            book.Genre = updatedBook.Genre;
            book.ISBN = updatedBook.ISBN;
            book.PublishDate = updatedBook.PublishDate;
            book.CopiesAvailable = updatedBook.CopiesAvailable;
            book.AuthorId = updatedBook.AuthorId;

            // Add to book new author book list
            var newAuthor = AuthorController.authors.FirstOrDefault(a => a.Id == updatedBook.AuthorId);

            if (newAuthor != null)
            {
                book.AuthorName = $"{newAuthor.FirstName} {newAuthor.LastName}";
                newAuthor.Books.Add(book);
            }

            return RedirectToAction("List");
        }


        // Show book details screen
        [HttpGet]
        public IActionResult Details(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);

            if (book == null)
                return NotFound();

            return View(book);
        }

        // Show delete book screen
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);

            if (book == null)
                return NotFound();

            return View(book);
        }

        // Delete a book
        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);

            if (book == null)
                return NotFound();

            // Access to author of book and remove from book list
            var author = AuthorController.authors.FirstOrDefault(a => a.Id == book.AuthorId);

            if (author != null)
                author.Books.Remove(book);

            // Remove from book list
            books.Remove(book);

            return RedirectToAction("List");
        }
    }
}
