using CarStore_Models.Models;

namespace CarStore_DL.Interfaces
{
    public interface IBuyerRepository
    {
        List<Buyer> GetAllBuyers();

        Buyer? GetBuyerById(int id);

        void AddBuyer(Buyer buyer);

        void DeleteBuyer(int id);
    }
}
