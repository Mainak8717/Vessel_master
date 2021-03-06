﻿using System;
using Foundation;
using UIKit;

namespace VesselManagement
{
	public class BottomTableViewSource : UITableViewSource
	{
		string cellType;
		string[] labelValues;
		public BottomTableViewSource(string typeOfCell)
		{
			cellType = typeOfCell;
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
			if(cellType.Equals("Agency"))
				labelValues = new string[]{"Agency 1","Contact Info:N/A"};
			else if(cellType.Equals("BoatAgency"))
				labelValues = new string[]{"Boat Agency 1","Phone:N/A"};

			cell.updateCell(labelValues);
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
