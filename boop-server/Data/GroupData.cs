using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace boopserver
{
	public class GroupData
	{
		[DataMember]
		public string Id;

		[DataMember]
		public List<string> Members;

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="boopserver.GroupData"/> class.
		/// </summary>
		public GroupData() {
			Members = new List<string> ();
		}
		#endregion
	}
}

