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

        public void AddBuyer(Buyer buyer)
        {
            _buyerRepository.AddBuyer(buyer);
        }

        public void DeleteBuyer(int id)
        {
            _buyerRepository.DeleteBuyer(id);
        }

        public List<Buyer> GetAllBuyers()
        {
            return _buyerRepository.GetAllBuyers();  
        }

        public Buyer? GetBuyerById(int id)
        {
            return _buyerRepository.GetBuyerById(id);
        }
    }
}
