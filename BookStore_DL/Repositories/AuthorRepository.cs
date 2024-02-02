using CarStore_DL.Interfaces;
using CarStore_DL.MemoryDB;
using CarStore_Models.Models;

namespace CarStore_DL.Repositories
{
    public class AuthorRepository : IBuyerRepository
    {
        public void Add(Buyer buyer)
        {
            InMemoryDB.BuyerData.Add(buyer);
        }

        public void Delete(int id)
        {
            var buyer = GetById(id);
            if (buyer != null)
            {
                InMemoryDB.BuyerData.Remove(buyer);
            }
            
        }

        public List<Buyer> GetAll()
        {
            return InMemoryDB.BuyerData;
        }

        public Buyer? GetById(int id)
        {
            return InMemoryDB.BuyerData.FirstOrDefault(a => a.Id == id);
        }
    }
}
