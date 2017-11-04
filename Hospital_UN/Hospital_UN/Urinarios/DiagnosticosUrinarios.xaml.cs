using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hospital_UN.Urinarios
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DiagnosticosUrinariosPage : ContentPage
	{
		public DiagnosticosUrinariosPage ()
		{
            Title = MainPage.THE_TITLE;
			InitializeComponent ();
		}

        public void OnCistitisClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Cistitis.CistitisPage());
        }

        public void OnPielonefritisClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pielonefritis.PielonefritisPage());
        }

    }
}