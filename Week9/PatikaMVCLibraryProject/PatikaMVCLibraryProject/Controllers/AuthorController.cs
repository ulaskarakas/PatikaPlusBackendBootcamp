using Microsoft.AspNetCore.Mvc;
using PatikaMVCLibraryProject.Models;

namespace PatikaMVCLibraryProject.Controllers
{
    public class AuthorController : Controller
    {
        public static List<Author> authors = new List<Author>();

        // Show author list screen 
        [HttpGet]
        public IActionResult List()
        {
            var viewModel = authors.Select(a => new AuthorListViewModel()
            {
                Id = a.Id,
                FirstName = a.FirstName,
                LastName = a.LastName,
                DateOfBirth = a.DateOfBirth,
                Books = a.Books
            }).ToList();

            return View(viewModel);
        }

        // Show create author screen
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // Add an author book
        [HttpPost]
        public IActionResult Create(AuthorCreateViewModel model)
        {
            var newAuthor = new Author
            {
                Id = authors.Any() ? authors.Max(b => b.Id) + 1 : 1,
                FirstName = model.FirstName,
                LastName = model.LastName,
                DateOfBirth = model.DateOfBirth
            };

            authors.Add(newAuthor);

            return RedirectToAction("List");
        }

        // Show edit author screen
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var author = authors.FirstOrDefault(a => a.Id == id);

            if (author == null)
                return NotFound();

            var viewModel = new AuthorEditViewModel()
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                DateOfBirth = author.DateOfBirth
            };

            return View(viewModel);
        }

        // Edit an author
        [HttpPost]
        public IActionResult Edit(AuthorEditViewModel updatedAuthor)
        {
            var author = authors.FirstOrDefault(a => a.Id == updatedAuthor.Id);

            if (author == null)
                return NotFound();

            // Update author information
            author.FirstName = updatedAuthor.FirstName;
            author.LastName = updatedAuthor.LastName;
            author.DateOfBirth = updatedAuthor.DateOfBirth;

            //Update AuthorName information in author book list
            foreach (var book in author.Books)
            {
                book.AuthorName = $"{author.FirstName} {author.LastName}";
            }

            return RedirectToAction("List");
        }


        // Show author details screen
        [HttpGet]
        public IActionResult Details(int id)
        {
            var author = authors.FirstOrDefault(a => a.Id == id);

            if (author == null)
                return NotFound();

            return View(author);
        }

        // Show delete author screen
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var author = authors.FirstOrDefault(a => a.Id == id);

            if (author == null) 
                return NotFound();

            if (author.Books.Count != 0)
                ViewBag.error = "Deletion cannot be performed because there are books associating to this author. Before deleting the author, please remove all books associated to the author.";

            return View(author);
        }

        // Delete an author
        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            var author = authors.FirstOrDefault(a => a.Id == id);

            if (author == null)
                return NotFound();

            // Remove from author list
            authors.Remove(author);

            return RedirectToAction("List");
        }
    }
}