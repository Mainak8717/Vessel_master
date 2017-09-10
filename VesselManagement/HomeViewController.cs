using System;
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
             //showPicker();
			this.NavigationController.NavigationBar.Hidden = false;
			tblView.RegisterNibForCellReuse(TripCell.Nib, "TripCell");
			tblView.Layer.BorderColor = new CoreGraphics.CGColor (22f, 175f, 202f);
			tblView.TableFooterView = new UIView();
			tblView.Source = new TripsTableSource(this);
		}

		public void showPicker()
		{
			//pickerView = new UIPickerView(new CGRect(UIScreen.MainScreen.Bounds.X, UIScreen.MainScreen.Bounds.Height -230, UIScreen.MainScreen.Bounds.Width, 180));
			//pickerView.ShowSelectionIndicator = true;

			//// create done button
			//UIButton done = new UIButton(new CGRect(pickerView.Frame.X, pickerView.Frame.Y - 50, UIScreen.MainScreen.Bounds.Width, 50));
			//done.BackgroundColor = UIColor.Purple;
			//done.SetTitle("Department List", UIControlState.Normal);

			//PickerDataModel picker = new PickerDataModel(); 
			//picker.Items.Add("Blue");
 		//	picker.Items.Add("Red");
			//picker.Items.Add("Purple");
			//picker.Items.Add("White");

			//picker.ValueChanged += (s, e) =>
			//{
			//};
			//pickerView.Model = picker;

			//View.AddSubviews(pickerView, done);
		}
	}
}

