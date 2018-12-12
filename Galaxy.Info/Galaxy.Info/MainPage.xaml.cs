using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.IO;


namespace Galaxy.Info
{
   
    public partial class MainPage : ContentPage
    {
        public string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
        

        public MainPage()
        {
            InitializeComponent();
        string filename = Path.Combine(path, "UserName.txt");




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

        private void MarsTapped(object sender, EventArgs e)
        {
            App.Current.MainPage = new MarsPage();
        }

        private void JupiterTapped(object sender, EventArgs e)
        {
            App.Current.MainPage = new JupiterPage();
        }

        private void SaturnTapped(object sender, EventArgs e)
        {
            App.Current.MainPage = new SaturnPage();
        }

        private void UranusTapped(object sender, EventArgs e)
        {
            App.Current.MainPage = new UranusPage();
        }

        private void NeptuneTapped(object sender, EventArgs e)
        {
            App.Current.MainPage = new NeptunePage();
        }

        private void MoreTapped(object sender, EventArgs e)
        {
            App.Current.MainPage = new MorePage();
        }
    }
}
