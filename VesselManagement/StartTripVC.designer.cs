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
	[Register ("StartTripVC")]
	partial class StartTripVC
	{
		[Outlet]
		UIKit.UITextField destinationTxtFld { get; set; }

		[Outlet]
		UIKit.UIButton detsinationSearchBtn { get; set; }

		[Outlet]
		UIKit.UIButton shipSearchBtn { get; set; }

		[Outlet]
		UIKit.UITextField shipTxtField { get; set; }

		[Outlet]
		UIKit.UIButton sourceSearchButton { get; set; }

		[Outlet]
		UIKit.UITextField sourceTextFld { get; set; }

		[Outlet]
		UIKit.UIButton startDateBtn { get; set; }

		[Outlet]
		UIKit.UITextField startDateTxtField { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (sourceSearchButton != null) {
				sourceSearchButton.Dispose ();
				sourceSearchButton = null;
			}

			if (sourceTextFld != null) {
				sourceTextFld.Dispose ();
				sourceTextFld = null;
			}

			if (destinationTxtFld != null) {
				destinationTxtFld.Dispose ();
				destinationTxtFld = null;
			}

			if (shipTxtField != null) {
				shipTxtField.Dispose ();
				shipTxtField = null;
			}

			if (startDateTxtField != null) {
				startDateTxtField.Dispose ();
				startDateTxtField = null;
			}

			if (detsinationSearchBtn != null) {
				detsinationSearchBtn.Dispose ();
				detsinationSearchBtn = null;
			}

			if (shipSearchBtn != null) {
				shipSearchBtn.Dispose ();
				shipSearchBtn = null;
			}

			if (startDateBtn != null) {
				startDateBtn.Dispose ();
				startDateBtn = null;
			}
		}
	}
}
