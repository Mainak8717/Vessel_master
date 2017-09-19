using System;
using CoreGraphics;
using UIKit;

namespace VesselManagement
{
	public partial class HomeViewController : BaseVC
	{
		UIPickerView pickerView;
		public HomeViewController(bool backButtonReq, bool hamburgerMenu) : base("HomeViewController")
		{
			HamburgerMenuRequired = hamburgerMenu;
			BackButtonRequired = backButtonReq;
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			this.NavigationController.NavigationBar.Hidden = false;
			tblView.RegisterNibForCellReuse(TripCell.Nib, "TripCell");
			tblView.Layer.BorderColor = new CoreGraphics.CGColor (22f, 175f, 202f);
			tblView.TableFooterView = new UIView();
			tblView.Source = new TripsTableSource(this);
		}
	}
}

