// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace VesselManagement
{
	[Register ("LoginVC")]
	partial class LoginVC
	{
		[Outlet]
		UIKit.UITextField passwordTextField { get; set; }

		[Outlet]
		UIKit.UIButton submitBtn { get; set; }

		[Outlet]
		UIKit.UITextField usernameTxtField { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (usernameTxtField != null) {
				usernameTxtField.Dispose ();
				usernameTxtField = null;
			}

			if (passwordTextField != null) {
				passwordTextField.Dispose ();
				passwordTextField = null;
			}

			if (submitBtn != null) {
				submitBtn.Dispose ();
				submitBtn = null;
			}
		}
	}
}
