using CarStore_DL.Interfaces;
using CarStore_Models.Models;
using CarStore_BL.Interfaces;

namespace CarStore_BL.Services
{
    public class BuyerService : IBuyerService
    {
        private readonly IBuyerRepository _buyerRepository;

        public BuyerService(IBuyerRepository buyerRepository)
        {
            _buyerRepository = buyerRepository;
        }

        public void Add(Buyer buyer)
        {
            _buyerRepository.Add(buyer);
        }

        public void Delete(int id)
        {
            _buyerRepository.Delete(id);
        }

        public List<Buyer> GetAll()
        {
            return _buyerRepository.GetAll();  
        }

        public Buyer? GetById(int id)
        {
            return _buyerRepository.GetById(id);
        }
    }
}
