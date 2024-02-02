using CarStore_Models.Responses;
using CarStore_Models.Requests;
using BookStore_BL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookstoreApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private readonly ILibraryService _libraryService;
        public LibraryController(ILibraryService libraryService)
        {
            _libraryService = libraryService;
        }

        
        [HttpPost("GetAllBooksByAuthorId")]
        public GetBooksByAuthorResponse? GetAllBooksByAuthorId(GetBooksByAuthorRequest requst)
        {
            return _libraryService.GetBooksByAuthor(requst);
        }
    }
}
