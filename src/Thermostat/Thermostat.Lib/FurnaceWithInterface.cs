using System.Diagnostics;

namespace Thermostat.Lib.Second
{
	public interface ISwitchableDevice
	{
		void on();
		void off();
	}

	public class Thermostat
	{
		private ISwitchableDevice _device;

		public Thermostat(ISwitchableDevice device)
		{
			_device = device;
		}

		public void run()
		{
			if (shouldBeOn())
			{
				_device.on();
			}
			else
			{
				_device.off();
			}
		}

		private bool shouldBeOn()
		{
			return true;
		}
	}

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
}