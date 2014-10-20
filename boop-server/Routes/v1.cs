using System;
using voyagerlib;
using voyagerlib.http;
using System.Runtime.Serialization.Json;

namespace boopserver
{
	public static class v1
	{
		#region Methods
		/// <summary>
		/// Create a device.
		/// </summary>
		/// <param name="req">Request.</param>
		/// <param name="res">Response.</param>
		public static void CreateDevice(Request req, Response res) {
			// create
			DeviceData device = Boop.CreateDevice ();

			// write response and status code
			res.StatusCode = HttpStatusCode.Created;
			res.Write (JsonSerializer.Serialize (device));
			res.Send ();
		}
			
		/// <summary>
		/// Create a group.
		/// </summary>
		/// <param name="req">Request.</param>
		/// <param name="res">Response.</param>
		[Route(HttpMethod.GET, "/v1/groups/create")]
		public static void CreateGroup(Request req, Response res) {
			// create
			GroupData group = Boop.CreateGroup ();

			// write response and status code
			res.StatusCode = HttpStatusCode.Created;
			res.Write (JsonSerializer.Serialize (group));
			res.Send ();
		}

		/// <summary>
		/// Join a group.
		/// </summary>
		/// <param name="req">Request.</param>
		/// <param name="res">Response.</param>
		public static void JoinGroup(Request req, Response res) {
			// create
			GroupData group = Boop.JoinGroup (string idSecret);
		}

		/// <summary>
		/// Get a group.
		/// </summary>
		/// <param name="req">Request.</param>
		/// <param name="res">Response.</param>
		[Route(HttpMethod.GET, "/v1/groups/get")]
		public static void GetGroup(Request req, Response res) {
			// parameters
			string id = "";

			// id
			if (req.Parameters["id"] != null)
				id = req.Parameters ["id"];
			else {
				res.Send (HttpStatusCode.NotFound); 
				return;
			}

			// get
			if (Boop.Groups.ContainsKey (id)) {
				res.StatusCode = HttpStatusCode.Found;
				res.Write (JsonSerializer.Serialize (Boop.Groups [id]));
			} else {
				res.Send (HttpStatusCode.NotFound); 
				return;
			}

			res.Send ();
		}

		/// <summary>
		/// Defaut route.
		/// </summary>
		/// <param name="req">Request.</param>
		/// <param name="res">Response.</param>
		[Route(HttpMethod.GET, "/")]
		public static void Home(Request req, Response res) {
			res.Write ("<html><head><title>Boop Server API</title></head><body>");
			res.Write ("<h1>Boop</h1>");
			res.Write ("<p>This is the boop api, hello!</p>");
			res.Write ("</html>");
			res.StatusCode = HttpStatusCode.NotFound;
			res.Send ();
		}
		#endregion
	}
}

