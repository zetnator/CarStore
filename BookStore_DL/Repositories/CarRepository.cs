using CarStore_Models.Models;
using CarStore_DL.Interfaces;
using CarStore_DL.MemoryDB;

namespace CarStore_DL.Repositories
{
    public class CarRepository : ICarRepository
    {
        public void Add(Car car)
        {
            InMemoryDB.BuyerData.Add(buyer);
        }

        public void Delete(int id)
        {
            var book = GetById(id);
            if (book != null)
            {
                InMemoryDB.CarData.Remove(car);
            }

        }

        public List<Car> GetAll()
        {
            return InMemoryDB.CarData;
        }

        public Car? GetById(int id)
        {
            return InMemoryDB.CarData.FirstOrDefault(a => a.Id == id);
        }

        public Car? GetCarById(int id)
        {
            throw new NotImplementedException();
        }

        void ICarRepository.Add(Car buyer)
        {
            throw new NotImplementedException();
        }

        void ICarRepository.Delete(int id)
        {
            throw new NotImplementedException();
        }

        List<Car> ICarRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        List<Car> ICarRepository.GetAllCarsByBuyerId(int authorId)
        {
            return InMemoryDB.CarData.Where(b => b.BuyerId == authorId).ToList();
        }

        Car? ICarRepository.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
