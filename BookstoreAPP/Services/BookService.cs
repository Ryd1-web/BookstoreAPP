using BookstoreAPP.Models;
using BookstoreAPP.Repository;

namespace BookstoreAPP.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public List<Book> GetBooks()
        {

            return _bookRepository.GetAllBooks();
        }

        public Book GetBookById(int bookId)
        {

            return _bookRepository.GetBookById(bookId);
        }
    }

}
