using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mocking_demo.lib
{
	public class EntityBase : IEntity<int>
	{
		public int Id { get; set; }
		public string Title { get; set; }
	}
}
