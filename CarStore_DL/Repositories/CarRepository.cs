using CarStore_Models.Models;
using CarStore_DL.Interfaces;
using CarStore_DL.MemoryDB;

namespace CarStore_DL.Repositories
{
    public class CarRepository : ICarRepository
    {
        public void Add(Car car)
        {
            InMemoryDB.CarData.Add(car);
        }

        public void Delete(int id)
        {
            var car = GetById(id);
            if (car != null)
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
            return InMemoryDB.CarData.FirstOrDefault(c => c.Id == id);
        }

        public Car? GetCarById(int id)
        {
            throw new NotImplementedException();
        }

        public Car? GetAllCarsByBuyerId(int buyerId)
        {
            return InMemoryDB.CarData.Where(b => b.BuyerId == buyerId).ToList();
        }

        List<Car> ICarRepository.GetAllCarsByBuyerId(int buyerId)
        {
            throw new NotImplementedException();
        }
    }
}
