using AdsPCL;
using GoogleAds;
using WinPhone.CustomRenders;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WinPhone;

[assembly: ExportRenderer(typeof(AdsPCL.MyBanner), typeof(CustomBannerRenderer))]
namespace WinPhone.CustomRenders
{
    public class CustomBannerRenderer : ViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<View> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                AdView bannerAd = new AdView
                {
                    Format = AdFormats.Banner,
					AdUnitID = "ca-app-pub-8228485892439970/3183360843",
                };
                AdRequest adRequest = new AdRequest();
                bannerAd.LoadAd(adRequest);
                Children.Add(bannerAd);
            }
        }
    }
}
