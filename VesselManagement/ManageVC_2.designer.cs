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
	[Register ("ManageVC_2")]
	partial class ManageVC_2
	{
		[Outlet]
		UIKit.UIButton addButton { get; set; }

		[Outlet]
		UIKit.UILabel lbl_1 { get; set; }

		[Outlet]
		UIKit.UILabel lbl_2 { get; set; }

		[Outlet]
		UIKit.UIButton searchButton_1 { get; set; }

		[Outlet]
		UIKit.UIButton searchButton_2 { get; set; }

		[Outlet]
		UIKit.UITableView tblView { get; set; }

		[Outlet]
		UIKit.UITextField tctField_2 { get; set; }

		[Outlet]
		UIKit.UILabel tripDetailsLbl { get; set; }

		[Outlet]
		UIKit.UITextField txtField_1 { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (tripDetailsLbl != null) {
				tripDetailsLbl.Dispose ();
				tripDetailsLbl = null;
			}

			if (lbl_1 != null) {
				lbl_1.Dispose ();
				lbl_1 = null;
			}

			if (txtField_1 != null) {
				txtField_1.Dispose ();
				txtField_1 = null;
			}

			if (searchButton_1 != null) {
				searchButton_1.Dispose ();
				searchButton_1 = null;
			}

			if (lbl_2 != null) {
				lbl_2.Dispose ();
				lbl_2 = null;
			}

			if (tctField_2 != null) {
				tctField_2.Dispose ();
				tctField_2 = null;
			}

			if (searchButton_2 != null) {
				searchButton_2.Dispose ();
				searchButton_2 = null;
			}

			if (addButton != null) {
				addButton.Dispose ();
				addButton = null;
			}

			if (tblView != null) {
				tblView.Dispose ();
				tblView = null;
			}
		}
	}
}
