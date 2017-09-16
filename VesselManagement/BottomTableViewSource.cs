using System;
using Foundation;
using UIKit;

namespace VesselManagement
{
	public class BottomTableViewSource : UITableViewSource
	{
		string valueToBeDisplayed;
		public BottomTableViewSource(string searchValue)
		{
			valueToBeDisplayed = searchValue;
		}
		public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
		{
			return 80;
		}
		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			var cell = (BottomTableViewCell)tableView.DequeueReusableCell("BottomTableViewCell")
								?? new BottomTableViewCell("BottomTableViewCell");
			cell.Accessory = UITableViewCellAccessory.None;
			cell.SelectionStyle = UITableViewCellSelectionStyle.None;

						return cell;
		}

		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return 2;
		}
		public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
		{
		}
	}
}
