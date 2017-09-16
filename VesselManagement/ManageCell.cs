using System;

using Foundation;
using UIKit;

namespace VesselManagement
{
	public partial class ManageCell : UITableViewCell
	{
		public static readonly NSString Key = new NSString("ManageCell");
		public static readonly UINib Nib;
		public ManageVC owner;

		static ManageCell()
		{
			Nib = UINib.FromName("ManageCell", NSBundle.MainBundle);
		}

		protected ManageCell(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}
		public ManageCell(string reuseIdentifier, ManageVC instanceClass) : base(UITableViewCellStyle.Default, reuseIdentifier){

			owner = instanceClass;
			manageCellSearchButton.TouchUpInside += (sender, e) =>
			{
				owner.NavigationController.PresentModalViewController(new SearchVC("vendor List"), true);
			};
		}
		public void updateManageCellFields(string valueSelected,string labelText,ManageVC instance, bool hideButton)
		{
			if (labelText.Equals("Vendor") && !string.IsNullOrEmpty(valueSelected))
				manageCellTextField.Text = valueSelected;
			manageCellSearchButton.Hidden = hideButton;
			manageCellLabel.Text = labelText;
			owner = instance;
		}
		partial void searchBtnAction(NSObject sender)
		{
			owner.NavigationController.PresentModalViewController(new SearchVC("Vendors List"), true);
		}
	}
}
