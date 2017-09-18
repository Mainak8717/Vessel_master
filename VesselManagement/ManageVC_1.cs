using System;
using Foundation;
using UIKit;

namespace VesselManagement
{
	public partial class ManageVC_1 : BaseVC
	{
		string typeOfManagement;
		public ManageVC_1(string typeOfVC) : base("ManageVC_1")
		{
			HamburgerMenuRequired = false;
			BackButtonRequired = true;
			typeOfManagement = typeOfVC;
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			NSNotificationCenter.DefaultCenter.AddObserver((Foundation.NSString)"agencySelected", ChangeLeftSide);
			NSNotificationCenter.DefaultCenter.AddObserver((Foundation.NSString)"BoatAgent", ChangeLeftSide);
			tbleView.RegisterNibForCellReuse(BottomTableViewCell.Nib, "BottomTableViewCell");

			tbleView.TableFooterView = new UIView();
			if (typeOfManagement.Equals("Agency"))
			{
				type.Text = "Agent";
				tbleView.Source = new BottomTableViewSource("Agency");
			}
			else
			{
				type.Text = "Boat Agent";
				tbleView.Source = new BottomTableViewSource("BoatAgency");
			}
			searchButton.TouchUpInside += (sender, e) =>
			{
				this.NavigationController.PresentModalViewController(new SearchVC(typeOfManagement), true);
			};
		}

		public void ChangeLeftSide(NSNotification notification)
		{
			switch (notification.Name)
			{
				case "agencySelected":
					txtField.Text = notification.Object.ToString();
					break;
				case "BoatAgent":
					txtField.Text = notification.Object.ToString();
					break;
			}
		}
	}
}

