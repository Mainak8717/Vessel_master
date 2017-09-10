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
		UIKit.UITableView addedListTblView { get; set; }

		[Outlet]
		UIKit.UITableView manageListTbleView { get; set; }

		[Outlet]
		UIKit.NSLayoutConstraint tableViewHeightConstraint { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (tableViewHeightConstraint != null) {
				tableViewHeightConstraint.Dispose ();
				tableViewHeightConstraint = null;
			}

			if (manageListTbleView != null) {
				manageListTbleView.Dispose ();
				manageListTbleView = null;
			}

			if (addBtn != null) {
				addBtn.Dispose ();
				addBtn = null;
			}

			if (addedListTblView != null) {
				addedListTblView.Dispose ();
				addedListTblView = null;
			}
		}
	}
}
