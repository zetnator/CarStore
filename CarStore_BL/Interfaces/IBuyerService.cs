using CarStore_Models.Models;

namespace CarStore_BL.Interfaces
{
    public interface IBuyerService
    {
        List<Buyer> GetAllBuyers();

        Buyer? GetBuyerById(int id);

        void AddBuyer(Buyer buyer);

        void DeleteBuyer(int id);
    }
}
