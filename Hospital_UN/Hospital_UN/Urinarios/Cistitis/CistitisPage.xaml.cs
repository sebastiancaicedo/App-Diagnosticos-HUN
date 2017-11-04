using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hospital_UN.Urinarios.Cistitis
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CistitisPage : ContentPage
	{
		public CistitisPage ()
		{
            Title = MainPage.THE_TITLE;
			InitializeComponent ();
		}

        public void OnSIClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CistitisSIPage());
        }

        public void OnNOClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CistitisNOPage());
        }
	}
}