using Microsoft.Phone.Controls;
using Xamarin.Forms;

namespace AdsPCL.WinPhone
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();

            Forms.Init();
            Content = AdsPCL.App.GetMainPage().ConvertPageToUIElement(this);
        }
    }
}
