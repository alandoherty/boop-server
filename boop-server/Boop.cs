using System;
using System.Collections.Generic;

namespace boopserver
{
	public static class Boop
	{
		#region Fields
		private static Dictionary<string, GroupData> _groups;
		private static Dictionary<String, DeviceData> _devices;
		#endregion

		#region Properties
		/// <summary>
		/// Gets the groups.
		/// </summary>
		/// <value>The groups.</value>
		public static Dictionary<string, GroupData> Groups {
			get {
				return _groups;
			}
		}
		#endregion

		#region Methods
		/// <summary>
		/// Create's a group.
		/// </summary>
		/// <returns>The group.</returns>
		public static GroupData CreateGroup() {
			// create group data
			GroupData data = new GroupData ();
			data.Id = Guid.NewGuid ().ToString();

			// add
			_groups.Add (data.Id, data);

			return data;
		}

		/// <summary>
		/// Removes a group.
		/// </summary>
		/// <param name="id">Identifier.</param>
		public static void RemoveGroup(string id) {
			// remove
			_groups.Remove (id);
		}

		/// <summary>
		/// Create's a device.
		/// </summary>
		/// <returns>The device.</returns>
		public static DeviceData CreateDevice() {
			// create device data
			DeviceData data = new DeviceData ();
			data.Id = Guid.NewGuid ().ToString ();

			// add
			_devices.Add (data.Id, data);

			return data;
		}
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes the <see cref="boopserver.Boop"/> class.
		/// </summary>
		static Boop() {
			_groups = new Dictionary<string, GroupData> ();
			_devices = new Dictionary<string, DeviceData> ();
		}
		#endregion
	}
}

