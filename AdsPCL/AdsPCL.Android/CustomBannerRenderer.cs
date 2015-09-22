using AdsPCL;
using Android.CustomRenders;
using Android.Gms.Ads;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using System;

[assembly: ExportRenderer(typeof(MyBanner), typeof(CustomBannerRenderer))]
namespace Android.CustomRenders
{
	public class CustomBannerRenderer : ViewRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<View> e)
		{
			base.OnElementChanged(e);

			try
			{
				if (e.OldElement == null)
				{
					AdView ad = new AdView(this.Context);
					ad.AdSize = AdSize.Banner;
					ad.AdUnitId = "ca-app-pub-8228485892439970/3183360843";
					var requestbuilder = new AdRequest.Builder();

					//This line throws Java.Lang.NoClassDefFoundError ???
					ad.LoadAd(requestbuilder.Build());

					this.SetNativeControl(ad);
				}
			}
			catch (Exception ex)
			{
			}
		}
	}
}
