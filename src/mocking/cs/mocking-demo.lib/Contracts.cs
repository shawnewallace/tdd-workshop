using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mocking_demo.lib
{
	public interface IIdentifiable<TKey>
	{
		TKey Id { get; set; }
	}

	public interface ITitled
	{
		string Title { get; set; }
	}

	public interface IEntity<TKey> : IIdentifiable<TKey>, ITitled
	{
	}

	public interface IRepository<T, TKey> where T : IEntity<TKey>
	{
		List<T> All();
		T GetById(TKey id);
		T Add(T entity);
		void Delete(T entity);
		void Update(T entity);
	}
}
