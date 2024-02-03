using CarStore_Models.Models;
using CarStore_DL.Interfaces;
using CarStore_BL.Interfaces;


namespace BookStore_BL.Services
{
    public class BookService : ICarService
    {
        private readonly ICarRepository _bookRepository;

        public BookService(ICarRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void Add(Car book)
        {
            _bookRepository.Add(book);
        }

        public void Delete(int id)
        {
            _bookRepository.Delete(id);
        }

        public List<Car> GetAll()
        {
            return _bookRepository.GetAll();
        }

        public Car? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Car? GetById(int id)
        {
            return _carRepository.GetById(id);
        }

       
    }
}
