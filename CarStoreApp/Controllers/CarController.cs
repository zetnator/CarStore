using CarStore_Models.Models;
using Microsoft.AspNetCore.Mvc;
using CarStore_BL.Interfaces;

namespace CarStoreApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarStoreService _carService;

        public CarController(ICarStoreService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        public Car GetCarById(int id)
        {
            return _carService.GetCarById(id);
        }

        [HttpGet]
        public List<Car> GetAllCars()
        {
            return _carService.GetAllCars();
        }

        [HttpPost]
        public void AddCar(Car car)
        {
            _carService.AddCar(car);
        }

        [HttpDelete]
        public void DeleteCar(int id)
        {
            _carService.DeleteCar(id);
        }
    }
}
