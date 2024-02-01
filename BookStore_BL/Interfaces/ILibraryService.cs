using BookStore_Models.Responses;
using BookStore_Models.Requests;

namespace BookStore_BL.Interfaces
{
    public interface ILibraryService
    {
        GetBooksByAuthorResponse?
            GetBooksByAuthor(GetBooksByAuthorRequest request);
    }
}
