using CarStore_Models.Models;

namespace CarStore_BL.Interfaces
{
    public interface IBuyerService
    {
        List<Buyer> GetAll();

        Buyer? GetById(int id);

        void Add(Buyer author);

        void Delete(int id);
    }
}
