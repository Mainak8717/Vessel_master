using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Foundation;
using UIKit;

namespace VesselManagement
{
	public class SearchTableSource : UITableViewSource
	{
		private List<TableItem> tableItems = new List<TableItem>();
		private List<TableItem> searchItems = new List<TableItem>();
		protected string cellIdentifier = "TableCell";
		SearchVC owner;
		string searchType;
		public SearchTableSource(List<TableItem> items, SearchVC instanceOfClass,string type)
		{
			this.tableItems = items;
			this.searchItems = items;
			owner = instanceOfClass;
			searchType = type;
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier);


			var cellStyle = UITableViewCellStyle.Default;

			// if there are no cells to reuse, create a new one  
			if (cell == null)
			{
				cell = new UITableViewCell(cellStyle, cellIdentifier);
			}

			cell.TextLabel.Text = searchItems[indexPath.Row].Title;
			cell.ImageView.Image = UIImage.FromFile("Images/" + searchItems[indexPath.Row].ImageName);

			return cell;
		}

		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return searchItems.Count;
		}
		public override nint NumberOfSections(UITableView tableView)
		{
			return 1;
		}
		public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
		{
			var selectedVal = searchItems[indexPath.Row];
			switch (searchType)
			{
				case "source":
					NSNotificationCenter.DefaultCenter.PostNotificationName(
				"sourceValueSelected", (NSString)selectedVal.Title.ToString());
					break;
				case "destination":
					NSNotificationCenter.DefaultCenter.PostNotificationName(
				"destinationValueSelected", (NSString)selectedVal.Title.ToString());
					break;
				case "ship":
					NSNotificationCenter.DefaultCenter.PostNotificationName(
				"shipValueSelected", (NSString)selectedVal.Title.ToString());
					break;
				case "Vendors List":
					NSNotificationCenter.DefaultCenter.PostNotificationName(
				"vendorNameSelected", (NSString)selectedVal.Title.ToString());
					break;
			}

			tableView.DeselectRow (indexPath, true);
			//owner.NavigationController.PopViewController(true);
			owner.DismissModalViewController(true);

		}
		public void PerformSearch(string searchText)
		{
			searchText = searchText.ToLower();
			this.searchItems = tableItems.Where(x => x.Title.ToLower().Contains(searchText)).ToList();
		}
	}
}
