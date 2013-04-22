using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moq;
using NUnit.Framework;

namespace mocking_demo.lib.tests.ServiceTests.BookServiceTests
{
	[TestFixture]
	public class AddTests
	{
		private BookService _service;
		private Book _newBook;
		private Mock<IRepository<Book, int>> _mock;

		[SetUp]
		public void SetUp()
		{
			_newBook = new Book {
				Title = "New Book",
				Author = "New Book's Author", 
				ISBN = "ABC-123"
			};
			
			_mock = new Mock<IRepository<Book, int>>();
		}

		[Test]
		public void when_succesful_object_returned()
		{
			_mock.Setup(m => m.Add(_newBook)).Returns(_newBook);
			_service = new BookService(_mock.Object);

			var result = _service.Add(_newBook);
			Assert.AreEqual(_newBook.Title, result.Title);
			Assert.AreEqual(_newBook.Author, result.Author);
			Assert.AreEqual(_newBook.ISBN, result.ISBN);
		}

		[Test]
		public void returns_null_if_exception()
		{
			_mock.Setup(m => m.Add(It.IsAny<Book>())).Throws<Exception>();
			_service = new BookService(_mock.Object);

			Assert.IsNull(_service.Add(_newBook));
		}
	}
}
