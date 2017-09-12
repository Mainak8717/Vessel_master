using System;

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
			manageListTbleView.RegisterNibForCellReuse(ManageCell.Nib, "ManageCell");
			UIView headerView = new UIView(new CoreGraphics.CGRect(0, 0, manageListTbleView.Frame.Size.Width, 40));
			UILabel remainingCapacityLbl = new UILabel(new CoreGraphics.CGRect(10, 5, manageListTbleView.Frame.Size.Width-10, 30));
			remainingCapacityLbl.Text = "Remaining Capacity: 0 out of 20";
			headerView.AddSubview(remainingCapacityLbl);
			manageListTbleView.TableHeaderView = headerView;
			manageListTbleView.Source = new manageListTableSource();
		}
		public override void ViewDidLayoutSubviews()
		{
			manageListTbleView.SizeToFit();
			bottomView.Frame = new CoreGraphics.CGRect(5, manageListTbleView.Frame.Y + manageListTbleView.Frame.Size.Height, UIScreen.MainScreen.Bounds.Width - 10, 499);
			//bottomTableView.Frame = new CoreGraphics.CGRect(5, bottomView.Frame.Y + 40, bottomView.Frame.Size.Width, 499);

			//bottomTableView.SizeToFit();
		}
	}
}

