using System;

using UIKit;

namespace VesselManagement
{
	public partial class TripDetailsVC : BaseVC
	{
		public TripDetailsVC() : base("TripDetailsVC")
		{
			HamburgerMenuRequired = false;
			BackButtonRequired = true;
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			firstButton.Hidden = false;
			secondButton.Hidden = true;
			thirdButton.Hidden = true;
			fourthButton.Hidden = true;
		}
		public override void ViewDidLayoutSubviews()
		{
			scrollView.ContentSize = new CoreGraphics.CGSize(View.Frame.Width, firstButton.Frame.Y + firstButton.Frame.Size.Height + 80);

		}
		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

