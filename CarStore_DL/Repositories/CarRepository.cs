﻿using CarStore_Models.Models;
using CarStore_DL.Interfaces;
using CarStore_DL.MemoryDB;

namespace CarStore_DL.Repositories
{
    public class CarRepository : ICarRepository
    {
        public void AddCar(Car car)
        {
            InMemoryDB.CarData.Add(car);
        }

        public void DeleteCar(int id)
        {
            var car = GetCarById(id);
            if (car != null)
            {
                InMemoryDB.CarData.Remove(car);
            }

        }

        public List<Car> GetAllCars()
        {
            return InMemoryDB.CarData;
        }

        public Car? GetCarById(int id)
        {
            throw new NotImplementedException();
        }

        List<Car> ICarRepository.GetAllCarsByBuyerId(int buyerId)
        {
            throw new NotImplementedException();
        }
    }
}
