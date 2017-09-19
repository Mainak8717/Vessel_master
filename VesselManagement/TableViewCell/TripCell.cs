using System;

using Foundation;
using UIKit;

namespace VesselManagement
{
	public partial class TripCell : UITableViewCell
	{
		public static readonly NSString Key = new NSString("TripCell");
		public static readonly UINib Nib;

		static TripCell()
		{
			 Nib = UINib.FromName("TripCell", NSBundle.MainBundle);
		}
		protected TripCell(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}
		public TripCell(string reuseIdentifier) : base(UITableViewCellStyle.Default, reuseIdentifier){
			
         }
	}
}
