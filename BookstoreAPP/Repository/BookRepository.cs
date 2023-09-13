using BookstoreAPP.Models;
using ShoppingCartSystem.Models;

namespace BookstoreAPP.Repository
{
	public class BookRepository : IBookRepository
	{
		private List<Book> _books;
		private readonly ApplicationDbContext _context;

		public BookRepository()
		{
			_books = new List<Book>
		{
			new Book { Id = 1, Title = "Book 1", Author = "Author 1", Price = 20.99, Stock = 10 },
			new Book { Id = 2, Title = "Book 2", Author = "Author 2", Price = 15.99, Stock = 5 },
			new Book { Id = 3, Title = "Book 3", Author = "Author 3", Price = 12.49, Stock = 15 },
		};
		}

		public List<Book> GetAllBooks()
		{
			return _books;
		}

		public Book GetBookById(int id)
		{
			return _books.FirstOrDefault(book => book.Id == id);
		}
	}

}
