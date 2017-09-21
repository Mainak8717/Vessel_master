using System;
using System.Collections.Generic;
using UIKit;

namespace VesselManagement
{
	public partial class TripDetailsVC : BaseVC
	{
		public TripModel model;
		public TripDetails tripDetails;
		public TripDetailsVC(TripModel tripModel) : base("TripDetailsVC")
		{
			model = tripModel;
			HamburgerMenuRequired = false;
			BackButtonRequired = true;
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			setDetailValues(getTripDetails());

			switch (AppDelegate.typeOfUser)
			{
				case "Manager":
					{ 
						firstButton.Hidden = false;
						firstButton.SetTitle("Manage Vendors", UIControlState.Normal);
						secondButton.Hidden = false;
						secondButton.SetTitle("Enter PSA DATA", UIControlState.Normal);
						thirdButton.Hidden = false;
						thirdButton.SetTitle("Manage Boat Agents", UIControlState.Normal);
						fourthButton.Hidden = false;
						fourthButton.SetTitle("Manage Boats", UIControlState.Normal);
						fourthButton.TouchUpInside += (sender, e) => { 
                             this.NavigationController.PushViewController(new ManageVC_1("Agency"),true);
						};
						secondButton.TouchUpInside += (sender, e) => { 
							this.NavigationController.PushViewController(new ManageVC_2(),true);
						};
						thirdButton.TouchUpInside += (sender, e) => { 
							this.NavigationController.PushViewController(new ManageVC_1("BoatAgent"),true);
						};
						firstButton.TouchUpInside += (sender, e) => { 
							this.NavigationController.PushViewController(new ManageVC(),true);
						};
					}
					break;
				case "Agency":
					{
						firstButton.Hidden = false;
						firstButton.SetTitle("Manage Agencies", UIControlState.Normal);
						secondButton.Hidden = false;
						secondButton.SetTitle("Manage Vendors", UIControlState.Normal);
						thirdButton.Hidden = false;
						thirdButton.SetTitle("Manage Boat Agents", UIControlState.Normal);
						fourthButton.Hidden = false;
						fourthButton.SetTitle("Manage Boats", UIControlState.Normal);

						firstButton.TouchUpInside += (sender, e) => { 

							 this.NavigationController.PushViewController(new ManageVC_1("Agency"),true);
						};
						secondButton.TouchUpInside += (sender, e) => { 
							this.NavigationController.PushViewController(new ManageVC_2(),true);
						};
						thirdButton.TouchUpInside += (sender, e) => { 
							this.NavigationController.PushViewController(new ManageVC_1("BoatAgent"),true);
						};
						fourthButton.TouchUpInside += (sender, e) => { 
							this.NavigationController.PushViewController(new ManageVC(),true);
						};
					}
					break;
				case "Charterer":
					{ 
						firstButton.Hidden = false;
						firstButton.SetTitle("Manage Agencies", UIControlState.Normal);
						secondButton.Hidden = true;
						thirdButton.Hidden = true;
						fourthButton.Hidden = true;

						firstButton.TouchUpInside += (sender, e) => { 

							 this.NavigationController.PushViewController(new ManageVC_1("Agency"),true);
						};
					}
					break;
				case "Vendor":
					{ 
						firstButton.Hidden = false;
						firstButton.TitleLabel.Text = "Manage Agencies";
						secondButton.Hidden = true;
						thirdButton.Hidden = true;
						fourthButton.Hidden = true;
					}
					break;
			}
		}
		public TripDetails getTripDetails()
		{
			
			 tripDetails = new TripDetails(model.TripId,"123456789", "MMSI001", "Mainak Choudhury", "31-12-2017","08-04-2018","17-Aug-2017 04:22 PM",
			                               "ACTIVE","Cargo","16:23","12:50","02:55","01:45","12:45","16:26","12:50","16:25");
			return tripDetails;
		}
		public void setDetailValues(TripDetails details)
		{
			IMO.Text = details.IMO;
			MMSI.Text = details.MMSI;
			MASTER.Text = details.Master;
			STARTDATE.Text = details.StartDate;
			ENDDATE.Text = details.EndDate;
			ETACALC.Text = details.ETACalculated;
			CURRENTSTATUS.Text = details.CurrentStatus;
			VESSEL.Text = details.VesselType;
			NT_Time.Text = details.NT;
			GT_Time.Text = details.GT;
			LOA_Time.Text = details.LOA;
			LBP_Time.Text = details.LBP;
			BREADTH_Time.Text = details.Breadth;
			FWD_Time.Text = details.FwdDraft;
			AFT_Time.Text = details.AftDraft;
			MAXDRAFT_time.Text = details.MaxSummerDraft;
			TRIPID.Text ="Trip Id:" + model.TripId;
			SOURCE.Text ="From: " + model.Source;
			DESTINATION.Text ="To: "+ model.Destination;

		}
		public override void ViewDidLayoutSubviews()
		{
			scrollView.ContentSize = new CoreGraphics.CGSize(View.Frame.Width, firstButton.Frame.Y + firstButton.Frame.Size.Height + 200);

		}
	}
}

