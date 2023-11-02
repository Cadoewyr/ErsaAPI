using ErsaAPI.BL.Repositories;
using ErsaAPI.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ErsaAPI.Controllers
{
    [ApiController]
    [Route("Category")]
    public class CategoryController : Controller
    {
        //Done
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            List<Category> categories = categoryRepository.GetAll().ToList();

            return Json(categories);
        }

        //Done
        [HttpGet]
        [Route("Get")]
        public IActionResult Get(int id)
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            Category category = categoryRepository.GetByID(id);

            return Json(category);
        }

        //Done
        [HttpPost]
        [Route("Add")]
        public IActionResult Add(Category category)
        {
            CategoryRepository categoryRepository = new CategoryRepository();

            return Json(categoryRepository.Add(category));
        }

        //Done
        [HttpPost]
        [Route("Update")]
        public IActionResult Update(int id, Category entity)
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            return Json(categoryRepository.Update(id, entity));
        }

        //Done
        [HttpPost]
        [Route("Delete")]
        public IActionResult Delete(int id)
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            return Json(categoryRepository.Delete(id));
        }
    }
}
