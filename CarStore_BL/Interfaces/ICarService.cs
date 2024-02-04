using CarStore_Models.Models;

namespace CarStore_BL.Interfaces
{
    public interface ICarService
    {
        List<Car> GetAll();

        Car? GetById(int id);

        void Add(Car book);

        void Delete(int id);
    }
}
