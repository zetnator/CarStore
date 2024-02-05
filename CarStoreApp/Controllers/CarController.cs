﻿using CarStore_Models.Models;
using Microsoft.AspNetCore.Mvc;
using CarStore_BL.Interfaces;

namespace CarStoreApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarStoreService _carService;

        public CarController(ICarStoreService bookService)
        {
            _carService = bookService;
        }

        [HttpGet(template: "GetBookById")]
        public Car GetBookById(int id)
        {
            return _carService.GetBooksById(id);
        }

        [HttpGet(template: "GetAllBooks")]
        public List<Car> GetAllBooks()
        {
            return _carService.GetAll();
        }

        [HttpPost]
        public void Add(Car book)
        {
            _carService.Add(book);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _carService.Delete(id);
        }
    }
}
