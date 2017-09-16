using System;
using Foundation;
using UIKit;

namespace VesselManagement
{
	public class manageListTableSource : UITableViewSource
	{
		ManageVC owner;
		string[] labelArray = { "Vendor", "Name", "Head Count" };
		string val;
		public manageListTableSource(ManageVC classInstance, string valueSelected)
		{
			owner = classInstance;
			val = valueSelected;
		}

		public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
		{
			return 74;
		}
		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			bool isButtonHidden = true;
			var cell = (ManageCell)tableView.DequeueReusableCell("ManageCell")
			                                ?? new ManageCell("ManageCell",owner);
			cell.Accessory = UITableViewCellAccessory.None;
			if (indexPath.Row == 0)
				isButtonHidden = false;
			cell.updateManageCellFields(val,labelArray[indexPath.Row],owner,isButtonHidden);
			cell.SelectionStyle = UITableViewCellSelectionStyle.None;
			return cell;
		}
		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return 3;
		}
		public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
		{
		 	tableView.DeselectRow (indexPath, true);
		}
	}
}
