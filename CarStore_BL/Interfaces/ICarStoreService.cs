using CarStore_Models.Responses;
using CarStore_Models.Requests;

namespace CarStore_BL.Interfaces
{
    public interface ICarStoreService
    {
        GetCarsByBuyerIdResponse?
            GetByBuyer(GetCarsByBuyerIdRequest request);
        GetCarsByBuyerIdResponse? GetCarsByBuyerId(GetCarsByBuyerIdRequest request);
    }
}
