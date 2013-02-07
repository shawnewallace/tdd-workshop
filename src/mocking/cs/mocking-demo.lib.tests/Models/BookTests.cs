using NUnit.Framework;

namespace mocking_demo.lib.tests.Models
{
	[TestFixture]
	public class BookTests
	{
		private Book _book;

		[SetUp]
		public void SetUp() { _book = new Book(); }

		[Test]
		public void has_correct_attributes()
		{
			_book.Title.Should(Be.EquivalentTo(null));
			_book.Author.Should(Be.EquivalentTo(null));
			_book.ISBN.Should(Be.EquivalentTo(null));
		}
	}
}