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
	[Register ("ManageVC")]
	partial class ManageVC
	{
		[Outlet]
		UIKit.UIButton addBtn { get; set; }

		[Outlet]
		UIKit.UIButton addVendorButton { get; set; }

		[Outlet]
		UIKit.UITableView bottomTableView { get; set; }

		[Outlet]
		UIKit.UITextField headCountTxtField { get; set; }

		[Outlet]
		UIKit.UITextField nameTxtField { get; set; }

		[Outlet]
		UIKit.UILabel tripDetailsLbl { get; set; }

		[Outlet]
		UIKit.UITextField vendorTxtField { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (addBtn != null) {
				addBtn.Dispose ();
				addBtn = null;
			}

			if (bottomTableView != null) {
				bottomTableView.Dispose ();
				bottomTableView = null;
			}

			if (tripDetailsLbl != null) {
				tripDetailsLbl.Dispose ();
				tripDetailsLbl = null;
			}

			if (vendorTxtField != null) {
				vendorTxtField.Dispose ();
				vendorTxtField = null;
			}

			if (nameTxtField != null) {
				nameTxtField.Dispose ();
				nameTxtField = null;
			}

			if (headCountTxtField != null) {
				headCountTxtField.Dispose ();
				headCountTxtField = null;
			}

			if (addVendorButton != null) {
				addVendorButton.Dispose ();
				addVendorButton = null;
			}
		}
	}
}
