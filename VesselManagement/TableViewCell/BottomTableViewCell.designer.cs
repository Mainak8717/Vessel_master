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
	[Register ("BottomTableViewCell")]
	partial class BottomTableViewCell
	{
		[Outlet]
		UIKit.UILabel headerLbl { get; set; }

		[Outlet]
		UIKit.UILabel subTitleLbl { get; set; }

		[Outlet]
		UIKit.UILabel subTitleLbl_2 { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (headerLbl != null) {
				headerLbl.Dispose ();
				headerLbl = null;
			}

			if (subTitleLbl != null) {
				subTitleLbl.Dispose ();
				subTitleLbl = null;
			}

			if (subTitleLbl_2 != null) {
				subTitleLbl_2.Dispose ();
				subTitleLbl_2 = null;
			}
		}
	}
}
