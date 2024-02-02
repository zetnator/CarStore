using CarStore_Models.Responses;
using CarStore_Models.Requests;

namespace BookStore_BL.Interfaces
{
    public interface IStoreService
    {
        GetBooksByAuthorResponse?
            GetBooksByAuthor(GetBooksByAuthorRequest request);
    }
}
