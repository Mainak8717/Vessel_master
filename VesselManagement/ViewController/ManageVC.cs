using System;
using Foundation;
using UIKit;

namespace VesselManagement
{
	public partial class ManageVC : BaseVC
	{
		public ManageVC() : base("ManageVC")
		{
			BackButtonRequired = true;
			HamburgerMenuRequired = false;
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			bottomTableView.RegisterNibForCellReuse(BottomTableViewCell.Nib, "BottomTableViewCell");
			bottomTableView.Source = new BottomTableViewSource(string.Empty);
			NSNotificationCenter.DefaultCenter.AddObserver ((Foundation.NSString)"boatVendorSelected", ChangeLeftSide);

			addVendorButton.TouchUpInside += (sender, e) => {

				this.NavigationController.PresentModalViewController(new SearchVC("boatVendorSelected"), true);
			};
		}
		public void ChangeLeftSide(NSNotification notification)
		{
			switch (notification.Name)
			{
				case "boatVendorSelected":
					vendorTxtField.Text = notification.Object.ToString();
					break;
			}
		}
	}
}

