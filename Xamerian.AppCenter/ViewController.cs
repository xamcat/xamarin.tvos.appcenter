using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;
using XamCat.AppCenter.tvOS;

namespace Xamerian.AppCenter
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var button = new UIButton(UIButtonType.System);
            button.Frame = new CGRect(25, 25, 300, 150);
            button.SetTitle("Event Me!", UIControlState.Normal);
            button.AllEvents += Button_AllEvents;


            var button2 = new UIButton(UIButtonType.System);
            button2.Frame = new CGRect(400, 25, 300, 150);
            button2.SetTitle("Crash Me!", UIControlState.Normal);
            button2.AllEvents += Button2_AllEvents;


            this.View.AddSubview(button);
            this.View.AddSubview(button2);
            MSAnalytics.TrackEvent("XAMARIN TVOS VIEW LOAD");
            // Perform any additional setup after loading the view, typically from a nib.
        }

        private void Button2_AllEvents(object sender, EventArgs e)
        {
            MSAnalytics.TrackEvent("XAMARNTRACK CrashButton BOOM");
            MSCrashes.GenerateTestCrash();
        }

        private void Button_AllEvents(object sender, EventArgs e)
        {
            MSAnalytics.TrackEvent("XAMARNTRACK BUTTONCLICK EEE");
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

