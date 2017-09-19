using System;
namespace VesselManagement
{
	public class TripModel
	{
		public string TripId { get; set; }
		public string Source { get; set; }
		public string Destination { get; set; }
		public string Status { get; set; }

		public TripModel() { }

		public TripModel(string tripId, string source, string destination, string status)
		{ 
			TripId = tripId;
			Source = source;
			Destination = destination;
			Status = status;
		}

	}
}
