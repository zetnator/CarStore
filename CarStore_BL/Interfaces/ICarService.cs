using CarStore_Models.Models;

namespace CarStore_BL.Interfaces
{
    public interface ICarStoreService
    {
        List<Car> GetAllCars();

        Car? GetCarById(int id);

        void AddCar(Car car);

        void DeleteCar(int id);
    }
}
