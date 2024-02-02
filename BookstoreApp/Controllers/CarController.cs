using CarStore_Models.Models;
using Microsoft.AspNetCore.Mvc;
using CarStore_BL.Interfaces;

namespace BookstoreApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarController(ICarService bookService)
        {
            _carService = bookService;
        }

        [HttpGet(template: "GetBookById")]
        public Car GetBookById(int id)
        {
            return _carService.GetBooksById(id);
        }

        [HttpGet(template: "GetAllBooks")]
        public List<Car> GetAllBooks()
        {
            return _carService.GetAll();
        }

        [HttpPost]
        public void Add(Car book)
        {
            _carService.Add(book);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _carService.Delete(id);
        }
    }
}
