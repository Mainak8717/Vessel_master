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
			UIView headerView = new UIView(new CoreGraphics.CGRect(0, 0, addedListTblView.Frame.Size.Width, 40));
			UILabel remainingCapacityLbl = new UILabel(new CoreGraphics.CGRect(10, 5, addedListTblView.Frame.Size.Width-10, 30));
			remainingCapacityLbl.Text = "Remaining Capacity: 0 out of 20";
			headerView.AddSubview(remainingCapacityLbl);

			manageListTbleView.TableHeaderView = headerView;
			manageListTbleView.SectionFooterHeight = 0;
			//manageListTbleView.TableFooterView = new UIView(new CoreGraphics.CGRect(0, 0, addedListTblView.Frame.Size.Width, 5));
			manageListTbleView.Source = new manageListTableSource();
		}
		public override void ViewDidLayoutSubviews()
		{
			//NSLayoutConstraint heightConstraint = new NSLayoutConstraint();
			//foreach (NSLayoutConstraint constraint in addedListTblView.Constraints) {
			//	if (constraint.FirstAttribute == NSLayoutAttribute.Height) {
			//        heightConstraint = constraint;
			//        break;
			//    }
			//}
						manageListTbleView.SectionFooterHeight = 0;

			//heightConstraint.Constant = 200;
			//tableViewHeightConstraint.Constant = 212f;

		}
		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

