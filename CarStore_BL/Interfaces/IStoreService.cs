using CarStore_Models.Responses;
using CarStore_Models.Requests;

namespace CarStore_BL.Interfaces
{
    public interface IStoreService
    {
        GetCarsByBuyerIdResponse?
            GetByAuthor(GetCarsByBuyerIdRequest request);
    }
}
