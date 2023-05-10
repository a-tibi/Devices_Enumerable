using System;
using System.Collections.Generic;

namespace Devices_Enumerable
{
	class Program
	{
		static void Main(string[] args)
		{
			Devices devices = new Devices();

			int counter = 1;
			foreach (var device in devices)
			{
				Console.WriteLine($"Device {counter++}:");				
				Console.WriteLine(device);
				Console.WriteLine("--------------------------------------------------------------------------------------");
			}

			devices.SortIt();
			Console.WriteLine("After Sorting:");
			counter = 1;
			foreach (var device in devices)
			{
				Console.WriteLine($"Device {counter++}:");
				Console.WriteLine(device);
				Console.WriteLine("--------------------------------------------------------------------------------------");
			}

			Console.ReadKey();
		}
	}
}
