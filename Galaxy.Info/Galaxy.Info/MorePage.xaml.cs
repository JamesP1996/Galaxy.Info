using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Galaxy.Info
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MorePage : ContentPage
	{
		public MorePage ()
		{
            InitializeComponent();
            
			
		}

        private void ApplyUserName_Clicked(object sender, EventArgs e)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
            string filename = Path.Combine(path, "UserName.txt");

            using (var streamWriter = new StreamWriter(filename,false))
            {
                streamWriter.WriteLine(userN.Text);
                streamWriter.Close();
            }
        }
    }
}