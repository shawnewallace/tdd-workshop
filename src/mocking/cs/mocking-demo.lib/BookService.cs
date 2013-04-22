using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mocking_demo.lib
{
	public class BookService
	{
		private IRepository<Book, int> _repository;

		public BookService(IRepository<Book, int> repository)
		{
			_repository = repository;
		}

		public Book Add(Book book)
		{
			try
			{
				return _repository.Add(book);
			}
			catch
			{
				return null;
			}
		}
	}
}
