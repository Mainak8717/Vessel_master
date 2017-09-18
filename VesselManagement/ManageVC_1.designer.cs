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
	[Register ("ManageVC_1")]
	partial class ManageVC_1
	{
		[Outlet]
		UIKit.UIButton addButton { get; set; }

		[Outlet]
		UIKit.UIButton searchButton { get; set; }

		[Outlet]
		UIKit.UITableView tbleView { get; set; }

		[Outlet]
		UIKit.UILabel tripDetails { get; set; }

		[Outlet]
		UIKit.UITextField txtField { get; set; }

		[Outlet]
		UIKit.UILabel type { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (tripDetails != null) {
				tripDetails.Dispose ();
				tripDetails = null;
			}

			if (type != null) {
				type.Dispose ();
				type = null;
			}

			if (txtField != null) {
				txtField.Dispose ();
				txtField = null;
			}

			if (searchButton != null) {
				searchButton.Dispose ();
				searchButton = null;
			}

			if (addButton != null) {
				addButton.Dispose ();
				addButton = null;
			}

			if (tbleView != null) {
				tbleView.Dispose ();
				tbleView = null;
			}
		}
	}
}
