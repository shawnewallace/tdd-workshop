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
			Assert.IsNull(_book.Title);
			Assert.IsNull(_book.Author);
			Assert.IsNull(_book.ISBN);
		}
	}
}