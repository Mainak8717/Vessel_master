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
	[Register ("TripDetailsVC")]
	partial class TripDetailsVC
	{
		[Outlet]
		UIKit.UIButton firstButton { get; set; }

		[Outlet]
		UIKit.UIButton fourthButton { get; set; }

		[Outlet]
		UIKit.UIScrollView scrollView { get; set; }

		[Outlet]
		UIKit.UIButton secondButton { get; set; }

		[Outlet]
		UIKit.UIButton thirdButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (scrollView != null) {
				scrollView.Dispose ();
				scrollView = null;
			}

			if (firstButton != null) {
				firstButton.Dispose ();
				firstButton = null;
			}

			if (secondButton != null) {
				secondButton.Dispose ();
				secondButton = null;
			}

			if (thirdButton != null) {
				thirdButton.Dispose ();
				thirdButton = null;
			}

			if (fourthButton != null) {
				fourthButton.Dispose ();
				fourthButton = null;
			}
		}
	}
}
