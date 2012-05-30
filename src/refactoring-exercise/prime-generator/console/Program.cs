using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using core;

namespace console
{
	class Program
	{
		static void Main(string[] args)
		{
			var result = GeneratePrimes.GeneratePrimeNumbers(10000);

			foreach(var prime in result)
				Console.WriteLine(prime);

			Console.ReadLine();
		}
	}
}
