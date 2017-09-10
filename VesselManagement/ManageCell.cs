using System;

using Foundation;
using UIKit;

namespace VesselManagement
{
	public partial class ManageCell : UITableViewCell
	{
		public static readonly NSString Key = new NSString("ManageCell");
		public static readonly UINib Nib;

		static ManageCell()
		{
			Nib = UINib.FromName("ManageCell", NSBundle.MainBundle);
		}

		protected ManageCell(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}
		public ManageCell(string reuseIdentifier) : base(UITableViewCellStyle.Default, reuseIdentifier){   }
	}
}
