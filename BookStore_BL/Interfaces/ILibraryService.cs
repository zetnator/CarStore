using CarStore_Models.Responses;
using CarStore_Models.Requests;

namespace BookStore_BL.Interfaces
{
    public interface ILibraryService
    {
        GetBooksByAuthorResponse?
            GetBooksByAuthor(GetBooksByAuthorRequest request);
    }
}
