using ErsaAPI.BL.Repositories;
using ErsaAPI.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ErsaAPI.Controllers
{
    [ApiController]
    [Route("Author")]
    public class AuthorController : Controller
    {
        //Done
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            AuthorRepository authorRepository = new AuthorRepository();
            List<Author> authors = authorRepository.GetAll().ToList();

            return Json(authors);
        }

        //Done
        [HttpGet]
        [Route("Get")]
        public IActionResult Get(int id)
        {
            AuthorRepository authorRepository = new AuthorRepository();
            Author author = authorRepository.GetByID(id);

            return Json(author);
        }

        //Done
        [HttpPost]
        [Route("Add")]
        public IActionResult Add(Author author)
        {
            AuthorRepository authorRepository = new AuthorRepository();

            return Json(authorRepository.Add(author));
        }

        //Done
        [HttpPost]
        [Route("Update")]
        public IActionResult Update(int id, Author entity)
        {
            AuthorRepository authorRepository = new AuthorRepository();
            return Json(authorRepository.Update(id, entity));
        }

        //Done
        [HttpPost]
        [Route("Delete")]
        public IActionResult Delete(int id)
        {
            AuthorRepository authorRepository = new AuthorRepository();
            return Json(authorRepository.Delete(id));
        }
    }
}
