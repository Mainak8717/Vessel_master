using System;
using Foundation;
using UIKit;

namespace VesselManagement
{
	public partial class ManageVC_2 : BaseVC
	{
		public ManageVC_2() : base("ManageVC_2")
		{
			HamburgerMenuRequired = false;
			BackButtonRequired = true;
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			NSNotificationCenter.DefaultCenter.AddObserver((Foundation.NSString)"serviceList", ChangeLeftSide);
			NSNotificationCenter.DefaultCenter.AddObserver((Foundation.NSString)"vendorsList", ChangeLeftSide);
			searchButton_1.TouchUpInside += (sender, e) => { 
               this.NavigationController.PresentModalViewController(new SearchVC("serviceList"), true);

			};
			searchButton_2.TouchUpInside += (sender, e) => { 
               this.NavigationController.PresentModalViewController(new SearchVC("vendorsList"), true);

			};
		}

		public void ChangeLeftSide(NSNotification notification)
		{
			switch (notification.Name)
			{
				case "serviceList":
					txtField_1.Text = notification.Object.ToString();
					break;
				case "vendorsLsit":
					tctField_2.Text = notification.Object.ToString();
					break;
			}
		}
	}
}

