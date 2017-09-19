using System;
namespace VesselManagement
{
	public class TripDetails
	{
		public string TRIPID { get; set; }
		public string IMO { get; set; }
		public string MMSI { get; set; }
		public string Master { get; set; }
		public string StartDate { get; set; }
		public string EndDate { get; set; }
		public string ETACalculated { get; set; }
		public string CurrentStatus { get; set; }
		public string VesselType { get; set; }
		public string NT { get; set; }
		public string GT { get; set; }
		public string LOA { get; set; }
		public string LBP { get; set; }
		public string Breadth { get; set; }
		public string FwdDraft { get; set; }
		public string AftDraft { get; set; }
		public string MaxSummerDraft { get; set; }

		public TripDetails(string tripID,string imo, string mmsi, string master, string startDate,
						   string endDate, string eta, string currentStatus, string vesselType, string nt, string gt, string loa,
						   string lbp, string breadth, string fwdDraft, string aftDraft, string maxSummerDraft)
		{
			TRIPID = tripID;
			IMO = imo;
			MMSI = mmsi;
			Master = master;
			StartDate = startDate;
			EndDate = endDate;
			ETACalculated = eta;
			CurrentStatus = currentStatus;
			VesselType = vesselType;
			NT = nt;
			GT = gt;
			LOA = loa;
			LBP = lbp;
			Breadth = breadth;
			FwdDraft = fwdDraft;
			AftDraft = aftDraft;
			MaxSummerDraft = maxSummerDraft;
		}
	}
}
