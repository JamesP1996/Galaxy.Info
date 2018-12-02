using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Galaxy.Info
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EarthPage : ContentPage
	{
		public EarthPage ()
		{
			InitializeComponent ();
		}
        private void FindMoreInfoBT(object sender, EventArgs e)
        {
            var url = "https://en.wikipedia.org/wiki/Earth";
            Device.OpenUri(new Uri(url));
        }

        protected override bool OnBackButtonPressed()
        {
            App.Current.MainPage = new MainPage();
            return base.OnBackButtonPressed();
        }
        private void BackButtonClicked(object sender, EventArgs e)
        {

            App.Current.MainPage = new MainPage();

        }
    }
}