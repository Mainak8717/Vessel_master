using System;
using Foundation;
using UIKit;

namespace VesselManagement
{
	public class TripsTableSource : UITableViewSource
	{
		public HomeViewController owner;
		public TripsTableSource(HomeViewController classInstance)
		{
			owner = classInstance;
		}
		public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
		{
			return 120;
		}
		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			var cell = (TripCell)tableView.DequeueReusableCell("TripCell")
									   ?? new TripCell("TripCell");
			cell.Accessory = UITableViewCellAccessory.DisclosureIndicator;
			return cell;
		}
		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return 10;
		}
		public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
		{
			owner.NavigationController.PushViewController(new TripDetailsVC(),true);
			 tableView.DeselectRow (indexPath, true);

		}
	}
}
