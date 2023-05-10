using System.Collections;
using System.Collections.Generic;

namespace Devices_Enumerable
{
	/// <summary>
	/// Class: list of devices as Repository
	/// </summary>
	class Devices : IEnumerable 
	{
		//Device[] devices;
		///<value>List of Devices</value> 
		List<Device> devices;

		public Devices()
		{
			//devices = new[] {
			devices = new List<Device> {
				new Device { PhysicalAddress = "05-05-05-05-05-05", LogicalAddress = "10.0.0.5", Function = DeviceFunctions.AcessPoint },
				new Device { PhysicalAddress = "03-03-03-03-03-03", LogicalAddress = "10.0.0.3", Function = DeviceFunctions.FireWall },
				new Device { PhysicalAddress = "02-02-02-02-02-02", LogicalAddress = "10.0.0.2", Function = DeviceFunctions.L3Switch },
				new Device { PhysicalAddress = "01-01-01-01-01-01", LogicalAddress = "10.0.0.1", Function = DeviceFunctions.Router },
				new Device { PhysicalAddress = "04-04-04-04-04-04", LogicalAddress = "10.0.0.4", Function = DeviceFunctions.Switch }			
			}; 
		}

		public IEnumerator GetEnumerator()
		{
			foreach (var device in devices)
			{
				yield return device; 
			}
		}

		/// <summary>
		/// Sorting method based on Physical address
		/// </summary>
		public void SortIt()
		{
			devices.Sort();
		}
	}


}
