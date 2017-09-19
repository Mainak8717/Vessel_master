using System;
using CoreGraphics;
using System.Collections.Generic;
using UIKit;


namespace VesselManagement
{
	public partial class SearchVC : BaseVC
	{
		UITableView table;
		SearchTableSource tableSource;
		List<TableItem> tableItems;
		UISearchBar searchBar;
		string searchType;
		public SearchVC(string type) : base("SearchVC")
		{
			HamburgerMenuRequired = false;
			BackButtonRequired = true;
			searchType = type;
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			searchBar = new UISearchBar();
			searchBar.SizeToFit();  
            searchBar.AutocorrectionType = UITextAutocorrectionType.No;  
            searchBar.AutocapitalizationType = UITextAutocapitalizationType.None;  
            searchBar.TextChanged += (sender, e) =>  
            {  
				searchTable();  
            };  
			table = new UITableView(new CGRect(0,60 , UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height - 20));  
            tableItems = new List<TableItem>();
			if (searchType.Equals("vendorsList"))
			{
				tableItems.Add(new TableItem("Vendor 1") { ImageName = "Vegetables.jpg" });
				tableItems.Add(new TableItem("Vendor 2") { ImageName = "Fruits.jpg" });
				tableItems.Add(new TableItem("Vendor 3") { ImageName = "Flower Buds.jpg" });
				tableItems.Add(new TableItem("Vendor 4") { ImageName = "Legumes.jpg" });
				tableItems.Add(new TableItem("Vendor 5") { ImageName = "Tubers.jpg" });
			}
			else if (searchType.Equals("Agency"))
			{
				tableItems.Add(new TableItem("Agency 1") { ImageName = "Vegetables.jpg" });
				tableItems.Add(new TableItem("Agency 2") { ImageName = "Fruits.jpg" });
				tableItems.Add(new TableItem("Agency 3") { ImageName = "Flower Buds.jpg" });
				tableItems.Add(new TableItem("Agency 4") { ImageName = "Legumes.jpg" });
				tableItems.Add(new TableItem("Agency 5") { ImageName = "Tubers.jpg" });
			}
			else if (searchType.Equals("serviceList"))
			{
				tableItems.Add(new TableItem("Service 1") { ImageName = "Vegetables.jpg" });
				tableItems.Add(new TableItem("Service 2") { ImageName = "Fruits.jpg" });
				tableItems.Add(new TableItem("Service 3") { ImageName = "Flower Buds.jpg" });
				tableItems.Add(new TableItem("Service 4") { ImageName = "Legumes.jpg" });
				tableItems.Add(new TableItem("Service 5") { ImageName = "Tubers.jpg" });
			}
			else if (searchType.Equals("BoatAgent"))
			{
				tableItems.Add(new TableItem("BoatAgency 1") { ImageName = "Vegetables.jpg" });
				tableItems.Add(new TableItem("BoatAgency 2") { ImageName = "Fruits.jpg" });
				tableItems.Add(new TableItem("BoatAgency 3") { ImageName = "Flower Buds.jpg" });
				tableItems.Add(new TableItem("BoatAgency 4") { ImageName = "Legumes.jpg" });
				tableItems.Add(new TableItem("BoatAgency 5") { ImageName = "Tubers.jpg" });
			}
			else
			{
				tableItems.Add(new TableItem("Hudson Bay") { ImageName = "Vegetables.jpg" });  
	            tableItems.Add(new TableItem("Shanghai") { ImageName = "Fruits.jpg" });  
	            tableItems.Add(new TableItem("Batemans Bay") { ImageName = "Flower Buds.jpg" });  
	            tableItems.Add(new TableItem("Coalcliff Harbour") { ImageName = "Legumes.jpg" });  
	            tableItems.Add(new TableItem("SunderLand") { ImageName = "Tubers.jpg" });
			}
		  
  
			tableSource = new SearchTableSource(tableItems,this,searchType);
			table.Source = tableSource;  
            table.TableHeaderView = searchBar;

			View.AddSubview(table);
			cancelBtn.TouchUpInside += (sender, e) => { 
				this.DismissModalViewController(true);
			};
		}
		private void searchTable()
		{
			tableSource.PerformSearch(searchBar.Text);
					table.ReloadData();
		} 
		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
		}
	}
}

