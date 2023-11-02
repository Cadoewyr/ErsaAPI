using ErsaAPI.BL.Repositories;
using ErsaAPI.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ErsaAPI.Controllers
{
    [ApiController]
    [Route("Book")]
    public class BookController : Controller
    {
        //Done
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            BookRepository bookRepository = new BookRepository();
            List<Book> books = bookRepository.GetAll().ToList();

            return Json(books);
        }

        //Done
        [HttpGet]
        [Route("Get")]
        public IActionResult Get(int id)
        {
            BookRepository bookRepository = new BookRepository();
            Book book = bookRepository.GetByID(id);

            return Json(book);
        }

        //Done
        [HttpPost]
        [Route("Add")]
        public IActionResult Add(Book book)
        {
            BookRepository bookRepository = new BookRepository();

            return Json(bookRepository.Add(book));
        }

        //Done
        [HttpPost]
        [Route("Update")]
        public IActionResult Update(int id, Book entity)
        {
            BookRepository bookRepository = new BookRepository();
            return Json(bookRepository.Update(id, entity));
        }

        //Done
        [HttpPost]
        [Route("Delete")]
        public IActionResult Delete(int id)
        {
            BookRepository bookRepository = new BookRepository();
            return Json(bookRepository.Delete(id));
        }
    }
}
