using System;

using UIKit;

namespace VesselManagement
{
	public partial class LoginVC : BaseVC
	{

		public LoginVC(bool backButton, bool hamburgerMenu) : base("LoginVC")
		{
			HamburgerMenuRequired = hamburgerMenu;
			BackButtonRequired = backButton;
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			this.NavigationController.NavigationBar.Hidden = true;
			this.submitBtn.TouchUpInside += (sender, e) =>
			{
				AppDelegate.typeOfUser = usernameTxtField.Text;
				BaseNavigationController nav =
					new BaseNavigationController(new HomeViewController(false,true));


				MainDelegate.MainNavController = nav;
				MainDelegate.Window.RootViewController = MainDelegate.MainNavController;
			};
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

