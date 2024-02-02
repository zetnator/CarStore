using CarStore_DL.Interfaces;
using CarStore_Models.Models;
using CarStore_BL.Interfaces;

namespace CarStore_BL.Services
{
    public class BuyerService : IBuyerService
    {
        private readonly IBuyerRepository _authorRepository;

        public BuyerService(IBuyerRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public void Add(Buyer author)
        {
            _authorRepository.Add(author);
        }

        public void Delete(int id)
        {
            _authorRepository.Delete(id);
        }

        public List<Buyer> GetAll()
        {
            return _authorRepository.GetAll();  
        }

        public Buyer? GetById(int id)
        {
            return _authorRepository.GetById(id);
        }
    }
}
