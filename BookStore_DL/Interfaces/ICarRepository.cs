using CarStore_Models.Models;

namespace CarStore_DL.Interfaces
{
    public interface ICarRepository
    {
        List<Car> GetAll();

        List<Car> GetAllCarsByBuyerId(int buyerId);

        Car? GetCarById(int id);

        void Add(Car buyer);

        void Delete(int id);
        Car? GetById(int id);
    }
}
