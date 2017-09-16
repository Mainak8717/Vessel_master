using System;

using Foundation;
using UIKit;

namespace VesselManagement
{
	public partial class BottomTableViewCell : UITableViewCell
	{
		public static readonly NSString Key = new NSString("BottomTableViewCell");
		public static readonly UINib Nib;

		static BottomTableViewCell()
		{
			Nib = UINib.FromName("BottomTableViewCell", NSBundle.MainBundle);
		}

		protected BottomTableViewCell(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}
		public BottomTableViewCell(string reuseIdentifier) : base(UITableViewCellStyle.Default, reuseIdentifier){

		}
	}
}
