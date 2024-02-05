using CarStore_Models.Models;

namespace CarStore_DL.Interfaces
{
    public interface ICarRepository
    {
        List<Car> GetAllCars();

        List<Car> GetAllCarsByBuyerId(int buyerId);

        Car? GetCarById(int id);

        void AddCar(Car buyer);

        void DeleteCar(int id);
    }
}
