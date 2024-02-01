using BookStore_Models.Models;
using BookStore_BL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookstoreApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet(template: "GetBookById")]
        public Book GetBookById(int id)
        {
            return _bookService.GetBooksById(id);
        }

        [HttpGet(template: "GetAllBooks")]
        public List<Book> GetAllBooks()
        {
            return _bookService.GetAll();
        }

        [HttpPost]
        public void Add(Book book)
        {
            _bookService.Add(book);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _bookService.Delete(id);
        }
    }
}
