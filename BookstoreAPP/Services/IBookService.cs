using BookstoreAPP.Models;

namespace BookstoreAPP.Services
{
    public interface IBookService
    {
        List<Book> GetBooks();
        Book GetBookById(int id);
    }

}
