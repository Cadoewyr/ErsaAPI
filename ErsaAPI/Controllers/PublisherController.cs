using ErsaAPI.BL.Repositories;
using ErsaAPI.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ErsaAPI.Controllers
{
    [ApiController]
    [Route("Publisher")]
    public class PublisherController : Controller
    {
        //Done
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            PublisherRepository publisherRepository = new PublisherRepository();
            List<Publisher> publishers = publisherRepository.GetAll().ToList();

            return Json(publishers);
        }

        //Done
        [HttpGet]
        [Route("Get")]
        public IActionResult Get(int id)
        {
            PublisherRepository publisherRepository = new PublisherRepository();
            Publisher publisher = publisherRepository.GetByID(id);

            return Json(publisher);
        }

        //Done
        [HttpPost]
        [Route("Add")]
        public IActionResult Add(Publisher publisher)
        {
            PublisherRepository publisherRepository = new PublisherRepository();

            return Json(publisherRepository.Add(publisher));
        }

        //Done
        [HttpPost]
        [Route("Update")]
        public IActionResult Update(int id, Publisher entity)
        {
            PublisherRepository publisherRepository = new PublisherRepository();
            return Json(publisherRepository.Update(id, entity));
        }

        //Done
        [HttpPost]
        [Route("Delete")]
        public IActionResult Delete(int id)
        {
            PublisherRepository publisherRepository = new PublisherRepository();
            return Json(publisherRepository.Delete(id));
        }
    }
}
