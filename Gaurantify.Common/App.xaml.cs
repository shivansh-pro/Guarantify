using Gaurantify.Common.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Gaurantify.Common
{
    public partial class App : Application
    {
        public App()
        {
            //this.LoadFromXaml(typeof(App));
            //InitializeComponent();

            SetMainPage();
        }

        public static void SetMainPage()
        {
            Current.MainPage = new TabbedPage
            {
                Children =
                {
                    new NavigationPage(new ScanPage())
                    {
                        Title = "Barcode Scanner",
                        Icon = Device.OnPlatform("tab_feed.png",null,null)
                    },

                }
            };
        }
    }
}
