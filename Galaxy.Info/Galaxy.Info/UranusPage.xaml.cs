﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Galaxy.Info
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UranusPage : ContentPage
	{
		public UranusPage ()
		{
			InitializeComponent ();
		}

        private void MoreInfoClicked(object sender, EventArgs e)
        {
            var url = "https://en.wikipedia.org/wiki/Uranus";
            Device.OpenUri(new Uri(url));
        }


       
       
    }
}