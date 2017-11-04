using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hospital_UN.Urinarios.Pielonefritis.SI
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ShockSepticoPage : ContentPage
	{
		public ShockSepticoPage ()
		{
            Title = MainPage.THE_TITLE;
			InitializeComponent ();
		}

        public void OnSIClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ShockSepticoSIPage());
        }

        public void OnNOClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ShockSepticoNOPage());
        }

        public void OnSospechaClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EnterococoPage());
        }

    }
}