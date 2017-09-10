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
	[Register ("HomeViewController")]
	partial class HomeViewController
	{
		[Outlet]
		UIKit.UISegmentedControl segmentControl { get; set; }

		[Outlet]
		UIKit.UITableView tblView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (segmentControl != null) {
				segmentControl.Dispose ();
				segmentControl = null;
			}

			if (tblView != null) {
				tblView.Dispose ();
				tblView = null;
			}
		}
	}
}
