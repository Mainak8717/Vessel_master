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
	[Register ("ManageCell")]
	partial class ManageCell
	{
		[Outlet]
		UIKit.UILabel manageCellLabel { get; set; }

		[Outlet]
		UIKit.UIButton manageCellSearchButton { get; set; }

		[Outlet]
		UIKit.UITextField manageCellTextField { get; set; }

		[Action ("searchBtnAction:")]
		partial void searchBtnAction (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (manageCellLabel != null) {
				manageCellLabel.Dispose ();
				manageCellLabel = null;
			}

			if (manageCellSearchButton != null) {
				manageCellSearchButton.Dispose ();
				manageCellSearchButton = null;
			}

			if (manageCellTextField != null) {
				manageCellTextField.Dispose ();
				manageCellTextField = null;
			}
		}
	}
}
