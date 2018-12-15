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
       
     

        public MainPage()
        {
            InitializeComponent();
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
            string filename = Path.Combine(path, "name.txt");
            if (!File.Exists(filename))
            {
                File.Create(filename).Dispose();
            }
            else
            {
                using (var streamReader = new StreamReader(filename))
                {
                    string content = streamReader.ReadToEnd();
                    System.Diagnostics.Debug.WriteLine(content);
                    UsrName.Text = ("Welcome to Galaxy.io " + content); 

                }
            }



    }




     async void MercuryTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MercuryPage());

        }

     async void VenusTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VenusPage());
        }

     async void EarthTapped(object sender,EventArgs e)
        {
            await Navigation.PushAsync(new EarthPage());
            

        }

     async void MarsTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MarsPage());
        }

     async void JupiterTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new JupiterPage());
        }

      async void SaturnTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SaturnPage());
        }

       async void UranusTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UranusPage());
        }

       async void NeptuneTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NeptunePage());
        }

        async void MoreTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MorePage());
        }
            public string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));

        private void SaveBt_Clicked(object sender, EventArgs e)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
            string filename = Path.Combine(path, "name.txt");


            using (var streamWriter = new StreamWriter(filename))
            {
                streamWriter.WriteLine(usrEntry.Text);
                streamWriter.Close();
            }

            using (var streamReader = new StreamReader(filename))
            {
                string content = streamReader.ReadToEnd();
                System.Diagnostics.Debug.WriteLine(content);
                UsrName.Text =("Welcome to Galaxy.io " + content);

            }
        }
    }
}
