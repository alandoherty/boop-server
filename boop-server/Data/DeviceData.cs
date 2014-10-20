using System;
using System.Runtime.Serialization;

namespace boopserver
{
	public class DeviceData
	{
		[DataMember]
		public string Name;

		[DataMember]
		public BoopDeviceType Type;

		[DataMember]
		public string Id;

		public string IdSecret;
	}
}

