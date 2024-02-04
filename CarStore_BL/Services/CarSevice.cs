using CarStore_Models.Models;
using CarStore_DL.Interfaces;
using CarStore_BL.Interfaces;


namespace CarStore_BL.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public void Add(Car car)
        {
            _carRepository.Add(car);
        }

        public void Delete(int id)
        {
            _carRepository.Delete(id);
        }

        public List<Car> GetAll()
        {
            return _carRepository.GetAll();
        }
        public Car? GetById(int id) => _carRepository.GetById(id);


    }
}
