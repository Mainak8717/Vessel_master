using System;
using Foundation;
using UIKit;

namespace VesselManagement
{
	public class manageListTableSource : UITableViewSource
	{
		public manageListTableSource()
		{
		}

		public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
		{
			return 74;
		}
		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			var cell = (ManageCell)tableView.DequeueReusableCell("ManageCell")
									   ?? new ManageCell("ManageCell");
			cell.Accessory = UITableViewCellAccessory.None;
			return cell;
		}
		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return 1;
		}
		public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
		{
			
		}
	}
}
