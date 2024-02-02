using CarStore_Models.Models;

namespace CarStore_DL.Interfaces
{
    public interface ICarRepository
    {
        List<Car> GetAll();

        List<Car> GetAllCarsByBuyer(int authorId);

        Car? GetById(int id);

        void Add(Car buyer);

        void Delete(int id);
    }
}
