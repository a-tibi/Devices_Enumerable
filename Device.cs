using System;

namespace Devices_Enumerable
{
	/// <summary>
	/// Class of Device
	/// </summary>
	/// <lis type="bullet">
	/// <term>
	/// PhysicalAddress
	/// </term>
	/// <Description>
	/// MAC Address consests of 48 bits (6 pairs of hexa decimal)
	/// </Description>
	/// <term>
	/// LogicalAddress
	/// </term>
	/// <Description>
	/// IP Address consests of 32 bits (4 octats of decimal)
	/// </Description>
	/// <term>
	/// Function
	/// </term>
	/// <Description>
	/// Device functions which gets valuse from Enum ()
	/// </Description>
	/// </lis>
	class Device : IComparable
	{
		/// <value>value of physical address: MAC address</value>
		public string PhysicalAddress { get; set; }
		public string LogicalAddress { get; set; }
		public DeviceFunctions Function { get; set; }

		public override bool Equals(object obj)
		{
			if ((obj is null) || (!(obj is Device)))
				return false;
			var device = obj as Device;

			return this.PhysicalAddress == device.PhysicalAddress &&
					this.LogicalAddress == device.LogicalAddress &&
					this.Function == device.Function;
		}

		public override int GetHashCode()
		{
			var hash = 13;
			hash = (hash * 7) + this.PhysicalAddress.GetHashCode();
			hash = (hash * 7) + this.LogicalAddress.GetHashCode();
			hash = (hash * 7) + this.Function.GetHashCode();

			return hash;
		}

		public static bool operator ==(Device ldevcie, Device rdevcie) => ldevcie.Equals(rdevcie);
		public static bool operator !=(Device ldevcie, Device rdevcie) => ldevcie.Equals(rdevcie);

		public override string ToString()
		{
			return $"Physical Address: {this.PhysicalAddress} | Logical Address: { this.LogicalAddress} | Function: { this.Function}";
		}

		/// <summary>
		/// Comparing method based on PhysicalAddress
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public int CompareTo(object obj)
		{
			if (obj is null)
				return 0;
			Device device = obj as Device;
			if (device is null)
				throw new ArgumentException("the object is not device!");
			return this.PhysicalAddress.CompareTo(device.PhysicalAddress);
		}
	}
}