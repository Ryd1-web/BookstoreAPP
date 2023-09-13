using BookstoreAPP.Models;
using Microsoft.AspNetCore.Mvc;
using ShoppingCartSystem.Models;

namespace BookstoreAPP.Controllers
{
    using BookstoreAPP.Services;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;

    namespace Bookstore.Controllers
    {
        [Route("api/books")]
		[ApiController]
		public class BooksController : ControllerBase
		{
			private readonly IBookService _bookService;

			public BooksController(IBookService bookService)
			{
				_bookService = bookService;
			}

			[HttpGet]
			public IActionResult GetBooks()
			{
				var books = _bookService.GetBooks();
				return Ok(books);
			}

			[HttpGet("{id}")]
			public IActionResult GetBookById(int id)
			{
				var book = _bookService.GetBookById(id);

				if (book == null)
				{
					return NotFound(); // Return a 404 Not Found if the book is not found.
				}

				return Ok(book);
			}
		}
	}



}
