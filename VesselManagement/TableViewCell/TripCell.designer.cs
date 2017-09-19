// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace VesselManagement
{
	[Register ("TripCell")]
	partial class TripCell
	{
		[Outlet]
		UIKit.UILabel destination { get; set; }

		[Outlet]
		UIKit.UILabel source { get; set; }

		[Outlet]
		UIKit.UILabel status { get; set; }

		[Outlet]
		UIKit.UILabel tripID { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (tripID != null) {
				tripID.Dispose ();
				tripID = null;
			}

			if (source != null) {
				source.Dispose ();
				source = null;
			}

			if (destination != null) {
				destination.Dispose ();
				destination = null;
			}

			if (status != null) {
				status.Dispose ();
				status = null;
			}
		}
	}
}
