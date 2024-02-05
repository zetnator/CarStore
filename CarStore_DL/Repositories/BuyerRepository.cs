using CarStore_DL.Interfaces;
using CarStore_DL.MemoryDB;
using CarStore_Models.Models;

namespace CarStore_DL.Repositories
{
    public class BuyerRepository : IBuyerRepository
    {
        public void AddBuyer(Buyer buyer)
        {
            InMemoryDB.BuyerData.Add(buyer);
        }

        public void DeleteBuyer(int id)
        {
            var buyer = GetBuyerById(id);
            if (buyer != null)
            {
                InMemoryDB.BuyerData.Remove(buyer);
            }
            
        }

        public List<Buyer> GetAllBuyers()
        {
            return InMemoryDB.BuyerData;
        }

        public Buyer? GetBuyerById(int id)
        {
            return InMemoryDB.BuyerData.FirstOrDefault(a => a.Id == id);
        }
    }
}
