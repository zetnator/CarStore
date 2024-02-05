using CarStore_Models.Models;
using CarStore_DL.Interfaces;
using CarStore_BL.Interfaces;
using CarStore_Models.Responses;
using CarStore_Models.Requests;


namespace CarStore_BL.Services
{
    public class CarService : ICarStoreService
    {
        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public void AddCar(Car car)
        {
            _carRepository.AddCar(car);
        }

        public void DeleteCar(int id)
        {
            _carRepository.DeleteCar(id);
        }

        public List<Car> GetAllCars()
        {
            return _carRepository.GetAllCars();
        }

        public GetCarsByBuyerIdResponse? GetByBuyer(GetCarsByBuyerIdRequest request)
        {
            throw new NotImplementedException();
        }

        public Car? GetCarById(int id)
        {
            return _carRepository.GetCarById(id);
        }

        public GetCarsByBuyerIdResponse? GetCarsByBuyerId(GetCarsByBuyerIdRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
