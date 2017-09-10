using System;
using Foundation;
using UIKit;

namespace VesselManagement
{
	public partial class StartTripVC : BaseVC
	{
		public StartTripVC(bool hamburgerReq, bool backButtonReq) : base("StartTripVC")
		{
			HamburgerMenuRequired = true;
			backButtonReq = false;
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			NSNotificationCenter.DefaultCenter.AddObserver ((Foundation.NSString)"sourceValueSelected", ChangeLeftSide);
			NSNotificationCenter.DefaultCenter.AddObserver ((Foundation.NSString)"destinationValueSelected", ChangeLeftSide);
			NSNotificationCenter.DefaultCenter.AddObserver ((Foundation.NSString)"shipValueSelected", ChangeLeftSide);

			shipSearchBtn.TouchUpInside += (sender, e) => { 
                displaySearch("ship");
			};
			detsinationSearchBtn.TouchUpInside += (sender, e) => { 
                displaySearch("destination");
			};
			sourceSearchButton.TouchUpInside += (sender, e) => {
				displaySearch("source");
			};
			startDateBtn.TouchUpInside += (sender, e) => {
                //displaySearch("source");
			};
		}
		public void ChangeLeftSide(NSNotification notification)
		{
			switch (notification.Name)
			{
				case "sourceValueSelected":
					sourceTextFld.Text = notification.Object.ToString();
					break;
				case "destinationValueSelected":
					destinationTxtFld.Text = notification.Object.ToString();
					break;
				case "shipValueSelected":
					shipTxtField.Text = notification.Object.ToString();
					break;
			}
		}
		private void displaySearch(string type)
		{
			this.NavigationController.PresentModalViewController(new SearchVC(type), true);
			
		}
	}
}

