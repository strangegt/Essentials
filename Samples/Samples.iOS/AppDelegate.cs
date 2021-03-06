﻿using Foundation;
using Microsoft.AppCenter.Distribute;
using UIKit;

namespace Samples.iOS
{
    [Register(nameof(AppDelegate))]
    public partial class AppDelegate : Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            Xamarin.Forms.Forms.Init();
            Distribute.DontCheckForUpdatesInDebug();
            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
