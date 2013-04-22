using System.Diagnostics;

namespace Thermostat.Lib.First
{
	public class Furnace
	{
		public Furnace()
		{
			off();
		}

		public void on()
		{
			Debug.WriteLine("Furnace is ON");
		}

		public void off()
		{
			Debug.WriteLine("Furnace is OFF");
		}
	}

	public class Thermostat
	{
		private Furnace _furnace;

		public Thermostat(Furnace furnace)
		{
			_furnace = furnace;
		}

		public void run()
		{
			if (shouldBeOn())
			{
				_furnace.on();
			}
			else
			{
				_furnace.off();
			}
		}

		private bool shouldBeOn()
		{
			return true;
		}
	}
}
