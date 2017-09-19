using System;
using System.Collections.Generic;
using CoreGraphics;
using UIKit;

namespace VesselManagement
{
	public partial class HomeViewController : BaseVC
	{
		UIPickerView pickerView;
		public HomeViewController(bool backButtonReq, bool hamburgerMenu) : base("HomeViewController")
		{
			HamburgerMenuRequired = hamburgerMenu;
			BackButtonRequired = backButtonReq;
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			this.NavigationController.NavigationBar.Hidden = false;
			tblView.RegisterNibForCellReuse(TripCell.Nib, "TripCell");

			tblView.Layer.BorderColor = new CoreGraphics.CGColor (22f, 175f, 202f);
			tblView.TableFooterView = new UIView();
			tblView.Source = new TripsTableSource(this,getTrips());
		}
		public List<TripModel> getTrips()
		{
			List<TripModel>tripModel = new List<TripModel>();
			tripModel.Add(new TripModel("1082017/1", "Hudson Bay", "Sundarland", "Active"));
			tripModel.Add(new TripModel("1182017/2", "Shanghai", "Coalcliff Harbour", "Active"));
			tripModel.Add(new TripModel("1282017/3", "Sundarland", "Shanghai", "Active"));
			tripModel.Add(new TripModel("1382017/4", "Coalcliff Harbour", "Sundarland", "Active"));
			tripModel.Add(new TripModel("1482017/5", "Batemans Bay", "Hudson Bay", "Active"));

			return tripModel;
		}
	}
}

