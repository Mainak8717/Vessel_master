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
			secondButton.Hidden = false;
			thirdButton.Hidden = false;
			fourthButton.Hidden = false;

			firstButton.TouchUpInside += (sender, e) => { 
                this.NavigationController.PushViewController(new ManageVC_1("Agency"),true);
			};
			thirdButton.TouchUpInside += (sender, e) => { 
				this.NavigationController.PushViewController(new ManageVC_1("BoatAgent"),true);
			};
			secondButton.TouchUpInside += (sender, e) => { 
				this.NavigationController.PushViewController(new ManageVC_2(),true);
			};
		}
		public override void ViewDidLayoutSubviews()
		{
			scrollView.ContentSize = new CoreGraphics.CGSize(View.Frame.Width, firstButton.Frame.Y + firstButton.Frame.Size.Height + 200);

		}
		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

