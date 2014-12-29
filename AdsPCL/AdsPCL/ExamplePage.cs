using Xamarin.Forms;

namespace AdsPCL
{
    public class ExamplePage : ContentPage
    {
        public ExamplePage()
        {
            var Title = new Label
            {
                Text = "Advertising Example for Cross Platform",
            };

            var myBanner = new MyBanner();

            Content = new StackLayout
            {
                Children = { Title, myBanner }
            };
        }
    }
}
