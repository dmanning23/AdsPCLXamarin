using AdsPCL;
using AdsPCL.iOS;
using GoogleAdMobAds;
using MonoTouch.UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(AdsPCL.MyBanner), typeof(CustomBannerRenderer))]
namespace AdsPCL.iOS
{
    public class CustomBannerRenderer : ViewRenderer
    {
		GADBannerView adView;
		bool viewOnScreen = false;
		protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.View> e)
		{
			base.OnElementChanged(e);

			adView = new GADBannerView(size: GADAdSizeCons.Banner)//, origin: new PointF(0, 0))
			{
				AdUnitID = "ca-app-pub-8228485892439970/3183360843",
				RootViewController = UIApplication.SharedApplication.Windows[0].RootViewController
			};

			adView.AdReceived += (sender, args) =>
			{
				if (!viewOnScreen) this.AddSubview(adView);
				viewOnScreen = true;
			};

			adView.LoadRequest(GADRequest.Request);
			base.SetNativeControl(adView);
		}
    }
}