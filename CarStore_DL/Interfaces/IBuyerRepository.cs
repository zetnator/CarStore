using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarStore_Models.Models;

namespace CarStore_DL.Interfaces
{
    public interface IBuyerRepository
    {
        List<Buyer> GetAll();

        Buyer? GetById(int id);

        void Add(Buyer buyer);

        void Delete(int id);
    }
}
