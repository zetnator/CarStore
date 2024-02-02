using CarStore_Models.Models;

namespace CarStore_BL.Interfaces
{
    public interface ICarService
    {
        List<Car> GetAll();

        Car? GetBooksById(int id);

        void Add(Car book);

        void Delete(int id);
    }
}
