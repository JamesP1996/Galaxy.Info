using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Galaxy.Info
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

        private void ToolbarItem_Activated(object sender, EventArgs e)
        {

        }

        private void MercuryTapped(object sender, EventArgs e)
        {
            App.Current.MainPage = new MercuryPage();

        }

        private void VenusTapped(object sender, EventArgs e)
        {
            App.Current.MainPage = new VenusPage();
        }

        private void EarthTapped(object sender,EventArgs e)
        {
            App.Current.MainPage = new EarthPage();

        }
    }
}
