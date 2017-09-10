using System;

using UIKit;

namespace VesselManagement
{
	public partial class CreateTripVC : BaseVC
	{
		public CreateTripVC(bool backButtonReq, bool hamburgerReq) : base("CreateTripVC")
		{
			HamburgerMenuRequired = hamburgerReq;
			BackButtonRequired = backButtonReq;
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			this.Title = "Trip Details";
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

