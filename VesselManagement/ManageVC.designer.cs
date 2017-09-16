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
		UIKit.UITableView bottomTableView { get; set; }

		[Outlet]
		UIKit.UIView bottomView { get; set; }

		[Outlet]
		UIKit.UITableView manageListTbleView { get; set; }
		
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

			if (bottomView != null) {
				bottomView.Dispose ();
				bottomView = null;
			}

			if (manageListTbleView != null) {
				manageListTbleView.Dispose ();
				manageListTbleView = null;
			}
		}
	}
}
