using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace VesselManagement
{
	public class TripsTableSource : UITableViewSource
	{
		public HomeViewController owner;
		public List<TripModel> modelList;
		public TripsTableSource(HomeViewController classInstance,List<TripModel> modelClass)
		{
			owner = classInstance;
			modelList = modelClass;
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
			cell.setCellValues(modelList[indexPath.Row]);
			return cell;
		}
		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return modelList.Count;
		}
		public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
		{
			owner.NavigationController.PushViewController(new TripDetailsVC(modelList[indexPath.Row]),true);
			 tableView.DeselectRow (indexPath, true);
		}
	}
}
