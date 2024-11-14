using Microsoft.AspNetCore.Mvc;
using NetCoreMVCLab03.Models;

namespace NetCoreMVCLab03.Controllers
{
    public class BookController : Controller
    {
        protected Book book =new Book();
        public IActionResult Index()
        {
            ViewBag.authors= book.Authors;
            ViewBag.genres=book.Genres;
            var books = book.GetBookList();
            return View(books);
        }
        public IActionResult Create()
        {
            ViewBag.authors= book.Authors;
            ViewBag.genres=book.Genres;
            Book model= new Book();
            return View(model);
        }
    }
}
