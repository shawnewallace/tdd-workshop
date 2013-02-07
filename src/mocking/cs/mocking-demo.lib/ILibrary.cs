namespace mocking_demo.lib
{
	public interface ILibrary
	{
		bool Inlibrary(string isbn);
		bool Available(string isbn);
	}
}