using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hospital_UN.Urinarios.Pielonefritis
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PielonefritisPage : ContentPage
	{
		public PielonefritisPage ()
		{
            Title = MainPage.THE_TITLE;
			InitializeComponent ();
		}

        public void OnSIClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PielonefritisSIPage());
        }

        public void OnNOClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PielonefritisNOPage());
        }
	}
}