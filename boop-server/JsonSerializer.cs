using System;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Text;

namespace boopserver
{
	public static class JsonSerializer
	{
		#region Methods
		/// <summary>
		/// Deserialize the Json string.
		/// </summary>
		/// <param name="json">Json.</param>
		public static object Deserialize<T>(string json) {
			// serializer
			DataContractJsonSerializer serializer = new DataContractJsonSerializer (typeof(T));

			// read
			using (MemoryStream ms = new MemoryStream (Encoding.UTF8.GetBytes(json))) {
				return (T)serializer.ReadObject (ms);
			}
		}

		/// <summary>
		/// Serialize the object to a Json string.
		/// </summary>
		/// <param name="obj">Object.</param>
		public static string Serialize(Object obj) {
			// serializer
			DataContractJsonSerializer serializer = new DataContractJsonSerializer (obj.GetType ());

			// write
			using (MemoryStream ms = new MemoryStream ()) {
				// serialize
				serializer.WriteObject (ms, obj);

				return Encoding.UTF8.GetString(ms.ToArray ());
			}
		}
		#endregion
	}
}

