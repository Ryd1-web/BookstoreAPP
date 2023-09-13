namespace BookstoreAPP.Services
{
	using BookstoreAPP.Repository;
	using System;
	using System.Collections.Generic;

	public interface IInventoryService
	{
		int GetStockCount(int bookId);
		//bool UpdateStock(int bookId, int quantityChange);
	}

	public class InventoryService : IInventoryService
	{
		private readonly IBookRepository _bookRepository; // Inject the book repository

		public InventoryService(IBookRepository bookRepository)
		{
			_bookRepository = bookRepository;
		}

		public int GetStockCount(int bookId)
		{
			var book = _bookRepository.GetBookById(bookId);
			return book != null ? book.Stock : 0;
		}
	}

}
